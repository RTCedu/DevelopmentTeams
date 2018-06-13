namespace DevelopmentTeamProject
{
    partial class Form1
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
            this.gboMemberOne = new System.Windows.Forms.GroupBox();
            this.gboDrinkOptions = new System.Windows.Forms.GroupBox();
            this.gboPizzaOptions = new System.Windows.Forms.GroupBox();
            this.rdbHawaiianPizza = new System.Windows.Forms.RadioButton();
            this.rdbPepperoniPizza = new System.Windows.Forms.RadioButton();
            this.rdbCheesePizza = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gboMemberTwo = new System.Windows.Forms.GroupBox();
            this.gboMemberThree = new System.Windows.Forms.GroupBox();
            this.rdbLargeDrink = new System.Windows.Forms.RadioButton();
            this.rdbSmallDrink = new System.Windows.Forms.RadioButton();
            this.rdbNoDrink = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalculateLoan = new System.Windows.Forms.Button();
            this.lblLoanTotal = new System.Windows.Forms.Label();
            this.txtLoanTotal = new System.Windows.Forms.TextBox();
            this.txtMonthlyPayments = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.btnCircleCalc = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCircumference = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gboMemberOne.SuspendLayout();
            this.gboDrinkOptions.SuspendLayout();
            this.gboPizzaOptions.SuspendLayout();
            this.gboMemberTwo.SuspendLayout();
            this.gboMemberThree.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboMemberOne
            // 
            this.gboMemberOne.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gboMemberOne.Controls.Add(this.txtTotal);
            this.gboMemberOne.Controls.Add(this.lblTotal);
            this.gboMemberOne.Controls.Add(this.txtTax);
            this.gboMemberOne.Controls.Add(this.label2);
            this.gboMemberOne.Controls.Add(this.txtSubtotal);
            this.gboMemberOne.Controls.Add(this.lblSubTotal);
            this.gboMemberOne.Controls.Add(this.btnOrder);
            this.gboMemberOne.Controls.Add(this.gboDrinkOptions);
            this.gboMemberOne.Controls.Add(this.gboPizzaOptions);
            this.gboMemberOne.Controls.Add(this.label1);
            this.gboMemberOne.Location = new System.Drawing.Point(12, 12);
            this.gboMemberOne.Name = "gboMemberOne";
            this.gboMemberOne.Size = new System.Drawing.Size(250, 479);
            this.gboMemberOne.TabIndex = 0;
            this.gboMemberOne.TabStop = false;
            this.gboMemberOne.Text = "Problem One";
            // 
            // gboDrinkOptions
            // 
            this.gboDrinkOptions.Controls.Add(this.rdbLargeDrink);
            this.gboDrinkOptions.Controls.Add(this.rdbSmallDrink);
            this.gboDrinkOptions.Controls.Add(this.rdbNoDrink);
            this.gboDrinkOptions.Location = new System.Drawing.Point(6, 207);
            this.gboDrinkOptions.Name = "gboDrinkOptions";
            this.gboDrinkOptions.Size = new System.Drawing.Size(238, 116);
            this.gboDrinkOptions.TabIndex = 2;
            this.gboDrinkOptions.TabStop = false;
            this.gboDrinkOptions.Text = "Drink";
            // 
            // gboPizzaOptions
            // 
            this.gboPizzaOptions.Controls.Add(this.rdbHawaiianPizza);
            this.gboPizzaOptions.Controls.Add(this.rdbPepperoniPizza);
            this.gboPizzaOptions.Controls.Add(this.rdbCheesePizza);
            this.gboPizzaOptions.Location = new System.Drawing.Point(6, 82);
            this.gboPizzaOptions.Name = "gboPizzaOptions";
            this.gboPizzaOptions.Size = new System.Drawing.Size(238, 119);
            this.gboPizzaOptions.TabIndex = 1;
            this.gboPizzaOptions.TabStop = false;
            this.gboPizzaOptions.Text = "Pizza";
            // 
            // rdbHawaiianPizza
            // 
            this.rdbHawaiianPizza.AutoSize = true;
            this.rdbHawaiianPizza.Location = new System.Drawing.Point(6, 83);
            this.rdbHawaiianPizza.Name = "rdbHawaiianPizza";
            this.rdbHawaiianPizza.Size = new System.Drawing.Size(168, 23);
            this.rdbHawaiianPizza.TabIndex = 2;
            this.rdbHawaiianPizza.Text = "Hawai\'ian Pizza $11.00";
            this.rdbHawaiianPizza.UseVisualStyleBackColor = true;
            // 
            // rdbPepperoniPizza
            // 
            this.rdbPepperoniPizza.AutoSize = true;
            this.rdbPepperoniPizza.Location = new System.Drawing.Point(6, 54);
            this.rdbPepperoniPizza.Name = "rdbPepperoniPizza";
            this.rdbPepperoniPizza.Size = new System.Drawing.Size(172, 23);
            this.rdbPepperoniPizza.TabIndex = 1;
            this.rdbPepperoniPizza.Text = "Pepperoni Pizza $10.00";
            this.rdbPepperoniPizza.UseVisualStyleBackColor = true;
            // 
            // rdbCheesePizza
            // 
            this.rdbCheesePizza.AutoSize = true;
            this.rdbCheesePizza.Checked = true;
            this.rdbCheesePizza.Location = new System.Drawing.Point(6, 25);
            this.rdbCheesePizza.Name = "rdbCheesePizza";
            this.rdbCheesePizza.Size = new System.Drawing.Size(147, 23);
            this.rdbCheesePizza.TabIndex = 0;
            this.rdbCheesePizza.TabStop = true;
            this.rdbCheesePizza.Text = "Cheese Pizza $9.00";
            this.rdbCheesePizza.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fill in code to add up subtotal, \r\ntax, and total.\r\nTax should be 10%.";
            // 
            // gboMemberTwo
            // 
            this.gboMemberTwo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gboMemberTwo.Controls.Add(this.txtMonthlyPayments);
            this.gboMemberTwo.Controls.Add(this.label6);
            this.gboMemberTwo.Controls.Add(this.txtLoanTotal);
            this.gboMemberTwo.Controls.Add(this.lblLoanTotal);
            this.gboMemberTwo.Controls.Add(this.btnCalculateLoan);
            this.gboMemberTwo.Controls.Add(this.groupBox1);
            this.gboMemberTwo.Controls.Add(this.label3);
            this.gboMemberTwo.Location = new System.Drawing.Point(268, 12);
            this.gboMemberTwo.Name = "gboMemberTwo";
            this.gboMemberTwo.Size = new System.Drawing.Size(250, 479);
            this.gboMemberTwo.TabIndex = 1;
            this.gboMemberTwo.TabStop = false;
            this.gboMemberTwo.Text = "Problem Two";
            // 
            // gboMemberThree
            // 
            this.gboMemberThree.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gboMemberThree.Controls.Add(this.txtArea);
            this.gboMemberThree.Controls.Add(this.btnCircleCalc);
            this.gboMemberThree.Controls.Add(this.label9);
            this.gboMemberThree.Controls.Add(this.groupBox2);
            this.gboMemberThree.Controls.Add(this.txtCircumference);
            this.gboMemberThree.Controls.Add(this.label10);
            this.gboMemberThree.Controls.Add(this.label7);
            this.gboMemberThree.Location = new System.Drawing.Point(524, 12);
            this.gboMemberThree.Name = "gboMemberThree";
            this.gboMemberThree.Size = new System.Drawing.Size(250, 479);
            this.gboMemberThree.TabIndex = 1;
            this.gboMemberThree.TabStop = false;
            this.gboMemberThree.Text = "Problem Three";
            // 
            // rdbLargeDrink
            // 
            this.rdbLargeDrink.AutoSize = true;
            this.rdbLargeDrink.Location = new System.Drawing.Point(6, 83);
            this.rdbLargeDrink.Name = "rdbLargeDrink";
            this.rdbLargeDrink.Size = new System.Drawing.Size(140, 23);
            this.rdbLargeDrink.TabIndex = 5;
            this.rdbLargeDrink.Text = "Large Drink $3.50";
            this.rdbLargeDrink.UseVisualStyleBackColor = true;
            // 
            // rdbSmallDrink
            // 
            this.rdbSmallDrink.AutoSize = true;
            this.rdbSmallDrink.Location = new System.Drawing.Point(6, 54);
            this.rdbSmallDrink.Name = "rdbSmallDrink";
            this.rdbSmallDrink.Size = new System.Drawing.Size(138, 23);
            this.rdbSmallDrink.TabIndex = 4;
            this.rdbSmallDrink.Text = "Small Drink $2.50";
            this.rdbSmallDrink.UseVisualStyleBackColor = true;
            // 
            // rdbNoDrink
            // 
            this.rdbNoDrink.AutoSize = true;
            this.rdbNoDrink.Checked = true;
            this.rdbNoDrink.Location = new System.Drawing.Point(6, 25);
            this.rdbNoDrink.Name = "rdbNoDrink";
            this.rdbNoDrink.Size = new System.Drawing.Size(85, 23);
            this.rdbNoDrink.TabIndex = 3;
            this.rdbNoDrink.TabStop = true;
            this.rdbNoDrink.Text = "No Drink";
            this.rdbNoDrink.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(6, 329);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(238, 45);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(6, 383);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(59, 19);
            this.lblSubTotal.TabIndex = 4;
            this.lblSubTotal.Text = "Subtotal";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(144, 380);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 26);
            this.txtSubtotal.TabIndex = 5;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(144, 412);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 26);
            this.txtTax.TabIndex = 7;
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tax (10%)";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(144, 444);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 447);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 19);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 57);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fill in code to calculate Mortgage \r\ntotal based on Loan Amount, \r\nInterest, and " +
    "Time.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYears);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtInterest);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtLoanAmount);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Location = new System.Drawing.Point(6, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 124);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Information";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(7, 26);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(91, 19);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Loan Amount";
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Location = new System.Drawing.Point(132, 23);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(100, 26);
            this.txtLoanAmount.TabIndex = 1;
            this.txtLoanAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(132, 55);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(100, 26);
            this.txtInterest.TabIndex = 3;
            this.txtInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Interest Rate (%)";
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(132, 87);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(100, 26);
            this.txtYears.TabIndex = 5;
            this.txtYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Period (Years)";
            // 
            // btnCalculateLoan
            // 
            this.btnCalculateLoan.Location = new System.Drawing.Point(6, 218);
            this.btnCalculateLoan.Name = "btnCalculateLoan";
            this.btnCalculateLoan.Size = new System.Drawing.Size(238, 45);
            this.btnCalculateLoan.TabIndex = 10;
            this.btnCalculateLoan.Text = "Calculate Loan Total";
            this.btnCalculateLoan.UseVisualStyleBackColor = true;
            this.btnCalculateLoan.Click += new System.EventHandler(this.btnCalculateLoan_Click);
            // 
            // lblLoanTotal
            // 
            this.lblLoanTotal.AutoSize = true;
            this.lblLoanTotal.Location = new System.Drawing.Point(6, 272);
            this.lblLoanTotal.Name = "lblLoanTotal";
            this.lblLoanTotal.Size = new System.Drawing.Size(39, 19);
            this.lblLoanTotal.TabIndex = 11;
            this.lblLoanTotal.Text = "Total";
            // 
            // txtLoanTotal
            // 
            this.txtLoanTotal.Location = new System.Drawing.Point(138, 269);
            this.txtLoanTotal.Name = "txtLoanTotal";
            this.txtLoanTotal.ReadOnly = true;
            this.txtLoanTotal.Size = new System.Drawing.Size(100, 26);
            this.txtLoanTotal.TabIndex = 12;
            this.txtLoanTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMonthlyPayments
            // 
            this.txtMonthlyPayments.Location = new System.Drawing.Point(138, 301);
            this.txtMonthlyPayments.Name = "txtMonthlyPayments";
            this.txtMonthlyPayments.ReadOnly = true;
            this.txtMonthlyPayments.Size = new System.Drawing.Size(100, 26);
            this.txtMonthlyPayments.TabIndex = 14;
            this.txtMonthlyPayments.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Monthly Payments";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 76);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fill in code to calculate the \r\nCircumfrance of a circle based on\r\nthe radius, an" +
    "d to calculate the\r\nArea of the circle.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRadius);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(6, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 54);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Radius Input";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Radius";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(132, 19);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 26);
            this.txtRadius.TabIndex = 1;
            // 
            // btnCircleCalc
            // 
            this.btnCircleCalc.Location = new System.Drawing.Point(6, 165);
            this.btnCircleCalc.Name = "btnCircleCalc";
            this.btnCircleCalc.Size = new System.Drawing.Size(238, 45);
            this.btnCircleCalc.TabIndex = 15;
            this.btnCircleCalc.Text = "Calculate Circumference and Area";
            this.btnCircleCalc.UseVisualStyleBackColor = true;
            this.btnCircleCalc.Click += new System.EventHandler(this.btnCircleCalc_Click);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(144, 248);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(100, 26);
            this.txtArea.TabIndex = 18;
            this.txtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Area";
            // 
            // txtCircumference
            // 
            this.txtCircumference.Location = new System.Drawing.Point(144, 216);
            this.txtCircumference.Name = "txtCircumference";
            this.txtCircumference.ReadOnly = true;
            this.txtCircumference.Size = new System.Drawing.Size(100, 26);
            this.txtCircumference.TabIndex = 16;
            this.txtCircumference.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "Circumference";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 504);
            this.Controls.Add(this.gboMemberThree);
            this.Controls.Add(this.gboMemberTwo);
            this.Controls.Add(this.gboMemberOne);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Development Team Project";
            this.gboMemberOne.ResumeLayout(false);
            this.gboMemberOne.PerformLayout();
            this.gboDrinkOptions.ResumeLayout(false);
            this.gboDrinkOptions.PerformLayout();
            this.gboPizzaOptions.ResumeLayout(false);
            this.gboPizzaOptions.PerformLayout();
            this.gboMemberTwo.ResumeLayout(false);
            this.gboMemberTwo.PerformLayout();
            this.gboMemberThree.ResumeLayout(false);
            this.gboMemberThree.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboMemberOne;
        private System.Windows.Forms.GroupBox gboPizzaOptions;
        private System.Windows.Forms.RadioButton rdbHawaiianPizza;
        private System.Windows.Forms.RadioButton rdbPepperoniPizza;
        private System.Windows.Forms.RadioButton rdbCheesePizza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboMemberTwo;
        private System.Windows.Forms.GroupBox gboMemberThree;
        private System.Windows.Forms.GroupBox gboDrinkOptions;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.RadioButton rdbLargeDrink;
        private System.Windows.Forms.RadioButton rdbSmallDrink;
        private System.Windows.Forms.RadioButton rdbNoDrink;
        private System.Windows.Forms.TextBox txtLoanTotal;
        private System.Windows.Forms.Label lblLoanTotal;
        private System.Windows.Forms.Button btnCalculateLoan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMonthlyPayments;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnCircleCalc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCircumference;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
    }
}

