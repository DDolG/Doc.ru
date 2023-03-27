SELECT c.name, AVG(Pow) as pow_avg from country as c
Inner join brand as b on b.country_id = c.id
Inner join car as cr on cr.brand_id = b.id
group by c.name
order by pow_avg DESC
limit 2