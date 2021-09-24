using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public enum msgType
    {
        alert,
        error
    }
    public class messages
    {
        public static void Show(string texto, msgType tipo)
        {
            switch (tipo)
            {
                case msgType.alert:
                    MessageBox.Show(texto, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case msgType.error:
                    MessageBox.Show(texto, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
        }
    }
}
