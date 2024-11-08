using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTS_PBO_PR.APP.Core;

namespace UTS_PBO_PR.APP.Context
    {
        internal class ProdiContext : DatabaseWrapper
        {
            private static string table = "prodi";

            public static DataTable All()
            {
                string query = $"SELECT * FROM {table}";
                DataTable dataTugas = queryExecutor(query);
                return dataTugas;
            }

            public static void AddTugas(M_Tugas newTugas)
            {
                string query = $"INSERT INTO {table} (nama_tugas) values (@nama_tugas)";
                NpgsqlParameter[] parameters =
                {
                new NpgsqlParameter("@nama_tugas", NpgsqlDbType.Varchar){Value = newTugas.nama_tugas,
            };
                commandExecutor(query, parameters);
            }

            public static void UpdateTugas(M_Tugas editTugas)
            {
                string query = $"UPDATE {table} SET nama_tugas = @nama_tugas WHERE id = @id";
                NpgsqlParameter[] parameters =
                {
                new NpgsqlParameter("@nama_tugas", NpgsqlDbType.Varchar){Value = editTugas.nama_tugas},
                new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = editTugas.id}
            };
                commandExecutor(query, parameters);
            }

            public static void DeleteTugas(int id)
            {
                string query = $"DELETE FROM {table} WHERE id = @id";
                NpgsqlParameter[] parameters =
                {
                new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = id},
            };
                commandExecutor(query, parameters);
            }
        }
    }
