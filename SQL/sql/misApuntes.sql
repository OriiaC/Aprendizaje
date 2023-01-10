-- Crea una tabla
CREATE TABLE IF NOT EXISTS employeesPrueba (
	id SERIAL PRIMARY KEY,
	name VARCHAR(250) NOT NULL,
	start_at TIME,
	genre CHAR(1),
	salary NUMERIC(9,2) CHECK (SALARY>0),
	email VARCHAR(100) UNIQUE,
	married BOOLEAN,	
	birth_date DATE CHECK (birth_date>'1975-01-01')
);
--Cambiar el nombre de una tabla:
ALTER TABLE IF EXISTS employeesPrueba_2023 RENAME TO employeesPrueba
--Agregar columna a la tabla
ALTER TABLE employeesPrueba ADD COLUMN email VARCHAR(100)
--Borrar columna
ALTER TABLE employeesPrueba DROP COLUMN email
--Ver datos de una tabla
Select * FROM employeesPrueba
--Insertar datos en una tabla
INSERT INTO employeesPrueba
		(name, start_at, genre, salary, email, married, birth_date)
VALUES 	('Ferney', '08:00:00', 'M', 1370000, 'edison.agudelo@hotmail.com', FALSE, '1976-04-26')
--Borrar tabla
DROP TABLE IF EXISTS employeesPrueba