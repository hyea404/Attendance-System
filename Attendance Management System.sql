CREATE DATABASE Attendance_Management_System;

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