namespace WindowsFormsApp1
{
    partial class Form1
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
            richTextBox = new RichTextBox();
            filePathLabel = new Label();
            chooseFileButton = new Button();
            analyzeButton = new Button();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // richTextBox
            // 
            richTextBox.Dock = DockStyle.Top;
            richTextBox.Location = new Point(0, 0);
            richTextBox.Margin = new Padding(4, 3, 4, 3);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(933, 115);
            richTextBox.TabIndex = 0;
            richTextBox.Text = "";
            // 
            // filePathLabel
            // 
            filePathLabel.AutoSize = true;
            filePathLabel.Dock = DockStyle.Top;
            filePathLabel.Location = new Point(0, 115);
            filePathLabel.Margin = new Padding(4, 0, 4, 0);
            filePathLabel.Name = "filePathLabel";
            filePathLabel.Size = new Size(97, 15);
            filePathLabel.TabIndex = 1;
            filePathLabel.Text = "Файл не выбран";
            // 
            // chooseFileButton
            // 
            chooseFileButton.Dock = DockStyle.Top;
            chooseFileButton.Location = new Point(0, 130);
            chooseFileButton.Margin = new Padding(4, 3, 4, 3);
            chooseFileButton.Name = "chooseFileButton";
            chooseFileButton.Size = new Size(933, 27);
            chooseFileButton.TabIndex = 2;
            chooseFileButton.Text = "Выбрать файл";
            chooseFileButton.UseVisualStyleBackColor = true;
            // 
            // analyzeButton
            // 
            analyzeButton.Dock = DockStyle.Top;
            analyzeButton.Location = new Point(0, 157);
            analyzeButton.Margin = new Padding(4, 3, 4, 3);
            analyzeButton.Name = "analyzeButton";
            analyzeButton.Size = new Size(933, 27);
            analyzeButton.TabIndex = 3;
            analyzeButton.Text = "Анализировать";
            analyzeButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 184);
            dataGridView.Margin = new Padding(4, 3, 4, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(933, 335);
            dataGridView.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(dataGridView);
            Controls.Add(analyzeButton);
            Controls.Add(chooseFileButton);
            Controls.Add(filePathLabel);
            Controls.Add(richTextBox);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}
