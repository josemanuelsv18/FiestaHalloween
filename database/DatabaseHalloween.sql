CREATE DATABASE FiestaHalloween;

USE FiestaHalloween;

CREATE TABLE Participantes(
    idParticipante INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(50) NOT NULL,
    contrasena VARCHAR(50) NOT NULL,
    disfraz VARCHAR(50) NOT NULL,
    fotoDisfraz VARCHAR(255) NOT NULL,
    codigoInvitacion VARCHAR(12)
);

CREATE TABLE Puntuacion (
    idPuntaje INT PRIMARY KEY AUTO_INCREMENT,
    puntaje INT NOT NULL CHECK (puntaje BETWEEN 1 AND 10),
    idParticipante INT NOT NULL,
    idVotante INT NOT NULL,
    FOREIGN KEY (idParticipante) REFERENCES Participantes(idParticipante) ON DELETE CASCADE,
    FOREIGN KEY (idVotante) REFERENCES Participantes(idParticipante) ON DELETE CASCADE
);

CREATE TABLE tipoDulce (
    id_tipo INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(100) NOT NULL
);

CREATE TABLE dulces (
    id_dulce INT PRIMARY KEY AUTO_INCREMENT,
    cantidad INT NOT NULL,
    id_tipo INT NOT NULL,
    FOREIGN KEY (id_tipo) REFERENCES tipoDulce(id_tipo) ON DELETE CASCADE
);

CREATE TABLE ParadaDulces(
    id_parada INT PRIMARY KEY AUTO_INCREMENT,
    familiaCasa VARCHAR(100) NOT NULL, -- Apellido de la familia dueña de la casa
    id_dulce INT NOT NULL,
    FOREIGN KEY (id_dulce) REFERENCES dulces(id_dulce) ON DELETE CASCADE
);

-- Relación adicional para registrar los participantes que visitan paradas de dulces
CREATE TABLE VisitaParada (
    id_visita INT PRIMARY KEY AUTO_INCREMENT,
    id_participante INT NOT NULL, -- Participante que visita la parada
    id_parada INT NOT NULL, -- Parada de dulces visitada
    cantidadRecogida INT NOT NULL, -- Cantidad de dulces recogidos
    id_dulce INT NOT NULL, -- Tipo de dulce recogido de la parada
    FOREIGN KEY (id_participante) REFERENCES Participantes(idParticipante) ON DELETE CASCADE,
    FOREIGN KEY (id_parada) REFERENCES ParadaDulces(id_parada) ON DELETE CASCADE,
    FOREIGN KEY (id_dulce) REFERENCES tipoDulce(id_tipo) ON DELETE CASCADE
);