namespace WindowsFormsApp2
{
    partial class Form3
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
            this.btnShowAllEmployee = new System.Windows.Forms.Button();
            this.btn3update = new System.Windows.Forms.Button();
            this.btn5Delete = new System.Windows.Forms.Button();
            this.btn4search = new System.Windows.Forms.Button();
            this.btn2save = new System.Windows.Forms.Button();
            this.textBox3Salary = new System.Windows.Forms.TextBox();
            this.textBox2Name = new System.Windows.Forms.TextBox();
            this.label3Sal = new System.Windows.Forms.Label();
            this.label2Name = new System.Windows.Forms.Label();
            this.label1ID = new System.Windows.Forms.Label();
            this.textBox1Id = new System.Windows.Forms.TextBox();
            this.AllEmpView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AllEmpView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowAllEmployee
            // 
            this.btnShowAllEmployee.Location = new System.Drawing.Point(560, 327);
            this.btnShowAllEmployee.Name = "btnShowAllEmployee";
            this.btnShowAllEmployee.Size = new System.Drawing.Size(207, 23);
            this.btnShowAllEmployee.TabIndex = 36;
            this.btnShowAllEmployee.Text = "Show All Employee";
            this.btnShowAllEmployee.UseVisualStyleBackColor = true;
            this.btnShowAllEmployee.Click += new System.EventHandler(this.btnShowAllEmployee_Click);
            // 
            // btn3update
            // 
            this.btn3update.Location = new System.Drawing.Point(301, 335);
            this.btn3update.Name = "btn3update";
            this.btn3update.Size = new System.Drawing.Size(75, 23);
            this.btn3update.TabIndex = 35;
            this.btn3update.Text = "Update";
            this.btn3update.UseVisualStyleBackColor = true;
            this.btn3update.Click += new System.EventHandler(this.btn3update_Click);
            // 
            // btn5Delete
            // 
            this.btn5Delete.Location = new System.Drawing.Point(334, 242);
            this.btn5Delete.Name = "btn5Delete";
            this.btn5Delete.Size = new System.Drawing.Size(75, 40);
            this.btn5Delete.TabIndex = 34;
            this.btn5Delete.Text = "Delete";
            this.btn5Delete.UseVisualStyleBackColor = true;
            this.btn5Delete.Click += new System.EventHandler(this.btn5Delete_Click);
            // 
            // btn4search
            // 
            this.btn4search.Location = new System.Drawing.Point(334, 158);
            this.btn4search.Name = "btn4search";
            this.btn4search.Size = new System.Drawing.Size(75, 44);
            this.btn4search.TabIndex = 33;
            this.btn4search.Text = "Search";
            this.btn4search.UseVisualStyleBackColor = true;
            this.btn4search.Click += new System.EventHandler(this.btn4search_Click);
            // 
            // btn2save
            // 
            this.btn2save.Location = new System.Drawing.Point(157, 335);
            this.btn2save.Name = "btn2save";
            this.btn2save.Size = new System.Drawing.Size(75, 23);
            this.btn2save.TabIndex = 32;
            this.btn2save.Text = "Save";
            this.btn2save.UseVisualStyleBackColor = true;
            this.btn2save.Click += new System.EventHandler(this.btn2save_Click);
            // 
            // textBox3Salary
            // 
            this.textBox3Salary.Location = new System.Drawing.Point(133, 267);
            this.textBox3Salary.Name = "textBox3Salary";
            this.textBox3Salary.Size = new System.Drawing.Size(100, 22);
            this.textBox3Salary.TabIndex = 31;
            // 
            // textBox2Name
            // 
            this.textBox2Name.Location = new System.Drawing.Point(133, 187);
            this.textBox2Name.Name = "textBox2Name";
            this.textBox2Name.Size = new System.Drawing.Size(100, 22);
            this.textBox2Name.TabIndex = 30;
            // 
            // label3Sal
            // 
            this.label3Sal.AutoSize = true;
            this.label3Sal.Location = new System.Drawing.Point(28, 273);
            this.label3Sal.Name = "label3Sal";
            this.label3Sal.Size = new System.Drawing.Size(46, 16);
            this.label3Sal.TabIndex = 29;
            this.label3Sal.Text = "Salary";
            // 
            // label2Name
            // 
            this.label2Name.AutoSize = true;
            this.label2Name.Location = new System.Drawing.Point(28, 190);
            this.label2Name.Name = "label2Name";
            this.label2Name.Size = new System.Drawing.Size(75, 16);
            this.label2Name.TabIndex = 28;
            this.label2Name.Text = "Emp Name";
            // 
            // label1ID
            // 
            this.label1ID.AutoSize = true;
            this.label1ID.Location = new System.Drawing.Point(28, 126);
            this.label1ID.Name = "label1ID";
            this.label1ID.Size = new System.Drawing.Size(85, 16);
            this.label1ID.TabIndex = 27;
            this.label1ID.Text = "Employee ID";
            // 
            // textBox1Id
            // 
            this.textBox1Id.Location = new System.Drawing.Point(132, 123);
            this.textBox1Id.Name = "textBox1Id";
            this.textBox1Id.Size = new System.Drawing.Size(100, 22);
            this.textBox1Id.TabIndex = 26;
            // 
            // AllEmpView
            // 
            this.AllEmpView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllEmpView.Location = new System.Drawing.Point(517, 93);
            this.AllEmpView.Name = "AllEmpView";
            this.AllEmpView.RowHeadersWidth = 51;
            this.AllEmpView.RowTemplate.Height = 24;
            this.AllEmpView.Size = new System.Drawing.Size(300, 185);
            this.AllEmpView.TabIndex = 25;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 473);
            this.Controls.Add(this.btnShowAllEmployee);
            this.Controls.Add(this.btn3update);
            this.Controls.Add(this.btn5Delete);
            this.Controls.Add(this.btn4search);
            this.Controls.Add(this.btn2save);
            this.Controls.Add(this.textBox3Salary);
            this.Controls.Add(this.textBox2Name);
            this.Controls.Add(this.label3Sal);
            this.Controls.Add(this.label2Name);
            this.Controls.Add(this.label1ID);
            this.Controls.Add(this.textBox1Id);
            this.Controls.Add(this.AllEmpView);
            this.Name = "Form3";
            this.Text = "Disconnected Demo";
            ((System.ComponentModel.ISupportInitialize)(this.AllEmpView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowAllEmployee;
        private System.Windows.Forms.Button btn3update;
        private System.Windows.Forms.Button btn5Delete;
        private System.Windows.Forms.Button btn4search;
        private System.Windows.Forms.Button btn2save;
        private System.Windows.Forms.TextBox textBox3Salary;
        private System.Windows.Forms.TextBox textBox2Name;
        private System.Windows.Forms.Label label3Sal;
        private System.Windows.Forms.Label label2Name;
        private System.Windows.Forms.Label label1ID;
        private System.Windows.Forms.TextBox textBox1Id;
        private System.Windows.Forms.DataGridView AllEmpView;
    }
}