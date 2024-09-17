namespace Gimnasio
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txt_Contrasenia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Mensaje = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.BackColor = System.Drawing.Color.Gold;
            this.btn_Ingresar.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ingresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Ingresar.Location = new System.Drawing.Point(118, 323);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(98, 29);
            this.btn_Ingresar.TabIndex = 3;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = false;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(18, 31);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(149, 26);
            this.txt_Usuario.TabIndex = 5;
            this.txt_Usuario.TextChanged += new System.EventHandler(this.txt_Usuario_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.txt_Usuario);
            this.panel1.Controls.Add(this.txt_Contrasenia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(100, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 128);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Gimnasio.Properties.Resources._747305;
            this.pictureBox4.InitialImage = global::Gimnasio.Properties.Resources._1077063;
            this.pictureBox4.Location = new System.Drawing.Point(178, 92);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Gimnasio.Properties.Resources._1077063;
            this.pictureBox3.InitialImage = global::Gimnasio.Properties.Resources._1077063;
            this.pictureBox3.Location = new System.Drawing.Point(178, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // txt_Contrasenia
            // 
            this.txt_Contrasenia.Location = new System.Drawing.Point(18, 92);
            this.txt_Contrasenia.Name = "txt_Contrasenia";
            this.txt_Contrasenia.PasswordChar = '*';
            this.txt_Contrasenia.Size = new System.Drawing.Size(149, 26);
            this.txt_Contrasenia.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Engravers MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "GIMNASIO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Gimnasio.Properties.Resources.KSSSSSS;
            this.pictureBox2.InitialImage = global::Gimnasio.Properties.Resources.KSSSSSS;
            this.pictureBox2.Location = new System.Drawing.Point(127, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Gimnasio.Properties.Resources.Fitness_Culturismo_Material_De_Antecedentes_de_Pantalla_Imagen_para_Descarga_Gratuita___Pngtree;
            this.pictureBox1.Image = global::Gimnasio.Properties.Resources.Fitness_Culturismo_Material_De_Antecedentes_de_Pantalla_Imagen_para_Descarga_Gratuita___Pngtree;
            this.pictureBox1.InitialImage = global::Gimnasio.Properties.Resources.Fitness_Culturismo_Material_De_Antecedentes_de_Pantalla_Imagen_para_Descarga_Gratuita___Pngtree;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 584);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Mensaje
            // 
            this.lbl_Mensaje.AutoSize = true;
            this.lbl_Mensaje.BackColor = System.Drawing.Color.Gold;
            this.lbl_Mensaje.ForeColor = System.Drawing.Color.Red;
            this.lbl_Mensaje.Location = new System.Drawing.Point(96, 359);
            this.lbl_Mensaje.Name = "lbl_Mensaje";
            this.lbl_Mensaje.Size = new System.Drawing.Size(0, 20);
            this.lbl_Mensaje.TabIndex = 11;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Gold;
            this.btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Cancelar.Location = new System.Drawing.Point(222, 323);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(95, 29);
            this.btn_Cancelar.TabIndex = 12;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 580);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.lbl_Mensaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txt_Contrasenia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Mensaje;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}

