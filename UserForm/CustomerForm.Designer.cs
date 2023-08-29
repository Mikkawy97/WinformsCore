namespace UserForm
{
    partial class CustomerForm
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
            ProductsgridView = new DataGridView();
            search_txt = new TextBox();
            searchBtn = new Button();
            plOrderBtn = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductsgridView).BeginInit();
            SuspendLayout();
            // 
            // ProductsgridView
            // 
            ProductsgridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsgridView.Location = new Point(12, 65);
            ProductsgridView.Name = "ProductsgridView";
            ProductsgridView.RowHeadersWidth = 51;
            ProductsgridView.RowTemplate.Height = 29;
            ProductsgridView.Size = new Size(744, 299);
            ProductsgridView.TabIndex = 0;
            // 
            // search_txt
            // 
            search_txt.Location = new Point(30, 19);
            search_txt.Name = "search_txt";
            search_txt.Size = new Size(201, 27);
            search_txt.TabIndex = 1;
            search_txt.TextChanged += textBox1_TextChanged;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(269, 17);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(94, 29);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // plOrderBtn
            // 
            plOrderBtn.Location = new Point(114, 400);
            plOrderBtn.Name = "plOrderBtn";
            plOrderBtn.Size = new Size(94, 29);
            plOrderBtn.TabIndex = 3;
            plOrderBtn.Text = "place order";
            plOrderBtn.UseVisualStyleBackColor = true;
            plOrderBtn.Click += plOrderBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(365, 400);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Orders List";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(plOrderBtn);
            Controls.Add(searchBtn);
            Controls.Add(search_txt);
            Controls.Add(ProductsgridView);
            Name = "CustomerForm";
            Text = "CustomerForm";
            Load += CustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)ProductsgridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ProductsgridView;
        private TextBox search_txt;
        private Button searchBtn;
        private Button plOrderBtn;
        private Button button1;
    }
}