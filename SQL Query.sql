create database LibraryManagement
use LibraryManagement

create Table Login(
	Username Varchar(150) not Null,
	Password Varchar (20) not Null,
);
Insert into Login (Username,Password) Values ('admin','admin');
Select * From Login

create Table AddNewBook(
	BookName Varchar (150) not Null,
	ISBN Varchar (150) not Null Primary Key,
	PublishDate Varchar (150) not Null,
	Category Varchar (150) not Null,
	Quantity Int not Null,
	AuthorName varchar(255),
);
Insert Into AddNewBook (BookName,ISBN,PublishDate,Category,Quantity) Values ('C++','0-333-40615','12/12/2021','Coding',20);


create Table AddUser(
	UserName Varchar (150) not Null,
	UserID Varchar (150) not Null Primary Key,
	UserContact Varchar (150) not Null, 
	UserEmail Varchar (150) not Null
);


create Table IssueBook(
	UserID Varchar (150) Foreign Key References AddUser(UserID) Not Null,
	ISBN Varchar (150) Foreign Key References AddNewBook(ISBN) Not Null,
	IssueDate Varchar (150) not Null,
	ReturnDate Varchar (150) not Null,
	IsReturned Bit not Null,
	Fine Int not Null,
	Foreign Key (UserID) References AddUser on Delete Cascade,
	Foreign Key (ISBN) References AddNewBook on Delete Cascade
);

Select * From IssueBook

Insert into AddUser(UserName,UserID,UserContact,UserEmail) values('zunaira','001','03000000000','zunaira@gmail.com')
Insert into AddUser(UserName,UserID,UserContact,UserEmail) values('sara','002','03100000000','sara@gmail.com')
