using System;
using System.Windows.Forms;

namespace PausasActivas.Modulos
{
    public partial class TemorizadoresForm : Form
    {
        public TemorizadoresForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Temporizadores y Alertas";
            this.Size = new System.Drawing.Size(725, 669);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Name = "TemorizadoresForm";
        }
    }
}