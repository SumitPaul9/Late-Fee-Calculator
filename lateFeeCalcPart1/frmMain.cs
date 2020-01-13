/* Submitted by : Sumit Jindal
 *          c0754947
 *          12th June,2019 
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

namespace lateFeeCalcPart1
{
    public partial class frmMain : Form
    {
        static decimal fee = 0;
        Form latefee = new frmLateFilms();
      
       
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();                                                      //Closes the window
        }

                                       

        private void btnNewRealse_Click(object sender, EventArgs e)
        {
            frmNew NewRealeases = new frmNew();                                //Create a new instance
            NewRealeases.ShowDialog();                                        //Shows frmNew form
            fee = fee + Decimal.Parse(NewRealeases.Tag.ToString());
            lblTotalLateFee.Text = fee.ToString("c");
        }

            
        private void btnLibraryMovie_Click(object sender, EventArgs e)
        {
            frmLibrary NewLibrary = new frmLibrary();                         //Create a new instance
            NewLibrary.ShowDialog();                                          //Shows frmLibrary form
            fee = fee + Decimal.Parse(NewLibrary.Tag.ToString());
            lblTotalLateFee.Text = fee.ToString("c");
        }

        
        private void btnKidsMovie_Click(object sender, EventArgs e)
        {
            frmKids NewKids = new frmKids();                                 //Create a new instance
            NewKids.ShowDialog();                                             //Shows frmKids form
            fee = fee + Decimal.Parse(NewKids.Tag.ToString());
            lblTotalLateFee.Text = fee.ToString("c");
        }

        private void addOrRemove_Click(object sender, EventArgs e)
        {
            frmRentalMain rentalMaintain = new frmRentalMain();
            rentalMaintain.ShowDialog();
        }
    }
}
