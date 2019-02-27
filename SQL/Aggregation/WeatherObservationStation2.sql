/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/

SELECT CAST(SUM(Lat_N) AS DECIMAL(15, 2)), CAST(SUM(Long_W) AS DECIMAL(15, 2))
FROM Station;
