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
    public partial class Congrats : Form
    {
        public Congrats(string category, int score)
        {
            InitializeComponent();
            category_lbl.Text = category;
            score_lbl.Text = score.ToString();
        }

        private void Congrats_Load(object sender, EventArgs e)
        {
            int score = Convert.ToInt32(score_lbl.Text);
        }
    }
}
