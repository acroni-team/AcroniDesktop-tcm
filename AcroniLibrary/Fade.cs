using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcroniLibrary
{
    class Fade
    {
        public async static void FadeIn(Form form)
        {
            while(form.Opacity < 1)
            {
                await Task.Delay(1);
                form.Opacity += 0.05;
            }
            form.Opacity = 1;
        }

        public async static void FadeOut(Form form, bool gonnaExit = false)
        {
            while (form.Opacity > 0)
            {
                await Task.Delay(1);
                form.Opacity -= 0.05;
            }
            form.Opacity = 0;
            if (gonnaExit)
                Application.Exit();
        }
    }
}
