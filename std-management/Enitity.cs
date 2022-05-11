using System;

namespace std_management
{
    public class StudentEntity
    {
        public enum GenderType
        {
            Male,
            Famale,
            All
        }

        public string code;
        public string first_name;
        public string last_name;
        public string birthdate;
        public string gender;
        public string phone;
        public string address;
        public string avatar;

        public StudentEntity setCode(string code)
        {
            this.code = code;
            return this;
        }

        public StudentEntity setFirstName(string first_name)
        {
            this.first_name = first_name;
            return this;
        }

        public StudentEntity setLastName(string last_name)
        {
            this.last_name = last_name;
            return this;
        }
        public StudentEntity setBirthdate(DateTime birthdate)
        {
            this.birthdate = birthdate.ToString("yyyy-MM-dd HH:mm:ss");
            return this;
        }
        public StudentEntity setGender(GenderType gender)
        {
            this.gender = gender.ToString();
            return this;
        }
        public StudentEntity setPhone(string phone)
        {
            this.phone = phone;
            return this;
        }

        public StudentEntity setAddress(string address)
        {
            this.address = address;
            return this;
        }
        public StudentEntity setAvatar(string avatar)
        {
            this.avatar = avatar;
            return this;
        }
        public StudentEntity build()
        {
            return this;
        }
    }

    public class Course
    {
        public string id;
        public string label;
        public int preiod;
        public string description;

        public Course setId(string id)
        {
            this.id = id; return this;
        }
        public Course setLabel(string label)
        {
            this.label = label;
            return this;
        }
        public Course setPreiod(int preiod)
        {
            this.preiod = preiod;
            return this;
        }
        public Course setDescription(string description)
        {
            this.description = description;
            return this;
        }
    }

    public class Score
    {
        public string studentCode;
        public string courseId;
        public float studentScore;
        public string description;

        public Score setStudentCode(string studentCode)
        {
            this.studentCode = studentCode ;
            return this;
        }
        public Score setCourseId(string courseId)
        {
            this.courseId = courseId ;
            return this;
        }
        public Score setStudentScore(float studentScore)
        {
            this.studentScore = studentScore;
            return this;
        }
        public Score setDescription(string desc)
        {
            this.description = desc;
            return this;
        }
    }
}
