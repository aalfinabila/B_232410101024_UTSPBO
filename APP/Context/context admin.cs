using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTS_PBO_PR.APP.Core;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace winform_mvc.App.Context
{
    internal class TugasContext : DatabaseWrapper
    {
        private static string table = "Data Tugas";

        public static DataTable All()
        {
            string query = @"
        SELECT 
            m.id,
            m.nama,
            m.deskripsi
        FROM 
            tugas m
        JOIN 
            jenis p ON m.id_jenis = p.id";

            DataTable dataTugas = queryExecutor(query);
            return dataTugas;
        }

        public static DataTable getTugasById(int id)
        {
            string query = @"
                SELECT 
                    m.id,
                    m.nama,
                    m.deskripsi
                FROM 
                    tugas m
                JOIN 
                    jenis p ON m.id_jenis = p.id
                WHERE 
                    m.id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
            };

            DataTable dataTugas = queryExecutor(query, parameters);
            return dataTugas;
        }


        public static void AddTugas(M_Tugas TugasBaru)
        {
            string query = $"INSERT INTO {table} (nama, deskripsi) VALUES(@nama, @deskripsi)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama", tugasBaru.nama),
                new NpgsqlParameter("@deskripsi", tugasBaru.deskripsi),
            };

            commandExecutor(query, parameters);
        }

        
        }
    }
}
