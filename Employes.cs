using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier_4_Excercice_1
{
    public partial class Employes : Form
    {
        static string connection_string = ConfigurationManager.ConnectionStrings["mon_connection"].ConnectionString;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
      
        public Employes()
        {
            InitializeComponent();
            try
            {               
                connection = new SqlConnection(connection_string);
                command = new SqlCommand("select * from employees", connection);
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Employes_dataGridView.Rows.Add(reader.GetInt32(0).ToString(), reader.GetSqlString(1),
                    reader.GetSqlString(2), reader.GetSqlString(3), reader.GetSqlString(8), reader.GetSqlString(11));

                }
            }      
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                connection.Close();
            }
       
        }
    }
}
