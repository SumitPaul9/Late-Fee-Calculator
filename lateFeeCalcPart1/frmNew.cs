/* Submitted by : Sumit Jindal
 *          c0754947
 *          26th July,2019 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace lateFeeCalcPart1
{
    public partial class frmNew : Form
    {
        
        int numberOfMovies = 0;                     //intialize a class variable 

        public frmNew()
        {
            InitializeComponent();

            //populate Today's date and show it in the textbox txtCurrent
            txtCurrent.Text = DateTime.Now.ToString(@"MM-dd-yyyy");
            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            String lateFee = "";
            double discountPercent = 0;                                               //Declare variables

            try
            {
                //Generate the Current date
                DateTime dCurrent = DateTime.Now;

                //Generate the due date based on user entry in textbox txtDue
                DateTime dDue = DateTime.Parse(txtDue.Text);
                IsDateTime(txtDue);

                
                //Calculate the number of days late
                TimeSpan days = (dCurrent.Date - dDue.Date);
                double numberOfDays = days.TotalDays;


                IsValidData();                                                          //Validate data

                // Calling CalculateLateFee method to return the late fee
                lateFee = CalculateLateFee(numberOfDays, discountPercent, numberOfMovies);
                
                //Display the late fee in the textbox txtFee
                txtFee.Text = lateFee;
                this.Tag = lateFee;
                

                btnReturn.Focus();                                                      //Focus on return button

            }
            catch (Exception)
            {
                MessageBox.Show("Due Date is required");                                 //Catch Exception
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Hide this form to reveal frmMain
            this.Hide();
        }

        public bool IsInt32(TextBox textBox, string name)                       //IsInt32 method takes two inputs 
        {                                                                       //Returns a boolean value
            int number = 0;

            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a int value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        //IsCustType method takes one parameter and returns a boolean value
        private bool IsCustType(TextBox txtCustomerType)
        {
            if (txtCustomerType.Text == "N" || txtCustomerType.Text == "n" || txtCustomerType.Text == "L" ||
                txtCustomerType.Text == "l" || txtCustomerType.Text == "J" || txtCustomerType.Text == "j")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Customer type must be any one of letter N, L or J ");
                return false;
            }
        }

        //IsPast method takes one parameter and returns a boolean value
        private bool IsPast(TextBox txtDue)
        {
            DateTime dDue = DateTime.Parse(txtDue.Text);
            DateTime dCurrent = DateTime.Now;

            if (dDue < dCurrent)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Due date must precede the current date");
                return false;
            }
        }

        //IsPresent method takes two parameters and returns a boolean value
        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            else
                return true;
        }

        //IsDateTime method takes one parameter and returns a boolean value
        private bool IsDateTime(TextBox txtDueDate3)
        {
            String strDue = txtDueDate3.Text;
            String strFormat = "MM-dd-yyyy";
            DateTime strResult;

            if (DateTime.TryParseExact(strDue, strFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out strResult))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid format");
                return false;
            }

        }

        //IsValidData method takes one parameter and returns a boolean value
        public bool IsValidData()
        {
            
            if ((numberOfMovies > 0) && IsCustType(txtCustomerType)
                                                && IsPast(txtDue) && IsPresent(txtCustomerType, "Customer Type"))

            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //clear late fee method to clear Text box 
        private void clearLatefee(object sender, EventArgs e)
        {
            txtFee.Text = "";
        }

        //CalculateLateFee method to calculate the late fee 
        private String CalculateLateFee(double numberOfDays, double discountPercent, int numberOfMovies)
        {

            double doubleLateFee = 0;

            //Display the number of days late in the textbox txtNum
            txtNum.Text = numberOfDays.ToString();

            //Get the number of movies from the txtNumberOfMovies textbox
           // bool success = Int32.TryParse(txtNumberOfMovies.Text, out numberOfMovies);

            //Calculate the late fee

            //Get customer type from txtCustomerType textbox
            char customerType = char.Parse(txtCustomerType.Text);

            if (customerType == 'N' || customerType == 'n' )//&& success)
            {
                doubleLateFee = 2 * numberOfDays * numberOfMovies;             // New customer and 0% discount
            }
            else if (customerType == 'L' || customerType == 'l')// && success)
            {
                doubleLateFee = 2 * numberOfDays * numberOfMovies * 0.90;      // Loyal customer and 10% discount
            }
            else if (customerType == 'J' || customerType == 'j' )//&& success)
            {
                doubleLateFee = 2 * numberOfDays * numberOfMovies * 0.95;     // Junior customer and 5% discount
            }

            //Display the late fee as currency in the textbox txtFee
            return doubleLateFee.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form lateMovies = new frmLateFilms();
            DialogResult selectedButton = lateMovies.ShowDialog();
            if (selectedButton == DialogResult.OK && lateMovies.Tag != null)
            {
                numberOfMovies += (int)lateMovies.Tag;
                lblnumber.Text = Convert.ToString(numberOfMovies);
            }
        }
    }
}
