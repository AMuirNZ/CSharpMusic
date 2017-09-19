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
            string connectionString =
                @"Data Source = LAPTOP-TKI3D179;Initial Catalog=Music2017;Integrated Security=True";
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

        public DataTable FillDGVCDWithCD()
        {
            //create a datatable as we only have one table, the Owner
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select * from CD ", Connection))
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
            string SQL = "select CDID, Name, Artist, Genre from CD where OwnerIDFK = '" + Ownervalue + "' ";


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

        public DataTable FillDGVCDWithCDClick(String CDValue)
        {
            string SQL = "select CDTrackID, TrackName, TrackDuration from CDTracks where CDIDFK = '" + CDValue + "' ";


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

        public string InsertOrUpdateOwner(string Firstname, string Lastname, string ID, string AddOrUpdate)
        {
            try
            {
                //Add gets passed through the parameter
                if (AddOrUpdate == "Add")
                {
                    //Create a Command object //Create a Query. Create and open a connection to SQL Server
                    string query = "INSERT INTO Owner (FirstName, LastName) " + "VALUES(@Firstname, @Lastname)";

                    var myCommand = new SqlCommand(query, Connection);
                    //create params
                    myCommand.Parameters.AddWithValue("Firstname", Firstname);
                    myCommand.Parameters.AddWithValue("LastName", Lastname);
                    Connection.Open();
                    // open connection add in the SQL
                    myCommand.ExecuteNonQuery();
                    Connection.Close();


                }
                //Update gets passed through the parameter
                else if (AddOrUpdate == "Update")
                {
                    var myCommand =
                        new SqlCommand(
                            "UPDATE Owner set FirstName = @Firstname, LastName=@Lastname where OwnerID = @ID ",
                            Connection);
                    //use parameters to prevent SQL injections
                    myCommand.Parameters.AddWithValue("Firstname", Firstname);
                    myCommand.Parameters.AddWithValue("Lastname", Lastname);
                    Connection.Open();
                    //open connection add in the SQ
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }
                //Update gets passed through the parameter
                else if (AddOrUpdate == "Update")
                {
                    var myCommand =
                        new SqlCommand(
                            "UPDATE OWner set FirstName = @Firstname, LastName=@Lastname where OwnerID = @ID ",
                            Connection);
                    //use parameters to prevent SQL injections
                    myCommand.Parameters.AddWithValue("Firstname", Firstname);
                    myCommand.Parameters.AddWithValue("Lastname", Lastname);
                    myCommand.Parameters.AddWithValue("ID", ID);
                    Connection.Open();
                    //open connection add in the SQL
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }
                return " is Successful";

            }
            catch (Exception e)
            {
                //need to get it to close a second time as it jumps the first connection.close if ExecuteNonQuery fails.
                Connection.Close();
                return " has Failed with " + e;

            }
            
        }

        public string DeleteOwnerCDTracks(string ID, string Table)
        {
            //only run if there is something in the textbox
            if (!object.ReferenceEquals(ID, string.Empty))
            {
                var myCommand = new SqlCommand();
                switch (Table)
                {
                    case "Owner":
                        myCommand = new SqlCommand("DELETE FROM Owner WHERE OwnerID = @ID", Connection);
                        break;
                    case "CD":
                        myCommand = new SqlCommand("DELETE FROM CDID = @ID", Connection);
                        break;
                    case "Track":
                        myCommand = new SqlCommand("DELETE FROM CDTracks WHERE TrackID = @ID", Connection);
                        break;
                }
                myCommand.Parameters.AddWithValue("ID", ID);
                //use parameters to prevent SQL injections
                Connection.Open();
                //open connection add in the SQL
                myCommand.ExecuteNonQuery();
                Connection.Close();
                return "Success";
            }
            else
            {
                Connection.Close();
                return "Failed";
            }

        }
        
        }


        }


    

