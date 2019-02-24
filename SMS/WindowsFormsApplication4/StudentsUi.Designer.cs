namespace WindowsFormsApplication4
{
    partial class StudentsUi
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
            this.components = new System.ComponentModel.Container();
            this.indexTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.regtextBox4 = new System.Windows.Forms.TextBox();
            this.contactextBox3 = new System.Windows.Forms.TextBox();
            this.addresstextBox2 = new System.Windows.Forms.TextBox();
            this.nametextBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.depatmentComboBox = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDbDataSet = new WindowsFormsApplication4.StudentDbDataSet();
            this.departmentTableAdapter = new WindowsFormsApplication4.StudentDbDataSetTableAdapters.DepartmentTableAdapter();
            this.studenDbDataSet = new WindowsFormsApplication4.StudenDbDataSet();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsTableAdapter = new WindowsFormsApplication4.StudenDbDataSetTableAdapters.DepartmentsTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.studentComboBox = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studenDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // indexTextbox
            // 
            this.indexTextbox.Location = new System.Drawing.Point(309, 17);
            this.indexTextbox.Name = "indexTextbox";
            this.indexTextbox.Size = new System.Drawing.Size(100, 20);
            this.indexTextbox.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Id";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(373, 71);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 31;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(265, 71);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 30;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(196, 249);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(75, 23);
            this.Show.TabIndex = 29;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(78, 250);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 28;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(16, 311);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(510, 160);
            this.dataGridView.TabIndex = 27;
            // 
            // regtextBox4
            // 
            this.regtextBox4.Location = new System.Drawing.Point(106, 131);
            this.regtextBox4.Name = "regtextBox4";
            this.regtextBox4.Size = new System.Drawing.Size(121, 20);
            this.regtextBox4.TabIndex = 25;
            // 
            // contactextBox3
            // 
            this.contactextBox3.Location = new System.Drawing.Point(106, 95);
            this.contactextBox3.Name = "contactextBox3";
            this.contactextBox3.Size = new System.Drawing.Size(121, 20);
            this.contactextBox3.TabIndex = 24;
            // 
            // addresstextBox2
            // 
            this.addresstextBox2.Location = new System.Drawing.Point(106, 56);
            this.addresstextBox2.Name = "addresstextBox2";
            this.addresstextBox2.Size = new System.Drawing.Size(121, 20);
            this.addresstextBox2.TabIndex = 23;
            // 
            // nametextBox1
            // 
            this.nametextBox1.Location = new System.Drawing.Point(106, 14);
            this.nametextBox1.Name = "nametextBox1";
            this.nametextBox1.Size = new System.Drawing.Size(121, 20);
            this.nametextBox1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "RegNo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name";
            // 
            // depatmentComboBox
            // 
            this.depatmentComboBox.DataSource = this.departmentBindingSource1;
            this.depatmentComboBox.DisplayMember = "Name";
            this.depatmentComboBox.FormattingEnabled = true;
            this.depatmentComboBox.Location = new System.Drawing.Point(106, 171);
            this.depatmentComboBox.Name = "depatmentComboBox";
            this.depatmentComboBox.Size = new System.Drawing.Size(121, 21);
            this.depatmentComboBox.TabIndex = 34;
            this.depatmentComboBox.ValueMember = "ID";
            this.depatmentComboBox.SelectedIndexChanged += new System.EventHandler(this.depatmentComboBox_SelectedIndexChanged);
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataSource = typeof(WindowsFormsApplication4.Models.Department);
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.studentDbDataSet;
            // 
            // studentDbDataSet
            // 
            this.studentDbDataSet.DataSetName = "StudentDbDataSet";
            this.studentDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // studenDbDataSet
            // 
            this.studenDbDataSet.DataSetName = "StudenDbDataSet";
            this.studenDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.studenDbDataSet;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Student";
            // 
            // studentComboBox
            // 
            this.studentComboBox.DataSource = this.studentBindingSource;
            this.studentComboBox.DisplayMember = "Name";
            this.studentComboBox.FormattingEnabled = true;
            this.studentComboBox.Location = new System.Drawing.Point(106, 203);
            this.studentComboBox.Name = "studentComboBox";
            this.studentComboBox.Size = new System.Drawing.Size(121, 21);
            this.studentComboBox.TabIndex = 34;
            this.studentComboBox.ValueMember = "ID";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(WindowsFormsApplication4.Models.Student);
            // 
            // StudentsUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 483);
            this.Controls.Add(this.studentComboBox);
            this.Controls.Add(this.depatmentComboBox);
            this.Controls.Add(this.indexTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.regtextBox4);
            this.Controls.Add(this.contactextBox3);
            this.Controls.Add(this.addresstextBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nametextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentsUi";
            this.Text = "StudentsUi";
            this.Load += new System.EventHandler(this.StudentsUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studenDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox indexTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox regtextBox4;
        private System.Windows.Forms.TextBox contactextBox3;
        private System.Windows.Forms.TextBox addresstextBox2;
        private System.Windows.Forms.TextBox nametextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox depatmentComboBox;
        private StudentDbDataSet studentDbDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private StudentDbDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private StudenDbDataSet studenDbDataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private StudenDbDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox studentComboBox;
        private System.Windows.Forms.BindingSource studentBindingSource;
    }
}