----------------------------------------CREATING Database ---------------------------------------------------------------------------------------------
GO
CREATE DATABASE Examination_System_Logins
GO
USE Examination_System_Logins
GO
----------------------------------------CREATING TABLES AND CONSTRIANTS -------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------- 1- Logins TABLE -------------------------------------------------------------------------------------------
CREATE TABLE Logins
(
	Username VARCHAR(50) NOT NULL,
	Password VARCHAR(50) NOT NULL,
	AccountType CHAR(1) NOT NULL,
	CONSTRAINT PK_Logins_Username PRIMARY KEY (Username)
);