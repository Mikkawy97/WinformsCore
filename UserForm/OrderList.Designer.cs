namespace UserForm
{
    partial class OrderList
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
            OrderGridView = new DataGridView();
            Back_Btn = new Button();
            SaveBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)OrderGridView).BeginInit();
            SuspendLayout();
            // 
            // OrderGridView
            // 
            OrderGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderGridView.Location = new Point(12, 12);
            OrderGridView.Name = "OrderGridView";
            OrderGridView.RowHeadersWidth = 51;
            OrderGridView.RowTemplate.Height = 29;
            OrderGridView.Size = new Size(754, 304);
            OrderGridView.TabIndex = 0;
            // 
            // Back_Btn
            // 
            Back_Btn.Location = new Point(204, 392);
            Back_Btn.Name = "Back_Btn";
            Back_Btn.Size = new Size(94, 29);
            Back_Btn.TabIndex = 1;
            Back_Btn.Text = "Back";
            Back_Btn.UseVisualStyleBackColor = true;
            Back_Btn.Click += Back_Btn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(450, 393);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(94, 29);
            SaveBtn.TabIndex = 2;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // OrderList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SaveBtn);
            Controls.Add(Back_Btn);
            Controls.Add(OrderGridView);
            Name = "OrderList";
            Text = "OrderListcs";
            Load += OrderList_Load;
            ((System.ComponentModel.ISupportInitialize)OrderGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView OrderGridView;
        private Button Back_Btn;
        private Button SaveBtn;
    }
}