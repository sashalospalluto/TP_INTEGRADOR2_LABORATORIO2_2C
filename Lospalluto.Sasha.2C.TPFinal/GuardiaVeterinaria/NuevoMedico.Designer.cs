namespace GuardiaVeterinaria
{
    partial class FrmNuevoMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoMedico));
            label1 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCrearMedico = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(295, 81);
            label1.Name = "label1";
            label1.Size = new Size(139, 22);
            label1.TabIndex = 0;
            label1.Text = "Nuevo medico";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(328, 141);
            txtNombre.MaxLength = 15;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(328, 180);
            txtApellido.MaxLength = 15;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(328, 217);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 3;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(271, 144);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 183);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(295, 220);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 6;
            label4.Text = "DNI";
            // 
            // btnCrearMedico
            // 
            btnCrearMedico.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearMedico.Location = new Point(248, 293);
            btnCrearMedico.Name = "btnCrearMedico";
            btnCrearMedico.Size = new Size(109, 40);
            btnCrearMedico.TabIndex = 7;
            btnCrearMedico.Text = "Crear";
            btnCrearMedico.UseVisualStyleBackColor = true;
            btnCrearMedico.Click += btnCrearMedico_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(389, 293);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 40);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmNuevoMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(570, 386);
            Controls.Add(btnCancelar);
            Controls.Add(btnCrearMedico);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmNuevoMedico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NuevoMedico";
            FormClosing += FrmNuevoMedico_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCrearMedico;
        private Button btnCancelar;
    }
}