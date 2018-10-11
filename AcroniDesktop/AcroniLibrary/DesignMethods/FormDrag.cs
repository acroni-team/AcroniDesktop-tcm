using System.Drawing;
using System.Windows.Forms;

namespace AcroniLibrary.DesignMethods
{
    public class FormDrag
    {
        static Point MouseDownLocation;

        public static void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MouseDownLocation = e.Location;
        }

        public static void Form_MouseMove(object sender, MouseEventArgs e)
        {
            Form form = Application.OpenForms[0];
            if (e.Button == MouseButtons.Left)
            {
                form.Left = e.X + form.Left - MouseDownLocation.X;
                form.Top = e.Y + form.Top - MouseDownLocation.Y;
            }

        }
    }
}
