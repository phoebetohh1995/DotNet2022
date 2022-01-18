--1) Select all the author's details
use pubs

select * from authors

--2) print all the author's full name

select au_fname 'first name', au_lname 'last name' from authors


--3) Print the average price , total price of all the titles

select avg(price) 'Average Price',
sum(price) 'Total Price' from titles

--4) Print the average price of a titles published by '0736'
select avg(price) 'Average Price' 
from titles
where pub_id in (0736)

--5) print the titles whicha have advance min of 3200 and maximum of 5000
select title 'titles', advance 'advance'
from titles 
where advance >= 3200 and advance <= 5000


--6) Print the titles which are of type 'psychology' or 'mod_cook'
select title 'titles', type 'Type'
from titles 
where type = 'mod_cook' or type = 'psychology'

--7) print all titles published before '1991-06-09 00:00:00.000'
select * from titles


--8) Select all the authors from 'CA'
select * from authors

select concat(au_fname, ' ', au_lname) 'Authors name', state 'state'
from authors
where state = 'CA'

--9) Print the average price of titles in every type
select * from titles

select type, avg(price) 'Average price'
from titles
where type in (select type where price is not null)
group by type

--10) print the sum of price of all the books pulished by every publisher
select sum(price) 'Total price', pub_id 'Pub ID'
from titles
group by pub_id 

--11) Print the first published title in every type
select * from titles

--12) calculate the total royalty for every publisher

select sum(royalty) 'royalty', pub_id 'pub id'
from titles
group by pub_id

--13) print the titles sorted by published date
select * from titles
order by pubdate

--14) print the titles sorted by publisher then by price
select * from titles
order by pub_id, price

--15) Print the books published by authors from 'CA'
select * from publishers
where state = 'CA'

--16) Print the author name of books whcih have royalty more than the average royalty of all the titletes
select royalty 'Royalty'
from titles
where royalty > avg(royalty)

--17) Print all the city and the number of pulishers in it, only if the city has more than one publisher

--18) Print the total number of orders for every title
select title_id 'title', COUNT(ord_num) 'Total orders'
from sales
group by title_id


--19) Prin the total number of titles in evry order
SELECT ord_num 'Order No.', COUNT(title_id) 'Total Titles' FROM salesGROUP BY ord_num

--20) Print the order date and the title name
select title 'title name ', ord_date 'order date'
from titles t join [sales] s
on t.title_id = s.title_id

--21) Print all the title names and publisher names
select title, pub_name
from titles t join [publishers] p
on t.pub_id = p.pub_id

--22) print all the publisher names(even if they have not published) and the title names that they have published
select pub_name 'Publisher name', title
from publishers p left outer join [titles] t
on p.pub_id = t.pub_id

--23) print the title id and the number of authors contributing to it

select title_id, count(au_id) 'Number of authors'
from titleauthor
group by title_id


--24) Print the titl name and the author name
select t.title 'title name', a.au_fname 'author name '
from authors a join [titleauthor] ta
on a.au_id = ta.au_id
join titles t on ta.title_id = t.title_id


--25) print the title name, author name and the publisher name
select t.title 'title name', a.au_fname 'author name', p.pub_name 'publisher name'
from authors a join [titleauthor] ta
on a.au_id = ta.au_id
join titles t on ta.title_id = t.title_id
right outer join publishers p on p.pub_id = t.pub_id


--26) print the titl name author name, publisher name, orderid, order date, quantity ordered and the total price
select t.title 'title name', a.au_fname 'author name', p.pub_name 'publisher name', s.ord_date 'order date', 
s.qty 'quantity', s.qty * t.price 'total price'
from authors a join [titleauthor] ta
on a.au_id = ta.au_id
join titles t on ta.title_id = t.title_id
right outer join publishers p on p.pub_id = t.pub_id
right outer join sales s on s.title_id = t.title_id


--27) given a title name print the stores in which it ws sold
select t.title 'title name', st.stor_name 'store name '
from stores st join [sales] sa
on st.stor_id = sa.stor_id
join titles t on t.title_id = sa.title_id


--28) Select the employees who have taken more than 2 orders
select * from employee


--29) Select all the titles and print the first order date (titles that have not be ordered should also be present)
select title 'title', ord_date 'order date'
from titles t left outer join sales s
on t.title_id = s.title_id
order by 1


--30) select all the data from teh orderes and the authors table
select * from sales cross join authors





