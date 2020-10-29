--(localdb)\MSSQLLocalDB--

create database Acceeco

use acceeco

create table UtilisateurSite(IDuser int primary key identity,Prenom varchar(50),Nom varchar(50),Email varchar(50),telephone varchar(50),Adresse varchar(150),CodePostal varchar(50),Ville varchar(50),Pays varchar(50),Motdepasse varchar(50),Roleuser varchar(50))

create table commande(IDcommande int primary key identity, Datecommande datetime ,Etat varchar(50),Iduser int references UtilisateurSite(IDuser)on delete cascade ,IDtransport int references Transport(idTransport) on delete cascade )

create table transport(idTransport int primary key identity, nomtransport varchar(50),idsuivi varchar(50),Etat varchar(50))

create table Produit(IDProduit int primary key identity ,desegnation varchar(50), DescriptionProduit varchar(150),Prix float,qte int ,Prixbarre float,categorie varchar(50),codebar varchar(50))

create table CommandeDtrail(IDcommandedetail int primary key identity ,dateCommande datetime ,Qte int,IDproduit int references Produit(IDProduit)on delete cascade,IDcommande int references Commande(IDcommande) on delete cascade)

create table Avis(idAvis int primary key identity, textavis varchar(40),note int , idproduit int references Produit(IDProduit)on delete cascade)

create table ImageProduit(IDimage int primary key identity, NomImage text,PathImage text, IdProduit int references Produit(IDProduit)on delete cascade)

