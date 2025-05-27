namespace Administracion_WinForms
{
    partial class Form_Usuario
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
            groupBox1 = new GroupBox();
            ErrorConfContraseña = new Label();
            ErrorContraseña = new Label();
            ErrorNombre = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(ErrorConfContraseña);
            groupBox1.Controls.Add(ErrorContraseña);
            groupBox1.Controls.Add(ErrorNombre);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(409, 211);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crear Usuario";
            // 
            // ErrorConfContraseña
            // 
            ErrorConfContraseña.AutoSize = true;
            ErrorConfContraseña.ForeColor = Color.FromArgb(192, 0, 0);
            ErrorConfContraseña.Location = new Point(153, 135);
            ErrorConfContraseña.Name = "ErrorConfContraseña";
            ErrorConfContraseña.Size = new Size(0, 15);
            ErrorConfContraseña.TabIndex = 10;
            // 
            // ErrorContraseña
            // 
            ErrorContraseña.AutoSize = true;
            ErrorContraseña.ForeColor = Color.FromArgb(192, 0, 0);
            ErrorContraseña.Location = new Point(153, 95);
            ErrorContraseña.Name = "ErrorContraseña";
            ErrorContraseña.Size = new Size(0, 15);
            ErrorContraseña.TabIndex = 9;
            // 
            // ErrorNombre
            // 
            ErrorNombre.AutoSize = true;
            ErrorNombre.ForeColor = Color.FromArgb(192, 0, 0);
            ErrorNombre.Location = new Point(93, 54);
            ErrorNombre.Name = "ErrorNombre";
            ErrorNombre.Size = new Size(0, 15);
            ErrorNombre.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.ForeColor = Color.White;
            button1.Location = new Point(150, 150);
            button1.Name = "button1";
            button1.Size = new Size(90, 39);
            button1.TabIndex = 7;
            button1.Text = "Crear Usuario";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(150, 110);
            textBox3.MaxLength = 60;
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(233, 23);
            textBox3.TabIndex = 6;
            textBox3.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 113);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 5;
            label3.Text = "Confirmar contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 73);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 32);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(90, 70);
            textBox2.MaxLength = 60;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(293, 23);
            textBox2.TabIndex = 1;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 29);
            textBox1.MaxLength = 25;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 23);
            textBox1.TabIndex = 0;
            // 
            // Form_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 221);
            Controls.Add(groupBox1);
            Name = "Form_Usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ABM Usuario";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBox3;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label ErrorNombre;
        private Label ErrorConfContraseña;
        private Label ErrorContraseña;
    }
}