namespace Pokemon
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnatendidos = new System.Windows.Forms.Button();
            this.btnestado = new System.Windows.Forms.Button();
            this.btntipo = new System.Windows.Forms.Button();
            this.btnhp = new System.Windows.Forms.Button();
            this.btninfectado = new System.Windows.Forms.Button();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.cbopokerus = new System.Windows.Forms.ComboBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txthp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdatos = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(115, 271);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 0;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnatendidos
            // 
            this.btnatendidos.Location = new System.Drawing.Point(341, 30);
            this.btnatendidos.Name = "btnatendidos";
            this.btnatendidos.Size = new System.Drawing.Size(75, 23);
            this.btnatendidos.TabIndex = 1;
            this.btnatendidos.Text = "Atendidos";
            this.btnatendidos.UseVisualStyleBackColor = true;
            this.btnatendidos.Click += new System.EventHandler(this.btnatendidos_Click);
            // 
            // btnestado
            // 
            this.btnestado.BackColor = System.Drawing.SystemColors.Control;
            this.btnestado.Location = new System.Drawing.Point(395, 68);
            this.btnestado.Name = "btnestado";
            this.btnestado.Size = new System.Drawing.Size(75, 23);
            this.btnestado.TabIndex = 2;
            this.btnestado.Text = "Estado";
            this.btnestado.UseVisualStyleBackColor = false;
            this.btnestado.Click += new System.EventHandler(this.btnestado_Click);
            // 
            // btntipo
            // 
            this.btntipo.Location = new System.Drawing.Point(250, 30);
            this.btntipo.Name = "btntipo";
            this.btntipo.Size = new System.Drawing.Size(75, 23);
            this.btntipo.TabIndex = 3;
            this.btntipo.Text = "Tipo";
            this.btntipo.UseVisualStyleBackColor = true;
            this.btntipo.Click += new System.EventHandler(this.btntipo_Click);
            // 
            // btnhp
            // 
            this.btnhp.Location = new System.Drawing.Point(290, 68);
            this.btnhp.Name = "btnhp";
            this.btnhp.Size = new System.Drawing.Size(75, 23);
            this.btnhp.TabIndex = 4;
            this.btnhp.Text = "HP";
            this.btnhp.UseVisualStyleBackColor = true;
            this.btnhp.Click += new System.EventHandler(this.btnhp_Click);
            // 
            // btninfectado
            // 
            this.btninfectado.Location = new System.Drawing.Point(435, 30);
            this.btninfectado.Name = "btninfectado";
            this.btninfectado.Size = new System.Drawing.Size(75, 23);
            this.btninfectado.TabIndex = 5;
            this.btninfectado.Text = "Infectados";
            this.btninfectado.UseVisualStyleBackColor = true;
            this.btninfectado.Click += new System.EventHandler(this.btninfectado_Click);
            // 
            // cbotipo
            // 
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Location = new System.Drawing.Point(102, 231);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(121, 21);
            this.cbotipo.TabIndex = 6;
            // 
            // cboestado
            // 
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(102, 151);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(121, 21);
            this.cboestado.TabIndex = 7;
            // 
            // cbopokerus
            // 
            this.cbopokerus.FormattingEnabled = true;
            this.cbopokerus.Location = new System.Drawing.Point(102, 194);
            this.cbopokerus.Name = "cbopokerus";
            this.cbopokerus.Size = new System.Drawing.Size(121, 21);
            this.cbopokerus.TabIndex = 8;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(102, 37);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 9;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(102, 78);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 10;
            // 
            // txthp
            // 
            this.txthp.Location = new System.Drawing.Point(102, 111);
            this.txthp.Name = "txthp";
            this.txthp.Size = new System.Drawing.Size(100, 20);
            this.txthp.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(45, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(45, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "HP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(45, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(43, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Pokerus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(45, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tipo";
            // 
            // txtdatos
            // 
            this.txtdatos.Location = new System.Drawing.Point(250, 114);
            this.txtdatos.Multiline = true;
            this.txtdatos.Name = "txtdatos";
            this.txtdatos.Size = new System.Drawing.Size(260, 161);
            this.txtdatos.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 361);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(585, 351);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdatos);
            this.Controls.Add(this.txthp);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.cbopokerus);
            this.Controls.Add(this.cboestado);
            this.Controls.Add(this.cbotipo);
            this.Controls.Add(this.btninfectado);
            this.Controls.Add(this.btnhp);
            this.Controls.Add(this.btntipo);
            this.Controls.Add(this.btnestado);
            this.Controls.Add(this.btnatendidos);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnatendidos;
        private System.Windows.Forms.Button btnestado;
        private System.Windows.Forms.Button btntipo;
        private System.Windows.Forms.Button btnhp;
        private System.Windows.Forms.Button btninfectado;
        private System.Windows.Forms.ComboBox cbotipo;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.ComboBox cbopokerus;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txthp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdatos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

