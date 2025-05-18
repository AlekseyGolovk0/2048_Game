namespace _2048GameWinFormsApp
{
    partial class SizeForm
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
            nameLabel = new Label();
            first4x4Label = new RadioButton();
            fourth7x7Label = new RadioButton();
            third6x6Label = new RadioButton();
            secound5x5Label = new RadioButton();
            userPressButton = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameLabel.Location = new Point(55, 20);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(244, 30);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Выберите размер поля";
            // 
            // ferst4x4Label
            // 
            first4x4Label.AutoSize = true;
            first4x4Label.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            first4x4Label.Location = new Point(55, 107);
            first4x4Label.Name = "ferst4x4Label";
            first4x4Label.Size = new Size(62, 29);
            first4x4Label.TabIndex = 1;
            first4x4Label.TabStop = true;
            first4x4Label.Text = "4х4";
            first4x4Label.UseVisualStyleBackColor = true;
            // 
            // fourth7x7Label
            // 
            fourth7x7Label.AutoSize = true;
            fourth7x7Label.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            fourth7x7Label.Location = new Point(237, 185);
            fourth7x7Label.Name = "fourth7x7Label";
            fourth7x7Label.Size = new Size(60, 29);
            fourth7x7Label.TabIndex = 5;
            fourth7x7Label.TabStop = true;
            fourth7x7Label.Text = "7х7";
            fourth7x7Label.UseVisualStyleBackColor = true;
            // 
            // third6x6Label
            // 
            third6x6Label.AutoSize = true;
            third6x6Label.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            third6x6Label.Location = new Point(55, 185);
            third6x6Label.Name = "third6x6Label";
            third6x6Label.Size = new Size(60, 29);
            third6x6Label.TabIndex = 6;
            third6x6Label.TabStop = true;
            third6x6Label.Text = "6х6";
            third6x6Label.UseVisualStyleBackColor = true;
            // 
            // secound5x5Label
            // 
            secound5x5Label.AutoSize = true;
            secound5x5Label.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            secound5x5Label.Location = new Point(237, 107);
            secound5x5Label.Name = "secound5x5Label";
            secound5x5Label.Size = new Size(58, 29);
            secound5x5Label.TabIndex = 7;
            secound5x5Label.TabStop = true;
            secound5x5Label.Text = "5х5";
            secound5x5Label.UseVisualStyleBackColor = true;
            // 
            // userPressButton
            // 
            userPressButton.Location = new Point(120, 242);
            userPressButton.Name = "userPressButton";
            userPressButton.Size = new Size(131, 62);
            userPressButton.TabIndex = 8;
            userPressButton.Text = "Выбрать";
            userPressButton.UseVisualStyleBackColor = true;
            userPressButton.Click += button1_Click;
            // 
            // SizeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 345);
            Controls.Add(userPressButton);
            Controls.Add(secound5x5Label);
            Controls.Add(third6x6Label);
            Controls.Add(fourth7x7Label);
            Controls.Add(first4x4Label);
            Controls.Add(nameLabel);
            Name = "SizeForm";
            Text = "StartForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private RadioButton first4x4Label;
        private RadioButton fourth7x7Label;
        private RadioButton third6x6Label;
        private RadioButton secound5x5Label;
        private Button userPressButton;
    }
}