CREATE DATABASE aeropuerto; 
USE aeropuerto; 

CREATE TABLE destinos(
	id_destino 	INT 			PRIMARY KEY,
    ciudad		VARCHAR(50)		NOT NULL,
	duracion	TIME			NOT NULL,
    imagen		VARCHAR(255)	NOT NULL
);

CREATE TABLE vuelos(
	id_vuelo		INT 			AUTO_INCREMENT PRIMARY KEY,
    fecha			DATE			NOT NULL, 
    hora_salida		TIME			NOT NULL,
    embarque		VARCHAR(50)		NOT NULL,
    precio			DECIMAL(10,2)	NOT NULL,
    cupo 			INT 			NOT NULL 	DEFAULT 48,
    id_destino 		INT 			NOT NULL,
    FOREIGN KEY (id_destino) REFERENCES destinos(id_destino)
); 

CREATE TABLE boletos(
	id_boleto	VARCHAR(20)	  	PRIMARY KEY,
	nombre		VARCHAR(30)		NOT NULL,
    a_paterno	VARCHAR(30)		NOT NULL,
    a_materno	VARCHAR(30)		NOT NULL,
    asiento		VARCHAR(2)		NOT NULL,
    checked_in	BOOLEAN			NOT NULL DEFAULT FALSE,
    id_vuelo	INT				NOT NULL,
    FOREIGN KEY (id_vuelo) REFERENCES vuelos(id_vuelo)
);


INSERT INTO destinos (id_destino, ciudad, duracion,imagen) VALUES
(1, 'Guadalajara', '00:30:00','destinosImg/guadalajara.jpg'),
(2, 'Monterrey', '01:20:00','destinosImg/monterrey.jpg'),
(3, 'Cancún', '02:12:00','destinosImg/cancun.jpg'),
(4, 'Tijuana', '03:30:00','destinosImg/tijuana.jpg'),
(5, 'Mérida', '02:18:00','destinosImg/merida.jpg');


INSERT INTO vuelos (fecha, hora_salida, embarque, precio, cupo, id_destino) VALUES
('2025-07-10', '06:30:00', 'Bloque A, Acceso 1', 1450.00, 43, 1),
('2025-06-15', '06:30:00', 'Bloque A, Acceso 1', 1450.00, 48, 1),
('2025-06-15', '07:30:00', 'Bloque B, Acceso 1', 1450.00, 48, 1),
('2025-07-20', '06:30:00', 'Bloque A, Acceso 1', 1450.00, 48, 1),
('2025-07-17', '08:15:00', 'Bloque B, Acceso 3', 1799.00, 43, 2),
('2025-07-23', '09:15:00', 'Bloque C, Acceso 3', 1799.00, 48, 2),
('2025-07-17', '11:00:00', 'Bloque C, Acceso 2', 2300.00, 45, 3),
('2025-07-10', '12:30:00', 'Bloque C, Acceso 2', 3300.00, 47, 3),
('2025-07-27', '15:45:00', 'Bloque A, Acceso 4', 2500.00, 48, 4),
('2025-07-28', '16:45:00', 'Bloque A, Acceso 1', 2500.00, 47, 4),
('2025-07-30', '15:45:00', 'Bloque A, Acceso 2', 2500.00, 48, 4),
('2025-07-30', '19:30:00', 'Bloque D, Acceso 1', 1650.00, 47, 5);

INSERT INTO boletos (id_boleto, nombre, a_paterno, a_materno, asiento, checked_in, id_vuelo) VALUES
	('75010007010141','Diego Eduardo','Díaz','Zamudio', 'E1', FALSE, 1),
    ('75010007010203', 'Juan', 'Pérez', 'Pérez', 'A3', FALSE, 1),
    ('75010007010316', 'Ruth', 'López', 'Medina', 'B6', TRUE, 1),
    ('75010007010451', 'Nicole', 'Guzmán', 'Guzmán', 'F1', TRUE, 1),
    ('75010007010504', 'Rosa', 'Fuentes', 'Flores', 'A4', TRUE, 1),
    ('75010007050112', 'Juan', 'Pérez', 'Pérez', 'B2', FALSE, 5),
    ('75010007050217', 'Juana', 'Pérez', 'Pérez', 'B7', FALSE, 5),
    ('75010007050301', 'Ruth', 'Pérez', 'García', 'A1', FALSE, 5),
    ('75010007050453', 'José', 'Pérez', 'García', 'F3', FALSE, 5),
    ('75010007050505', 'Miguel', 'Perez', 'Medina', 'A5', FALSE, 5),
    ('75010007070156', 'Ruth', 'López', 'Medina', 'F6', FALSE, 7),
    ('75010007070244', 'Nicole', 'Guzmán', 'Guzman', 'E4', FALSE, 7),
    ('75010007070301', 'Rosa', 'Fuentes', 'Flores', 'A1', FALSE, 7),
    ('75010007080147', 'Pedro', 'Cornejo', 'Ceja', 'E7', FALSE, 8),
    ('75010007100114', 'Rosa', 'Zamudio', 'Pérez', 'B4', FALSE, 10),
    ('75010007120131', 'Juan', 'Pérez', 'García', 'D1', FALSE, 12); 