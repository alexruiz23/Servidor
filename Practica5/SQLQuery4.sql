﻿-- Primero insertamos los ciclos con todos sus campos
INSERT INTO Ciclos (Codigo, Siglas, Nombre, Cursos) 
VALUES 
    ('CFGS-DAM', 'DAM', 'Desarrollo de Aplicaciones Multiplataforma', 2),
    ('CFGS-DAW', 'DAW', 'Desarrollo de Aplicaciones Web', 3),
    ('CFGS-ASR', 'ASIR', 'Administración de Sistemas Informáticos en Red', 4);

-- Luego insertamos los alumnos
INSERT INTO Alumnos (DNI, Nombre, Apellidos, Telefono, Edad, Ciclo, Curso)
VALUES 
    ('12345678A', 'Juan', 'García López', '623456789', 19, 'DAM', 1),
    ('98765432B', 'María', 'Martínez Ruiz', '634567890', 21, 'DAM', 2),
    ('45678912C', 'Pedro', 'Sánchez Moreno', '645678901', 20, 'DAW', 1),
    ('78912345D', 'Ana', 'López García', '656789012', 22, 'DAW', 2),
    ('32165498E', 'Carlos', 'González Pérez', '667890123', 18, 'ASIR', 1),
    ('65498732F', 'Laura', 'Fernández Torres', '678901234', 23, 'ASIR', 2);