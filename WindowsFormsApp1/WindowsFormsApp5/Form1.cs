using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "ListView";
            //Size = new Size(350, 300);

            List<Actress> actress = new List<Actress>();
            actress.Add(new Actress("AAA", 1981));
            actress.Add(new Actress("BBB", 1975));
            actress.Add(new Actress("CCC", 1981));
            actress.Add(new Actress("DDD", 1971));
            actress.Add(new Actress("EEE", 1984));

            foreach (Actress act in actress)
            {
                ListViewItem item = new ListViewItem();
                item.Text = act.name;
                item.SubItems.Add(act.year.ToString());
                listView1.Items.Add(item);
            }
        }
    }
    }
}
