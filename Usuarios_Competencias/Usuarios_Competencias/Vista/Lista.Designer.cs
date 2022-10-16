namespace Usuarios_Competencias.Vista
{
    partial class Lista
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
            this.tableLayoutPanelTodo = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.dataGridViewLista = new System.Windows.Forms.DataGridView();
            this.labelCedula = new System.Windows.Forms.Label();
            this.textBoxCedula = new System.Windows.Forms.TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.tableLayoutPanelTodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelTodo
            // 
            this.tableLayoutPanelTodo.ColumnCount = 5;
            this.tableLayoutPanelTodo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelTodo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelTodo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelTodo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelTodo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelTodo.Controls.Add(this.buttonEliminar, 4, 2);
            this.tableLayoutPanelTodo.Controls.Add(this.buttonModificar, 3, 2);
            this.tableLayoutPanelTodo.Controls.Add(this.buttonConsultar, 2, 2);
            this.tableLayoutPanelTodo.Controls.Add(this.buttonCrear, 1, 2);
            this.tableLayoutPanelTodo.Controls.Add(this.dataGridViewLista, 0, 1);
            this.tableLayoutPanelTodo.Controls.Add(this.labelCedula, 0, 0);
            this.tableLayoutPanelTodo.Controls.Add(this.textBoxCedula, 1, 0);
            this.tableLayoutPanelTodo.Controls.Add(this.labelEstado, 2, 0);
            this.tableLayoutPanelTodo.Controls.Add(this.textBoxEstado, 3, 0);
            this.tableLayoutPanelTodo.Controls.Add(this.buttonSalir, 0, 2);
            this.tableLayoutPanelTodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTodo.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTodo.Name = "tableLayoutPanelTodo";
            this.tableLayoutPanelTodo.RowCount = 3;
            this.tableLayoutPanelTodo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelTodo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanelTodo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanelTodo.Size = new System.Drawing.Size(835, 328);
            this.tableLayoutPanelTodo.TabIndex = 0;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEliminar.BackColor = System.Drawing.Color.Lavender;
            this.buttonEliminar.Location = new System.Drawing.Point(699, 276);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(104, 43);
            this.buttonEliminar.TabIndex = 9;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonModificar.BackColor = System.Drawing.Color.Lavender;
            this.buttonModificar.Location = new System.Drawing.Point(532, 276);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(104, 43);
            this.buttonModificar.TabIndex = 8;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConsultar.BackColor = System.Drawing.Color.Lavender;
            this.buttonConsultar.Location = new System.Drawing.Point(365, 276);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(104, 43);
            this.buttonConsultar.TabIndex = 7;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = false;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // buttonCrear
            // 
            this.buttonCrear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCrear.BackColor = System.Drawing.Color.Lavender;
            this.buttonCrear.Location = new System.Drawing.Point(198, 276);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(104, 43);
            this.buttonCrear.TabIndex = 6;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = false;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // dataGridViewLista
            // 
            this.dataGridViewLista.AllowUserToAddRows = false;
            this.dataGridViewLista.AllowUserToDeleteRows = false;
            this.dataGridViewLista.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanelTodo.SetColumnSpan(this.dataGridViewLista, 5);
            this.dataGridViewLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLista.GridColor = System.Drawing.Color.Ivory;
            this.dataGridViewLista.Location = new System.Drawing.Point(3, 35);
            this.dataGridViewLista.Name = "dataGridViewLista";
            this.dataGridViewLista.ReadOnly = true;
            this.dataGridViewLista.RowTemplate.Height = 25;
            this.dataGridViewLista.Size = new System.Drawing.Size(829, 230);
            this.dataGridViewLista.TabIndex = 0;
            this.dataGridViewLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLista_CellClick);
            // 
            // labelCedula
            // 
            this.labelCedula.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCedula.AutoSize = true;
            this.labelCedula.Location = new System.Drawing.Point(26, 6);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(138, 20);
            this.labelCedula.TabIndex = 1;
            this.labelCedula.Text = "Filtrar por cédula:";
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCedula.BackColor = System.Drawing.Color.SeaShell;
            this.textBoxCedula.Location = new System.Drawing.Point(170, 3);
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(161, 27);
            this.textBoxCedula.TabIndex = 2;
            this.textBoxCedula.TextChanged += new System.EventHandler(this.textBoxCedula_TextChanged);
            this.textBoxCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCedula_KeyPress);
            // 
            // labelEstado
            // 
            this.labelEstado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(361, 6);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(137, 20);
            this.labelEstado.TabIndex = 3;
            this.labelEstado.Text = "Filtrar por estado:";
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEstado.BackColor = System.Drawing.Color.SeaShell;
            this.tableLayoutPanelTodo.SetColumnSpan(this.textBoxEstado, 2);
            this.textBoxEstado.Location = new System.Drawing.Point(504, 3);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(328, 27);
            this.textBoxEstado.TabIndex = 4;
            this.textBoxEstado.TextChanged += new System.EventHandler(this.textBoxEstado_TextChanged);
            this.textBoxEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEstado_KeyPress);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSalir.BackColor = System.Drawing.Color.Lavender;
            this.buttonSalir.Location = new System.Drawing.Point(31, 276);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(104, 43);
            this.buttonSalir.TabIndex = 5;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(835, 328);
            this.Controls.Add(this.tableLayoutPanelTodo);
            this.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista";
            this.tableLayoutPanelTodo.ResumeLayout(false);
            this.tableLayoutPanelTodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanelTodo;
        private DataGridView dataGridViewLista;
        private Label labelCedula;
        private TextBox textBoxCedula;
        private Label labelEstado;
        private TextBox textBoxEstado;
        private Button buttonSalir;
        private Button buttonEliminar;
        private Button buttonModificar;
        private Button buttonConsultar;
        private Button buttonCrear;
    }
}