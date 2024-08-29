namespace pd_recepcion_ufs_2007
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
            STX = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TRIAL = new TextBox();
            STATUS = new TextBox();
            AMOUNT = new TextBox();
            COUNT = new TextBox();
            ETX = new TextBox();
            label7 = new Label();
            RX = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 7);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 0;
            label1.Text = "Stx";
            // 
            // STX
            // 
            STX.Location = new Point(70, 6);
            STX.Name = "STX";
            STX.Size = new Size(125, 27);
            STX.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(9, 40);
            label2.Name = "label2";
            label2.Size = new Size(39, 22);
            label2.TabIndex = 2;
            label2.Text = "Trial";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 79);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 3;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 108);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 4;
            label4.Text = "Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 148);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 5;
            label5.Text = "Count";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 181);
            label6.Name = "label6";
            label6.Size = new Size(29, 20);
            label6.TabIndex = 6;
            label6.Text = "Etx";
            // 
            // TRIAL
            // 
            TRIAL.Location = new Point(70, 37);
            TRIAL.Name = "TRIAL";
            TRIAL.Size = new Size(125, 27);
            TRIAL.TabIndex = 7;
            // 
            // STATUS
            // 
            STATUS.Location = new Point(70, 75);
            STATUS.Name = "STATUS";
            STATUS.Size = new Size(125, 27);
            STATUS.TabIndex = 8;
            // 
            // AMOUNT
            // 
            AMOUNT.Location = new Point(70, 105);
            AMOUNT.Name = "AMOUNT";
            AMOUNT.Size = new Size(212, 27);
            AMOUNT.TabIndex = 9;
            // 
            // COUNT
            // 
            COUNT.Location = new Point(70, 145);
            COUNT.Name = "COUNT";
            COUNT.Size = new Size(212, 27);
            COUNT.TabIndex = 10;
            // 
            // ETX
            // 
            ETX.Location = new Point(70, 178);
            ETX.Name = "ETX";
            ETX.Size = new Size(125, 27);
            ETX.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 225);
            label7.Name = "label7";
            label7.Size = new Size(25, 20);
            label7.TabIndex = 12;
            label7.Text = "Rx";
            // 
            // RX
            // 
            RX.Location = new Point(69, 218);
            RX.Name = "RX";
            RX.Size = new Size(597, 27);
            RX.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(69, 261);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "Borrado Rx";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(RX);
            Controls.Add(label7);
            Controls.Add(ETX);
            Controls.Add(COUNT);
            Controls.Add(AMOUNT);
            Controls.Add(STATUS);
            Controls.Add(TRIAL);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(STX);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox STX;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox TRIAL;
        private TextBox STATUS;
        private TextBox AMOUNT;
        private TextBox COUNT;
        private TextBox ETX;
        private Label label7;
        private TextBox RX;
        private Button button1;
    }
}
