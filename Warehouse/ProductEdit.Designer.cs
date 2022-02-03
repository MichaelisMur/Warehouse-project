
namespace Warehouse
{
    partial class ProductEdit
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.priceProductBox = new System.Windows.Forms.TextBox();
            this.ammountProductBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codeProductBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveProductChanges = new System.Windows.Forms.Button();
            this.nameProductBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.deleteProductButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.deleteProductButton);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.priceProductBox);
            this.splitContainer1.Panel1.Controls.Add(this.ammountProductBox);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.codeProductBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.saveProductChanges);
            this.splitContainer1.Panel1.Controls.Add(this.nameProductBox);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Size = new System.Drawing.Size(807, 450);
            this.splitContainer1.SplitterDistance = 140;
            this.splitContainer1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(622, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Price";
            // 
            // priceProductBox
            // 
            this.priceProductBox.Location = new System.Drawing.Point(622, 41);
            this.priceProductBox.Name = "priceProductBox";
            this.priceProductBox.Size = new System.Drawing.Size(175, 31);
            this.priceProductBox.TabIndex = 15;
            // 
            // ammountProductBox
            // 
            this.ammountProductBox.Location = new System.Drawing.Point(419, 41);
            this.ammountProductBox.Name = "ammountProductBox";
            this.ammountProductBox.Size = new System.Drawing.Size(175, 31);
            this.ammountProductBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ammount";
            // 
            // codeProductBox
            // 
            this.codeProductBox.Location = new System.Drawing.Point(215, 41);
            this.codeProductBox.Name = "codeProductBox";
            this.codeProductBox.Size = new System.Drawing.Size(175, 31);
            this.codeProductBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Vendor Code";
            // 
            // saveProductChanges
            // 
            this.saveProductChanges.Location = new System.Drawing.Point(12, 93);
            this.saveProductChanges.Name = "saveProductChanges";
            this.saveProductChanges.Size = new System.Drawing.Size(112, 34);
            this.saveProductChanges.TabIndex = 10;
            this.saveProductChanges.Text = "Save";
            this.saveProductChanges.UseVisualStyleBackColor = true;
            this.saveProductChanges.Click += new System.EventHandler(this.saveProductChanges_Click);
            // 
            // nameProductBox
            // 
            this.nameProductBox.Location = new System.Drawing.Point(12, 41);
            this.nameProductBox.Name = "nameProductBox";
            this.nameProductBox.Size = new System.Drawing.Size(175, 31);
            this.nameProductBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Description";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(429, 265);
            this.textBox1.TabIndex = 0;
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(150, 93);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(112, 34);
            this.deleteProductButton.TabIndex = 17;
            this.deleteProductButton.Text = "Delete";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // ProductEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ProductEdit";
            this.Text = "ProductEdit";
            this.TopMost = true;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceProductBox;
        private System.Windows.Forms.TextBox ammountProductBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codeProductBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveProductChanges;
        private System.Windows.Forms.TextBox nameProductBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button deleteProductButton;
    }
}