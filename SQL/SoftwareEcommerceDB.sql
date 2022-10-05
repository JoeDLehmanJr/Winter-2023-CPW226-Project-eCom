USE master;
-- Delete existing Database if exists and needs removal.
DROP DATABASE IF EXISTS CPW221_Project_eCom;
GO
--------------------------------------------------------

-- Initialize ECommerce Database

CREATE DATABASE CPW221_Project_eCom;
GO

USE CPW221_Project_eCom; 
GO



CREATE TABLE CustomerLogin
(
	CustomerLoginId int PRIMARY KEY IDENTITY (1,1) NOT NULL
	,UserName varchar(60) NOT NULL
	,Password varchar(18) NOT NULL
);

CREATE TABLE Customer(
	CustomerId int PRIMARY KEY IDENTITY (1,1) NOT NULL
	,FirstName varchar(25) NOT NULL
	,LastName varchar(25) NOT NULL
	,Address1 varchar(50)
	,Address2 varchar(50)
	,City varchar(58)
	,State varchar(14)
	,ZipCode int
	,Email varchar(50)
	,IsEmailConfirmed bit
	,IsSubscribed bit

);

CREATE TABLE Invoices(
	OrderNumber int PRIMARY KEY IDENTITY (1,1) NOT NULL
	,OrderDate DateTime NOT NULL
	,Status varchar(255) NOT NULL
	,DueDate datetime
	,IsOnlineOrder bit
);

CREATE TABLE InvoicedItems(
	ProductId int PRIMARY KEY IDENTITY (1,1) NOT NULL
	,Quantity int NOT NULL
);

CREATE TABLE Product(
	ProductId int PRIMARY KEY IDENTITY (1,1) NOT NULL
	,RetailPrice smallmoney	
	,ProductDescription varchar(255) NOT NULL	
);

CREATE TABLE ProductCategory(
	ProductCategoryId int PRIMARY KEY IDENTITY (1,1) NOT NULL
	,ProductCategoryName varchar(75) NOT NULL
	,ProductCategoryDescription varchar(255) NOT NULL
);

ALTER TABLE Customer
ADD CustomerLoginId int NOT NULL REFERENCES CustomerLogin(CustomerLoginId)

ALTER TABLE Invoices
ADD CustomerId int NOT NULL REFERENCES Customer(CustomerId);

ALTER TABLE InvoicedItems
ADD OrderNumber int NOT NULL REFERENCES Invoices(OrderNumber);

ALTER TABLE Product
ADD ProductCategoryId int NOT NULL REFERENCES ProductCategory(ProductCategoryId);