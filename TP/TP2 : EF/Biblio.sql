CREATE TABLE Auteurs(
	id_auteur INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	nom_auteur VARCHAR(50) NOT NULL,
	prenom_auteur VARCHAR(50) NOT NULL
);

CREATE TABLE Livres(
	id_livre INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	titre_livre VARCHAR(50) NOT NULL,
	resumer_livre VARCHAR(255) NOT NULL,
	id_auteur INTEGER NOT NULL,
	FOREIGN KEY(id_auteur) REFERENCES Auteurs(id_auteur)
);