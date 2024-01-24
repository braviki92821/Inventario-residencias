
using Inventario_residencias.Modelos;

namespace Inventario_residencias.Vistas.Usuario
{
    public partial class Menu_Usuario : Form
    {
        private Form activeForm = null;

        public Menu_Usuario()
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

        private void btnInventario_Click(object sender, EventArgs e)
        {
            openChildForm(new Tablero_Inventario());
        }

        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {
            Session.usuarioId = 0;
            Session.nombre = null;
            Session.tipo = null;
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
