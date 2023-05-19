namespace Apresentacao
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            statusStrip1 = new StatusStrip();
            versaoMenu = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            menuCadastro = new ToolStripMenuItem();
            menuPaciente = new ToolStripMenuItem();
            menuMedico = new ToolStripMenuItem();
            menuSair = new ToolStripMenuItem();
            btnPaciente = new Button();
            buttonMedico = new Button();
            buttonConsultas = new Button();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.ActiveCaption;
            statusStrip1.Items.AddRange(new ToolStripItem[] { versaoMenu });
            statusStrip1.Location = new Point(0, 435);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(747, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // versaoMenu
            // 
            versaoMenu.BackColor = SystemColors.ActiveCaption;
            versaoMenu.Name = "versaoMenu";
            versaoMenu.Size = new Size(59, 17);
            versaoMenu.Text = "Versão 1.0";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuCadastro, menuSair });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(747, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuCadastro
            // 
            menuCadastro.DropDownItems.AddRange(new ToolStripItem[] { menuPaciente, menuMedico });
            menuCadastro.Name = "menuCadastro";
            menuCadastro.Size = new Size(48, 20);
            menuCadastro.Text = "Inicio";
            // 
            // menuPaciente
            // 
            menuPaciente.Name = "menuPaciente";
            menuPaciente.Size = new Size(119, 22);
            menuPaciente.Text = "Paciente";
            // 
            // menuMedico
            // 
            menuMedico.Name = "menuMedico";
            menuMedico.Size = new Size(119, 22);
            menuMedico.Text = "Médico";
            // 
            // menuSair
            // 
            menuSair.Name = "menuSair";
            menuSair.Size = new Size(38, 20);
            menuSair.Text = "Sair";
            menuSair.Click += menuSair_Click;
            // 
            // btnPaciente
            // 
            btnPaciente.BackColor = SystemColors.ActiveCaption;
            btnPaciente.BackgroundImage = (Image)resources.GetObject("btnPaciente.BackgroundImage");
            btnPaciente.BackgroundImageLayout = ImageLayout.Center;
            btnPaciente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPaciente.Location = new Point(311, 82);
            btnPaciente.Name = "btnPaciente";
            btnPaciente.Size = new Size(184, 129);
            btnPaciente.TabIndex = 3;
            btnPaciente.Text = "Paciente";
            btnPaciente.TextAlign = ContentAlignment.BottomCenter;
            btnPaciente.UseVisualStyleBackColor = false;
            btnPaciente.Click += btnPaciente_Click;
            // 
            // buttonMedico
            // 
            buttonMedico.BackColor = SystemColors.ActiveCaption;
            buttonMedico.BackgroundImage = (Image)resources.GetObject("buttonMedico.BackgroundImage");
            buttonMedico.BackgroundImageLayout = ImageLayout.Center;
            buttonMedico.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMedico.Location = new Point(95, 82);
            buttonMedico.Name = "buttonMedico";
            buttonMedico.Size = new Size(184, 129);
            buttonMedico.TabIndex = 4;
            buttonMedico.Text = "Médico";
            buttonMedico.TextAlign = ContentAlignment.BottomCenter;
            buttonMedico.UseVisualStyleBackColor = false;
            buttonMedico.Click += buttonMedico_Click;
            // 
            // buttonConsultas
            // 
            buttonConsultas.BackColor = SystemColors.ActiveCaption;
            buttonConsultas.BackgroundImage = (Image)resources.GetObject("buttonConsultas.BackgroundImage");
            buttonConsultas.BackgroundImageLayout = ImageLayout.Center;
            buttonConsultas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConsultas.Location = new Point(535, 76);
            buttonConsultas.Name = "buttonConsultas";
            buttonConsultas.Size = new Size(184, 135);
            buttonConsultas.TabIndex = 5;
            buttonConsultas.Text = "Consultas";
            buttonConsultas.TextAlign = ContentAlignment.BottomCenter;
            buttonConsultas.UseVisualStyleBackColor = false;
            buttonConsultas.Click += buttonConsultas_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(747, 457);
            Controls.Add(buttonConsultas);
            Controls.Add(buttonMedico);
            Controls.Add(btnPaciente);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "FrmMenu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Controle Consultório";
            WindowState = FormWindowState.Maximized;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel versaoMenu;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuCadastro;
        private ToolStripMenuItem menuPaciente;
        private ToolStripMenuItem menuMedico;
        private ToolStripMenuItem menuSair;
        private Button btnPaciente;
        private Button buttonMedico;
        private Button buttonConsultas;
    }
}