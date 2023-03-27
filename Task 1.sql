select main.id, main.name from car as main where Exists 
(select null from car as tmp where main.brand_id = tmp.brand_id and main.base_id = tmp.id);