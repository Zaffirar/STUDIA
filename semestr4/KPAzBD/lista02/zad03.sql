drop procedure if exists proc2
drop type if exists CzytelnikTable
drop table if exists wynik
go

create type CzytelnikTable as table(czytelnik_id int primary key)
create table wynik(czytelnik_id int primary key, SumarycznaLiczbaDni int)
go

create procedure proc2 
@tab CzytelnikTable readonly
as
begin
		select t.czytelnik_id, SUM(w.Liczba_Dni) as SumarycznaLiczbaDni from @tab t
		join Wypozyczenie w on w.Czytelnik_ID=t.czytelnik_id
		group by t.czytelnik_ID
	return
end
go


declare @czytelnicy CzytelnikTable
insert into @czytelnicy select distinct Czytelnik_ID from Wypozyczenie
insert into wynik exec proc2 @tab = @czytelnicy
go
select * from wynik