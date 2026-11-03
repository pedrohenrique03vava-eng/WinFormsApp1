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
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            labelResultado = new Label();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            textBoxNumero01 = new TextBox();
            textBoxNumero02 = new TextBox();
            label5 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 234);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 78);
            label2.Name = "label2";
            label2.Size = new Size(138, 15);
            label2.TabIndex = 3;
            label2.Text = "Insira o primeiro numero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 155);
            label3.Name = "label3";
            label3.Size = new Size(142, 15);
            label3.TabIndex = 4;
            label3.Text = "Insira o segundo  numero";
            // 
            // button1
            // 
            button1.Location = new Point(239, 95);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Somar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(239, 310);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 15);
            labelResultado.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 28);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 7;
            label4.Text = "Calculadora";
            // 
            // button2
            // 
            button2.Location = new Point(484, 96);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "Subtrair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(366, 96);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 21;
            button3.Text = "Multiplicar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBoxNumero01
            // 
            textBoxNumero01.Location = new Point(31, 96);
            textBoxNumero01.Name = "textBoxNumero01";
            textBoxNumero01.Size = new Size(148, 23);
            textBoxNumero01.TabIndex = 22;
            // 
            // textBoxNumero02
            // 
            textBoxNumero02.Location = new Point(31, 191);
            textBoxNumero02.Name = "textBoxNumero02";
            textBoxNumero02.Size = new Size(148, 23);
            textBoxNumero02.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 234);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 24;
            label5.Text = "Resultado:";
            // 
            // button4
            // 
            button4.Location = new Point(484, 147);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 25;
            button4.Text = "Divisão";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(366, 147);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 26;
            button5.Text = "Logaritimo";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(239, 147);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 27;
            button6.Text = "Exponenciação";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 637);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(textBoxNumero02);
            Controls.Add(textBoxNumero01);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(labelResultado);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label labelResultado;
        private Label label4;
        private Button button2;
        private Button button3;
        private TextBox textBoxNumero01;
        private TextBox textBoxNumero02;
        private Label label5;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
