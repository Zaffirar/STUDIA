drop table if exists Imiona
go
create table Imiona(
ID int not null identity(1,1) primary key,
imie varchar(50) not null)
go
drop table if exists Nazwiska
go
create table Nazwiska(
ID int not null identity(1,1) primary key ,
nazwisko varchar(50) not null)
go

insert into Imiona(imie) values
('Julia'),
('Zofia'),
('Maja'),
('Hanna'),
('Zuzana'),
('Antoni'),
('Jan'),
('Jakub'),
('Aleksander'),
('Szymon');
go
insert into Nazwiska(nazwisko) values
('Nowak'),
('Wójcik'),
('Kowalczyk'),
('Mazur'),
('Krawczyk'),
('Woźniak'),
('Kaczmarek'),
('Brzęczyszczykiewicz'),
('Kostka');
go
select * from Imiona
go
select * from Nazwiska
go
drop table if exists dane
go
create table dane(
imie varchar(50) not null,
nazwisko varchar(50) not null,
primary key (imie, nazwisko))
go

drop procedure if exists proc1 
go
create procedure proc1 @n int
as
begin
	declare @a int, @b int
	set @a = (select COUNT(*) from Imiona)
	set @b = (select COUNT(*) from Nazwiska)
	if(@n>@a*@b/2) throw 60000, 'Za duże n!', 1;
	else
	begin
	delete from dane
	declare @imie varchar(50), @nazwisko varchar(50)
	while @n>0
	begin
	set @imie = (select imie from Imiona where ID = (SELECT FLOOR(RAND()*(@a-1)+1)))
	set @nazwisko = (select nazwisko from Nazwiska where ID = (SELECT FLOOR(RAND()*(@b-1)+1)))
	if(not exists(select * from dane where dane.imie=@imie and dane.nazwisko=@nazwisko))
		begin
		insert into dane(imie, nazwisko) values (@imie, @nazwisko)
		set @n=@n-1
		end
	end
	end
end
go
exec proc1 @n=40
go
select * from dane
go