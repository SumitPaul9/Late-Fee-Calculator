namespace lateFeeCalcPart1
{
    partial class frmKids
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.txtDue = new System.Windows.Forms.TextBox();
            this.lateFeeLabel = new System.Windows.Forms.Label();
            this.daysLateLabel = new System.Windows.Forms.Label();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumberOfMovies = new System.Windows.Forms.Label();
            this.txtCustomerType = new System.Windows.Forms.TextBox();
            this.lblCustomertype = new System.Windows.Forms.Label();
            this.lblnumber = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturn.Location = new System.Drawing.Point(190, 320);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(86, 26);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(75, 320);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(86, 26);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(176, 262);
            this.txtFee.Name = "txtFee";
            this.txtFee.ReadOnly = true;
            this.txtFee.Size = new System.Drawing.Size(100, 20);
            this.txtFee.TabIndex = 4;
            this.txtFee.TabStop = false;
            this.txtFee.TextChanged += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(176, 226);
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 3;
            this.txtNum.TabStop = false;
            // 
            // txtCurrent
            // 
            this.txtCurrent.Location = new System.Drawing.Point(176, 118);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(100, 20);
            this.txtCurrent.TabIndex = 2;
            // 
            // txtDue
            // 
            this.txtDue.Location = new System.Drawing.Point(176, 82);
            this.txtDue.Name = "txtDue";
            this.txtDue.Size = new System.Drawing.Size(100, 20);
            this.txtDue.TabIndex = 1;
            // 
            // lateFeeLabel
            // 
            this.lateFeeLabel.AutoSize = true;
            this.lateFeeLabel.Location = new System.Drawing.Point(51, 264);
            this.lateFeeLabel.Name = "lateFeeLabel";
            this.lateFeeLabel.Size = new System.Drawing.Size(52, 13);
            this.lateFeeLabel.TabIndex = 14;
            this.lateFeeLabel.Text = "Late Fee:";
            // 
            // daysLateLabel
            // 
            this.daysLateLabel.AutoSize = true;
            this.daysLateLabel.Location = new System.Drawing.Point(51, 229);
            this.daysLateLabel.Name = "daysLateLabel";
            this.daysLateLabel.Size = new System.Drawing.Size(110, 13);
            this.daysLateLabel.TabIndex = 13;
            this.daysLateLabel.Text = "Number of Days Late:";
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Location = new System.Drawing.Point(51, 124);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(70, 13);
            this.currentDateLabel.TabIndex = 12;
            this.currentDateLabel.Text = "Current Date:";
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Location = new System.Drawing.Point(51, 89);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(56, 13);
            this.dueDateLabel.TabIndex = 10;
            this.dueDateLabel.Text = "Due Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(104, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kids Movies";
            // 
            // lblNumberOfMovies
            // 
            this.lblNumberOfMovies.AutoSize = true;
            this.lblNumberOfMovies.Location = new System.Drawing.Point(51, 159);
            this.lblNumberOfMovies.Name = "lblNumberOfMovies";
            this.lblNumberOfMovies.Size = new System.Drawing.Size(98, 13);
            this.lblNumberOfMovies.TabIndex = 27;
            this.lblNumberOfMovies.Text = "Number of movies: ";
            // 
            // txtCustomerType
            // 
            this.txtCustomerType.Location = new System.Drawing.Point(176, 190);
            this.txtCustomerType.Name = "txtCustomerType";
            this.txtCustomerType.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerType.TabIndex = 4;
            // 
            // lblCustomertype
            // 
            this.lblCustomertype.AutoSize = true;
            this.lblCustomertype.Location = new System.Drawing.Point(51, 194);
            this.lblCustomertype.Name = "lblCustomertype";
            this.lblCustomertype.Size = new System.Drawing.Size(81, 13);
            this.lblCustomertype.TabIndex = 30;
            this.lblCustomertype.Text = "Customer Type:";
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Location = new System.Drawing.Point(173, 159);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(0, 13);
            this.lblnumber.TabIndex = 34;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(307, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmKids
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnReturn;
            this.ClientSize = new System.Drawing.Size(406, 362);
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
            this.Controls.Add(this.currentDateLabel);
            this.Controls.Add(this.dueDateLabel);
            this.Name = "frmKids";
            this.Text = "Kids movies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.TextBox txtDue;
        private System.Windows.Forms.Label lateFeeLabel;
        private System.Windows.Forms.Label daysLateLabel;
        private System.Windows.Forms.Label currentDateLabel;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumberOfMovies;
        private System.Windows.Forms.TextBox txtCustomerType;
        private System.Windows.Forms.Label lblCustomertype;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.Button btnAdd;
    }
}