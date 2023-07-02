using Newtonsoft.Json;
using System.ComponentModel;
using WindowsFormsApp.Models;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private readonly BindingList<Book> _data;
        private readonly string FILTER = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
        public Form1()
        {
            InitializeComponent();

            _data = new BindingList<Book>();

            dgvRecords.DataSource = _data;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string author = txtAuthor.Text;
            string title = txtTitle.Text;
            if (string.IsNullOrEmpty(author))
            {
                MessageBox.Show("Author is a required field.");
                return;
            }

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Title is a required field.");
                return;
            }

            Book book = new Book(author, title);

            _data.Add(book);

            txtAuthor.Text = string.Empty;
            txtTitle.Text = string.Empty;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string booksJson = JsonConvert.SerializeObject(dgvRecords.DataSource);
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = FILTER;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, booksJson);
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = FILTER;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (Stream fileStream = openFileDialog.OpenFile())
                    {
                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            string bookJson = reader.ReadToEnd();
                            if (string.IsNullOrEmpty(bookJson))
                            {
                                MessageBox.Show("The Selected file was empty.");
                                return;
                            }

                            List<Book>? books = JsonConvert.DeserializeObject<List<Book>>(bookJson);

                            if (books != null)
                            {
                                _data.Clear();
                                foreach (Book book in books)
                                {
                                    _data.Add(book);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _data.Clear();
        }
    }
}