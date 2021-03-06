﻿using System.Windows.Forms;

namespace AcroniBLL.CustomizingMethods.Colorpicker
{
    class SetColorpickerVisibility : ColorpickerHandlers
    {
        public SetColorpickerVisibility(ref Panel pnlColorpicker, ref Button btnHist1, ref Button btnHist2, ref Button btnHist3, ref Panel pnlHistorico)
        {
            if (IsChosen)
            {
                IsChosen = false;
                pnlColorpicker.Visible = true;
                if (NoOfColorsVisibleOnDisplay > 0)
                {
                    pnlHistorico.Visible = true;
                    if (NoOfColorsVisibleOnDisplay == 1)
                        btnHist1.Visible = true;
                    else if (NoOfColorsVisibleOnDisplay == 2)
                        btnHist2.Visible = true;
                    else
                        btnHist3.Visible = true;
                }
            }
            else
            {
                pnlColorpicker.Visible = false;
                pnlHistorico.Visible = false;
                IsChosen = true;
            }
        }
    }
}
