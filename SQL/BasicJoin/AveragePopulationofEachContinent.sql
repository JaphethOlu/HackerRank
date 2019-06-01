/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/

SELECT Country.Continent, AVG(City.Population)
FROM Country
INNER JOIN City ON City.CountryCode = Country.Code
GROUP BY Country.Continent;