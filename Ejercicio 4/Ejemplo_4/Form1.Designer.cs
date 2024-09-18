namespace Ejemplo_4
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
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtpreciocosto = new System.Windows.Forms.TextBox();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbcorreos = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnElectrodomestico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(162, 23);
            this.txtmarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(126, 20);
            this.txtmarca.TabIndex = 0;
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(162, 75);
            this.txtmodelo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(126, 20);
            this.txtmodelo.TabIndex = 1;
            // 
            // txtpreciocosto
            // 
            this.txtpreciocosto.Location = new System.Drawing.Point(162, 127);
            this.txtpreciocosto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtpreciocosto.Name = "txtpreciocosto";
            this.txtpreciocosto.Size = new System.Drawing.Size(126, 20);
            this.txtpreciocosto.TabIndex = 2;
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.Location = new System.Drawing.Point(162, 185);
            this.txtprecioventa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(126, 20);
            this.txtprecioventa.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(162, 243);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio de Costo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio de Venta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de Compra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(457, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(457, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Edad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(457, 127);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Correos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(457, 184);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tipo de Pago:";
            // 
            // cbcorreos
            // 
            this.cbcorreos.FormattingEnabled = true;
            this.cbcorreos.Location = new System.Drawing.Point(596, 125);
            this.cbcorreos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbcorreos.Name = "cbcorreos";
            this.cbcorreos.Size = new System.Drawing.Size(144, 21);
            this.cbcorreos.TabIndex = 15;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(596, 184);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 17);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Credito";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(672, 184);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 17);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Contado";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(596, 24);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(144, 20);
            this.txtnombre.TabIndex = 18;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(596, 76);
            this.txtedad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(144, 20);
            this.txtedad.TabIndex = 19;
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.Green;
            this.btnCliente.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(585, 298);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(135, 55);
            this.btnCliente.TabIndex = 20;
            this.btnCliente.Text = "Agregar Cliente";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnElectrodomestico
            // 
            this.btnElectrodomestico.BackColor = System.Drawing.Color.LawnGreen;
            this.btnElectrodomestico.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElectrodomestico.Location = new System.Drawing.Point(106, 298);
            this.btnElectrodomestico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnElectrodomestico.Name = "btnElectrodomestico";
            this.btnElectrodomestico.Size = new System.Drawing.Size(159, 55);
            this.btnElectrodomestico.TabIndex = 21;
            this.btnElectrodomestico.Text = "Agregar Electrodomestico";
            this.btnElectrodomestico.UseVisualStyleBackColor = false;
            this.btnElectrodomestico.Click += new System.EventHandler(this.btnElectrodomestico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(877, 378);
            this.Controls.Add(this.btnElectrodomestico);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.cbcorreos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtprecioventa);
            this.Controls.Add(this.txtpreciocosto);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.txtmarca);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Compra y Venta de electrodomesticos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txtpreciocosto;
        private System.Windows.Forms.TextBox txtprecioventa;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbcorreos;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnElectrodomestico;
    }
}

