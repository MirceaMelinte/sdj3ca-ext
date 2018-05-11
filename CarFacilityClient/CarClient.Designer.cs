namespace CarFacilityClient
{
    partial class CarClient
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
            this.chassisNoLabel = new System.Windows.Forms.Label();
            this.chassisNoTextField = new System.Windows.Forms.TextBox();
            this.GetStolenPartsButton = new System.Windows.Forms.Button();
            this.GetStolenProductsButton = new System.Windows.Forms.Button();
            this.GetCarDetailsButton = new System.Windows.Forms.Button();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // chassisNoLabel
            // 
            this.chassisNoLabel.Location = new System.Drawing.Point(71, 57);
            this.chassisNoLabel.Name = "chassisNoLabel";
            this.chassisNoLabel.Size = new System.Drawing.Size(101, 14);
            this.chassisNoLabel.TabIndex = 0;
            this.chassisNoLabel.Text = "Chassis number:";
            // 
            // chassisNoTextField
            // 
            this.chassisNoTextField.Location = new System.Drawing.Point(74, 83);
            this.chassisNoTextField.Name = "chassisNoTextField";
            this.chassisNoTextField.Size = new System.Drawing.Size(147, 20);
            this.chassisNoTextField.TabIndex = 1;
            // 
            // GetStolenPartsButton
            // 
            this.GetStolenPartsButton.Location = new System.Drawing.Point(259, 81);
            this.GetStolenPartsButton.Name = "GetStolenPartsButton";
            this.GetStolenPartsButton.Size = new System.Drawing.Size(130, 23);
            this.GetStolenPartsButton.TabIndex = 2;
            this.GetStolenPartsButton.Text = "Get Stolen Parts";
            this.GetStolenPartsButton.UseVisualStyleBackColor = true;
            this.GetStolenPartsButton.Click += new System.EventHandler(this.GetStolenPartsButton_Click);
            // 
            // GetStolenProductsButton
            // 
            this.GetStolenProductsButton.Location = new System.Drawing.Point(438, 80);
            this.GetStolenProductsButton.Name = "GetStolenProductsButton";
            this.GetStolenProductsButton.Size = new System.Drawing.Size(129, 23);
            this.GetStolenProductsButton.TabIndex = 3;
            this.GetStolenProductsButton.Text = "Get Stolen Products";
            this.GetStolenProductsButton.UseVisualStyleBackColor = true;
            this.GetStolenProductsButton.Click += new System.EventHandler(this.GetStolenProductsButton_Click);
            // 
            // GetCarDetailsButton
            // 
            this.GetCarDetailsButton.Location = new System.Drawing.Point(612, 81);
            this.GetCarDetailsButton.Name = "GetCarDetailsButton";
            this.GetCarDetailsButton.Size = new System.Drawing.Size(129, 23);
            this.GetCarDetailsButton.TabIndex = 4;
            this.GetCarDetailsButton.Text = "Get Car Details";
            this.GetCarDetailsButton.UseVisualStyleBackColor = true;
            this.GetCarDetailsButton.Click += new System.EventHandler(this.GetCarDetailsButton_Click);
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Location = new System.Drawing.Point(74, 147);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(667, 251);
            this.outputListBox.TabIndex = 5;
            // 
            // CarClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.GetCarDetailsButton);
            this.Controls.Add(this.GetStolenProductsButton);
            this.Controls.Add(this.GetStolenPartsButton);
            this.Controls.Add(this.chassisNoTextField);
            this.Controls.Add(this.chassisNoLabel);
            this.Name = "CarClient";
            this.Text = "Car theft tracking client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chassisNoLabel;
        private System.Windows.Forms.TextBox chassisNoTextField;
        private System.Windows.Forms.Button GetStolenPartsButton;
        private System.Windows.Forms.Button GetStolenProductsButton;
        private System.Windows.Forms.Button GetCarDetailsButton;
        private System.Windows.Forms.ListBox outputListBox;
    }
}

