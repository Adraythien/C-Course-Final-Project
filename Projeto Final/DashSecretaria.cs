using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace Projeto_Final
{
    public partial class DashSecretaria : MetroFramework.Controls.MetroUserControl
    {
        public DashSecretaria()
        {
            InitializeComponent();
        }
      
        public void ContaUsers()
        {
          
           
            try
            {
                string conn = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
                string Query = "SELECT COUNT(*) FROM Plataforma.users;";
               
                MySqlConnection conDatabase = new MySqlConnection(conn);
                MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
                MySqlDataReader reader;
                conDatabase.Open();
                reader = cmdDatabase.ExecuteReader();               
               
                
                while (reader.Read())
                {

                    pb_Users.Text = "";
                    pb_Users.Text = reader.GetString(0);
                }

                reader.Close();
                conDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
                
            }
        }

      

        public void ShowTime()
        {
            
            lbTime.Text = DateTime.Now.ToString(""+"HH:mm");
            lbSeconds.Text = DateTime.Now.ToString(""+"ss");
            lbDate.Text = DateTime.Now.ToString(""+"MMM dd yyyy");
            lbDay.Text = DateTime.Now.ToString(""+"dddd");

            
        }

        public void ShowCPURAM()
        {
            PerformanceCounter pCPU = new PerformanceCounter();
            PerformanceCounter pRAM = new PerformanceCounter();
          
            pCPU.CategoryName = "Processor";
            pCPU.CounterName = "% Processor Time";
            pCPU.InstanceName = "_Total";

            pRAM.CategoryName = "Memory";
            pRAM.CounterName = "% Committed Bytes In Use";
            

            float cpu = pCPU.NextValue();
            float ram = pRAM.NextValue();


            pb_CPU.Value = Convert.ToInt32(cpu);
            pb_RAM.Value = Convert.ToInt32(ram);


            pb_CPU.Text = string.Format("" + "{0:0}%", cpu);
            pb_RAM.Text = string.Format("" + "{0:0}%", ram);

            cpu = 0;
            ram = 0;
        }
        
    }
}
