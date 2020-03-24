drop function if exists foo1
Go
create function foo1(@LiczbDni int) returns table
return (select c.PESEL, count(w.Wypozyczenie_ID) as LiczbaEgzemplarzy from dbo.Czytelnik c 
		join dbo.Wypozyczenie w on c.Czytelnik_ID=w.Czytelnik_ID and w.Liczba_Dni>=@LiczbDni 
		group by c.PESEL
		having COUNT(w.Wypozyczenie_ID)>0)
Go
select * from foo1(5)

