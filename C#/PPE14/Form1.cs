using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Collections.Specialized;
using System.Xml;

namespace PPE14
{
    public partial class form_prof : Form
    {
        public form_prof()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Console.WriteLine("Construc form_prof");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("CLICK");
            try
            {
                Console.WriteLine("On est dans le try !");
                String urlEtudiant = "http://localhost/PPE14/vues/afficher-etudiant-prog.php";
                String urlCompetence = "http://localhost/PPE14/vues/afficher-competence-prog.php";
                Console.WriteLine("ON A RECUP LES LIENS");
                WebClient webClient = new WebClient();
                webClient.Proxy = null;
                Console.WriteLine("WebClient declared");
                NameValueCollection etudiants = new NameValueCollection();
                NameValueCollection competences = new NameValueCollection();
                Console.WriteLine("Collection declared");
                etudiants["message"] = "Test";
                Console.WriteLine("Debut byte");
                byte[] reponseEtudiant = webClient.UploadValues(urlEtudiant, "POST", etudiants);
                byte[] reponseCompetence = webClient.UploadValues(urlCompetence, "POST", competences);
                Console.WriteLine("Fin byte");
                Console.WriteLine("Debut encodage");
                string str_reponseEtudiant = Encoding.UTF8.GetString(reponseEtudiant);
                string str_reponseCompetence = Encoding.UTF8.GetString(reponseCompetence);
                Console.WriteLine("Fin encodage");
                Console.WriteLine("DataSet");
                DataSet resultatEtudiant = new DataSet();
                DataSet resultatCompetence = new DataSet();
                Console.WriteLine("XML");
                resultatEtudiant.ReadXml(XmlReader.Create(new StringReader(str_reponseEtudiant)));
                resultatCompetence.ReadXml(XmlReader.Create(new StringReader(str_reponseCompetence)));
                Console.WriteLine(str_reponseEtudiant);
                grid_liste_etu.DataSource = resultatEtudiant.Tables["etudiant"];
                grid_liste_comp.DataSource = resultatCompetence.Tables["competence"];
                Console.WriteLine("Recup XML");
            }
            catch (WebException ex)
            {
                Console.WriteLine("On est dans le catch");
                if (ex.Response is HttpWebResponse)
                {
                    switch (((HttpWebResponse)ex.Response).StatusCode)
                    {
                        case HttpStatusCode.NotFound:
                            break;

                        default:
                            throw ex;
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
