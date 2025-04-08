using ProjetoTesteClass;

namespace ProjetoTesteDesk
{
    public partial class FrmConsultarUsuario : Form
    {
        public FrmConsultarUsuario()
        {
            InitializeComponent();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var usuario = Usuario.ObterPorId(int.Parse(txtId.Text));
            txtNome.Text = usuario.Nome;
            txtEmail.Text = usuario.Email;
            txtTelefone.Text = usuario.Telefone;
            txtSenha.Text = usuario.Senha;
            chkAtivo.Checked = usuario.Ativo;

            txtId.ReadOnly = false;
            txtNome.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtSenha.ReadOnly = true;
            chkAtivo.Enabled = false;

            btnAlterar.Enabled = true;
            btnInserir.Enabled = false;
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvUsuarios.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvUsuarios.Rows[linha].Cells[0].Value);
            bool ativo = Convert.ToBoolean(dgvUsuarios.Rows[linha].Cells[3].Value);
            if (ativo)
            {
                Usuario.Arquivar(id);
            }
            else
            {
                Usuario.Restaurar(id);
            }
            FrmConsultarUsuario_Load(sender, e);
            MessageBox.Show($"O usuario está:" + (ativo ? "ativo" : "inativo"));
        }

        private void FrmConsultarUsuario_Load(object sender, EventArgs e)
        {
            int linha = 0;

            var lista = Usuario.ObterLista();
            foreach (var usuario in lista)
            {
                dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[linha].Cells[0].Value = usuario.Id;
                dgvUsuarios.Rows[linha].Cells[1].Value = usuario.Nome;
                dgvUsuarios.Rows[linha].Cells[2].Value = usuario.Telefone;
                dgvUsuarios.Rows[linha].Cells[3].Value = usuario.Email;
                dgvUsuarios.Rows[linha].Cells[4].Value = usuario.Ativo;

                linha++;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Usuario usuario = new(txtNome.Text, txtTelefone.Text, txtEmail.Text, txtSenha.Text);
            usuario.Inserir();
            txtId.Text = usuario.Id.ToString();
            FrmConsultarUsuario_Load(sender, e);
        }
    }
}
