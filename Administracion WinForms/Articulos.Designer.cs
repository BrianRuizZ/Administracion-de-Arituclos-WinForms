namespace Administracion_WinForms
{
    partial class Articulos
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
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
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
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            listaDeUsuariosToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            parametrosToolStripMenuItem = new ToolStripMenuItem();
            LabelUsuario = new Label();
            groupBox1 = new GroupBox();
            button5 = new Button();
            BuscarBox = new TextBox();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ArtBox.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 350);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += GridDoubleClick;
            // 
            // button2
            // 
            button2.Location = new Point(210, 31);
            button2.Name = "button2";
            button2.Size = new Size(93, 31);
            button2.TabIndex = 2;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(309, 31);
            button3.Name = "button3";
            button3.Size = new Size(93, 31);
            button3.TabIndex = 5;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(111, 31);
            button4.Name = "button4";
            button4.Size = new Size(93, 31);
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
            ArtBox.Location = new Point(12, 108);
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
            buttonAgregarART.Location = new Point(12, 31);
            buttonAgregarART.Name = "buttonAgregarART";
            buttonAgregarART.Size = new Size(93, 31);
            buttonAgregarART.TabIndex = 12;
            buttonAgregarART.Text = "Agregar";
            buttonAgregarART.UseVisualStyleBackColor = true;
            buttonAgregarART.Click += buttonAgregarART_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.GripMargin = new Padding(2);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, parametrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(798, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem5, listaDeUsuariosToolStripMenuItem, toolStripMenuItem4 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(64, 20);
            toolStripMenuItem1.Text = "Usuario";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(190, 22);
            toolStripMenuItem5.Text = "Elegir Usuario";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // listaDeUsuariosToolStripMenuItem
            // 
            listaDeUsuariosToolStripMenuItem.Name = "listaDeUsuariosToolStripMenuItem";
            listaDeUsuariosToolStripMenuItem.Size = new Size(190, 22);
            listaDeUsuariosToolStripMenuItem.Text = "Lista de Usuarios";
            listaDeUsuariosToolStripMenuItem.Click += listaDeUsuariosToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(190, 22);
            toolStripMenuItem4.Text = "Crear nuevo usuario";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // parametrosToolStripMenuItem
            // 
            parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            parametrosToolStripMenuItem.Size = new Size(87, 20);
            parametrosToolStripMenuItem.Text = "Parametros";
            parametrosToolStripMenuItem.Click += parametrosToolStripMenuItem_Click;
            // 
            // LabelUsuario
            // 
            LabelUsuario.AutoSize = true;
            LabelUsuario.BackColor = SystemColors.ButtonFace;
            LabelUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LabelUsuario.ForeColor = SystemColors.InactiveCaptionText;
            LabelUsuario.Location = new Point(6, 25);
            LabelUsuario.Name = "LabelUsuario";
            LabelUsuario.Size = new Size(0, 17);
            LabelUsuario.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LabelUsuario);
            groupBox1.Location = new Point(536, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(202, 51);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuario";
            // 
            // button5
            // 
            button5.Location = new Point(731, 36);
            button5.Name = "button5";
            button5.Size = new Size(57, 44);
            button5.TabIndex = 17;
            button5.Text = "Cerrar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // BuscarBox
            // 
            BuscarBox.Location = new Point(12, 79);
            BuscarBox.Name = "BuscarBox";
            BuscarBox.Size = new Size(322, 23);
            BuscarBox.TabIndex = 21;
            // 
            // button6
            // 
            button6.Location = new Point(334, 78);
            button6.Name = "button6";
            button6.Size = new Size(68, 25);
            button6.TabIndex = 23;
            button6.Text = "Buscar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Articulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 450);
            Controls.Add(button6);
            Controls.Add(BuscarBox);
            Controls.Add(button5);
            Controls.Add(groupBox1);
            Controls.Add(buttonAgregarART);
            Controls.Add(ArtBox);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Articulos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador De Articulos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ArtBox.ResumeLayout(false);
            ArtBox.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Button button4;
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem parametrosToolStripMenuItem;
        private ToolStripMenuItem listaDeUsuariosToolStripMenuItem;
        private Label LabelUsuario;
        private GroupBox groupBox1;
        private Button button5;
        private TextBox BuscarBox;
        private Button button6;
    }
}
