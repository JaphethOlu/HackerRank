/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/

SELECT COUNT(City) - 
(SELECT COUNT (DISTINCT City) FROM Station)
FROM Station;