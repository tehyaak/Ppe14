using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE14
{
    public partial class form_base : Form
    {
        public form_base()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            form_prof ListeEleve = new form_prof();
            ListeEleve.MdiParent = this;
            ListeEleve.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            form_admin admin = new form_admin();
            admin.MdiParent = this;
            admin.Show();
        }
    }
}
