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
            LoadCustomerDropDown();
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
            LoadCustomerDropDown();
            ChooseCustomerFromDropDown(cname);
            MessageBox.Show(customerController.GetCustomersAsString());
        }

        private void LoadCustomerDropDown()
        {
            List<String> customerNames = customerController.GetCustomerName();
            ddclist.DataSource = customerNames;
            ddclist.Refresh();
        }

        private void ChooseCustomerFromDropDown(string cname)
        {
            int index = ddclist.Items.IndexOf(cname);
            if (index >= 0)
            {
                ddclist.SelectedIndex = index;
            }
            
        }

        private void frmdelivery_Load(object sender, EventArgs e)
        {

        }

        private void lblclist_Click(object sender, EventArgs e)
        {

        }

        private void ddclist_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cname;
            Dictionary<string, string> data;
            string[] toppings;
            if (ddclist.SelectedIndex != -1)
            {
                cname = ddclist.GetItemText(ddclist.SelectedItem);
                data = customerController.GetDataForCustomerByName(cname);
                if (data != null)
                {
                    txtdate.Text = data["Address"];
                    txtcname.Text = data["Customer Name"];
                    txtaddress.Text = data["Address"];
                    txtdname.Text = data["Driver Name"];
                    txttime.Text = data["Time-Out"];
                    lstsize.SelectedIndex = lstsize.Items.IndexOf(data["Size"]);
                    if (data["Tip"].Equals("0"))
                    {
                        rbten.Checked = true;
                    } else if (data["Tip"].Equals("1"))
                    {
                        rbfifteen.Checked = true;
                    } else
                    {
                        rbeighteen.Checked = true;
                    }
                    toppings = data["Toppings"].Split(' ');
                    chkcheese.Checked = false;
                    chkveggie.Checked = false;
                    chkmeat.Checked = false;
                    if (toppings.Length > 0)
                    {
                        if (toppings.Contains("0"))
                        {
                            chkcheese.Checked = true;
                        }
                        if (toppings.Contains("1"))
                        {
                            chkveggie.Checked = true;
                        }
                        if (toppings.Contains("2"))
                        {
                            chkmeat.Checked = true;
                        }
                    }
                    rtbinstruction.Text = data["Information"];
                    Refresh();




                }
            }
            //string cname = ddclist.GetItemText(ddclist.SelectedItem);

        }
    }
}
