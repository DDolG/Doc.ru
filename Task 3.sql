select br.name, (select sum(price) from car where brand_id = main.brand_id) as price from car as main 
inner join brand as br on main.brand_id = br.id
group by br.name, main.brand_id 