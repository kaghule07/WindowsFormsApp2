namespace WindowsFormsApp2
{
    partial class Form2
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
            this.AllCourseView = new System.Windows.Forms.DataGridView();
            this.btn3update = new System.Windows.Forms.Button();
            this.btn5Delete = new System.Windows.Forms.Button();
            this.btn4search = new System.Windows.Forms.Button();
            this.btn2save = new System.Windows.Forms.Button();
            this.textBox3Fees = new System.Windows.Forms.TextBox();
            this.textBox2Name = new System.Windows.Forms.TextBox();
            this.label3Sal = new System.Windows.Forms.Label();
            this.label2Name = new System.Windows.Forms.Label();
            this.label1ID = new System.Windows.Forms.Label();
            this.textBox1Id = new System.Windows.Forms.TextBox();
            this.btnShowAllCr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllCourseView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllCourseView
            // 
            this.AllCourseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllCourseView.Location = new System.Drawing.Point(578, 55);
            this.AllCourseView.Name = "AllCourseView";
            this.AllCourseView.RowHeadersWidth = 51;
            this.AllCourseView.RowTemplate.Height = 24;
            this.AllCourseView.Size = new System.Drawing.Size(300, 185);
            this.AllCourseView.TabIndex = 12;
            // 
            // btn3update
            // 
            this.btn3update.Location = new System.Drawing.Point(362, 297);
            this.btn3update.Name = "btn3update";
            this.btn3update.Size = new System.Drawing.Size(75, 23);
            this.btn3update.TabIndex = 23;
            this.btn3update.Text = "Update";
            this.btn3update.UseVisualStyleBackColor = true;
            this.btn3update.Click += new System.EventHandler(this.btn3update_Click);
            // 
            // btn5Delete
            // 
            this.btn5Delete.Location = new System.Drawing.Point(395, 204);
            this.btn5Delete.Name = "btn5Delete";
            this.btn5Delete.Size = new System.Drawing.Size(75, 40);
            this.btn5Delete.TabIndex = 22;
            this.btn5Delete.Text = "Delete";
            this.btn5Delete.UseVisualStyleBackColor = true;
            this.btn5Delete.Click += new System.EventHandler(this.btn5Delete_Click);
            // 
            // btn4search
            // 
            this.btn4search.Location = new System.Drawing.Point(395, 120);
            this.btn4search.Name = "btn4search";
            this.btn4search.Size = new System.Drawing.Size(75, 44);
            this.btn4search.TabIndex = 21;
            this.btn4search.Text = "Search";
            this.btn4search.UseVisualStyleBackColor = true;
            this.btn4search.Click += new System.EventHandler(this.btn4search_Click);
            // 
            // btn2save
            // 
            this.btn2save.Location = new System.Drawing.Point(218, 297);
            this.btn2save.Name = "btn2save";
            this.btn2save.Size = new System.Drawing.Size(75, 23);
            this.btn2save.TabIndex = 20;
            this.btn2save.Text = "Save";
            this.btn2save.UseVisualStyleBackColor = true;
            this.btn2save.Click += new System.EventHandler(this.btn2save_Click);
            // 
            // textBox3Fees
            // 
            this.textBox3Fees.Location = new System.Drawing.Point(194, 229);
            this.textBox3Fees.Name = "textBox3Fees";
            this.textBox3Fees.Size = new System.Drawing.Size(100, 22);
            this.textBox3Fees.TabIndex = 18;
            // 
            // textBox2Name
            // 
            this.textBox2Name.Location = new System.Drawing.Point(194, 149);
            this.textBox2Name.Name = "textBox2Name";
            this.textBox2Name.Size = new System.Drawing.Size(100, 22);
            this.textBox2Name.TabIndex = 17;
            // 
            // label3Sal
            // 
            this.label3Sal.AutoSize = true;
            this.label3Sal.Location = new System.Drawing.Point(44, 228);
            this.label3Sal.Name = "label3Sal";
            this.label3Sal.Size = new System.Drawing.Size(38, 16);
            this.label3Sal.TabIndex = 16;
            this.label3Sal.Text = "Fees";
            // 
            // label2Name
            // 
            this.label2Name.AutoSize = true;
            this.label2Name.Location = new System.Drawing.Point(44, 148);
            this.label2Name.Name = "label2Name";
            this.label2Name.Size = new System.Drawing.Size(90, 16);
            this.label2Name.TabIndex = 15;
            this.label2Name.Text = "Course Name";
            // 
            // label1ID
            // 
            this.label1ID.AutoSize = true;
            this.label1ID.Location = new System.Drawing.Point(44, 85);
            this.label1ID.Name = "label1ID";
            this.label1ID.Size = new System.Drawing.Size(23, 16);
            this.label1ID.TabIndex = 14;
            this.label1ID.Text = " ID";
            // 
            // textBox1Id
            // 
            this.textBox1Id.Location = new System.Drawing.Point(193, 85);
            this.textBox1Id.Name = "textBox1Id";
            this.textBox1Id.Size = new System.Drawing.Size(100, 22);
            this.textBox1Id.TabIndex = 13;
            // 
            // btnShowAllCr
            // 
            this.btnShowAllCr.Location = new System.Drawing.Point(621, 289);
            this.btnShowAllCr.Name = "btnShowAllCr";
            this.btnShowAllCr.Size = new System.Drawing.Size(207, 23);
            this.btnShowAllCr.TabIndex = 24;
            this.btnShowAllCr.Text = "Show All Courses";
            this.btnShowAllCr.UseVisualStyleBackColor = true;
            this.btnShowAllCr.Click += new System.EventHandler(this.btnShowAllCr_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 445);
            this.Controls.Add(this.btnShowAllCr);
            this.Controls.Add(this.btn3update);
            this.Controls.Add(this.btn5Delete);
            this.Controls.Add(this.btn4search);
            this.Controls.Add(this.btn2save);
            this.Controls.Add(this.textBox3Fees);
            this.Controls.Add(this.textBox2Name);
            this.Controls.Add(this.label3Sal);
            this.Controls.Add(this.label2Name);
            this.Controls.Add(this.label1ID);
            this.Controls.Add(this.textBox1Id);
            this.Controls.Add(this.AllCourseView);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.AllCourseView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllCourseView;
        private System.Windows.Forms.Button btn3update;
        private System.Windows.Forms.Button btn5Delete;
        private System.Windows.Forms.Button btn4search;
        private System.Windows.Forms.Button btn2save;
        private System.Windows.Forms.TextBox textBox3Fees;
        private System.Windows.Forms.TextBox textBox2Name;
        private System.Windows.Forms.Label label3Sal;
        private System.Windows.Forms.Label label2Name;
        private System.Windows.Forms.Label label1ID;
        private System.Windows.Forms.TextBox textBox1Id;
        private System.Windows.Forms.Button btnShowAllCr;
    }
}