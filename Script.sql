CREATE SCHEMA unterricht;

CREATE TABLE unterricht.personen (
    id        INT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    vorname   VARCHAR(100) NOT NULL,
    nachname  VARCHAR(100) NOT NULL
);

INSERT INTO unterricht.personen (vorname, nachname) VALUES
    ('Luca',  'Reicher'),
    ('Darko', 'Tepic');

SELECT * FROM unterricht.personen;