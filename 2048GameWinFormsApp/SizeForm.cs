using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048GameWinFormsApp
{
    public partial class SizeForm : Form
    {
        public List<RadioButton> radioButtons;
        public SizeForm()
        {
            InitializeComponent();
            radioButtons = new List<RadioButton>()
            {
                first4x4Label, secound5x5Label, third6x6Label, fourth7x7Label
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
