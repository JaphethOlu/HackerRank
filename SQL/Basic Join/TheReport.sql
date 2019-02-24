/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/

SELECT
CASE
    WHEN Grade < 8 THEN NULL
    ELSE Name
END, Grade, Marks
FROM
(SELECT Students.Name, Grades.Grade, Students.Marks
FROM Students
INNER JOIN Grades ON Students.Marks >= Grades.Min_Mark AND Students.Marks <= Grades.Max_Mark) G
ORDER BY Grade DESC, Name ASC;