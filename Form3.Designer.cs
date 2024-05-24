namespace WindowsFormsAppSQL
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
            this.btnshowemplist = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.tstname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.Empsalary = new System.Windows.Forms.Label();
            this.Empcity = new System.Windows.Forms.Label();
            this.Empname = new System.Windows.Forms.Label();
            this.Empid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnshowemplist
            // 
            this.btnshowemplist.Location = new System.Drawing.Point(518, 381);
            this.btnshowemplist.Name = "btnshowemplist";
            this.btnshowemplist.Size = new System.Drawing.Size(292, 40);
            this.btnshowemplist.TabIndex = 27;
            this.btnshowemplist.Text = "Show Employee List";
            this.btnshowemplist.UseVisualStyleBackColor = true;
            this.btnshowemplist.Click += new System.EventHandler(this.btnshowemplist_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(462, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(485, 332);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(359, 50);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(89, 51);
            this.btnsearch.TabIndex = 25;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(269, 331);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(90, 48);
            this.btndelete.TabIndex = 24;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(118, 331);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(96, 48);
            this.btnupdate.TabIndex = 23;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(-34, 331);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(146, 48);
            this.btnsave.TabIndex = 22;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(110, 239);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(111, 22);
            this.txtsalary.TabIndex = 21;
            this.txtsalary.Text = "25000";
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(115, 184);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(106, 22);
            this.txtcity.TabIndex = 20;
            this.txtcity.Text = "pune";
            // 
            // tstname
            // 
            this.tstname.Location = new System.Drawing.Point(115, 123);
            this.tstname.Name = "tstname";
            this.tstname.Size = new System.Drawing.Size(100, 22);
            this.tstname.TabIndex = 19;
            this.tstname.Text = "priya";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(115, 64);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 18;
            // 
            // Empsalary
            // 
            this.Empsalary.AutoSize = true;
            this.Empsalary.Location = new System.Drawing.Point(16, 226);
            this.Empsalary.Name = "Empsalary";
            this.Empsalary.Size = new System.Drawing.Size(46, 16);
            this.Empsalary.TabIndex = 17;
            this.Empsalary.Text = "Salary";
            // 
            // Empcity
            // 
            this.Empcity.AutoSize = true;
            this.Empcity.Location = new System.Drawing.Point(16, 171);
            this.Empcity.Name = "Empcity";
            this.Empcity.Size = new System.Drawing.Size(29, 16);
            this.Empcity.TabIndex = 16;
            this.Empcity.Text = "City";
            // 
            // Empname
            // 
            this.Empname.AutoSize = true;
            this.Empname.Location = new System.Drawing.Point(15, 112);
            this.Empname.Name = "Empname";
            this.Empname.Size = new System.Drawing.Size(44, 16);
            this.Empname.TabIndex = 15;
            this.Empname.Text = "Name";
            // 
            // Empid
            // 
            this.Empid.AutoSize = true;
            this.Empid.Location = new System.Drawing.Point(-7, 70);
            this.Empid.Name = "Empid";
            this.Empid.Size = new System.Drawing.Size(83, 16);
            this.Empid.TabIndex = 14;
            this.Empid.Text = "Employee id";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 450);
            this.Controls.Add(this.btnshowemplist);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.tstname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.Empsalary);
            this.Controls.Add(this.Empcity);
            this.Controls.Add(this.Empname);
            this.Controls.Add(this.Empid);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnshowemplist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox tstname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label Empsalary;
        private System.Windows.Forms.Label Empcity;
        private System.Windows.Forms.Label Empname;
        private System.Windows.Forms.Label Empid;
    }
}