namespace GestionItem
{
    partial class Registro_de_usuario
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
            panel1 = new Panel();
            lblMensaje = new Label();
            RegistraseBtn = new Button();
            Cancelarbtn = new Button();
            panel2 = new Panel();
            label1 = new Label();
            Cargobox = new ComboBox();
            label5 = new Label();
            NombreTxt = new TextBox();
            label4 = new Label();
            ContraseñaTxt = new TextBox();
            CorreoTxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblMensaje);
            panel1.Controls.Add(RegistraseBtn);
            panel1.Controls.Add(Cancelarbtn);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(Cargobox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(NombreTxt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(ContraseñaTxt);
            panel1.Controls.Add(CorreoTxt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(188, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(532, 375);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.ForeColor = Color.Red;
            lblMensaje.Location = new Point(65, 279);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 20);
            lblMensaje.TabIndex = 16;
            // 
            // RegistraseBtn
            // 
            RegistraseBtn.Location = new Point(279, 324);
            RegistraseBtn.Name = "RegistraseBtn";
            RegistraseBtn.Size = new Size(106, 35);
            RegistraseBtn.TabIndex = 15;
            RegistraseBtn.Text = "Registrase";
            RegistraseBtn.UseVisualStyleBackColor = true;
            RegistraseBtn.Click += RegistraseBtn_Click;
            // 
            // Cancelarbtn
            // 
            Cancelarbtn.ForeColor = Color.Red;
            Cancelarbtn.Location = new Point(136, 324);
            Cancelarbtn.Name = "Cancelarbtn";
            Cancelarbtn.Size = new Size(106, 35);
            Cancelarbtn.TabIndex = 14;
            Cancelarbtn.Text = "Cancelar";
            Cancelarbtn.UseVisualStyleBackColor = true;
            Cancelarbtn.Click += Cancelarbtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-1, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(532, 61);
            panel2.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(210, 18);
            label1.Name = "label1";
            label1.Size = new Size(109, 31);
            label1.TabIndex = 1;
            label1.Text = "Registro ";
            // 
            // Cargobox
            // 
            Cargobox.FormattingEnabled = true;
            Cargobox.Items.AddRange(new object[] { "Empleado", "Administrador", "Contador" });
            Cargobox.Location = new Point(304, 204);
            Cargobox.Name = "Cargobox";
            Cargobox.Size = new Size(132, 28);
            Cargobox.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(338, 176);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 11;
            label5.Text = "Cargo";
            // 
            // NombreTxt
            // 
            NombreTxt.Location = new Point(65, 113);
            NombreTxt.Name = "NombreTxt";
            NombreTxt.Size = new Size(132, 27);
            NombreTxt.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(51, 176);
            label4.Name = "label4";
            label4.Size = new Size(169, 25);
            label4.TabIndex = 9;
            label4.Text = "Correo Electronico";
            // 
            // ContraseñaTxt
            // 
            ContraseñaTxt.Location = new Point(304, 113);
            ContraseñaTxt.Name = "ContraseñaTxt";
            ContraseñaTxt.Size = new Size(132, 27);
            ContraseñaTxt.TabIndex = 8;
            // 
            // CorreoTxt
            // 
            CorreoTxt.Location = new Point(65, 205);
            CorreoTxt.Name = "CorreoTxt";
            CorreoTxt.Size = new Size(132, 27);
            CorreoTxt.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(318, 85);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 6;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(93, 85);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // Registro_de_usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.guia_almacen_7;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(894, 442);
            Controls.Add(panel1);
            Name = "Registro_de_usuario";
            Text = "Registro_de_usuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox NombreTxt;
        private Label label4;
        private TextBox ContraseñaTxt;
        private TextBox CorreoTxt;
        private Label label3;
        private Label label2;
        private ComboBox Cargobox;
        private Label label5;
        private Button RegistraseBtn;
        private Button Cancelarbtn;
        private Panel panel2;
        private Label lblMensaje;
    }
}