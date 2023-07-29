namespace Inscripcion2
{
    partial class FBusquedaUsuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BAceptar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BAnterior = new System.Windows.Forms.Button();
            this.BSiguiente = new System.Windows.Forms.Button();
            this.BUltimo = new System.Windows.Forms.Button();
            this.BPrimero = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BBuscarDato = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVDatos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 47);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Busqueda de Usuario";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.BAceptar);
            this.panel2.Controls.Add(this.BCancelar);
            this.panel2.Controls.Add(this.BAnterior);
            this.panel2.Controls.Add(this.BSiguiente);
            this.panel2.Controls.Add(this.BUltimo);
            this.panel2.Controls.Add(this.BPrimero);
            this.panel2.Location = new System.Drawing.Point(0, 492);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 58);
            this.panel2.TabIndex = 1;
            // 
            // BAceptar
            // 
            this.BAceptar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAceptar.Location = new System.Drawing.Point(814, 12);
            this.BAceptar.Name = "BAceptar";
            this.BAceptar.Size = new System.Drawing.Size(68, 30);
            this.BAceptar.TabIndex = 21;
            this.BAceptar.Text = "Aceptar";
            this.BAceptar.UseVisualStyleBackColor = false;
            this.BAceptar.Click += new System.EventHandler(this.BAceptar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.Location = new System.Drawing.Point(717, 12);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(73, 30);
            this.BCancelar.TabIndex = 22;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BAnterior
            // 
            this.BAnterior.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAnterior.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BAnterior.Location = new System.Drawing.Point(119, 12);
            this.BAnterior.Name = "BAnterior";
            this.BAnterior.Size = new System.Drawing.Size(67, 30);
            this.BAnterior.TabIndex = 20;
            this.BAnterior.Text = "Anterior";
            this.BAnterior.UseVisualStyleBackColor = false;
            this.BAnterior.Click += new System.EventHandler(this.BAnterior_Click);
            // 
            // BSiguiente
            // 
            this.BSiguiente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSiguiente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BSiguiente.Location = new System.Drawing.Point(205, 12);
            this.BSiguiente.Name = "BSiguiente";
            this.BSiguiente.Size = new System.Drawing.Size(81, 30);
            this.BSiguiente.TabIndex = 19;
            this.BSiguiente.Text = "Siguiente";
            this.BSiguiente.UseVisualStyleBackColor = false;
            this.BSiguiente.Click += new System.EventHandler(this.BSiguiente_Click);
            // 
            // BUltimo
            // 
            this.BUltimo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUltimo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BUltimo.Location = new System.Drawing.Point(309, 12);
            this.BUltimo.Name = "BUltimo";
            this.BUltimo.Size = new System.Drawing.Size(61, 30);
            this.BUltimo.TabIndex = 17;
            this.BUltimo.Text = "Ultimo";
            this.BUltimo.UseVisualStyleBackColor = false;
            this.BUltimo.Click += new System.EventHandler(this.BUltimo_Click);
            // 
            // BPrimero
            // 
            this.BPrimero.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BPrimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPrimero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BPrimero.Location = new System.Drawing.Point(37, 12);
            this.BPrimero.Name = "BPrimero";
            this.BPrimero.Size = new System.Drawing.Size(66, 30);
            this.BPrimero.TabIndex = 18;
            this.BPrimero.Text = "Primero";
            this.BPrimero.UseVisualStyleBackColor = false;
            this.BPrimero.Click += new System.EventHandler(this.BPrimero_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.BBuscarDato);
            this.panel3.Controls.Add(this.tbBuscar);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(894, 41);
            this.panel3.TabIndex = 2;
            // 
            // BBuscarDato
            // 
            this.BBuscarDato.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BBuscarDato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarDato.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BBuscarDato.Location = new System.Drawing.Point(563, 5);
            this.BBuscarDato.Name = "BBuscarDato";
            this.BBuscarDato.Size = new System.Drawing.Size(61, 26);
            this.BBuscarDato.TabIndex = 10;
            this.BBuscarDato.Text = "Buscar";
            this.BBuscarDato.UseVisualStyleBackColor = false;
            this.BBuscarDato.Click += new System.EventHandler(this.BBuscarDato_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(287, 9);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(270, 20);
            this.tbBuscar.TabIndex = 9;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(106, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Digite el dato a buscar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DGVDatos
            // 
            this.DGVDatos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDatos.Location = new System.Drawing.Point(51, 116);
            this.DGVDatos.Name = "DGVDatos";
            this.DGVDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDatos.Size = new System.Drawing.Size(783, 334);
            this.DGVDatos.TabIndex = 3;
            this.DGVDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDatos_CellDoubleClick);
            this.DGVDatos.CurrentCellChanged += new System.EventHandler(this.DGVDatos_CurrentCellChanged);
            // 
            // FBusquedaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 546);
            this.Controls.Add(this.DGVDatos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FBusquedaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FBusquedaUsuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FBusquedaUsuario_FormClosing);
            this.Load += new System.EventHandler(this.FBusquedaUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BBuscarDato;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVDatos;
        private System.Windows.Forms.Button BAceptar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BAnterior;
        private System.Windows.Forms.Button BSiguiente;
        private System.Windows.Forms.Button BUltimo;
        private System.Windows.Forms.Button BPrimero;
        private System.Windows.Forms.Label label1;
    }
}