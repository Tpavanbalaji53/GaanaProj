//Data Access Layer

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SqlClient;
//using System.Data.SqlTypes;
using EntityLayers;
using BussinessLogicLayers;


namespace DataAccessLayers
{
    public class DataAccessLayer
    {

        public string ConnectionString;

        SqlCommand command = new SqlCommand();
        public DataAccessLayer()
        {
            ConnectionString = @"server= MindC1   ; 
                                       database= MusicDataBase; 
                                       user id= sa; 
                                       password= pass@word1";
        }

        internal UserEntity ViewMusic(UserEntity user)
        {
            throw new NotImplementedException();
        }

        internal object CreateMusic(UserEntity user)
        {
            throw new NotImplementedException();
        }

        public string AddMusicData(UserEntity listOfIndividualUser)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            command = new SqlCommand(createQuery, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@FirstName", listOfIndividualUser.FirstName);
            command.Parameters.AddWithValue("@Email", listOfIndividualUser.Email);
            command.Parameters.AddWithValue("@DOB", listOfIndividualUser.DateOfBirth);
            command.Parameters.AddWithValue("@Id", listOfIndividualUser.UserId);

            SqlParameter outputParameter = new SqlParameter();
            outputParameter.ParameterName = "@Id";
            outputParameter.SqlDbType = System.Data.SqlDbType.Int;
            outputParameter.Direction = System.Data.ParameterDirection.Output;
            command.Parameters.Add(outputParameter);

            connection.Open();
            command.ExecuteNonQuery();

            connection.Close();

            return "Records inserted Successfully";


        }
    }
}

