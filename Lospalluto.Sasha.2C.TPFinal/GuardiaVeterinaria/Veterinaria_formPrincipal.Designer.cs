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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuardiaVeterinaria));
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(437, 9);
            label1.Name = "label1";
            label1.Size = new Size(305, 41);
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
            lstEnAtencionMedica.Location = new Point(404, 324);
            lstEnAtencionMedica.Name = "lstEnAtencionMedica";
            lstEnAtencionMedica.Size = new Size(356, 139);
            lstEnAtencionMedica.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(112, 290);
            label2.Name = "label2";
            label2.Size = new Size(146, 22);
            label2.TabIndex = 3;
            label2.Text = "Sala de espera";
            // 
            // lstAtendidos
            // 
            lstAtendidos.FormattingEnabled = true;
            lstAtendidos.ItemHeight = 15;
            lstAtendidos.Location = new Point(809, 324);
            lstAtendidos.Name = "lstAtendidos";
            lstAtendidos.Size = new Size(356, 139);
            lstAtendidos.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(422, 290);
            label3.Name = "label3";
            label3.Size = new Size(338, 22);
            label3.TabIndex = 5;
            label3.Text = "Mascotas en atencion con el medico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(881, 290);
            label4.Name = "label4";
            label4.Size = new Size(221, 22);
            label4.TabIndex = 6;
            label4.Text = "Pacientes ya atendidos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(60, 17);
            label5.Name = "label5";
            label5.Size = new Size(300, 18);
            label5.TabIndex = 7;
            label5.Text = "Carga de paciente en sala de espera";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(233, 61);
            label6.Name = "label6";
            label6.Size = new Size(113, 18);
            label6.TabIndex = 8;
            label6.Text = "DNI del tutor:";
            // 
            // txtDniTutor
            // 
            txtDniTutor.Location = new Point(226, 82);
            txtDniTutor.Name = "txtDniTutor";
            txtDniTutor.Size = new Size(115, 23);
            txtDniTutor.TabIndex = 9;
            txtDniTutor.KeyPress += txtDniTutor_KeyPress;
            // 
            // btnBuscarMascota
            // 
            btnBuscarMascota.Location = new Point(392, 26);
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
            lstPacienteEncontrado.Location = new Point(16, 183);
            lstPacienteEncontrado.Name = "lstPacienteEncontrado";
            lstPacienteEncontrado.Size = new Size(359, 49);
            lstPacienteEncontrado.TabIndex = 11;
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(392, 108);
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
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(58, 17);
            label7.Name = "label7";
            label7.Size = new Size(220, 18);
            label7.TabIndex = 13;
            label7.Text = "Ingreso de medico al turno";
            // 
            // txtDniMedico
            // 
            txtDniMedico.Location = new Point(48, 108);
            txtDniMedico.Name = "txtDniMedico";
            txtDniMedico.Size = new Size(126, 23);
            txtDniMedico.TabIndex = 15;
            txtDniMedico.KeyPress += txtDniMedico_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(47, 82);
            label8.Name = "label8";
            label8.Size = new Size(127, 18);
            label8.TabIndex = 14;
            label8.Text = "DNI del medico";
            // 
            // btnNuevoMedico
            // 
            btnNuevoMedico.Location = new Point(194, 124);
            btnNuevoMedico.Name = "btnNuevoMedico";
            btnNuevoMedico.Size = new Size(100, 30);
            btnNuevoMedico.TabIndex = 17;
            btnNuevoMedico.Text = "Nuevo medico";
            btnNuevoMedico.UseVisualStyleBackColor = true;
            btnNuevoMedico.Click += btnNuevoMedico_Click;
            // 
            // btnIngresarMedico
            // 
            btnIngresarMedico.Location = new Point(194, 64);
            btnIngresarMedico.Name = "btnIngresarMedico";
            btnIngresarMedico.Size = new Size(100, 30);
            btnIngresarMedico.TabIndex = 16;
            btnIngresarMedico.Text = "Ingresar medico";
            btnIngresarMedico.UseVisualStyleBackColor = true;
            btnIngresarMedico.Click += btnIngresarMedico_Click;
            // 
            // btnIngresarPacientesXml
            // 
            btnIngresarPacientesXml.Location = new Point(392, 144);
            btnIngresarPacientesXml.Name = "btnIngresarPacientesXml";
            btnIngresarPacientesXml.Size = new Size(100, 54);
            btnIngresarPacientesXml.TabIndex = 19;
            btnIngresarPacientesXml.Text = "Ingresar pacientes con XML";
            btnIngresarPacientesXml.UseVisualStyleBackColor = true;
            btnIngresarPacientesXml.Click += btnIngresarPacientesXml_Click;
            // 
            // btnCerrarVeterinaria
            // 
            btnCerrarVeterinaria.BackColor = SystemColors.HotTrack;
            btnCerrarVeterinaria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarVeterinaria.ForeColor = SystemColors.ButtonHighlight;
            btnCerrarVeterinaria.Location = new Point(982, 502);
            btnCerrarVeterinaria.Name = "btnCerrarVeterinaria";
            btnCerrarVeterinaria.Size = new Size(170, 50);
            btnCerrarVeterinaria.TabIndex = 20;
            btnCerrarVeterinaria.Text = "Cerrar veterinaria y generar reporte";
            btnCerrarVeterinaria.UseVisualStyleBackColor = false;
            btnCerrarVeterinaria.Click += btnCerrarVeterinaria_Click;
            // 
            // btnIngresarPaciente
            // 
            btnIngresarPaciente.Location = new Point(392, 62);
            btnIngresarPaciente.Name = "btnIngresarPaciente";
            btnIngresarPaciente.Size = new Size(100, 43);
            btnIngresarPaciente.TabIndex = 21;
            btnIngresarPaciente.Text = "Ingresar paciente";
            btnIngresarPaciente.UseVisualStyleBackColor = true;
            btnIngresarPaciente.Click += btnIngresarPaciente_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(btnIngresarPaciente);
            panel1.Controls.Add(btnIngresarPacientesXml);
            panel1.Controls.Add(btnNuevaMascota);
            panel1.Controls.Add(btnBuscarMascota);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtDniTutor);
            panel1.Location = new Point(12, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(534, 215);
            panel1.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtDniMedico);
            panel2.Controls.Add(btnNuevoMedico);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(btnIngresarMedico);
            panel2.Location = new Point(615, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(320, 215);
            panel2.TabIndex = 23;
            // 
            // GuardiaVeterinaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1194, 564);
            Controls.Add(btnCerrarVeterinaria);
            Controls.Add(lstPacienteEncontrado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lstAtendidos);
            Controls.Add(label2);
            Controls.Add(lstEnAtencionMedica);
            Controls.Add(lstSalaDeEspera);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GuardiaVeterinaria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lospalluto.Sasha.2C";
            FormClosing += GuardiaVeterinaria_FormClosing;
            Load += GuardiaVeterinaria_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel1;
        private Panel panel2;
    }
}