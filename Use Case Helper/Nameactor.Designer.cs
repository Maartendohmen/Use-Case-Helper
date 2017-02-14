namespace Use_Case_Helper
{
    partial class Nameactor
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
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbconfirm = new System.Windows.Forms.Button();
            this.lbexplanation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(101, 83);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(285, 20);
            this.tbname.TabIndex = 0;
            // 
            // tbconfirm
            // 
            this.tbconfirm.Location = new System.Drawing.Point(129, 158);
            this.tbconfirm.Name = "tbconfirm";
            this.tbconfirm.Size = new System.Drawing.Size(205, 37);
            this.tbconfirm.TabIndex = 1;
            this.tbconfirm.Text = "Confirm";
            this.tbconfirm.UseVisualStyleBackColor = true;
            this.tbconfirm.Click += new System.EventHandler(this.tbconfirm_Click);
            // 
            // lbexplanation
            // 
            this.lbexplanation.AutoSize = true;
            this.lbexplanation.Location = new System.Drawing.Point(160, 35);
            this.lbexplanation.Name = "lbexplanation";
            this.lbexplanation.Size = new System.Drawing.Size(163, 13);
            this.lbexplanation.TabIndex = 2;
            this.lbexplanation.Text = "Please fill in a name for the actor:";
            // 
            // Nameactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 261);
            this.Controls.Add(this.lbexplanation);
            this.Controls.Add(this.tbconfirm);
            this.Controls.Add(this.tbname);
            this.Name = "Nameactor";
            this.Text = "Nameactor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button tbconfirm;
        public System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label lbexplanation;
    }
}