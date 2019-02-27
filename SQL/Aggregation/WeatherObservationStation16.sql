/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/

SELECT CAST(MIN(Lat_N) AS DECIMAL(10, 4))
FROM Station
WHERE Lat_N > 38.7880;