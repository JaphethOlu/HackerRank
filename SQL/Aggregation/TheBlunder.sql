/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/

SELECT CEILING((AVG(CAST(Salary AS DECIMAL(9, 5))))
-
AVG(CAST(REPLACE(Salary, '0', '') AS DECIMAL(9, 5))))
FROM Employees;