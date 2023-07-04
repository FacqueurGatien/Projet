drop table if exists listes_personnes;
drop table if exists personnes;
drop table if exists listes;

create table listes
(
	liste_id INT primary key,
	mineur INT not null,
	majeur INT not null
);

create table personnes
(
	personne_id INT primary key,
	personne_nom VARCHAR (50) not null,
	personne_prenom VARCHAR (50) not null,
	age INT not NULL,
	sexe VARCHAR(5) not null
);

create table listes_personnes
(
	liste_id INT,
	personne_id INT,
	primary key (liste_id,personne_id),
	foreign key (liste_id) references listes (liste_id),
	foreign key (personne_id) references personnes(personne_id)
);

insert into personnes
values
(1,'facqueur','gatien',32,'homme'),
(2,'klein','laura',25,'femme'),
(3,'klein facqueur','pandora',0,'femme');

insert into listes
values
(1,0,0);

select * from personnes;