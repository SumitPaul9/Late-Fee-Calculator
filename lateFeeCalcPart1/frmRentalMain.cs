using RentalMaintenance;
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
    public partial class frmRentalMain : Form
    {
        public frmRentalMain()
        {
            InitializeComponent();
        }

        private List<RentalItem> rentalItems = null;

        private void frmRentalMaintenance_Load(object sender, EventArgs e)
        {
            rentalItems = RentalItemDB.GetMovies();                 //Function call
            FillMovieListBox();                                     //Function call
        }

        private void FillMovieListBox()
        {
            lstFillMovie.Items.Clear();
            foreach (RentalItem p in rentalItems)
            {
                lstFillMovie.Items.Add(p.GetDisplayText());
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)             // add event to add new movie to list 
        {
            frmNewMovie newMovieForm = new frmNewMovie();                   //new instance
            RentalItem rentalItem = newMovieForm.GetNewRental();
            if (rentalItem != null)
            {
                rentalItems.Add(rentalItem);                                //add items
                RentalItemDB.SaveMovies(rentalItems);                       //Save items
                FillMovieListBox();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

            int i = lstFillMovie.SelectedIndex;
            if (i != -1)
            {
                RentalItem rentalitem = (RentalItem)rentalItems[i];
                string message = "Are you sure you want to delete "             //delete confirmation
                    + rentalitem.Description + "?";
                DialogResult button =
                    MessageBox.Show(message, "Confirm Delete",                  //message to confirm
                    MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    rentalItems.Remove(rentalitem);
                    RentalItemDB.SaveMovies(rentalItems);
                    FillMovieListBox();
                }
            }
        }
    }
}
