namespace StockSim
{
    partial class appIntro
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
            this.newPortfolioButton = new System.Windows.Forms.Button();
            this.loadPortfolioButton = new System.Windows.Forms.Button();
            this.introSymbolCombo = new System.Windows.Forms.ComboBox();
            this.symbolIntroList = new System.Windows.Forms.ListBox();
            this.introPromptLabel = new System.Windows.Forms.Label();
            this.introCreatePortfolioButton = new System.Windows.Forms.Button();
            this.removeSelectedSymbols = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newPortfolioButton
            // 
            this.newPortfolioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.newPortfolioButton.Location = new System.Drawing.Point(92, 75);
            this.newPortfolioButton.Name = "newPortfolioButton";
            this.newPortfolioButton.Size = new System.Drawing.Size(118, 59);
            this.newPortfolioButton.TabIndex = 0;
            this.newPortfolioButton.Text = "New Portfolio";
            this.newPortfolioButton.UseVisualStyleBackColor = true;
            this.newPortfolioButton.Click += new System.EventHandler(this.newPortfolioButton_Click);
            // 
            // loadPortfolioButton
            // 
            this.loadPortfolioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loadPortfolioButton.Location = new System.Drawing.Point(238, 75);
            this.loadPortfolioButton.Name = "loadPortfolioButton";
            this.loadPortfolioButton.Size = new System.Drawing.Size(118, 59);
            this.loadPortfolioButton.TabIndex = 1;
            this.loadPortfolioButton.Text = "Load Portfolio";
            this.loadPortfolioButton.UseVisualStyleBackColor = true;
            this.loadPortfolioButton.Click += new System.EventHandler(this.loadPortfolioButton_Click);
            // 
            // introSymbolCombo
            // 
            this.introSymbolCombo.BackColor = System.Drawing.Color.AliceBlue;
            this.introSymbolCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.introSymbolCombo.FormattingEnabled = true;
            this.introSymbolCombo.Location = new System.Drawing.Point(29, 140);
            this.introSymbolCombo.Name = "introSymbolCombo";
            this.introSymbolCombo.Size = new System.Drawing.Size(181, 21);
            this.introSymbolCombo.TabIndex = 2;
            this.introSymbolCombo.Tag = "";
            this.introSymbolCombo.Text = "Select Some Symbols...";
            this.introSymbolCombo.SelectedIndexChanged += new System.EventHandler(this.introSymbolCombo_SelectedIndexChanged);
            // 
            // symbolIntroList
            // 
            this.symbolIntroList.FormattingEnabled = true;
            this.symbolIntroList.HorizontalScrollbar = true;
            this.symbolIntroList.Location = new System.Drawing.Point(238, 140);
            this.symbolIntroList.Name = "symbolIntroList";
            this.symbolIntroList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.symbolIntroList.Size = new System.Drawing.Size(118, 238);
            this.symbolIntroList.TabIndex = 3;
            this.symbolIntroList.SelectedIndexChanged += new System.EventHandler(this.symbolIntroList_SelectedIndexChanged);
            // 
            // introPromptLabel
            // 
            this.introPromptLabel.AutoSize = true;
            this.introPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.introPromptLabel.Location = new System.Drawing.Point(74, 9);
            this.introPromptLabel.Name = "introPromptLabel";
            this.introPromptLabel.Size = new System.Drawing.Size(310, 29);
            this.introPromptLabel.TabIndex = 4;
            this.introPromptLabel.Text = "Please Select Some Stocks";
            this.introPromptLabel.Click += new System.EventHandler(this.introPromptLabel_Click);
            // 
            // introCreatePortfolioButton
            // 
            this.introCreatePortfolioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.introCreatePortfolioButton.Location = new System.Drawing.Point(135, 41);
            this.introCreatePortfolioButton.Name = "introCreatePortfolioButton";
            this.introCreatePortfolioButton.Size = new System.Drawing.Size(174, 75);
            this.introCreatePortfolioButton.TabIndex = 5;
            this.introCreatePortfolioButton.Text = "Create Portfolio";
            this.introCreatePortfolioButton.UseVisualStyleBackColor = true;
            this.introCreatePortfolioButton.Click += new System.EventHandler(this.introCreatePortfolioButton_Click);
            // 
            // removeSelectedSymbols
            // 
            this.removeSelectedSymbols.Location = new System.Drawing.Point(362, 224);
            this.removeSelectedSymbols.Name = "removeSelectedSymbols";
            this.removeSelectedSymbols.Size = new System.Drawing.Size(75, 43);
            this.removeSelectedSymbols.TabIndex = 6;
            this.removeSelectedSymbols.Text = "Remove Selected";
            this.removeSelectedSymbols.UseVisualStyleBackColor = true;
            this.removeSelectedSymbols.Click += new System.EventHandler(this.removeSelectedSymbols_Click);
            // 
            // appIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(463, 393);
            this.Controls.Add(this.removeSelectedSymbols);
            this.Controls.Add(this.introPromptLabel);
            this.Controls.Add(this.symbolIntroList);
            this.Controls.Add(this.introSymbolCombo);
            this.Controls.Add(this.loadPortfolioButton);
            this.Controls.Add(this.newPortfolioButton);
            this.Controls.Add(this.introCreatePortfolioButton);
            this.Name = "appIntro";
            this.Text = "appIntro";
            this.Load += new System.EventHandler(this.appIntro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newPortfolioButton;
        private System.Windows.Forms.Button loadPortfolioButton;
        private System.Windows.Forms.ComboBox introSymbolCombo;
        private System.Windows.Forms.ListBox symbolIntroList;
        private System.Windows.Forms.Label introPromptLabel;
        private System.Windows.Forms.Button introCreatePortfolioButton;
        private System.Windows.Forms.Button removeSelectedSymbols;
    }
}