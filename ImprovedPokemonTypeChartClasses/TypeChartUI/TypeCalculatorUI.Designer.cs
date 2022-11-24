namespace TypeChartUI
{
    partial class TypeCalculatorUI
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
            this.lblSecondaryType = new System.Windows.Forms.Label();
            this.lblPrimaryType = new System.Windows.Forms.Label();
            this.SecondaryTypesComboBox = new System.Windows.Forms.ComboBox();
            this.PrimaryTypesComboBox = new System.Windows.Forms.ComboBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.StrengthsAndWeaknessesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSecondaryType
            // 
            this.lblSecondaryType.AutoSize = true;
            this.lblSecondaryType.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSecondaryType.Location = new System.Drawing.Point(601, 34);
            this.lblSecondaryType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecondaryType.Name = "lblSecondaryType";
            this.lblSecondaryType.Size = new System.Drawing.Size(235, 30);
            this.lblSecondaryType.TabIndex = 9;
            this.lblSecondaryType.Text = "Enter Secondary Type: ";
            // 
            // lblPrimaryType
            // 
            this.lblPrimaryType.AutoSize = true;
            this.lblPrimaryType.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrimaryType.Location = new System.Drawing.Point(271, 34);
            this.lblPrimaryType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimaryType.Name = "lblPrimaryType";
            this.lblPrimaryType.Size = new System.Drawing.Size(201, 30);
            this.lblPrimaryType.TabIndex = 8;
            this.lblPrimaryType.Text = "Enter Primary Type:";
            // 
            // SecondaryTypesComboBox
            // 
            this.SecondaryTypesComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.SecondaryTypesComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SecondaryTypesComboBox.DropDownHeight = 150;
            this.SecondaryTypesComboBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondaryTypesComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.SecondaryTypesComboBox.FormattingEnabled = true;
            this.SecondaryTypesComboBox.IntegralHeight = false;
            this.SecondaryTypesComboBox.Location = new System.Drawing.Point(591, 76);
            this.SecondaryTypesComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SecondaryTypesComboBox.Name = "SecondaryTypesComboBox";
            this.SecondaryTypesComboBox.Size = new System.Drawing.Size(254, 38);
            this.SecondaryTypesComboBox.TabIndex = 7;
            this.SecondaryTypesComboBox.Text = "Select Secondary Type:";
            // 
            // PrimaryTypesComboBox
            // 
            this.PrimaryTypesComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PrimaryTypesComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.PrimaryTypesComboBox.DropDownHeight = 150;
            this.PrimaryTypesComboBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrimaryTypesComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.PrimaryTypesComboBox.FormattingEnabled = true;
            this.PrimaryTypesComboBox.IntegralHeight = false;
            this.PrimaryTypesComboBox.ItemHeight = 30;
            this.PrimaryTypesComboBox.Location = new System.Drawing.Point(244, 77);
            this.PrimaryTypesComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PrimaryTypesComboBox.Name = "PrimaryTypesComboBox";
            this.PrimaryTypesComboBox.Size = new System.Drawing.Size(254, 38);
            this.PrimaryTypesComboBox.TabIndex = 6;
            this.PrimaryTypesComboBox.Text = "Select Primary Type:";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalculateButton.Location = new System.Drawing.Point(438, 150);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(205, 47);
            this.CalculateButton.TabIndex = 10;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // StrengthsAndWeaknessesRichTextBox
            // 
            this.StrengthsAndWeaknessesRichTextBox.Location = new System.Drawing.Point(12, 297);
            this.StrengthsAndWeaknessesRichTextBox.Name = "StrengthsAndWeaknessesRichTextBox";
            this.StrengthsAndWeaknessesRichTextBox.Size = new System.Drawing.Size(1031, 319);
            this.StrengthsAndWeaknessesRichTextBox.TabIndex = 11;
            this.StrengthsAndWeaknessesRichTextBox.Text = "";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(490, 224);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(101, 36);
            this.ResetButton.TabIndex = 12;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // TypeCalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1055, 628);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StrengthsAndWeaknessesRichTextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.lblSecondaryType);
            this.Controls.Add(this.lblPrimaryType);
            this.Controls.Add(this.SecondaryTypesComboBox);
            this.Controls.Add(this.PrimaryTypesComboBox);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TypeCalculatorUI";
            this.Text = "Pokemon Type Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSecondaryType;
        private Label lblPrimaryType;
        private ComboBox SecondaryTypesComboBox;
        private ComboBox PrimaryTypesComboBox;
        private Button CalculateButton;
        private RichTextBox StrengthsAndWeaknessesRichTextBox;
        private Button ResetButton;
    }
}