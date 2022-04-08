﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace std_management
{
    class SQLHandler
    {
        public string sqlConnectionString = "Server=MAY-28\\SQLEXPRESS;Database=students_db;Trusted_Connection=True;";

        public bool login(string username, string password)
        {
            Cursor.Current = Cursors.WaitCursor;

            SqlConnection connection = new SqlConnection(this.sqlConnectionString);
            connection.Open();
            using (SqlCommand command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "SELECT * FROM users WHERE username = @username AND password = @password";
                    command.Parameters.Add("@username", username);
                    command.Parameters.Add("@password", password);
                    SqlDataReader dr = command.ExecuteReader();
                    return dr.HasRows;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            connection.Close();
            return false;
        }


        public void testConnection()
        {
            SqlConnection connection = new SqlConnection(this.sqlConnectionString);
            connection.Open();
            using (SqlCommand command = connection.CreateCommand())
            {
                MessageBox.Show("Connected!");
            }
            connection.Close();
        }

        public SqlDataAdapter getAllStudentsAdapter(string searchText = "")
        {
            Cursor.Current = Cursors.WaitCursor;

            SqlDataAdapter adapter;
            SqlConnection connection = new SqlConnection(this.sqlConnectionString);
            connection.Open();
            string query = "SELECT * FROM Students ";
            if (!string.IsNullOrEmpty(searchText))
                query += $"WHERE (first_name + ' ' + last_name) LIKE '%{searchText}%' ";
            query += "ORDER BY id DESC";
            adapter = new SqlDataAdapter(query, connection);
            connection.Close();

            Cursor.Current = Cursors.Default;

            return adapter;
        }
        public void createStudentSQL(StudentEntity student)
        {
            Cursor.Current = Cursors.WaitCursor;

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
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            connection.Close();
        }

        public void updateStudentSQL(int id, StudentEntity student)
        {
            Cursor.Current = Cursors.WaitCursor;

            SqlConnection connection = new SqlConnection(this.sqlConnectionString);
            connection.Open();
            using (SqlCommand command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                       "UPDATE students " +
                       "SET (first_name, last_name, birthdate, gender, phone, address, avatar) values (@first_name, @last_name, @birthdate, @gender, @phone, @address, @avatar) " +
                       $"WHERE id = {id} ";

                    command.Parameters.AddWithValue("@first_name", student.first_name);
                    command.Parameters.AddWithValue("@last_name", student.last_name);
                    command.Parameters.AddWithValue("@birthdate", student.birthdate);
                    command.Parameters.AddWithValue("@gender", student.gender);
                    command.Parameters.AddWithValue("@phone", student.phone);
                    command.Parameters.AddWithValue("@address", student.address);
                    command.Parameters.AddWithValue("@avatar", student.avatar);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            connection.Close();
        }

        public void deleteStudentByIdSQL(int id)
        {
            Cursor.Current = Cursors.WaitCursor;
            SqlConnection connection = new SqlConnection(this.sqlConnectionString);
            connection.Open();
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = String.Format($"DELETE FROM Students WHERE id = {id}");
                command.ExecuteNonQuery();
            }
            connection.Close();
            Cursor.Current = Cursors.Default;
        }
    }
}
