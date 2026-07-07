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
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(54, 44);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(233, 54);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // TemorizadoresForm
            // 
            ClientSize = new System.Drawing.Size(532, 244);
            Controls.Add(button1);
            Name = "TemorizadoresForm";
            Load += TemorizadoresForm_Load;
            ResumeLayout(false);

        }

        private void TemorizadoresForm_Load(object sender, System.EventArgs e)
        {

        }

        private Button button1;
    }
}
