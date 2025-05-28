namespace ordinario
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
            this.listaautos = new System.Windows.Forms.DataGridView();
            this.Most = new System.Windows.Forms.Button();
            this.Exp = new System.Windows.Forms.Button();
            this.Imp = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.Elim = new System.Windows.Forms.Button();
            this.Act = new System.Windows.Forms.Button();
            this.limp = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.marca = new System.Windows.Forms.TextBox();
            this.modelo = new System.Windows.Forms.TextBox();
            this.anio = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.estado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Suma = new System.Windows.Forms.Button();
            this.elem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaautos)).BeginInit();
            this.SuspendLayout();
            // 
            // listaautos
            // 
            this.listaautos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaautos.Location = new System.Drawing.Point(61, 41);
            this.listaautos.Name = "listaautos";
            this.listaautos.Size = new System.Drawing.Size(551, 274);
            this.listaautos.TabIndex = 0;
            // 
            // Most
            // 
            this.Most.Location = new System.Drawing.Point(91, 389);
            this.Most.Name = "Most";
            this.Most.Size = new System.Drawing.Size(109, 37);
            this.Most.TabIndex = 1;
            this.Most.Text = "Mostrar";
            this.Most.UseVisualStyleBackColor = true;
            this.Most.Click += new System.EventHandler(this.Most_Click);
            // 
            // Exp
            // 
            this.Exp.Location = new System.Drawing.Point(249, 392);
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(95, 33);
            this.Exp.TabIndex = 2;
            this.Exp.Text = "Exportar";
            this.Exp.UseVisualStyleBackColor = true;
            this.Exp.Click += new System.EventHandler(this.Exp_Click);
            // 
            // Imp
            // 
            this.Imp.Location = new System.Drawing.Point(387, 392);
            this.Imp.Name = "Imp";
            this.Imp.Size = new System.Drawing.Size(105, 32);
            this.Imp.TabIndex = 3;
            this.Imp.Text = "Importar";
            this.Imp.UseVisualStyleBackColor = true;
            this.Imp.Click += new System.EventHandler(this.Imp_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(658, 53);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(94, 26);
            this.Insert.TabIndex = 4;
            this.Insert.Text = "Insertar";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Elim
            // 
            this.Elim.Location = new System.Drawing.Point(658, 129);
            this.Elim.Name = "Elim";
            this.Elim.Size = new System.Drawing.Size(93, 31);
            this.Elim.TabIndex = 5;
            this.Elim.Text = "Eliminar";
            this.Elim.UseVisualStyleBackColor = true;
            this.Elim.Click += new System.EventHandler(this.Elim_Click);
            // 
            // Act
            // 
            this.Act.Location = new System.Drawing.Point(659, 214);
            this.Act.Name = "Act";
            this.Act.Size = new System.Drawing.Size(91, 29);
            this.Act.TabIndex = 6;
            this.Act.Text = "Actualizar";
            this.Act.UseVisualStyleBackColor = true;
            this.Act.Click += new System.EventHandler(this.Act_Click);
            // 
            // limp
            // 
            this.limp.Location = new System.Drawing.Point(665, 288);
            this.limp.Name = "limp";
            this.limp.Size = new System.Drawing.Size(84, 26);
            this.limp.TabIndex = 7;
            this.limp.Text = "Limpiar";
            this.limp.UseVisualStyleBackColor = true;
            this.limp.Click += new System.EventHandler(this.limp_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(66, 340);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(66, 20);
            this.id.TabIndex = 8;
            // 
            // marca
            // 
            this.marca.Location = new System.Drawing.Point(159, 341);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(79, 20);
            this.marca.TabIndex = 9;
            // 
            // modelo
            // 
            this.modelo.Location = new System.Drawing.Point(253, 342);
            this.modelo.Name = "modelo";
            this.modelo.Size = new System.Drawing.Size(74, 20);
            this.modelo.TabIndex = 10;
            // 
            // anio
            // 
            this.anio.Location = new System.Drawing.Point(348, 343);
            this.anio.Name = "anio";
            this.anio.Size = new System.Drawing.Size(73, 20);
            this.anio.TabIndex = 11;
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(448, 343);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(79, 20);
            this.color.TabIndex = 12;
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(547, 343);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(82, 20);
            this.precio.TabIndex = 13;
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(659, 342);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(89, 20);
            this.estado.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Anio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(549, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(663, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Estado";
            // 
            // Suma
            // 
            this.Suma.Location = new System.Drawing.Point(523, 393);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(88, 30);
            this.Suma.TabIndex = 22;
            this.Suma.Text = "Total";
            this.Suma.UseVisualStyleBackColor = true;
            this.Suma.Click += new System.EventHandler(this.Suma_Click);
            // 
            // elem
            // 
            this.elem.Location = new System.Drawing.Point(651, 395);
            this.elem.Name = "elem";
            this.elem.Size = new System.Drawing.Size(96, 27);
            this.elem.TabIndex = 23;
            this.elem.Text = "Elementos";
            this.elem.UseVisualStyleBackColor = true;
            this.elem.Click += new System.EventHandler(this.elem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.elem);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.color);
            this.Controls.Add(this.anio);
            this.Controls.Add(this.modelo);
            this.Controls.Add(this.marca);
            this.Controls.Add(this.id);
            this.Controls.Add(this.limp);
            this.Controls.Add(this.Act);
            this.Controls.Add(this.Elim);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.Imp);
            this.Controls.Add(this.Exp);
            this.Controls.Add(this.Most);
            this.Controls.Add(this.listaautos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.listaautos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listaautos;
        private System.Windows.Forms.Button Most;
        private System.Windows.Forms.Button Exp;
        private System.Windows.Forms.Button Imp;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Elim;
        private System.Windows.Forms.Button Act;
        private System.Windows.Forms.Button limp;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox marca;
        private System.Windows.Forms.TextBox modelo;
        private System.Windows.Forms.TextBox anio;
        private System.Windows.Forms.TextBox color;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.Button elem;
    }
}

