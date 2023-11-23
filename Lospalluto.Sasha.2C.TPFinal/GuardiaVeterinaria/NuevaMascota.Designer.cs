namespace GuardiaVeterinaria
{
    partial class FrmNuevaMascota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevaMascota));
            btnAgregarMascota = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbTipoMascota = new ComboBox();
            txtNombreMascota = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtEdad = new TextBox();
            txtPeso = new TextBox();
            txtNombreTutor = new TextBox();
            txtDniTutor = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // btnAgregarMascota
            // 
            btnAgregarMascota.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarMascota.Location = new Point(301, 338);
            btnAgregarMascota.Name = "btnAgregarMascota";
            btnAgregarMascota.Size = new Size(107, 45);
            btnAgregarMascota.TabIndex = 0;
            btnAgregarMascota.Text = "Agregar";
            btnAgregarMascota.UseVisualStyleBackColor = true;
            btnAgregarMascota.Click += btnAgregarMascota_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(446, 338);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 45);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(364, 45);
            label1.Name = "label1";
            label1.Size = new Size(151, 22);
            label1.TabIndex = 2;
            label1.Text = "Nuevo paciente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 109);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre de la mascota:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 140);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 4;
            label3.Text = "Tipo de mascota:";
            // 
            // cmbTipoMascota
            // 
            cmbTipoMascota.AutoCompleteMode = AutoCompleteMode.Append;
            cmbTipoMascota.FormattingEnabled = true;
            cmbTipoMascota.Location = new Point(394, 137);
            cmbTipoMascota.Name = "cmbTipoMascota";
            cmbTipoMascota.Size = new Size(121, 23);
            cmbTipoMascota.TabIndex = 5;
            // 
            // txtNombreMascota
            // 
            txtNombreMascota.Location = new Point(394, 106);
            txtNombreMascota.MaxLength = 15;
            txtNombreMascota.Name = "txtNombreMascota";
            txtNombreMascota.Size = new Size(100, 23);
            txtNombreMascota.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(277, 234);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 7;
            label4.Text = "Nombre del tutor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(301, 263);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 8;
            label5.Text = "DNI del tutor:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(267, 171);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 9;
            label6.Text = "Edad de la mascota:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(344, 205);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 10;
            label7.Text = "Peso:";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(394, 168);
            txtEdad.MaxLength = 2;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 11;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(394, 202);
            txtPeso.MaxLength = 2;
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 12;
            txtPeso.KeyPress += txtPeso_KeyPress;
            // 
            // txtNombreTutor
            // 
            txtNombreTutor.Location = new Point(394, 231);
            txtNombreTutor.MaxLength = 20;
            txtNombreTutor.Name = "txtNombreTutor";
            txtNombreTutor.Size = new Size(100, 23);
            txtNombreTutor.TabIndex = 13;
            // 
            // txtDniTutor
            // 
            txtDniTutor.Location = new Point(394, 260);
            txtDniTutor.MaxLength = 8;
            txtDniTutor.Name = "txtDniTutor";
            txtDniTutor.Size = new Size(100, 23);
            txtDniTutor.TabIndex = 14;
            txtDniTutor.KeyPress += txtDniTutor_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(500, 205);
            label8.Name = "label8";
            label8.Size = new Size(21, 15);
            label8.TabIndex = 15;
            label8.Text = "KG";
            // 
            // FrmNuevaMascota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(650, 450);
            Controls.Add(label8);
            Controls.Add(txtDniTutor);
            Controls.Add(txtNombreTutor);
            Controls.Add(txtPeso);
            Controls.Add(txtEdad);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtNombreMascota);
            Controls.Add(cmbTipoMascota);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregarMascota);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmNuevaMascota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NuevaMascota";
            FormClosing += FrmNuevaMascota_FormClosing;
            Load += FrmNuevaMascota_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarMascota;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbTipoMascota;
        private TextBox txtNombreMascota;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtEdad;
        private TextBox txtPeso;
        private TextBox txtNombreTutor;
        private TextBox txtDniTutor;
        private Label label8;
    }
}