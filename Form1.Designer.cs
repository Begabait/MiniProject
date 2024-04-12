namespace FormComs
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox3 = new TextBox();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button6 = new Button();
            textBox6 = new TextBox();
            label3 = new Label();
            button7 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(123, 138);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(117, 20);
            button1.TabIndex = 0;
            button1.Text = "Administrator";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(35, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            comboBox1.Visible = false;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(220, 44);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 2;
            comboBox2.Visible = false;
            // 
            // textBox1
            // 
            textBox1.HideSelection = false;
            textBox1.Location = new Point(47, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            textBox1.Visible = false;
            // 
            // textBox2
            // 
            textBox2.HideSelection = false;
            textBox2.Location = new Point(229, 44);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            textBox2.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(35, 138);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(70, 20);
            button2.TabIndex = 5;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(151, 138);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(70, 20);
            button3.TabIndex = 6;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(259, 138);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(70, 20);
            button4.TabIndex = 7;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(140, 87);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 8;
            textBox3.Visible = false;
            // 
            // button5
            // 
            button5.Location = new Point(92, 152);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 9;
            button5.Text = "Log In";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 43);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 10;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 87);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 11;
            label2.Text = "Password:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(162, 40);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(162, 84);
            textBox5.Name = "textBox5";
            textBox5.PasswordChar = '*';
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 13;
            // 
            // button6
            // 
            button6.Location = new Point(197, 152);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 14;
            button6.Text = "Validate";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(162, 116);
            textBox6.Name = "textBox6";
            textBox6.PasswordChar = '*';
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 15;
            textBox6.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 119);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 16;
            label3.Text = "Repeat Password:";
            label3.Visible = false;
            // 
            // button7
            // 
            button7.Location = new Point(279, 116);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 17;
            button7.Text = "Register";
            button7.UseVisualStyleBackColor = true;
            button7.Visible = false;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 207);
            Controls.Add(button7);
            Controls.Add(label3);
            Controls.Add(textBox6);
            Controls.Add(button6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox3;
        private Button button5;
        private Label label1;
        private Label label2;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button6;
        private TextBox textBox6;
        private Label label3;
        private Button button7;
    }
}