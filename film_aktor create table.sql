CREATE TABLE Aktor (
	id INT IDENTITY(1,1) NOT NULL UNIQUE,
	Imie NVARCHAR(50) NOT NULL,
	Nazwisko NVARCHAR(50) NOT NULL,
	Data_urodzenia NVARCHAR(10),
	Miejsce_urodzenia NVARCHAR(50),
CONSTRAINT aktor_pk PRIMARY KEY(id)
);
CREATE TABLE Film (
	id INT IDENTITY(1,1) NOT NULL UNIQUE,
	Tytul NVARCHAR(MAX) NOT NULL,
	Gatunek NVARCHAR(50),
	Produkcja NVARCHAR(50),
	Rezyseria NVARCHAR(50),
	Scenariusz NVARCHAR(50),
	Rok NCHAR(10),
CONSTRAINT film_pk PRIMARY KEY(id)
);
create table film_aktor (
id			INT IDENTITY(1,1)	NOT NULL UNIQUE,
film	INT					NOT NULL,
aktor		INT					NOT NULL,
CONSTRAINT film_aktor_pk PRIMARY KEY(id),
CONSTRAINT film_fk	FOREIGN KEY(film) REFERENCES Film(ID),
CONSTRAINT aktor_fk	FOREIGN KEY(aktor) REFERENCES Aktor(ID),
);
---------------------
INSERT INTO Film(Tytul, Gatunek, Produkcja, Rezyseria, Scenariusz, Rok) VALUES ('Zielona Mila','Dramat','USA','Frank Darabont','Frank Darabont','1999');

INSERT INTO Aktor(Imie,Nazwisko,Data_urodzenia,Miejsce_urodzenia) VALUES('Tom','Hanks','1956-07-09','Concord, Kalifornia, USA');