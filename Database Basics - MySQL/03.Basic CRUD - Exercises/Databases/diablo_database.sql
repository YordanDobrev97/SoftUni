SELECT country_name, country_code, currency =
    CASE 
        WHEN currency_code = 'EUR' THEN 'Euro'
        ELSE 'Not Euro' 
    END
    FROM countries
ORDER BY country_name;