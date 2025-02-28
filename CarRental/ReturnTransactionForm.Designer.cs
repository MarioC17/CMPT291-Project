﻿
namespace CarRental
{
    partial class ReturnTransactionForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.mileageUsed = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.customerIDBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.returnBranch = new System.Windows.Forms.ComboBox();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.listOfRentals = new System.Windows.Forms.DataGridView();
            this.rentalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickUpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickUpBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.make = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyPricing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weeklyPricing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyPricing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lateFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestedClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.baseCost = new System.Windows.Forms.TextBox();
            this.lateCost = new System.Windows.Forms.TextBox();
            this.changeBranchCost = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfRentals)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Return Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mileage Used";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // mileageUsed
            // 
            this.mileageUsed.Location = new System.Drawing.Point(15, 91);
            this.mileageUsed.Name = "mileageUsed";
            this.mileageUsed.Size = new System.Drawing.Size(100, 23);
            this.mileageUsed.TabIndex = 3;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(20, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Customer ID";
            // 
            // customerIDBox
            // 
            this.customerIDBox.FormattingEnabled = true;
            this.customerIDBox.Location = new System.Drawing.Point(18, 49);
            this.customerIDBox.Name = "customerIDBox";
            this.customerIDBox.Size = new System.Drawing.Size(121, 23);
            this.customerIDBox.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.loadButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.result);
            this.groupBox1.Controls.Add(this.calculateButton);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.listOfRentals);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.customerIDBox);
            this.groupBox1.Location = new System.Drawing.Point(20, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 696);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Return Form";
            // 
            // loadButton
            // 
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.loadButton.Location = new System.Drawing.Point(166, 48);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(158, 23);
            this.loadButton.TabIndex = 49;
            this.loadButton.Text = "Load Ongoing Rentals";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(256, 653);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 48;
            this.label4.Text = "Total Fee";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(337, 653);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(166, 23);
            this.result.TabIndex = 47;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(528, 456);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(126, 30);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "Calculate Total Fee";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.returnBranch);
            this.groupBox2.Controls.Add(this.returnDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.mileageUsed);
            this.groupBox2.Location = new System.Drawing.Point(18, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 128);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Return Branch";
            // 
            // returnBranch
            // 
            this.returnBranch.FormattingEnabled = true;
            this.returnBranch.Location = new System.Drawing.Point(237, 37);
            this.returnBranch.Name = "returnBranch";
            this.returnBranch.Size = new System.Drawing.Size(121, 23);
            this.returnBranch.TabIndex = 14;
            this.returnBranch.SelectedIndexChanged += new System.EventHandler(this.returnBranch_SelectedIndexChanged);
            // 
            // returnDate
            // 
            this.returnDate.Location = new System.Drawing.Point(15, 37);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(200, 23);
            this.returnDate.TabIndex = 16;
            // 
            // listOfRentals
            // 
            this.listOfRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfRentals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentalID,
            this.pickUpDate,
            this.expectedDate,
            this.pickUpBranch,
            this.carID,
            this.make,
            this.model,
            this.year,
            this.dailyPricing,
            this.weeklyPricing,
            this.monthlyPricing,
            this.lateFee,
            this.changeBranch,
            this.employeeID,
            this.requestedClass});
            this.listOfRentals.Location = new System.Drawing.Point(18, 90);
            this.listOfRentals.Name = "listOfRentals";
            this.listOfRentals.RowTemplate.Height = 25;
            this.listOfRentals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listOfRentals.Size = new System.Drawing.Size(636, 226);
            this.listOfRentals.TabIndex = 13;
            this.listOfRentals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listOfRentals_CellContentClick);
            // 
            // rentalID
            // 
            this.rentalID.HeaderText = "Rental ID";
            this.rentalID.Name = "rentalID";
            this.rentalID.ReadOnly = true;
            // 
            // pickUpDate
            // 
            this.pickUpDate.HeaderText = "Pick-Up Date";
            this.pickUpDate.Name = "pickUpDate";
            this.pickUpDate.ReadOnly = true;
            // 
            // expectedDate
            // 
            this.expectedDate.HeaderText = "Expected Date";
            this.expectedDate.Name = "expectedDate";
            this.expectedDate.ReadOnly = true;
            // 
            // pickUpBranch
            // 
            this.pickUpBranch.HeaderText = "Pick-Up Branch ID";
            this.pickUpBranch.Name = "pickUpBranch";
            this.pickUpBranch.ReadOnly = true;
            // 
            // carID
            // 
            this.carID.HeaderText = "Car ID";
            this.carID.Name = "carID";
            this.carID.ReadOnly = true;
            // 
            // make
            // 
            this.make.HeaderText = "Make";
            this.make.Name = "make";
            this.make.ReadOnly = true;
            // 
            // model
            // 
            this.model.HeaderText = "Model";
            this.model.Name = "model";
            this.model.ReadOnly = true;
            // 
            // year
            // 
            this.year.HeaderText = "Year";
            this.year.Name = "year";
            this.year.ReadOnly = true;
            // 
            // dailyPricing
            // 
            this.dailyPricing.HeaderText = "Daily Pricing";
            this.dailyPricing.Name = "dailyPricing";
            this.dailyPricing.ReadOnly = true;
            // 
            // weeklyPricing
            // 
            this.weeklyPricing.HeaderText = "Weekly Pricing";
            this.weeklyPricing.Name = "weeklyPricing";
            this.weeklyPricing.ReadOnly = true;
            // 
            // monthlyPricing
            // 
            this.monthlyPricing.HeaderText = "Monthly Pricing";
            this.monthlyPricing.Name = "monthlyPricing";
            this.monthlyPricing.ReadOnly = true;
            // 
            // lateFee
            // 
            this.lateFee.HeaderText = "Late Fee";
            this.lateFee.Name = "lateFee";
            this.lateFee.ReadOnly = true;
            // 
            // changeBranch
            // 
            this.changeBranch.HeaderText = "Different Return Branch Fee";
            this.changeBranch.Name = "changeBranch";
            this.changeBranch.ReadOnly = true;
            // 
            // employeeID
            // 
            this.employeeID.HeaderText = "Employee ID";
            this.employeeID.Name = "employeeID";
            this.employeeID.ReadOnly = true;
            // 
            // requestedClass
            // 
            this.requestedClass.HeaderText = "Requested Car Type ID";
            this.requestedClass.Name = "requestedClass";
            this.requestedClass.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(619, 759);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.changeBranchCost);
            this.groupBox3.Controls.Add(this.lateCost);
            this.groupBox3.Controls.Add(this.baseCost);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(33, 495);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(470, 142);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Breakdown of Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Base Fee:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Late Fee:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Diff Branch Fee:";
            // 
            // baseCost
            // 
            this.baseCost.Location = new System.Drawing.Point(335, 36);
            this.baseCost.Name = "baseCost";
            this.baseCost.Size = new System.Drawing.Size(100, 23);
            this.baseCost.TabIndex = 3;
            // 
            // lateCost
            // 
            this.lateCost.Location = new System.Drawing.Point(335, 65);
            this.lateCost.Name = "lateCost";
            this.lateCost.Size = new System.Drawing.Size(100, 23);
            this.lateCost.TabIndex = 4;
            // 
            // changeBranchCost
            // 
            this.changeBranchCost.Location = new System.Drawing.Point(335, 94);
            this.changeBranchCost.Name = "changeBranchCost";
            this.changeBranchCost.Size = new System.Drawing.Size(100, 23);
            this.changeBranchCost.TabIndex = 5;
            // 
            // ReturnTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 819);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backButton);
            this.Name = "ReturnTransactionForm";
            this.Text = "ReturnTransactionForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfRentals)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mileageUsed;
#pragma warning disable CS0169 // The field 'ReturnTransactionForm.button1' is never used
        private System.Windows.Forms.Button button1;
#pragma warning restore CS0169 // The field 'ReturnTransactionForm.button1' is never used
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox customerIDBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker returnDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox returnBranch;
        private System.Windows.Forms.DataGridView listOfRentals;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button loadButton;
#pragma warning disable CS0169 // The field 'ReturnTransactionForm.rn' is never used
        private System.Windows.Forms.ComboBox rn;
#pragma warning restore CS0169 // The field 'ReturnTransactionForm.rn' is never used
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pickUpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn expectedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn pickUpBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn carID;
        private System.Windows.Forms.DataGridViewTextBoxColumn make;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyPricing;
        private System.Windows.Forms.DataGridViewTextBoxColumn weeklyPricing;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyPricing;
        private System.Windows.Forms.DataGridViewTextBoxColumn lateFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestedClass;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox changeBranchCost;
        private System.Windows.Forms.TextBox lateCost;
        private System.Windows.Forms.TextBox baseCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}