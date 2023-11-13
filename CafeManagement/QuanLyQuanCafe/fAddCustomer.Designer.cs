namespace QuanLyQuanCafe
{
    partial class fAddCustomer
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
            panel1 = new Panel();
            panel2 = new Panel();
            txbCustomerUsername = new TextBox();
            label1 = new Label();
            btnAddCustomer = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 76);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(txbCustomerUsername);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(394, 69);
            panel2.TabIndex = 0;
            // 
            // txbCustomerUsername
            // 
            txbCustomerUsername.Location = new Point(176, 24);
            txbCustomerUsername.MaxLength = 20;
            txbCustomerUsername.Name = "txbCustomerUsername";
            txbCustomerUsername.Size = new Size(215, 23);
            txbCustomerUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 24);
            label1.Name = "label1";
            label1.Size = new Size(167, 22);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng:";
            label1.Click += label1_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(337, 94);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(75, 23);
            btnAddCustomer.TabIndex = 1;
            btnAddCustomer.Text = "Thêm";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // fAddCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 124);
            Controls.Add(btnAddCustomer);
            Controls.Add(panel1);
            Name = "fAddCustomer";
            Text = "Thêm khách hàng";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txbCustomerUsername;
        private Label label1;
        private Button btnAddCustomer;
    }
}