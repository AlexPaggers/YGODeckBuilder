namespace YuGiOhDeckBuilder
{
    partial class CreateCardForm
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
            this.components = new System.ComponentModel.Container();
            this.labelCardName = new System.Windows.Forms.Label();
            this.textBoxCardName = new System.Windows.Forms.TextBox();
            this.labelCardType = new System.Windows.Forms.Label();
            this.comboBoxCardType = new System.Windows.Forms.ComboBox();
            this.buttonCreateCard = new System.Windows.Forms.Button();
            this.labelAttribute = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelAtk = new System.Windows.Forms.Label();
            this.labelDef = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxAttribute = new System.Windows.Forms.ComboBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.numericUpDownLevel = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCardTypes = new System.Windows.Forms.ComboBox();
            this.numericUpDownAtk = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDef = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAtk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDef)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCardName
            // 
            this.labelCardName.AutoSize = true;
            this.labelCardName.Location = new System.Drawing.Point(49, 34);
            this.labelCardName.Name = "labelCardName";
            this.labelCardName.Size = new System.Drawing.Size(38, 13);
            this.labelCardName.TabIndex = 0;
            this.labelCardName.Text = "Name:";
            // 
            // textBoxCardName
            // 
            this.textBoxCardName.Location = new System.Drawing.Point(88, 33);
            this.textBoxCardName.Name = "textBoxCardName";
            this.textBoxCardName.Size = new System.Drawing.Size(215, 20);
            this.textBoxCardName.TabIndex = 1;
            // 
            // labelCardType
            // 
            this.labelCardType.AutoSize = true;
            this.labelCardType.Location = new System.Drawing.Point(12, 9);
            this.labelCardType.Name = "labelCardType";
            this.labelCardType.Size = new System.Drawing.Size(59, 13);
            this.labelCardType.TabIndex = 2;
            this.labelCardType.Text = "Card Type:";
            // 
            // comboBoxCardType
            // 
            this.comboBoxCardType.FormattingEnabled = true;
            this.comboBoxCardType.Location = new System.Drawing.Point(77, 6);
            this.comboBoxCardType.Name = "comboBoxCardType";
            this.comboBoxCardType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCardType.TabIndex = 3;
            this.comboBoxCardType.SelectedIndexChanged += new System.EventHandler(this.comboBoxCardType_SelectedIndexChanged);
            // 
            // buttonCreateCard
            // 
            this.buttonCreateCard.Location = new System.Drawing.Point(94, 343);
            this.buttonCreateCard.Name = "buttonCreateCard";
            this.buttonCreateCard.Size = new System.Drawing.Size(104, 23);
            this.buttonCreateCard.TabIndex = 4;
            this.buttonCreateCard.Text = "Create Card";
            this.buttonCreateCard.UseVisualStyleBackColor = true;
            this.buttonCreateCard.Click += new System.EventHandler(this.buttonCreateCard_Click);
            // 
            // labelAttribute
            // 
            this.labelAttribute.AutoSize = true;
            this.labelAttribute.Location = new System.Drawing.Point(37, 55);
            this.labelAttribute.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAttribute.Name = "labelAttribute";
            this.labelAttribute.Size = new System.Drawing.Size(49, 13);
            this.labelAttribute.TabIndex = 5;
            this.labelAttribute.Text = "Attribute:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(23, 76);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "Description:";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(49, 156);
            this.labelLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(36, 13);
            this.labelLevel.TabIndex = 7;
            this.labelLevel.Text = "Level:";
            // 
            // labelAtk
            // 
            this.labelAtk.AutoSize = true;
            this.labelAtk.Location = new System.Drawing.Point(55, 204);
            this.labelAtk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAtk.Name = "labelAtk";
            this.labelAtk.Size = new System.Drawing.Size(31, 13);
            this.labelAtk.TabIndex = 8;
            this.labelAtk.Text = "ATK:";
            // 
            // labelDef
            // 
            this.labelDef.AutoSize = true;
            this.labelDef.Location = new System.Drawing.Point(54, 230);
            this.labelDef.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDef.Name = "labelDef";
            this.labelDef.Size = new System.Drawing.Size(31, 13);
            this.labelDef.TabIndex = 9;
            this.labelDef.Text = "DEF:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(9, 179);
            this.labelType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(79, 13);
            this.labelType.TabIndex = 12;
            this.labelType.Text = "###### Type:";
            // 
            // comboBoxAttribute
            // 
            this.comboBoxAttribute.FormattingEnabled = true;
            this.comboBoxAttribute.Items.AddRange(new object[] {
            "LIGHT",
            "DARK",
            "FIRE",
            "EARTH",
            "WIND",
            "WATER",
            "DIVINE"});
            this.comboBoxAttribute.Location = new System.Drawing.Point(88, 53);
            this.comboBoxAttribute.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAttribute.Name = "comboBoxAttribute";
            this.comboBoxAttribute.Size = new System.Drawing.Size(96, 21);
            this.comboBoxAttribute.TabIndex = 13;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(88, 74);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxDescription.Size = new System.Drawing.Size(214, 76);
            this.textBoxDescription.TabIndex = 14;
            // 
            // numericUpDownLevel
            // 
            this.numericUpDownLevel.Location = new System.Drawing.Point(90, 153);
            this.numericUpDownLevel.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownLevel.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLevel.Name = "numericUpDownLevel";
            this.numericUpDownLevel.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownLevel.TabIndex = 15;
            this.numericUpDownLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxCardTypes
            // 
            this.comboBoxCardTypes.FormattingEnabled = true;
            this.comboBoxCardTypes.Location = new System.Drawing.Point(88, 175);
            this.comboBoxCardTypes.Name = "comboBoxCardTypes";
            this.comboBoxCardTypes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCardTypes.TabIndex = 16;
            // 
            // numericUpDownAtk
            // 
            this.numericUpDownAtk.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownAtk.Location = new System.Drawing.Point(88, 201);
            this.numericUpDownAtk.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownAtk.Name = "numericUpDownAtk";
            this.numericUpDownAtk.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownAtk.TabIndex = 17;
            // 
            // numericUpDownDef
            // 
            this.numericUpDownDef.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownDef.Location = new System.Drawing.Point(88, 227);
            this.numericUpDownDef.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownDef.Name = "numericUpDownDef";
            this.numericUpDownDef.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownDef.TabIndex = 18;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // CreateCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 378);
            this.Controls.Add(this.numericUpDownDef);
            this.Controls.Add(this.numericUpDownAtk);
            this.Controls.Add(this.comboBoxCardTypes);
            this.Controls.Add(this.numericUpDownLevel);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.comboBoxAttribute);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelDef);
            this.Controls.Add(this.labelAtk);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelAttribute);
            this.Controls.Add(this.buttonCreateCard);
            this.Controls.Add(this.comboBoxCardType);
            this.Controls.Add(this.labelCardType);
            this.Controls.Add(this.textBoxCardName);
            this.Controls.Add(this.labelCardName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Card";
            this.Load += new System.EventHandler(this.CreateCardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAtk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDef)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCardName;
        private System.Windows.Forms.TextBox textBoxCardName;
        private System.Windows.Forms.Label labelCardType;
        private System.Windows.Forms.ComboBox comboBoxCardType;
        private System.Windows.Forms.Button buttonCreateCard;
        private System.Windows.Forms.Label labelAttribute;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelAtk;
        private System.Windows.Forms.Label labelDef;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxAttribute;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.NumericUpDown numericUpDownLevel;
        private System.Windows.Forms.ComboBox comboBoxCardTypes;
        private System.Windows.Forms.NumericUpDown numericUpDownAtk;
        private System.Windows.Forms.NumericUpDown numericUpDownDef;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}