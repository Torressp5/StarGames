CREATE DATABASE BLECAUTE
Use BLECAUTE

CREATE TABLE TipoUsuario (
		IdTipoUsuario Int PRIMARY KEY IDENTITY,
		DescTipoUsuario VARCHAR (20)
)

Insert Into TipoUsuario Values('Administrador');
Insert Into TipoUsuario Values('Outros');

CREATE TABLE Usuario (
		IdUsuario INT Primary key identity,
		NmUsuario NVARCHAR (100) NOT NULL,
		CpfUsuario VARCHAR (14) NOT NULL,
		SenhaUsuario VARCHAR (6),
		DtNascimento VARCHAR (10) NOT NULL,
		DsEmail VARCHAR (100),
		UrlImgUsuario varchar (MAX) not null,
		TipoUsuario INT NOT NULL
		FOREIGN KEY (TipoUsuario) REFERENCES TipoUsuario (IdTipoUsuario)
)
select * from Usuario
INSERT INTO Usuario VALUES ('PorqueMon', '111.111.111-01', '111111', '02/02/2001', 'porquemon@gmail.com', '~/Imagens/img1.jpg', 1)
INSERT INTO Usuario VALUES ('Claudia a Raia', '222.222.222-02', '222222', '25/06/1968', 'claudia.a.aria@gmail.com', '~/Imagens/img2.jpg', 2)
INSERT INTO Usuario VALUES ('DressaQuebrabarraco', '111.111.111-03', '333333', '02/02/1999', 'Dressadessearua@gmail.com', '~/Imagens/img3.jpg', 1)
DROP TABLE Usuario


select * from Usuario

SELECT IdConsole,NomeConsole FROM CONSOLE ORDER BY NomeConsole
------------------------------------------------


---------------------------------------------------------------------
drop table Jogo
Select *from Jogo	
Alter Table Jogo Alter Column DescDistribuidoraJogo VARCHAR (max)
CREATE TABLE Jogo (
		IdJogo INT PRIMARY KEY IDENTITY NOT NULL,
		NmJogo VARCHAR (50) NOT NULL,
		DtLancamento Varchar (14) NULL,
		DescGenero VARCHAR (10) NULL,
		TipoDeJogo VARCHAR (50) NOT NULL,
		VlPrecos VARCHAR (100) NULL,
		DescDistribuidoraJogo VARCHAR (Max),
		UrlImagemAlbum Varchar (MAX) Not NUll,
		CONSOLE int not null FOREIGN KEY (CONSOLE) REFERENCES CONSOLE (IdConsole),
		NOVIDADE INT NOT NULL FOREIGN KEY (NOVIDADE) REFERENCES NOVIDADE (IdNovidade)		
)

INSERT INTO Jogo ('NmJogo', 'DtLançamento', 'DescGenero', 'TipoDeJogo', 'VlPreços', 'DescDistribuidoraJogo' , 'CONSOLE', 'NOVIDADE')
		VALUES ('', '', '', '', '', '', '', '') ------------

INSERT INTO Jogo VALUES ('Super Mario Odyssey', '2017', 'Aventura', 'Plataforma', '368.00', 'Nintendo' ,'~/Imagens/img2.jpg', 3, 3);


select * from Jogo --- 


CREATE TABLE NOVIDADE (
	IdNovidade INTEGER PRIMARY KEY IDENTITY NOT NULL,
	NomeNovidade VARCHAR(20) NULL
)

SELECT * FROM NOVIDADE
drop table NOVIDADE
INSERT INTO NOVIDADE VALUES ('Update');
INSERT INTO NOVIDADE VALUES ('DLCs');
INSERT INTO NOVIDADE VALUES ('Gift Box');
select *from CONSOLE
CREATE TABLE CONSOLE (
	IdConsole INTEGER PRIMARY KEY IDENTITY,
	NomeConsole VARCHAR (30)
)

INSERT INTO CONSOLE VALUES ('PlayStation 5');
INSERT INTO CONSOLE VALUES ('PlayStation 4');
INSERT INTO CONSOLE VALUES ('----');
INSERT INTO CONSOLE VALUES ('Xbox One');
INSERT INTO CONSOLE VALUES ('Nintendo Switch');

select * from CONSOLE

Create Table Cliente(
IdCliente Int Primary Key Identity(1,1) Not Null,
NmCliente Varchar (100)Not Null,
NumCpf Varchar (14)Not Null,
DsEmail Varchar (100)Not Null,
NumTelefone Varchar(20)Not Null,
DsLougradouro Varchar(100)Not Null,
DsNumero Varchar(50)Not Null,
DsComplemento Varchar(50)Null,
NmBairro Varchar(100)Not Null,
NmCidade Varchar(100)Not Null,
NmEstado  Varchar(100)Not Null,
NumCep  Varchar(10)Not Null,
DtCadastro  Datetime Not Null,
)
Select *From Cliente


SELECT IdUsuario,NmUsuario,CpfUsuario,SenhaUsuario,DtNascimento,DsEmail,UrlImgUsuario,DescTipoUsuario FROM Usuario JOIN TipoUsuario ON TipoUsuario = IdTipoUsuario
SELECT IdJogo,NmJogo,DtLancamento,DescGenero,TipoDeJogo,VlPrecos,DescDistribuidoraJogo,Jg.CONSOLE,CSL.NomeConsole,Jg.NOVIDADE,NVD.NomeNovidade FROM Jogo AS Jg 
INNER JOIN CONSOLE AS CSL ON CSL.IdConsole = Jg.CONSOLE 
INNER JOIN NOVIDADE AS NVD ON NVD.IdNovidade =Jg.NOVIDADE 
SELECT IdConsole,NomeConsole FROM CONSOLE ORDER BY NomeConsole
SELECT IdNovidade,NomeNovidade FROM NOVIDADE ORDER BY NomeNovidade
SELECT IdJogo,NmJogo,DtLancamento,DescGenero,TipoDeJogo,VlPrecos,DescDistribuidoraJogo,Jg.CONSOLE,CSL.NomeConsole,Jg.NOVIDADE,NVD.NomeNovidade FROM Jogo AS Jg  INNER JOIN CONSOLE AS CSL ON CLS.IdConsole = Jg.CONSOLE INNER JOIN NOVIDADE AS NVD ON NVD.IdNovidade=Jg.NOVIDADE WHERE IdJogo = @v1

