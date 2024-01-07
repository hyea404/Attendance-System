CREATE DATABASE Attendance_Management_System;

USE Attendance_Management_System;

CREATE TABLE User_Table
(
	User_Id INT IDENTITY(1,1),
	User_Name VARCHAR(150) UNIQUE,
	User_Pass VARCHAR(130),
	User_Pho VARCHAR(20),
	User_CNIC VARCHAR(19) UNIQUE,
	User_DOB VARCHAR(10),
	User_Gender VARCHAR(6),
	User_Email VARCHAR(30),
	User_Role VARCHAR(5),
	User_Add VARCHAR(150),
	CONSTRAINT User_Table_PK PRIMARY KEY (User_Id)
);

INSERT INTO User_Table VALUES
('user', '123456', '+11 111 111111', '1111-111111-1', '09/18/2021' , 'Male' , 'user@gmail.com', 'User' , 'Indonesian'),
('admin', '12345678', '+11 111 111111', '2222-222222-1', '09/18/2021' , 'Male' , 'user@gmail.com', 'Admin' , 'Malaysia');

CREATE TABLE Class_Table
(
	Class_ID INT IDENTITY(1, 1),
	Class_Name VARCHAR(150) UNIQUE,
	Class_Total INT,
	Class_Male INT,
	Class_Female INT,
	CONSTRAINT Class_Table_PK PRIMARY KEY (Class_ID)
);

CREATE TABLE Student_Table
(
	Student_ID INT IDENTITY(1, 1),
	Student_Name VARCHAR(150),
	Student_Reg VARCHAR(50) UNIQUE,
	Student_Gender VARCHAR(10),
	Class_ID INT,
	CONSTRAINT Student_Table_PK PRIMARY KEY (Student_ID),
	CONSTRAINT Student_Table_FK FOREIGN KEY (Class_ID) REFERENCES Class_Table (Class_ID) ON DELETE CASCADE
)

CREATE TABLE Attendance_Table
(
	Attendance_ID INT IDENTITY(1, 1),
	Attendance_Date VARCHAR(10),
	Attendance_Status VARCHAR(10) DEFAULT 'Absent',
	Student_ID INT,
	CONSTRAINT Attendance_Table_PK PRIMARY KEY (Attendance_ID),
	CONSTRAINT Attendance_Table_FK FOREIGN KEY (Student_ID) REFERENCES Student_Table (Student_ID) ON DELETE CASCADE
)

SELECT * FROM Attendance_Table