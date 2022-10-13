namespace Final_Project
{
    partial class Itemmaster
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
            this.btnADDITEM = new System.Windows.Forms.Button();
            this.BTNDELETEITEM = new System.Windows.Forms.Button();
            this.btnUpdateITEM = new System.Windows.Forms.Button();
            this.BTNDISPLAsuP = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnADDITEM
            // 
            this.btnADDITEM.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADDITEM.Location = new System.Drawing.Point(71, 67);
            this.btnADDITEM.Name = "btnADDITEM";
            this.btnADDITEM.Size = new System.Drawing.Size(197, 79);
            this.btnADDITEM.TabIndex = 3;
            this.btnADDITEM.Text = "ADD ITEM";
            this.btnADDITEM.UseVisualStyleBackColor = true;
            this.btnADDITEM.Click += new System.EventHandler(this.btnADDITEM_Click);
            // 
            // BTNDELETEITEM
            // 
            this.BTNDELETEITEM.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDELETEITEM.Location = new System.Drawing.Point(274, 67);
            this.BTNDELETEITEM.Name = "BTNDELETEITEM";
            this.BTNDELETEITEM.Size = new System.Drawing.Size(203, 79);
            this.BTNDELETEITEM.TabIndex = 4;
            this.BTNDELETEITEM.Text = "DELETE ";
            this.BTNDELETEITEM.UseVisualStyleBackColor = true;
            this.BTNDELETEITEM.Click += new System.EventHandler(this.BTNDELETEITEM_Click);
            // 
            // btnUpdateITEM
            // 
            this.btnUpdateITEM.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateITEM.Location = new System.Drawing.Point(71, 152);
            this.btnUpdateITEM.Name = "btnUpdateITEM";
            this.btnUpdateITEM.Size = new System.Drawing.Size(197, 79);
            this.btnUpdateITEM.TabIndex = 5;
            this.btnUpdateITEM.Text = "UPDATE ITEM";
            this.btnUpdateITEM.UseVisualStyleBackColor = true;
            this.btnUpdateITEM.Click += new System.EventHandler(this.btnUpdateITEM_Click);
            // 
            // BTNDISPLAsuP
            // 
            this.BTNDISPLAsuP.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDISPLAsuP.Location = new System.Drawing.Point(274, 152);
            this.BTNDISPLAsuP.Name = "BTNDISPLAsuP";
            this.BTNDISPLAsuP.Size = new System.Drawing.Size(203, 79);
            this.BTNDISPLAsuP.TabIndex = 6;
            this.BTNDISPLAsuP.Text = "DISPLAY DATA";
            this.BTNDISPLAsuP.UseVisualStyleBackColor = true;
            this.BTNDISPLAsuP.Click += new System.EventHandler(this.BTNDISPLAsuP_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(171, 242);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(203, 79);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Itemmaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 368);
            this.Controls.Add(this.btnADDITEM);
            this.Controls.Add(this.BTNDELETEITEM);
            this.Controls.Add(this.btnUpdateITEM);
            this.Controls.Add(this.BTNDISPLAsuP);
            this.Controls.Add(this.btnHome);
            this.Name = "Itemmaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Itemmaster";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnADDITEM;
        private System.Windows.Forms.Button BTNDELETEITEM;
        private System.Windows.Forms.Button btnUpdateITEM;
        private System.Windows.Forms.Button BTNDISPLAsuP;
        private System.Windows.Forms.Button btnHome;
    }
}