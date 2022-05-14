

USE students_db

DROP TABLE users
CREATE TABLE users (
	id INT IDENTITY(1,1) PRIMARY KEY,
	username VARCHAR(100) NOT NULL,
	password VARCHAR(100) NOT NULL,
	email VARCHAR(100) NOT NULL,
	pic VARCHAR(MAX)
)

insert into users (username, password, email) values ('admin123', 'admin123', 'admin123@gmail.com')

DROP TABLE students
CREATE TABLE students (
	code VARCHAR(10) NOT NULL PRIMARY KEY,
	first_name VARCHAR(50),
	last_name VARCHAR(50), 
	birthdate DATE,
	gender VARCHAR(20) NOT NULL,
	phone VARCHAR (15),  
	address VARCHAR(255), 
	avatar VARCHAR(MAX)
)

DROP TABLE course
CREATE TABLE course (
	id VARCHAR(20) NOT NULL PRIMARY KEY,
	label VARCHAR(100),
	preiod INT,
	description VARCHAR(500)
)

insert into course (id, label, preiod, description) values ('CS_12', 'CSharp', 10, 'C# (C-Sharp) is a programming language developed by Microsoft that runs on the .NET Framework. C# is used to develop web apps, desktop apps, mobile apps, ...');
insert into course (id, label, preiod, description) values ('JAVA_08','Java | Oracle', 10, 'About Java. Java + Alice Java + Greenfoot Oracle Academy for Educators Java Magazine');

DROP TABLE score
CREATE TABLE score (
	student_code VARCHAR(10) FOREIGN KEY REFERENCES students(code),
	course_id VARCHAR(20) FOREIGN KEY REFERENCES course(id),
	student_score FLOAT,
	description TEXT,
	PRIMARY KEY (student_code, course_id)
)

DROP TABLE [group]
CREATE TABLE [group] (
	id INT IDENTITY(1,1) PRIMARY KEY,
	name VARCHAR(50) NOT NULL,
	created_by INT FOREIGN KEY REFERENCES users(id) NOT NULL
)

DROP TABLE contact
CREATE TABLE contact (
	id INT IDENTITY(1,1) PRIMARY KEY,
    firstName VARCHAR(20),
    lastName VARCHAR(20),
    groupId VARCHAR(10),
    phone VARCHAR(15),
    email VARCHAR(100),
    address VARCHAR(100),
    pic VARCHAR(MAX),
    userId INT
)

