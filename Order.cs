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
    public partial class Order : Form
    {
        private string soupName;
        private int quantity;
        private double totalPrice;

        public Order(string soupName, int quantity, double totalPrice)
        {
            InitializeComponent();
            this.soupName = soupName;
            this.quantity = quantity;
            this.totalPrice = totalPrice;
        }
        public Order()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            form.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            this.Hide(); // Hide the current form
            homeForm.Show();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            

        }
    }
}
