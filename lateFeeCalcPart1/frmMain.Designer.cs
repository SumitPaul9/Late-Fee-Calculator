namespace lateFeeCalcPart1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewRelease = new System.Windows.Forms.Button();
            this.btnLibraryMovies = new System.Windows.Forms.Button();
            this.btnKidsMovies = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalLateFee = new System.Windows.Forms.Label();
            this.addOrRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(64, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Late Fee Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNewRelease
            // 
            this.btnNewRelease.Location = new System.Drawing.Point(99, 120);
            this.btnNewRelease.Name = "btnNewRelease";
            this.btnNewRelease.Size = new System.Drawing.Size(113, 25);
            this.btnNewRelease.TabIndex = 1;
            this.btnNewRelease.Text = "&New Release";
            this.btnNewRelease.UseVisualStyleBackColor = true;
            this.btnNewRelease.Click += new System.EventHandler(this.btnNewRealse_Click);
            // 
            // btnLibraryMovies
            // 
            this.btnLibraryMovies.Location = new System.Drawing.Point(99, 165);
            this.btnLibraryMovies.Name = "btnLibraryMovies";
            this.btnLibraryMovies.Size = new System.Drawing.Size(113, 25);
            this.btnLibraryMovies.TabIndex = 2;
            this.btnLibraryMovies.Text = "&Library Movies";
            this.btnLibraryMovies.UseVisualStyleBackColor = true;
            this.btnLibraryMovies.Click += new System.EventHandler(this.btnLibraryMovie_Click);
            // 
            // btnKidsMovies
            // 
            this.btnKidsMovies.Location = new System.Drawing.Point(99, 212);
            this.btnKidsMovies.Name = "btnKidsMovies";
            this.btnKidsMovies.Size = new System.Drawing.Size(113, 25);
            this.btnKidsMovies.TabIndex = 3;
            this.btnKidsMovies.Text = "&Kids Movies";
            this.btnKidsMovies.UseVisualStyleBackColor = true;
            this.btnKidsMovies.Click += new System.EventHandler(this.btnKidsMovie_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(99, 294);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 25);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(66, 79);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(76, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total Late fee:";
            // 
            // lblTotalLateFee
            // 
            this.lblTotalLateFee.AutoSize = true;
            this.lblTotalLateFee.Location = new System.Drawing.Point(166, 79);
            this.lblTotalLateFee.Name = "lblTotalLateFee";
            this.lblTotalLateFee.Size = new System.Drawing.Size(0, 13);
            this.lblTotalLateFee.TabIndex = 6;
            // 
            // addOrRemove
            // 
            this.addOrRemove.Location = new System.Drawing.Point(99, 254);
            this.addOrRemove.Name = "addOrRemove";
            this.addOrRemove.Size = new System.Drawing.Size(113, 23);
            this.addOrRemove.TabIndex = 4;
            this.addOrRemove.Text = "Add/Remove Movie";
            this.addOrRemove.UseVisualStyleBackColor = true;
            this.addOrRemove.Click += new System.EventHandler(this.addOrRemove_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(316, 362);
            this.Controls.Add(this.addOrRemove);
            this.Controls.Add(this.lblTotalLateFee);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnKidsMovies);
            this.Controls.Add(this.btnLibraryMovies);
            this.Controls.Add(this.btnNewRelease);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Late Fee Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewRelease;
        private System.Windows.Forms.Button btnLibraryMovies;
        private System.Windows.Forms.Button btnKidsMovies;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalLateFee;
        private System.Windows.Forms.Button addOrRemove;
    }
}

