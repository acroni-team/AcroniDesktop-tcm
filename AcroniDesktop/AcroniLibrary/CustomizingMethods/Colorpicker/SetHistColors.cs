using System.Windows.Forms;
using System.Drawing;

namespace AcroniBLL.CustomizingMethods.Colorpicker
{
    class SetHistColors : ColorpickerHandlers
    {
        public SetHistColors(ref Panel pnlColorpicker, ref Button btnCol, ref Button btnColorChosen, ref Button btnHist1, ref Button btnHist2, ref Button btnHist3, ref Panel pnlHistorico)
        {
            pnlColorpicker.Visible = false;
            pnlHistorico.Visible = false;
            IsChosen = true;
            btnColorChosen.BackColor = btnCol.BackColor;
            if (NoOfColorsVisibleOnDisplay < 3)
                NoOfColorsVisibleOnDisplay++;
            else
                NoOfColorsVisibleOnDisplay = 1;

            if (NoOfColorsVisibleOnDisplay == 1)
            {
                btnHist1.Visible = true;
                btnHist1.BackColor = btnCol.BackColor;
            }
            else if (NoOfColorsVisibleOnDisplay == 2)
            {
                btnHist2.Visible = true;
                btnHist2.BackColor = btnCol.BackColor;
            }
            else 
            {
                btnHist3.Visible = true;
                btnHist3.BackColor = btnCol.BackColor;
            }
            ChosenColor = btnColorChosen.BackColor;
        }

        public static Color GetColor
        {
            get
            {
                return ChosenColor;
            }
        }
    }
}
