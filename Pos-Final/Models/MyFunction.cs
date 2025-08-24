using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos_Final.Models
{
    internal class MyFunction
    {
        public static bool IsTextBoxEmpty( params TextBox[] textBoxs)
        {

            foreach (TextBox textBox in textBoxs)
            {

                if (textBox.Text.Equals(""))
                {
                    textBox.Focus();
                    return true;
                }
            }
            return false;
        }
        public static void ClearTextBox(params TextBox[] textBoxs)
        {

            foreach (TextBox textBox in textBoxs)
            {

                if (!textBox.Text.Equals(""))
                {
                    textBox.Clear();

                }
            }
        }

        internal static bool IsComboBoxEmpty(params ComboBox[] comboBoxs) { 
            throw new NotImplementedException();
        
        }

        public static void ClearComboBox(ComboBox cbUserId)
        {
            
            cbUserId.SelectedIndex = -1;  // Clears the selected item
        }

        internal static bool IsTextBoxEmpty(TextBox txtQty, TextBox txtPrice)
        {
            throw new NotImplementedException();
        }
    }
    
}
