using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    class csLimpiar
    {
        public void BorrarCampos(Panel pnl)
        {
            foreach (var txt in pnl.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedIndex = 2;
                }
                else if (txt is MaskedTextBox)
                {
                    ((MaskedTextBox)txt).ResetText();
                }
            }
        }

    }
}
