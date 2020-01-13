namespace lateFeeCalcPart1
{
    partial class frmNew
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
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.CurrentDateLabel = new System.Windows.Forms.Label();
            this.daysLateLabel = new System.Windows.Forms.Label();
            this.lateFeeLabel = new System.Windows.Forms.Label();
            this.txtDue = new System.Windows.Forms.TextBox();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumberOfMovies = new System.Windows.Forms.Label();
            this.txtCustomerType = new System.Windows.Forms.TextBox();
            this.lblCustomertype = new System.Windows.Forms.Label();
            this.lblnumber = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Location = new System.Drawing.Point(65, 84);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(56, 13);
            this.dueDateLabel.TabIndex = 0;
            this.dueDateLabel.Text = "Due Date:";
            this.dueDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CurrentDateLabel
            // 
            this.CurrentDateLabel.AutoSize = true;
            this.CurrentDateLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CurrentDateLabel.Location = new System.Drawing.Point(65, 117);
            this.CurrentDateLabel.Name = "CurrentDateLabel";
            this.CurrentDateLabel.Size = new System.Drawing.Size(70, 13);
            this.CurrentDateLabel.TabIndex = 1;
            this.CurrentDateLabel.Text = "Current Date:";
            this.CurrentDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // daysLateLabel
            // 
            this.daysLateLabel.AutoSize = true;
            this.daysLateLabel.Location = new System.Drawing.Point(65, 216);
            this.daysLateLabel.Name = "daysLateLabel";
            this.daysLateLabel.Size = new System.Drawing.Size(110, 13);
            this.daysLateLabel.TabIndex = 2;
            this.daysLateLabel.Text = "Number of Days Late:";
            this.daysLateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lateFeeLabel
            // 
            this.lateFeeLabel.AutoSize = true;
            this.lateFeeLabel.Location = new System.Drawing.Point(65, 249);
            this.lateFeeLabel.Name = "lateFeeLabel";
            this.lateFeeLabel.Size = new System.Drawing.Size(52, 13);
            this.lateFeeLabel.TabIndex = 3;
            this.lateFeeLabel.Text = "Late Fee:";
            this.lateFeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDue
            // 
            this.txtDue.Location = new System.Drawing.Point(190, 81);
            this.txtDue.Name = "txtDue";
            this.txtDue.Size = new System.Drawing.Size(100, 20);
            this.txtDue.TabIndex = 1;
            // 
            // txtCurrent
            // 
            this.txtCurrent.Location = new System.Drawing.Point(190, 114);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(100, 20);
            this.txtCurrent.TabIndex = 2;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(190, 213);
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 3;
            this.txtNum.TabStop = false;
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(190, 246);
            this.txtFee.Name = "txtFee";
            this.txtFee.ReadOnly = true;
            this.txtFee.Size = new System.Drawing.Size(100, 20);
            this.txtFee.TabIndex = 4;
            this.txtFee.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(65, 289);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(98, 26);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturn.Location = new System.Drawing.Point(205, 289);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(98, 26);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(106, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "New Releases";
            // 
            // lblNumberOfMovies
            // 
            this.lblNumberOfMovies.AutoSize = true;
            this.lblNumberOfMovies.Location = new System.Drawing.Point(65, 183);
            this.lblNumberOfMovies.Name = "lblNumberOfMovies";
            this.lblNumberOfMovies.Size = new System.Drawing.Size(98, 13);
            this.lblNumberOfMovies.TabIndex = 25;
            this.lblNumberOfMovies.Text = "Number of movies: ";
            // 
            // txtCustomerType
            // 
            this.txtCustomerType.Location = new System.Drawing.Point(190, 150);
            this.txtCustomerType.Name = "txtCustomerType";
            this.txtCustomerType.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerType.TabIndex = 4;
            // 
            // lblCustomertype
            // 
            this.lblCustomertype.AutoSize = true;
            this.lblCustomertype.Location = new System.Drawing.Point(65, 150);
            this.lblCustomertype.Name = "lblCustomertype";
            this.lblCustomertype.Size = new System.Drawing.Size(81, 13);
            this.lblCustomertype.TabIndex = 32;
            this.lblCustomertype.Text = "Customer Type:";
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Location = new System.Drawing.Point(187, 183);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(0, 13);
            this.lblnumber.TabIndex = 33;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(338, 183);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmNew
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnReturn;
            this.ClientSize = new System.Drawing.Size(452, 335);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblnumber);
            this.Controls.Add(this.txtCustomerType);
            this.Controls.Add(this.lblCustomertype);
            this.Controls.Add(this.lblNumberOfMovies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.txtDue);
            this.Controls.Add(this.lateFeeLabel);
            this.Controls.Add(this.daysLateLabel);
            this.Controls.Add(this.CurrentDateLabel);
            this.Controls.Add(this.dueDateLabel);
            this.Name = "frmNew";
            this.Text = "New Releases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.Label CurrentDateLabel;
        private System.Windows.Forms.Label daysLateLabel;
        private System.Windows.Forms.Label lateFeeLabel;
        private System.Windows.Forms.TextBox txtDue;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumberOfMovies;
        private System.Windows.Forms.TextBox txtCustomerType;
        private System.Windows.Forms.Label lblCustomertype;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.Button btnAdd;
    }
}