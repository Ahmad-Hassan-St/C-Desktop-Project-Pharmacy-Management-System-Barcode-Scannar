namespace Final_Project
{
    partial class HOME
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnsupplier = new System.Windows.Forms.Button();
            this.btnitem = new System.Windows.Forms.Button();
            this.btnpurchase = new System.Windows.Forms.Button();
            this.btnsale = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.39271F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.60729F));
            this.tableLayoutPanel1.Controls.Add(this.btnsupplier, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnitem, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnpurchase, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnsale, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(72, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(412, 170);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnsupplier
            // 
            this.btnsupplier.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupplier.Location = new System.Drawing.Point(3, 3);
            this.btnsupplier.Name = "btnsupplier";
            this.btnsupplier.Size = new System.Drawing.Size(197, 79);
            this.btnsupplier.TabIndex = 0;
            this.btnsupplier.Text = "SUPPLIER ";
            this.btnsupplier.UseVisualStyleBackColor = true;
            this.btnsupplier.Click += new System.EventHandler(this.btnsupplier_Click);
            // 
            // btnitem
            // 
            this.btnitem.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnitem.Location = new System.Drawing.Point(206, 3);
            this.btnitem.Name = "btnitem";
            this.btnitem.Size = new System.Drawing.Size(203, 79);
            this.btnitem.TabIndex = 0;
            this.btnitem.Text = "ITEM MASTER";
            this.btnitem.UseVisualStyleBackColor = true;
            this.btnitem.Click += new System.EventHandler(this.btnitem_Click);
            // 
            // btnpurchase
            // 
            this.btnpurchase.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpurchase.Location = new System.Drawing.Point(3, 88);
            this.btnpurchase.Name = "btnpurchase";
            this.btnpurchase.Size = new System.Drawing.Size(197, 79);
            this.btnpurchase.TabIndex = 0;
            this.btnpurchase.Text = "PURCHASE MASTER";
            this.btnpurchase.UseVisualStyleBackColor = true;
            this.btnpurchase.Click += new System.EventHandler(this.btnpurchase_Click);
            // 
            // btnsale
            // 
            this.btnsale.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsale.Location = new System.Drawing.Point(206, 88);
            this.btnsale.Name = "btnsale";
            this.btnsale.Size = new System.Drawing.Size(203, 79);
            this.btnsale.TabIndex = 0;
            this.btnsale.Text = "SALE";
            this.btnsale.UseVisualStyleBackColor = true;
            this.btnsale.Click += new System.EventHandler(this.btnsale_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Location = new System.Drawing.Point(175, 228);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(203, 79);
            this.btnInventory.TabIndex = 0;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 330);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnInventory);
            this.Name = "HOME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnsupplier;
        private System.Windows.Forms.Button btnitem;
        private System.Windows.Forms.Button btnpurchase;
        private System.Windows.Forms.Button btnsale;
        private System.Windows.Forms.Button btnInventory;
    }
}

