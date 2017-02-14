namespace Use_Case_Helper
{
    partial class Form1
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
            this.gblements = new System.Windows.Forms.GroupBox();
            this.rbtnactor = new System.Windows.Forms.RadioButton();
            this.rbtnusecases = new System.Windows.Forms.RadioButton();
            this.rbtnline = new System.Windows.Forms.RadioButton();
            this.gpbmode = new System.Windows.Forms.GroupBox();
            this.rbtncreate = new System.Windows.Forms.RadioButton();
            this.rbtnselect = new System.Windows.Forms.RadioButton();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gblements.SuspendLayout();
            this.gpbmode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gblements
            // 
            this.gblements.Controls.Add(this.rbtnline);
            this.gblements.Controls.Add(this.rbtnusecases);
            this.gblements.Controls.Add(this.rbtnactor);
            this.gblements.Location = new System.Drawing.Point(533, 12);
            this.gblements.Name = "gblements";
            this.gblements.Size = new System.Drawing.Size(131, 91);
            this.gblements.TabIndex = 0;
            this.gblements.TabStop = false;
            this.gblements.Text = "Elements";
            // 
            // rbtnactor
            // 
            this.rbtnactor.AutoSize = true;
            this.rbtnactor.Location = new System.Drawing.Point(6, 19);
            this.rbtnactor.Name = "rbtnactor";
            this.rbtnactor.Size = new System.Drawing.Size(50, 17);
            this.rbtnactor.TabIndex = 1;
            this.rbtnactor.TabStop = true;
            this.rbtnactor.Text = "Actor";
            this.rbtnactor.UseVisualStyleBackColor = true;
            // 
            // rbtnusecases
            // 
            this.rbtnusecases.AutoSize = true;
            this.rbtnusecases.Location = new System.Drawing.Point(6, 42);
            this.rbtnusecases.Name = "rbtnusecases";
            this.rbtnusecases.Size = new System.Drawing.Size(71, 17);
            this.rbtnusecases.TabIndex = 2;
            this.rbtnusecases.TabStop = true;
            this.rbtnusecases.Text = "Use Case";
            this.rbtnusecases.UseVisualStyleBackColor = true;
            // 
            // rbtnline
            // 
            this.rbtnline.AutoSize = true;
            this.rbtnline.Location = new System.Drawing.Point(6, 64);
            this.rbtnline.Name = "rbtnline";
            this.rbtnline.Size = new System.Drawing.Size(45, 17);
            this.rbtnline.TabIndex = 2;
            this.rbtnline.TabStop = true;
            this.rbtnline.Text = "Line";
            this.rbtnline.UseVisualStyleBackColor = true;
            // 
            // gpbmode
            // 
            this.gpbmode.Controls.Add(this.rbtnselect);
            this.gpbmode.Controls.Add(this.rbtncreate);
            this.gpbmode.Location = new System.Drawing.Point(533, 135);
            this.gpbmode.Name = "gpbmode";
            this.gpbmode.Size = new System.Drawing.Size(131, 64);
            this.gpbmode.TabIndex = 1;
            this.gpbmode.TabStop = false;
            this.gpbmode.Text = "Mode";
            // 
            // rbtncreate
            // 
            this.rbtncreate.AutoSize = true;
            this.rbtncreate.Location = new System.Drawing.Point(10, 18);
            this.rbtncreate.Name = "rbtncreate";
            this.rbtncreate.Size = new System.Drawing.Size(56, 17);
            this.rbtncreate.TabIndex = 0;
            this.rbtncreate.TabStop = true;
            this.rbtncreate.Text = "Create";
            this.rbtncreate.UseVisualStyleBackColor = true;
            // 
            // rbtnselect
            // 
            this.rbtnselect.AutoSize = true;
            this.rbtnselect.Location = new System.Drawing.Point(10, 41);
            this.rbtnselect.Name = "rbtnselect";
            this.rbtnselect.Size = new System.Drawing.Size(55, 17);
            this.rbtnselect.TabIndex = 1;
            this.rbtnselect.TabStop = true;
            this.rbtnselect.Text = "Select";
            this.rbtnselect.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(535, 231);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(128, 33);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "Clear All";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(533, 286);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(128, 33);
            this.btnremove.TabIndex = 3;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(19, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 296);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 331);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.gpbmode);
            this.Controls.Add(this.gblements);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gblements.ResumeLayout(false);
            this.gblements.PerformLayout();
            this.gpbmode.ResumeLayout(false);
            this.gpbmode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gblements;
        private System.Windows.Forms.RadioButton rbtnactor;
        private System.Windows.Forms.RadioButton rbtnline;
        private System.Windows.Forms.RadioButton rbtnusecases;
        private System.Windows.Forms.GroupBox gpbmode;
        private System.Windows.Forms.RadioButton rbtnselect;
        private System.Windows.Forms.RadioButton rbtncreate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

