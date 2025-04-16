namespace organizational_technique
{
    partial class PrinterForm
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
            button1 = new Button();
            button2 = new Button();
            ListBox1 = new ListBox();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button3 = new Button();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Location = new Point(12, 333);
            button1.Name = "button1";
            button1.Size = new Size(126, 77);
            button1.TabIndex = 0;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.Location = new Point(428, 333);
            button2.Name = "button2";
            button2.Size = new Size(111, 77);
            button2.TabIndex = 1;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ListBox1
            // 
            ListBox1.BackColor = SystemColors.Window;
            ListBox1.FormattingEnabled = true;
            ListBox1.Location = new Point(12, 86);
            ListBox1.Name = "ListBox1";
            ListBox1.Size = new Size(527, 244);
            ListBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 27);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(659, 86);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(249, 52);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonShadow;
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(406, 53);
            button3.Name = "button3";
            button3.Size = new Size(133, 29);
            button3.TabIndex = 6;
            button3.Text = "Изменить статус";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(249, 18);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 7;
            // 
            // PrinterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(ListBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "PrinterForm";
            Text = "PrinterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ListBox ListBox1;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private Button button3;
        private ComboBox comboBox2;
    }
}