using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acroni.Colorpicker
{
    class GetSelectedColor : ColorpickerHandlers
    {
        public GetSelectedColor(ref Panel pnlColorpicker, ref Button btnCol, ref Button btnColorChosen, ref Button btnHist1, ref Button btnHist2, ref Button btnHist3, ref Panel pnlHistorico)
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
        }
    }
}
