select br.name from car as main 
inner join brand as br on main.brand_id = br.id
group by br.name, main.brand_id 
HAVING 3 <= (select count(id) from car where brand_id = main.brand_id)