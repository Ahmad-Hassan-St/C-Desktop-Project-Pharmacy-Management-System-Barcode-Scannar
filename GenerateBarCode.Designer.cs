namespace Final_Project
{
    partial class GenerateBarCode
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGenrate = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.BTNSUpplierDash = new System.Windows.Forms.Button();
            this.txtencode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDecode = new System.Windows.Forms.TextBox();
            this.btnDecod = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(39, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnGenrate
            // 
            this.btnGenrate.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenrate.Location = new System.Drawing.Point(372, 21);
            this.btnGenrate.Name = "btnGenrate";
            this.btnGenrate.Size = new System.Drawing.Size(122, 28);
            this.btnGenrate.TabIndex = 20;
            this.btnGenrate.Text = "GENERATE";
            this.btnGenrate.UseVisualStyleBackColor = true;
            this.btnGenrate.Click += new System.EventHandler(this.btnGenrate_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(377, 333);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(115, 44);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "Print";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // BTNSUpplierDash
            // 
            this.BTNSUpplierDash.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSUpplierDash.Location = new System.Drawing.Point(39, 333);
            this.BTNSUpplierDash.Name = "BTNSUpplierDash";
            this.BTNSUpplierDash.Size = new System.Drawing.Size(95, 44);
            this.BTNSUpplierDash.TabIndex = 22;
            this.BTNSUpplierDash.Text = "BACK";
            this.BTNSUpplierDash.UseVisualStyleBackColor = true;
            this.BTNSUpplierDash.Click += new System.EventHandler(this.BTNSUpplierDash_Click);
            // 
            // txtencode
            // 
            this.txtencode.Location = new System.Drawing.Point(160, 24);
            this.txtencode.Name = "txtencode";
            this.txtencode.Size = new System.Drawing.Size(190, 20);
            this.txtencode.TabIndex = 19;
            this.txtencode.TextChanged += new System.EventHandler(this.txtSupplierID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Encode:";
            // 
            // txtDecode
            // 
            this.txtDecode.Location = new System.Drawing.Point(160, 58);
            this.txtDecode.Name = "txtDecode";
            this.txtDecode.Size = new System.Drawing.Size(190, 20);
            this.txtDecode.TabIndex = 19;
            this.txtDecode.TextChanged += new System.EventHandler(this.txtSupplierID_TextChanged);
            // 
            // btnDecod
            // 
            this.btnDecod.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecod.Location = new System.Drawing.Point(372, 55);
            this.btnDecod.Name = "btnDecod";
            this.btnDecod.Size = new System.Drawing.Size(122, 28);
            this.btnDecod.TabIndex = 20;
            this.btnDecod.Text = "DECODE";
            this.btnDecod.UseVisualStyleBackColor = true;
            this.btnDecod.Click += new System.EventHandler(this.btnDecod_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Decode:";
            // 
            // GenerateBarCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 410);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDecod);
            this.Controls.Add(this.btnGenrate);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtDecode);
            this.Controls.Add(this.BTNSUpplierDash);
            this.Controls.Add(this.txtencode);
            this.Name = "GenerateBarCode";
            this.Text = "GenerateBarCode";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGenrate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button BTNSUpplierDash;
        private System.Windows.Forms.TextBox txtencode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDecode;
        private System.Windows.Forms.Button btnDecod;
        private System.Windows.Forms.Label label2;
    }
}