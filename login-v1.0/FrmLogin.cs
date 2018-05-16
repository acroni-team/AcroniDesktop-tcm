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
            if(txt1.Text == "Filipe" && txt2.Text == "filipe")
            {
                Application.Exit();
            } else{
                txt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
                txt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            }
        }

        private void txt1_Enter(object sender, EventArgs e)
        {
            if (txt1.ForeColor == System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76))))))
            {
                txt1.Text = "";
            }
            txt1.ForeColor = Color.Gray;
        }

        private void txt2_Enter(object sender, EventArgs e)
        {
            if (txt2.ForeColor == System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76))))))
            {
                txt2.Text = "";
            }
            txt2.ForeColor = Color.Gray;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
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


    }
}
