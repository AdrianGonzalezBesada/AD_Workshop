SELECT Codigo from fabricante

-- ¿Y para ordenarlos de forma descendente según el nombre?
SELECT * from fabricante order by nombre desc

-- ¿Cómo sería la instrucción para añadir un registro a esta tabla?
INSERT INTO fabricante
VALUES (0, 'Chino de la esquina')

-- ¿Cómo sería la consulta para actualizar el siguiente registro de la tabla?
UPDATE fabricante
SET nombre = 'Chino de la otra esquina'
WHERE codigo = 0

-- ¿Cómo es la consulta para borrar todos los registros con el codigo 0 ?
DELETE FROM fabricante
WHERE codigo = 0

-- ¿Cómo es la consulta para crear esta tabla?
CREATE TABLE FABRICANTES (
Codigo INT PRIMARY KEY,
Nombre varchar(100)
)

-- ¿Cómo es la consulta para modificar el campo “Nombre” a varchar(50)?
ALTER TABLE fabricante
ALTER COLUMN nombre varchar(50)

-- ¿Cómo es la consulta para borrar los registros de esta tabla?
TRUNCATE TABLE fabricante

-- ¿Cómo es la consulta para borrar esta tabla?
DROP TABLE fabricante

-- La nota media debe aparecer con un solo decimal y redondeada hacia arriba
SELECT ROUND(1.3456,1)