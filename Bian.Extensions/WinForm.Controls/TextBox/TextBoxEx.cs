using System.Windows.Forms;

namespace Bian.Extensions
{
    public static class TextBoxEx
    {
        public static void SetSelect(this TextBoxBase textBox)
        {
            textBox.Focus();
            textBox.SelectAll();
        }
    }
}
