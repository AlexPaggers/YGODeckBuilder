namespace YuGiOhDeckBuilder
{
    partial class YugiohDeckBuilderForm
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
            this.groupBoxDeck = new System.Windows.Forms.GroupBox();
            this.listBoxDeck = new System.Windows.Forms.ListBox();
            this.buttonClearDeck = new System.Windows.Forms.Button();
            this.buttonImportDeck = new System.Windows.Forms.Button();
            this.buttonSaveDeck = new System.Windows.Forms.Button();
            this.groupBoxCollection = new System.Windows.Forms.GroupBox();
            this.listBoxCollection = new System.Windows.Forms.ListBox();
            this.buttonDeleteCreatedCard = new System.Windows.Forms.Button();
            this.buttonCreateCard = new System.Windows.Forms.Button();
            this.buttonRemoveFromDeck = new System.Windows.Forms.Button();
            this.buttonAddToDeck = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.groupBoxDeck.SuspendLayout();
            this.groupBoxCollection.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDeck
            // 
            this.groupBoxDeck.Controls.Add(this.listBoxDeck);
            this.groupBoxDeck.Controls.Add(this.buttonClearDeck);
            this.groupBoxDeck.Controls.Add(this.buttonImportDeck);
            this.groupBoxDeck.Controls.Add(this.buttonSaveDeck);
            this.groupBoxDeck.Location = new System.Drawing.Point(13, 13);
            this.groupBoxDeck.Name = "groupBoxDeck";
            this.groupBoxDeck.Size = new System.Drawing.Size(238, 545);
            this.groupBoxDeck.TabIndex = 0;
            this.groupBoxDeck.TabStop = false;
            this.groupBoxDeck.Text = "Deck";
            // 
            // listBoxDeck
            // 
            this.listBoxDeck.FormattingEnabled = true;
            this.listBoxDeck.Location = new System.Drawing.Point(7, 20);
            this.listBoxDeck.Name = "listBoxDeck";
            this.listBoxDeck.Size = new System.Drawing.Size(224, 394);
            this.listBoxDeck.TabIndex = 8;
            // 
            // buttonClearDeck
            // 
            this.buttonClearDeck.Location = new System.Drawing.Point(82, 422);
            this.buttonClearDeck.Name = "buttonClearDeck";
            this.buttonClearDeck.Size = new System.Drawing.Size(75, 23);
            this.buttonClearDeck.TabIndex = 6;
            this.buttonClearDeck.Text = "Clear Deck";
            this.buttonClearDeck.UseVisualStyleBackColor = true;
            this.buttonClearDeck.Click += new System.EventHandler(this.buttonClearDeck_Click);
            // 
            // buttonImportDeck
            // 
            this.buttonImportDeck.Location = new System.Drawing.Point(139, 498);
            this.buttonImportDeck.Name = "buttonImportDeck";
            this.buttonImportDeck.Size = new System.Drawing.Size(92, 41);
            this.buttonImportDeck.TabIndex = 7;
            this.buttonImportDeck.Text = "Import Deck";
            this.buttonImportDeck.UseVisualStyleBackColor = true;
            this.buttonImportDeck.Click += new System.EventHandler(this.buttonImportDeck_Click);
            // 
            // buttonSaveDeck
            // 
            this.buttonSaveDeck.Location = new System.Drawing.Point(7, 498);
            this.buttonSaveDeck.Name = "buttonSaveDeck";
            this.buttonSaveDeck.Size = new System.Drawing.Size(92, 41);
            this.buttonSaveDeck.TabIndex = 5;
            this.buttonSaveDeck.Text = "Save Deck";
            this.buttonSaveDeck.UseVisualStyleBackColor = true;
            this.buttonSaveDeck.Click += new System.EventHandler(this.buttonSaveDeck_Click);
            // 
            // groupBoxCollection
            // 
            this.groupBoxCollection.Controls.Add(this.listBoxCollection);
            this.groupBoxCollection.Controls.Add(this.buttonDeleteCreatedCard);
            this.groupBoxCollection.Controls.Add(this.buttonCreateCard);
            this.groupBoxCollection.Location = new System.Drawing.Point(338, 13);
            this.groupBoxCollection.Name = "groupBoxCollection";
            this.groupBoxCollection.Size = new System.Drawing.Size(173, 545);
            this.groupBoxCollection.TabIndex = 1;
            this.groupBoxCollection.TabStop = false;
            this.groupBoxCollection.Text = "Card Collection";
            // 
            // listBoxCollection
            // 
            this.listBoxCollection.FormattingEnabled = true;
            this.listBoxCollection.Location = new System.Drawing.Point(6, 20);
            this.listBoxCollection.Name = "listBoxCollection";
            this.listBoxCollection.Size = new System.Drawing.Size(167, 459);
            this.listBoxCollection.TabIndex = 3;
            // 
            // buttonDeleteCreatedCard
            // 
            this.buttonDeleteCreatedCard.Location = new System.Drawing.Point(6, 511);
            this.buttonDeleteCreatedCard.Name = "buttonDeleteCreatedCard";
            this.buttonDeleteCreatedCard.Size = new System.Drawing.Size(161, 23);
            this.buttonDeleteCreatedCard.TabIndex = 2;
            this.buttonDeleteCreatedCard.Text = "Remove Card from Collection";
            this.buttonDeleteCreatedCard.UseVisualStyleBackColor = true;
            // 
            // buttonCreateCard
            // 
            this.buttonCreateCard.Location = new System.Drawing.Point(7, 482);
            this.buttonCreateCard.Name = "buttonCreateCard";
            this.buttonCreateCard.Size = new System.Drawing.Size(160, 23);
            this.buttonCreateCard.TabIndex = 1;
            this.buttonCreateCard.Text = "Add New Card to Collection";
            this.buttonCreateCard.UseVisualStyleBackColor = true;
            this.buttonCreateCard.Click += new System.EventHandler(this.buttonCreateCard_Click);
            // 
            // buttonRemoveFromDeck
            // 
            this.buttonRemoveFromDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveFromDeck.ForeColor = System.Drawing.Color.Red;
            this.buttonRemoveFromDeck.Location = new System.Drawing.Point(257, 207);
            this.buttonRemoveFromDeck.Name = "buttonRemoveFromDeck";
            this.buttonRemoveFromDeck.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveFromDeck.TabIndex = 2;
            this.buttonRemoveFromDeck.Text = "--->";
            this.buttonRemoveFromDeck.UseVisualStyleBackColor = true;
            this.buttonRemoveFromDeck.Click += new System.EventHandler(this.buttonRemoveFromDeck_Click);
            // 
            // buttonAddToDeck
            // 
            this.buttonAddToDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToDeck.ForeColor = System.Drawing.Color.Green;
            this.buttonAddToDeck.Location = new System.Drawing.Point(256, 178);
            this.buttonAddToDeck.Name = "buttonAddToDeck";
            this.buttonAddToDeck.Size = new System.Drawing.Size(75, 23);
            this.buttonAddToDeck.TabIndex = 3;
            this.buttonAddToDeck.Text = "<---";
            this.buttonAddToDeck.UseVisualStyleBackColor = true;
            this.buttonAddToDeck.Click += new System.EventHandler(this.buttonAddToDeck_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(284, 33);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(54, 25);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // YugiohDeckBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 570);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonAddToDeck);
            this.Controls.Add(this.buttonRemoveFromDeck);
            this.Controls.Add(this.groupBoxCollection);
            this.Controls.Add(this.groupBoxDeck);
            this.Name = "YugiohDeckBuilderForm";
            this.Text = "Yu-Gi-Oh! Deck Builder";
            this.groupBoxDeck.ResumeLayout(false);
            this.groupBoxCollection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDeck;
        private System.Windows.Forms.Button buttonClearDeck;
        private System.Windows.Forms.Button buttonImportDeck;
        private System.Windows.Forms.Button buttonSaveDeck;
        private System.Windows.Forms.GroupBox groupBoxCollection;
        private System.Windows.Forms.Button buttonRemoveFromDeck;
        private System.Windows.Forms.Button buttonAddToDeck;
        private System.Windows.Forms.Button buttonDeleteCreatedCard;
        private System.Windows.Forms.Button buttonCreateCard;
        private System.Windows.Forms.ListBox listBoxDeck;
        private System.Windows.Forms.ListBox listBoxCollection;
        private System.Windows.Forms.Button buttonRefresh;
    }
}

