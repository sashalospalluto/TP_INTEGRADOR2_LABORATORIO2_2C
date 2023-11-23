namespace GuardiaVeterinaria
{
    partial class GuardiaVeterinaria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lstSalaDeEspera = new ListBox();
            lstEnAtencionMedica = new ListBox();
            label2 = new Label();
            lstAtendidos = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtDniTutor = new TextBox();
            btnBuscarMascota = new Button();
            lstPacienteEncontrado = new ListBox();
            btnNuevaMascota = new Button();
            label7 = new Label();
            txtDniMedico = new TextBox();
            label8 = new Label();
            btnNuevoMedico = new Button();
            btnIngresarMedico = new Button();
            btnIngresarPacientesXml = new Button();
            btnCerrarVeterinaria = new Button();
            btnIngresarPaciente = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(412, 26);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Guardia Veterinaria";
            // 
            // lstSalaDeEspera
            // 
            lstSalaDeEspera.FormattingEnabled = true;
            lstSalaDeEspera.ItemHeight = 15;
            lstSalaDeEspera.Location = new Point(12, 324);
            lstSalaDeEspera.Name = "lstSalaDeEspera";
            lstSalaDeEspera.Size = new Size(356, 139);
            lstSalaDeEspera.TabIndex = 1;
            // 
            // lstEnAtencionMedica
            // 
            lstEnAtencionMedica.FormattingEnabled = true;
            lstEnAtencionMedica.ItemHeight = 15;
            lstEnAtencionMedica.Location = new Point(374, 324);
            lstEnAtencionMedica.Name = "lstEnAtencionMedica";
            lstEnAtencionMedica.Size = new Size(356, 139);
            lstEnAtencionMedica.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 290);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 3;
            label2.Text = "Sala de espera";
            // 
            // lstAtendidos
            // 
            lstAtendidos.FormattingEnabled = true;
            lstAtendidos.ItemHeight = 15;
            lstAtendidos.Location = new Point(736, 324);
            lstAtendidos.Name = "lstAtendidos";
            lstAtendidos.Size = new Size(356, 139);
            lstAtendidos.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(456, 290);
            label3.Name = "label3";
            label3.Size = new Size(200, 15);
            label3.TabIndex = 5;
            label3.Text = "Mascotas en atencion con el medico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(867, 290);
            label4.Name = "label4";
            label4.Size = new Size(127, 15);
            label4.TabIndex = 6;
            label4.Text = "Pacientes ya atendidos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 88);
            label5.Name = "label5";
            label5.Size = new Size(194, 15);
            label5.TabIndex = 7;
            label5.Text = "Carga de paciente en sala de espera";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 123);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 8;
            label6.Text = "DNI del tutor";
            // 
            // txtDniTutor
            // 
            txtDniTutor.Location = new Point(71, 141);
            txtDniTutor.Name = "txtDniTutor";
            txtDniTutor.Size = new Size(100, 23);
            txtDniTutor.TabIndex = 9;
            // 
            // btnBuscarMascota
            // 
            btnBuscarMascota.Location = new Point(289, 123);
            btnBuscarMascota.Name = "btnBuscarMascota";
            btnBuscarMascota.Size = new Size(100, 30);
            btnBuscarMascota.TabIndex = 10;
            btnBuscarMascota.Text = "Buscar";
            btnBuscarMascota.UseVisualStyleBackColor = true;
            btnBuscarMascota.Click += btnBuscarMascota_Click;
            // 
            // lstPacienteEncontrado
            // 
            lstPacienteEncontrado.FormattingEnabled = true;
            lstPacienteEncontrado.ItemHeight = 15;
            lstPacienteEncontrado.Location = new Point(12, 183);
            lstPacienteEncontrado.Name = "lstPacienteEncontrado";
            lstPacienteEncontrado.Size = new Size(245, 49);
            lstPacienteEncontrado.TabIndex = 11;
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(289, 202);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(100, 30);
            btnNuevaMascota.TabIndex = 12;
            btnNuevaMascota.Text = "Nuevo paciente";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(659, 88);
            label7.Name = "label7";
            label7.Size = new Size(95, 15);
            label7.TabIndex = 13;
            label7.Text = "Medico de turno";
            // 
            // txtDniMedico
            // 
            txtDniMedico.Location = new Point(642, 141);
            txtDniMedico.Name = "txtDniMedico";
            txtDniMedico.Size = new Size(100, 23);
            txtDniMedico.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(653, 123);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 14;
            label8.Text = "DNI del medico";
            // 
            // btnNuevoMedico
            // 
            btnNuevoMedico.Location = new Point(770, 172);
            btnNuevoMedico.Name = "btnNuevoMedico";
            btnNuevoMedico.Size = new Size(100, 30);
            btnNuevoMedico.TabIndex = 17;
            btnNuevoMedico.Text = "Nuevo Medico";
            btnNuevoMedico.UseVisualStyleBackColor = true;
            btnNuevoMedico.Click += btnNuevoMedico_Click;
            // 
            // btnIngresarMedico
            // 
            btnIngresarMedico.Location = new Point(770, 136);
            btnIngresarMedico.Name = "btnIngresarMedico";
            btnIngresarMedico.Size = new Size(100, 30);
            btnIngresarMedico.TabIndex = 16;
            btnIngresarMedico.Text = "Ingresar medico";
            btnIngresarMedico.UseVisualStyleBackColor = true;
            btnIngresarMedico.Click += btnIngresarMedico_Click;
            // 
            // btnIngresarPacientesXml
            // 
            btnIngresarPacientesXml.Location = new Point(289, 238);
            btnIngresarPacientesXml.Name = "btnIngresarPacientesXml";
            btnIngresarPacientesXml.Size = new Size(100, 54);
            btnIngresarPacientesXml.TabIndex = 19;
            btnIngresarPacientesXml.Text = "Ingresar pacientes con XML";
            btnIngresarPacientesXml.UseVisualStyleBackColor = true;
            btnIngresarPacientesXml.Click += btnIngresarPacientesXml_Click;
            // 
            // btnCerrarVeterinaria
            // 
            btnCerrarVeterinaria.Location = new Point(867, 502);
            btnCerrarVeterinaria.Name = "btnCerrarVeterinaria";
            btnCerrarVeterinaria.Size = new Size(170, 50);
            btnCerrarVeterinaria.TabIndex = 20;
            btnCerrarVeterinaria.Text = "Cerrar veterinaria y generar los reportes";
            btnCerrarVeterinaria.UseVisualStyleBackColor = true;
            btnCerrarVeterinaria.Click += btnCerrarVeterinaria_Click;
            // 
            // btnIngresarPaciente
            // 
            btnIngresarPaciente.Location = new Point(289, 153);
            btnIngresarPaciente.Name = "btnIngresarPaciente";
            btnIngresarPaciente.Size = new Size(100, 43);
            btnIngresarPaciente.TabIndex = 21;
            btnIngresarPaciente.Text = "Ingresar paciente";
            btnIngresarPaciente.UseVisualStyleBackColor = true;
            btnIngresarPaciente.Click += btnIngresarPaciente_Click;
            // 
            // GuardiaVeterinaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 564);
            Controls.Add(btnIngresarPaciente);
            Controls.Add(btnCerrarVeterinaria);
            Controls.Add(btnIngresarPacientesXml);
            Controls.Add(btnNuevoMedico);
            Controls.Add(btnIngresarMedico);
            Controls.Add(txtDniMedico);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnNuevaMascota);
            Controls.Add(lstPacienteEncontrado);
            Controls.Add(btnBuscarMascota);
            Controls.Add(txtDniTutor);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lstAtendidos);
            Controls.Add(label2);
            Controls.Add(lstEnAtencionMedica);
            Controls.Add(lstSalaDeEspera);
            Controls.Add(label1);
            Name = "GuardiaVeterinaria";
            Text = "Lospalluto.Sasha.2C";
            Load += GuardiaVeterinaria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstSalaDeEspera;
        private ListBox lstEnAtencionMedica;
        private Label label2;
        private ListBox lstAtendidos;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtDniTutor;
        private Button btnBuscarMascota;
        private ListBox lstPacienteEncontrado;
        private Button btnNuevaMascota;
        private Label label7;
        private TextBox txtDniMedico;
        private Label label8;
        private Button btnNuevoMedico;
        private Button btnIngresarMedico;
        private Button btnIngresarPacientesXml;
        private Button btnCerrarVeterinaria;
        private Button btnIngresarPaciente;
    }
}