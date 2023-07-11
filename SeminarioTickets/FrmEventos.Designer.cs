namespace SeminarioTickets
{
    partial class FrmEventos
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
            this.components = new System.ComponentModel.Container();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtReserva = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbLugar = new System.Windows.Forms.ComboBox();
            this.lugaresBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.seminarioTicketsDataSet11 = new SeminarioTickets.SeminarioTicketsDataSet();
            this.lugaresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.seminarioTicketsDataSet = new SeminarioTickets.SeminarioTicketsDataSet();
            this.lugaresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbEvento = new System.Windows.Forms.ComboBox();
            this.tipoEventosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tipoEventosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tipoEventosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.seminarioTicketsDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoEventosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tipoEventosTableAdapter = new SeminarioTickets.SeminarioTicketsDataSetTableAdapters.TipoEventosTableAdapter();
            this.lugaresTableAdapter = new SeminarioTickets.SeminarioTicketsDataSetTableAdapters.LugaresTableAdapter();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lugaresBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lugaresTableAdapter2 = new SeminarioTickets.SeminarioTicketsDataSetTableAdapters.LugaresTableAdapter();
            this.eventosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventosTableAdapter = new SeminarioTickets.SeminarioTicketsDataSetTableAdapters.EventosTableAdapter();
            this.tipoEventosTableAdapter2 = new SeminarioTickets.SeminarioTicketsDataSetTableAdapters.TipoEventosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoEventosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoEventosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoEventosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoEventosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(158, 342);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 33);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvEventos
            // 
            this.dgvEventos.AllowUserToAddRows = false;
            this.dgvEventos.AllowUserToDeleteRows = false;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Location = new System.Drawing.Point(394, 104);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.RowHeadersWidth = 51;
            this.dgvEventos.Size = new System.Drawing.Size(291, 271);
            this.dgvEventos.TabIndex = 10;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacidad.Location = new System.Drawing.Point(136, 272);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(199, 22);
            this.txtCapacidad.TabIndex = 7;
            // 
            // txtReserva
            // 
            this.txtReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReserva.Location = new System.Drawing.Point(136, 300);
            this.txtReserva.Name = "txtReserva";
            this.txtReserva.Size = new System.Drawing.Size(200, 22);
            this.txtReserva.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(136, 128);
            this.txtNombre.MaxLength = 70;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(136, 100);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(199, 22);
            this.txtId.TabIndex = 1;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(136, 188);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 4;
            this.dtpFecha.Value = new System.DateTime(2023, 7, 3, 20, 54, 26, 0);
            // 
            // cmbLugar
            // 
            this.cmbLugar.DataSource = this.lugaresBindingSource3;
            this.cmbLugar.DisplayMember = "NomLug";
            this.cmbLugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLugar.FormattingEnabled = true;
            this.cmbLugar.Location = new System.Drawing.Point(136, 242);
            this.cmbLugar.Name = "cmbLugar";
            this.cmbLugar.Size = new System.Drawing.Size(199, 24);
            this.cmbLugar.TabIndex = 6;
            this.cmbLugar.ValueMember = "IdLug";
            // 
            // lugaresBindingSource3
            // 
            this.lugaresBindingSource3.DataMember = "Lugares";
            this.lugaresBindingSource3.DataSource = this.seminarioTicketsDataSet11;
            // 
            // seminarioTicketsDataSet11
            // 
            this.seminarioTicketsDataSet11.DataSetName = "SeminarioTicketsDataSet1";
            this.seminarioTicketsDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lugaresBindingSource1
            // 
            this.lugaresBindingSource1.DataMember = "Lugares";
            this.lugaresBindingSource1.DataSource = this.seminarioTicketsDataSet;
            // 
            // seminarioTicketsDataSet
            // 
            this.seminarioTicketsDataSet.DataSetName = "SeminarioTicketsDataSet";
            this.seminarioTicketsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lugaresBindingSource
            // 
            this.lugaresBindingSource.DataMember = "Lugares";
            this.lugaresBindingSource.DataSource = this.seminarioTicketsDataSet;
            // 
            // cmbEvento
            // 
            this.cmbEvento.DataSource = this.tipoEventosBindingSource3;
            this.cmbEvento.DisplayMember = "NomEvn";
            this.cmbEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEvento.FormattingEnabled = true;
            this.cmbEvento.Location = new System.Drawing.Point(136, 156);
            this.cmbEvento.Name = "cmbEvento";
            this.cmbEvento.Size = new System.Drawing.Size(200, 24);
            this.cmbEvento.TabIndex = 3;
            this.cmbEvento.ValueMember = "IdEvn";
            // 
            // tipoEventosBindingSource3
            // 
            this.tipoEventosBindingSource3.DataMember = "TipoEventos";
            this.tipoEventosBindingSource3.DataSource = this.seminarioTicketsDataSet11;
            // 
            // tipoEventosBindingSource2
            // 
            this.tipoEventosBindingSource2.DataMember = "TipoEventos";
            this.tipoEventosBindingSource2.DataSource = this.seminarioTicketsDataSet;
            // 
            // tipoEventosBindingSource
            // 
            this.tipoEventosBindingSource.DataMember = "TipoEventos";
            this.tipoEventosBindingSource.DataSource = this.seminarioTicketsDataSet;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(80, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Lugar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Reserva:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Capacidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Hora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tipo Evento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 106);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Eventos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fecha:";
            // 
            // tipoEventosTableAdapter
            // 
            this.tipoEventosTableAdapter.ClearBeforeFill = true;
            // 
            // lugaresTableAdapter
            // 
            this.lugaresTableAdapter.ClearBeforeFill = true;
            // 
            // dtpHora
            // 
            this.dtpHora.AllowDrop = true;
            this.dtpHora.CustomFormat = "00:00:00";
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpHora.Location = new System.Drawing.Point(136, 216);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(200, 20);
            this.dtpHora.TabIndex = 5;
            this.dtpHora.Value = new System.DateTime(2023, 7, 3, 0, 0, 0, 0);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(158, 342);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 33);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(158, 342);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(106, 33);
            this.btnActualizar.TabIndex = 28;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // lugaresBindingSource2
            // 
            this.lugaresBindingSource2.DataMember = "Lugares";
            this.lugaresBindingSource2.DataSource = this.seminarioTicketsDataSet;
            // 
            // lugaresTableAdapter2
            // 
            this.lugaresTableAdapter2.ClearBeforeFill = true;
            // 
            // eventosBindingSource
            // 
            this.eventosBindingSource.DataMember = "Eventos";
            this.eventosBindingSource.DataSource = this.seminarioTicketsDataSet;
            // 
            // eventosTableAdapter
            // 
            this.eventosTableAdapter.ClearBeforeFill = true;
            // 
            // tipoEventosTableAdapter2
            // 
            this.tipoEventosTableAdapter2.ClearBeforeFill = true;
            // 
            // FrmEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(714, 447);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.txtReserva);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cmbLugar);
            this.Controls.Add(this.cmbEvento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.FrmEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoEventosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoEventosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoEventosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoEventosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtReserva;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbLugar;
        private System.Windows.Forms.ComboBox cmbEvento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private SeminarioTicketsDataSet seminarioTicketsDataSet;
        private System.Windows.Forms.BindingSource tipoEventosBindingSource;
        private SeminarioTicketsDataSetTableAdapters.TipoEventosTableAdapter tipoEventosTableAdapter;
        private System.Windows.Forms.BindingSource lugaresBindingSource;
        private SeminarioTicketsDataSetTableAdapters.LugaresTableAdapter lugaresTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.BindingSource seminarioTicketsDataSet1BindingSource;
        private SeminarioTicketsDataSet seminarioTicketsDataSet1;
        private System.Windows.Forms.BindingSource tipoEventosBindingSource1;
        private SeminarioTicketsDataSetTableAdapters.TipoEventosTableAdapter tipoEventosTableAdapter1;
        private System.Windows.Forms.BindingSource lugaresBindingSource1;
        private SeminarioTicketsDataSetTableAdapters.LugaresTableAdapter lugaresTableAdapter1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.BindingSource lugaresBindingSource2;
        private System.Windows.Forms.BindingSource tipoEventosBindingSource2;
        private SeminarioTicketsDataSet seminarioTicketsDataSet11;
        private System.Windows.Forms.BindingSource lugaresBindingSource3;
        private SeminarioTicketsDataSetTableAdapters.LugaresTableAdapter lugaresTableAdapter2;
        private System.Windows.Forms.BindingSource eventosBindingSource;
        private SeminarioTicketsDataSetTableAdapters.EventosTableAdapter eventosTableAdapter;
        private System.Windows.Forms.BindingSource tipoEventosBindingSource3;
        private SeminarioTicketsDataSetTableAdapters.TipoEventosTableAdapter tipoEventosTableAdapter2;
    }
}