namespace Final_Project
{
    partial class DisplayItem
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
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.BTNSUpplierDash = new System.Windows.Forms.Button();
            this.txtSearchIdSupp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboCamera = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConnectCamera = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSupplier.Location = new System.Drawing.Point(481, 399);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(115, 44);
            this.btnDeleteSupplier.TabIndex = 27;
            this.btnDeleteSupplier.Text = "Display";
            this.btnDeleteSupplier.UseVisualStyleBackColor = true;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            // 
            // BTNSUpplierDash
            // 
            this.BTNSUpplierDash.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSUpplierDash.Location = new System.Drawing.Point(25, 399);
            this.BTNSUpplierDash.Name = "BTNSUpplierDash";
            this.BTNSUpplierDash.Size = new System.Drawing.Size(95, 30);
            this.BTNSUpplierDash.TabIndex = 28;
            this.BTNSUpplierDash.Text = "BACK";
            this.BTNSUpplierDash.UseVisualStyleBackColor = true;
            this.BTNSUpplierDash.Click += new System.EventHandler(this.BTNSUpplierDash_Click);
            // 
            // txtSearchIdSupp
            // 
            this.txtSearchIdSupp.Location = new System.Drawing.Point(175, 39);
            this.txtSearchIdSupp.Name = "txtSearchIdSupp";
            this.txtSearchIdSupp.Size = new System.Drawing.Size(213, 20);
            this.txtSearchIdSupp.TabIndex = 25;
            this.txtSearchIdSupp.TextChanged += new System.EventHandler(this.txtSearchIdSupp_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Search Barcode:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(571, 289);
            this.dataGridView1.TabIndex = 23;
            // 
            // comboCamera
            // 
            this.comboCamera.FormattingEnabled = true;
            this.comboCamera.Location = new System.Drawing.Point(729, 37);
            this.comboCamera.Name = "comboCamera";
            this.comboCamera.Size = new System.Drawing.Size(222, 21);
            this.comboCamera.TabIndex = 39;
            this.comboCamera.Text = "Select Camera";
            this.comboCamera.SelectedIndexChanged += new System.EventHandler(this.comboCamera_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(623, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "Camera:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(630, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // btnConnectCamera
            // 
            this.btnConnectCamera.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectCamera.Location = new System.Drawing.Point(729, 352);
            this.btnConnectCamera.Name = "btnConnectCamera";
            this.btnConnectCamera.Size = new System.Drawing.Size(200, 44);
            this.btnConnectCamera.TabIndex = 27;
            this.btnConnectCamera.Text = "Connect Camera";
            this.btnConnectCamera.UseVisualStyleBackColor = true;
            this.btnConnectCamera.Click += new System.EventHandler(this.btnConnectCamera_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Helvetica Rounded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(729, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 39);
            this.button1.TabIndex = 40;
            this.button1.Text = "Stop Camera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DisplayItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 521);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboCamera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConnectCamera);
            this.Controls.Add(this.btnDeleteSupplier);
            this.Controls.Add(this.BTNSUpplierDash);
            this.Controls.Add(this.txtSearchIdSupp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DisplayItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayItem";
            this.Load += new System.EventHandler(this.DisplayItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Button BTNSUpplierDash;
        private System.Windows.Forms.TextBox txtSearchIdSupp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboCamera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConnectCamera;
        private System.Windows.Forms.Button button1;
    }
}