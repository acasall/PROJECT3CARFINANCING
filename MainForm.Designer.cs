namespace PROJECT3CARFINANCING
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbCarPurchase = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShowPay = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.lstMonthly = new System.Windows.Forms.ListBox();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.lblCar = new System.Windows.Forms.Label();
            this.cmbCar = new System.Windows.Forms.ComboBox();
            this.txtInitialPay = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblInitialPay = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbPurchasesMade = new System.Windows.Forms.TabPage();
            this.lstPrevPurchases = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tbCarPurchase.SuspendLayout();
            this.tbPurchasesMade.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbCarPurchase);
            this.tabControl1.Controls.Add(this.tbPurchasesMade);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 310);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tbCarPurchase
            // 
            this.tbCarPurchase.Controls.Add(this.btnExit);
            this.tbCarPurchase.Controls.Add(this.btnClear);
            this.tbCarPurchase.Controls.Add(this.btnShowPay);
            this.tbCarPurchase.Controls.Add(this.btnPurchase);
            this.tbCarPurchase.Controls.Add(this.lstMonthly);
            this.tbCarPurchase.Controls.Add(this.rd3);
            this.tbCarPurchase.Controls.Add(this.rd2);
            this.tbCarPurchase.Controls.Add(this.rd1);
            this.tbCarPurchase.Controls.Add(this.lblCar);
            this.tbCarPurchase.Controls.Add(this.cmbCar);
            this.tbCarPurchase.Controls.Add(this.txtInitialPay);
            this.tbCarPurchase.Controls.Add(this.txtAge);
            this.tbCarPurchase.Controls.Add(this.txtName);
            this.tbCarPurchase.Controls.Add(this.lblInitialPay);
            this.tbCarPurchase.Controls.Add(this.lblAge);
            this.tbCarPurchase.Controls.Add(this.lblName);
            this.tbCarPurchase.Location = new System.Drawing.Point(4, 24);
            this.tbCarPurchase.Name = "tbCarPurchase";
            this.tbCarPurchase.Padding = new System.Windows.Forms.Padding(3);
            this.tbCarPurchase.Size = new System.Drawing.Size(767, 282);
            this.tbCarPurchase.TabIndex = 0;
            this.tbCarPurchase.Text = "Car Purchase";
            this.tbCarPurchase.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(421, 171);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(300, 171);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnShowPay
            // 
            this.btnShowPay.Location = new System.Drawing.Point(421, 119);
            this.btnShowPay.Name = "btnShowPay";
            this.btnShowPay.Size = new System.Drawing.Size(99, 24);
            this.btnShowPay.TabIndex = 13;
            this.btnShowPay.Text = "Show Payments";
            this.btnShowPay.UseVisualStyleBackColor = true;
            this.btnShowPay.Click += new System.EventHandler(this.btnShowPay_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(300, 119);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(75, 23);
            this.btnPurchase.TabIndex = 12;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // lstMonthly
            // 
            this.lstMonthly.FormattingEnabled = true;
            this.lstMonthly.ItemHeight = 15;
            this.lstMonthly.Location = new System.Drawing.Point(526, 13);
            this.lstMonthly.Name = "lstMonthly";
            this.lstMonthly.Size = new System.Drawing.Size(235, 259);
            this.lstMonthly.TabIndex = 11;
            // 
            // rd3
            // 
            this.rd3.AutoSize = true;
            this.rd3.Location = new System.Drawing.Point(430, 62);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(53, 19);
            this.rd3.TabIndex = 10;
            this.rd3.TabStop = true;
            this.rd3.Text = "Sport";
            this.rd3.UseVisualStyleBackColor = true;
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.Location = new System.Drawing.Point(350, 62);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(61, 19);
            this.rd2.TabIndex = 9;
            this.rd2.TabStop = true;
            this.rd2.Text = "Hybrid";
            this.rd2.UseVisualStyleBackColor = true;
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Location = new System.Drawing.Point(279, 62);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(52, 19);
            this.rd1.TabIndex = 8;
            this.rd1.TabStop = true;
            this.rd1.Text = "Basic";
            this.rd1.UseVisualStyleBackColor = true;
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Location = new System.Drawing.Point(276, 29);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(79, 15);
            this.lblCar.TabIndex = 7;
            this.lblCar.Text = "Car Selection:";
            // 
            // cmbCar
            // 
            this.cmbCar.FormattingEnabled = true;
            this.cmbCar.Items.AddRange(new object[] {
            "Sonata",
            "Corolla",
            "Civic",
            "Camry"});
            this.cmbCar.Location = new System.Drawing.Point(361, 24);
            this.cmbCar.Name = "cmbCar";
            this.cmbCar.Size = new System.Drawing.Size(121, 23);
            this.cmbCar.TabIndex = 6;
            // 
            // txtInitialPay
            // 
            this.txtInitialPay.Location = new System.Drawing.Point(148, 100);
            this.txtInitialPay.Multiline = true;
            this.txtInitialPay.Name = "txtInitialPay";
            this.txtInitialPay.Size = new System.Drawing.Size(100, 20);
            this.txtInitialPay.TabIndex = 5;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(88, 61);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(88, 24);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblInitialPay
            // 
            this.lblInitialPay.AutoSize = true;
            this.lblInitialPay.Location = new System.Drawing.Point(18, 100);
            this.lblInitialPay.Name = "lblInitialPay";
            this.lblInitialPay.Size = new System.Drawing.Size(123, 15);
            this.lblInitialPay.TabIndex = 2;
            this.lblInitialPay.Text = "Initial Down Payment:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(50, 61);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(31, 15);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(39, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // tbPurchasesMade
            // 
            this.tbPurchasesMade.Controls.Add(this.lstPrevPurchases);
            this.tbPurchasesMade.Location = new System.Drawing.Point(4, 24);
            this.tbPurchasesMade.Name = "tbPurchasesMade";
            this.tbPurchasesMade.Padding = new System.Windows.Forms.Padding(3);
            this.tbPurchasesMade.Size = new System.Drawing.Size(767, 282);
            this.tbPurchasesMade.TabIndex = 1;
            this.tbPurchasesMade.Text = "Purchases Made";
            this.tbPurchasesMade.UseVisualStyleBackColor = true;
            // 
            // lstPrevPurchases
            // 
            this.lstPrevPurchases.FormattingEnabled = true;
            this.lstPrevPurchases.ItemHeight = 15;
            this.lstPrevPurchases.Location = new System.Drawing.Point(7, 7);
            this.lstPrevPurchases.Name = "lstPrevPurchases";
            this.lstPrevPurchases.Size = new System.Drawing.Size(754, 259);
            this.lstPrevPurchases.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Car Financing";
            this.tabControl1.ResumeLayout(false);
            this.tbCarPurchase.ResumeLayout(false);
            this.tbCarPurchase.PerformLayout();
            this.tbPurchasesMade.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbCarPurchase;
        private System.Windows.Forms.Label lblInitialPay;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabPage tbPurchasesMade;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.ComboBox cmbCar;
        private System.Windows.Forms.TextBox txtInitialPay;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShowPay;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.ListBox lstMonthly;
        private System.Windows.Forms.ListBox lstPrevPurchases;
    }
}

