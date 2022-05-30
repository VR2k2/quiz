using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            string player = textBox_player.Text;
            
            if (MessageBox.Show("Добро пожаловать, " + player) == DialogResult.OK)
            {
                Categories newForm = new Categories();
                newForm.Show();
                this.Hide();
            }
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
