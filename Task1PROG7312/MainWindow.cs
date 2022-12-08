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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rpBooksBtn_Click(object sender, EventArgs e)
        {
            ReplacingBooks rb = new ReplacingBooks();
            rb.Show();
            this.Hide();
        }

        private void idAreaBtn_Click(object sender, EventArgs e)
        {
            idAreas id = new idAreas();
            id.Show();
            this.Hide();
        }
    }
}
