namespace PruebaForms
{
    partial class abmClientes
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Nro. Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 103);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 132);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 3;
            label4.Text = "E-mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 161);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Teléfono";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            textBox1.Text = "1";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(175, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            textBox2.Text = "telefonoCliente";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(175, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            textBox3.Text = "emailCliente";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(175, 100);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 8;
            textBox4.Text = "apellidoCliente";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(175, 71);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 9;
            textBox5.Text = "nombreCliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(69, 9);
            label6.Name = "label6";
            label6.Size = new Size(142, 21);
            label6.TabIndex = 10;
            label6.Text = "Datos de Clientes";
            // 
            // button1
            // 
            button1.Location = new Point(12, 243);
            button1.Name = "button1";
            button1.Size = new Size(77, 32);
            button1.TabIndex = 11;
            button1.Text = "Borrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 281);
            button2.Name = "button2";
            button2.Size = new Size(77, 32);
            button2.TabIndex = 12;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 205);
            button3.Name = "button3";
            button3.Size = new Size(77, 32);
            button3.TabIndex = 13;
            button3.Text = "Nuevo";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(232, 205);
            button4.Name = "button4";
            button4.Size = new Size(29, 27);
            button4.TabIndex = 14;
            button4.Text = ">";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(197, 205);
            button5.Name = "button5";
            button5.Size = new Size(29, 27);
            button5.TabIndex = 15;
            button5.Text = "<";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(208, 264);
            button6.Name = "button6";
            button6.Size = new Size(75, 49);
            button6.TabIndex = 16;
            button6.Text = "Consulta Clientes";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // abmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 322);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "abmClientes";
            Text = "abmClientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}