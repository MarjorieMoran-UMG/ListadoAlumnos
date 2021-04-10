
namespace ListadoAlumnos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCargarArchivo = new System.Windows.Forms.Button();
            this.listBoxCorrelativo = new System.Windows.Forms.ListBox();
            this.listBoxNombres = new System.Windows.Forms.ListBox();
            this.listBoxParcial1 = new System.Windows.Forms.ListBox();
            this.buttonNombres = new System.Windows.Forms.Button();
            this.buttonParcial1 = new System.Windows.Forms.Button();
            this.buttonParcial2 = new System.Windows.Forms.Button();
            this.listBoxParcial2 = new System.Windows.Forms.ListBox();
            this.buttonpParcial3 = new System.Windows.Forms.Button();
            this.listBoxParcial3 = new System.Windows.Forms.ListBox();
            this.buttonCorrelativo = new System.Windows.Forms.Button();
            this.buttonPromedioGeneral = new System.Windows.Forms.Button();
            this.buttonNotaMasAlta = new System.Windows.Forms.Button();
            this.listBoxPromedioGeneral = new System.Windows.Forms.ListBox();
            this.buttonNotaMasBaja = new System.Windows.Forms.Button();
            this.listBoxNotaMasAlta = new System.Windows.Forms.ListBox();
            this.listBoxNotaMasBaja = new System.Windows.Forms.ListBox();
            this.buttonPromedioAlumno = new System.Windows.Forms.Button();
            this.listBoxPromedioAlumno = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonCargarArchivo
            // 
            this.buttonCargarArchivo.Location = new System.Drawing.Point(9, 424);
            this.buttonCargarArchivo.Name = "buttonCargarArchivo";
            this.buttonCargarArchivo.Size = new System.Drawing.Size(142, 63);
            this.buttonCargarArchivo.TabIndex = 0;
            this.buttonCargarArchivo.Text = "Cargar Archivo";
            this.buttonCargarArchivo.UseVisualStyleBackColor = true;
            this.buttonCargarArchivo.Click += new System.EventHandler(this.buttonCargarArchivo_Click);
            // 
            // listBoxCorrelativo
            // 
            this.listBoxCorrelativo.FormattingEnabled = true;
            this.listBoxCorrelativo.Location = new System.Drawing.Point(12, 36);
            this.listBoxCorrelativo.Name = "listBoxCorrelativo";
            this.listBoxCorrelativo.Size = new System.Drawing.Size(101, 264);
            this.listBoxCorrelativo.TabIndex = 1;
            // 
            // listBoxNombres
            // 
            this.listBoxNombres.FormattingEnabled = true;
            this.listBoxNombres.Location = new System.Drawing.Point(119, 36);
            this.listBoxNombres.Name = "listBoxNombres";
            this.listBoxNombres.Size = new System.Drawing.Size(369, 264);
            this.listBoxNombres.TabIndex = 2;
            // 
            // listBoxParcial1
            // 
            this.listBoxParcial1.FormattingEnabled = true;
            this.listBoxParcial1.Location = new System.Drawing.Point(494, 37);
            this.listBoxParcial1.Name = "listBoxParcial1";
            this.listBoxParcial1.Size = new System.Drawing.Size(101, 264);
            this.listBoxParcial1.TabIndex = 3;
            // 
            // buttonNombres
            // 
            this.buttonNombres.Location = new System.Drawing.Point(119, 2);
            this.buttonNombres.Name = "buttonNombres";
            this.buttonNombres.Size = new System.Drawing.Size(369, 33);
            this.buttonNombres.TabIndex = 4;
            this.buttonNombres.Text = "Nombres Alumnos";
            this.buttonNombres.UseVisualStyleBackColor = true;
            // 
            // buttonParcial1
            // 
            this.buttonParcial1.Location = new System.Drawing.Point(494, 2);
            this.buttonParcial1.Name = "buttonParcial1";
            this.buttonParcial1.Size = new System.Drawing.Size(101, 33);
            this.buttonParcial1.TabIndex = 5;
            this.buttonParcial1.Text = "Parcial 1";
            this.buttonParcial1.UseVisualStyleBackColor = true;
            // 
            // buttonParcial2
            // 
            this.buttonParcial2.Location = new System.Drawing.Point(601, 2);
            this.buttonParcial2.Name = "buttonParcial2";
            this.buttonParcial2.Size = new System.Drawing.Size(101, 33);
            this.buttonParcial2.TabIndex = 7;
            this.buttonParcial2.Text = "Parcial 2";
            this.buttonParcial2.UseVisualStyleBackColor = true;
            // 
            // listBoxParcial2
            // 
            this.listBoxParcial2.FormattingEnabled = true;
            this.listBoxParcial2.Location = new System.Drawing.Point(601, 37);
            this.listBoxParcial2.Name = "listBoxParcial2";
            this.listBoxParcial2.Size = new System.Drawing.Size(101, 264);
            this.listBoxParcial2.TabIndex = 6;
            // 
            // buttonpParcial3
            // 
            this.buttonpParcial3.Location = new System.Drawing.Point(708, 2);
            this.buttonpParcial3.Name = "buttonpParcial3";
            this.buttonpParcial3.Size = new System.Drawing.Size(101, 33);
            this.buttonpParcial3.TabIndex = 9;
            this.buttonpParcial3.Text = "Parcial 3";
            this.buttonpParcial3.UseVisualStyleBackColor = true;
            // 
            // listBoxParcial3
            // 
            this.listBoxParcial3.FormattingEnabled = true;
            this.listBoxParcial3.Location = new System.Drawing.Point(708, 37);
            this.listBoxParcial3.Name = "listBoxParcial3";
            this.listBoxParcial3.Size = new System.Drawing.Size(101, 264);
            this.listBoxParcial3.TabIndex = 8;
            // 
            // buttonCorrelativo
            // 
            this.buttonCorrelativo.Location = new System.Drawing.Point(12, 2);
            this.buttonCorrelativo.Name = "buttonCorrelativo";
            this.buttonCorrelativo.Size = new System.Drawing.Size(101, 33);
            this.buttonCorrelativo.TabIndex = 10;
            this.buttonCorrelativo.Text = "Correlativo";
            this.buttonCorrelativo.UseVisualStyleBackColor = true;
            // 
            // buttonPromedioGeneral
            // 
            this.buttonPromedioGeneral.Location = new System.Drawing.Point(537, 334);
            this.buttonPromedioGeneral.Name = "buttonPromedioGeneral";
            this.buttonPromedioGeneral.Size = new System.Drawing.Size(101, 33);
            this.buttonPromedioGeneral.TabIndex = 11;
            this.buttonPromedioGeneral.Text = "Promedio General";
            this.buttonPromedioGeneral.UseVisualStyleBackColor = true;
            // 
            // buttonNotaMasAlta
            // 
            this.buttonNotaMasAlta.Location = new System.Drawing.Point(12, 333);
            this.buttonNotaMasAlta.Name = "buttonNotaMasAlta";
            this.buttonNotaMasAlta.Size = new System.Drawing.Size(101, 33);
            this.buttonNotaMasAlta.TabIndex = 12;
            this.buttonNotaMasAlta.Text = "Nota Más Alta";
            this.buttonNotaMasAlta.UseVisualStyleBackColor = true;
            // 
            // listBoxPromedioGeneral
            // 
            this.listBoxPromedioGeneral.FormattingEnabled = true;
            this.listBoxPromedioGeneral.Location = new System.Drawing.Point(644, 336);
            this.listBoxPromedioGeneral.Name = "listBoxPromedioGeneral";
            this.listBoxPromedioGeneral.Size = new System.Drawing.Size(101, 30);
            this.listBoxPromedioGeneral.TabIndex = 13;
            // 
            // buttonNotaMasBaja
            // 
            this.buttonNotaMasBaja.Location = new System.Drawing.Point(12, 372);
            this.buttonNotaMasBaja.Name = "buttonNotaMasBaja";
            this.buttonNotaMasBaja.Size = new System.Drawing.Size(101, 33);
            this.buttonNotaMasBaja.TabIndex = 14;
            this.buttonNotaMasBaja.Text = "Nota Más Baja";
            this.buttonNotaMasBaja.UseVisualStyleBackColor = true;
            // 
            // listBoxNotaMasAlta
            // 
            this.listBoxNotaMasAlta.FormattingEnabled = true;
            this.listBoxNotaMasAlta.Location = new System.Drawing.Point(119, 335);
            this.listBoxNotaMasAlta.Name = "listBoxNotaMasAlta";
            this.listBoxNotaMasAlta.Size = new System.Drawing.Size(369, 30);
            this.listBoxNotaMasAlta.TabIndex = 15;
            // 
            // listBoxNotaMasBaja
            // 
            this.listBoxNotaMasBaja.FormattingEnabled = true;
            this.listBoxNotaMasBaja.Location = new System.Drawing.Point(119, 374);
            this.listBoxNotaMasBaja.Name = "listBoxNotaMasBaja";
            this.listBoxNotaMasBaja.Size = new System.Drawing.Size(369, 30);
            this.listBoxNotaMasBaja.TabIndex = 16;
            // 
            // buttonPromedioAlumno
            // 
            this.buttonPromedioAlumno.Location = new System.Drawing.Point(815, 2);
            this.buttonPromedioAlumno.Name = "buttonPromedioAlumno";
            this.buttonPromedioAlumno.Size = new System.Drawing.Size(101, 33);
            this.buttonPromedioAlumno.TabIndex = 17;
            this.buttonPromedioAlumno.Text = "Promedio Alumno";
            this.buttonPromedioAlumno.UseVisualStyleBackColor = true;
            // 
            // listBoxPromedioAlumno
            // 
            this.listBoxPromedioAlumno.FormattingEnabled = true;
            this.listBoxPromedioAlumno.Location = new System.Drawing.Point(815, 37);
            this.listBoxPromedioAlumno.Name = "listBoxPromedioAlumno";
            this.listBoxPromedioAlumno.Size = new System.Drawing.Size(101, 264);
            this.listBoxPromedioAlumno.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 496);
            this.Controls.Add(this.listBoxPromedioAlumno);
            this.Controls.Add(this.buttonPromedioAlumno);
            this.Controls.Add(this.listBoxNotaMasBaja);
            this.Controls.Add(this.listBoxNotaMasAlta);
            this.Controls.Add(this.buttonNotaMasBaja);
            this.Controls.Add(this.listBoxPromedioGeneral);
            this.Controls.Add(this.buttonNotaMasAlta);
            this.Controls.Add(this.buttonPromedioGeneral);
            this.Controls.Add(this.buttonCorrelativo);
            this.Controls.Add(this.buttonpParcial3);
            this.Controls.Add(this.listBoxParcial3);
            this.Controls.Add(this.buttonParcial2);
            this.Controls.Add(this.listBoxParcial2);
            this.Controls.Add(this.buttonParcial1);
            this.Controls.Add(this.buttonNombres);
            this.Controls.Add(this.listBoxParcial1);
            this.Controls.Add(this.listBoxNombres);
            this.Controls.Add(this.listBoxCorrelativo);
            this.Controls.Add(this.buttonCargarArchivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCargarArchivo;
        private System.Windows.Forms.ListBox listBoxCorrelativo;
        private System.Windows.Forms.ListBox listBoxNombres;
        private System.Windows.Forms.ListBox listBoxParcial1;
        private System.Windows.Forms.Button buttonNombres;
        private System.Windows.Forms.Button buttonParcial1;
        private System.Windows.Forms.Button buttonParcial2;
        private System.Windows.Forms.ListBox listBoxParcial2;
        private System.Windows.Forms.Button buttonpParcial3;
        private System.Windows.Forms.ListBox listBoxParcial3;
        private System.Windows.Forms.Button buttonCorrelativo;
        private System.Windows.Forms.Button buttonPromedioGeneral;
        private System.Windows.Forms.Button buttonNotaMasAlta;
        private System.Windows.Forms.ListBox listBoxPromedioGeneral;
        private System.Windows.Forms.Button buttonNotaMasBaja;
        private System.Windows.Forms.ListBox listBoxNotaMasAlta;
        private System.Windows.Forms.ListBox listBoxNotaMasBaja;
        private System.Windows.Forms.Button buttonPromedioAlumno;
        private System.Windows.Forms.ListBox listBoxPromedioAlumno;
    }
}

