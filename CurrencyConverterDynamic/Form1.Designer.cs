namespace CurrencyConverterDynamic
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.inputBoxLabel = new System.Windows.Forms.Label();
            this.usdRadioButton = new System.Windows.Forms.RadioButton();
            this.eurRadioButton = new System.Windows.Forms.RadioButton();
            this.jpyRadioButton = new System.Windows.Forms.RadioButton();
            this.convertButton = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(82, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Currency Converter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(129, 104);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(194, 23);
            this.inputBox.TabIndex = 1;
            this.inputBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // inputBoxLabel
            // 
            this.inputBoxLabel.AutoSize = true;
            this.inputBoxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputBoxLabel.Location = new System.Drawing.Point(79, 104);
            this.inputBoxLabel.Name = "inputBoxLabel";
            this.inputBoxLabel.Size = new System.Drawing.Size(37, 21);
            this.inputBoxLabel.TabIndex = 2;
            this.inputBoxLabel.Text = "IDR";
            // 
            // usdRadioButton
            // 
            this.usdRadioButton.AutoSize = true;
            this.usdRadioButton.Location = new System.Drawing.Point(114, 185);
            this.usdRadioButton.Name = "usdRadioButton";
            this.usdRadioButton.Size = new System.Drawing.Size(47, 19);
            this.usdRadioButton.TabIndex = 3;
            this.usdRadioButton.TabStop = true;
            this.usdRadioButton.Text = "USD";
            this.usdRadioButton.UseVisualStyleBackColor = true;
            // 
            // eurRadioButton
            // 
            this.eurRadioButton.AutoSize = true;
            this.eurRadioButton.Location = new System.Drawing.Point(207, 185);
            this.eurRadioButton.Name = "eurRadioButton";
            this.eurRadioButton.Size = new System.Drawing.Size(46, 19);
            this.eurRadioButton.TabIndex = 4;
            this.eurRadioButton.TabStop = true;
            this.eurRadioButton.Text = "EUR";
            this.eurRadioButton.UseVisualStyleBackColor = true;
            // 
            // jpyRadioButton
            // 
            this.jpyRadioButton.AutoSize = true;
            this.jpyRadioButton.Location = new System.Drawing.Point(297, 185);
            this.jpyRadioButton.Name = "jpyRadioButton";
            this.jpyRadioButton.Size = new System.Drawing.Size(43, 19);
            this.jpyRadioButton.TabIndex = 5;
            this.jpyRadioButton.TabStop = true;
            this.jpyRadioButton.Text = "JPY";
            this.jpyRadioButton.UseVisualStyleBackColor = true;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(158, 239);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(127, 32);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "CONVERT!";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(129, 298);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(194, 23);
            this.resultBox.TabIndex = 7;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(59, 298);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(65, 21);
            this.result.TabIndex = 8;
            this.result.Text = "Result :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 360);
            this.Controls.Add(this.result);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.jpyRadioButton);
            this.Controls.Add(this.eurRadioButton);
            this.Controls.Add(this.usdRadioButton);
            this.Controls.Add(this.inputBoxLabel);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label inputBoxLabel;
        private System.Windows.Forms.RadioButton usdRadioButton;
        private System.Windows.Forms.RadioButton eurRadioButton;
        private System.Windows.Forms.RadioButton jpyRadioButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label result;
    }
}

