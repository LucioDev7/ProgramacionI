namespace CiclismoDesktopPorCodigo.Views.Linq
{
    partial class PruebasLinqView
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
            dataGridResultados = new DataGridView();
            btnPruebaArray = new Button();
            btnSqlLinq = new Button();
            btnXMLlinq = new Button();
            btnJsonLinq = new Button();
            btnSelectLinq = new Button();
            btnSelectManyLinq = new Button();
            btnWhereLinq = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridResultados).BeginInit();
            SuspendLayout();
            // 
            // dataGridResultados
            // 
            dataGridResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridResultados.Location = new Point(12, 12);
            dataGridResultados.Name = "dataGridResultados";
            dataGridResultados.RowHeadersWidth = 51;
            dataGridResultados.Size = new Size(533, 355);
            dataGridResultados.TabIndex = 0;
            // 
            // btnPruebaArray
            // 
            btnPruebaArray.Location = new Point(600, 12);
            btnPruebaArray.Name = "btnPruebaArray";
            btnPruebaArray.Size = new Size(141, 29);
            btnPruebaArray.TabIndex = 1;
            btnPruebaArray.Text = "Prueba Array";
            btnPruebaArray.UseVisualStyleBackColor = true;
            btnPruebaArray.Click += btnPruebaArray_Click;
            // 
            // btnSqlLinq
            // 
            btnSqlLinq.Location = new Point(600, 71);
            btnSqlLinq.Name = "btnSqlLinq";
            btnSqlLinq.Size = new Size(141, 29);
            btnSqlLinq.TabIndex = 2;
            btnSqlLinq.Text = "Prueba SQL";
            btnSqlLinq.UseVisualStyleBackColor = true;
            btnSqlLinq.Click += btnSqlLinq_Click;
            // 
            // btnXMLlinq
            // 
            btnXMLlinq.Location = new Point(600, 131);
            btnXMLlinq.Name = "btnXMLlinq";
            btnXMLlinq.Size = new Size(141, 29);
            btnXMLlinq.TabIndex = 3;
            btnXMLlinq.Text = "Prueba XML";
            btnXMLlinq.UseVisualStyleBackColor = true;
            btnXMLlinq.Click += btnXMLlinq_Click;
            // 
            // btnJsonLinq
            // 
            btnJsonLinq.Location = new Point(600, 189);
            btnJsonLinq.Name = "btnJsonLinq";
            btnJsonLinq.Size = new Size(141, 29);
            btnJsonLinq.TabIndex = 4;
            btnJsonLinq.Text = "Prueba JSON";
            btnJsonLinq.UseVisualStyleBackColor = true;
            btnJsonLinq.Click += btnJsonLinq_Click;
            // 
            // btnSelectLinq
            // 
            btnSelectLinq.Location = new Point(12, 373);
            btnSelectLinq.Name = "btnSelectLinq";
            btnSelectLinq.Size = new Size(141, 29);
            btnSelectLinq.TabIndex = 5;
            btnSelectLinq.Text = "Prueba Select";
            btnSelectLinq.UseVisualStyleBackColor = true;
            btnSelectLinq.Click += btnSelectLinq_Click;
            // 
            // btnSelectManyLinq
            // 
            btnSelectManyLinq.Location = new Point(12, 409);
            btnSelectManyLinq.Name = "btnSelectManyLinq";
            btnSelectManyLinq.Size = new Size(163, 29);
            btnSelectManyLinq.TabIndex = 6;
            btnSelectManyLinq.Text = "Prueba SelectMany";
            btnSelectManyLinq.UseVisualStyleBackColor = true;
            btnSelectManyLinq.Click += btnSelectManyLinq_Click;
            // 
            // btnWhereLinq
            // 
            btnWhereLinq.Location = new Point(177, 373);
            btnWhereLinq.Name = "btnWhereLinq";
            btnWhereLinq.Size = new Size(141, 29);
            btnWhereLinq.TabIndex = 7;
            btnWhereLinq.Text = "Prueba Where";
            btnWhereLinq.UseVisualStyleBackColor = true;
            btnWhereLinq.Click += btnWhereLinq_Click;
            // 
            // PruebasLinqView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnWhereLinq);
            Controls.Add(btnSelectManyLinq);
            Controls.Add(btnSelectLinq);
            Controls.Add(btnJsonLinq);
            Controls.Add(btnXMLlinq);
            Controls.Add(btnSqlLinq);
            Controls.Add(btnPruebaArray);
            Controls.Add(dataGridResultados);
            Name = "PruebasLinqView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PruebasLinqView";
            ((System.ComponentModel.ISupportInitialize)dataGridResultados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridResultados;
        private Button btnPruebaArray;
        private Button btnSqlLinq;
        private Button btnXMLlinq;
        private Button btnJsonLinq;
        private Button btnSelectLinq;
        private Button btnSelectManyLinq;
        private Button btnWhereLinq;
    }
}