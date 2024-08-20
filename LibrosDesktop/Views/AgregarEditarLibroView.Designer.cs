namespace LibrosDesktop.Views
{
    partial class AgregarEditarLibroView
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
            txtNombre = new TextBox();
            txtAutor = new TextBox();
            label2 = new Label();
            txtEditorial = new TextBox();
            label3 = new Label();
            txtPortadaUrl = new TextBox();
            label4 = new Label();
            txtSinopsis = new TextBox();
            label5 = new Label();
            label6 = new Label();
            numericPaginas = new NumericUpDown();
            txtGenero = new TextBox();
            label7 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericPaginas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 50);
            label1.Name = "label1";
            label1.Size = new Size(64, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(117, 50);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(386, 25);
            txtNombre.TabIndex = 1;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(117, 93);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(386, 25);
            txtAutor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 93);
            label2.Name = "label2";
            label2.Size = new Size(46, 17);
            label2.TabIndex = 2;
            label2.Text = "Autor:";
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(117, 135);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(386, 25);
            txtEditorial.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 135);
            label3.Name = "label3";
            label3.Size = new Size(64, 17);
            label3.TabIndex = 4;
            label3.Text = "Editorial:";
            // 
            // txtPortadaUrl
            // 
            txtPortadaUrl.Location = new Point(117, 222);
            txtPortadaUrl.Name = "txtPortadaUrl";
            txtPortadaUrl.Size = new Size(386, 25);
            txtPortadaUrl.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 222);
            label4.Name = "label4";
            label4.Size = new Size(85, 17);
            label4.TabIndex = 6;
            label4.Text = "Portada Url:";
            // 
            // txtSinopsis
            // 
            txtSinopsis.Location = new Point(117, 309);
            txtSinopsis.Multiline = true;
            txtSinopsis.Name = "txtSinopsis";
            txtSinopsis.Size = new Size(386, 131);
            txtSinopsis.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 312);
            label5.Name = "label5";
            label5.Size = new Size(68, 17);
            label5.TabIndex = 8;
            label5.Text = "Sinopsis:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 265);
            label6.Name = "label6";
            label6.Size = new Size(65, 17);
            label6.TabIndex = 10;
            label6.Text = "Paginás:";
            // 
            // numericPaginas
            // 
            numericPaginas.Location = new Point(117, 265);
            numericPaginas.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericPaginas.Name = "numericPaginas";
            numericPaginas.Size = new Size(386, 25);
            numericPaginas.TabIndex = 12;
            numericPaginas.TextAlign = HorizontalAlignment.Right;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(117, 178);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(386, 25);
            txtGenero.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 181);
            label7.Name = "label7";
            label7.Size = new Size(60, 17);
            label7.TabIndex = 13;
            label7.Text = "Genero:";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top;
            btnGuardar.BackColor = Color.Peru;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(160, 489);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "&Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top;
            btnCancelar.BackColor = Color.Peru;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(282, 489);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AgregarEditarLibroView
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(515, 541);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtGenero);
            Controls.Add(label7);
            Controls.Add(numericPaginas);
            Controls.Add(label6);
            Controls.Add(txtSinopsis);
            Controls.Add(label5);
            Controls.Add(txtPortadaUrl);
            Controls.Add(label4);
            Controls.Add(txtEditorial);
            Controls.Add(label3);
            Controls.Add(txtAutor);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AgregarEditarLibroView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar/Editar Libro";
            ((System.ComponentModel.ISupportInitialize)numericPaginas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtAutor;
        private Label label2;
        private TextBox txtEditorial;
        private Label label3;
        private TextBox txtPortadaUrl;
        private Label label4;
        private TextBox txtSinopsis;
        private Label label5;
        private Label label6;
        private NumericUpDown numericPaginas;
        private TextBox txtGenero;
        private Label label7;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}