/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/

SELECT TOP 1 CAST(Long_W AS DECIMAL(10, 4))
FROM Station
WHERE Lat_N > 38.7780
ORDER BY Lat_N ASC;