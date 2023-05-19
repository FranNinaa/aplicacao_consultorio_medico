namespace Apresentacao
{
    partial class frmPacienteConsultar
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            btnPesquisa = new Label();
            textPesquisa = new TextBox();
            butonPesquisar = new Button();
            butonInserir = new Button();
            buttonAlterar = new Button();
            buttonExcluir = new Button();
            buttonConsultar = new Button();
            dataGridViewPacientes = new DataGridView();
            idpacienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomePacienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            enderecoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bairroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cepDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sexoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            celularDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pacienteBindingSource = new BindingSource(components);
            pacienteNegociosBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPacientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pacienteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pacienteNegociosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnPesquisa
            // 
            btnPesquisa.AutoSize = true;
            btnPesquisa.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPesquisa.Location = new Point(33, 35);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(146, 20);
            btnPesquisa.TabIndex = 0;
            btnPesquisa.Text = "Consultar Pacientes";
            // 
            // textPesquisa
            // 
            textPesquisa.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textPesquisa.Location = new Point(214, 30);
            textPesquisa.Name = "textPesquisa";
            textPesquisa.Size = new Size(313, 27);
            textPesquisa.TabIndex = 1;
            // 
            // butonPesquisar
            // 
            butonPesquisar.BackColor = SystemColors.ActiveCaption;
            butonPesquisar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            butonPesquisar.Location = new Point(548, 24);
            butonPesquisar.Name = "butonPesquisar";
            butonPesquisar.Size = new Size(110, 42);
            butonPesquisar.TabIndex = 2;
            butonPesquisar.Text = "Pesquisar";
            butonPesquisar.UseVisualStyleBackColor = false;
            butonPesquisar.Click += butonPesquisar_Click;
            // 
            // butonInserir
            // 
            butonInserir.BackColor = SystemColors.ActiveCaption;
            butonInserir.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            butonInserir.Location = new Point(213, 379);
            butonInserir.Name = "butonInserir";
            butonInserir.Size = new Size(120, 39);
            butonInserir.TabIndex = 3;
            butonInserir.Text = "Inserir";
            butonInserir.UseVisualStyleBackColor = false;
            butonInserir.Click += butonInserir_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.BackColor = SystemColors.ActiveCaption;
            buttonAlterar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAlterar.Location = new Point(339, 379);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(113, 39);
            buttonAlterar.TabIndex = 4;
            buttonAlterar.Text = "Alterar";
            buttonAlterar.UseVisualStyleBackColor = false;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = SystemColors.ActiveCaption;
            buttonExcluir.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExcluir.Location = new Point(589, 379);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(118, 39);
            buttonExcluir.TabIndex = 6;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonConsultar
            // 
            buttonConsultar.BackColor = SystemColors.ActiveCaption;
            buttonConsultar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConsultar.Location = new Point(458, 379);
            buttonConsultar.Name = "buttonConsultar";
            buttonConsultar.Size = new Size(125, 39);
            buttonConsultar.TabIndex = 5;
            buttonConsultar.Text = "Consultar";
            buttonConsultar.UseVisualStyleBackColor = false;
            buttonConsultar.Click += buttonConsultar_Click;
            // 
            // dataGridViewPacientes
            // 
            dataGridViewPacientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLightLight;
            dataGridViewPacientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPacientes.AutoGenerateColumns = false;
            dataGridViewPacientes.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPacientes.Columns.AddRange(new DataGridViewColumn[] { idpacienteDataGridViewTextBoxColumn, nomePacienteDataGridViewTextBoxColumn, enderecoDataGridViewTextBoxColumn, bairroDataGridViewTextBoxColumn, numeroDataGridViewTextBoxColumn, cidadeDataGridViewTextBoxColumn, cepDataGridViewTextBoxColumn, sexoDataGridViewTextBoxColumn, telefoneDataGridViewTextBoxColumn, celularDataGridViewTextBoxColumn });
            dataGridViewPacientes.DataSource = pacienteBindingSource;
            dataGridViewPacientes.Location = new Point(12, 81);
            dataGridViewPacientes.MultiSelect = false;
            dataGridViewPacientes.Name = "dataGridViewPacientes";
            dataGridViewPacientes.ReadOnly = true;
            dataGridViewPacientes.RowTemplate.Height = 25;
            dataGridViewPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPacientes.ShowCellToolTips = false;
            dataGridViewPacientes.Size = new Size(699, 283);
            dataGridViewPacientes.TabIndex = 7;
            // 
            // idpacienteDataGridViewTextBoxColumn
            // 
            idpacienteDataGridViewTextBoxColumn.DataPropertyName = "Idpaciente";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            idpacienteDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            idpacienteDataGridViewTextBoxColumn.HeaderText = "Código";
            idpacienteDataGridViewTextBoxColumn.Name = "idpacienteDataGridViewTextBoxColumn";
            idpacienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomePacienteDataGridViewTextBoxColumn
            // 
            nomePacienteDataGridViewTextBoxColumn.DataPropertyName = "NomePaciente";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nomePacienteDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            nomePacienteDataGridViewTextBoxColumn.HeaderText = "Nome do Paciente";
            nomePacienteDataGridViewTextBoxColumn.Name = "nomePacienteDataGridViewTextBoxColumn";
            nomePacienteDataGridViewTextBoxColumn.ReadOnly = true;
            nomePacienteDataGridViewTextBoxColumn.Width = 350;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            enderecoDataGridViewTextBoxColumn.Visible = false;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            bairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro";
            bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            bairroDataGridViewTextBoxColumn.ReadOnly = true;
            bairroDataGridViewTextBoxColumn.Visible = false;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            numeroDataGridViewTextBoxColumn.ReadOnly = true;
            numeroDataGridViewTextBoxColumn.Visible = false;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            cidadeDataGridViewTextBoxColumn.Visible = false;
            // 
            // cepDataGridViewTextBoxColumn
            // 
            cepDataGridViewTextBoxColumn.DataPropertyName = "Cep";
            cepDataGridViewTextBoxColumn.HeaderText = "Cep";
            cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            cepDataGridViewTextBoxColumn.ReadOnly = true;
            cepDataGridViewTextBoxColumn.Visible = false;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            sexoDataGridViewTextBoxColumn.ReadOnly = true;
            sexoDataGridViewTextBoxColumn.Visible = false;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            telefoneDataGridViewTextBoxColumn.Visible = false;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.Format = "( 00 ) 00000 - 0000";
            celularDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            celularDataGridViewTextBoxColumn.ReadOnly = true;
            celularDataGridViewTextBoxColumn.Width = 200;
            // 
            // pacienteBindingSource
            // 
            pacienteBindingSource.DataSource = typeof(ObjetoTransferencia.Paciente);
            // 
            // pacienteNegociosBindingSource
            // 
            pacienteNegociosBindingSource.DataSource = typeof(RegraNegocios.PacienteNegocios);
            // 
            // frmPacienteConsultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(723, 427);
            Controls.Add(dataGridViewPacientes);
            Controls.Add(buttonConsultar);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonAlterar);
            Controls.Add(butonInserir);
            Controls.Add(butonPesquisar);
            Controls.Add(textPesquisa);
            Controls.Add(btnPesquisa);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPacienteConsultar";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Paciente";
            Load += frmPacienteConsultar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPacientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pacienteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pacienteNegociosBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label btnPesquisa;
        private TextBox textPesquisa;
        private Button butonPesquisar;
        private Button butonInserir;
        private Button buttonAlterar;
        private Button buttonExcluir;
        private Button buttonConsultar;
        private DataGridView dataGridViewPacientes;
        private DataGridViewTextBoxColumn codigo;
        private BindingSource pacienteNegociosBindingSource;
        private BindingSource pacienteBindingSource;
        private DataGridViewTextBoxColumn idpacienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomePacienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
    }
}