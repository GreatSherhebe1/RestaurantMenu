namespace MenuForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label3 = new Label();
            label4 = new Label();
            richTextBox3 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.56328F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55.43672F));
            tableLayoutPanel1.Size = new Size(484, 561);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(button1, 1, 2);
            tableLayoutPanel2.Controls.Add(richTextBox1, 1, 1);
            tableLayoutPanel2.Controls.Add(richTextBox2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.9344263F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 70.90164F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.7540979F));
            tableLayoutPanel2.Size = new Size(478, 244);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Создать меню";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(247, 210);
            button1.Margin = new Padding(8, 3, 8, 3);
            button1.Name = "button1";
            button1.Size = new Size(223, 31);
            button1.TabIndex = 1;
            button1.Text = "Сформировать меню";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(247, 42);
            richTextBox1.Margin = new Padding(8);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(223, 157);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Dock = DockStyle.Fill;
            richTextBox2.Location = new Point(8, 42);
            richTextBox2.Margin = new Padding(8);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(223, 157);
            richTextBox2.TabIndex = 3;
            richTextBox2.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 4;
            label2.Text = "Разделитель - Enter";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(richTextBox4, 0, 0);
            tableLayoutPanel3.Controls.Add(button3, 0, 2);
            tableLayoutPanel3.Controls.Add(button4, 1, 2);
            tableLayoutPanel3.Controls.Add(button5, 2, 2);
            tableLayoutPanel3.Controls.Add(button2, 3, 2);
            tableLayoutPanel3.Controls.Add(label3, 2, 1);
            tableLayoutPanel3.Controls.Add(label4, 1, 1);
            tableLayoutPanel3.Controls.Add(richTextBox3, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 253);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 77.57611F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 11.7095976F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7142859F));
            tableLayoutPanel3.Size = new Size(478, 305);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(365, 274);
            button2.Margin = new Padding(8, 3, 8, 3);
            button2.Name = "button2";
            button2.Size = new Size(105, 28);
            button2.TabIndex = 0;
            button2.Text = "Конец";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(8, 274);
            button3.Margin = new Padding(8, 3, 8, 3);
            button3.Name = "button3";
            button3.Size = new Size(103, 28);
            button3.TabIndex = 1;
            button3.Text = "Начало";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(127, 274);
            button4.Margin = new Padding(8, 3, 8, 3);
            button4.Name = "button4";
            button4.Size = new Size(103, 28);
            button4.TabIndex = 2;
            button4.Text = "Предыдущая";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Location = new Point(246, 274);
            button5.Margin = new Padding(8, 3, 8, 3);
            button5.Name = "button5";
            button5.Size = new Size(103, 28);
            button5.TabIndex = 3;
            button5.Text = "Следующая";
            button5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(241, 246);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 4;
            label3.Text = "label3";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(122, 246);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 5;
            label4.Text = "label4";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTextBox3
            // 
            tableLayoutPanel3.SetColumnSpan(richTextBox3, 2);
            richTextBox3.Dock = DockStyle.Fill;
            richTextBox3.Location = new Point(246, 8);
            richTextBox3.Margin = new Padding(8);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(224, 220);
            richTextBox3.TabIndex = 6;
            richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            tableLayoutPanel3.SetColumnSpan(richTextBox4, 2);
            richTextBox4.Dock = DockStyle.Fill;
            richTextBox4.Location = new Point(8, 8);
            richTextBox4.Margin = new Padding(8);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(222, 220);
            richTextBox4.TabIndex = 7;
            richTextBox4.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(500, 600);
            MinimumSize = new Size(500, 600);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Button button1;
        private Label label2;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button2;
        private Label label3;
        private Label label4;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox3;
    }
}
