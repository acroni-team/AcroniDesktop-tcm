using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace login_v1._0
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        Point lastPoint;
        private void lblFund_MouseDown(object sender, MouseEventArgs e)
        {
           lastPoint = new Point(e.X, e.Y);
        }
        private void lblFund_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { this.Left += e.X - lastPoint.X; this.Top += e.Y - lastPoint.Y; }

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            txt1.Focus();
            txt1.ForeColor = Color.Gray;

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            txt2.Focus();
            txt2.ForeColor = Color.Gray;

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible == false)
            {
                if (txt1.Text == "Filipe" && txt2.Text == "filipe")
                {
                    Application.Exit();
                }
                else
                {
                    txt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
                    txt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
                }
            }
            else
            {
                panel3.Visible = false;
                panel3.Location = new System.Drawing.Point(14, 12);
                btnEntrar.Location = new System.Drawing.Point(536, 339);
                btnSair.Location = new System.Drawing.Point(691, 339);
            }
        }

        private void txt1_Enter(object sender, EventArgs e)
        {
            if (txt1.ForeColor == System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76))))))
            {
                txt1.Text = "";
            }
            txt1.ForeColor = Color.Gray;
            if(txt1.Text == "Usuário")
            {
                txt1.Text = "";
            }
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void txt2_Enter(object sender, EventArgs e)
        {
            if (txt2.ForeColor == System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76))))))
            {
                txt2.Text = "";
            }

            txt2.ForeColor = Color.Gray;
            if (txt2.Text == "Senha")
            {
                txt2.Text = "";
                txt2.PasswordChar = '•';
            }
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            
            panel3.Visible = true;
            panel3.Location = new System.Drawing.Point(536, 339);
            btnEntrar.Location = new System.Drawing.Point(536, 406);
            btnSair.Location = new System.Drawing.Point(691, 406);

            
            
            
            
        }

        private void lblFund_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("C:/Users/Filipe/Desktop/Projetos/Qanelas Soft/Fontes/TTF/Qanelas-Bold.ttf");
            pfc.AddFontFile("C:\\Users\\Filipe\\Desktop\\Projetos\\Sites\\.COWFFEE NEW\\FONTES\\openregular.ttf");

            label3.Font = new Font(pfc.Families[1], 21, FontStyle.Regular);
            label4.Font = new Font(pfc.Families[0], 9, FontStyle.Regular);
            btnEntrar.Font = new Font(pfc.Families[0], 11, FontStyle.Regular);
            btnSair.Font = new Font(pfc.Families[0], 11, FontStyle.Regular);
        }

        private void txt1_Leave(object sender, EventArgs e)
        {
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            if(txt1.Text == "")
            {
                txt1.Text = "Usuário";
            }
        }

        private void txt2_Leave(object sender, EventArgs e)
        {
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            if (txt2.Text == "")
            {
                txt2.Text = "Senha";
                txt2.PasswordChar = '\0';
            }
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.ForeColor == System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76))))))
            {
                textBox1.Text = "";
            }
            textBox1.ForeColor = Color.Gray;
            if (textBox1.Text == "Confirmar senha")
            {
                textBox1.Text = "";
                textBox1.PasswordChar = '•';
            }
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            if(txt1.Text != "Usuário")
            {
                txt1.Text = "Usuário";
                txt1.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            if (textBox1.Text == "")
            {
                textBox1.Text = "Confirmar senha";
                textBox1.PasswordChar = '\0';
            }
        }
    }
}
