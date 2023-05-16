namespace Files
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            comboBox4 = new ComboBox();
            label8 = new Label();
            comboBox3 = new ComboBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            dataGridView2 = new DataGridView();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(20, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1032, 639);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1024, 606);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Документ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(333, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(671, 498);
            dataGridView1.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(157, 491);
            button3.Name = "button3";
            button3.Size = new Size(116, 42);
            button3.TabIndex = 8;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(20, 491);
            button2.Name = "button2";
            button2.Size = new Size(116, 42);
            button2.TabIndex = 7;
            button2.Text = "Изменить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Location = new Point(89, 426);
            button1.Name = "button1";
            button1.Size = new Size(124, 46);
            button1.TabIndex = 6;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(20, 372);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(253, 28);
            comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 340);
            label3.Name = "label3";
            label3.Size = new Size(169, 20);
            label3.TabIndex = 4;
            label3.Text = "Кому предназначается";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(20, 185);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 124);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 150);
            label2.Name = "label2";
            label2.Size = new Size(155, 20);
            label2.TabIndex = 2;
            label2.Text = "Детальное описание";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 61);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 58);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 26);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 0;
            label1.Text = "Название документа";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(comboBox4);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(comboBox3);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1024, 606);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Карточка";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(16, 186);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(253, 28);
            comboBox4.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 163);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 24;
            label8.Text = "ID документа";
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(16, 126);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(253, 28);
            comboBox3.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 103);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 22;
            label7.Text = "Автор";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(16, 389);
            dateTimePicker1.MaxDate = new DateTime(9998, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2005, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(253, 27);
            dateTimePicker1.TabIndex = 21;
            dateTimePicker1.Value = new DateTime(2023, 5, 16, 0, 0, 0, 0);
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(16, 60);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(253, 28);
            comboBox2.TabIndex = 20;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(329, 36);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(671, 498);
            dataGridView2.TabIndex = 19;
            // 
            // button4
            // 
            button4.Location = new Point(153, 511);
            button4.Name = "button4";
            button4.Size = new Size(116, 42);
            button4.TabIndex = 18;
            button4.Text = "Удалить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(16, 511);
            button5.Name = "button5";
            button5.Size = new Size(116, 42);
            button5.TabIndex = 17;
            button5.Text = "Изменить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.SteelBlue;
            button6.Location = new Point(85, 446);
            button6.Name = "button6";
            button6.Size = new Size(124, 46);
            button6.TabIndex = 16;
            button6.Text = "Добавить";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 356);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 14;
            label4.Text = "Дата создания";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(16, 265);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(253, 88);
            textBox3.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 230);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 12;
            label5.Text = "Краткое описание";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 27);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 10;
            label6.Text = "Тип документа";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 675);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Картотека документов";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label7;
        private ComboBox comboBox4;
        private Label label8;
    }
}