create database MarketingManagementApp;

use MarketingManagementApp;

create table Distributor
(
DistributorID int primary key identity(1,1)
,FirstName nvarchar(50) not null
,LastName nvarchar(50) not null
,BirthDate date not null
,Gender nvarchar(10) not null
,Picture varbinary(max)
,Recomendedby nvarchar(50) null
)

create table PersonalINfo
(
PersonalInfoID int primary key identity(1,1)
,DocType nvarchar(20) not null
,DocSeria varchar(10)
,DocNumber varchar(10)
,DateOfIssue date not null
,ExpiryDate date not null
,PersonalNumber varchar(50) not null
,IssuingAuthority nvarchar(100)
,DistributorID int unique
,foreign key (DistributorID) references Distributor(DistributorID)
)

create table ContactInfo
(
ContactInfoID int primary key identity(1,1)
,ContactType nvarchar(20) not null
,ContInfo nvarchar(100) not null
,DistributorID int 
,foreign key (DistributorID) references Distributor(DistributorID)
)


create table Addresses
(
AddressID int primary key identity(1,1)
,AddressType nvarchar(50) not null
,AddresInfo nvarchar(100) not null
,DistributorID int unique
,foreign key (DistributorID) references Distributor(DistributorID)
)

create table Product
(
ProductID int primary key identity(1,1)
,Name nvarchar(100) not null
,Price decimal(9,3) not null

)

create table DistSale
(
DistSaleID int primary key identity(1,1)
,DistributorID int 
,foreign key (DistributorID) references Distributor(DistributorID)
,SaleDate date 
,ProductID int
foreign key (ProductID) references Product(ProductID)
,prodQuantity int null
,totalPrice decimal(9,2) null

)










