namespace GestionItem
{
    partial class Sistema_Inventario
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
            dataGridView = new DataGridView();
            groupBox1 = new GroupBox();
            lblEstado = new Label();
            label6 = new Label();
            EditarBtn = new Button();
            EliminarBtn = new Button();
            groupBox2 = new GroupBox();
            PrecioLbl = new Label();
            DecripcionLbl = new Label();
            CantidadLbl = new Label();
            IdLbl = new Label();
            NombreLbl = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            ProductoBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(6, 26);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(780, 273);
            dataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblEstado);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dataGridView);
            groupBox1.Location = new Point(12, 161);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(804, 329);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vista";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(69, 302);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 20);
            lblEstado.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 302);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 1;
            label6.Text = "Estado:";
            // 
            // EditarBtn
            // 
            EditarBtn.Location = new Point(82, 65);
            EditarBtn.Name = "EditarBtn";
            EditarBtn.Size = new Size(199, 29);
            EditarBtn.TabIndex = 1;
            EditarBtn.Text = "Editar";
            EditarBtn.UseVisualStyleBackColor = true;
            EditarBtn.Click += EditarBtn_Click;
            // 
            // EliminarBtn
            // 
            EliminarBtn.Location = new Point(82, 100);
            EliminarBtn.Name = "EliminarBtn";
            EliminarBtn.Size = new Size(199, 29);
            EliminarBtn.TabIndex = 2;
            EliminarBtn.Text = "Eliminar";
            EliminarBtn.UseVisualStyleBackColor = true;
            EliminarBtn.Click += EliminarBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PrecioLbl);
            groupBox2.Controls.Add(DecripcionLbl);
            groupBox2.Controls.Add(CantidadLbl);
            groupBox2.Controls.Add(IdLbl);
            groupBox2.Controls.Add(NombreLbl);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(398, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(418, 143);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Productos";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // PrecioLbl
            // 
            PrecioLbl.AutoSize = true;
            PrecioLbl.Location = new Point(290, 77);
            PrecioLbl.Name = "PrecioLbl";
            PrecioLbl.Size = new Size(0, 20);
            PrecioLbl.TabIndex = 9;
            // 
            // DecripcionLbl
            // 
            DecripcionLbl.AutoSize = true;
            DecripcionLbl.Location = new Point(290, 47);
            DecripcionLbl.Name = "DecripcionLbl";
            DecripcionLbl.Size = new Size(0, 20);
            DecripcionLbl.TabIndex = 8;
            // 
            // CantidadLbl
            // 
            CantidadLbl.AutoSize = true;
            CantidadLbl.Location = new Point(92, 101);
            CantidadLbl.Name = "CantidadLbl";
            CantidadLbl.Size = new Size(0, 20);
            CantidadLbl.TabIndex = 7;
            // 
            // IdLbl
            // 
            IdLbl.AutoSize = true;
            IdLbl.Location = new Point(92, 74);
            IdLbl.Name = "IdLbl";
            IdLbl.Size = new Size(0, 20);
            IdLbl.TabIndex = 6;
            // 
            // NombreLbl
            // 
            NombreLbl.AutoSize = true;
            NombreLbl.Location = new Point(92, 44);
            NombreLbl.Name = "NombreLbl";
            NombreLbl.Size = new Size(0, 20);
            NombreLbl.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(231, 77);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 4;
            label5.Text = "Precio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(194, 44);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 3;
            label4.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 74);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 2;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 101);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Cantidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 44);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre: ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ProductoBtn);
            groupBox3.Controls.Add(EliminarBtn);
            groupBox3.Controls.Add(EditarBtn);
            groupBox3.Location = new Point(18, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(351, 143);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Acciones";
            // 
            // ProductoBtn
            // 
            ProductoBtn.Location = new Point(82, 26);
            ProductoBtn.Name = "ProductoBtn";
            ProductoBtn.Size = new Size(199, 33);
            ProductoBtn.TabIndex = 0;
            ProductoBtn.Text = "Agregar Producto";
            ProductoBtn.UseVisualStyleBackColor = true;
            ProductoBtn.Click += ProductoBtn_Click;
            // 
            // Sistema_Inventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(831, 492);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Sistema_Inventario";
            Text = "Sistema_Inventario";
            Load += Sistema_Inventario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private GroupBox groupBox1;
        private Button EliminarBtn;
        private Button EditarBtn;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button ProductoBtn;
        private Label PrecioLbl;
        private Label DecripcionLbl;
        private Label CantidadLbl;
        private Label IdLbl;
        private Label NombreLbl;
        private Label label5;
        private Label label4;
        private Label lblEstado;
        private Label label6;
    }
}