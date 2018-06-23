namespace BookInfo
{
    partial class BookInfoLib
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabBookList = new System.Windows.Forms.TabPage();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.tabAddBook = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnLoadAuthor = new System.Windows.Forms.Button();
            this.cboAuthor = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDetailCategory = new System.Windows.Forms.TextBox();
            this.txtDetailAuthor = new System.Windows.Forms.TextBox();
            this.btnDetailOK = new System.Windows.Forms.Button();
            this.txtDetailPrice = new System.Windows.Forms.TextBox();
            this.txtDetailName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDetailID = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl.SuspendLayout();
            this.tabBookList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.tabAddBook.SuspendLayout();
            this.pnlDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabBookList);
            this.tabControl.Controls.Add(this.tabAddBook);
            this.tabControl.Location = new System.Drawing.Point(12, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(758, 442);
            this.tabControl.TabIndex = 4;
            // 
            // tabBookList
            // 
            this.tabBookList.Controls.Add(this.btnSort);
            this.tabBookList.Controls.Add(this.btnRefresh);
            this.tabBookList.Controls.Add(this.btnDetail);
            this.tabBookList.Controls.Add(this.lblTest);
            this.tabBookList.Controls.Add(this.label12);
            this.tabBookList.Controls.Add(this.btnDelete);
            this.tabBookList.Controls.Add(this.btnSearch);
            this.tabBookList.Controls.Add(this.txtSearch);
            this.tabBookList.Controls.Add(this.dgvBookList);
            this.tabBookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBookList.Location = new System.Drawing.Point(4, 22);
            this.tabBookList.Name = "tabBookList";
            this.tabBookList.Padding = new System.Windows.Forms.Padding(3);
            this.tabBookList.Size = new System.Drawing.Size(750, 416);
            this.tabBookList.TabIndex = 0;
            this.tabBookList.Text = "BookListForm";
            this.tabBookList.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(624, 300);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(85, 23);
            this.btnSort.TabIndex = 33;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(624, 166);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 23);
            this.btnRefresh.TabIndex = 32;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.Location = new System.Drawing.Point(624, 99);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(85, 23);
            this.btnDetail.TabIndex = 31;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.Location = new System.Drawing.Point(137, 3);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 16);
            this.lblTest.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "      ";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(624, 233);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(624, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(27, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(560, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // dgvBookList
            // 
            this.dgvBookList.AllowUserToAddRows = false;
            this.dgvBookList.AllowUserToDeleteRows = false;
            this.dgvBookList.AllowUserToResizeRows = false;
            this.dgvBookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Location = new System.Drawing.Point(27, 94);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.ReadOnly = true;
            this.dgvBookList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookList.Size = new System.Drawing.Size(560, 294);
            this.dgvBookList.TabIndex = 0;
            this.dgvBookList.SelectionChanged += new System.EventHandler(this.dgvBookList_SelectionChanged);
            // 
            // tabAddBook
            // 
            this.tabAddBook.Controls.Add(this.btnCancel);
            this.tabAddBook.Controls.Add(this.btnAddBook);
            this.tabAddBook.Controls.Add(this.btnLoadAuthor);
            this.tabAddBook.Controls.Add(this.cboAuthor);
            this.tabAddBook.Controls.Add(this.cboCategory);
            this.tabAddBook.Controls.Add(this.txtPrice);
            this.tabAddBook.Controls.Add(this.txtBookName);
            this.tabAddBook.Controls.Add(this.label5);
            this.tabAddBook.Controls.Add(this.label4);
            this.tabAddBook.Controls.Add(this.label3);
            this.tabAddBook.Controls.Add(this.label2);
            this.tabAddBook.Controls.Add(this.label1);
            this.tabAddBook.Controls.Add(this.txtBookID);
            this.tabAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAddBook.Location = new System.Drawing.Point(4, 22);
            this.tabAddBook.Name = "tabAddBook";
            this.tabAddBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddBook.Size = new System.Drawing.Size(750, 416);
            this.tabAddBook.TabIndex = 1;
            this.tabAddBook.Text = "AddBookForm";
            this.tabAddBook.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(410, 341);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Location = new System.Drawing.Point(159, 341);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(98, 23);
            this.btnAddBook.TabIndex = 11;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnLoadAuthor
            // 
            this.btnLoadAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadAuthor.Location = new System.Drawing.Point(379, 145);
            this.btnLoadAuthor.Name = "btnLoadAuthor";
            this.btnLoadAuthor.Size = new System.Drawing.Size(98, 23);
            this.btnLoadAuthor.TabIndex = 10;
            this.btnLoadAuthor.Text = "Load Author";
            this.btnLoadAuthor.UseVisualStyleBackColor = true;
            this.btnLoadAuthor.Click += new System.EventHandler(this.btnLoadAuthor_Click);
            // 
            // cboAuthor
            // 
            this.cboAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAuthor.FormattingEnabled = true;
            this.cboAuthor.Location = new System.Drawing.Point(164, 144);
            this.cboAuthor.Name = "cboAuthor";
            this.cboAuthor.Size = new System.Drawing.Size(173, 23);
            this.cboAuthor.TabIndex = 9;
            this.cboAuthor.Text = " -------Select Author--------";
            // 
            // cboCategory
            // 
            this.cboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(164, 90);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(218, 23);
            this.cboCategory.TabIndex = 8;
            this.cboCategory.Text = " ---------Select Category-----------";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(164, 255);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(108, 21);
            this.txtPrice.TabIndex = 7;
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.Location = new System.Drawing.Point(164, 198);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(289, 21);
            this.txtBookName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Book Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book ID:";
            // 
            // txtBookID
            // 
            this.txtBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID.Location = new System.Drawing.Point(164, 33);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.ReadOnly = true;
            this.txtBookID.Size = new System.Drawing.Size(101, 21);
            this.txtBookID.TabIndex = 0;
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.label11);
            this.pnlDetail.Controls.Add(this.txtDetailCategory);
            this.pnlDetail.Controls.Add(this.txtDetailAuthor);
            this.pnlDetail.Controls.Add(this.btnDetailOK);
            this.pnlDetail.Controls.Add(this.txtDetailPrice);
            this.pnlDetail.Controls.Add(this.txtDetailName);
            this.pnlDetail.Controls.Add(this.label6);
            this.pnlDetail.Controls.Add(this.label7);
            this.pnlDetail.Controls.Add(this.label8);
            this.pnlDetail.Controls.Add(this.label9);
            this.pnlDetail.Controls.Add(this.label10);
            this.pnlDetail.Controls.Add(this.txtDetailID);
            this.pnlDetail.Location = new System.Drawing.Point(804, 27);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(635, 403);
            this.pnlDetail.TabIndex = 5;
            this.pnlDetail.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(224, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 24);
            this.label11.TabIndex = 28;
            this.label11.Text = "Book Detail Page";
            // 
            // txtDetailCategory
            // 
            this.txtDetailCategory.Location = new System.Drawing.Point(244, 145);
            this.txtDetailCategory.Name = "txtDetailCategory";
            this.txtDetailCategory.ReadOnly = true;
            this.txtDetailCategory.Size = new System.Drawing.Size(251, 20);
            this.txtDetailCategory.TabIndex = 27;
            // 
            // txtDetailAuthor
            // 
            this.txtDetailAuthor.Location = new System.Drawing.Point(244, 200);
            this.txtDetailAuthor.Name = "txtDetailAuthor";
            this.txtDetailAuthor.ReadOnly = true;
            this.txtDetailAuthor.Size = new System.Drawing.Size(177, 20);
            this.txtDetailAuthor.TabIndex = 26;
            // 
            // btnDetailOK
            // 
            this.btnDetailOK.Enabled = false;
            this.btnDetailOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailOK.Location = new System.Drawing.Point(482, 352);
            this.btnDetailOK.Name = "btnDetailOK";
            this.btnDetailOK.Size = new System.Drawing.Size(98, 23);
            this.btnDetailOK.TabIndex = 25;
            this.btnDetailOK.Text = "OK";
            this.btnDetailOK.UseVisualStyleBackColor = true;
            this.btnDetailOK.Click += new System.EventHandler(this.btnDetailOK_Click);
            // 
            // txtDetailPrice
            // 
            this.txtDetailPrice.Location = new System.Drawing.Point(244, 310);
            this.txtDetailPrice.Name = "txtDetailPrice";
            this.txtDetailPrice.ReadOnly = true;
            this.txtDetailPrice.Size = new System.Drawing.Size(108, 20);
            this.txtDetailPrice.TabIndex = 20;
            // 
            // txtDetailName
            // 
            this.txtDetailName.Location = new System.Drawing.Point(244, 252);
            this.txtDetailName.Name = "txtDetailName";
            this.txtDetailName.ReadOnly = true;
            this.txtDetailName.Size = new System.Drawing.Size(289, 20);
            this.txtDetailName.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(170, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(163, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Author:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(111, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Book Category:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(129, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Book Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(153, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Book ID:";
            // 
            // txtDetailID
            // 
            this.txtDetailID.Location = new System.Drawing.Point(244, 84);
            this.txtDetailID.Name = "txtDetailID";
            this.txtDetailID.ReadOnly = true;
            this.txtDetailID.Size = new System.Drawing.Size(101, 20);
            this.txtDetailID.TabIndex = 13;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // BookInfoLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.tabControl);
            this.Name = "BookInfoLib";
            this.Size = new System.Drawing.Size(1114, 450);
            this.tabControl.ResumeLayout(false);
            this.tabBookList.ResumeLayout(false);
            this.tabBookList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.tabAddBook.ResumeLayout(false);
            this.tabAddBook.PerformLayout();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabBookList;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.TabPage tabAddBook;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnLoadAuthor;
        private System.Windows.Forms.ComboBox cboAuthor;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDetailCategory;
        private System.Windows.Forms.TextBox txtDetailAuthor;
        private System.Windows.Forms.Button btnDetailOK;
        private System.Windows.Forms.TextBox txtDetailPrice;
        private System.Windows.Forms.TextBox txtDetailName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDetailID;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
