using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CSharpMusic
{
    class Database
    {
        //Create Connection and Command and an adapter.
        private SqlConnection Connection = new SqlConnection();
        private SqlCommand Command = new SqlCommand();
        private SqlDataAdapter da = new SqlDataAdapter();
        //The Constructor sets the defaults upon loading the class
        public Database()
        {
            //change the connection string to run from your own music db
            string connectionString = @"Data Source = LAPTOP-TKI3D179;Initial Catalog=Music2017;Integrated Security=True";
            Connection.ConnectionString = connectionString;
            Command.Connection = Connection;
            
        }

        public DataTable FillDGVOwnerWithOwner()
        {
          //create a datatable as we only have one table, the Owner
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select * from Owner ", Connection))
            {
                //connect into the DB and get the SQL
                Connection.Open();
                //open a connection to the DB
                da.Fill(dt);
                //fill the datatable from the SQL
                Connection.Close(); //close the connection
            }
            return dt; //pass the datatable data to the DataGridView
        }

        public List<string> FillListBoxWithGenre()
        {
            var myCommand = new SqlCommand();
            myCommand = new SqlCommand("select genre from UniqueGenre",
                Connection);
            //Create a list to hold all the grnre, then pass it back to the listbox on the form
            List<string> newgenre = new List<string>();
            Connection.Open();
            SqlDataReader reader = myCommand.ExecuteReader();
            //loop through the genres and pass it to a reader, that gets added to the list
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    newgenre.Add(reader["genre"].ToString());
                }
            }
            reader.Close();
            Connection.Close();
            return newgenre; //send the list back to the listbox
        }

        public DataTable FillDGVCDWithOwnerClick(String Ownervalue)
        {
            string SQL = "select Name, Artist, Genre, CDID from CD where OwnerIDFK = '" + Ownervalue + "' ";
            

            using (da = new SqlDataAdapter(SQL, Connection))
            {
                //connect in to the DB and get the SQL
                DataTable dt = new DataTable();
                //create a datatable as we only have one table, the Owner

                Connection.Open();
                //open a connection to the DB
                da.Fill(dt);
                //fill the tatatable from the SQL
                Connection.Close();
                //close the connection

                return dt; 
            }
        }
    
    }


}
