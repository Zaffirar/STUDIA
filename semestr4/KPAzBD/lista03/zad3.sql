drop table if exists Bufor
drop table if exists Historia
drop table if exists Parametry
go
create table Bufor(
id int identity(1,1) primary key, 
AdresUrl varchar(255), 
OstatnieWejscie datetime)

create table Historia(
id int identity(1,1) primary key,
AdresUrl varchar(255),
OstatnieWejscie datetime)

create table Parametry(
nazwa varchar(50) primary key,
wartosc int)
go

insert into Parametry values
('max_cache', 2)
go

drop trigger if exists BuforInsert
drop trigger if exists HistoriaInsert 
go

create trigger BuforInsert on Bufor instead of insert as
begin
if (select AdresUrl from inserted) in (select AdresUrl from Bufor)
begin
	update Bufor 
	set Bufor.OstatnieWejscie=(select OstatnieWejscie from inserted)
	where Bufor.AdresUrl=(select AdresUrl from inserted)
end
else
begin
	if (select count(*) from Bufor)>=(select wartosc from Parametry where nazwa='max_cache')
	begin
		insert Historia select AdresUrl, OstatnieWejscie from Bufor where id=(select top 1 id from Bufor order by OstatnieWejscie) 
		delete from Bufor where id=(select top 1 id from Bufor order by OstatnieWejscie) 
	end
	insert Bufor select AdresUrl, OstatnieWejscie from inserted
	end
end
go

create trigger HistoriaInsert on Historia instead of insert as
begin
if (select AdresUrl from inserted) in (select AdresUrl from Historia)
begin
	update Historia 
	set Historia.OstatnieWejscie=(select OstatnieWejscie from inserted)
	where Historia.AdresUrl=(select AdresUrl from inserted)
end
else
begin
	insert Historia select AdresUrl, OstatnieWejscie from inserted
end
end
go



insert into Bufor values
('onet.pl', CURRENT_TIMESTAMP)
go
insert into Bufor values
('wp.pl', CURRENT_TIMESTAMP)
go
insert into Bufor values
('google.com', CURRENT_TIMESTAMP)
go

select * from Bufor 
go
select * from Historia
go

insert into Bufor values
('google.com', CURRENT_TIMESTAMP)
go

select * from Bufor 
go
select * from Historia
go

insert into Bufor values
('onet.pl', CURRENT_TIMESTAMP)
go
insert into Bufor values
('wp.pl', CURRENT_TIMESTAMP)
go
insert into Bufor values
('google.com', CURRENT_TIMESTAMP)
go

select * from Bufor 
go
select * from Historia
go