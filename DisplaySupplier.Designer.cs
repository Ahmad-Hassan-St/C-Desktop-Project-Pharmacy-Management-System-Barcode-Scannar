namespace Final_Project
{
    partial class DisplaySupplier
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
            this.txtSearchIdSupp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.BTNSUpplierDash = new System.Windows.Forms.Button();
            this.BTNSEARCHSUP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(571, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtSearchIdSupp
            // 
            this.txtSearchIdSupp.Location = new System.Drawing.Point(172, 25);
            this.txtSearchIdSupp.Name = "txtSearchIdSupp";
            this.txtSearchIdSupp.Size = new System.Drawing.Size(190, 20);
            this.txtSearchIdSupp.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Search ID:";
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSupplier.Location = new System.Drawing.Point(494, 382);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(115, 44);
            this.btnDeleteSupplier.TabIndex = 21;
            this.btnDeleteSupplier.Text = "Display";
            this.btnDeleteSupplier.UseVisualStyleBackColor = true;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            // 
            // BTNSUpplierDash
            // 
            this.BTNSUpplierDash.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSUpplierDash.Location = new System.Drawing.Point(38, 382);
            this.BTNSUpplierDash.Name = "BTNSUpplierDash";
            this.BTNSUpplierDash.Size = new System.Drawing.Size(95, 30);
            this.BTNSUpplierDash.TabIndex = 22;
            this.BTNSUpplierDash.Text = "BACK";
            this.BTNSUpplierDash.UseVisualStyleBackColor = true;
            this.BTNSUpplierDash.Click += new System.EventHandler(this.BTNSUpplierDash_Click);
            // 
            // BTNSEARCHSUP
            // 
            this.BTNSEARCHSUP.Font = new System.Drawing.Font("Helvetica Rounded", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSEARCHSUP.Location = new System.Drawing.Point(449, 19);
            this.BTNSEARCHSUP.Name = "BTNSEARCHSUP";
            this.BTNSEARCHSUP.Size = new System.Drawing.Size(98, 26);
            this.BTNSEARCHSUP.TabIndex = 21;
            this.BTNSEARCHSUP.Text = "SEARCH";
            this.BTNSEARCHSUP.UseVisualStyleBackColor = true;
            this.BTNSEARCHSUP.Click += new System.EventHandler(this.BTNSEARCHSUP_Click);
            // 
            // DisplaySupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 438);
            this.Controls.Add(this.BTNSEARCHSUP);
            this.Controls.Add(this.btnDeleteSupplier);
            this.Controls.Add(this.BTNSUpplierDash);
            this.Controls.Add(this.txtSearchIdSupp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DisplaySupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplaySupplier";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearchIdSupp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Button BTNSUpplierDash;
        private System.Windows.Forms.Button BTNSEARCHSUP;
    }
}