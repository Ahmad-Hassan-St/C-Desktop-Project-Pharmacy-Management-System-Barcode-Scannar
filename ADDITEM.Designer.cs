namespace Final_Project
{
    partial class ADDITEM
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.BTNSUpplierDash = new System.Windows.Forms.Button();
            this.txtunnitqty = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.NumericUpDown();
            this.txtdescription = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboCamera = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.NumericUpDown();
            this.btnConnectCamera = new System.Windows.Forms.Button();
            this.cmbsupplierID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(134, 372);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(203, 32);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Stop Camera";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(279, 307);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(115, 32);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // BTNSUpplierDash
            // 
            this.BTNSUpplierDash.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSUpplierDash.Location = new System.Drawing.Point(76, 307);
            this.BTNSUpplierDash.Name = "BTNSUpplierDash";
            this.BTNSUpplierDash.Size = new System.Drawing.Size(95, 32);
            this.BTNSUpplierDash.TabIndex = 15;
            this.BTNSUpplierDash.Text = "BACK";
            this.BTNSUpplierDash.UseVisualStyleBackColor = true;
            this.BTNSUpplierDash.Click += new System.EventHandler(this.BTNSUpplierDash_Click);
            // 
            // txtunnitqty
            // 
            this.txtunnitqty.AutoSize = true;
            this.txtunnitqty.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtunnitqty.Location = new System.Drawing.Point(66, 263);
            this.txtunnitqty.Name = "txtunnitqty";
            this.txtunnitqty.Size = new System.Drawing.Size(118, 19);
            this.txtunnitqty.TabIndex = 4;
            this.txtunnitqty.Text = "Unit Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description:";
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(204, 96);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(190, 20);
            this.txtbarcode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Barcode:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Supplier ID:";
            // 
            // txtprice
            // 
            this.txtprice.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtprice.Location = new System.Drawing.Point(204, 214);
            this.txtprice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtprice.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(190, 20);
            this.txtprice.TabIndex = 4;
            this.txtprice.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // txtdescription
            // 
            this.txtdescription.FormattingEnabled = true;
            this.txtdescription.Items.AddRange(new object[] {
            "Tablet",
            "Syrup",
            "Drop",
            "Inhalers",
            "Injections"});
            this.txtdescription.Location = new System.Drawing.Point(204, 175);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(190, 21);
            this.txtdescription.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(471, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // comboCamera
            // 
            this.comboCamera.FormattingEnabled = true;
            this.comboCamera.Location = new System.Drawing.Point(570, 45);
            this.comboCamera.Name = "comboCamera";
            this.comboCamera.Size = new System.Drawing.Size(222, 21);
            this.comboCamera.TabIndex = 20;
            this.comboCamera.Text = "Select Camera";
            this.comboCamera.SelectedIndexChanged += new System.EventHandler(this.comboCamera_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(464, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Camera:";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(204, 262);
            this.txtQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(190, 20);
            this.txtQty.TabIndex = 5;
            this.txtQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnConnectCamera
            // 
            this.btnConnectCamera.Font = new System.Drawing.Font("Helvetica Rounded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectCamera.Location = new System.Drawing.Point(560, 342);
            this.btnConnectCamera.Name = "btnConnectCamera";
            this.btnConnectCamera.Size = new System.Drawing.Size(200, 44);
            this.btnConnectCamera.TabIndex = 28;
            this.btnConnectCamera.Text = "Connect Camera";
            this.btnConnectCamera.UseVisualStyleBackColor = true;
            this.btnConnectCamera.Click += new System.EventHandler(this.btnConnectCamera_Click);
            // 
            // cmbsupplierID
            // 
            this.cmbsupplierID.FormattingEnabled = true;
            this.cmbsupplierID.Location = new System.Drawing.Point(204, 60);
            this.cmbsupplierID.Name = "cmbsupplierID";
            this.cmbsupplierID.Size = new System.Drawing.Size(190, 21);
            this.cmbsupplierID.TabIndex = 0;
            this.cmbsupplierID.SelectedIndexChanged += new System.EventHandler(this.cmbsupplierID_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Item Name :";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(204, 134);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(190, 20);
            this.txtItemName.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(560, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 41);
            this.button1.TabIndex = 29;
            this.button1.Text = "Generate Barcode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ADDITEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbsupplierID);
            this.Controls.Add(this.btnConnectCamera);
            this.Controls.Add(this.comboCamera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.BTNSUpplierDash);
            this.Controls.Add(this.txtunnitqty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "ADDITEM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADDITEM";
            this.Load += new System.EventHandler(this.ADDITEM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button BTNSUpplierDash;
        private System.Windows.Forms.Label txtunnitqty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtprice;
        private System.Windows.Forms.ComboBox txtdescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboCamera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtQty;
        private System.Windows.Forms.Button btnConnectCamera;
        private System.Windows.Forms.ComboBox cmbsupplierID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Button button1;
    }
}