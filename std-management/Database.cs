using System;
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


        public class CourseDB
        {
            public void createCourse(Course course)
            {
                Cursor.Current = Cursors.WaitCursor;
                SqlConnection connection = new SqlConnection(sqlConnectionString);
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "insert into course (id, label, preiod, description) values (@id, @label, @preiod, @description)";
                    command.Parameters.AddWithValue("@id", course.id);
                    command.Parameters.AddWithValue("@label", course.label);
                    command.Parameters.AddWithValue("@preiod", course.preiod);
                    command.Parameters.AddWithValue("@description", course.description);

                    var stdId = command.ExecuteScalar();
                    Cursor.Current = Cursors.Default;
                }
                connection.Close();
            }

            public void updateCourse(string id, Course course)
            {
                Cursor.Current = Cursors.WaitCursor;
                SqlConnection connection = new SqlConnection(sqlConnectionString);
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText =
                        "UPDATE course SET id = @id, label = @label, preiod = @preiod, description = @description " +
                         $"WHERE id = '{id}'";
                    command.Parameters.AddWithValue("@id", course.id);
                    command.Parameters.AddWithValue("@label", course.label);
                    command.Parameters.AddWithValue("@preiod", course.preiod);
                    command.Parameters.AddWithValue("@description", course.description);

                    Console.WriteLine(command.CommandText);

                    var stdId = command.ExecuteScalar();
                    Cursor.Current = Cursors.Default;
                }
                connection.Close();
            }

            public SqlDataAdapter getAllCourseAdapter(bool usePrettyData = false)
            {
                Cursor.Current = Cursors.WaitCursor;

                SqlDataAdapter adapter;
                SqlConnection connection = new SqlConnection(sqlConnectionString);
                connection.Open();
                string query;

                if (usePrettyData)
                {
                    query = "SELECT id as [Course id], label as [Label], preiod as [Preiod], description as [Description]  FROM course WHERE 1 = 1";
                }
                else
                {
                    query = "SELECT * FROM course WHERE 1 = 1";
                }

                // query += " ORDER BY code DESC";

                adapter = new SqlDataAdapter(query, connection);
                connection.Close();

                Cursor.Current = Cursors.Default;
                return adapter;
            }

            public int countCourses()
            {
                Cursor.Current = Cursors.WaitCursor;

                SqlConnection connection = new SqlConnection(sqlConnectionString);
                connection.Open();
                int totalCount = 0;

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = String.Format("SELECT COUNT(*) FROM course");
                    // command.ExecuteNonQuery();
                    var reader = command.ExecuteScalar();
                    totalCount = Int32.Parse(reader.ToString());
                }
                connection.Close();

                Cursor.Current = Cursors.Default;
                return totalCount;
            }

            public bool checkExistCourseId(string id)
            {
                Cursor.Current = Cursors.WaitCursor;
                SqlConnection connection = new SqlConnection(sqlConnectionString);
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = "SELECT id FROM course WHERE id = @id";
                        command.Parameters.AddWithValue("@id", id);
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
            public void deleteCourseId(string id)
            {
                Cursor.Current = Cursors.WaitCursor;
                SqlConnection connection = new SqlConnection(sqlConnectionString);
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = String.Format($"DELETE FROM course WHERE id = @id");
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
                connection.Close();
                Cursor.Current = Cursors.Default;
            }
        }

        public class ScoreDB
        {
            public void createScore(Score score)
            {
                Cursor.Current = Cursors.WaitCursor;
                SqlConnection connection = new SqlConnection(sqlConnectionString);
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "insert into score (student_code, course_id, student_score, description) values (@student_code, @course_id, @student_score, @description)";
                    command.Parameters.AddWithValue("@student_code", score.studentCode);
                    command.Parameters.AddWithValue("@course_id", score.courseId);
                    command.Parameters.AddWithValue("@student_score", score.studentScore);
                    command.Parameters.AddWithValue("@description", score.description);

                    var stdId = command.ExecuteScalar();
                    Cursor.Current = Cursors.Default;
                }
                connection.Close();
            }

            public void updateScore(string studentCode, string courseId, Score score)
            {
                Cursor.Current = Cursors.WaitCursor;
                SqlConnection connection = new SqlConnection(sqlConnectionString);
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText =
                        "UPDATE score SET student_code = @student_code, course_id = @course_id, student_score = @student_score, description = @description " +
                         $"WHERE student_code = '{studentCode}' AND course_id = '{courseId}'";
                    command.Parameters.AddWithValue("@student_code", score.studentCode);
                    command.Parameters.AddWithValue("@course_id", score.courseId);
                    command.Parameters.AddWithValue("@student_score", score.studentScore);
                    command.Parameters.AddWithValue("@description", score.description);

                    Console.WriteLine(command.CommandText);

                    var stdId = command.ExecuteScalar();
                    Cursor.Current = Cursors.Default;
                }
                connection.Close();
            }

            public SqlDataAdapter getAllDetailScoreAdapter()
            {
                Cursor.Current = Cursors.WaitCursor;

                SqlDataAdapter adapter;
                SqlConnection connection = new SqlConnection(sqlConnectionString);
                connection.Open();
                string query =
                    "SELECT student_code as [Student code], first_name as [First Name], last_name as [Last name], course_id as [Course id], label as [Label], ROUND(student_score, 2) as [Score] " +
                    "FROM score " +
                    "JOIN students ON score.student_code = students.code " +
                    "JOIN course ON score.course_id = course.id";

                adapter = new SqlDataAdapter(query, connection);
                connection.Close();

                Cursor.Current = Cursors.Default;
                return adapter;
            }

            public SqlDataAdapter getAllAverageScoreByCourseAdapter()
            {
                Cursor.Current = Cursors.WaitCursor;
                SqlDataAdapter adapter;
                SqlConnection connection = new SqlConnection(sqlConnectionString);
                connection.Open();
                string query = "SELECT label as Label, ROUND(AVG(student_score), 3) as [Average grade] FROM score, course WHERE score.course_id = course.id GROUP BY id, course.label";
                adapter = new SqlDataAdapter(query, connection);
                connection.Close();
                Cursor.Current = Cursors.Default;
                return adapter;
            }

            public void deleteScore(string studentCode, string courseId)
            {
                Cursor.Current = Cursors.WaitCursor;
                SqlConnection connection = new SqlConnection(sqlConnectionString);
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = String.Format($"DELETE FROM score WHERE student_code = @student_code AND course_id = @course_id");
                    command.Parameters.AddWithValue("@student_code", studentCode);
                    command.Parameters.AddWithValue("@course_id", courseId);
                    command.ExecuteNonQuery();
                }
                connection.Close();
                Cursor.Current = Cursors.Default;
            }

            public bool checkExistScore(string student_code, string course_id)
            {
                Cursor.Current = Cursors.WaitCursor;
                SqlConnection connection = new SqlConnection(sqlConnectionString);
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = $"SELECT * FROM score WHERE student_code = '{student_code}' AND course_id = '{course_id}'";
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
                    command.CommandText = "SELECT code FROM students WHERE code = @code";
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
        public SqlDataAdapter getAllStudentsAdapter(
            string searchText = "",
            StudentEntity.GenderType gender = StudentEntity.GenderType.All,
            DateTime? fromDate = null,
            DateTime? toDate = null)
        {
            Cursor.Current = Cursors.WaitCursor;

            SqlDataAdapter adapter;
            SqlConnection connection = new SqlConnection(sqlConnectionString);
            connection.Open();
            string query = "SELECT * FROM Students WHERE 1 = 1";
            if (!string.IsNullOrEmpty(searchText))
                query += $" AND (first_name + ' ' + last_name) LIKE '%{searchText}%' ";

            if (gender.ToString() != StudentEntity.GenderType.All.ToString())
                query += $" AND gender = '{gender.ToString()}'";

            if (fromDate != null && toDate != null)
                query += $" AND birthdate BETWEEN '{fromDate.ToString()}' AND '{toDate.ToString()}'";


            query += " ORDER BY code DESC";
            adapter = new SqlDataAdapter(query, connection);
            connection.Close();

            Cursor.Current = Cursors.Default;

            return adapter;
        }

        public SqlDataAdapter getAllStudentsWithSelectAdapter(string select = "*")
        {
            Cursor.Current = Cursors.WaitCursor;

            SqlDataAdapter adapter;
            SqlConnection connection = new SqlConnection(sqlConnectionString);
            connection.Open();
            string query = $"SELECT {select} FROM Students WHERE 1 = 1";
            adapter = new SqlDataAdapter(query, connection);
            connection.Close();
            Cursor.Current = Cursors.Default;

            return adapter;
        }

        public SqlDataAdapter getAllStudentsWithFormatSelectionAdapter(
           string selectString = "*")
        {
            Cursor.Current = Cursors.WaitCursor;

            SqlDataAdapter adapter;
            SqlConnection connection = new SqlConnection(sqlConnectionString);
            connection.Open();
            string query = $"SELECT {selectString} FROM Students WHERE 1 = 1";
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
