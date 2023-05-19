namespace Apresentacao
{
    partial class FormConsultas
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
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            lblMedico = new Label();
            textNomePaciente = new TextBox();
            dataGridViewConsultas = new DataGridView();
            consultaNegociosBindingSource = new BindingSource(components);
            consultasBindingSource = new BindingSource(components);
            buttonExcluirConsulta = new Button();
            buttonConsultarConsulta = new Button();
            buttonInserirConsulta = new Button();
            buttonAlterarConsulta = new Button();
            buttonPesquisar = new Button();
            Codigo = new DataGridViewTextBoxColumn();
            NomePaciente = new DataGridViewTextBoxColumn();
            NomeMedico = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            Horario = new DataGridViewTextBoxColumn();
            Retorno = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsultas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)consultaNegociosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)consultasBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblMedico
            // 
            lblMedico.AutoSize = true;
            lblMedico.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMedico.Location = new Point(106, 36);
            lblMedico.Name = "lblMedico";
            lblMedico.Size = new Size(148, 20);
            lblMedico.TabIndex = 2;
            lblMedico.Text = "Nome do Paciente";
            // 
            // textNomePaciente
            // 
            textNomePaciente.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textNomePaciente.Location = new Point(290, 29);
            textNomePaciente.Name = "textNomePaciente";
            textNomePaciente.Size = new Size(473, 27);
            textNomePaciente.TabIndex = 7;
            // 
            // dataGridViewConsultas
            // 
            dataGridViewConsultas.AutoGenerateColumns = false;
            dataGridViewConsultas.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Control;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dataGridViewConsultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConsultas.Columns.AddRange(new DataGridViewColumn[] { Codigo, NomePaciente, NomeMedico, Data, Horario, Retorno });
            dataGridViewConsultas.DataSource = consultaNegociosBindingSource;
            dataGridViewConsultas.Location = new Point(12, 86);
            dataGridViewConsultas.Name = "dataGridViewConsultas";
            dataGridViewConsultas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewConsultas.Size = new Size(1023, 225);
            dataGridViewConsultas.TabIndex = 10;
            // 
            // consultaNegociosBindingSource
            // 
            consultaNegociosBindingSource.DataSource = typeof(RegraNegocios.ConsultaNegocios);
            // 
            // consultasBindingSource
            // 
            consultasBindingSource.DataSource = typeof(ObjetoTransferencia.Consultas);
            // 
            // buttonExcluirConsulta
            // 
            buttonExcluirConsulta.BackColor = SystemColors.ActiveCaption;
            buttonExcluirConsulta.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExcluirConsulta.Location = new Point(931, 318);
            buttonExcluirConsulta.Name = "buttonExcluirConsulta";
            buttonExcluirConsulta.Size = new Size(104, 39);
            buttonExcluirConsulta.TabIndex = 14;
            buttonExcluirConsulta.Text = "Excluir";
            buttonExcluirConsulta.UseVisualStyleBackColor = false;
            buttonExcluirConsulta.Click += buttonExcluirConsulta_Click;
            // 
            // buttonConsultarConsulta
            // 
            buttonConsultarConsulta.BackColor = SystemColors.ActiveCaption;
            buttonConsultarConsulta.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConsultarConsulta.Location = new Point(682, 318);
            buttonConsultarConsulta.Name = "buttonConsultarConsulta";
            buttonConsultarConsulta.Size = new Size(111, 42);
            buttonConsultarConsulta.TabIndex = 15;
            buttonConsultarConsulta.Text = "Consultar";
            buttonConsultarConsulta.UseVisualStyleBackColor = false;
            buttonConsultarConsulta.Click += buttonConsultarConsulta_Click_1;
            // 
            // buttonInserirConsulta
            // 
            buttonInserirConsulta.BackColor = SystemColors.ActiveCaption;
            buttonInserirConsulta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonInserirConsulta.Location = new Point(567, 320);
            buttonInserirConsulta.Name = "buttonInserirConsulta";
            buttonInserirConsulta.Size = new Size(109, 40);
            buttonInserirConsulta.TabIndex = 22;
            buttonInserirConsulta.Text = "Inserir";
            buttonInserirConsulta.UseVisualStyleBackColor = false;
            buttonInserirConsulta.Click += buttonInserirConsulta_Click;
            // 
            // buttonAlterarConsulta
            // 
            buttonAlterarConsulta.BackColor = SystemColors.ActiveCaption;
            buttonAlterarConsulta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAlterarConsulta.Location = new Point(799, 317);
            buttonAlterarConsulta.Name = "buttonAlterarConsulta";
            buttonAlterarConsulta.Size = new Size(126, 40);
            buttonAlterarConsulta.TabIndex = 19;
            buttonAlterarConsulta.Text = "Alterar";
            buttonAlterarConsulta.UseVisualStyleBackColor = false;
            buttonAlterarConsulta.Click += buttonAlterarConsulta_Click;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.BackColor = SystemColors.ActiveCaption;
            buttonPesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPesquisar.Location = new Point(820, 22);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(130, 34);
            buttonPesquisar.TabIndex = 23;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = false;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "IDconsultaConsulta";
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle16.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Codigo.DefaultCellStyle = dataGridViewCellStyle16;
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.Width = 90;
            // 
            // NomePaciente
            // 
            NomePaciente.DataPropertyName = "NomePaciente";
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle17.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            NomePaciente.DefaultCellStyle = dataGridViewCellStyle17;
            NomePaciente.HeaderText = "Nome Paciente";
            NomePaciente.Name = "NomePaciente";
            NomePaciente.Width = 300;
            // 
            // NomeMedico
            // 
            NomeMedico.DataPropertyName = "NomeMedico";
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle18.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            NomeMedico.DefaultCellStyle = dataGridViewCellStyle18;
            NomeMedico.HeaderText = "Nome Medico";
            NomeMedico.Name = "NomeMedico";
            NomeMedico.Width = 300;
            // 
            // Data
            // 
            Data.DataPropertyName = "Data";
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle19.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle19.Format = "d";
            dataGridViewCellStyle19.NullValue = null;
            Data.DefaultCellStyle = dataGridViewCellStyle19;
            Data.HeaderText = "Data";
            Data.Name = "Data";
            // 
            // Horario
            // 
            Horario.DataPropertyName = "Horario";
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle20.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle20.Format = "t";
            dataGridViewCellStyle20.NullValue = null;
            Horario.DefaultCellStyle = dataGridViewCellStyle20;
            Horario.HeaderText = "Horário";
            Horario.Name = "Horario";
            // 
            // Retorno
            // 
            Retorno.DataPropertyName = "Retorno";
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle21.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Retorno.DefaultCellStyle = dataGridViewCellStyle21;
            Retorno.HeaderText = "Retorno";
            Retorno.Name = "Retorno";
            Retorno.Width = 90;
            // 
            // FormConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1044, 374);
            Controls.Add(buttonPesquisar);
            Controls.Add(buttonInserirConsulta);
            Controls.Add(buttonAlterarConsulta);
            Controls.Add(buttonConsultarConsulta);
            Controls.Add(buttonExcluirConsulta);
            Controls.Add(dataGridViewConsultas);
            Controls.Add(textNomePaciente);
            Controls.Add(lblMedico);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConsultas";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsultas).EndInit();
            ((System.ComponentModel.ISupportInitialize)consultaNegociosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)consultasBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblMedico;
        private TextBox textNomePaciente;
        private DataGridView dataGridViewConsultas;
        private Button buttonExcluirConsulta;
        private BindingSource consultasBindingSource;
        private Button buttonConsultarConsulta;
        private Button buttonInserirConsulta;
        private Button buttonAlterarConsulta;
        private Button buttonPesquisar;
        private BindingSource consultaNegociosBindingSource;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn NomePaciente;
        private DataGridViewTextBoxColumn NomeMedico;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Horario;
        private DataGridViewTextBoxColumn Retorno;
    }
}