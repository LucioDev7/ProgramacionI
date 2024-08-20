using CiclismoDesktopPorCodigo.Views;
using CiclismoDesktopPorCodigo.Views.Linq;

namespace CiclismoDesktop
{
    public partial class MainMenuView : Form
    {
        public MainMenuView()
        {
            InitializeComponent();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gestionDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientsView clientesView = new ClientsView();
            clientesView.ShowDialog();
        }

        private void gestionDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadosView empleadosView = new EmpleadosView();
            empleadosView.ShowDialog();
        }

        private void gestionDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductosView productosView = new ProductosView();
            productosView.ShowDialog();
        }

        private void gestionDeTipoDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoDeProductoView tipoDeProductoView = new TipoDeProductoView();
            tipoDeProductoView.ShowDialog();
        }

        private void gestionDeClientesStoredProceduresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesStoredProceduresView clientesStoreProceduresView = new ClientesStoredProceduresView();
            clientesStoreProceduresView.ShowDialog();
        }

        private void gestionClientesORMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesORMView clientesORMView = new ClientesORMView();
            clientesORMView.ShowDialog();
        }

        private void gestionDeProductosStoredProceduresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductosStoredProceduresView productosStoredProceduresView = new ProductosStoredProceduresView();
            productosStoredProceduresView.ShowDialog();
        }

        private void pruebasLinqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PruebasLinqView pruebasLinq = new PruebasLinqView();
            pruebasLinq.ShowDialog();
        }
    }
}
