using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HardwareShopBillingSystem
{
    public class DatabaseManager
    {
        private string connectionString;

        public DatabaseManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Executes a SELECT query and returns the resulting DataTable
        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error executing query: " + ex.Message);
            }
            return dataTable;
        }

        // Executes INSERT, UPDATE, or DELETE queries with provided parameters
        public int ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, conn);

                    // Add parameters to the SQL command
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            sqlCommand.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }

                    // Execute the non-query (INSERT, UPDATE, DELETE) and return the number of rows affected
                    return sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error executing non-query: " + ex.Message);
            }
        }

        // Selects all rows from a specified table and returns the resulting DataTable
        public DataTable SelectData(string tableName)
        {
            string query = $"SELECT * FROM {tableName}";
            return ExecuteQuery(query);
        }

        // Inserts a new record into the specified table with given field values
        public int InsertData(string tableName, Dictionary<string, object> fieldValues)
        {
            string fields = string.Join(", ", fieldValues.Keys);
            string valuePlaceholders = string.Join(", ", fieldValues.Keys.Select(k => "@" + k)); // Use parameter placeholders

            string query = $"INSERT INTO {tableName} ({fields}) VALUES ({valuePlaceholders})";

            // Execute the INSERT query with parameterized values
            return ExecuteNonQuery(query, fieldValues);
        }

        // Updates an existing record in the specified table based on the primary key field
        public int UpdateData(string tableName, int primaryKeyValue, string primaryKeyField, Dictionary<string, object> fieldValues)
        {
            List<string> updateFields = new List<string>();
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            foreach (var field in fieldValues)
            {
                string paramName = $"@{field.Key}"; // Use parameterized names
                updateFields.Add($"{field.Key} = {paramName}");
                parameters.Add(paramName, field.Value); // Add parameter to dictionary
            }

            // Construct the UPDATE query
            string updateFieldsString = string.Join(", ", updateFields);
            string query = $"UPDATE {tableName} SET {updateFieldsString} WHERE {primaryKeyField} = @{primaryKeyField}";

            // Add the primary key field and value to the parameters
            parameters.Add($"@{primaryKeyField}", primaryKeyValue);

            // Execute the UPDATE query with parameters and return the number of rows affected
            return ExecuteNonQuery(query, parameters);
        }

        // Deletes a record from the specified table based on the primary key field
        public int DeleteData(string tableName, int primaryKeyValue, string primaryKeyField)
        {
            string query = $"DELETE FROM {tableName} WHERE {primaryKeyField} = @{primaryKeyField}";

            // Create a dictionary with the primary key field and value as parameters
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { primaryKeyField, primaryKeyValue }
            };

            // Execute the DELETE query with the parameters and return the number of rows affected
            return ExecuteNonQuery(query, parameters);
        }
    }
}
