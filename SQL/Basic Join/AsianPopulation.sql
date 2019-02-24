/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/

SELECT SUM(City.Population)
FROM Country
INNER JOIN City ON Country.Code = City.CountryCode
WHERE Country.Continent = "Asia";