using OTS_Supermarket.Models;
using System;
using System.Windows.Forms;

namespace OTS_Supermarket
{
    public partial class Form1 : Form
    {
        public static Cart cart = new Cart();

        public Form1()
        {
            InitializeComponent();
            disableButtons();
        }

        public static void AddOneItem(String itemName)
        {
            Item item;
            if (itemName == "Monitor")
            {
                item = new Monitor();
                cart.AddOneToCart(item);
            }
            else if (itemName == "Keyboard")
            {
                item = new Keyboard();
                cart.AddOneToCart(item);
            }
            else if (itemName == "Lap top")
            {
                item = new Laptop();
                cart.AddOneToCart(item);
            }
            else if (itemName == "Computer")
            {
                item = new Computer();
                cart.AddOneToCart(item);
            }
            else if (itemName == "Computer chair")
            {
                item = new Chair();
                cart.AddOneToCart(item);
            }
        }

        public static void AddMultipleItems(String itemName, int quantity)
        {
            Item item;
            if (itemName == "Monitor")
            {
                item = new Monitor();
                cart.AddMultipleToCart(item, quantity);
            }
            else if (itemName == "Keyboard")
            {
                item = new Keyboard();
                cart.AddMultipleToCart(item, quantity);
            }
            else if (itemName == "Lap top")
            {
                item = new Laptop();
                cart.AddMultipleToCart(item, quantity);
            }
            else if (itemName == "Computer")
            {
                item = new Computer();
                cart.AddMultipleToCart(item, quantity);
            }
            else if (itemName == "Computer chair")
            {
                item = new Chair();
                cart.AddMultipleToCart(item, quantity);
            }
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            QuantityForm form = new QuantityForm();
            form.lblQuantity.Text = "Monitor";
            form.Show();
        }

        private void btnKeyboard_Click(object sender, EventArgs e)
        {
            QuantityForm form = new QuantityForm();
            form.lblQuantity.Text = "Keyboard";
            form.Show();
        }

        private void btnComputer_Click(object sender, EventArgs e)
        {
            QuantityForm form = new QuantityForm();
            form.lblQuantity.Text = "Computer";
            form.Show();
        }

        private void btnLaptop_Click(object sender, EventArgs e)
        {
            QuantityForm form = new QuantityForm();
            form.lblQuantity.Text = "Laptop";
            form.Show();
        }

        private void btnChair_Click(object sender, EventArgs e)
        {
            QuantityForm form = new QuantityForm();
            form.lblQuantity.Text = "Computer chair";
            form.Show();
        }

       
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                cart.Calculate(tbxDate.Text);
                MessageBox.Show("Total price is: " + cart.Amount + "\nCurrent budget: " + cart.Budget);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                this.rtbOutput.Text = cart.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                cart.DeleteAll();
                rtbOutput.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void disableButtons()
        {
            gboxActions.Visible = false;
            gboxButtons.Visible = false;
            lblAdd.Visible = false;
            lblDelivery.Visible = false;
            tbxDate.Visible = false;
            rtbOutput.Visible = false;
        }

        public void enableButtons()
        {
            gboxButtons.Visible = true;
            gboxActions.Visible = true;
            lblDelivery.Visible = true;
            lblAdd.Visible = true;
            tbxDate.Visible = true;
            rtbOutput.Visible = true;
            tbxBudget.Enabled = false;
            btnEnter.Visible = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            double budget;
            bool parsingOK = Double.TryParse(tbxBudget.Text, out budget);
            if (!parsingOK || budget < 0)
            {
                MessageBox.Show("Not a valid number! Budget must be a positive numeric value");
            }
            else
            {
                cart.Budget = Double.Parse(tbxBudget.Text);
                enableButtons();
            }
           
            
        }
    }
}
