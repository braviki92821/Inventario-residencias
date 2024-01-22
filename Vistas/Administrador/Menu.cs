using Inventario_residencias.Modelos;
using Inventario_residencias.Vistas.Administrador;

namespace Inventario_residencias
{
    public partial class Menu : Form
    {
        private Form activeForm = null;

        public Menu()
        {
            InitializeComponent();
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.usuarioId = 0;
            Session.nombre = null;
            Session.tipo = null;
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnListaItems_Click(object sender, EventArgs e)
        {
            openChildForm(new Lista_Inventario());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new Usuarios());
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.usuarioId = 0;
            Session.nombre = null;
            Session.tipo = null;
            Application.ExitThread();
        }
    }
}
