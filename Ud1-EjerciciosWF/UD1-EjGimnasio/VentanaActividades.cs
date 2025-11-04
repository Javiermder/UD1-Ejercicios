using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD1_EjGimnasio
{
    public partial class VentanaActividades : Form
    {

        List<Actividad> Actividades = new List<Actividad>();

        public VentanaActividades()
        {
            InitializeComponent();
            this.Load += VentanaActividades_Load;
        }

        Actividad act1 = new Actividad("A01", "Pesas", "Sala 1", "Entrenamiento de mancuernas");
        Actividad act2 = new Actividad("A02", "Spinning", "Sala 2", "Entrenamiento de bicicletas estáticas");
        Actividad act3 = new Actividad("A03", "Yoga", "Sala 3", "Relajate y estira musculos");
        Actividad act4 = new Actividad("A04", "Natación", "Sala 4", "Trae a los peques a aprender a nadar");

        private void VentanaActividades_Load(object sender, EventArgs e)
        {
            Actividades.Add(act1);
            Actividades.Add(act2);
            Actividades.Add(act3);
            Actividades.Add(act4);

            lvActividades.Items.Clear();
            
            foreach (Actividad a in Actividades)
            {
                ListViewItem item = new ListViewItem(a.Codigo);
                item.SubItems.Add(a.Nombre);
                item.SubItems.Add(a.Sala);
                item.SubItems.Add(a.Descripcion);
                lvActividades.Items.Add(item);
            }
        }
    }
}
