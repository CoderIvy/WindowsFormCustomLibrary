using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BookInfo
{
    public partial class BookInfoLib: UserControl
    {
     
        int curSelectedRow = 0;
        bool lowToHigh = true;  //for sort book by price
        private BookInfoControl theControl;
        List<Book> bookList = new List<Book>();

        public BookInfoLib()
        {
            InitializeComponent();
            Init();
        }

        public void Init() {
            theControl = new BookInfoControl(this);

            pnlDetail.Visible = false;  //set detail page invisiable
            pnlDetail.Left = 60;    //set detail page's position
            pnlDetail.Top = 20;   
            this.Width = 750;   //set component's size
            this.Height = 450;

            bookList = GetBookList();
            BindBookData(bookList);
            int newID = bookList.Count() + 1;
            txtBookID.Text = newID + "";
            setCategory();
        }

        /// <summary>
        /// set book list for datagridview
        /// </summary>
        /// <param name="l"></param>
        private void BindBookData(List<Book> l)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("NAME", typeof(string));
            table.Columns.Add("PRICE", typeof(float));

            foreach (Book b in l)
            {
                table.Rows.Add(b.getID(), b.getName(), b.getPrice());
            }
            dgvBookList.DataSource = table;

        }

        /// <summary>
        /// click search button to search certain books
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
         //   MessageBox.Show("search clicked");
            string keyWord = txtSearch.Text.Trim();
            if (keyWord.Equals(""))
            {
                MessageBox.Show("Search key workd cannot be empty!");
                return;
            }

            List<Book> searchList = GetSearchResult(keyWord);
            BindBookData(searchList);
            txtSearch.Text = "";
        }

        /// <summary>
        /// click button show book's detail info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDetail_Click(object sender, EventArgs e)
        {
         //   MessageBox.Show("detail clicked");
            Book curBook = bookList[curSelectedRow];

            txtDetailID.Text = curBook.getID().ToString().Trim();
            txtDetailCategory.Text = curBook.getCategory().ToString().Trim();
            txtDetailAuthor.Text = curBook.getAuthor().ToString().Trim();
            txtDetailName.Text = curBook.getName().ToString().Trim();
            txtDetailPrice.Text = curBook.getPrice().ToString().Trim();

            pnlDetail.Visible = true;
            btnDelete.Enabled = false;
            btnSearch.Enabled = false;
            btnDetail.Enabled = false;
            btnDetailOK.Enabled = true;

        }

        /// <summary>
        /// refresh page after search books
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("refresh clicked");
            BindBookData(bookList);
        }

        /// <summary>
        /// click delete button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
         //   MessageBox.Show("delete clicked");
            bookList.Remove(bookList[curSelectedRow]);
            BindBookData(bookList);
            MessageBox.Show("Book item deleted successfully.", "Msg");
            
        }

        /// <summary>
        /// click sort button to sort book by price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSort_Click(object sender, EventArgs e)
        {
        //    MessageBox.Show("sort clicked");
            List<Book> lowList = new List<Book>();
            foreach (Book b in bookList)
            {
                lowList.Add(b);
            }

            for (int i = 0; i < lowList.Count - 1; i++)
            {
                for (int j = 0; j < lowList.Count - 1 - i; j++)
                {
                    if (lowList[j].getPrice() > lowList[j + 1].getPrice())
                    {
                        Book temp = lowList[j];
                        lowList[j] = lowList[j + 1];
                        lowList[j + 1] = temp;
                    }

                }
            }
            if (lowToHigh)
            {
                BindBookData(lowList);
                lowToHigh = false;
            }
            else
            {
                List<Book> highList = new List<Book>();
                int k = 0;
                for (int i = lowList.Count - 1; i >= 0; i--)
                {
                    highList.Add(lowList[i]);
                    k++;
                }
                BindBookData(highList);
                lowToHigh = true;
            }


        }

        /// <summary>
        /// get current select row index
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            curSelectedRow = dgvBookList.CurrentCell.RowIndex;   //current select row number,start from 0; 

        }

        /// <summary>
        /// exit book detail page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDetailOK_Click(object sender, EventArgs e)
        {
        //    MessageBox.Show("btnDetailOK_Click clicked");
            pnlDetail.Visible = false;
            btnSearch.Enabled = true;
            btnDelete.Enabled = true;
            btnDetail.Enabled = true;
        }

        /// <summary>
        /// load author from local file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadAuthor_Click(object sender, EventArgs e)
        {
        //    MessageBox.Show("load author clicked");
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                List<Author> authorList = new List<Author>();

                while (!sr.EndOfStream)
                {
                    string[] str = (sr.ReadLine()).Split(',');
                    authorList.Add(new Author(Int32.Parse(str[0]), str[1]));

                }

                for (int i = 0; i < authorList.Count(); i++)
                {
                    cboAuthor.Items.Insert(i, authorList[i].getAuthorName());

                }
                //  cboAuthor.SelectedIndex = 0;

                sr.Close();
            }
        }

        /// <summary>
        /// click addbook button to add book
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBook_Click(object sender, EventArgs e)
        {
         //   MessageBox.Show("add book clicked");           
            int id = Int32.Parse(txtBookID.Text);
            string category = cboCategory.Text;
            string author = cboAuthor.Text;
            string name = txtBookName.Text;
            float price = float.Parse(txtPrice.Text);

            bookList.Add(new Book(id, category, author, name, price));

            BindBookData(bookList);
            tabControl.SelectedIndex = 0;
        }

        /// <summary>
        /// click cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("cancel clicked");
            tabControl.SelectedIndex = 0;
        }

        /// <summary>
        /// get all book info form local txt file
        /// </summary>
        private List<Book> GetBookList()
        {
            string soucePath = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "BookList.txt");
            string[] lines = System.IO.File.ReadAllLines(soucePath);
            foreach (string line in lines)
            {
                string[] bookStr = line.Split(',');
                int id = Int32.Parse(bookStr[0]);
                string category = bookStr[1];
                string author = bookStr[2];
                string name = bookStr[3];
                float price = float.Parse(bookStr[4]);

                //  Book aBook = new Book(id, category, author, name, price);
                bookList.Add(new Book(id, category, author, name, price));
            }
            return bookList;
        }


        /// <summary>
        /// use book name to search book
        /// </summary>
        /// <param name="keyWord"></param>
        /// <returns> book list </returns>
        private List<Book> GetSearchResult(string keyWord)
        {
            List<Book> searchBookList = new List<Book>();
            foreach (Book b in bookList)
            {

                if (b.getName().ToString().Contains(keyWord))
                {
                    searchBookList.Add(b);
                }
            }
            return searchBookList;
        }


        /// <summary>
        /// set add book page's category
        /// </summary>
        public void setCategory()
        {
            List<Category> categories = new List<Category>();
            //  string[] lines = System.IO.File.ReadAllLines(@"C:\Temp\CategoryList.txt");

            string soucePath = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "CategoryList.txt");
            string[] lines = System.IO.File.ReadAllLines(soucePath);

            foreach (string line in lines)
            {
                string[] categoryStr = line.Split(',');
                int id = Int32.Parse(categoryStr[0]);
                string categoryName = categoryStr[1];

                categories.Add(new Category(id, categoryName));
            }

            for (int i = 0; i < categories.Count; i++)
            {
                cboCategory.Items.Insert(i, categories[i].getCategoryName());
            }

        }










    }
}
