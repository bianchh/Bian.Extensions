using Bian.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.SetSelect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SetItems(new string[] { "1", "2", "3", "4" });

            string str = "1234abcd";
            byte[] bytes = Encoding.ASCII.GetBytes(str);
            ByteEx.TryParseByteToByteString(bytes, out string byteString);
            StringEx.TryParseByteStringToAsciiString(byteString, out string asciiString);
            StringEx.TryParseByteStringToByte(byteString, out byte[] byteArray);
            StringEx.TryParseAsciiStringToByteString(asciiString, out string byteString2);
        }
    }
}
