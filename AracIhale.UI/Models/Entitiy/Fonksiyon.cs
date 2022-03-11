using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracIhale.UI
{
    public static class Fonksiyon
    {
        public static void Temizle(Control.ControlCollection koleksiyon)
        {
            foreach (Control gb in koleksiyon)
            {
                if (gb is GroupBox)
                {
                    foreach (Control tb in gb.Controls)
                    {
                        if (tb is TextBox)
                        {
                            TextBox txt = (TextBox)tb;
                            txt.Clear();
                        }
                        else if (tb is ComboBox)
                        {
                            ComboBox cb = (ComboBox)tb;
                            cb.SelectedIndex = -1;
                        }
                        else if (tb is NumericUpDown)
                        {
                            NumericUpDown nmr = (NumericUpDown)tb;
                            nmr.Value = 0;
                        }
                    }
                }
            }
        }


    }
}
