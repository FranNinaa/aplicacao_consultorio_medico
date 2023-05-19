namespace Apresentacao
{
    partial class FormCadastroMedico
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
            textNomeMedico = new TextBox();
            TextTelefone = new MaskedTextBox();
            txtValorConsulta = new MaskedTextBox();
            labelValorConsulta = new Label();
            labelTelefone = new Label();
            labelNome = new Label();
            label1 = new Label();
            textCodigo = new TextBox();
            buttonSalvar = new Button();
            buttonCancelar = new Button();
            SuspendLayout();
            // 
            // textNomeMedico
            // 
            textNomeMedico.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textNomeMedico.Location = new Point(33, 128);
            textNomeMedico.Name = "textNomeMedico";
            textNomeMedico.Size = new Size(357, 27);
            textNomeMedico.TabIndex = 1;
            // 
            // TextTelefone
            // 
            TextTelefone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextTelefone.Location = new Point(33, 204);
            TextTelefone.Mask = "( 00 ) 00000 - 0000";
            TextTelefone.Name = "TextTelefone";
            TextTelefone.Size = new Size(166, 27);
            TextTelefone.TabIndex = 3;
            TextTelefone.TextAlign = HorizontalAlignment.Center;
            // 
            // txtValorConsulta
            // 
            txtValorConsulta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorConsulta.Location = new Point(33, 279);
            txtValorConsulta.Mask = "$ 000,00";
            txtValorConsulta.Name = "txtValorConsulta";
            txtValorConsulta.Size = new Size(166, 27);
            txtValorConsulta.TabIndex = 3;
            txtValorConsulta.TextAlign = HorizontalAlignment.Center;
            // 
            // labelValorConsulta
            // 
            labelValorConsulta.AutoSize = true;
            labelValorConsulta.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelValorConsulta.Location = new Point(53, 256);
            labelValorConsulta.Name = "labelValorConsulta";
            labelValorConsulta.Size = new Size(131, 20);
            labelValorConsulta.TabIndex = 24;
            labelValorConsulta.Text = "Valor da Consulta";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTelefone.Location = new Point(53, 172);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(69, 20);
            labelTelefone.TabIndex = 23;
            labelTelefone.Text = "Telefone";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.Location = new Point(53, 105);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(52, 20);
            labelNome.TabIndex = 22;
            labelNome.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(53, 31);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 21;
            label1.Text = "Codigo";
            // 
            // textCodigo
            // 
            textCodigo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textCodigo.Location = new Point(33, 54);
            textCodigo.Name = "textCodigo";
            textCodigo.ReadOnly = true;
            textCodigo.Size = new Size(100, 27);
            textCodigo.TabIndex = 20;
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = SystemColors.ActiveCaption;
            buttonSalvar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalvar.Location = new Point(283, 340);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.RightToLeft = RightToLeft.Yes;
            buttonSalvar.Size = new Size(107, 34);
            buttonSalvar.TabIndex = 31;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = SystemColors.ActiveCaption;
            buttonCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(161, 339);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.RightToLeft = RightToLeft.Yes;
            buttonCancelar.Size = new Size(107, 35);
            buttonCancelar.TabIndex = 30;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // FormCadastroMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(404, 386);
            Controls.Add(buttonSalvar);
            Controls.Add(buttonCancelar);
            Controls.Add(textNomeMedico);
            Controls.Add(TextTelefone);
            Controls.Add(txtValorConsulta);
            Controls.Add(labelValorConsulta);
            Controls.Add(labelTelefone);
            Controls.Add(labelNome);
            Controls.Add(label1);
            Controls.Add(textCodigo);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroMedico";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Médico";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNomeMedico;
        private MaskedTextBox TextTelefone;
        private MaskedTextBox txtValorConsulta;
        private Label labelValorConsulta;
        private Label labelTelefone;
        private Label labelNome;
        private Label label1;
        private TextBox textCodigo;
        private Button buttonSalvar;
        private Button buttonCancelar;
    }
}