﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace habilitations2024.bddmanager
{
    public class BddManager
    {
        private static BddManager instance = null;
        private readonly MySqlConnection connection;
        private BddManager(string stringConnect)
        {
            connection = new MySqlConnection(stringConnect);
            connection.Open();
        }


        public static BddManager GetInstance(string stringConnect)
        {
            if (instance == null)
            {
                instance = new BddManager(stringConnect);
            }
            return instance;
        }


        public void ReqUpdate(string stringQuery, Dictionary<string, object> parameters = null)
        {
            MySqlCommand command = new MySqlCommand(stringQuery, connection);
            if (parameters != null)
            {
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                }
            }
            command.Prepare();
            command.ExecuteNonQuery();
        }

        public List<object[]> ReqSelect(string stringQuery, Dictionary<string, object> parameters = null)
        {
            List<object[]> records = new List<object[]>();

            using (MySqlCommand command = new MySqlCommand(stringQuery, connection))
            {
                if (parameters != null)
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }

                command.Prepare();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    int nbCols = reader.FieldCount;

                    while (reader.Read())
                    {
                        object[] attributs = new object[nbCols];
                        reader.GetValues(attributs);
                        records.Add(attributs);
                    }
                    reader.Close();
                }
                
            }
            return records;
        }
    }
}
