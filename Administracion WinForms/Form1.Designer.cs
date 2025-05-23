namespace Administracion_WinForms
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
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ArtBox = new GroupBox();
            buttonEditar = new Button();
            ButtonCancelar = new Button();
            button1 = new Button();
            textStock = new TextBox();
            label4 = new Label();
            textPrecio = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textNombre = new TextBox();
            buttonAgregarART = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ArtBox.SuspendLayout();
            SuspendLayout();
            // 
            // bindingSource1
            // 
            bindingSource1.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 407);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += GridDoubleClick;
            // 
            // button2
            // 
            button2.Location = new Point(255, 8);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(93, 8);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(174, 8);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 6;
            button4.Text = "Editar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ArtBox
            // 
            ArtBox.Controls.Add(buttonEditar);
            ArtBox.Controls.Add(ButtonCancelar);
            ArtBox.Controls.Add(button1);
            ArtBox.Controls.Add(textStock);
            ArtBox.Controls.Add(label4);
            ArtBox.Controls.Add(textPrecio);
            ArtBox.Controls.Add(label5);
            ArtBox.Controls.Add(label6);
            ArtBox.Controls.Add(textNombre);
            ArtBox.FlatStyle = FlatStyle.Flat;
            ArtBox.Location = new Point(12, 37);
            ArtBox.Name = "ArtBox";
            ArtBox.Size = new Size(776, 91);
            ArtBox.TabIndex = 11;
            ArtBox.TabStop = false;
            ArtBox.Text = "Articulo";
            ArtBox.Visible = false;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(695, 58);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 20;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Visible = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Location = new Point(614, 58);
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(75, 23);
            ButtonCancelar.TabIndex = 19;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.UseVisualStyleBackColor = true;
            ButtonCancelar.Click += ButtonCancelar_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(695, 58);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ButtonAgregar_Click;
            // 
            // textStock
            // 
            textStock.Location = new Point(663, 29);
            textStock.Name = "textStock";
            textStock.Size = new Size(107, 23);
            textStock.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(618, 32);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 16;
            label4.Text = "Stock:";
            // 
            // textPrecio
            // 
            textPrecio.Location = new Point(476, 29);
            textPrecio.Name = "textPrecio";
            textPrecio.Size = new Size(136, 23);
            textPrecio.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(427, 32);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 14;
            label5.Text = "Precio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 32);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 13;
            label6.Text = "Nombre:";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(71, 29);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(350, 23);
            textNombre.TabIndex = 12;
            // 
            // buttonAgregarART
            // 
            buttonAgregarART.Location = new Point(12, 8);
            buttonAgregarART.Name = "buttonAgregarART";
            buttonAgregarART.Size = new Size(75, 23);
            buttonAgregarART.TabIndex = 12;
            buttonAgregarART.Text = "Agregar";
            buttonAgregarART.UseVisualStyleBackColor = true;
            buttonAgregarART.Click += buttonAgregarART_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAgregarART);
            Controls.Add(ArtBox);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "ABM Articulos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ArtBox.ResumeLayout(false);
            ArtBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource bindingSource1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Button button4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private GroupBox ArtBox;
        private TextBox textStock;
        private Label label4;
        private TextBox textPrecio;
        private Label label5;
        private Label label6;
        private TextBox textNombre;
        private Button buttonAgregar;
        private Button button1;
        private Button buttonAgregarART;
        private Button ButtonCancelar;
        private Button buttonEditar;
    }
}
