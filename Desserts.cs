using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orfoo
{
    public partial class Desserts : Form
    {
        public static Desserts instance;
        public Desserts()
        {
            InitializeComponent();
            instance = this;
        }
        private void Desserts_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            this.Hide(); // Hide the current form
            homeForm.Show();
        }
    }
}
