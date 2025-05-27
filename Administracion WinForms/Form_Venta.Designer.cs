namespace Administracion_WinForms
{
    partial class Form_Venta
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
            DataGridAgregar = new DataGridView();
            DataGridImprimir = new DataGridView();
            button3 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridImprimir).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(730, 349);
            button1.Name = "button1";
            button1.Size = new Size(75, 37);
            button1.TabIndex = 0;
            button1.Text = "Imprimir";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(340, 349);
            button2.Name = "button2";
            button2.Size = new Size(65, 37);
            button2.TabIndex = 1;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DataGridAgregar
            // 
            DataGridAgregar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridAgregar.Location = new Point(15, 60);
            DataGridAgregar.Name = "DataGridAgregar";
            DataGridAgregar.ReadOnly = true;
            DataGridAgregar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridAgregar.Size = new Size(390, 283);
            DataGridAgregar.TabIndex = 2;
            DataGridAgregar.CellMouseDoubleClick += button2_Click;
            // 
            // DataGridImprimir
            // 
            DataGridImprimir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridImprimir.Location = new Point(415, 60);
            DataGridImprimir.Name = "DataGridImprimir";
            DataGridImprimir.Size = new Size(390, 283);
            DataGridImprimir.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(415, 349);
            button3.Name = "button3";
            button3.Size = new Size(65, 37);
            button3.TabIndex = 4;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(329, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 34);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 6;
            label1.Text = "Ariticulo:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Location = new Point(415, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 23);
            panel1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RosyBrown;
            label2.Location = new Point(252, 3);
            label2.Name = "label2";
            label2.Size = new Size(53, 16);
            label2.TabIndex = 0;
            label2.Text = "Total: 0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 9);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 8;
            label3.Text = "Cliente:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(76, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(329, 23);
            comboBox1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(405, 6);
            label4.Name = "label4";
            label4.Size = new Size(12, 15);
            label4.TabIndex = 10;
            label4.Text = "*";
            // 
            // Form_Venta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 395);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(DataGridImprimir);
            Controls.Add(DataGridAgregar);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form_Venta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ABM Vender";
            Load += Form_Venta_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridImprimir).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private DataGridView DataGridAgregar;
        private DataGridView DataGridImprimir;
        private Button button3;
        private TextBox textBox1;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
    }
}