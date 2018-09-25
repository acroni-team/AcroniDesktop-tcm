using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using AcroniLibrary;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AcroniUI.LoginAndSignUp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            apnlEsquerdo.BackgroundImage = null;
            apnlEsquerdo.BackColor = Color.FromArgb(0,147,255);
        }

        #region Ações dos botões do menuStrip

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Métodos para transição de cores dos botões do menu

        private void btnSair_MouseMove(object sender, MouseEventArgs e)
        {
            btnSair.BackColor = Color.FromArgb(244, 134, 134);
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.FromArgb(238, 63, 63);
        }

        #endregion

        #region Objetos do banco
        //Usuário para lançar o script do banco: (Usuário: Acroni, Senha: acroni7)
        SqlConnection conexão_SQL = new SqlConnection(Conexao.nome_conexao);
        SqlCommand comando_SQL;
        #endregion

        #region Methods of Design
        static Form layerFadeForm = new Form();
        private Form GetLayerForm()
        {
            layerFadeForm.Dock = DockStyle.Fill;
            layerFadeForm.Size = new Size(1280, 720);
            layerFadeForm.FormBorderStyle = FormBorderStyle.None;
            layerFadeForm.Opacity = 0;
            layerFadeForm.BackColor = Color.FromArgb(44, 47, 55);
            layerFadeForm.Tag = "hidden";
            layerFadeForm.Show();
            layerFadeForm.Location = new Point(this.Location.X, this.Location.Y);
            return layerFadeForm;
        }

        private void ChangeReferencesOnError(ref Label label, Color backColor, ref Panel panel, ref Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox, String Errorlabel)
        {
            label.Text = Errorlabel;
            label.ForeColor = backColor;
            panel.CreateGraphics().DrawRectangle(new Pen(backColor, 3), 0, 0, panel.Width - 1, panel.Height - 1);
            //panel.BackColor = Color.Firebrick;
            bunifuMaterialTextbox.BackColor = Color.FromArgb(44, 47, 55);
        }

        private bool hasEmptyRegisters()
        {
            bool returnMethod = false; String controlName; //Para pegar o nome do atributo errado e dar focus nele
            foreach (Control control in pnlCadastro.Controls)
            {
                if (control is Panel)
                {
                    if (String.IsNullOrEmpty(control.GetNextControl(new Label(), true).Text))
                    {
                        returnMethod = true;
                        controlName = control.GetNextControl(new Label(), true).Name;
                        break;
                    }
                }
            }
            return returnMethod;
        }
        #endregion

        #region Timers
        private void TimerSlide_Tick(object sender, EventArgs e)
        {
            pnlCadastro.Parent.Invalidate();
            if (pnlCadastro.Tag.ToString().Equals("Closed"))
            {
                TimerSlide.Interval = 10;
                pnlCadastro.Location = new Point(pnlCadastro.Location.X - 10, 0);
                apnlEsquerdo.Location = new Point(apnlEsquerdo.Location.X - 10, 0);
                pnlLogoCad.Location = new Point(-15, 0);
                if (pnlCadastro.Location.X == 0)
                {
                    TimerSlide.Stop();
                    pnlCadastro.Tag = "Open";

                }
            }
            else if (pnlCadastro.Tag.ToString().Equals("Open"))
            {
                TimerSlide.Interval = 1;
                pnlCadastro.Location = new Point(pnlCadastro.Location.X + 10, 0);
                apnlEsquerdo.Location = new Point(apnlEsquerdo.Location.X + 10, 0);
                pnlLogoCad.Location = new Point(490, 0);
                if (pnlCadastro.Location.X == 790)
                {
                    TimerSlide.Stop();
                    pnlCadastro.Tag = "Closed";
                }
            }                      
        }


        private void TimerFade_Tick(object sender, EventArgs e)
        {
            if (layerFadeForm.Tag.Equals("hidden"))
            {
                layerFadeForm.Opacity += 0.1;
                if (layerFadeForm.Opacity == 0.7)
                {
                    TimerFade.Stop();
                    layerFadeForm.Tag = "open";
                }
            }
            else if (layerFadeForm.Tag.Equals("open"))
            {
                layerFadeForm.Opacity -= 0.1;
                if (layerFadeForm.Opacity == 0)
                {
                    TimerFade.Stop();
                    layerFadeForm.Tag.Equals("hidden");
                }
            }
        }
        #endregion

        SelectKeyboard selecionarTeclado;

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                //--Abrindo a conexão
                if (conexão_SQL.State != ConnectionState.Open)
                    conexão_SQL.Open();

                //--Criando um comando SELECT e chamando sua resposta
                String select_usuario = "SELECT usuario FROM tblCliente WHERE usuario='" + txtEntrar.Text + "'";
                comando_SQL = new SqlCommand(select_usuario, conexão_SQL);
                SqlDataReader resposta_usuario = comando_SQL.ExecuteReader();

                //--Checando se houve algum valor que retornou
                if (resposta_usuario.HasRows)
                {
                    resposta_usuario.Close();
                    try
                    {
                        //--Abrindo a conexão
                        if (conexão_SQL.State != ConnectionState.Open)
                            conexão_SQL.Open();

                        //--Criando um comando SELECT e chamando sua resposta
                        String select = "SELECT senha FROM tblCliente WHERE usuario='" + txtEntrar.Text + "'";
                        comando_SQL = new SqlCommand(select, conexão_SQL);
                        SqlDataReader resposta = comando_SQL.ExecuteReader();

                        //--Checando se houve algum valor que retornou
                        if (resposta.HasRows)
                        {
                            //--Lendo a resposta
                            resposta.Read();

                            //Para pegar os valores, trate a resposta como uma Array
                            if (resposta[0].ToString().Equals(txtSenha.Text))
                            {
                                Conexao.nome_usuario = txtEntrar.Text;
                                selecionarTeclado = new SelectKeyboard();
                                selecionarTeclado.Show();
                                this.Hide();
                            }
                            else
                            {
                                pnlQueDesce.Location = new Point(68, 460);
                                lblAviso.Text = "A senha está incorreta.";
                                lblAviso.Visible = true;
                                resposta.Close();
                            }
                        }
                        else
                        {
                            pnlQueDesce.Location = new Point(68, 460);
                            lblAviso.Text = "A senha está incorreta.";
                            lblAviso.Visible = true;
                            resposta.Close();
                        }

                        //--Fechando a conexão
                        conexão_SQL.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        conexão_SQL.Close();
                    }
                }
                else
                {
                    pnlQueDesce.Location = new Point(68, 460);
                    lblAviso.Text = "Este usuário não existe.";
                    lblAviso.Visible = true;
                    resposta_usuario.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexão_SQL.Close();
            }
        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void lnklblEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pnlCadastro.Tag.Equals("Closed"))
                TimerSlide.Start();
            AcceptButton = btnCadastrar;
        }

        private void pnlVisibiladade_Click(object sender, EventArgs e)
        {
            if (((Panel)sender).Equals(pnlVisibiladade))
            {
                if (pnlVisibiladade.Tag.Equals("false"))
                {
                    pnlVisibiladade.BackgroundImage = new Bitmap(AcroniUI.Properties.Resources.olho);
                    txtSenha.isPassword = false;
                    pnlVisibiladade.Tag = "true";
                }
                else
                {
                    pnlVisibiladade.BackgroundImage = new Bitmap(AcroniUI.Properties.Resources.olhoblock);
                    txtSenha.isPassword = true;
                    pnlVisibiladade.Tag = "false";
                }
            }else if (((Panel)sender).Equals(pnlVisibilidadeCadSenha))
            {
                if(pnlVisibilidadeCadSenha.Tag.Equals("false"))
                {
                    pnlVisibilidadeCadSenha.BackgroundImage = new Bitmap(AcroniUI.Properties.Resources.olho);
                    txtCadPass.isPassword = false;
                    pnlVisibilidadeCadSenha.Tag = "true";
                }else
                {
                    pnlVisibilidadeCadSenha.BackgroundImage = new Bitmap(AcroniUI.Properties.Resources.olhoblock);
                    txtCadPass.isPassword = true;
                    pnlVisibilidadeCadSenha.Tag = "false";
                }
            }else
            {
                if (pnlVisibiladadeRepSenha.Tag.Equals("false"))
                {
                    pnlVisibiladadeRepSenha.BackgroundImage = new Bitmap(AcroniUI.Properties.Resources.olho);
                    txtCadRepPass.isPassword = false;
                    pnlVisibiladadeRepSenha.Tag = "true";
                }
                else
                {
                    pnlVisibiladadeRepSenha.BackgroundImage = new Bitmap(AcroniUI.Properties.Resources.olhoblock);
                    txtCadRepPass.isPassword = true;
                    pnlVisibiladadeRepSenha.Tag = "false";
                }
            }
        }

        private void txtBoxesLogin_OnValueChanged(object sender, EventArgs e)
        {
            pnlQueDesce.Location = new Point(68, 438);
            pnlShowCadError.Location = new Point(94, 508);
            Bunifu.Framework.UI.BunifuMaterialTextbox b = (Bunifu.Framework.UI.BunifuMaterialTextbox)sender;
            if (b.Name.Contains("Senha") && pnlVisibiladade.Tag.Equals("false"))
                txtSenha.isPassword = true;
            if (b.Name.Contains("CadPass") && pnlVisibilidadeCadSenha.Tag.Equals("false"))
                txtCadPass.isPassword = true;
            if (b.Name.Contains("RepPass") && pnlVisibiladadeRepSenha.Tag.Equals("false"))
                txtCadRepPass.isPassword = true;
        }

        private void txtBoxesCad_OnValueChanged(object sender, EventArgs e) => pnlShowCadError.Location = new Point(94, 508);
        
        private void ChangeMessagelblAviso(String message)
        {
            lblAvisoCad.Text = message;
            pnlShowCadError.Location = new Point(apnlApelido.Location.X, 510);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (hasEmptyRegisters())
                ChangeMessagelblAviso($"Ainda há registros vazios!");
            else
            {
                if (SQLMethods.SELECT_HASROWS($"SELECT usuario FROM tblCliente WHERE usuario LIKE '{txtCadApelido.Text}'"))
                    ChangeMessagelblAviso($"O apelido já existe!");
                else
                {
                    if (!Regex.IsMatch(txtCadEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                        ChangeMessagelblAviso($"O email {txtCadEmail.Text} não está correto");
                    else
                    {
                        if (SQLMethods.SELECT_HASROWS($"SELECT email FROM tblCliente WHERE email LIKE '{txtCadEmail.Text}'"))
                            ChangeMessagelblAviso($"O email {txtCadEmail.Text} existe em OUTRA conta");
                        else
                        {
                            if (!txtCadPass.Text.Equals(txtCadRepPass.Text))
                                ChangeMessagelblAviso("As senhas estão erradas");
                            else
                            { 
                                this.AddOwnedForm(GetLayerForm());
                                TimerFade.Start();
                                FrmConfirmarEmail confirm = new FrmConfirmarEmail(txtCadUser.Text, txtCadApelido.Text, txtCadPass.Text, txtCadEmail.Text, txtCadCPF.Text, "cadastro");
                                if (confirm.IsDisposed)
                                    TimerFade.Start();
                                else {
                                    confirm.ShowDialog();
                                    if (FrmConfirmarEmail.atualizacao_SUCCESS)
                                    {
                                        if (!File.Exists(Application.StartupPath + "\\" + Conexao.nome_usuario + ".acr"))
                                        {
                                            using (FileStream savearchive = new FileStream(Application.StartupPath + @"\" + Conexao.nome_usuario + ".acr", FileMode.Create))
                                            {
                                                BinaryFormatter Serializer = new BinaryFormatter();
                                                Serializer.Serialize(savearchive, CompartilhaObjetosUser.user);
                                            }
                                        }
                                        (new SelectKeyboard()).Show();
                                        this.Hide();
                                        Conexao.nome_usuario = txtEntrar.Text;
                                        // Checa se existe o arquivo, e se não existe, cria - o
                                    } else
                                    {
                                        TimerFade.Start();
                                        ChangeMessagelblAviso("Cadastro não concluído");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AcceptButton = btnEntrar;
            if (pnlCadastro.Tag.Equals("Open"))
                TimerSlide.Start();
        }

        private void OnLeaveValidation(object sender, EventArgs e)
        {
            if (((Bunifu.Framework.UI.BunifuMaterialTextbox)sender).Equals(txtCadApelido))
            {
                if (SQLMethods.SELECT_HASROWS($"SELECT usuario FROM tblCliente WHERE usuario LIKE '{txtCadApelido.Text}'"))
                    ChangeReferencesOnError(ref alblApelido, Color.Firebrick, ref apnlApelido, ref txtCadUser, $"O apelido {txtCadApelido.Text} já existe!");
                else
                {
                    ChangeReferencesOnError(ref alblApelido, Color.FromArgb(98, 118, 125), ref apnlApelido, ref txtCadUser, "Apelido");
                    apnlApelido.CreateGraphics().Clear(Color.FromArgb(44, 47, 55));
                }
            }
            else if (((Bunifu.Framework.UI.BunifuMaterialTextbox)sender).Equals(txtCadEmail))
            {
                if (!Regex.IsMatch(txtCadEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                    ChangeReferencesOnError(ref alblEmail, Color.Firebrick, ref apnlEmail, ref txtCadEmail, $"O email está com formato incorreto!");
                else if (SQLMethods.SELECT_HASROWS($"SELECT email FROM tblCliente WHERE email LIKE '{txtCadEmail.Text}'"))
                    ChangeReferencesOnError(ref alblEmail, Color.Firebrick, ref apnlEmail, ref txtCadEmail, $"O email já existe em outra conta!");
                else
                {
                    ChangeReferencesOnError(ref alblEmail, Color.FromArgb(98, 118, 125), ref apnlEmail, ref txtCadEmail, "Email");
                    apnlEmail.CreateGraphics().Clear(Color.FromArgb(44, 47, 55));
                }
            }
            else if (((Bunifu.Framework.UI.BunifuMaterialTextbox)sender).Equals(txtCadCPF))
            {
                if (!ValidationOF.CPF(txtCadCPF.Text))
                    ChangeReferencesOnError(ref alblCPF, Color.Firebrick, ref apnlCPF, ref txtCadCPF, $"O CPF não existe!!");
                else
                {
                    ChangeReferencesOnError(ref alblCPF, Color.FromArgb(98, 118, 125), ref apnlCPF, ref txtCadCPF, "CPF");
                    apnlCPF.CreateGraphics().Clear(Color.FromArgb(44, 47, 55));
                }
            }

        }
    }
}