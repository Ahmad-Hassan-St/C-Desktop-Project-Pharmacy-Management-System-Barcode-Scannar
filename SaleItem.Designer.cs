namespace Final_Project
{
    partial class SaleItem
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sysDate = new System.Windows.Forms.DateTimePicker();
            this.btnConnectCamera = new System.Windows.Forms.Button();
            this.comboCamera = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtitemName = new System.Windows.Forms.ComboBox();
            this.txtQty = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.BTNSUpplierDash = new System.Windows.Forms.Button();
            this.txtunnitqty = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblboxes = new System.Windows.Forms.Label();
            this.lblcheck = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 357);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(778, 160);
            this.dataGridView1.TabIndex = 71;
            // 
            // sysDate
            // 
            this.sysDate.Location = new System.Drawing.Point(185, 48);
            this.sysDate.Name = "sysDate";
            this.sysDate.Size = new System.Drawing.Size(207, 20);
            this.sysDate.TabIndex = 69;
            // 
            // btnConnectCamera
            // 
            this.btnConnectCamera.Font = new System.Drawing.Font("Helvetica Rounded", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectCamera.Location = new System.Drawing.Point(684, 315);
            this.btnConnectCamera.Name = "btnConnectCamera";
            this.btnConnectCamera.Size = new System.Drawing.Size(134, 37);
            this.btnConnectCamera.TabIndex = 68;
            this.btnConnectCamera.Text = "Connect Camera";
            this.btnConnectCamera.UseVisualStyleBackColor = true;
            this.btnConnectCamera.Click += new System.EventHandler(this.btnConnectCamera_Click);
            // 
            // comboCamera
            // 
            this.comboCamera.FormattingEnabled = true;
            this.comboCamera.Location = new System.Drawing.Point(551, 47);
            this.comboCamera.Name = "comboCamera";
            this.comboCamera.Size = new System.Drawing.Size(222, 21);
            this.comboCamera.TabIndex = 67;
            this.comboCamera.Text = "Select Camera";
            this.comboCamera.SelectedIndexChanged += new System.EventHandler(this.comboCamera_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(445, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 66;
            this.label5.Text = "Camera:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(452, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // txtitemName
            // 
            this.txtitemName.FormattingEnabled = true;
            this.txtitemName.Location = new System.Drawing.Point(185, 171);
            this.txtitemName.Name = "txtitemName";
            this.txtitemName.Size = new System.Drawing.Size(207, 21);
            this.txtitemName.TabIndex = 64;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(185, 211);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(207, 20);
            this.txtQty.TabIndex = 62;
            this.txtQty.ValueChanged += new System.EventHandler(this.txtQty_ValueChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Helvetica Rounded", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(168, 316);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 32);
            this.btnClear.TabIndex = 58;
            this.btnClear.Text = "Display";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBill
            // 
            this.btnBill.Font = new System.Drawing.Font("Helvetica Rounded", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.Location = new System.Drawing.Point(452, 315);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(95, 36);
            this.btnBill.TabIndex = 60;
            this.btnBill.Text = "Bill";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Helvetica Rounded", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(311, 316);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 32);
            this.btnAdd.TabIndex = 59;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // BTNSUpplierDash
            // 
            this.BTNSUpplierDash.Font = new System.Drawing.Font("Helvetica Rounded", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSUpplierDash.Location = new System.Drawing.Point(40, 316);
            this.BTNSUpplierDash.Name = "BTNSUpplierDash";
            this.BTNSUpplierDash.Size = new System.Drawing.Size(95, 32);
            this.BTNSUpplierDash.TabIndex = 61;
            this.BTNSUpplierDash.Text = "Back";
            this.BTNSUpplierDash.UseVisualStyleBackColor = true;
            this.BTNSUpplierDash.Click += new System.EventHandler(this.BTNSUpplierDash_Click);
            // 
            // txtunnitqty
            // 
            this.txtunnitqty.AutoSize = true;
            this.txtunnitqty.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtunnitqty.Location = new System.Drawing.Point(47, 214);
            this.txtunnitqty.Name = "txtunnitqty";
            this.txtunnitqty.Size = new System.Drawing.Size(81, 19);
            this.txtunnitqty.TabIndex = 49;
            this.txtunnitqty.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 50;
            this.label4.Text = "Sale Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 51;
            this.label3.Text = "Item Name:";
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(185, 127);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(207, 20);
            this.txtbarcode.TabIndex = 56;
            this.txtbarcode.TextChanged += new System.EventHandler(this.txtbarcode_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "Barcode:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(185, 87);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(207, 20);
            this.txtCustomerName.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label6.Location = new System.Drawing.Point(23, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 19);
            this.label6.TabIndex = 55;
            this.label6.Text = "Boxes in Inventory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 53;
            this.label1.Text = "Customer Name:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Helvetica Rounded", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(560, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 72;
            this.button1.Text = "Stop Camera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(180, 254);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(20, 25);
            this.lblPrice.TabIndex = 73;
            this.lblPrice.Text = "*";
            // 
            // lblboxes
            // 
            this.lblboxes.AutoSize = true;
            this.lblboxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblboxes.Location = new System.Drawing.Point(207, 9);
            this.lblboxes.Name = "lblboxes";
            this.lblboxes.Size = new System.Drawing.Size(20, 25);
            this.lblboxes.TabIndex = 74;
            this.lblboxes.Text = "*";
            // 
            // lblcheck
            // 
            this.lblcheck.AutoSize = true;
            this.lblcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcheck.Location = new System.Drawing.Point(415, 210);
            this.lblcheck.Name = "lblcheck";
            this.lblcheck.Size = new System.Drawing.Size(20, 25);
            this.lblcheck.TabIndex = 75;
            this.lblcheck.Text = "*";
            this.lblcheck.UseWaitCursor = true;
            // 
            // SaleItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 540);
            this.Controls.Add(this.lblcheck);
            this.Controls.Add(this.lblboxes);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sysDate);
            this.Controls.Add(this.btnConnectCamera);
            this.Controls.Add(this.comboCamera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtitemName);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.BTNSUpplierDash);
            this.Controls.Add(this.txtunnitqty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "SaleItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleItem";
            this.Load += new System.EventHandler(this.SaleItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker sysDate;
        private System.Windows.Forms.Button btnConnectCamera;
        private System.Windows.Forms.ComboBox comboCamera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox txtitemName;
        private System.Windows.Forms.NumericUpDown txtQty;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button BTNSUpplierDash;
        private System.Windows.Forms.Label txtunnitqty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblboxes;
        private System.Windows.Forms.Label lblcheck;
    }
}