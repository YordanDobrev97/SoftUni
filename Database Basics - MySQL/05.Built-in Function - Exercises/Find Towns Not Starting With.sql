SELECT * FROM towns
WHERE NOT (name LIKE 'R%' OR name LIKE 'B%' OR name LIKE 'D%')
ORDER BY name;