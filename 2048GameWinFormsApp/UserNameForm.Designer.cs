namespace _2048GameWinFormsApp
{
    partial class UserNameForm
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
            userNameTextBox = new TextBox();
            welcomeLabel = new Label();
            closeButton = new Button();
            SuspendLayout();
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(69, 91);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(224, 23);
            userNameTextBox.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new Point(142, 48);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(80, 15);
            welcomeLabel.TabIndex = 1;
            welcomeLabel.Text = "Введите Имя!";
            // 
            // closeButton
            // 
            closeButton.Location = new Point(142, 149);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 2;
            closeButton.Text = "Далее";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += UserNameAnswer_Click;
            // 
            // UserNameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 204);
            Controls.Add(closeButton);
            Controls.Add(welcomeLabel);
            Controls.Add(userNameTextBox);
            Name = "UserNameForm";
            Text = "UserNameForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userNameTextBox;
        private Label welcomeLabel;
        private Button closeButton;
    }
}