
namespace Warehouse
{
    partial class SectorPanel
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
            this.addSectorText = new System.Windows.Forms.TextBox();
            this.AddSector = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.sortingCodeButton = new System.Windows.Forms.Button();
            this.sortingCodeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.renameSectionButton = new System.Windows.Forms.Button();
            this.renameSectionBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteSection = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.productsToGenerate = new System.Windows.Forms.Label();
            this.sectionsToGenerate = new System.Windows.Forms.Label();
            this.comboBoxSubsections = new System.Windows.Forms.ComboBox();
            this.generateSection = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.productNameText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.productCodeText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.productAmmountText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.productPriceText = new System.Windows.Forms.TextBox();
            this.productInfoText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addSectorText
            // 
            this.addSectorText.Location = new System.Drawing.Point(2, 152);
            this.addSectorText.Name = "addSectorText";
            this.addSectorText.Size = new System.Drawing.Size(175, 31);
            this.addSectorText.TabIndex = 0;
            // 
            // AddSector
            // 
            this.AddSector.Location = new System.Drawing.Point(3, 189);
            this.AddSector.Name = "AddSector";
            this.AddSector.Size = new System.Drawing.Size(112, 34);
            this.AddSector.TabIndex = 2;
            this.AddSector.Text = "Add";
            this.AddSector.UseVisualStyleBackColor = true;
            this.AddSector.Click += new System.EventHandler(this.AddSector_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.sortingCodeButton);
            this.splitContainer1.Panel1.Controls.Add(this.sortingCodeBox);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.renameSectionButton);
            this.splitContainer1.Panel1.Controls.Add(this.renameSectionBox);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.deleteSection);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.AddSector);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.addSectorText);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.addProductButton);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.productInfoText);
            this.splitContainer1.Panel2.Controls.Add(this.productPriceText);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.productAmmountText);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.productCodeText);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.productNameText);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.generate);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxProducts);
            this.splitContainer1.Panel2.Controls.Add(this.productsToGenerate);
            this.splitContainer1.Panel2.Controls.Add(this.sectionsToGenerate);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxSubsections);
            this.splitContainer1.Panel2.Controls.Add(this.generateSection);
            this.splitContainer1.Size = new System.Drawing.Size(889, 426);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 3;
            // 
            // sortingCodeButton
            // 
            this.sortingCodeButton.Location = new System.Drawing.Point(3, 312);
            this.sortingCodeButton.Name = "sortingCodeButton";
            this.sortingCodeButton.Size = new System.Drawing.Size(112, 34);
            this.sortingCodeButton.TabIndex = 10;
            this.sortingCodeButton.Text = "Save";
            this.sortingCodeButton.UseVisualStyleBackColor = true;
            this.sortingCodeButton.Click += new System.EventHandler(this.sortingCodeButton_Click);
            // 
            // sortingCodeBox
            // 
            this.sortingCodeBox.Location = new System.Drawing.Point(3, 275);
            this.sortingCodeBox.Name = "sortingCodeBox";
            this.sortingCodeBox.Size = new System.Drawing.Size(175, 31);
            this.sortingCodeBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sorting Code";
            // 
            // renameSectionButton
            // 
            this.renameSectionButton.Location = new System.Drawing.Point(3, 75);
            this.renameSectionButton.Name = "renameSectionButton";
            this.renameSectionButton.Size = new System.Drawing.Size(112, 34);
            this.renameSectionButton.TabIndex = 7;
            this.renameSectionButton.Text = "Save";
            this.renameSectionButton.UseVisualStyleBackColor = true;
            this.renameSectionButton.Click += new System.EventHandler(this.renameSection_Click);
            // 
            // renameSectionBox
            // 
            this.renameSectionBox.Location = new System.Drawing.Point(3, 38);
            this.renameSectionBox.Name = "renameSectionBox";
            this.renameSectionBox.Size = new System.Drawing.Size(175, 31);
            this.renameSectionBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rename Section";
            // 
            // deleteSection
            // 
            this.deleteSection.Location = new System.Drawing.Point(-1, 387);
            this.deleteSection.Name = "deleteSection";
            this.deleteSection.Size = new System.Drawing.Size(112, 34);
            this.deleteSection.TabIndex = 4;
            this.deleteSection.Text = "Delete Sector";
            this.deleteSection.UseVisualStyleBackColor = true;
            this.deleteSection.Click += new System.EventHandler(this.deleteSection_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Delete This Sector";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add New Subsection";
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(459, 70);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(112, 34);
            this.generate.TabIndex = 11;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(254, 72);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(161, 33);
            this.comboBoxProducts.TabIndex = 10;
            // 
            // productsToGenerate
            // 
            this.productsToGenerate.AutoSize = true;
            this.productsToGenerate.Location = new System.Drawing.Point(254, 44);
            this.productsToGenerate.Name = "productsToGenerate";
            this.productsToGenerate.Size = new System.Drawing.Size(178, 25);
            this.productsToGenerate.TabIndex = 9;
            this.productsToGenerate.Text = "Products to generate";
            // 
            // sectionsToGenerate
            // 
            this.sectionsToGenerate.AutoSize = true;
            this.sectionsToGenerate.Location = new System.Drawing.Point(16, 44);
            this.sectionsToGenerate.Name = "sectionsToGenerate";
            this.sectionsToGenerate.Size = new System.Drawing.Size(203, 25);
            this.sectionsToGenerate.TabIndex = 8;
            this.sectionsToGenerate.Text = "Subsections to generate";
            // 
            // comboBoxSubsections
            // 
            this.comboBoxSubsections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubsections.FormattingEnabled = true;
            this.comboBoxSubsections.Location = new System.Drawing.Point(16, 72);
            this.comboBoxSubsections.Name = "comboBoxSubsections";
            this.comboBoxSubsections.Size = new System.Drawing.Size(161, 33);
            this.comboBoxSubsections.TabIndex = 7;
            // 
            // generateSection
            // 
            this.generateSection.AutoSize = true;
            this.generateSection.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateSection.Location = new System.Drawing.Point(143, 14);
            this.generateSection.MinimumSize = new System.Drawing.Size(400, 0);
            this.generateSection.Name = "generateSection";
            this.generateSection.Size = new System.Drawing.Size(400, 30);
            this.generateSection.TabIndex = 6;
            this.generateSection.Text = "Generate section";
            this.generateSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(143, 124);
            this.label5.MinimumSize = new System.Drawing.Size(400, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(400, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "Add new product";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Product name";
            // 
            // productNameText
            // 
            this.productNameText.Location = new System.Drawing.Point(16, 189);
            this.productNameText.Name = "productNameText";
            this.productNameText.Size = new System.Drawing.Size(175, 31);
            this.productNameText.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Vendor code";
            // 
            // productCodeText
            // 
            this.productCodeText.Location = new System.Drawing.Point(224, 189);
            this.productCodeText.Name = "productCodeText";
            this.productCodeText.Size = new System.Drawing.Size(175, 31);
            this.productCodeText.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ammount";
            // 
            // productAmmountText
            // 
            this.productAmmountText.Location = new System.Drawing.Point(16, 262);
            this.productAmmountText.Name = "productAmmountText";
            this.productAmmountText.Size = new System.Drawing.Size(175, 31);
            this.productAmmountText.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(438, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Price";
            // 
            // productPriceText
            // 
            this.productPriceText.Location = new System.Drawing.Point(429, 189);
            this.productPriceText.Name = "productPriceText";
            this.productPriceText.Size = new System.Drawing.Size(175, 31);
            this.productPriceText.TabIndex = 20;
            // 
            // productInfoText
            // 
            this.productInfoText.Location = new System.Drawing.Point(224, 262);
            this.productInfoText.Name = "productInfoText";
            this.productInfoText.Size = new System.Drawing.Size(380, 31);
            this.productInfoText.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(224, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Description";
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(224, 359);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(175, 34);
            this.addProductButton.TabIndex = 23;
            this.addProductButton.Text = "Add product";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // SectorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SectorPanel";
            this.Text = "NodePanel";
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

        private System.Windows.Forms.Button AddSector;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addSectorText;
        private System.Windows.Forms.Button deleteSection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button renameSectionButton;
        private System.Windows.Forms.TextBox renameSectionBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sortingCodeButton;
        private System.Windows.Forms.TextBox sortingCodeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSubsections;
        private System.Windows.Forms.Label generateSection;
        private System.Windows.Forms.Label sectionsToGenerate;
        private System.Windows.Forms.Label productsToGenerate;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.TextBox productCodeText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox productNameText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox productInfoText;
        private System.Windows.Forms.TextBox productPriceText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox productAmmountText;
        private System.Windows.Forms.Label label8;
    }
}