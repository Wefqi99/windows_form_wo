using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_form
{
    public partial class frmdelivery : Form
    {
        private CustomerController customerController;
        public frmdelivery(CustomerController customerController)
        {
            InitializeComponent();
            this.customerController = customerController;
        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbltip_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmdelivery_Click(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string date = txtdate.Text;
            string cname = txtcname.Text;
            string address = txtaddress.Text;
            string dname = txtdname.Text;
            string time = txttime.Text;
            string instructions = rtbinstruction.Text;
            string size = lstsize.GetItemText(lstsize.SelectedItem);
            int tip;
            List<int> toppings = new List<int>();
            if (rbten.Checked)
            {
                tip = 0;
            } else if (rbfifteen.Checked)
            {
                tip = 1;
            } else
            {
                tip = 2;
            }
            if (chkcheese.Checked)
            {
                toppings.Add(0);
            }
            if (chkmeat.Checked)
            {
                toppings.Add(1);
            }
            if (chkveggie.Checked)
            {
                toppings.Add(2);
            }
            customerController.AddCustomer(date, cname, address, dname, time, instructions, size, toppings, tip);
            MessageBox.Show(customerController.GetCustomersAsString());
        }

        private void frmdelivery_Load(object sender, EventArgs e)
        {

        }
    }
}
