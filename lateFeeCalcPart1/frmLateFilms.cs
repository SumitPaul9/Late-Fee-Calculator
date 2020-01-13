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
    public partial class frmLateFilms : Form
    {
        public frmLateFilms()
        {
            InitializeComponent();
        }

        SortedList<Int32, string> movieList = new SortedList<Int32, string>();
        Int32 cou = 0;
        private void btnOk_Click(object sender, EventArgs e)
        {
            String name;
            name = txtName.ToString();
            movieList.Add(cou, name);
            cou++;
            this.Tag = movieList.Count;
            this.DialogResult = DialogResult.OK;

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
