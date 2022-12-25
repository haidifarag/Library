namespace library1.views.forms
{
    partial class borrow
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtS_Name = new System.Windows.Forms.TextBox();
            this.txtS_Department = new System.Windows.Forms.TextBox();
            this.txtS_Id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtD_Department = new System.Windows.Forms.TextBox();
            this.txtD_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtO_Department = new System.Windows.Forms.TextBox();
            this.txtO_Name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 502);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1045, 184);
            this.dgv.TabIndex = 18;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtS_Name
            // 
            this.txtS_Name.Location = new System.Drawing.Point(215, 99);
            this.txtS_Name.Name = "txtS_Name";
            this.txtS_Name.Size = new System.Drawing.Size(265, 38);
            this.txtS_Name.TabIndex = 31;
            this.txtS_Name.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtS_Department
            // 
            this.txtS_Department.Location = new System.Drawing.Point(215, 158);
            this.txtS_Department.Name = "txtS_Department";
            this.txtS_Department.Size = new System.Drawing.Size(265, 38);
            this.txtS_Department.TabIndex = 29;
            // 
            // txtS_Id
            // 
            this.txtS_Id.Location = new System.Drawing.Point(215, 44);
            this.txtS_Id.Name = "txtS_Id";
            this.txtS_Id.Size = new System.Drawing.Size(265, 38);
            this.txtS_Id.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("DecoType Naskh Variants", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(10, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 49);
            this.label5.TabIndex = 28;
            this.label5.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DecoType Naskh Variants", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(22, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 49);
            this.label3.TabIndex = 26;
            this.label3.Text = "Department";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DecoType Naskh Variants", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(22, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 49);
            this.label4.TabIndex = 23;
            this.label4.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtS_Name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtS_Department);
            this.groupBox1.Controls.Add(this.txtS_Id);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 229);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtD_Department);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtD_Name);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(515, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(493, 169);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Doctors";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // txtD_Department
            // 
            this.txtD_Department.Location = new System.Drawing.Point(215, 99);
            this.txtD_Department.Name = "txtD_Department";
            this.txtD_Department.Size = new System.Drawing.Size(265, 38);
            this.txtD_Department.TabIndex = 31;
            // 
            // txtD_Name
            // 
            this.txtD_Name.Location = new System.Drawing.Point(215, 44);
            this.txtD_Name.Name = "txtD_Name";
            this.txtD_Name.Size = new System.Drawing.Size(265, 38);
            this.txtD_Name.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DecoType Naskh Variants", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(13, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 49);
            this.label1.TabIndex = 36;
            this.label1.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DecoType Naskh Variants", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 49);
            this.label2.TabIndex = 35;
            this.label2.Text = "Name";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtO_Department);
            this.groupBox5.Controls.Add(this.txtO_Name);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(19, 267);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(490, 229);
            this.groupBox5.TabIndex = 34;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Operation";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // txtO_Department
            // 
            this.txtO_Department.Location = new System.Drawing.Point(215, 169);
            this.txtO_Department.Name = "txtO_Department";
            this.txtO_Department.Size = new System.Drawing.Size(265, 38);
            this.txtO_Department.TabIndex = 31;
            this.txtO_Department.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtO_Name
            // 
            this.txtO_Name.Location = new System.Drawing.Point(215, 111);
            this.txtO_Name.Name = "txtO_Name";
            this.txtO_Name.Size = new System.Drawing.Size(265, 38);
            this.txtO_Name.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("DecoType Naskh Variants", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(17, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 49);
            this.label8.TabIndex = 36;
            this.label8.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("DecoType Naskh Variants", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(10, 168);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 49);
            this.label9.TabIndex = 36;
            this.label9.Text = "Department";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("DecoType Naskh Variants", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(10, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 49);
            this.label6.TabIndex = 37;
            this.label6.Text = "select";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(215, 52);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(265, 38);
            this.textBox5.TabIndex = 38;
            // 
            // borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 695);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "borrow";
            this.Text = "borrow";
            this.Load += new System.EventHandler(this.borrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtS_Name;
        private System.Windows.Forms.TextBox txtS_Department;
        private System.Windows.Forms.TextBox txtS_Id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtD_Department;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtD_Name;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtO_Department;
        private System.Windows.Forms.TextBox txtO_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
    }
}