/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/

SELECT CAST(SUM(Lat_N) AS DECIMAL(10, 4))
FROM Station
WHERE Lat_N BETWEEN 38.7880 AND 137.2345;