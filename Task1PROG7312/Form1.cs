using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1PROG7312
{
    public partial class ReplacingBooks : Form
    {
        int Counter;

        public ReplacingBooks()
        {
            InitializeComponent();
        }

        public void EmptySpotChecker(Button Butt1, Button Butt2)
        {
            if (Butt2.Text == "")
            {
                Butt2.Text = Butt1.Text;
                Butt1.Text = "";
            }
        }

        public void SolutionChecker()
        {
            if (btn1.Text == "1 001.92 JUH" && btn2.Text == "2 002.45 PA" && btn3.Text == "3 003.15 GAR" && btn4.Text == "4 004.12 GAR"
                && btn5.Text == "5 005.15 HAR" && btn6.Text == "6 006.92 JOK" && btn7.Text == "7 007.92 PLM" && btn8.Text == "8 008.15 JUH"
                && btn9.Text == "9 009.6 JUH" && btn10.Text == "10 010.1 PA" && btn11.Text == "11 010.2 JAN" && btn12.Text == "12 010.3 HAR"
                && btn13.Text == "13 010.5 GAR" && btn14.Text == "14 010.6 PLM" && btn15.Text == "15 010.9 SAM")
            {
                MessageBox.Show("Well Done you are a winner", "Shuffle Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Counter = Counter + 1;
            numOfPlays.Text = "Number of Clicks " + Counter;
            counterBox.Text = Counter.ToString();
        }

        public void Shuffle()
        {
            int[] bnum = new int[16];
            int i, j, rowChecker;
            Boolean flag = false;

            i = 1;

            do
            {
                Random rand = new Random();
                rowChecker = Convert.ToInt32((rand.Next(0, 15)) + 1);

                for (j = 1; j <= i; j++)
                {
                    if (bnum[j] == rowChecker)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                {
                    flag = false;
                }
                else
                {
                    bnum[i] = rowChecker;
                    i = i + 1;
                }
            }
            while (1 <= 15);
            btn1.Text = Convert.ToString(bnum[1]);
            btn2.Text = Convert.ToString(bnum[2]);
            btn3.Text = Convert.ToString(bnum[3]);
            btn4.Text = Convert.ToString(bnum[4]);
            btn5.Text = Convert.ToString(bnum[5]);
            btn6.Text = Convert.ToString(bnum[6]);
            btn7.Text = Convert.ToString(bnum[7]);
            btn8.Text = Convert.ToString(bnum[8]);
            btn9.Text = Convert.ToString(bnum[9]);
            btn10.Text = Convert.ToString(bnum[10]);
            btn11.Text = Convert.ToString(bnum[11]);
            btn12.Text = Convert.ToString(bnum[12]);
            btn13.Text = Convert.ToString(bnum[13]);
            btn14.Text = Convert.ToString(bnum[14]);
            btn15.Text = Convert.ToString(bnum[15]);
            btn16.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn1, btn2);
            EmptySpotChecker(btn1, btn5);

            SolutionChecker();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn2, btn1);
            EmptySpotChecker(btn2, btn3);
            EmptySpotChecker(btn2, btn6);

            SolutionChecker();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn3, btn2);
            EmptySpotChecker(btn3, btn4);
            EmptySpotChecker(btn3, btn7);

            SolutionChecker();
        }

        private void btn4_Click(object sender, EventArgs e)
        {

            EmptySpotChecker(btn4, btn3);
            EmptySpotChecker(btn4, btn8);

            SolutionChecker();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn5, btn1);
            EmptySpotChecker(btn5, btn6);
            EmptySpotChecker(btn5, btn9);

            SolutionChecker();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn6, btn2);
            EmptySpotChecker(btn6, btn5);
            EmptySpotChecker(btn6, btn7);
            EmptySpotChecker(btn6, btn10);

            SolutionChecker();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn7, btn3);
            EmptySpotChecker(btn7, btn6);
            EmptySpotChecker(btn7, btn11);
            EmptySpotChecker(btn7, btn8);

            SolutionChecker();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn8, btn4);
            EmptySpotChecker(btn8, btn7);
            EmptySpotChecker(btn8, btn12);

            SolutionChecker();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn9, btn5);
            EmptySpotChecker(btn9, btn10);
            EmptySpotChecker(btn9, btn13);

            SolutionChecker();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn10, btn6);
            EmptySpotChecker(btn10, btn9);
            EmptySpotChecker(btn10, btn11);
            EmptySpotChecker(btn10, btn14);

            SolutionChecker();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn11, btn7);
            EmptySpotChecker(btn11, btn10);
            EmptySpotChecker(btn11, btn15);
            EmptySpotChecker(btn11, btn12);

            SolutionChecker();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn12, btn8);
            EmptySpotChecker(btn12, btn11);
            EmptySpotChecker(btn12, btn16);

            SolutionChecker();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn13, btn9);
            EmptySpotChecker(btn13, btn14);

            SolutionChecker();
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn14, btn13);
            EmptySpotChecker(btn14, btn10);
            EmptySpotChecker(btn14, btn15);

            SolutionChecker();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn15, btn14);
            EmptySpotChecker(btn15, btn11);
            EmptySpotChecker(btn15, btn16);

            SolutionChecker();
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(btn16, btn12);
            EmptySpotChecker(btn16, btn15);

            SolutionChecker();
        }

        private void rstBtn_Click(object sender, EventArgs e)
        {
            Shuffle();
        }

        private void solBtn_Click(object sender, EventArgs e)
        {
            btn1.Text = Convert.ToString(1);
            btn2.Text = Convert.ToString(2);
            btn3.Text = Convert.ToString(3);
            btn4.Text = Convert.ToString(4);
            btn5.Text = Convert.ToString(5);
            btn6.Text = Convert.ToString(6);
            btn7.Text = Convert.ToString(7);
            btn8.Text = Convert.ToString(8);
            btn9.Text = Convert.ToString(9);
            btn10.Text = Convert.ToString(10);
            btn11.Text = Convert.ToString(11);
            btn12.Text = Convert.ToString(12);
            btn13.Text = Convert.ToString(13);
            btn14.Text = Convert.ToString(14);
            btn15.Text = Convert.ToString(15);
            btn16.Text = "";
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            Shuffle();
            numOfPlays.Clear();
            counterBox.Clear();

            this.Refresh();
            this.Hide();

            ReplacingBooks NewGame = new ReplacingBooks();
            NewGame.Show();
        }

        private void extBtn_Click(object sender, EventArgs e)
        {
            DialogResult iExit = MessageBox.Show("Confirm if you want to exit", "Shuffle Games",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (iExit == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void ReplacingBooks_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult iExit = MessageBox.Show("Confirm if you want to exit", "Shuffle Games",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (iExit == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ReplacingBooks_Load(object sender, EventArgs e)
        {
            //Shuffle();
        }
    }
}
