SELECT COUNT(c.name)
FROM categories AS c
         JOIN products AS p ON c.id = p.category_id
WHERE c.name = 'appetizers' AND
        category_id = 2 AND
        price >= 8;