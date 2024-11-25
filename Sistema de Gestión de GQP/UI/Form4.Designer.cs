namespace Sistema_de_Gestión_de_GQP
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_cliente = new System.Windows.Forms.TextBox();
            this.textBox_cantidad = new System.Windows.Forms.TextBox();
            this.textBox_unidad = new System.Windows.Forms.TextBox();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.textBox_dia = new System.Windows.Forms.TextBox();
            this.textBox_mes = new System.Windows.Forms.TextBox();
            this.textBox_año = new System.Windows.Forms.TextBox();
            this.Registrar_pedido = new System.Windows.Forms.Button();
            this.button_SALIR = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox_detalles = new System.Windows.Forms.RichTextBox();
            this.pictureBox_imagen = new System.Windows.Forms.PictureBox();
            this.button_imagen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha: ";
            // 
            // textBox_cliente
            // 
            this.textBox_cliente.Location = new System.Drawing.Point(271, 19);
            this.textBox_cliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_cliente.Name = "textBox_cliente";
            this.textBox_cliente.Size = new System.Drawing.Size(233, 20);
            this.textBox_cliente.TabIndex = 6;
            // 
            // textBox_cantidad
            // 
            this.textBox_cantidad.Location = new System.Drawing.Point(271, 64);
            this.textBox_cantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_cantidad.Name = "textBox_cantidad";
            this.textBox_cantidad.Size = new System.Drawing.Size(57, 20);
            this.textBox_cantidad.TabIndex = 7;
            this.textBox_cantidad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_unidad
            // 
            this.textBox_unidad.Location = new System.Drawing.Point(344, 64);
            this.textBox_unidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_unidad.Name = "textBox_unidad";
            this.textBox_unidad.Size = new System.Drawing.Size(98, 20);
            this.textBox_unidad.TabIndex = 8;
            // 
            // textBox_total
            // 
            this.textBox_total.Location = new System.Drawing.Point(271, 116);
            this.textBox_total.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.Size = new System.Drawing.Size(141, 20);
            this.textBox_total.TabIndex = 9;
            // 
            // textBox_dia
            // 
            this.textBox_dia.Location = new System.Drawing.Point(271, 172);
            this.textBox_dia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_dia.Name = "textBox_dia";
            this.textBox_dia.Size = new System.Drawing.Size(30, 20);
            this.textBox_dia.TabIndex = 10;
            // 
            // textBox_mes
            // 
            this.textBox_mes.Location = new System.Drawing.Point(314, 172);
            this.textBox_mes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_mes.Name = "textBox_mes";
            this.textBox_mes.Size = new System.Drawing.Size(30, 20);
            this.textBox_mes.TabIndex = 11;
            // 
            // textBox_año
            // 
            this.textBox_año.Location = new System.Drawing.Point(357, 172);
            this.textBox_año.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_año.Name = "textBox_año";
            this.textBox_año.Size = new System.Drawing.Size(30, 20);
            this.textBox_año.TabIndex = 12;
            // 
            // Registrar_pedido
            // 
            this.Registrar_pedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Registrar_pedido.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrar_pedido.Location = new System.Drawing.Point(11, 431);
            this.Registrar_pedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Registrar_pedido.Name = "Registrar_pedido";
            this.Registrar_pedido.Size = new System.Drawing.Size(110, 54);
            this.Registrar_pedido.TabIndex = 13;
            this.Registrar_pedido.Text = "Registrar pedido";
            this.Registrar_pedido.UseVisualStyleBackColor = false;
            this.Registrar_pedido.Click += new System.EventHandler(this.Registrar_pedido_Click);
            // 
            // button_SALIR
            // 
            this.button_SALIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_SALIR.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SALIR.Location = new System.Drawing.Point(586, 444);
            this.button_SALIR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_SALIR.Name = "button_SALIR";
            this.button_SALIR.Size = new System.Drawing.Size(110, 54);
            this.button_SALIR.TabIndex = 14;
            this.button_SALIR.Text = "Salir";
            this.button_SALIR.UseVisualStyleBackColor = false;
            this.button_SALIR.Click += new System.EventHandler(this.button_SALIR_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.richTextBox_detalles);
            this.groupBox1.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(65, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 176);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DETALLES:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pictureBox_imagen);
            this.groupBox2.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(429, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 176);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INSERTE IMAGEN:";
            // 
            // richTextBox_detalles
            // 
            this.richTextBox_detalles.BackColor = System.Drawing.Color.White;
            this.richTextBox_detalles.Location = new System.Drawing.Point(16, 29);
            this.richTextBox_detalles.Name = "richTextBox_detalles";
            this.richTextBox_detalles.Size = new System.Drawing.Size(179, 135);
            this.richTextBox_detalles.TabIndex = 0;
            this.richTextBox_detalles.Text = "";
            // 
            // pictureBox_imagen
            // 
            this.pictureBox_imagen.BackColor = System.Drawing.Color.White;
            this.pictureBox_imagen.Location = new System.Drawing.Point(15, 25);
            this.pictureBox_imagen.Name = "pictureBox_imagen";
            this.pictureBox_imagen.Size = new System.Drawing.Size(188, 139);
            this.pictureBox_imagen.TabIndex = 0;
            this.pictureBox_imagen.TabStop = false;
            // 
            // button_imagen
            // 
            this.button_imagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_imagen.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_imagen.Location = new System.Drawing.Point(488, 392);
            this.button_imagen.Name = "button_imagen";
            this.button_imagen.Size = new System.Drawing.Size(106, 36);
            this.button_imagen.TabIndex = 17;
            this.button_imagen.Text = "INSERTAR";
            this.button_imagen.UseVisualStyleBackColor = false;
            this.button_imagen.Click += new System.EventHandler(this.button_imagen_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_de_Gestión_de_GQP.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(695, 496);
            this.Controls.Add(this.button_imagen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_SALIR);
            this.Controls.Add(this.Registrar_pedido);
            this.Controls.Add(this.textBox_año);
            this.Controls.Add(this.textBox_mes);
            this.Controls.Add(this.textBox_dia);
            this.Controls.Add(this.textBox_total);
            this.Controls.Add(this.textBox_unidad);
            this.Controls.Add(this.textBox_cantidad);
            this.Controls.Add(this.textBox_cliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_cliente;
        private System.Windows.Forms.TextBox textBox_cantidad;
        private System.Windows.Forms.TextBox textBox_unidad;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.TextBox textBox_dia;
        private System.Windows.Forms.TextBox textBox_mes;
        private System.Windows.Forms.TextBox textBox_año;
        private System.Windows.Forms.Button Registrar_pedido;
        private System.Windows.Forms.Button button_SALIR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox_detalles;
        private System.Windows.Forms.PictureBox pictureBox_imagen;
        private System.Windows.Forms.Button button_imagen;
    }
}