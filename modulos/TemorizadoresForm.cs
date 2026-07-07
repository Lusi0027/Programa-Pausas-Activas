using System.Windows.Forms;

namespace PausasActivas.Modulos
{
    public class TemorizadoresForm : Form
    {
        public TemorizadoresForm()
        {
            this.Text = "Temporizadores y Alertas";
            this.Size = new System.Drawing.Size(600, 450);
            this.StartPosition = FormStartPosition.CenterParent;

            // TODO Equipo 1: construir la UI aquí
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // TemorizadoresForm
            // 
            ClientSize = new System.Drawing.Size(951, 558);
            Name = "TemorizadoresForm";
            Load += TemorizadoresForm_Load;
            ResumeLayout(false);

        }

        private void TemorizadoresForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
