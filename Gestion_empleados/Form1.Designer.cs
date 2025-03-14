namespace Gestion_empleados
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
            btn_guardar = new Button();
            btn_eliminar = new Button();
            dgvEmpleado = new DataGridView();
            lbl_nombre = new Label();
            lbl_apellido = new Label();
            lbl_edad = new Label();
            lbl_cargo = new Label();
            lbl_salario = new Label();
            txt_nombre = new TextBox();
            txt_apellido = new TextBox();
            txt_edad = new TextBox();
            txt_salario = new TextBox();
            cmb_cargo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado).BeginInit();
            SuspendLayout();
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(31, 343);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(141, 65);
            btn_guardar.TabIndex = 0;
            btn_guardar.Text = "guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(199, 343);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(141, 65);
            btn_eliminar.TabIndex = 2;
            btn_eliminar.Text = "eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // dgvEmpleado
            // 
            dgvEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleado.Location = new Point(370, 12);
            dgvEmpleado.Name = "dgvEmpleado";
            dgvEmpleado.RowHeadersWidth = 51;
            dgvEmpleado.Size = new Size(596, 443);
            dgvEmpleado.TabIndex = 3;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(49, 46);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(61, 20);
            lbl_nombre.TabIndex = 4;
            lbl_nombre.Text = "nombre";
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Location = new Point(49, 86);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(64, 20);
            lbl_apellido.TabIndex = 5;
            lbl_apellido.Text = "apellido";
            // 
            // lbl_edad
            // 
            lbl_edad.AutoSize = true;
            lbl_edad.Location = new Point(49, 129);
            lbl_edad.Name = "lbl_edad";
            lbl_edad.Size = new Size(43, 20);
            lbl_edad.TabIndex = 6;
            lbl_edad.Text = "edad";
            // 
            // lbl_cargo
            // 
            lbl_cargo.AutoSize = true;
            lbl_cargo.Location = new Point(49, 173);
            lbl_cargo.Name = "lbl_cargo";
            lbl_cargo.Size = new Size(47, 20);
            lbl_cargo.TabIndex = 7;
            lbl_cargo.Text = "cargo";
            lbl_cargo.Click += label4_Click;
            // 
            // lbl_salario
            // 
            lbl_salario.AutoSize = true;
            lbl_salario.Location = new Point(49, 211);
            lbl_salario.Name = "lbl_salario";
            lbl_salario.Size = new Size(53, 20);
            lbl_salario.TabIndex = 8;
            lbl_salario.Text = "salario";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(183, 39);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(125, 27);
            txt_nombre.TabIndex = 9;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(183, 79);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(125, 27);
            txt_apellido.TabIndex = 10;
            txt_apellido.TextChanged += textBox2_TextChanged;
            // 
            // txt_edad
            // 
            txt_edad.Location = new Point(183, 122);
            txt_edad.Name = "txt_edad";
            txt_edad.Size = new Size(125, 27);
            txt_edad.TabIndex = 11;
            // 
            // txt_salario
            // 
            txt_salario.Location = new Point(183, 204);
            txt_salario.Name = "txt_salario";
            txt_salario.Size = new Size(125, 27);
            txt_salario.TabIndex = 13;
            // 
            // cmb_cargo
            // 
            cmb_cargo.FormattingEnabled = true;
            cmb_cargo.Items.AddRange(new object[] { "Administrativo", "Tecnico" });
            cmb_cargo.Location = new Point(183, 165);
            cmb_cargo.Name = "cmb_cargo";
            cmb_cargo.Size = new Size(125, 28);
            cmb_cargo.TabIndex = 14;
            cmb_cargo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 467);
            Controls.Add(cmb_cargo);
            Controls.Add(txt_salario);
            Controls.Add(txt_edad);
            Controls.Add(txt_apellido);
            Controls.Add(txt_nombre);
            Controls.Add(lbl_salario);
            Controls.Add(lbl_cargo);
            Controls.Add(lbl_edad);
            Controls.Add(lbl_apellido);
            Controls.Add(lbl_nombre);
            Controls.Add(dgvEmpleado);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_guardar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_guardar;
        private Button btn_eliminar;
        private DataGridView dgvEmpleado;
        private Label lbl_nombre;
        private Label lbl_apellido;
        private Label lbl_edad;
        private Label lbl_cargo;
        private Label lbl_salario;
        private TextBox txt_Nombre;
        private TextBox txt_Apellido;
        private TextBox txt_Edad;
        private TextBox txt_Salario;
        private ComboBox cmb_cargo;
    }
}
