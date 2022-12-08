using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Task1PROG7312
{
    public partial class idAreas : Form
    {
        Random rand = new Random();
        int Counter;
        private Stopwatch stopwatch;
        private static Dictionary<string, string> test = new Dictionary<string, string>() {
      {
        "000",
        "Computer science, information and general works"
      },
      {
        "100",
        "Philosophy and psychology"
      },
      {
        "200",
        "Religion"
      },
      {
        "300",
        "Social sciences"     
      },
      // {
      //  "400",
      //  "History and geography"
      //},
      //  {
      //  "500",
      //  "Literature"
      //},
      //   {
      //  "600",
      //  "Technology"
      //},
    };

        public idAreas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (test[listBox1.Text] != listBox2.Text)
            {
                //Incorrect Message
                MessageBox.Show("Incorrect");
                MessageBox.Show("Game Complete");

                //Clear Game once finished
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                scoreBox.Clear();

                Application.Exit();

            }
            else
            {
                MessageBox.Show("Correct");
                Counter = Counter + 1;
                MessageBox.Show("You have one point");
                scoreBox.Text = "Score Is " + Counter;
                //counterBox.Text = Counter.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void idAreas_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();

            foreach (KeyValuePair<string, string> kvp in test)
            {

                listBox1.Items.Add(kvp.Key);
                //int index = rand.Next(kvp.Count);
                listBox2.Items.Add(kvp.Value);

                int index = rand.Next(test.Count);

                string key = test.Keys.ElementAt(index);
                string value = test.Values.ElementAt(index);

                KeyValuePair<string, string> pair = test.ElementAt(index);

            }
        }

        private void exitGame_Click(object sender, EventArgs e)
        {
            DialogResult iExit = MessageBox.Show("Confirm if you want to exit", "Match Quiz",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (iExit == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
              listBox1.Items.Clear();
              listBox2.Items.Clear();
              scoreBox.Clear();
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, string> kvp in test)
            {

                listBox1.Items.Add(kvp.Key);
                listBox2.Items.Add(kvp.Value);
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    

        //    //random class created
        //    Random random = new Random();

        //    for (var i = 0; i < 4; i++)
        //    {
        //        int index = random.Next(values.Count);

        //        //adds numbers to listbox
        //        listBox1.Items.Add(values[index]);
        //    }
        //    for (var i = 0; i < 7; i++)
        //    {
        //        int index = random.Next(animals.Count);

        //        //adds animals to listbox          
        //        listBox2.Items.Add(animals[index]);
        //    }
        //}

    }
}

