using AcroniControls;
using AcroniLibrary.FileInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcroniUI
{
    public partial class CollectionSelected : TemplateMenu
    {
        private int contKeyboards = 0;   
        public CollectionSelected()
        {
            InitializeComponent();
            pnlWithKeyboards.AutoScroll = true;
            loadKeyboards();
            lblCollectionName.Text = Share.Collection.CollectionName;
            lblKeyboardsNumber.Text = contKeyboards + " "+lblKeyboardsNumber.Text;

        }
        private void loadKeyboards()
        {
            int countLateralPadding = 0;
            int countUpBottomPadding = 0;
            foreach (Keyboard userKeyboard in Share.Collection.Keyboards)
            {
                Share.Keyboard.NickName = userKeyboard.NickName;
                Share.Keyboard.KeyboardType = userKeyboard.KeyboardType;
                Keyboard_CollectionSelected userKeyboardUI = new Keyboard_CollectionSelected();
                if (countLateralPadding == 468)
                {
                    countLateralPadding = 0;
                    countUpBottomPadding += 476;
                }               
                userKeyboardUI.Location = new Point(0+countLateralPadding, 0+countUpBottomPadding);
                pnlWithKeyboards.Controls.Add(userKeyboardUI);
                countLateralPadding += 234;
                contKeyboards++;               
            }
        }

        
    }
}
