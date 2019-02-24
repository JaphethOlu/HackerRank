/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/

SELECT City.Name
FROM City
INNER JOIN Country ON City.CountryCode = Country.Code
WHERE Country.Continent = "Africa";