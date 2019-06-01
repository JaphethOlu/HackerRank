/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/

SELECT TOP 1 City, DATALENGTH(City) AS CityLength
FROM Station
ORDER BY CityLength ASC, City ASC;

SELECT TOP 1 City, DATALENGTH(City) AS CityLength
FROM Station
ORDER BY CityLength DESC, City ASC;