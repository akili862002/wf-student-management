using System;
using System.Data.SqlClient;

namespace StudentManager
{
    class SQLHandler
    {
        public string sqlConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\tranv\\OneDrive\\Documents\\Dung_files\\source\\repos\\StudentManager\\StudentManager\\Database1.mdf;Integrated Security=True";

        public SqlDataAdapter getAllStudentsAdapter()
        {
            SqlDataAdapter adapter;
            SqlConnection connection = new SqlConnection(this.sqlConnectionString);
            connection.Open();
            adapter = new SqlDataAdapter("SELECT TOP 10 * FROM Students ORDER BY id DESC", connection);
            connection.Close();
            return adapter;
        }
        public void createStudentSQL(StudentEntity student)
        {
            SqlConnection connection = new SqlConnection(this.sqlConnectionString);
            connection.Open();
            using (SqlCommand command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "insert into Students (first_name, last_name, birthdate, gender, phone, address, avatar) values (@first_name, @last_name, @birthdate, @gender, @phone, @address, @avatar)";
                    command.Parameters.AddWithValue("@first_name", student.first_name);
                    command.Parameters.AddWithValue("@last_name", student.last_name);
                    command.Parameters.AddWithValue("@birthdate", student.birthdate);
                    command.Parameters.AddWithValue("@gender", student.gender);
                    command.Parameters.AddWithValue("@phone", student.phone);
                    command.Parameters.AddWithValue("@address", student.address);
                    command.Parameters.AddWithValue("@avatar", student.avatar);

                    Console.WriteLine(command.CommandText);

                    var stdId = command.ExecuteScalar();
                    Console.WriteLine("New Student", stdId);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            connection.Close();
        }

        public void deleteStudentByIdSQL(int id)
        {
            SqlConnection connection = new SqlConnection(this.sqlConnectionString);
            connection.Open();
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = String.Format("DELETE FROM Students WHERE id = {0}", id);
                var rows_affected = command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }
}
