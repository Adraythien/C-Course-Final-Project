using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Final
{
    public partial class EditarTeste : MetroFramework.Controls.MetroUserControl
    {
        static MySqlConnection conn = new MySqlConnection();
        static MySqlCommand cmd = new MySqlCommand();
        public static string IDTESTEouNao { get; set; }
        public static int NUMP { get; set; }
        public static string titulo { get; set; }
        public static int index { get; set; }
        List<MetroFramework.Controls.MetroLabel> LabelP = new List<MetroFramework.Controls.MetroLabel>();
        static List<MetroFramework.Controls.MetroRadioButton> radioButtons = new List<MetroFramework.Controls.MetroRadioButton>();
        List<MetroFramework.Controls.MetroLabel> LabelsResp = new List<MetroFramework.Controls.MetroLabel>();

        public static int entrou { get; set; }
        
        public EditarTeste()
        {
            InitializeComponent();
        }

        public static void ADDP_Click(object sender, EventArgs e)
        {
            entrou++;
            NUMP++;
            Perguntas frm = new Perguntas();
            frm.Show();
            frm.LBLNumP.Text=Perguntas.TesteOuNao().ToString();
            
        }

        public static int numeroP { get; set; }

        

        static DataTable dataEU = new DataTable();
        static EditarTeste wat = new EditarTeste();
        

        
    }

}
