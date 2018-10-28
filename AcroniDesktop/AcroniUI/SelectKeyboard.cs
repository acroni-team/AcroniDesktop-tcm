using AcroniLibrary.FileInfo;
using AcroniUI.Custom;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace AcroniUI
{
    public partial class SelectKeyboard : TemplateMenu
    {
        bool canDoAnimation = true;
        public SelectKeyboard()
        {
            InitializeComponent();
            Bunifu.Framework.UI.BunifuElipse roundCorners= new Bunifu.Framework.UI.BunifuElipse();
            roundCorners.ApplyElipse(lblFullSize, 20);
            roundCorners.ApplyElipse(lblTenkeyless, 20);
            roundCorners.ApplyElipse(lblCompacto, 20);

        }

        #region Inicializar todos os tipos de teclados
        #endregion



        private async void btnOpenFullSize_MouseEnter(object sender, System.EventArgs e)
        {
            if ((sender as Control) is PictureBox)
                canDoAnimation = false;    
                while (picBoxOpenFullSize.Height < 340)
                {                
                    await Task.Delay(1);
                    picBoxOpenFullSize.Size = new System.Drawing.Size(Convert.ToInt32(picBoxOpenFullSize.Size.Width + 10), Convert.ToInt32(picBoxOpenFullSize.Height + 10));
                    picBoxOpenFullSize.Location = new System.Drawing.Point(Convert.ToInt32(picBoxOpenFullSize.Location.X - 5), Convert.ToInt32(picBoxOpenFullSize.Location.Y - 5));
                }           
        }

        private void picBoxOpenFullSize_Click(object sender, EventArgs e)
        {
            Fullsize fullsize = new Fullsize();
            fullsize.Show();
            this.Close();
        }

        private async void btnOpenFullSize_MouseLeave(object sender, EventArgs e)
        {
            while (picBoxOpenFullSize.Height > 201)
            {
                if (!canDoAnimation)
                    break;
                    await Task.Delay(1);
                picBoxOpenFullSize.Size = new System.Drawing.Size(Convert.ToInt32(picBoxOpenFullSize.Size.Width - 10), Convert.ToInt32(picBoxOpenFullSize.Height - 10));
                picBoxOpenFullSize.Location = new System.Drawing.Point(Convert.ToInt32(picBoxOpenFullSize.Location.X + 5), Convert.ToInt32(picBoxOpenFullSize.Location.Y + 5));
            }
        }

        private async void picBoxOpenFullSize_MouseLeave(object sender, EventArgs e)
        {
            if (picBoxOpenFullSize.Height > 202)
            {
                while (picBoxOpenFullSize.Height > 201)
                {
                    await Task.Delay(1);
                    picBoxOpenFullSize.Size = new System.Drawing.Size(Convert.ToInt32(picBoxOpenFullSize.Size.Width - 10), Convert.ToInt32(picBoxOpenFullSize.Height - 10));
                    picBoxOpenFullSize.Location = new System.Drawing.Point(Convert.ToInt32(picBoxOpenFullSize.Location.X + 5), Convert.ToInt32(picBoxOpenFullSize.Location.Y + 5));
                }
            }
        }
    }
}
