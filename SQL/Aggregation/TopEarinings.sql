
SELECT MAX(Months * Salary), COUNT(Employee_Id)
FROM Employee
WHERE Months * Salary = (SELECT MAX(Months * Salary)
                        FROM Employee);