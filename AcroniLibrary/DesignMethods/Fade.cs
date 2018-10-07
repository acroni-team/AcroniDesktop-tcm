using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcroniLibrary.DesignMethods
{
    public class Fade
    {
        public async static void FadeIn(Form form)
        {
            while (form.Opacity < 1)
            {
                await Task.Delay(1);
                form.Opacity += 0.05;
            }
            form.Opacity = 1.0;
        }

        public async static void FadeOut(Form form)
        {
            while (form.Opacity > 0)
            {
                await Task.Delay(1);
                form.Opacity -= 0.05;
            }
            Application.Exit();
        }
    }
}
