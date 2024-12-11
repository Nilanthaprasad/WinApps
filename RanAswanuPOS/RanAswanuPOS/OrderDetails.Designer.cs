namespace RanAswanuPOS
{
    partial class OrderDetails
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
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.Customer = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.labal = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBillingAddress = new System.Windows.Forms.Label();
            this.lblBillingCity = new System.Windows.Forms.Label();
            this.lblBillingPhone = new System.Windows.Forms.Label();
            this.lblBillingLN = new System.Windows.Forms.Label();
            this.lblBillingFN = new System.Windows.Forms.Label();
            this.lblShippingAddress = new System.Windows.Forms.Label();
            this.lblShippingPostCode = new System.Windows.Forms.Label();
            this.lblShippingCity = new System.Windows.Forms.Label();
            this.lblShippingLN = new System.Windows.Forms.Label();
            this.lblShippingFN = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblBillingPostCode = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBillingEmail = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.itemNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNumber,
            this.productId,
            this.productName,
            this.pricePerItem,
            this.quantity,
            this.lineTotal});
            this.dgvOrderDetails.Location = new System.Drawing.Point(22, 61);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.Size = new System.Drawing.Size(574, 377);
            this.dgvOrderDetails.TabIndex = 0;
            // 
            // Customer
            // 
            this.Customer.AutoSize = true;
            this.Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer.Location = new System.Drawing.Point(18, 13);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(86, 20);
            this.Customer.TabIndex = 1;
            this.Customer.Text = "Customer";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(122, 13);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(0, 20);
            this.lblCustomerName.TabIndex = 2;
            // 
            // labal
            // 
            this.labal.AutoSize = true;
            this.labal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labal.Location = new System.Drawing.Point(459, 13);
            this.labal.Name = "labal";
            this.labal.Size = new System.Drawing.Size(49, 20);
            this.labal.TabIndex = 3;
            this.labal.Text = "Total";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(505, 13);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(19, 20);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBillingEmail);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblBillingPostCode);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblBillingAddress);
            this.groupBox1.Controls.Add(this.lblBillingCity);
            this.groupBox1.Controls.Add(this.lblBillingPhone);
            this.groupBox1.Controls.Add(this.lblBillingLN);
            this.groupBox1.Controls.Add(this.lblBillingFN);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(622, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 241);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Billing Information";
            // 
            // grpBox2
            // 
            this.grpBox2.Controls.Add(this.lblShippingAddress);
            this.grpBox2.Controls.Add(this.lblShippingPostCode);
            this.grpBox2.Controls.Add(this.lblShippingCity);
            this.grpBox2.Controls.Add(this.lblShippingLN);
            this.grpBox2.Controls.Add(this.lblShippingFN);
            this.grpBox2.Controls.Add(this.label11);
            this.grpBox2.Controls.Add(this.label12);
            this.grpBox2.Controls.Add(this.label13);
            this.grpBox2.Controls.Add(this.label14);
            this.grpBox2.Controls.Add(this.label15);
            this.grpBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox2.Location = new System.Drawing.Point(622, 275);
            this.grpBox2.Name = "grpBox2";
            this.grpBox2.Size = new System.Drawing.Size(299, 163);
            this.grpBox2.TabIndex = 8;
            this.grpBox2.TabStop = false;
            this.grpBox2.Text = "Shipping Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // lblBillingAddress
            // 
            this.lblBillingAddress.AutoSize = true;
            this.lblBillingAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillingAddress.Location = new System.Drawing.Point(80, 167);
            this.lblBillingAddress.Name = "lblBillingAddress";
            this.lblBillingAddress.Size = new System.Drawing.Size(35, 13);
            this.lblBillingAddress.TabIndex = 9;
            this.lblBillingAddress.Text = "label6";
            // 
            // lblBillingCity
            // 
            this.lblBillingCity.AutoSize = true;
            this.lblBillingCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillingCity.Location = new System.Drawing.Point(81, 91);
            this.lblBillingCity.Name = "lblBillingCity";
            this.lblBillingCity.Size = new System.Drawing.Size(35, 13);
            this.lblBillingCity.TabIndex = 8;
            this.lblBillingCity.Text = "label7";
            // 
            // lblBillingPhone
            // 
            this.lblBillingPhone.AutoSize = true;
            this.lblBillingPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillingPhone.Location = new System.Drawing.Point(81, 68);
            this.lblBillingPhone.Name = "lblBillingPhone";
            this.lblBillingPhone.Size = new System.Drawing.Size(35, 13);
            this.lblBillingPhone.TabIndex = 7;
            this.lblBillingPhone.Text = "label8";
            // 
            // lblBillingLN
            // 
            this.lblBillingLN.AutoSize = true;
            this.lblBillingLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillingLN.Location = new System.Drawing.Point(81, 44);
            this.lblBillingLN.Name = "lblBillingLN";
            this.lblBillingLN.Size = new System.Drawing.Size(35, 13);
            this.lblBillingLN.TabIndex = 6;
            this.lblBillingLN.Text = "label9";
            // 
            // lblBillingFN
            // 
            this.lblBillingFN.AutoSize = true;
            this.lblBillingFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillingFN.Location = new System.Drawing.Point(81, 20);
            this.lblBillingFN.Name = "lblBillingFN";
            this.lblBillingFN.Size = new System.Drawing.Size(41, 13);
            this.lblBillingFN.TabIndex = 5;
            this.lblBillingFN.Text = "label10";
            // 
            // lblShippingAddress
            // 
            this.lblShippingAddress.AutoSize = true;
            this.lblShippingAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingAddress.Location = new System.Drawing.Point(78, 120);
            this.lblShippingAddress.Name = "lblShippingAddress";
            this.lblShippingAddress.Size = new System.Drawing.Size(35, 13);
            this.lblShippingAddress.TabIndex = 19;
            this.lblShippingAddress.Text = "label6";
            // 
            // lblShippingPostCode
            // 
            this.lblShippingPostCode.AutoSize = true;
            this.lblShippingPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingPostCode.Location = new System.Drawing.Point(78, 95);
            this.lblShippingPostCode.Name = "lblShippingPostCode";
            this.lblShippingPostCode.Size = new System.Drawing.Size(35, 13);
            this.lblShippingPostCode.TabIndex = 18;
            this.lblShippingPostCode.Text = "label7";
            // 
            // lblShippingCity
            // 
            this.lblShippingCity.AutoSize = true;
            this.lblShippingCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingCity.Location = new System.Drawing.Point(78, 72);
            this.lblShippingCity.Name = "lblShippingCity";
            this.lblShippingCity.Size = new System.Drawing.Size(35, 13);
            this.lblShippingCity.TabIndex = 17;
            this.lblShippingCity.Text = "label8";
            // 
            // lblShippingLN
            // 
            this.lblShippingLN.AutoSize = true;
            this.lblShippingLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingLN.Location = new System.Drawing.Point(78, 48);
            this.lblShippingLN.Name = "lblShippingLN";
            this.lblShippingLN.Size = new System.Drawing.Size(35, 13);
            this.lblShippingLN.TabIndex = 16;
            this.lblShippingLN.Text = "label9";
            // 
            // lblShippingFN
            // 
            this.lblShippingFN.AutoSize = true;
            this.lblShippingFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingFN.Location = new System.Drawing.Point(78, 25);
            this.lblShippingFN.Name = "lblShippingFN";
            this.lblShippingFN.Size = new System.Drawing.Size(41, 13);
            this.lblShippingFN.TabIndex = 15;
            this.lblShippingFN.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Postal Code";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "City";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Last Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "First Name";
            // 
            // lblBillingPostCode
            // 
            this.lblBillingPostCode.AutoSize = true;
            this.lblBillingPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillingPostCode.Location = new System.Drawing.Point(81, 116);
            this.lblBillingPostCode.Name = "lblBillingPostCode";
            this.lblBillingPostCode.Size = new System.Drawing.Size(35, 13);
            this.lblBillingPostCode.TabIndex = 11;
            this.lblBillingPostCode.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Post Code";
            // 
            // lblBillingEmail
            // 
            this.lblBillingEmail.AutoSize = true;
            this.lblBillingEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillingEmail.Location = new System.Drawing.Point(80, 141);
            this.lblBillingEmail.Name = "lblBillingEmail";
            this.lblBillingEmail.Size = new System.Drawing.Size(35, 13);
            this.lblBillingEmail.TabIndex = 13;
            this.lblBillingEmail.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Email";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(846, 444);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // itemNumber
            // 
            this.itemNumber.HeaderText = "#";
            this.itemNumber.Name = "itemNumber";
            this.itemNumber.Width = 30;
            // 
            // productId
            // 
            this.productId.HeaderText = "Product Id";
            this.productId.Name = "productId";
            this.productId.Width = 65;
            // 
            // productName
            // 
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            this.productName.Width = 150;
            // 
            // pricePerItem
            // 
            this.pricePerItem.HeaderText = "Unit Price";
            this.pricePerItem.Name = "pricePerItem";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // lineTotal
            // 
            this.lineTotal.HeaderText = "Total";
            this.lineTotal.Name = "lineTotal";
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 497);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.labal);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.dgvOrderDetails);
            this.Name = "OrderDetails";
            this.Text = "OrderDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBox2.ResumeLayout(false);
            this.grpBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.Label Customer;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label labal;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBillingAddress;
        private System.Windows.Forms.Label lblBillingCity;
        private System.Windows.Forms.Label lblBillingPhone;
        private System.Windows.Forms.Label lblBillingLN;
        private System.Windows.Forms.Label lblBillingFN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBox2;
        private System.Windows.Forms.Label lblShippingAddress;
        private System.Windows.Forms.Label lblShippingPostCode;
        private System.Windows.Forms.Label lblShippingCity;
        private System.Windows.Forms.Label lblShippingLN;
        private System.Windows.Forms.Label lblShippingFN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblBillingEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBillingPostCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineTotal;
    }
}