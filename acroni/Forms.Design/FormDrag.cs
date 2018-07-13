using System.Drawing;
using System.Windows.Forms;

namespace Forms.Design
{
    public class FormDrag
    {
        public static Point MouseDownLocation;

        public static void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MouseDownLocation = e.Location;
        }

        public static void Form_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (int i in Application.OpenForms) {
                Form form = Application.OpenForms[i];
                if (e.Button == MouseButtons.Left)
                {
                    form.Left = e.X + form.Left - MouseDownLocation.X;
                    form.Top = e.Y + form.Top - MouseDownLocation.Y;
                }
            }
        }
    }
}
