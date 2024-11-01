namespace Test1
{
    partial class go
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
            this.view = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(229, 549);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(148, 44);
            this.view.TabIndex = 1;
            this.view.Text = "Show all orders";
            this.view.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(488, 549);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(116, 44);
            this.Add.TabIndex = 2;
            this.Add.Text = "New order";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 534);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(878, 483);
            this.dataGridView1.TabIndex = 0;
            // 
            // go
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.view);
            this.Name = "go";
            this.Text = "go";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button view;
        private Button Add;
        private Panel panel1;
        private DataGridView dataGridView1;
    }
}