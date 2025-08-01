namespace GestionItem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel2 = new Panel();
            lblMensaje = new Label();
            IniciarseccionBtn = new Button();
            label4 = new Label();
            RegistrarseBtn = new Button();
            ContraseñaTxt = new TextBox();
            NombreTxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblMensaje);
            panel2.Controls.Add(IniciarseccionBtn);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(RegistrarseBtn);
            panel2.Controls.Add(ContraseñaTxt);
            panel2.Controls.Add(NombreTxt);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // lblMensaje
            // 
            resources.ApplyResources(lblMensaje, "lblMensaje");
            lblMensaje.ForeColor = Color.Red;
            lblMensaje.Name = "lblMensaje";
            // 
            // IniciarseccionBtn
            // 
            resources.ApplyResources(IniciarseccionBtn, "IniciarseccionBtn");
            IniciarseccionBtn.Name = "IniciarseccionBtn";
            IniciarseccionBtn.UseVisualStyleBackColor = true;
            IniciarseccionBtn.Click += IniciarseccionBtn_Click;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.CausesValidation = false;
            label4.Name = "label4";
            // 
            // RegistrarseBtn
            // 
            resources.ApplyResources(RegistrarseBtn, "RegistrarseBtn");
            RegistrarseBtn.Name = "RegistrarseBtn";
            RegistrarseBtn.UseVisualStyleBackColor = true;
            RegistrarseBtn.Click += RegistrarseBtn_Click;
            // 
            // ContraseñaTxt
            // 
            resources.ApplyResources(ContraseñaTxt, "ContraseñaTxt");
            ContraseñaTxt.Name = "ContraseñaTxt";
            // 
            // NombreTxt
            // 
            resources.ApplyResources(NombreTxt, "NombreTxt");
            NombreTxt.Name = "NombreTxt";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = Properties.Resources.guia_almacen_7;
            Controls.Add(panel2);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            TransparencyKey = Color.FromArgb(255, 192, 128);
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Button RegistrarseBtn;
        private Label label4;
        private TextBox ContraseñaTxt;
        private TextBox NombreTxt;
        private Button IniciarseccionBtn;
        private Label lblMensaje;
        private Label label1;
    }
}
