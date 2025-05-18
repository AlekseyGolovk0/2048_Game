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
    public partial class UserNameForm : Form
    {
        public string UserName => userNameTextBox.Text;
        public UserNameForm()
        {
            InitializeComponent();
        }

        private void UserNameAnswer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userNameTextBox.Text))
            {
                MessageBox.Show("Введите корректный ответ!");
            }
            else
            {
                Close();
            }
        }
    }
}
