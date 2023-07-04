using Dapper;
using iText7Example.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace iText7Example.Repository
{
    public class BiodataRepo
    {
        string connectionString = "Server=DESKTOP-VUAHRB4;Initial Catalog=DB_GeneratePdfExample;Integrated Security=True";

        public List<TblBiodata> GetListDataDiri()
        {
            IEnumerable<TblBiodata> result;
            List<TblBiodata> listBiodata = new List<TblBiodata>();

            string query = "select * from tbl_Biodata";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                result = connection.Query<TblBiodata>(query);
            }

            foreach (var item in result)
            {
                listBiodata.Add(item);
            }

            return listBiodata;
        }
    }
}
