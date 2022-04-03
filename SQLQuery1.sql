--create database CurrencyExchangeAdo
--go

use CurrencyExchangeAdo
go

create table Currency
(
	CurrencyId int primary key identity(1,1),
	CurrencyName nvarchar(max),
	PurchasePrice money,
	SellPrice money,
	BankName nvarchar(max),
	Relevance date
)
go