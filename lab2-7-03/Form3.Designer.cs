namespace lab2_7_03
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
            listView1 = new ListView();
            label3 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            KOMPUTER = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(109, 93);
            listView1.Name = "listView1";
            listView1.Size = new Size(250, 209);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(414, 104);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 4;
            label3.Text = "Cena: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(460, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(566, 104);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 6;
            label1.Text = "zl";
            // 
            // KOMPUTER
            // 
            KOMPUTER.Location = new Point(414, 390);
            KOMPUTER.Name = "KOMPUTER";
            KOMPUTER.Size = new Size(177, 38);
            KOMPUTER.TabIndex = 11;
            KOMPUTER.Text = "WYZJDZ";
            KOMPUTER.UseVisualStyleBackColor = true;
            KOMPUTER.Click += KOMPUTER_Click;
            // 
            // button1
            // 
            button1.Location = new Point(600, 391);
            button1.Name = "button1";
            button1.Size = new Size(164, 37);
            button1.TabIndex = 12;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(KOMPUTER);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(listView1);
            Name = "Form3";
            Text = "MONITOR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label3;
        private TextBox textBox1;
        private Label label1;
        private Button KOMPUTER;
        private Button button1;
    }
}