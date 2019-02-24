namespace WindowsFormsApplication4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nametextBox1 = new System.Windows.Forms.TextBox();
            this.addresstextBox2 = new System.Windows.Forms.TextBox();
            this.contactextBox3 = new System.Windows.Forms.TextBox();
            this.regtextBox4 = new System.Windows.Forms.TextBox();
            this.departmenttextBox5 = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Save = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.indexTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "RegNo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DepartmentId";
            // 
            // nametextBox1
            // 
            this.nametextBox1.Location = new System.Drawing.Point(113, 48);
            this.nametextBox1.Name = "nametextBox1";
            this.nametextBox1.Size = new System.Drawing.Size(100, 20);
            this.nametextBox1.TabIndex = 5;
            // 
            // addresstextBox2
            // 
            this.addresstextBox2.Location = new System.Drawing.Point(113, 90);
            this.addresstextBox2.Name = "addresstextBox2";
            this.addresstextBox2.Size = new System.Drawing.Size(100, 20);
            this.addresstextBox2.TabIndex = 6;
            // 
            // contactextBox3
            // 
            this.contactextBox3.Location = new System.Drawing.Point(113, 129);
            this.contactextBox3.Name = "contactextBox3";
            this.contactextBox3.Size = new System.Drawing.Size(100, 20);
            this.contactextBox3.TabIndex = 7;
            // 
            // regtextBox4
            // 
            this.regtextBox4.Location = new System.Drawing.Point(113, 164);
            this.regtextBox4.Name = "regtextBox4";
            this.regtextBox4.Size = new System.Drawing.Size(100, 20);
            this.regtextBox4.TabIndex = 8;
            // 
            // departmenttextBox5
            // 
            this.departmenttextBox5.Location = new System.Drawing.Point(113, 206);
            this.departmenttextBox5.Name = "departmenttextBox5";
            this.departmenttextBox5.Size = new System.Drawing.Size(100, 20);
            this.departmenttextBox5.TabIndex = 9;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 287);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(510, 160);
            this.dataGridView.TabIndex = 10;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(137, 242);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 11;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(255, 241);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(75, 23);
            this.Show.TabIndex = 12;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(321, 85);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 13;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(415, 85);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Id";
            // 
            // indexTextbox
            // 
            this.indexTextbox.Location = new System.Drawing.Point(363, 36);
            this.indexTextbox.Name = "indexTextbox";
            this.indexTextbox.Size = new System.Drawing.Size(100, 20);
            this.indexTextbox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 459);
            this.Controls.Add(this.indexTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.departmenttextBox5);
            this.Controls.Add(this.regtextBox4);
            this.Controls.Add(this.contactextBox3);
            this.Controls.Add(this.addresstextBox2);
            this.Controls.Add(this.nametextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nametextBox1;
        private System.Windows.Forms.TextBox addresstextBox2;
        private System.Windows.Forms.TextBox contactextBox3;
        private System.Windows.Forms.TextBox regtextBox4;
        private System.Windows.Forms.TextBox departmenttextBox5;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox indexTextbox;
    }
}

