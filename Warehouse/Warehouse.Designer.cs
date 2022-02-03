
namespace Warehouse
{
    public partial class Warehouse
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warehouse));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView = new System.Windows.Forms.TreeView();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.productNameColumn = new System.Windows.Forms.ColumnHeader();
            this.productCodeColumn = new System.Windows.Forms.ColumnHeader();
            this.productAmmountColumn = new System.Windows.Forms.ColumnHeader();
            this.productPriceColumn = new System.Windows.Forms.ColumnHeader();
            this.endingGoodsStrip = new System.Windows.Forms.MenuStrip();
            this.loadStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultSave = new System.Windows.Forms.ToolStripMenuItem();
            this.saveStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.csv = new System.Windows.Forms.ToolStripMenuItem();
            this.endingStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.allProducts = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.endingGoodsStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            // 
            // treeView
            // 
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList1;
            this.treeView.Location = new System.Drawing.Point(12, 36);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(298, 596);
            this.treeView.TabIndex = 0;
            this.treeView.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeViewBeforeCollapse);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewNodeMouseDoubleClick);
            // 
            // listViewProducts
            // 
            this.listViewProducts.BackColor = System.Drawing.SystemColors.Menu;
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productNameColumn,
            this.productCodeColumn,
            this.productAmmountColumn,
            this.productPriceColumn});
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(316, 36);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(850, 279);
            this.listViewProducts.TabIndex = 2;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            this.listViewProducts.DoubleClick += new System.EventHandler(this.listViewProducts_DoubleClick);
            // 
            // productNameColumn
            // 
            this.productNameColumn.Text = "Name";
            this.productNameColumn.Width = 380;
            // 
            // productCodeColumn
            // 
            this.productCodeColumn.Text = "Vendor Code";
            this.productCodeColumn.Width = 150;
            // 
            // productAmmountColumn
            // 
            this.productAmmountColumn.Text = "Ammount";
            this.productAmmountColumn.Width = 120;
            // 
            // productPriceColumn
            // 
            this.productPriceColumn.Text = "Price";
            this.productPriceColumn.Width = 150;
            // 
            // endingGoodsStrip
            // 
            this.endingGoodsStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.endingGoodsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadStrip,
            this.defaultSave,
            this.saveStrip,
            this.csv,
            this.endingStrip});
            this.endingGoodsStrip.Location = new System.Drawing.Point(0, 0);
            this.endingGoodsStrip.Name = "endingGoodsStrip";
            this.endingGoodsStrip.Size = new System.Drawing.Size(1178, 33);
            this.endingGoodsStrip.TabIndex = 4;
            this.endingGoodsStrip.Text = "menuStrip1";
            this.endingGoodsStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // loadStrip
            // 
            this.loadStrip.Name = "loadStrip";
            this.loadStrip.Size = new System.Drawing.Size(67, 29);
            this.loadStrip.Text = "Load";
            // 
            // defaultSave
            // 
            this.defaultSave.Name = "defaultSave";
            this.defaultSave.Size = new System.Drawing.Size(125, 29);
            this.defaultSave.Text = "Default save";
            // 
            // saveStrip
            // 
            this.saveStrip.Name = "saveStrip";
            this.saveStrip.Size = new System.Drawing.Size(95, 29);
            this.saveStrip.Text = "Save as..";
            // 
            // csv
            // 
            this.csv.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.csv.Name = "csv";
            this.csv.Size = new System.Drawing.Size(102, 29);
            this.csv.Text = "Save CSV";
            // 
            // endingStrip
            // 
            this.endingStrip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.endingStrip.Name = "endingStrip";
            this.endingStrip.Size = new System.Drawing.Size(184, 29);
            this.endingStrip.Text = "Ending Goods Limit";
            // 
            // allProducts
            // 
            this.allProducts.BackColor = System.Drawing.SystemColors.Menu;
            this.allProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.allProducts.HideSelection = false;
            this.allProducts.Location = new System.Drawing.Point(316, 350);
            this.allProducts.Name = "allProducts";
            this.allProducts.Size = new System.Drawing.Size(850, 282);
            this.allProducts.TabIndex = 5;
            this.allProducts.UseCompatibleStateImageBehavior = false;
            this.allProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 380;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Vendor Code";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ammount";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Products in subsections:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 597);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Double click for editing";
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allProducts);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.endingGoodsStrip);
            this.MainMenuStrip = this.endingGoodsStrip;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Warehouse";
            this.Text = "Warehouse";
            this.Load += new System.EventHandler(this.WarehouseLoad);
            this.endingGoodsStrip.ResumeLayout(false);
            this.endingGoodsStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.ColumnHeader productNameColumn;
        private System.Windows.Forms.ColumnHeader productCodeColumn;
        private System.Windows.Forms.ColumnHeader productAmmountColumn;
        private System.Windows.Forms.ColumnHeader productPriceColumn;
        private System.Windows.Forms.MenuStrip endingGoodsStrip;
        private System.Windows.Forms.ToolStripMenuItem loadStrip;
        private System.Windows.Forms.ToolStripMenuItem saveStrip;
        private System.Windows.Forms.ToolStripMenuItem defaultSave;
        private System.Windows.Forms.ToolStripMenuItem endingStrip;
        private System.Windows.Forms.ToolStripMenuItem csv;
        private System.Windows.Forms.ListView allProducts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

