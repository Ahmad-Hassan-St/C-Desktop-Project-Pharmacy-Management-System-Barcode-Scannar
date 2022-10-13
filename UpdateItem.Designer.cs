namespace Final_Project
{
    partial class UpdateItem
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
            this.comboCamera = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtdescription = new System.Windows.Forms.ComboBox();
            this.txtQty = new System.Windows.Forms.NumericUpDown();
            this.txtprice = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.BTNSUpplierDash = new System.Windows.Forms.Button();
            this.txtunnitqty = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtitemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.btnConnectCamera = new System.Windows.Forms.Button();
            this.cmbsupplierId = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprice)).BeginInit();
            this.SuspendLayout();
            // 
            // comboCamera
            // 
            this.comboCamera.FormattingEnabled = true;
            this.comboCamera.Location = new System.Drawing.Point(545, 70);
            this.comboCamera.Name = "comboCamera";
            this.comboCamera.Size = new System.Drawing.Size(222, 21);
            this.comboCamera.TabIndex = 36;
            this.comboCamera.Text = "Select Camera";
            this.comboCamera.SelectedIndexChanged += new System.EventHandler(this.comboCamera_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Camera:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(446, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
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
            this.txtdescription.Location = new System.Drawing.Point(179, 204);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(190, 21);
            this.txtdescription.TabIndex = 33;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(179, 291);
            this.txtQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(190, 20);
            this.txtQty.TabIndex = 31;
            this.txtQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtprice
            // 
            this.txtprice.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtprice.Location = new System.Drawing.Point(179, 243);
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
            this.txtprice.TabIndex = 32;
            this.txtprice.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(156, 356);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 32);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(300, 356);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 32);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // BTNSUpplierDash
            // 
            this.BTNSUpplierDash.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSUpplierDash.Location = new System.Drawing.Point(42, 356);
            this.BTNSUpplierDash.Name = "BTNSUpplierDash";
            this.BTNSUpplierDash.Size = new System.Drawing.Size(95, 32);
            this.BTNSUpplierDash.TabIndex = 30;
            this.BTNSUpplierDash.Text = "BACK";
            this.BTNSUpplierDash.UseVisualStyleBackColor = true;
            this.BTNSUpplierDash.Click += new System.EventHandler(this.BTNSUpplierDash_Click);
            // 
            // txtunnitqty
            // 
            this.txtunnitqty.AutoSize = true;
            this.txtunnitqty.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtunnitqty.Location = new System.Drawing.Point(41, 292);
            this.txtunnitqty.Name = "txtunnitqty";
            this.txtunnitqty.Size = new System.Drawing.Size(118, 19);
            this.txtunnitqty.TabIndex = 21;
            this.txtunnitqty.Text = "Unit Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Description:";
            // 
            // txtitemName
            // 
            this.txtitemName.Location = new System.Drawing.Point(179, 160);
            this.txtitemName.Name = "txtitemName";
            this.txtitemName.Size = new System.Drawing.Size(190, 20);
            this.txtitemName.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Item Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Supplier ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Search Barcode:";
            // 
            // txtSearchId
            // 
            this.txtSearchId.Location = new System.Drawing.Point(179, 71);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(190, 20);
            this.txtSearchId.TabIndex = 27;
            this.txtSearchId.TextChanged += new System.EventHandler(this.txtSearchId_TextChanged);
            // 
            // btnConnectCamera
            // 
            this.btnConnectCamera.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectCamera.Location = new System.Drawing.Point(520, 358);
            this.btnConnectCamera.Name = "btnConnectCamera";
            this.btnConnectCamera.Size = new System.Drawing.Size(200, 44);
            this.btnConnectCamera.TabIndex = 37;
            this.btnConnectCamera.Text = "Connect Camera";
            this.btnConnectCamera.UseVisualStyleBackColor = true;
            this.btnConnectCamera.Click += new System.EventHandler(this.btnConnectCamera_Click);
            // 
            // cmbsupplierId
            // 
            this.cmbsupplierId.FormattingEnabled = true;
            this.cmbsupplierId.Location = new System.Drawing.Point(179, 122);
            this.cmbsupplierId.Name = "cmbsupplierId";
            this.cmbsupplierId.Size = new System.Drawing.Size(190, 21);
            this.cmbsupplierId.TabIndex = 38;
            this.cmbsupplierId.SelectedIndexChanged += new System.EventHandler(this.cmbsupplierId_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Helvetica Rounded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(520, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 37);
            this.button1.TabIndex = 39;
            this.button1.Text = "Stop Camera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 468);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbsupplierId);
            this.Controls.Add(this.btnConnectCamera);
            this.Controls.Add(this.comboCamera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.BTNSUpplierDash);
            this.Controls.Add(this.txtunnitqty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtitemName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "UpdateItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateItem";
            this.Load += new System.EventHandler(this.UpdateItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCamera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox txtdescription;
        private System.Windows.Forms.NumericUpDown txtQty;
        private System.Windows.Forms.NumericUpDown txtprice;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button BTNSUpplierDash;
        private System.Windows.Forms.Label txtunnitqty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtitemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.Button btnConnectCamera;
        private System.Windows.Forms.ComboBox cmbsupplierId;
        private System.Windows.Forms.Button button1;
    }
}