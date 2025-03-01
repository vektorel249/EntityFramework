namespace Vektorel.EFForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvResult = new DataGridView();
            btnSuppliers1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // dgvResult
            // 
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(12, 12);
            dgvResult.Name = "dgvResult";
            dgvResult.Size = new Size(568, 341);
            dgvResult.TabIndex = 0;
            // 
            // btnSuppliers1
            // 
            btnSuppliers1.Location = new Point(12, 359);
            btnSuppliers1.Name = "btnSuppliers1";
            btnSuppliers1.Size = new Size(150, 23);
            btnSuppliers1.TabIndex = 1;
            btnSuppliers1.Text = "Almanyadaki Firmalar";
            btnSuppliers1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 437);
            Controls.Add(btnSuppliers1);
            Controls.Add(dgvResult);
            Name = "Form1";
            Text = "Entity Framework";
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvResult;
        private Button btnSuppliers1;
    }
}
