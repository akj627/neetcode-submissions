-- Write your query below
select employee_id, 
CASE WHEN employee_id % 2 = 0 OR LEFT(name, 1) = 'M' THEN 0
    ELSE salary
    END AS
bonus from employees
order by employee_id