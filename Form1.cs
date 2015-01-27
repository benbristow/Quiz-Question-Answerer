using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Question_Answerer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddAnswerBox()
        {
            //Create new textbox.
            TextBox txtbox = new TextBox();

            //Add to flow panel
            flowLayoutPanel1.Controls.Add(txtbox);

            txtbox.KeyPress += txtbox_KeyPress;

            resizeFlowControls();

        }

        void txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //On tab, new box
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                AddAnswerBox();
            }
        }

        private void btn_AddAnswer_Click(object sender, EventArgs e)
        {
            AddAnswerBox();
        }


        private void btn_RemoveAnswer_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count - 1);                
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeFlowControls();
        }

        private void resizeFlowControls()
        {
            //Resize textboxes in flow panel
            foreach (TextBox txtbox in flowLayoutPanel1.Controls)
            {
                txtbox.Width = txtbox.Parent.ClientSize.Width - 10;
            }

        }

        private void btn_Guess_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count == 0)
            {
                return;
            }

            Question q = new Question(txt_Question.Text);
            foreach (TextBox txtbox in flowLayoutPanel1.Controls)
            {
                q.addAnswer(txtbox.Text);
            }

            MessageBox.Show("The crystal ball says: " + q.guessAnswer());
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Question.Clear();
            foreach (TextBox txt in flowLayoutPanel1.Controls)
            {
                flowLayoutPanel1.Controls.Clear();
            }
        }
    }
}
