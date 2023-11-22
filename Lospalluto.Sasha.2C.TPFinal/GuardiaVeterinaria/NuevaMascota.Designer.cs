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
            SuspendLayout();
            // 
            // btnAgregarMascota
            // 
            btnAgregarMascota.Location = new Point(255, 336);
            btnAgregarMascota.Name = "btnAgregarMascota";
            btnAgregarMascota.Size = new Size(75, 23);
            btnAgregarMascota.TabIndex = 0;
            btnAgregarMascota.Text = "Agregar";
            btnAgregarMascota.UseVisualStyleBackColor = true;
            btnAgregarMascota.Click += btnAgregarMascota_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(469, 336);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(348, 45);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 2;
            label1.Text = "Nuevo paciente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 93);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre de la mascota";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 124);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 4;
            label3.Text = "Tipo de mascota";
            // 
            // cmbTipoMascota
            // 
            cmbTipoMascota.AutoCompleteMode = AutoCompleteMode.Append;
            cmbTipoMascota.FormattingEnabled = true;
            cmbTipoMascota.Location = new Point(328, 121);
            cmbTipoMascota.Name = "cmbTipoMascota";
            cmbTipoMascota.Size = new Size(121, 23);
            cmbTipoMascota.TabIndex = 5;
            // 
            // txtNombreMascota
            // 
            txtNombreMascota.Location = new Point(328, 90);
            txtNombreMascota.Name = "txtNombreMascota";
            txtNombreMascota.Size = new Size(100, 23);
            txtNombreMascota.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(211, 218);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 7;
            label4.Text = "Nombre del tutor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(235, 247);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 8;
            label5.Text = "DNI del tutor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(201, 155);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 9;
            label6.Text = "Edad de la mascota";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(278, 189);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 10;
            label7.Text = "Peso";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(328, 152);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 11;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(328, 186);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 12;
            // 
            // txtNombreTutor
            // 
            txtNombreTutor.Location = new Point(328, 215);
            txtNombreTutor.Name = "txtNombreTutor";
            txtNombreTutor.Size = new Size(100, 23);
            txtNombreTutor.TabIndex = 13;
            // 
            // txtDniTutor
            // 
            txtDniTutor.Location = new Point(328, 244);
            txtDniTutor.Name = "txtDniTutor";
            txtDniTutor.Size = new Size(100, 23);
            txtDniTutor.TabIndex = 14;
            // 
            // FrmNuevaMascota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "FrmNuevaMascota";
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
    }
}