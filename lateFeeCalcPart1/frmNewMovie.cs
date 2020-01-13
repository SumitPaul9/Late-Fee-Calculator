using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lateFeeCalcPart1
{
    public partial class frmNewMovie : Form
    {
        
        public frmNewMovie()
        {
            InitializeComponent();
        }

         private RentalItem rentalItem = null;            

        public RentalItem GetNewRental()
        {
           this.ShowDialog();                                                       //Shows the new movie dialog
            return rentalItem;
        }

        private void btnSave_Click(object sender, EventArgs e)                      //Event when save button is clicked
        {
            if (IsValidData())
            {
                rentalItem = new RentalItem(Convert.ToInt32(txtMovieNo.Text),       //Function call
                    txtDescription.Text, txtRating.Text);
                this.Close();
            }
        }

        private bool IsValidData()                                          //Validation function to check if data is already present or not
        {
            return Validator.IsPresent(txtMovieNo) &&
                   Validator.IsPresent(txtDescription) &&
                   Validator.IsPresent(txtRating) &&
                   Validator.IsDecimal(txtMovieNo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();                                                   //closes the dialog
        }
    }
}
