

USE students_db

DROP TABLE score
DROP TABLE users
DROP TABLE students
DROP TABLE course

CREATE TABLE users (
	username VARCHAR(100) NOT NULL PRIMARY KEY,
	password VARCHAR(100) NOT NULL,
	email VARCHAR(100) NOT NULL
)

insert into users (username, password, email) values ('admin123', 'admin123', 'admin123@gmail.com')

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

CREATE TABLE course (
	id VARCHAR(20) NOT NULL PRIMARY KEY,
	label VARCHAR(100),
	preiod INT,
	description VARCHAR(500)
)

insert into course (id, label, preiod, description) values ('CS_12', 'CSharp', 10, 'C# (C-Sharp) is a programming language developed by Microsoft that runs on the .NET Framework. C# is used to develop web apps, desktop apps, mobile apps, ...');
insert into course (id, label, preiod, description) values ('JAVA_08','Java | Oracle', 10, 'About Java. Java + Alice Java + Greenfoot Oracle Academy for Educators Java Magazine');

CREATE TABLE score (
	student_code VARCHAR(10) FOREIGN KEY REFERENCES students(code),
	course_id VARCHAR(20) FOREIGN KEY REFERENCES course(id),
	student_score FLOAT,
	description TEXT,
	PRIMARY KEY (student_code, course_id)
)

