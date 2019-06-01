/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/

SELECT Hackers.Hacker_Id, Hackers.Name
FROM Submissions
INNER JOIN Challenges ON Submissions.Challenge_Id = Challenges.Challenge_Id
INNER JOIN Difficulty ON Challenges.Difficulty_Level = Difficulty.Difficulty_Level
INNER JOIN Hackers ON Submissions.Hacker_Id = Hackers.Hacker_Id
WHERE Submissions.Score = Difficulty.Score
GROUP BY Hackers.Hacker_Id, Hackers.Name
HAVING COUNT(*) > 1
ORDER BY COUNT(*) DESC, Hackers.Hacker_Id ASC;