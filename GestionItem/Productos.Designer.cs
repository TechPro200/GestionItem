namespace GestionItem
{
    partial class Productos
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
            groupBox1 = new GroupBox();
            lblMensaje = new Label();
            AgregarBtn = new Button();
            CancelarBtn = new Button();
            PrecioTxt = new TextBox();
            CantidadTxt = new TextBox();
            DescripcionTxt = new TextBox();
            NombreTxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblMensaje);
            groupBox1.Controls.Add(AgregarBtn);
            groupBox1.Controls.Add(CancelarBtn);
            groupBox1.Controls.Add(PrecioTxt);
            groupBox1.Controls.Add(CantidadTxt);
            groupBox1.Controls.Add(DescripcionTxt);
            groupBox1.Controls.Add(NombreTxt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(409, 275);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulario";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(9, 205);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 20);
            lblMensaje.TabIndex = 10;
            // 
            // AgregarBtn
            // 
            AgregarBtn.Location = new Point(219, 233);
            AgregarBtn.Name = "AgregarBtn";
            AgregarBtn.Size = new Size(94, 29);
            AgregarBtn.TabIndex = 9;
            AgregarBtn.Text = "Agregar";
            AgregarBtn.UseVisualStyleBackColor = true;
            AgregarBtn.Click += AgregarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(103, 233);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(94, 29);
            CancelarBtn.TabIndex = 8;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // PrecioTxt
            // 
            PrecioTxt.Location = new Point(105, 153);
            PrecioTxt.Multiline = true;
            PrecioTxt.Name = "PrecioTxt";
            PrecioTxt.Size = new Size(266, 28);
            PrecioTxt.TabIndex = 7;
            // 
            // CantidadTxt
            // 
            CantidadTxt.Location = new Point(105, 114);
            CantidadTxt.Multiline = true;
            CantidadTxt.Name = "CantidadTxt";
            CantidadTxt.Size = new Size(266, 28);
            CantidadTxt.TabIndex = 6;
            // 
            // DescripcionTxt
            // 
            DescripcionTxt.Location = new Point(105, 77);
            DescripcionTxt.Multiline = true;
            DescripcionTxt.Name = "DescripcionTxt";
            DescripcionTxt.Size = new Size(266, 28);
            DescripcionTxt.TabIndex = 5;
            // 
            // NombreTxt
            // 
            NombreTxt.Location = new Point(105, 38);
            NombreTxt.Multiline = true;
            NombreTxt.Name = "NombreTxt";
            NombreTxt.Size = new Size(266, 28);
            NombreTxt.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 153);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 3;
            label4.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 115);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Cantidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 77);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 1;
            label2.Text = "Descripcion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 38);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(412, 276);
            Controls.Add(groupBox1);
            Name = "Productos";
            Text = "Producto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private TextBox NombreTxt;
        private Button AgregarBtn;
        private Button CancelarBtn;
        private TextBox PrecioTxt;
        private TextBox CantidadTxt;
        private TextBox DescripcionTxt;
        private Label lblMensaje;
    }
}