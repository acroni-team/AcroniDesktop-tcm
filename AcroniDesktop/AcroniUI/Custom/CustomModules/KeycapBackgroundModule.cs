using AcroniControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcroniUI.Custom.CustomModules
{
    public partial class KeycapBackgroundModule : KeycapParentModule
    {
        private string __imageName { get; set; }

        Bunifu.Framework.UI.BunifuElipse e = new Bunifu.Framework.UI.BunifuElipse();

        public KeycapBackgroundModule()
        {
            InitializeComponent();

            foreach (Control c in this.Controls)
            {
                e.ApplyElipse(c, 5);
            }
        }

        //Declaração das propriedades dos ícones
        private Queue<Image> ImageQueue = new Queue<Image>();

        public Image SelectedImg { get; set; }

        public static bool HasChosenAnImg { get; set; }

        private void btnNewIcon_Click(object sender, EventArgs e)
        {
            List<Image> insertableArray = new List<Image> { };
            using (OpenFileDialog iconGetter = new OpenFileDialog())
            {
                iconGetter.InitialDirectory = @"C:\";
                iconGetter.Title = "Qual o ícone que deseja adicionar?";
                iconGetter.Filter = "Todos os tipos de imagem | *jpg; *.jpeg; *.bmp; *.png; *.ico|BMP | *.bmp | JPG | *.jpg; *.jpeg | PNG | *.png | ICO | *.ico | Todos| *.*";
                iconGetter.Multiselect = true;
                if (iconGetter.ShowDialog() == DialogResult.OK)
                {
                    foreach (String fileDirectory in iconGetter.FileNames)
                        ImageQueue.Enqueue(Image.FromFile(fileDirectory));

                    while (ImageQueue.Count > 10)
                        ImageQueue.Dequeue();

                    AcroniMessageBoxInput input = new AcroniMessageBoxInput("Muito legal a imagem, parabéns.", "Agora escolha um nome para ela.");
                    if (input.ShowDialog() == DialogResult.OK)
                    {
                        __imageName = input.input;
                    }
                }
                for (int aux = ImageQueue.Count - 1; aux >= 0; aux--)
                {
                    insertableArray.Add(ImageQueue.ToArray()[aux]);
                }
            }
            for (int i = 0; i < ImageQueue.Count; i++)
            {
                (pnlImages.Controls[$"pnlImg{i + 1}"].Controls[$"picBoxImg{i + 1}"] as PictureBox).Image = insertableArray[i];
                (pnlImages.Controls[$"pnlImg{i + 1}"].Controls[$"picBoxImg{i + 1}"] as PictureBox).SizeMode = PictureBoxSizeMode.Zoom;
                (pnlImages.Controls[$"pnlImg{i + 1}"] as Panel).Visible = true;
                this.e.ApplyElipse(pnlImages.Controls[$"pnlImg{i + 1}"] as Panel, 5);
                (pnlImages.Controls[$"pnlImg{i + 1}"] as Panel).BackColor = Color.FromArgb(80, 80, 80);
                (pnlImages.Controls[$"pnlImg{i + 1}"].Controls[$"lblPic{i + 1}"] as Label).Text = __imageName;
            }
        }

        private void picIcons_Click(object sender, EventArgs e)
        {
            PictureBox icon = (PictureBox)sender;
            icon.Tag = "Chosen";
            if (icon.Tag.Equals("Chosen"))
                icon.Focus();

            if (sender != null)
            {
                pnlBtnIconChosen.Visible = true;
                pnlBtnIconChosen.Location = new Point(icon.Location.X + icon.Size.Width - 10, icon.Location.Y + icon.Size.Height - 10);
                this.e.ApplyElipse(pnlBtnIconChosen, 5);
                SelectedImg = icon.Image;
                HasChosenAnImg = true;
            }
        }
    }
}
