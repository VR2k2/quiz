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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        int count = 0;
        int score = 0;

       

        

        private void History_Load(object sender, EventArgs e)
        {
            button_next.Enabled = false;
            button_answer.Enabled = true;
            count++;

            if(count == 1)
            {
                question.Text = "В каком году началась первая мировая война?";
                answer_1.Text = "1931";
                answer_2.Text = "1914";
                answer_3.Text = "1941";
                answer_4.Text = "1939";
            }

            if(count == 2)
            {
                question.Text = "В каком году был медный бунт?";
                answer_1.Text = "1662";
                answer_2.Text = "1665";
                answer_3.Text = "1701";
                answer_4.Text = "1599";
            }

            if(count == 3)
            {
                this.Hide();
                Congrats newForm = new Congrats("Категория: История", score);
                newForm.Show();
                
            }



        }

        private void button_next_Click(object sender, EventArgs e)
        {
            button_next.Enabled = false;
            button_answer.Enabled = true;
            count++;

            if(count == 1)
            {
                question.Text = "В каком году началась первая мировая война?";
                answer_1.Text = "1931";
                answer_2.Text = "1914";
                answer_3.Text = "1941";
                answer_4.Text = "1939";
            }

            if(count == 2)
            {
                question.Text = "В каком году был медный бунт?";
                answer_1.Text = "1662";
                answer_2.Text = "1665";
                answer_3.Text = "1701";
                answer_4.Text = "1599";
            }

            if(count == 3)
            {
                this.Hide();
                Congrats newForm = new Congrats("Категория: История", score);
                newForm.Show();

            }
        }

        private void button_finish_Click(object sender, EventArgs e)
        {
            Categories newForm = new Categories();
            newForm.Show();
            this.Hide();
        }

        private void button_answer_Click(object sender, EventArgs e)
        {
            button_next.Enabled = true;
            button_answer.Enabled = false;

            if(question.Text == "В каком году началась первая мировая война?")
            {
                if(answer_2.Checked == true)
                {
                    score++;
                }
            }

            if(question.Text == "В каком году был медный бунт?")
            {
                if(answer_1.Checked == true)
                {
                    score++;
                }
            }
        }

        
    }
}
