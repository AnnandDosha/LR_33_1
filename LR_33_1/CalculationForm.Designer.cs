namespace LR_33_1
{
    partial class CalculationForm
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
            this.number1TextBox = new System.Windows.Forms.TextBox();
            this.number2TextBox = new System.Windows.Forms.TextBox();
            this.Calculation = new System.Windows.Forms.Button();
            this.number1Label = new System.Windows.Forms.Label();
            this.number2Label = new System.Windows.Forms.Label();
            this.plusRadioButton = new System.Windows.Forms.RadioButton();
            this.minusRadioButton = new System.Windows.Forms.RadioButton();
            this.mulRadioButton = new System.Windows.Forms.RadioButton();
            this.divisionRadioButton = new System.Windows.Forms.RadioButton();
            this.conclusionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // number1TextBox
            // 
            this.number1TextBox.Location = new System.Drawing.Point(162, 36);
            this.number1TextBox.Name = "number1TextBox";
            this.number1TextBox.Size = new System.Drawing.Size(100, 20);
            this.number1TextBox.TabIndex = 0;
            // 
            // number2TextBox
            // 
            this.number2TextBox.Location = new System.Drawing.Point(162, 92);
            this.number2TextBox.Name = "number2TextBox";
            this.number2TextBox.Size = new System.Drawing.Size(100, 20);
            this.number2TextBox.TabIndex = 1;
            // 
            // Calculation
            // 
            this.Calculation.Location = new System.Drawing.Point(30, 140);
            this.Calculation.Name = "Calculation";
            this.Calculation.Size = new System.Drawing.Size(75, 23);
            this.Calculation.TabIndex = 2;
            this.Calculation.Text = "Вычислить";
            this.Calculation.UseVisualStyleBackColor = true;
            this.Calculation.Click += new System.EventHandler(this.button1_Click);
            // 
            // number1Label
            // 
            this.number1Label.AutoSize = true;
            this.number1Label.Location = new System.Drawing.Point(27, 39);
            this.number1Label.Name = "number1Label";
            this.number1Label.Size = new System.Drawing.Size(81, 13);
            this.number1Label.TabIndex = 3;
            this.number1Label.Text = "Введите число";
            // 
            // number2Label
            // 
            this.number2Label.AutoSize = true;
            this.number2Label.Location = new System.Drawing.Point(27, 99);
            this.number2Label.Name = "number2Label";
            this.number2Label.Size = new System.Drawing.Size(81, 13);
            this.number2Label.TabIndex = 4;
            this.number2Label.Text = "Введите число";
            // 
            // plusRadioButton
            // 
            this.plusRadioButton.AutoSize = true;
            this.plusRadioButton.Checked = true;
            this.plusRadioButton.Location = new System.Drawing.Point(308, 35);
            this.plusRadioButton.Name = "plusRadioButton";
            this.plusRadioButton.Size = new System.Drawing.Size(31, 17);
            this.plusRadioButton.TabIndex = 5;
            this.plusRadioButton.TabStop = true;
            this.plusRadioButton.Text = "+";
            this.plusRadioButton.UseVisualStyleBackColor = true;
            // 
            // minusRadioButton
            // 
            this.minusRadioButton.AutoSize = true;
            this.minusRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusRadioButton.Location = new System.Drawing.Point(308, 58);
            this.minusRadioButton.Name = "minusRadioButton";
            this.minusRadioButton.Size = new System.Drawing.Size(31, 22);
            this.minusRadioButton.TabIndex = 6;
            this.minusRadioButton.Text = "-";
            this.minusRadioButton.UseVisualStyleBackColor = true;
            // 
            // mulRadioButton
            // 
            this.mulRadioButton.AutoSize = true;
            this.mulRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mulRadioButton.Location = new System.Drawing.Point(308, 81);
            this.mulRadioButton.Name = "mulRadioButton";
            this.mulRadioButton.Size = new System.Drawing.Size(32, 22);
            this.mulRadioButton.TabIndex = 7;
            this.mulRadioButton.Text = "*";
            this.mulRadioButton.UseVisualStyleBackColor = true;
            // 
            // divisionRadioButton
            // 
            this.divisionRadioButton.AutoSize = true;
            this.divisionRadioButton.Location = new System.Drawing.Point(308, 104);
            this.divisionRadioButton.Name = "divisionRadioButton";
            this.divisionRadioButton.Size = new System.Drawing.Size(30, 17);
            this.divisionRadioButton.TabIndex = 8;
            this.divisionRadioButton.Text = "/";
            this.divisionRadioButton.UseVisualStyleBackColor = true;
            // 
            // conclusionLabel
            // 
            this.conclusionLabel.AutoSize = true;
            this.conclusionLabel.Location = new System.Drawing.Point(159, 150);
            this.conclusionLabel.Name = "conclusionLabel";
            this.conclusionLabel.Size = new System.Drawing.Size(40, 13);
            this.conclusionLabel.TabIndex = 9;
            this.conclusionLabel.Text = "Ответ:";
            // 
            // CalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.conclusionLabel);
            this.Controls.Add(this.divisionRadioButton);
            this.Controls.Add(this.mulRadioButton);
            this.Controls.Add(this.minusRadioButton);
            this.Controls.Add(this.plusRadioButton);
            this.Controls.Add(this.number2Label);
            this.Controls.Add(this.number1Label);
            this.Controls.Add(this.Calculation);
            this.Controls.Add(this.number2TextBox);
            this.Controls.Add(this.number1TextBox);
            this.Name = "CalculationForm";
            this.Text = "CalculationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number1TextBox;
        private System.Windows.Forms.TextBox number2TextBox;
        private System.Windows.Forms.Button Calculation;
        private System.Windows.Forms.Label number1Label;
        private System.Windows.Forms.Label number2Label;
        private System.Windows.Forms.RadioButton plusRadioButton;
        private System.Windows.Forms.RadioButton minusRadioButton;
        private System.Windows.Forms.RadioButton mulRadioButton;
        private System.Windows.Forms.RadioButton divisionRadioButton;
        private System.Windows.Forms.Label conclusionLabel;
    }
}