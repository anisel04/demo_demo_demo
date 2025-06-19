namespace demo_sam
{
    partial class DemoEx
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            TeacherType = new DataGridViewTextBoxColumn();
            button3 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView5 = new DataGridView();
            IDISH = new DataGridViewTextBoxColumn();
            C1 = new DataGridViewTextBoxColumn();
            C2 = new DataGridViewTextBoxColumn();
            dataGridView4 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Partner = new DataGridViewTextBoxColumn();
            Discount = new DataGridViewTextBoxColumn();
            comboBox2 = new ComboBox();
            dataGridView3 = new DataGridView();
            Lesson = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            label6 = new Label();
            textBox6 = new TextBox();
            dataGridView2 = new DataGridView();
            Type = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            dataGridView6 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 9);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "ФИО";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(137, 139);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 51);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 3;
            label2.Text = "Телефон";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 91);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 4;
            label3.Text = "Тип";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(126, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(126, 91);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(126, 204);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(126, 244);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 244);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 11;
            label4.Text = "Телефон";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 204);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 10;
            label5.Text = "ФИО";
            // 
            // button2
            // 
            button2.Location = new Point(139, 328);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Обновить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Phone, TeacherType });
            dataGridView1.Location = new Point(46, 405);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(294, 188);
            dataGridView1.TabIndex = 14;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 125;
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.Width = 125;
            // 
            // TeacherType
            // 
            TeacherType.HeaderText = "Type";
            TeacherType.MinimumWidth = 6;
            TeacherType.Name = "TeacherType";
            TeacherType.Width = 125;
            // 
            // button3
            // 
            button3.Location = new Point(139, 599);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 15;
            button3.Text = "Фреш";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(73, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1271, 669);
            tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView5);
            tabPage1.Controls.Add(dataGridView4);
            tabPage1.Controls.Add(comboBox2);
            tabPage1.Controls.Add(dataGridView3);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(textBox6);
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(button2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1263, 636);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Columns.AddRange(new DataGridViewColumn[] { IDISH, C1, C2 });
            dataGridView5.Location = new Point(547, 180);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersWidth = 51;
            dataGridView5.Size = new Size(599, 103);
            dataGridView5.TabIndex = 24;
            dataGridView5.CellDoubleClick += dataGridView5_CellDoubleClick;
            // 
            // IDISH
            // 
            IDISH.HeaderText = "IDISH";
            IDISH.MinimumWidth = 6;
            IDISH.Name = "IDISH";
            IDISH.Width = 125;
            // 
            // C1
            // 
            C1.HeaderText = "C1";
            C1.MinimumWidth = 6;
            C1.Name = "C1";
            C1.Width = 125;
            // 
            // C2
            // 
            C2.HeaderText = "C2";
            C2.MinimumWidth = 6;
            C2.Name = "C2";
            C2.Width = 125;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.AllowUserToResizeColumns = false;
            dataGridView4.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 230, 210);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(240, 230, 210);
            dataGridView4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView4.BackgroundColor = Color.FromArgb(244, 232, 211);
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.ColumnHeadersVisible = false;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { ID, Partner, Discount });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(244, 232, 211);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(103, 186, 128);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(244, 232, 211);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(103, 186, 128);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView4.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView4.GridColor = Color.FromArgb(244, 232, 211);
            dataGridView4.Location = new Point(547, 38);
            dataGridView4.Margin = new Padding(3, 4, 3, 4);
            dataGridView4.MultiSelect = false;
            dataGridView4.Name = "dataGridView4";
            dataGridView4.ReadOnly = true;
            dataGridView4.RowHeadersVisible = false;
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.ShowEditingIcon = false;
            dataGridView4.Size = new Size(599, 110);
            dataGridView4.TabIndex = 23;
            dataGridView4.CellDoubleClick += dataGridView4_CellDoubleClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            ID.Width = 125;
            // 
            // Partner
            // 
            Partner.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Partner.FillWeight = 80F;
            Partner.HeaderText = "Partner";
            Partner.MinimumWidth = 6;
            Partner.Name = "Partner";
            Partner.ReadOnly = true;
            // 
            // Discount
            // 
            Discount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Discount.FillWeight = 20F;
            Discount.HeaderText = "Discount";
            Discount.MinimumWidth = 6;
            Discount.Name = "Discount";
            Discount.ReadOnly = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1069, 340);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 21;
            comboBox2.SelectedValueChanged += comboBox2_SelectedValueChanged;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Lesson });
            dataGridView3.Location = new Point(717, 405);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(503, 188);
            dataGridView3.TabIndex = 20;
            // 
            // Lesson
            // 
            Lesson.HeaderText = "Lesson";
            Lesson.MinimumWidth = 6;
            Lesson.Name = "Lesson";
            Lesson.Width = 125;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(295, 201);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 19;
            comboBox1.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 285);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 18;
            label6.Text = "Тип";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(126, 282);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 17;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Type });
            dataGridView2.Location = new Point(377, 405);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(300, 188);
            dataGridView2.TabIndex = 16;
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.Width = 125;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView6);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1263, 636);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1263, 636);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Location = new Point(208, 129);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.RowHeadersWidth = 51;
            dataGridView6.Size = new Size(483, 188);
            dataGridView6.TabIndex = 0;
            // 
            // DemoEx
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1399, 730);
            Controls.Add(tabControl1);
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label4;
        private Label label5;
        private Button button2;
        private DataGridView dataGridView1;
        private Button button3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn TeacherType;
        private Label label6;
        private TextBox textBox6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn Lesson;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Partner;
        private DataGridViewTextBoxColumn Discount;
        private DataGridView dataGridView5;
        private DataGridViewTextBoxColumn IDISH;
        private DataGridViewTextBoxColumn C1;
        private DataGridViewTextBoxColumn C2;
        private DataGridView dataGridView6;
    }
}
