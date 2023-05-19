namespace Apresentacao
{
    partial class FormCadastroConsulta
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
            buttonSalvar = new Button();
            buttonCancelar = new Button();
            label1 = new Label();
            comboBoxRetorno = new ComboBox();
            textHora = new MaskedTextBox();
            textData = new MaskedTextBox();
            textNomeMedico = new TextBox();
            textNomePaciente = new TextBox();
            textBoxCodigo = new TextBox();
            label5 = new Label();
            data = new Label();
            lblMedico = new Label();
            labelIDpaciente = new Label();
            labelCodigo = new Label();
            medicoBindingSource = new BindingSource(components);
            medicoNegociosBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)medicoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)medicoNegociosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = SystemColors.ActiveCaption;
            buttonSalvar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalvar.Location = new Point(261, 373);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.RightToLeft = RightToLeft.Yes;
            buttonSalvar.Size = new Size(102, 31);
            buttonSalvar.TabIndex = 33;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = SystemColors.ActiveCaption;
            buttonCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(153, 373);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.RightToLeft = RightToLeft.Yes;
            buttonCancelar.Size = new Size(102, 32);
            buttonCancelar.TabIndex = 32;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(49, 312);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 45;
            label1.Text = "Retorno";
            // 
            // comboBoxRetorno
            // 
            comboBoxRetorno.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxRetorno.FormattingEnabled = true;
            comboBoxRetorno.Items.AddRange(new object[] { "", "Sim", "Não" });
            comboBoxRetorno.Location = new Point(33, 335);
            comboBoxRetorno.Name = "comboBoxRetorno";
            comboBoxRetorno.Size = new Size(121, 28);
            comboBoxRetorno.TabIndex = 5;
            // 
            // textHora
            // 
            textHora.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textHora.Location = new Point(164, 264);
            textHora.Mask = "00 : 00 h";
            textHora.Name = "textHora";
            textHora.Size = new Size(108, 27);
            textHora.TabIndex = 4;
            textHora.TextAlign = HorizontalAlignment.Center;
            textHora.ValidatingType = typeof(DateTime);
            // 
            // textData
            // 
            textData.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textData.Location = new Point(33, 264);
            textData.Mask = "00/00/0000";
            textData.Name = "textData";
            textData.Size = new Size(108, 27);
            textData.TabIndex = 3;
            textData.TextAlign = HorizontalAlignment.Center;
            // 
            // textNomeMedico
            // 
            textNomeMedico.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textNomeMedico.Location = new Point(33, 121);
            textNomeMedico.Name = "textNomeMedico";
            textNomeMedico.Size = new Size(324, 27);
            textNomeMedico.TabIndex = 1;
            // 
            // textNomePaciente
            // 
            textNomePaciente.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textNomePaciente.Location = new Point(33, 194);
            textNomePaciente.Name = "textNomePaciente";
            textNomePaciente.Size = new Size(324, 27);
            textNomePaciente.TabIndex = 2;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCodigo.Location = new Point(33, 57);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.ReadOnly = true;
            textBoxCodigo.Size = new Size(106, 27);
            textBoxCodigo.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(176, 241);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 38;
            label5.Text = "Hora";
            // 
            // data
            // 
            data.AutoSize = true;
            data.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            data.Location = new Point(49, 241);
            data.Name = "data";
            data.Size = new Size(45, 20);
            data.TabIndex = 37;
            data.Text = "Data";
            // 
            // lblMedico
            // 
            lblMedico.AutoSize = true;
            lblMedico.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMedico.Location = new Point(49, 98);
            lblMedico.Name = "lblMedico";
            lblMedico.Size = new Size(140, 20);
            lblMedico.TabIndex = 36;
            lblMedico.Text = "Nome do Médico";
            // 
            // labelIDpaciente
            // 
            labelIDpaciente.AutoSize = true;
            labelIDpaciente.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelIDpaciente.Location = new Point(49, 171);
            labelIDpaciente.Name = "labelIDpaciente";
            labelIDpaciente.Size = new Size(148, 20);
            labelIDpaciente.TabIndex = 35;
            labelIDpaciente.Text = "Nome do Paciente";
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCodigo.Location = new Point(49, 22);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(64, 20);
            labelCodigo.TabIndex = 34;
            labelCodigo.Text = "Código";
            // 
            // medicoBindingSource
            // 
            medicoBindingSource.DataSource = typeof(ObjetoTransferencia.Medico);
            // 
            // medicoNegociosBindingSource
            // 
            medicoNegociosBindingSource.DataSource = typeof(RegraNegocios.MedicoNegocios);
            // 
            // FormCadastroConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(375, 417);
            Controls.Add(label1);
            Controls.Add(comboBoxRetorno);
            Controls.Add(textHora);
            Controls.Add(textData);
            Controls.Add(textNomeMedico);
            Controls.Add(textNomePaciente);
            Controls.Add(textBoxCodigo);
            Controls.Add(label5);
            Controls.Add(data);
            Controls.Add(lblMedico);
            Controls.Add(labelIDpaciente);
            Controls.Add(labelCodigo);
            Controls.Add(buttonSalvar);
            Controls.Add(buttonCancelar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroConsulta";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Consulta";
            ((System.ComponentModel.ISupportInitialize)medicoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)medicoNegociosBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSalvar;
        private Button buttonCancelar;
        private Label label1;
        private ComboBox comboBoxRetorno;
        private MaskedTextBox textHora;
        private MaskedTextBox textData;
        private TextBox textNomeMedico;
        private TextBox textNomePaciente;
        private TextBox textBoxCodigo;
        private Label label5;
        private Label data;
        private Label lblMedico;
        private Label labelIDpaciente;
        private Label labelCodigo;
        private BindingSource medicoBindingSource;
        private BindingSource medicoNegociosBindingSource;
    }
}