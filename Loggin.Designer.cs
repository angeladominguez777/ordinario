namespace ordinario
{
    partial class Loggin
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
            this.User = new System.Windows.Forms.Label();
            this.Contrase = new System.Windows.Forms.Label();
            this.Usua = new System.Windows.Forms.TextBox();
            this.Contra = new System.Windows.Forms.TextBox();
            this.Ing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(319, 82);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(43, 13);
            this.User.TabIndex = 0;
            this.User.Text = "Usuario";
            // 
            // Contrase
            // 
            this.Contrase.AutoSize = true;
            this.Contrase.Location = new System.Drawing.Point(316, 210);
            this.Contrase.Name = "Contrase";
            this.Contrase.Size = new System.Drawing.Size(63, 13);
            this.Contrase.TabIndex = 1;
            this.Contrase.Text = "Contrasenia";
            // 
            // Usua
            // 
            this.Usua.Location = new System.Drawing.Point(288, 112);
            this.Usua.Name = "Usua";
            this.Usua.Size = new System.Drawing.Size(104, 20);
            this.Usua.TabIndex = 2;
            this.Usua.TextChanged += new System.EventHandler(this.Usua_TextChanged);
            // 
            // Contra
            // 
            this.Contra.Location = new System.Drawing.Point(282, 257);
            this.Contra.Name = "Contra";
            this.Contra.Size = new System.Drawing.Size(109, 20);
            this.Contra.TabIndex = 3;
            this.Contra.TextChanged += new System.EventHandler(this.Contra_TextChanged);
            // 
            // Ing
            // 
            this.Ing.Location = new System.Drawing.Point(280, 336);
            this.Ing.Name = "Ing";
            this.Ing.Size = new System.Drawing.Size(98, 32);
            this.Ing.TabIndex = 4;
            this.Ing.Text = "Ingresar";
            this.Ing.UseVisualStyleBackColor = true;
            this.Ing.Click += new System.EventHandler(this.Ing_Click);
            // 
            // Loggin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ing);
            this.Controls.Add(this.Contra);
            this.Controls.Add(this.Usua);
            this.Controls.Add(this.Contrase);
            this.Controls.Add(this.User);
            this.Name = "Loggin";
            this.Text = "Loggin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label Contrase;
        private System.Windows.Forms.TextBox Usua;
        private System.Windows.Forms.TextBox Contra;
        private System.Windows.Forms.Button Ing;
    }
}