
use QuanlyCafe
go

Create table TableFood
(
	id int identity primary key,
	name nvarchar(100) not null default N'Bàn chưa có tên',
	status nvarchar(100) not null default N'Trống',
)
go

create table Account
(
	UserName nvarchar(100) primary key,
	DisplayName nvarchar(100) not null default N'Ker',
	PassWord nvarchar(1000) not null default 0,
	Type int not null
)
go

create table FoodCategory
(
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa đặt tên'
)
go

create table Food
(
	id int identity primary key,
	name nvarchar(100) not null default N'Chưa đặt tên',
	idCategory int not null,
	price Float not null default 0

	foreign key (idCategory) references dbo.FoodCategory(id)
)
go

create table Bill
(
	id int identity primary key,
	DateCheckIn Date null default getdate(),
	DateCheckout date,
	idTable int not null,
	status int not null default 0

	foreign key (idTable) references dbo.TableFood(id)
)
go

create table billinfo
(
	id int identity primary key,
	idBill int not null,
	idFood int not null,
	count int not null default 0
	foreign key (idBill) references dbo.Bill(id),
	foreign key (idFood) references dbo.Food(id)
)
go

create proc USP_GetAccountByUserName
@userName nvarchar(100)
as
begin
	select *from Account Where UserName = @userName
end
go

exec USP_GetAccountByUserName @username = N'kyubi'
go

create proc USP_Login
@userName nvarchar(100),@passWord nvarchar(100)
as
begin
	select * from Account where UserName=@userName and PassWord=@passWord
end
go