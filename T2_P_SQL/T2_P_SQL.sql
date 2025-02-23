SELECT Codigo from fabricante

-- �Y para ordenarlos de forma descendente seg�n el nombre?
SELECT * from fabricante order by nombre desc

-- �C�mo ser�a la instrucci�n para a�adir un registro a esta tabla?
INSERT INTO fabricante
VALUES (0, 'Chino de la esquina')

-- �C�mo ser�a la consulta para actualizar el siguiente registro de la tabla?
UPDATE fabricante
SET nombre = 'Chino de la otra esquina'
WHERE codigo = 0

-- �C�mo es la consulta para borrar todos los registros con el codigo 0 ?
DELETE FROM fabricante
WHERE codigo = 0

-- �C�mo es la consulta para crear esta tabla?
CREATE TABLE FABRICANTES (
Codigo INT PRIMARY KEY,
Nombre varchar(100)
)

-- �C�mo es la consulta para modificar el campo �Nombre� a varchar(50)?
ALTER TABLE fabricante
ALTER COLUMN nombre varchar(50)

-- �C�mo es la consulta para borrar los registros de esta tabla?
TRUNCATE TABLE fabricante

-- �C�mo es la consulta para borrar esta tabla?
DROP TABLE fabricante

-- La nota media debe aparecer con un solo decimal y redondeada hacia arriba
SELECT ROUND(1.3456,1)