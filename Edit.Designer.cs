namespace Test1
{
    partial class Edit
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
            this.label1 = new System.Windows.Forms.Label();
            this.oid = new System.Windows.Forms.TextBox();
            this.prc = new System.Windows.Forms.TextBox();
            this.det = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(282, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Order";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // oid
            // 
            this.oid.Location = new System.Drawing.Point(291, 136);
            this.oid.Name = "oid";
            this.oid.Size = new System.Drawing.Size(125, 27);
            this.oid.TabIndex = 1;
            // 
            // prc
            // 
            this.prc.Location = new System.Drawing.Point(291, 212);
            this.prc.Name = "prc";
            this.prc.Size = new System.Drawing.Size(125, 27);
            this.prc.TabIndex = 2;
            // 
            // det
            // 
            this.det.Location = new System.Drawing.Point(291, 277);
            this.det.Name = "det";
            this.det.Size = new System.Drawing.Size(125, 27);
            this.det.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Details :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Order id :";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(304, 337);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(94, 29);
            this.Save.TabIndex = 8;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.det);
            this.Controls.Add(this.prc);
            this.Controls.Add(this.oid);
            this.Controls.Add(this.label1);
            this.Name = "Edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox oid;
        private TextBox prc;
        private TextBox det;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Save;
    }
}