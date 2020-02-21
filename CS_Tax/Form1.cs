using System;
using System.Drawing;
using System.Windows.Forms;

namespace CS_Tax
{
    public partial class Form1 : Form
    {
        double iTax, iSubTotal, iTotal;

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Cofirm if you want to exit", "Sales Inventory System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTax.BackColor = Color.White;
            txtTotal.Text = "";
            txtSubTotal.Text = "";
            txtTax.Text = "";
            txtQuantity.Text = "";
        }

        private void btnToal_Click(object sender, EventArgs e)
        {
            cTax cost = new cTax();

            if (txtQuantity.Text == "")
            {
                MessageBox.Show("Enter quantity", "Sales Inventory System", MessageBoxButtons.OK, MessageBoxIcon.Question);

                txtQuantity.Focus();
            }
            else
            {
                cost.item1 = double.Parse(txtQuantity.Text);

                iSubTotal = cost.GetAmount();
                iTax = cost.cFindTax(iSubTotal);
                iTotal = iSubTotal + iTax;

                txtTax.Text = string.Format("{0:C}", iTax);
                txtTotal.Text = string.Format("{0:C}", iTotal);
                txtSubTotal.Text = string.Format("{0:C}", iSubTotal);

                txtTax.BackColor = Color.Azure;
            }
        }
    }
}
