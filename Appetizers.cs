using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace orfoo
{
    public partial class Appetizers : Form
    {
        public static Appetizers instance;
        private List<string> selectedOrders = new List<string>();

        private Dictionary<string, double> soupPrices = new Dictionary<string, double>()
        {
            { "Vegetable Soup", 250.00},
            { "Chicken Soup", 300.00 },
            { "Beef Soup", 350.00 },
            { "Salad", 150.00 },
            { "Chips and Dips", 100.00 }
        };
        public Appetizers()
        {
            InitializeComponent();
            instance = this;
        }

        private void Appetizers_Load(object sender, EventArgs e)
        {


            // Set default selection
            comboBox1.SelectedIndex = 0;
        }

        private void panelAp1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            this.Hide(); // Hide the current form
            homeForm.Show();
        }

        private void panelA1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

            if (textBox != null)
            {
                // Check if the entered text is a valid number
                if (!int.TryParse(textBox.Text, out int quantity) || quantity <= 0)
                {
                    // If invalid, show a warning message or highlight the textbox
                    textBox.BackColor = Color.LightCoral; // Highlight the textbox with a red background
                    toolTip1.SetToolTip(textBox, "Please enter a valid quantity (greater than 0).");
                }
                else
                {
                    // If valid, reset the textbox's background color
                    textBox.BackColor = Color.White;
                    toolTip1.RemoveAll();
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
         
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {// Get selected soup type and quantity
            string selectedSoup = comboBox1.SelectedItem?.ToString();
            int quantity;
            bool isValidQuantity = int.TryParse(textBox3.Text, out quantity);

            // Check if the selected soup and quantity are valid
            if (!string.IsNullOrEmpty(selectedSoup) && isValidQuantity && quantity > 0)
            {
                // Calculate total price
                double pricePerSoup = soupPrices[selectedSoup];
                double totalPrice = pricePerSoup * quantity;

                // Display the total price in label10
                label10.Text = $"{totalPrice:F2}";
            }
            else
            {
                // Show error message if input is invalid
                MessageBox.Show("Please select a soup and enter a valid quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int quantity;
            if (int.TryParse(textBox3.Text, out quantity) && quantity > 0)
            {
                string soupName = comboBox1.SelectedItem.ToString(); // Get selected soup name
                double price = 0;

                // Determine the price based on the selected soup
                if (soupName == "Vegetable Soup")
                    price = 5.99;
                else if (soupName == "Chicken Soup")
                    price = 7.99;
                else if (soupName == "Beef Soup")
                    price = 9.99;

                double totalPrice = price * quantity;  // Calculate total price

                // Pass the selected data to the Order form
                Order orderForm = new Order(soupName, quantity, totalPrice);
                this.Hide(); // Hide the current form
                orderForm.Show(); // Show the Order form
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity greater than 0.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int quantity;
            if (int.TryParse(salad_qty.Text, out quantity) && quantity > 0)
            {
                // Define the price for Salad (replace with the actual price if needed)
                double SaladPrice = 150.00; // For example, the price of the Salad

                // Calculate total price
                double totalPrice = SaladPrice * quantity;

                // Display the total price in label11
                saladPrice.Text = $"Rs:{totalPrice:F2}";  // Format to 2 decimal places
            }
            else
            {
                // Show an error message if the quantity is invalid
                MessageBox.Show("Please enter a valid quantity greater than 0.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

            if (textBox != null)
            {
                // Check if the entered text is a valid number
                if (!int.TryParse(textBox.Text, out int quantity) || quantity <= 0)
                {
                    // If invalid, show a warning message or highlight the textbox
                    textBox.BackColor = Color.LightCoral; // Highlight the textbox with a red background
                    toolTip1.SetToolTip(textBox, "Please enter a valid quantity (greater than 0).");
                }
                else
                {
                    // If valid, reset the textbox's background color
                    textBox.BackColor = Color.White;
                    toolTip1.RemoveAll(); // Remove the tool tip when the quantity is valid
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (int.TryParse(cdqty.Text, out int quantity) && quantity > 0)
            {
                // Price per "Chips and Dips"
                double chipsAndDipsPrice = 100.00; // Adjust this price as needed

                // Calculate total price
                double totalPrice = chipsAndDipsPrice * quantity;

                // Display total price in the cdPrice label
                cdPrice.Text = $"Rs:{totalPrice:F2}"; // Display with two decimal places
            }
            else
            {
                // Show an error message if the quantity is invalid
                MessageBox.Show("Please enter a valid quantity for Chips and Dips.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

            if (textBox != null)
            {
                // Check if the entered text is a valid number (greater than 0)
                if (!int.TryParse(textBox.Text, out int quantity) || quantity <= 0)
                {
                    // If invalid, show a warning message or highlight the textbox
                    textBox.BackColor = Color.LightCoral; // Highlight the textbox with a red background
                    toolTip1.SetToolTip(textBox, "Please enter a valid quantity (greater than 0).");
                }
                else
                {
                    // If valid, reset the textbox's background color
                    textBox.BackColor = Color.White;
                    toolTip1.RemoveAll();
                }
            }
        }
    }
}
