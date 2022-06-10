namespace WindowsFormsApp2
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
            this.textBox1Id = new System.Windows.Forms.TextBox();
            this.label1ID = new System.Windows.Forms.Label();
            this.label2Name = new System.Windows.Forms.Label();
            this.label3Sal = new System.Windows.Forms.Label();
            this.textBox2Name = new System.Windows.Forms.TextBox();
            this.textBox3Sal = new System.Windows.Forms.TextBox();
            this.btn1Add = new System.Windows.Forms.Button();
            this.btn2save = new System.Windows.Forms.Button();
            this.btn4search = new System.Windows.Forms.Button();
            this.btn5Delete = new System.Windows.Forms.Button();
            this.btn3update = new System.Windows.Forms.Button();
            this.AllEmpView = new System.Windows.Forms.DataGridView();
            this.btn6AllEmp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllEmpView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1Id
            // 
            this.textBox1Id.Location = new System.Drawing.Point(161, 48);
            this.textBox1Id.Name = "textBox1Id";
            this.textBox1Id.Size = new System.Drawing.Size(100, 22);
            this.textBox1Id.TabIndex = 0;
            // 
            // label1ID
            // 
            this.label1ID.AutoSize = true;
            this.label1ID.Location = new System.Drawing.Point(12, 48);
            this.label1ID.Name = "label1ID";
            this.label1ID.Size = new System.Drawing.Size(83, 16);
            this.label1ID.TabIndex = 1;
            this.label1ID.Text = "Employee Id";
            // 
            // label2Name
            // 
            this.label2Name.AutoSize = true;
            this.label2Name.Location = new System.Drawing.Point(12, 111);
            this.label2Name.Name = "label2Name";
            this.label2Name.Size = new System.Drawing.Size(109, 16);
            this.label2Name.TabIndex = 2;
            this.label2Name.Text = "Employee Name";
            // 
            // label3Sal
            // 
            this.label3Sal.AutoSize = true;
            this.label3Sal.Location = new System.Drawing.Point(12, 191);
            this.label3Sal.Name = "label3Sal";
            this.label3Sal.Size = new System.Drawing.Size(46, 16);
            this.label3Sal.TabIndex = 3;
            this.label3Sal.Text = "Salary";
            // 
            // textBox2Name
            // 
            this.textBox2Name.Location = new System.Drawing.Point(162, 112);
            this.textBox2Name.Name = "textBox2Name";
            this.textBox2Name.Size = new System.Drawing.Size(100, 22);
            this.textBox2Name.TabIndex = 4;
            // 
            // textBox3Sal
            // 
            this.textBox3Sal.Location = new System.Drawing.Point(162, 192);
            this.textBox3Sal.Name = "textBox3Sal";
            this.textBox3Sal.Size = new System.Drawing.Size(100, 22);
            this.textBox3Sal.TabIndex = 5;
            // 
            // btn1Add
            // 
            this.btn1Add.Location = new System.Drawing.Point(15, 260);
            this.btn1Add.Name = "btn1Add";
            this.btn1Add.Size = new System.Drawing.Size(75, 23);
            this.btn1Add.TabIndex = 6;
            this.btn1Add.Text = "Add New";
            this.btn1Add.UseVisualStyleBackColor = true;
            // 
            // btn2save
            // 
            this.btn2save.Location = new System.Drawing.Point(186, 260);
            this.btn2save.Name = "btn2save";
            this.btn2save.Size = new System.Drawing.Size(75, 23);
            this.btn2save.TabIndex = 7;
            this.btn2save.Text = "Save";
            this.btn2save.UseVisualStyleBackColor = true;
            this.btn2save.Click += new System.EventHandler(this.btn2save_Click);
            // 
            // btn4search
            // 
            this.btn4search.Location = new System.Drawing.Point(363, 83);
            this.btn4search.Name = "btn4search";
            this.btn4search.Size = new System.Drawing.Size(75, 44);
            this.btn4search.TabIndex = 8;
            this.btn4search.Text = "Search";
            this.btn4search.UseVisualStyleBackColor = true;
            this.btn4search.Click += new System.EventHandler(this.btn4search_Click);
            // 
            // btn5Delete
            // 
            this.btn5Delete.Location = new System.Drawing.Point(363, 167);
            this.btn5Delete.Name = "btn5Delete";
            this.btn5Delete.Size = new System.Drawing.Size(75, 40);
            this.btn5Delete.TabIndex = 9;
            this.btn5Delete.Text = "Delete";
            this.btn5Delete.UseVisualStyleBackColor = true;
            this.btn5Delete.Click += new System.EventHandler(this.btn5Delete_Click);
            // 
            // btn3update
            // 
            this.btn3update.Location = new System.Drawing.Point(330, 260);
            this.btn3update.Name = "btn3update";
            this.btn3update.Size = new System.Drawing.Size(75, 23);
            this.btn3update.TabIndex = 10;
            this.btn3update.Text = "Update";
            this.btn3update.UseVisualStyleBackColor = true;
            this.btn3update.Click += new System.EventHandler(this.btn3update_Click);
            // 
            // AllEmpView
            // 
            this.AllEmpView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllEmpView.Location = new System.Drawing.Point(604, 29);
            this.AllEmpView.Name = "AllEmpView";
            this.AllEmpView.RowHeadersWidth = 51;
            this.AllEmpView.RowTemplate.Height = 24;
            this.AllEmpView.Size = new System.Drawing.Size(300, 185);
            this.AllEmpView.TabIndex = 11;
            // 
            // btn6AllEmp
            // 
            this.btn6AllEmp.Location = new System.Drawing.Point(667, 251);
            this.btn6AllEmp.Name = "btn6AllEmp";
            this.btn6AllEmp.Size = new System.Drawing.Size(199, 23);
            this.btn6AllEmp.TabIndex = 12;
            this.btn6AllEmp.Text = "Show All Employee";
            this.btn6AllEmp.UseVisualStyleBackColor = true;
            this.btn6AllEmp.Click += new System.EventHandler(this.btn6AllEmp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 335);
            this.Controls.Add(this.btn6AllEmp);
            this.Controls.Add(this.AllEmpView);
            this.Controls.Add(this.btn3update);
            this.Controls.Add(this.btn5Delete);
            this.Controls.Add(this.btn4search);
            this.Controls.Add(this.btn2save);
            this.Controls.Add(this.btn1Add);
            this.Controls.Add(this.textBox3Sal);
            this.Controls.Add(this.textBox2Name);
            this.Controls.Add(this.label3Sal);
            this.Controls.Add(this.label2Name);
            this.Controls.Add(this.label1ID);
            this.Controls.Add(this.textBox1Id);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AllEmpView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1Id;
        private System.Windows.Forms.Label label1ID;
        private System.Windows.Forms.Label label2Name;
        private System.Windows.Forms.Label label3Sal;
        private System.Windows.Forms.TextBox textBox2Name;
        private System.Windows.Forms.TextBox textBox3Sal;
        private System.Windows.Forms.Button btn1Add;
        private System.Windows.Forms.Button btn2save;
        private System.Windows.Forms.Button btn4search;
        private System.Windows.Forms.Button btn5Delete;
        private System.Windows.Forms.Button btn3update;
        private System.Windows.Forms.DataGridView AllEmpView;
        private System.Windows.Forms.Button btn6AllEmp;
    }
}

