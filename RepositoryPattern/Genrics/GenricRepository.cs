using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Genrics
{
    public abstract class GenricRepository<T> 
    {
        protected readonly string ConnectionString;
        public GenricRepository()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
    }
        public abstract T MapEntityFromDataReader(SqlDataReader reader);
        public abstract void CreateEntity(T entity , string tableName);
        public abstract void DeleteEntity(int id, string tableName);
        public abstract void UpdateEntity(T entity , string tableName);
        public List<T> GetEntities(string searchCriteria, string tabelName,
                                   string orderByColumn, string searchColumn,
                                   int page, int recordsPerPage, out int totalRecords)
        {
            List<T> entities = new List<T>();  
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                //Construct the query of pagination 
                string query = $"SELECT * FROM (SELECT * , ROW_NUMBER() OVER(ORDER BY {orderByColumn} AS RowNum FROM {tabelName}" +
                    $" WHERE {GenerateSerachConditionForCount(searchColumn)})  AS TempTable WHERE RowNum BETWEEN @startIndex AND @endIndex)";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@search", "%" + searchCriteria + "%");

                //Calculate the start and end index of pagination
                int startIndex = (page - 1 ) * recordsPerPage + 1;
                int endIndex = page * recordsPerPage;
                cmd.Parameters.AddWithValue("@startIndex", startIndex);
                cmd.Parameters.AddWithValue("@endIndex", endIndex);

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        T entity = MapEntityFromDataReader(reader);
                        entities.Add(entity);
                    }
                }

                //Get the total records count by pangination
                string countQuery = $"SELECT COUNT(*) FROM {tabelName} WHERE {GenerateSerachConditionForCount(searchColumn)}";
                SqlCommand countCmd = new SqlCommand(countQuery, connection);
                countCmd.Parameters.AddWithValue("@search", "%" + searchCriteria + "%");
                totalRecords = Convert.ToInt32(countCmd.ExecuteScalar());
                return entities;

            }
        }

        private string GenerateSerachConditionForCount(string searchColumn)
        {
            string[] columns = searchColumn.Split(',');
            List<string> condition = new List<string>();
            foreach (var item in columns)
            {
                condition.Add($"{item} LIKE @search");
            }
            return string.Join("OR ", condition);
            
        }
    }
}
