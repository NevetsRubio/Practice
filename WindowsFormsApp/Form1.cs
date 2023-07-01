using Newtonsoft.Json;
using System.ComponentModel;
using System.Windows.Forms;
using WindowsFormsApp.Models;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private readonly BindingList<Book> _data;
        private string FILTER = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
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
                MessageBox.Show("Book is a required field.");
                return;
            }

            Book book = new Book(author, title);

            _data.Add(book);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string booksJson = JsonConvert.SerializeObject(dgvRecords.DataSource);
            using (SaveFileDialog saveFiledialog = new SaveFileDialog())
            {
                saveFiledialog.Filter = FILTER;
                saveFiledialog.RestoreDirectory = true;

                if (saveFiledialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFiledialog.FileName, booksJson);
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
                    Stream fileStream = openFileDialog.OpenFile();

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            _data.Clear();
        }
    }
}