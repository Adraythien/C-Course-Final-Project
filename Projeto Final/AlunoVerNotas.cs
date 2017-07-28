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
    public partial class AlunoVerNotas : MetroFramework.Controls.MetroUserControl
    {
        List<MetroFramework.Controls.MetroLabel> LabelsTeste = new List<MetroFramework.Controls.MetroLabel>();
        List<MetroFramework.Controls.MetroLabel> LabelsNota = new List<MetroFramework.Controls.MetroLabel>();
        static MySqlConnection conn = new MySqlConnection();
        static MySqlCommand cmd = new MySqlCommand();
        public static string IDUFCD { get; set; }
        
        

        public AlunoVerNotas()
        {
            InitializeComponent();
        }
        
        
    }
}
