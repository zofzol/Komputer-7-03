namespace lab2_7_03
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
            KOMPUTER = new Button();
            MONITOR = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // KOMPUTER
            // 
            KOMPUTER.Location = new Point(34, 140);
            KOMPUTER.Name = "KOMPUTER";
            KOMPUTER.Size = new Size(191, 178);
            KOMPUTER.TabIndex = 0;
            KOMPUTER.Text = "KOMPUTER";
            KOMPUTER.UseVisualStyleBackColor = true;
            KOMPUTER.Click += Komputer_Click;
            // 
            // MONITOR
            // 
            MONITOR.Location = new Point(291, 140);
            MONITOR.Name = "MONITOR";
            MONITOR.Size = new Size(186, 178);
            MONITOR.TabIndex = 1;
            MONITOR.Text = "MONITOR";
            MONITOR.UseVisualStyleBackColor = true;
            MONITOR.Click += Monitor_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(546, 295);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(550, 279);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 3;
            label1.Text = "Cana zl";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(MONITOR);
            Controls.Add(KOMPUTER);
            Name = "Form1";
            Text = "BAZA";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button KOMPUTER;
        private Button MONITOR;
        private TextBox textBox1;
        private Label label1;
    }
}
