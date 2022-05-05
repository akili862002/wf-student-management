﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace std_management
{
    class Database
    {
        public static string dbServerName = "DESKTOP-7TB6IV3";
        public static string sqlConnectionString = $"Server={dbServerName};Database=students_db;Trusted_Connection=True;";

        public class Auth
        {
            public bool login(string username, string password)
            {
                Cursor.Current = Cursors.WaitCursor;

                SqlConnection connection = new SqlConnection(sqlConnectionString);
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

            public bool checkExistUsername(string username)
            {
                Cursor.Current = Cursors.WaitCursor;

                SqlConnection connection = new SqlConnection(sqlConnectionString);
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = "SELECT * FROM users WHERE username = @username";
                        command.Parameters.Add("@username", username);
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

            public void register(string username, string password, string email)
            {
                Cursor.Current = Cursors.WaitCursor;

                SqlConnection connection = new SqlConnection(sqlConnectionString);
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = "insert into users (email, username, password) values (@email, @username, @password)";
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        Console.WriteLine(command.CommandText);

                        command.ExecuteScalar();
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
        }

        public bool checkExistStudentCode(string code)
        {
            Cursor.Current = Cursors.WaitCursor;

            SqlConnection connection = new SqlConnection(sqlConnectionString);
            connection.Open();
            using (SqlCommand command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "SELECT code FROM Students WHERE code = @code";
                    command.Parameters.AddWithValue("@code", code);
                    SqlDataReader dr = command.ExecuteReader();
                    return dr.HasRows;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            SqlConnection connection = new SqlConnection(sqlConnectionString);
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
            SqlConnection connection = new SqlConnection(sqlConnectionString);
            connection.Open();
            string query = "SELECT * FROM Students ";
            if (!string.IsNullOrEmpty(searchText))
                query += $"WHERE (first_name + ' ' + last_name) LIKE '%{searchText}%' ";
            query += "ORDER BY code DESC";
            adapter = new SqlDataAdapter(query, connection);
            connection.Close();

            Cursor.Current = Cursors.Default;

            return adapter;
        }
        public void createStudentSQL(StudentEntity student)
        {
            Cursor.Current = Cursors.WaitCursor;

            SqlConnection connection = new SqlConnection(sqlConnectionString);
            connection.Open();
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "insert into Students (code, first_name, last_name, birthdate, gender, phone, address, avatar) values (@code, @first_name, @last_name, @birthdate, @gender, @phone, @address, @avatar)";
                command.Parameters.AddWithValue("@code", student.code);
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
                Cursor.Current = Cursors.Default;
            }
            connection.Close();
        }

        public void updateStudentSQL(string code, StudentEntity student)
        {
            Cursor.Current = Cursors.WaitCursor;
            SqlConnection connection = new SqlConnection(sqlConnectionString);
            connection.Open();
            using (SqlCommand command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                       "UPDATE students " +
                       "SET code = @code, first_name = @first_name, last_name = @last_name, birthdate = @birthdate, gender = @gender, phone = @phone, address = @address, avatar = @avatar " +
                       $"WHERE code = {code} ";

                    command.Parameters.AddWithValue("@code", student.code);
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
                    throw ex;
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            connection.Close();
        }

        public void deleteStudentByIdSQL(string code)
        {
            Cursor.Current = Cursors.WaitCursor;
            SqlConnection connection = new SqlConnection(sqlConnectionString);
            connection.Open();
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = String.Format($"DELETE FROM Students WHERE code = @code");
                command.Parameters.AddWithValue("@code", code);
                command.ExecuteNonQuery();
            }
            connection.Close();
            Cursor.Current = Cursors.Default;
        }

        public int countTotalStudents()
        {
            Cursor.Current = Cursors.WaitCursor;
            SqlConnection connection = new SqlConnection(sqlConnectionString);
            connection.Open();
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT COUNT(*) FROM students";
                int totalCount = (Int32)command.ExecuteScalar();
                return totalCount;
            }
            connection.Close();
            Cursor.Current = Cursors.Default;
        }
        public int countTotalStudentsByGender(bool isMale)
        {
            Cursor.Current = Cursors.WaitCursor;
            SqlConnection connection = new SqlConnection(sqlConnectionString);
            connection.Open();
            using (SqlCommand command = connection.CreateCommand())
            {
                string gender = isMale ? "Male" : "Female";
                command.CommandText = $"SELECT COUNT(*) FROM students WHERE gender = '{gender}'";

                int totalCount = (Int32)command.ExecuteScalar();
                return totalCount;
            }
            connection.Close();
            Cursor.Current = Cursors.Default;
        }

    }
}