using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcroniBLL.CustomizingMethods
{
    public class FormManipulator
    {
        public static void CleanAllTextbox(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                    control.ResetText();
            }
        }
    }
}
