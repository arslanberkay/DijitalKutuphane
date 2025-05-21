using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijitalKütüphane.UI.Helper
{
    public static class ValidationExtensions
    {

        public static bool ValidateTextBox(this TextBox txt, string mesaj)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                MessageBox.Show(mesaj);
                return false;
            }
            return true;
        }

        public static bool ValidateMaskedTextBox(this MaskedTextBox mtxt, string mesaj)
        {
            if (!mtxt.MaskFull)
            {
                MessageBox.Show(mesaj);
                return false;
            }
            return true;
        }

        public static bool ValidateDateTimePicker(this DateTimePicker dtp, string mesaj)
        {
            if (dtp.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show(mesaj);
                return false;
            }
            return true;
        }

        public static bool ValidateComboBox(this ComboBox cb, string mesaj)
        {
            if (cb.SelectedItem == null)
            {
                MessageBox.Show(mesaj);
                return false;
            }
            return true;
        }

    }
}
