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
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            var users = UserManager.GetAll();
            foreach (var user in users)
            {
                resultdataGridView.Rows.Add(user.Name, user.Score);
            }
        }
    }
}
