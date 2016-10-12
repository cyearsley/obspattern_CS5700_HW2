namespace StockSim
{
    partial class StockApplication
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
            this.appStockLabel = new System.Windows.Forms.Label();
            this.appStockCombo = new System.Windows.Forms.ComboBox();
            this.stockPriceButton = new System.Windows.Forms.Button();
            this.createPanelLabel = new System.Windows.Forms.Label();
            this.priceGraphButton = new System.Windows.Forms.Button();
            this.volumeGraphButton = new System.Windows.Forms.Button();
            this.appPortfolioLabel = new System.Windows.Forms.Label();
            this.appPortfolioList = new System.Windows.Forms.ListBox();
            this.appAddStock = new System.Windows.Forms.Button();
            this.appRemoveStock = new System.Windows.Forms.Button();
            this.appListOfSymbolsList = new System.Windows.Forms.ListBox();
            this.appSavePortfolioButton = new System.Windows.Forms.Button();
            this.stockContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // appStockLabel
            // 
            this.appStockLabel.AutoSize = true;
            this.appStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.appStockLabel.Location = new System.Drawing.Point(1115, 12);
            this.appStockLabel.Name = "appStockLabel";
            this.appStockLabel.Size = new System.Drawing.Size(92, 25);
            this.appStockLabel.TabIndex = 1;
            this.appStockLabel.Text = "Stock(s):";
            // 
            // appStockCombo
            // 
            this.appStockCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.appStockCombo.FormattingEnabled = true;
            this.appStockCombo.ItemHeight = 20;
            this.appStockCombo.Location = new System.Drawing.Point(1079, 40);
            this.appStockCombo.Name = "appStockCombo";
            this.appStockCombo.Size = new System.Drawing.Size(128, 28);
            this.appStockCombo.TabIndex = 2;
            this.appStockCombo.SelectedIndexChanged += new System.EventHandler(this.appStockCombo_SelectedIndexChanged);
            // 
            // stockPriceButton
            // 
            this.stockPriceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.stockPriceButton.Location = new System.Drawing.Point(898, 40);
            this.stockPriceButton.Name = "stockPriceButton";
            this.stockPriceButton.Size = new System.Drawing.Size(136, 47);
            this.stockPriceButton.TabIndex = 3;
            this.stockPriceButton.Text = "Stock Prices";
            this.stockPriceButton.UseVisualStyleBackColor = true;
            this.stockPriceButton.Click += new System.EventHandler(this.stockPriceButton_Click);
            // 
            // createPanelLabel
            // 
            this.createPanelLabel.AutoSize = true;
            this.createPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.createPanelLabel.Location = new System.Drawing.Point(899, 13);
            this.createPanelLabel.Name = "createPanelLabel";
            this.createPanelLabel.Size = new System.Drawing.Size(126, 25);
            this.createPanelLabel.TabIndex = 4;
            this.createPanelLabel.Text = "Create Panel";
            // 
            // priceGraphButton
            // 
            this.priceGraphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.priceGraphButton.Location = new System.Drawing.Point(898, 93);
            this.priceGraphButton.Name = "priceGraphButton";
            this.priceGraphButton.Size = new System.Drawing.Size(136, 47);
            this.priceGraphButton.TabIndex = 5;
            this.priceGraphButton.Text = "Price Graph";
            this.priceGraphButton.UseVisualStyleBackColor = true;
            this.priceGraphButton.Click += new System.EventHandler(this.priceGraphButton_Click);
            // 
            // volumeGraphButton
            // 
            this.volumeGraphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.volumeGraphButton.Location = new System.Drawing.Point(898, 146);
            this.volumeGraphButton.Name = "volumeGraphButton";
            this.volumeGraphButton.Size = new System.Drawing.Size(136, 47);
            this.volumeGraphButton.TabIndex = 6;
            this.volumeGraphButton.Text = "Volume Graph";
            this.volumeGraphButton.UseVisualStyleBackColor = true;
            this.volumeGraphButton.Click += new System.EventHandler(this.volumeGraphButton_Click);
            // 
            // appPortfolioLabel
            // 
            this.appPortfolioLabel.AutoSize = true;
            this.appPortfolioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.appPortfolioLabel.Location = new System.Drawing.Point(898, 245);
            this.appPortfolioLabel.Name = "appPortfolioLabel";
            this.appPortfolioLabel.Size = new System.Drawing.Size(158, 25);
            this.appPortfolioLabel.TabIndex = 7;
            this.appPortfolioLabel.Text = "Current Portfolio:";
            // 
            // appPortfolioList
            // 
            this.appPortfolioList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.appPortfolioList.FormattingEnabled = true;
            this.appPortfolioList.ItemHeight = 20;
            this.appPortfolioList.Location = new System.Drawing.Point(899, 274);
            this.appPortfolioList.Name = "appPortfolioList";
            this.appPortfolioList.Size = new System.Drawing.Size(157, 284);
            this.appPortfolioList.TabIndex = 8;
            // 
            // appAddStock
            // 
            this.appAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.appAddStock.Location = new System.Drawing.Point(980, 565);
            this.appAddStock.Name = "appAddStock";
            this.appAddStock.Size = new System.Drawing.Size(75, 36);
            this.appAddStock.TabIndex = 9;
            this.appAddStock.Text = "+";
            this.appAddStock.UseVisualStyleBackColor = true;
            this.appAddStock.Click += new System.EventHandler(this.appAddStock_Click);
            // 
            // appRemoveStock
            // 
            this.appRemoveStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.appRemoveStock.Location = new System.Drawing.Point(899, 564);
            this.appRemoveStock.Name = "appRemoveStock";
            this.appRemoveStock.Size = new System.Drawing.Size(75, 36);
            this.appRemoveStock.TabIndex = 10;
            this.appRemoveStock.Text = "-";
            this.appRemoveStock.UseVisualStyleBackColor = true;
            this.appRemoveStock.Click += new System.EventHandler(this.appRemoveStock_Click);
            // 
            // appListOfSymbolsList
            // 
            this.appListOfSymbolsList.Enabled = false;
            this.appListOfSymbolsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.appListOfSymbolsList.FormattingEnabled = true;
            this.appListOfSymbolsList.ItemHeight = 20;
            this.appListOfSymbolsList.Location = new System.Drawing.Point(1079, 274);
            this.appListOfSymbolsList.Name = "appListOfSymbolsList";
            this.appListOfSymbolsList.Size = new System.Drawing.Size(128, 224);
            this.appListOfSymbolsList.TabIndex = 11;
            this.appListOfSymbolsList.SelectedIndexChanged += new System.EventHandler(this.appListOfSymbolsList_SelectedIndexChanged);
            // 
            // appSavePortfolioButton
            // 
            this.appSavePortfolioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.appSavePortfolioButton.Location = new System.Drawing.Point(1079, 534);
            this.appSavePortfolioButton.Name = "appSavePortfolioButton";
            this.appSavePortfolioButton.Size = new System.Drawing.Size(128, 66);
            this.appSavePortfolioButton.TabIndex = 12;
            this.appSavePortfolioButton.Text = "Save Portfolio";
            this.appSavePortfolioButton.UseVisualStyleBackColor = true;
            this.appSavePortfolioButton.Click += new System.EventHandler(this.appSavePortfolioButton_Click);
            // 
            // stockContainer
            // 
            this.stockContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stockContainer.Location = new System.Drawing.Point(13, 12);
            this.stockContainer.Name = "stockContainer";
            this.stockContainer.Size = new System.Drawing.Size(879, 589);
            this.stockContainer.TabIndex = 13;
            this.stockContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.stockContainer_Paint);
            // 
            // StockApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1219, 637);
            this.Controls.Add(this.stockContainer);
            this.Controls.Add(this.appSavePortfolioButton);
            this.Controls.Add(this.appListOfSymbolsList);
            this.Controls.Add(this.appRemoveStock);
            this.Controls.Add(this.appAddStock);
            this.Controls.Add(this.appPortfolioList);
            this.Controls.Add(this.appPortfolioLabel);
            this.Controls.Add(this.volumeGraphButton);
            this.Controls.Add(this.priceGraphButton);
            this.Controls.Add(this.createPanelLabel);
            this.Controls.Add(this.stockPriceButton);
            this.Controls.Add(this.appStockCombo);
            this.Controls.Add(this.appStockLabel);
            this.Name = "StockApplication";
            this.Text = "StockApplication";
            this.Load += new System.EventHandler(this.StockApplication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label appStockLabel;
        private System.Windows.Forms.ComboBox appStockCombo;
        private System.Windows.Forms.Button stockPriceButton;
        private System.Windows.Forms.Label createPanelLabel;
        private System.Windows.Forms.Button priceGraphButton;
        private System.Windows.Forms.Button volumeGraphButton;
        private System.Windows.Forms.Label appPortfolioLabel;
        private System.Windows.Forms.ListBox appPortfolioList;
        private System.Windows.Forms.Button appAddStock;
        private System.Windows.Forms.Button appRemoveStock;
        private System.Windows.Forms.ListBox appListOfSymbolsList;
        private System.Windows.Forms.Button appSavePortfolioButton;
        private System.Windows.Forms.FlowLayoutPanel stockContainer;
    }
}