namespace Apresentacao
{
    partial class FormMedico
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
            labelNome = new Label();
            buttonAlterarMedico = new Button();
            buttonConsultarMedico = new Button();
            dataGridViewMedico = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            iDmedicoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeMedicoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefoneMedicoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorConsultaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            medicoBindingSource = new BindingSource(components);
            buttonInserir = new Button();
            textNomeMedico = new TextBox();
            buttonPesquisar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)medicoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.Location = new Point(91, 39);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(129, 20);
            labelNome.TabIndex = 2;
            labelNome.Text = "Nome do Médico";
            // 
            // buttonAlterarMedico
            // 
            buttonAlterarMedico.BackColor = SystemColors.ActiveCaption;
            buttonAlterarMedico.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAlterarMedico.Location = new Point(676, 323);
            buttonAlterarMedico.Name = "buttonAlterarMedico";
            buttonAlterarMedico.Size = new Size(100, 34);
            buttonAlterarMedico.TabIndex = 14;
            buttonAlterarMedico.Text = "Alterar";
            buttonAlterarMedico.UseVisualStyleBackColor = false;
            buttonAlterarMedico.Click += buttonAlterarMedico_Click;
            // 
            // buttonConsultarMedico
            // 
            buttonConsultarMedico.BackColor = SystemColors.ActiveCaption;
            buttonConsultarMedico.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConsultarMedico.Location = new Point(571, 323);
            buttonConsultarMedico.Name = "buttonConsultarMedico";
            buttonConsultarMedico.Size = new Size(99, 34);
            buttonConsultarMedico.TabIndex = 15;
            buttonConsultarMedico.Text = "Consultar";
            buttonConsultarMedico.UseVisualStyleBackColor = false;
            buttonConsultarMedico.Click += buttonConsultarMedico_Click;
            // 
            // dataGridViewMedico
            // 
            dataGridViewMedico.AllowUserToDeleteRows = false;
            dataGridViewMedico.AllowUserToOrderColumns = true;
            dataGridViewMedico.AutoGenerateColumns = false;
            dataGridViewMedico.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewMedico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMedico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMedico.Columns.AddRange(new DataGridViewColumn[] { Codigo, iDmedicoDataGridViewTextBoxColumn, nomeMedicoDataGridViewTextBoxColumn, telefoneMedicoDataGridViewTextBoxColumn, valorConsultaDataGridViewTextBoxColumn });
            dataGridViewMedico.DataSource = medicoBindingSource;
            dataGridViewMedico.Location = new Point(26, 90);
            dataGridViewMedico.MultiSelect = false;
            dataGridViewMedico.Name = "dataGridViewMedico";
            dataGridViewMedico.ReadOnly = true;
            dataGridViewMedico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMedico.Size = new Size(750, 227);
            dataGridViewMedico.TabIndex = 16;
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "IDmedico";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Codigo.DefaultCellStyle = dataGridViewCellStyle2;
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // iDmedicoDataGridViewTextBoxColumn
            // 
            iDmedicoDataGridViewTextBoxColumn.DataPropertyName = "IDmedico";
            iDmedicoDataGridViewTextBoxColumn.HeaderText = "IDmedico";
            iDmedicoDataGridViewTextBoxColumn.Name = "iDmedicoDataGridViewTextBoxColumn";
            iDmedicoDataGridViewTextBoxColumn.ReadOnly = true;
            iDmedicoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeMedicoDataGridViewTextBoxColumn
            // 
            nomeMedicoDataGridViewTextBoxColumn.DataPropertyName = "NomeMedico";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nomeMedicoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            nomeMedicoDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeMedicoDataGridViewTextBoxColumn.Name = "nomeMedicoDataGridViewTextBoxColumn";
            nomeMedicoDataGridViewTextBoxColumn.ReadOnly = true;
            nomeMedicoDataGridViewTextBoxColumn.Width = 300;
            // 
            // telefoneMedicoDataGridViewTextBoxColumn
            // 
            telefoneMedicoDataGridViewTextBoxColumn.DataPropertyName = "TelefoneMedico";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.Format = "(00) 00000 - 0000";
            dataGridViewCellStyle4.NullValue = null;
            telefoneMedicoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            telefoneMedicoDataGridViewTextBoxColumn.HeaderText = "Telefone";
            telefoneMedicoDataGridViewTextBoxColumn.Name = "telefoneMedicoDataGridViewTextBoxColumn";
            telefoneMedicoDataGridViewTextBoxColumn.ReadOnly = true;
            telefoneMedicoDataGridViewTextBoxColumn.Width = 150;
            // 
            // valorConsultaDataGridViewTextBoxColumn
            // 
            valorConsultaDataGridViewTextBoxColumn.DataPropertyName = "ValorConsulta";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.Format = "#,##0,00";
            valorConsultaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            valorConsultaDataGridViewTextBoxColumn.HeaderText = "Valor da Consulta";
            valorConsultaDataGridViewTextBoxColumn.Name = "valorConsultaDataGridViewTextBoxColumn";
            valorConsultaDataGridViewTextBoxColumn.ReadOnly = true;
            valorConsultaDataGridViewTextBoxColumn.Width = 150;
            // 
            // medicoBindingSource
            // 
            medicoBindingSource.DataSource = typeof(ObjetoTransferencia.Medico);
            // 
            // buttonInserir
            // 
            buttonInserir.BackColor = SystemColors.ActiveCaption;
            buttonInserir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonInserir.Location = new Point(471, 323);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(94, 34);
            buttonInserir.TabIndex = 18;
            buttonInserir.Text = "Inserir";
            buttonInserir.UseVisualStyleBackColor = false;
            buttonInserir.Click += buttonInserir_Click;
            // 
            // textNomeMedico
            // 
            textNomeMedico.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textNomeMedico.Location = new Point(249, 36);
            textNomeMedico.Name = "textNomeMedico";
            textNomeMedico.Size = new Size(379, 27);
            textNomeMedico.TabIndex = 19;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.BackColor = SystemColors.ActiveCaption;
            buttonPesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPesquisar.Location = new Point(664, 29);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(108, 39);
            buttonPesquisar.TabIndex = 24;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = false;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // FormMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(784, 367);
            Controls.Add(buttonPesquisar);
            Controls.Add(textNomeMedico);
            Controls.Add(buttonInserir);
            Controls.Add(dataGridViewMedico);
            Controls.Add(buttonConsultarMedico);
            Controls.Add(buttonAlterarMedico);
            Controls.Add(labelNome);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMedico";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Médicos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedico).EndInit();
            ((System.ComponentModel.ISupportInitialize)medicoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelNome;
        private Button buttonAlterarMedico;
        private Button buttonConsultarMedico;
        private DataGridView dataGridViewMedico;
        private Button buttonInserir;
        private TextBox textNomeMedico;
        private DataGridViewTextBoxColumn NomeMedico;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn ValorConsulta;
        private BindingSource medicoBindingSource;
        private Button buttonPesquisar;
        private DataGridViewTextBoxColumn idPacienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idConsultaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn iDmedicoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeMedicoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefoneMedicoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorConsultaDataGridViewTextBoxColumn;
    }
}