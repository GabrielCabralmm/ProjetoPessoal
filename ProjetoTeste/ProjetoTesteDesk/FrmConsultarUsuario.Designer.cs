namespace ProjetoTesteDesk
{
    partial class FrmConsultarUsuario
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
            btnBuscar = new Button();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            txtTelefone = new MaskedTextBox();
            txtId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            chkAtivo = new CheckBox();
            label6 = new Label();
            dgvUsuarios = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnTelefone = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewCheckBoxColumn();
            btnInserir = new Button();
            btnAlterar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.Highlight;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.Control;
            btnBuscar.Location = new Point(300, 46);
            btnBuscar.Margin = new Padding(4, 3, 4, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 30);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.Control;
            txtNome.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(80, 95);
            txtNome.Margin = new Padding(4, 3, 4, 3);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(294, 26);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Control;
            txtEmail.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(80, 140);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(294, 26);
            txtEmail.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.Control;
            txtSenha.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(80, 232);
            txtSenha.Margin = new Padding(4, 3, 4, 3);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(294, 26);
            txtSenha.TabIndex = 4;
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = SystemColors.Control;
            txtTelefone.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefone.Location = new Point(80, 186);
            txtTelefone.Margin = new Padding(4, 3, 4, 3);
            txtTelefone.Mask = "+00 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(294, 26);
            txtTelefone.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.Control;
            txtId.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(80, 48);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Name = "txtId";
            txtId.Size = new Size(204, 26);
            txtId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(24, 17);
            label1.TabIndex = 9;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(5, 98);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 17);
            label2.TabIndex = 10;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(5, 144);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 17);
            label3.TabIndex = 11;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(5, 236);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 17);
            label4.TabIndex = 13;
            label4.Text = "Senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(5, 190);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 17);
            label5.TabIndex = 12;
            label5.Text = "Telefone";
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.BackColor = Color.White;
            chkAtivo.Location = new Point(80, 281);
            chkAtivo.Margin = new Padding(4, 3, 4, 3);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 5;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(5, 9);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(189, 27);
            label6.TabIndex = 15;
            label6.Text = "Buscar Usuários";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.BackgroundColor = SystemColors.Control;
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnTelefone, clnEmail, clnAtivo });
            dgvUsuarios.GridColor = SystemColors.Control;
            dgvUsuarios.Location = new Point(467, 91);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(601, 289);
            dgvUsuarios.StandardTab = true;
            dgvUsuarios.TabIndex = 16;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 30;
            // 
            // clnNome
            // 
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 150;
            // 
            // clnTelefone
            // 
            clnTelefone.HeaderText = "Telefone";
            clnTelefone.Name = "clnTelefone";
            clnTelefone.ReadOnly = true;
            clnTelefone.Width = 150;
            // 
            // clnEmail
            // 
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 170;
            // 
            // clnAtivo
            // 
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 60;
            // 
            // btnInserir
            // 
            btnInserir.BackColor = SystemColors.Highlight;
            btnInserir.FlatAppearance.BorderSize = 0;
            btnInserir.FlatStyle = FlatStyle.Flat;
            btnInserir.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInserir.ForeColor = SystemColors.Control;
            btnInserir.Location = new Point(131, 324);
            btnInserir.Margin = new Padding(4, 3, 4, 3);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 30);
            btnInserir.TabIndex = 17;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = SystemColors.Highlight;
            btnAlterar.Enabled = false;
            btnAlterar.FlatAppearance.BorderSize = 0;
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.ForeColor = SystemColors.Control;
            btnAlterar.Location = new Point(243, 324);
            btnAlterar.Margin = new Padding(4, 3, 4, 3);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 30);
            btnAlterar.TabIndex = 18;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            // 
            // FrmConsultarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1123, 450);
            Controls.Add(btnAlterar);
            Controls.Add(btnInserir);
            Controls.Add(dgvUsuarios);
            Controls.Add(label6);
            Controls.Add(chkAtivo);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(txtTelefone);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(btnBuscar);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FrmConsultarUsuario";
            Text = "Consultar Usuário";
            WindowState = FormWindowState.Maximized;
            Load += FrmConsultarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private MaskedTextBox txtTelefone;
        private TextBox txtId;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox chkAtivo;
        private Label label6;
        private DataGridView dgvUsuarios;
        private Button btnInserir;
        private Button btnAlterar;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewCheckBoxColumn clnAtivo;
    }
}
