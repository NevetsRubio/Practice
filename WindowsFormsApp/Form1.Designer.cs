namespace WindowsFormsApp
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
            label1 = new Label();
            txtAuthor = new TextBox();
            label2 = new Label();
            txtTitle = new TextBox();
            btnAddBook = new Button();
            btnExport = new Button();
            btnImport = new Button();
            dgvRecords = new DataGridView();
            Author = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(129, 48);
            label1.TabIndex = 0;
            label1.Text = "Author";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(147, 12);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(300, 55);
            txtAuthor.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 99);
            label2.Name = "label2";
            label2.Size = new Size(88, 48);
            label2.TabIndex = 2;
            label2.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(147, 96);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(300, 55);
            txtTitle.TabIndex = 3;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(12, 181);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(435, 69);
            btnAddBook.TabIndex = 4;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(12, 256);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(435, 69);
            btnExport.TabIndex = 5;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(12, 331);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(435, 69);
            btnImport.TabIndex = 6;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // dgvRecords
            // 
            dgvRecords.AllowUserToAddRows = false;
            dgvRecords.AllowUserToDeleteRows = false;
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecords.Columns.AddRange(new DataGridViewColumn[] { Author, Title });
            dgvRecords.Location = new Point(469, 12);
            dgvRecords.Name = "dgvRecords";
            dgvRecords.ReadOnly = true;
            dgvRecords.RowHeadersWidth = 123;
            dgvRecords.RowTemplate.Height = 57;
            dgvRecords.Size = new Size(720, 463);
            dgvRecords.TabIndex = 7;
            // 
            // Author
            // 
            Author.DataPropertyName = "Author";
            Author.HeaderText = "Author";
            Author.MinimumWidth = 15;
            Author.Name = "Author";
            Author.ReadOnly = true;
            Author.Width = 300;
            // 
            // Title
            // 
            Title.DataPropertyName = "Title";
            Title.HeaderText = "Title";
            Title.MinimumWidth = 15;
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.Width = 300;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 406);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(435, 69);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 489);
            Controls.Add(btnClear);
            Controls.Add(dgvRecords);
            Controls.Add(btnImport);
            Controls.Add(btnExport);
            Controls.Add(btnAddBook);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(txtAuthor);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAuthor;
        private Label label2;
        private TextBox txtTitle;
        private Button btnAddBook;
        private Button btnExport;
        private Button btnImport;
        private DataGridView dgvRecords;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Title;
        private Button btnClear;
    }
}