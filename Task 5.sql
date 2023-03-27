SELECT b.name, (select name from car where price = min(c.price) limit 1) as auto from brand as b
inner join car as c on b.id = c.brand_id
group by b.name