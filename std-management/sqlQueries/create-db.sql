
CREATE DATABASE students_db
GO

USE students_db

CREATE TABLE users (
	username VARCHAR(100) NOT NULL PRIMARY KEY,
	password VARCHAR(100) NOT NULL,
	email VARCHAR(100) NOT NULL
)

insert into users (username, password, email) values ('admin123', 'admin123', 'admin123@gmail.com')

CREATE TABLE students (
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	first_name VARCHAR(50),
	 last_name VARCHAR(50), 
	 birthdate DATE,
	 gender VARCHAR(20) NOT NULL,
		phone VARCHAR (15),  
		address VARCHAR(255), 
		avatar VARCHAR(400)
)

insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Randall', 'Titcombe', '1/14/2002', 'Male', '3311736335', '86 Dunning Circle', '');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Emmalynn', 'Burgett', '11/14/2001', 'Female', '2697816055', '27 Stone Corner Way', '');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Ariella', 'Gridon', '9/30/1999', 'Female', '6711083075', '1356 Holy Cross Hill', '');


CREATE TABLE course (
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	label VARCHAR(100),
	hours_number INT,
	description VARCHAR(500)
)

insert into course (label, hours_number, description) values ('CSharp', 10, 'C# (C-Sharp) is a programming language developed by Microsoft that runs on the .NET Framework. C# is used to develop web apps, desktop apps, mobile apps, ...');
insert into course (label, hours_number, description) values ('Java | Oracle', 10, 'About Java. Java + Alice Java + Greenfoot Oracle Academy for Educators Java Magazine');

CREATE TABLE score (
	student_id INT,
	course_id INT,
	student_score FLOAT,
	description TEXT,
)