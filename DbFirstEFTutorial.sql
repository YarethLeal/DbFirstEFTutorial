-- Database name
CREATE DATABASE DbFirstEFTutorial
USE DbFirstEFTutorial

--Tables
CREATE TABLE Tv_Show
(
	--Entity Framework needs a primary key with identity to add info
	ShowId int Primary Key Identity(1,1)
	,Name nvarchar(50)
	,Chapters int
)

CREATE TABLE Character
(
	CharacterId int Primary Key Identity(1,1)
	,Name nvarchar(50)
	,Gender nvarchar(50)
	,Age int
	,Tv_Show int Foreign Key references Tv_Show(ShowID)
)