namespace Future_Real_Estate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnFinanciamiento = new System.Windows.Forms.Button();
            this.btnContacto = new System.Windows.Forms.Button();
            this.pMenu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnProperty = new System.Windows.Forms.Button();
            this.pVyA = new System.Windows.Forms.Panel();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnAlquiler = new System.Windows.Forms.Button();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pVyA.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(175)))), ((int)(((byte)(99)))));
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(193, 71);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnInicio.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(175)))), ((int)(((byte)(99)))));
            this.btnVender.FlatAppearance.BorderSize = 0;
            this.btnVender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.Location = new System.Drawing.Point(476, 0);
            this.btnVender.Margin = new System.Windows.Forms.Padding(0);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(200, 71);
            this.btnVender.TabIndex = 3;
            this.btnVender.Text = "Vende tu Propiedad";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnVender.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnFinanciamiento
            // 
            this.btnFinanciamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(175)))), ((int)(((byte)(99)))));
            this.btnFinanciamiento.FlatAppearance.BorderSize = 0;
            this.btnFinanciamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanciamiento.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinanciamiento.Location = new System.Drawing.Point(706, 0);
            this.btnFinanciamiento.Margin = new System.Windows.Forms.Padding(0);
            this.btnFinanciamiento.Name = "btnFinanciamiento";
            this.btnFinanciamiento.Size = new System.Drawing.Size(202, 71);
            this.btnFinanciamiento.TabIndex = 4;
            this.btnFinanciamiento.Text = "Financiamiento Bancario";
            this.btnFinanciamiento.UseVisualStyleBackColor = false;
            this.btnFinanciamiento.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnFinanciamiento.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnContacto
            // 
            this.btnContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(175)))), ((int)(((byte)(99)))));
            this.btnContacto.FlatAppearance.BorderSize = 0;
            this.btnContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContacto.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContacto.Location = new System.Drawing.Point(967, 0);
            this.btnContacto.Margin = new System.Windows.Forms.Padding(0);
            this.btnContacto.Name = "btnContacto";
            this.btnContacto.Size = new System.Drawing.Size(200, 71);
            this.btnContacto.TabIndex = 5;
            this.btnContacto.Text = "Contáctanos";
            this.btnContacto.UseVisualStyleBackColor = false;
            this.btnContacto.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnContacto.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(175)))), ((int)(((byte)(99)))));
            this.pMenu.Controls.Add(this.btnContacto);
            this.pMenu.Controls.Add(this.btnFinanciamiento);
            this.pMenu.Controls.Add(this.btnVender);
            this.pMenu.Controls.Add(this.btnProperty);
            this.pMenu.Controls.Add(this.btnInicio);
            this.pMenu.Location = new System.Drawing.Point(-2, 91);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(1926, 77);
            this.pMenu.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(80)))), ((int)(((byte)(67)))));
            this.pictureBox4.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1926, 94);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // btnProperty
            // 
            this.btnProperty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(175)))), ((int)(((byte)(99)))));
            this.btnProperty.FlatAppearance.BorderSize = 0;
            this.btnProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProperty.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProperty.Image = global::Future_Real_Estate.Properties.Resources.icons8_expand_arrow_24;
            this.btnProperty.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProperty.Location = new System.Drawing.Point(244, 0);
            this.btnProperty.Margin = new System.Windows.Forms.Padding(0);
            this.btnProperty.Name = "btnProperty";
            this.btnProperty.Size = new System.Drawing.Size(200, 71);
            this.btnProperty.TabIndex = 1;
            this.btnProperty.Text = "Propiedades";
            this.btnProperty.UseVisualStyleBackColor = false;
            this.btnProperty.Click += new System.EventHandler(this.btnProperty_Click);
            this.btnProperty.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnProperty.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // pVyA
            // 
            this.pVyA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(175)))), ((int)(((byte)(99)))));
            this.pVyA.Controls.Add(this.btnVenta);
            this.pVyA.Controls.Add(this.btnAlquiler);
            this.pVyA.Location = new System.Drawing.Point(242, 174);
            this.pVyA.Name = "pVyA";
            this.pVyA.Size = new System.Drawing.Size(200, 150);
            this.pVyA.TabIndex = 5;
            this.pVyA.Visible = false;
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(175)))), ((int)(((byte)(99)))));
            this.btnVenta.FlatAppearance.BorderSize = 0;
            this.btnVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.Location = new System.Drawing.Point(0, 0);
            this.btnVenta.Margin = new System.Windows.Forms.Padding(0);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(200, 71);
            this.btnVenta.TabIndex = 6;
            this.btnVenta.Text = "Venta de Propiedades";
            this.btnVenta.UseVisualStyleBackColor = false;
            this.btnVenta.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnVenta.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnAlquiler
            // 
            this.btnAlquiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(175)))), ((int)(((byte)(99)))));
            this.btnAlquiler.FlatAppearance.BorderSize = 0;
            this.btnAlquiler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAlquiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlquiler.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlquiler.Location = new System.Drawing.Point(0, 79);
            this.btnAlquiler.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlquiler.Name = "btnAlquiler";
            this.btnAlquiler.Size = new System.Drawing.Size(200, 71);
            this.btnAlquiler.TabIndex = 7;
            this.btnAlquiler.Text = "Alquiler de Propiedades";
            this.btnAlquiler.UseVisualStyleBackColor = false;
            this.btnAlquiler.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnAlquiler.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(194)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1180, 625);
            this.Controls.Add(this.pVyA);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pVyA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnProperty;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnFinanciamiento;
        private System.Windows.Forms.Button btnContacto;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel pVyA;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnAlquiler;
    }
}

