using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum_winform
{
    public class DatabaseHelper
    {
        private string connString =
          "Host=localhost;" +  // server PostgreSQL
          "Port=5432;" +  // port default PostgreSQL
          "Database=DatabasePBO;" +  // nama database
          "Username=postgres;" +  // username
          "Password=20050119";  // password

        public List<User> getAllData()
        {
            List<User> dataUser = new List<User>();
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            using var perintah = new NpgsqlCommand("SELECT id, nama, umur, asal FROM users", conn);
            using var reader = perintah.ExecuteReader();

            while (reader.Read())
            {
                dataUser.Add(new User(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3)));
            }
            return dataUser;
        }

        public void addUser(User user)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            using var perintah = new NpgsqlCommand("INSERT INTO users (nama, umur, asal) VALUES (@nama, @umur, @asal)", conn);
            perintah.Parameters.AddWithValue("nama", user.nama);
            perintah.Parameters.AddWithValue("umur", user.umur);
            perintah.Parameters.AddWithValue("asal", user.asal);
            perintah.ExecuteNonQuery();
        }

        public void editUser(User user)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            using var perintah = new NpgsqlCommand("UPDATE users SET nama=@nama, umur=@umur, asal=@asal WHERE id=@id", conn);
            perintah.Parameters.AddWithValue("asal", user.asal);
            perintah.Parameters.AddWithValue("nama", user.nama);
            perintah.Parameters.AddWithValue("id", user.Id);
            perintah.Parameters.AddWithValue("umur", user.umur);
            perintah.ExecuteNonQuery();
        }

        public void Template(User user)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            using var perintah = new NpgsqlCommand("", conn);
            perintah.ExecuteNonQuery();
        }

        public void deleteData(User user)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            using var perintah = new NpgsqlCommand("DELETE FROM users WHERE id=@id", conn);
            perintah.Parameters.AddWithValue("id", user.Id);
            perintah.ExecuteNonQuery();
        }

    }
}
