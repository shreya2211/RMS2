namespace restaurant
{
    partial class adminHomeScreenWindow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rolesbtn = new System.Windows.Forms.Button();
            this.usersbtn = new System.Windows.Forms.Button();
            this.customersbtn = new System.Windows.Forms.Button();
            this.categoriesbtn = new System.Windows.Forms.Button();
            this.floorsbtn = new System.Windows.Forms.Button();
            this.ordersbtn = new System.Windows.Forms.Button();
            this.tablesbtn = new System.Windows.Forms.Button();
            this.billBtn = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.menubtn = new System.Windows.Forms.Button();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.leftpanel.Size = new System.Drawing.Size(250, 450);
            this.leftpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftpanel_Paint);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.tableLayoutPanel1);
            this.rightpanel.Size = new System.Drawing.Size(732, 450);
            this.rightpanel.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.rolesbtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.usersbtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.customersbtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.categoriesbtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.menubtn, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.floorsbtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ordersbtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tablesbtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.billBtn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button10, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button11, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(732, 405);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // rolesbtn
            // 
            this.rolesbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.rolesbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rolesbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolesbtn.FlatAppearance.BorderSize = 2;
            this.rolesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rolesbtn.Font = new System.Drawing.Font("Calibri", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolesbtn.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.rolesbtn.Location = new System.Drawing.Point(3, 3);
            this.rolesbtn.Name = "rolesbtn";
            this.rolesbtn.Size = new System.Drawing.Size(140, 129);
            this.rolesbtn.TabIndex = 0;
            this.rolesbtn.Text = "ROLES";
            this.rolesbtn.UseVisualStyleBackColor = false;
            this.rolesbtn.Click += new System.EventHandler(this.rolesbtn_Click);
            // 
            // usersbtn
            // 
            this.usersbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.usersbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersbtn.FlatAppearance.BorderSize = 2;
            this.usersbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersbtn.Font = new System.Drawing.Font("Calibri", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersbtn.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.usersbtn.Location = new System.Drawing.Point(149, 3);
            this.usersbtn.Name = "usersbtn";
            this.usersbtn.Size = new System.Drawing.Size(140, 129);
            this.usersbtn.TabIndex = 1;
            this.usersbtn.Text = "USERS";
            this.usersbtn.UseVisualStyleBackColor = false;
            this.usersbtn.Click += new System.EventHandler(this.usersbtn_Click);
            // 
            // customersbtn
            // 
            this.customersbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.customersbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customersbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersbtn.FlatAppearance.BorderSize = 2;
            this.customersbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customersbtn.Font = new System.Drawing.Font("Calibri", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersbtn.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.customersbtn.Location = new System.Drawing.Point(295, 3);
            this.customersbtn.Name = "customersbtn";
            this.customersbtn.Size = new System.Drawing.Size(140, 129);
            this.customersbtn.TabIndex = 2;
            this.customersbtn.Text = "CUSTOMERS";
            this.customersbtn.UseVisualStyleBackColor = false;
            this.customersbtn.Click += new System.EventHandler(this.customersbtn_Click);
            // 
            // categoriesbtn
            // 
            this.categoriesbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.categoriesbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoriesbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesbtn.FlatAppearance.BorderSize = 2;
            this.categoriesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriesbtn.Font = new System.Drawing.Font("Calibri", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesbtn.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.categoriesbtn.Location = new System.Drawing.Point(441, 3);
            this.categoriesbtn.Name = "categoriesbtn";
            this.categoriesbtn.Size = new System.Drawing.Size(140, 129);
            this.categoriesbtn.TabIndex = 3;
            this.categoriesbtn.Text = "FOOD CATEGORY";
            this.categoriesbtn.UseVisualStyleBackColor = false;
            this.categoriesbtn.Click += new System.EventHandler(this.categoriesbtn_Click);
            // 
            // floorsbtn
            // 
            this.floorsbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.floorsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.floorsbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.floorsbtn.FlatAppearance.BorderSize = 2;
            this.floorsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.floorsbtn.Font = new System.Drawing.Font("Calibri", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorsbtn.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.floorsbtn.Location = new System.Drawing.Point(3, 138);
            this.floorsbtn.Name = "floorsbtn";
            this.floorsbtn.Size = new System.Drawing.Size(140, 129);
            this.floorsbtn.TabIndex = 5;
            this.floorsbtn.Text = "FLOORS";
            this.floorsbtn.UseVisualStyleBackColor = false;
            this.floorsbtn.Click += new System.EventHandler(this.floorsbtn_Click);
            // 
            // ordersbtn
            // 
            this.ordersbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ordersbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ordersbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersbtn.FlatAppearance.BorderSize = 2;
            this.ordersbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersbtn.Font = new System.Drawing.Font("Calibri", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersbtn.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.ordersbtn.Location = new System.Drawing.Point(149, 138);
            this.ordersbtn.Name = "ordersbtn";
            this.ordersbtn.Size = new System.Drawing.Size(140, 129);
            this.ordersbtn.TabIndex = 6;
            this.ordersbtn.Text = "ORDERS";
            this.ordersbtn.UseVisualStyleBackColor = false;
            this.ordersbtn.Click += new System.EventHandler(this.ordersbtn_Click);
            // 
            // tablesbtn
            // 
            this.tablesbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tablesbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablesbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablesbtn.FlatAppearance.BorderSize = 2;
            this.tablesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tablesbtn.Font = new System.Drawing.Font("Calibri", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablesbtn.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.tablesbtn.Location = new System.Drawing.Point(295, 138);
            this.tablesbtn.Name = "tablesbtn";
            this.tablesbtn.Size = new System.Drawing.Size(140, 129);
            this.tablesbtn.TabIndex = 7;
            this.tablesbtn.Text = "TABLES";
            this.tablesbtn.UseVisualStyleBackColor = false;
            this.tablesbtn.Click += new System.EventHandler(this.tablesbtn_Click);
            // 
            // billBtn
            // 
            this.billBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.billBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.billBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billBtn.FlatAppearance.BorderSize = 2;
            this.billBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billBtn.Font = new System.Drawing.Font("Calibri", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billBtn.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.billBtn.Location = new System.Drawing.Point(441, 138);
            this.billBtn.Name = "billBtn";
            this.billBtn.Size = new System.Drawing.Size(140, 129);
            this.billBtn.TabIndex = 8;
            this.billBtn.Text = "BILL GENERATION";
            this.billBtn.UseVisualStyleBackColor = false;
            this.billBtn.Click += new System.EventHandler(this.billBtn_Click);
            // 
            // button10
            // 
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.FlatAppearance.BorderSize = 2;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(3, 273);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(140, 129);
            this.button10.TabIndex = 9;
            this.button10.Text = "Order Modification";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.FlatAppearance.BorderSize = 2;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(587, 138);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(142, 129);
            this.button11.TabIndex = 10;
            this.button11.Text = "Tax Management";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Visible = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // menubtn
            // 
            this.menubtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menubtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menubtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menubtn.FlatAppearance.BorderSize = 2;
            this.menubtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menubtn.Font = new System.Drawing.Font("Calibri", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menubtn.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.menubtn.Location = new System.Drawing.Point(587, 3);
            this.menubtn.Name = "menubtn";
            this.menubtn.Size = new System.Drawing.Size(142, 129);
            this.menubtn.TabIndex = 4;
            this.menubtn.Text = "FOOD MENU";
            this.menubtn.UseVisualStyleBackColor = false;
            this.menubtn.Click += new System.EventHandler(this.menubtn_Click);
            // 
            // adminHomeScreenWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "adminHomeScreenWindow";
            this.Text = "Home Screen";
            this.Load += new System.EventHandler(this.adminHomeScreenWindow_Load);
            this.leftpanel.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button rolesbtn;
        private System.Windows.Forms.Button usersbtn;
        private System.Windows.Forms.Button customersbtn;
        private System.Windows.Forms.Button categoriesbtn;
        private System.Windows.Forms.Button floorsbtn;
        private System.Windows.Forms.Button ordersbtn;
        private System.Windows.Forms.Button tablesbtn;
        private System.Windows.Forms.Button billBtn;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button menubtn;
        private System.Windows.Forms.Button button11;
    }
}