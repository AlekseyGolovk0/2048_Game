namespace _2048GameWinFormsApp
{
    partial class ResultForm
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
            resultdataGridView = new DataGridView();
            UserName = new DataGridViewTextBoxColumn();
            UserResult = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)resultdataGridView).BeginInit();
            SuspendLayout();
            // 
            // resultdataGridView
            // 
            resultdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultdataGridView.Columns.AddRange(new DataGridViewColumn[] { UserName, UserResult });
            resultdataGridView.Location = new Point(12, 12);
            resultdataGridView.Name = "resultdataGridView";
            resultdataGridView.Size = new Size(244, 309);
            resultdataGridView.TabIndex = 0;
            // 
            // UserName
            // 
            UserName.HeaderText = "Имя";
            UserName.Name = "UserName";
            // 
            // UserResult
            // 
            UserResult.HeaderText = "Кол-во очков";
            UserResult.Name = "UserResult";
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 324);
            Controls.Add(resultdataGridView);
            Name = "ResultForm";
            Text = "ResultForm";
            Load += ResultForm_Load;
            ((System.ComponentModel.ISupportInitialize)resultdataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView resultdataGridView;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn UserResult;
    }
}