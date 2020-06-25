--https://leetcode.com/problems/nth-highest-salary/
CREATE FUNCTION getNthHighestSalary(@N INT) RETURNS INT AS
BEGIN
    RETURN (
        
        SELECT DISTINCT salary
        FROM (SELECT salary,
              DENSE_RANK() OVER (ORDER BY salary DESC) AS rank
              FROM employee) t
        WHERE t.rank = @N

        
    );
END
