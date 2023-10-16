namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            checkedListCourses = new CheckedListBox();
            label5 = new Label();
            cbCity = new ComboBox();
            lacity = new Label();
            rdfemale = new RadioButton();
            rdmale = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            txtage = new TextBox();
            label2 = new Label();
            txtname = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleName = "txtname";
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 40);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 0;
            label1.Text = " Student name:";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(checkedListCourses);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbCity);
            groupBox1.Controls.Add(lacity);
            groupBox1.Controls.Add(rdfemale);
            groupBox1.Controls.Add(rdmale);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtage);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtname);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 616);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Information";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(114, 544);
            button1.Name = "button1";
            button1.Size = new Size(145, 48);
            button1.TabIndex = 12;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkedListCourses
            // 
            checkedListCourses.FormattingEnabled = true;
            checkedListCourses.Items.AddRange(new object[] { "OS", "COA", "DSA", "LA", "OOP" });
            checkedListCourses.Location = new Point(117, 401);
            checkedListCourses.Name = "checkedListCourses";
            checkedListCourses.Size = new Size(123, 99);
            checkedListCourses.TabIndex = 11;
            // 
            // label5
            // 
            label5.AccessibleName = "txtname";
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium Cond", 10.2F);
            label5.Location = new Point(6, 401);
            label5.Name = "label5";
            label5.Size = new Size(62, 21);
            label5.TabIndex = 10;
            label5.Text = "Courses";
            // 
            // cbCity
            // 
            cbCity.FormattingEnabled = true;
            cbCity.Items.AddRange(new object[] { "Mansoura", "Cairo", "Alexandria", "Giza" });
            cbCity.Location = new Point(123, 297);
            cbCity.Name = "cbCity";
            cbCity.Size = new Size(151, 24);
            cbCity.TabIndex = 9;
            // 
            // lacity
            // 
            lacity.AccessibleName = "txtname";
            lacity.AutoSize = true;
            lacity.Font = new Font("Franklin Gothic Medium Cond", 10.2F);
            lacity.Location = new Point(12, 297);
            lacity.Name = "lacity";
            lacity.Size = new Size(41, 21);
            lacity.TabIndex = 8;
            lacity.Text = "City :";
            lacity.Click += lacity_Click;
            // 
            // rdfemale
            // 
            rdfemale.AutoSize = true;
            rdfemale.Location = new Point(123, 213);
            rdfemale.Name = "rdfemale";
            rdfemale.Size = new Size(73, 20);
            rdfemale.TabIndex = 7;
            rdfemale.TabStop = true;
            rdfemale.Text = "Female";
            rdfemale.UseVisualStyleBackColor = true;
            // 
            // rdmale
            // 
            rdmale.AutoSize = true;
            rdmale.Location = new Point(123, 187);
            rdmale.Name = "rdmale";
            rdmale.Size = new Size(58, 20);
            rdmale.TabIndex = 6;
            rdmale.TabStop = true;
            rdmale.Text = "Male";
            rdmale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AccessibleName = "txtname";
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium Cond", 10.2F);
            label4.Location = new Point(6, 187);
            label4.Name = "label4";
            label4.Size = new Size(64, 21);
            label4.TabIndex = 5;
            label4.Text = "Gender :";
            // 
            // label3
            // 
            label3.AccessibleName = "txtname";
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 10.2F);
            label3.Location = new Point(6, 90);
            label3.Name = "label3";
            label3.Size = new Size(41, 21);
            label3.TabIndex = 4;
            label3.Text = "Age :";
            // 
            // txtage
            // 
            txtage.Location = new Point(123, 79);
            txtage.Name = "txtage";
            txtage.Size = new Size(181, 24);
            txtage.TabIndex = 3;
            // 
            // label2
            // 
            label2.AccessibleName = "txtname";
            label2.AutoSize = true;
            label2.Location = new Point(6, 87);
            label2.Name = "label2";
            label2.Size = new Size(0, 16);
            label2.TabIndex = 2;
            // 
            // txtname
            // 
            txtname.Location = new Point(123, 37);
            txtname.Name = "txtname";
            txtname.Size = new Size(181, 24);
            txtname.TabIndex = 1;
            txtname.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 624);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Student Portal";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtage;
        private Label label2;
        private TextBox txtname;
        private Label label3;
        private Label label4;
        private ComboBox cbCity;
        private Label lacity;
        private RadioButton rdfemale;
        private RadioButton rdmale;
        private Button button1;
        private CheckedListBox checkedListCourses;
        private Label label5;
    }
}
