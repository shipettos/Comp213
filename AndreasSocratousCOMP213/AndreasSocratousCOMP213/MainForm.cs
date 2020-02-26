using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndreasSocratousCOMP213
{
    public partial class MainForm : Form
    {
        // Global constants
        const int CORE2DUO = 350;
        const int CORE2QUAD24 = 800;
        const int CORE2QUAD28 = 950;
        const int CAMERA = 30;
        const int QUIETFAN = 50;
        const int BLURAY = 180;

        
        //global variables
        int DialyTotal = 0;
        int DialyTotalAfterDiscount = 0;
        int totalAfterDiscount = 0;
        int quantity = 0;
        int purchases = 0;
        int BlurayCounter = 0;
        int totalComputers = 0;

        public MainForm()
        {
            InitializeComponent();
            RBFirstSelected.Checked = true;
        }

        /// <summary>
        /// Exits the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// changes the font
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fontDialog1.Font = this.Font;
            this.fontDialog1.ShowDialog();

            this.Font = this.fontDialog1.Font;
        }

        /// <summary>
        /// showing information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Discounts from 0 to 40% " +Environment.NewLine + Environment.NewLine +
                            "2.Computer Shop", "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            quantity = 0;
            int discount = 0;
            totalAfterDiscount = 0;
            int total = 0;


            //check if any cpu are selected

            if (RBDuo30.Checked == false && RBQuad24.Checked == false && RBQuad28.Checked == false)
            {
                MessageBox.Show("You must Select a CPU", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // GET GUI INFO

            //checking guantity checkbox
            try
            {
                quantity = int.Parse(txtNumOfComps.Text);
            }
            catch
            {
                if (txtNumOfComps.Text == "" || txtNumOfComps.Text == "0")
                {
                    MessageBox.Show("Quantity must be at least 1", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtNumOfComps.SelectAll();
                    this.txtNumOfComps.Focus();
                }
                else
                {
                    MessageBox.Show("Input must be positive number", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtNumOfComps.SelectAll();
                    this.txtNumOfComps.Focus();
                    return;
                }
            }

            //checking discount check box
            try
            {
                if (txtDiscountCode.Text == "")
                    txtDiscountCode.Text = "0";
                discount = int.Parse(txtDiscountCode.Text);
            }
            catch
            {
                MessageBox.Show("Empty or Incorrect input", "Error", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtDiscountCode.SelectAll();
                this.txtDiscountCode.Focus();
                return;
            }
            //checking the range

            if (discount > 40 || discount < 0)
            {
                MessageBox.Show("Value must be from 0-40", "Range Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtDiscountCode.SelectAll();
                this.txtDiscountCode.Focus();
                return;
            }
            else
            {

                //check for the GUI

                if (RBDuo30.Checked)
                    total = total + CORE2DUO;
                if (RBQuad24.Checked)
                    total = total + CORE2QUAD24;
                if (RBQuad28.Checked)
                    total = total + CORE2QUAD28;
                if (CBBluray.Checked)
                {
                    total = total + BLURAY;
                    BlurayCounter++;
                }
                if (CBCmera.Checked)
                    total = total + CAMERA;
                if (CBFan.Checked)
                    total = total + QUIETFAN;

                total = total * quantity;

                discount = total * discount / 100;
                totalComputers = totalComputers + quantity;
                totalAfterDiscount = total - discount;

                //update dialy variables
                DialyTotal = DialyTotal + total;
                DialyTotalAfterDiscount = DialyTotalAfterDiscount + totalAfterDiscount;



                txtTotalBeforeDiscount.Text = total.ToString();
                txtTotal.Text = totalAfterDiscount.ToString();
                cmdBuy.Enabled = true;
            }

        }

        /// <summary>
        /// clearing the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdClear_Click(object sender, EventArgs e)
        {
            //clearing the gui
            txtDiscountCode.Clear();
            txtNumOfComps.Clear();
            txtTotal.Clear();
            txtTotalBeforeDiscount.Clear();
            CBBluray.Checked = false;
            CBCmera.Checked = false;
            CBFan.Checked = false;
        }

        /// <summary>
        /// MAKING THE PURCHASE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdBuy_Click(object sender, EventArgs e)
        {
            cmdCalculate_Click(sender, e);

            DialogResult result;

            result =  MessageBox.Show("Amount charged :" + totalAfterDiscount + ". Proceed?", "Confirmation",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                purchases++;
                cmdClear_Click(sender, e);
                this.RBFirstSelected.Checked = true;
            }
            cmdBuy.Enabled = false;
        }

        /// <summary>
        /// showing the dialy summary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dialySummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Summary Information" + Environment.NewLine +
                            "Number of Orders : " + purchases + Environment.NewLine +
                            "Number of Computers : " + totalComputers + Environment.NewLine +
                            "Number of BluRay Players : " + BlurayCounter + Environment.NewLine +
                            Environment.NewLine + Environment.NewLine +
                            "Amount Before Discount : " + DialyTotal + Environment.NewLine+
                            "Amount after Discount : " + DialyTotalAfterDiscount, "Summary Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// resetting the dialy summary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Are you sure?", "Confirmation",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //setting global to zero, resetting them
                purchases = 0;
                totalComputers = 0;
                DialyTotal = 0;
                DialyTotalAfterDiscount = 0;
                BlurayCounter = 0;
            }
        }

 
    }
}
