using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace ooplab.Classes
{
    public class sqlOperations
    {
        
            public static SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-72SGCCO;Initial Catalog=usersData;Integrated Security=True; MultipleActiveResultSets = True");

            public static void CheckConnection(SqlConnection tempcnn)
            {
                if (tempcnn.State == ConnectionState.Closed)
                {
                    tempcnn.Open();
                }
                else
                {
                    
                }
            }
        
    }
}