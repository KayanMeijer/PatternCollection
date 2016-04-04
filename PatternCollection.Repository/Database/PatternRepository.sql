USE master
GO

IF DB_ID('PatternCollection') IS NOT NULL
	DROP DATABASE PatternCollection
GO

CREATE DATABASE PatternCollection
GO

USE PatternCollection
GO

CREATE TABLE [User] (
	UserId		UNIQUEIDENTIFIER	NOT NULL,
	FirstName	VARCHAR(20)			NOT NULL,
	LastName	VARCHAR(20)			NOT NULL,
	Age			INT					NOT NULL,

	CONSTRAINT PK_USER PRIMARY KEY (UserId)
)
GO