SELECT * FROM actor
INSERT INTO actor (first_name,last_name,last_update) VALUES ('EDISON', 'AGUDELO', '2022-02-15 04:34:33-05')
DELETE FROM actor WHERE actor_id = '201' AND first_name = 'EDISON'

SELECT * FROM actor;
SELECT last_name, count(last_name) from actor group by last_name;
SELECT last_name, count(last_name) from actor group by last_name HAVING count(last_name) > 1;
SELECT last_name, count(last_name) FROM actor group by last_name ORDER BY last_name
SELECT * FROM actor WHERE first_name = 'PENELOPE';