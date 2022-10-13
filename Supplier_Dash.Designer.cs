namespace Final_Project
{
    partial class Supplier_Dash
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
            this.BTNDISPLAsuP = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnADDsupplier = new System.Windows.Forms.Button();
            this.BTNDELETESUP = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNDISPLAsuP
            // 
            this.BTNDISPLAsuP.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDISPLAsuP.Location = new System.Drawing.Point(206, 88);
            this.BTNDISPLAsuP.Name = "BTNDISPLAsuP";
            this.BTNDISPLAsuP.Size = new System.Drawing.Size(203, 79);
            this.BTNDISPLAsuP.TabIndex = 0;
            this.BTNDISPLAsuP.Text = "DISPLAY DATA";
            this.BTNDISPLAsuP.UseVisualStyleBackColor = true;
            this.BTNDISPLAsuP.Click += new System.EventHandler(this.BTNDISPLAsuP_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.39271F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.60729F));
            this.tableLayoutPanel1.Controls.Add(this.btnADDsupplier, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTNDELETESUP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTNDISPLAsuP, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(47, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(412, 170);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnADDsupplier
            // 
            this.btnADDsupplier.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADDsupplier.Location = new System.Drawing.Point(3, 3);
            this.btnADDsupplier.Name = "btnADDsupplier";
            this.btnADDsupplier.Size = new System.Drawing.Size(197, 79);
            this.btnADDsupplier.TabIndex = 0;
            this.btnADDsupplier.Text = "ADD SUPPLIER ";
            this.btnADDsupplier.UseVisualStyleBackColor = true;
            this.btnADDsupplier.Click += new System.EventHandler(this.btnADDsupplier_Click);
            // 
            // BTNDELETESUP
            // 
            this.BTNDELETESUP.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDELETESUP.Location = new System.Drawing.Point(206, 3);
            this.BTNDELETESUP.Name = "BTNDELETESUP";
            this.BTNDELETESUP.Size = new System.Drawing.Size(203, 79);
            this.BTNDELETESUP.TabIndex = 0;
            this.BTNDELETESUP.Text = "DELETE ";
            this.BTNDELETESUP.UseVisualStyleBackColor = true;
            this.BTNDELETESUP.Click += new System.EventHandler(this.BTNDELETESUP_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(3, 88);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(197, 79);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "UPDATE SUPPLIER";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(150, 216);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(203, 79);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Supplier_Dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 338);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnHome);
            this.Name = "Supplier_Dash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier_Dash";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNDISPLAsuP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnADDsupplier;
        private System.Windows.Forms.Button BTNDELETESUP;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHome;
    }
}