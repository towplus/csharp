using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var font = FontFamily.Families;
            foreach (FontFamily f in font)
            {
                comFont.Items.Add(f.Name);
            }
        }
        void ChangeFont()
        {
            if (comFont.SelectedIndex < 0)
            {
                return;
            }
            FontStyle fs = FontStyle.Regular;

            if (chkBold.Checked)
            {
                fs |= FontStyle.Bold;
            }
            if (chkItalic.Checked)
            {
                fs |= FontStyle.Italic;
            }
            txtMessage.Font = new Font((string)comFont.SelectedItem, 10, fs);
        }
    }
}
