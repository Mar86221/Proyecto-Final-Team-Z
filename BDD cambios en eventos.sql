CREATE DATABASE BINAES_BDD
USE BINAES_BDD;
DROP DATABASE BINAES_BDD
---------------------------------------
---------------------------------------

CREATE TABLE HORARIO (
	id int primary key NOT NULL,
	hora_apertura TIME NOT NULL,
	hora_cierre TIME NOT NULL
	);

CREATE TABLE PISO (
	id int primary key NOT NULL,
	piso VARCHAR(50) NOT NULL,
	);

CREATE TABLE AREA (
	id int primary key NOT NULL,
	descripcion VARCHAR(200) NOT NULL,
	nombre VARCHAR(50) NOT NULL,
	id_piso	int NOT NULL FOREIGN KEY (id_piso) REFERENCES PISO (id),
    id_horario int NOT NULL FOREIGN KEY (id_horario) REFERENCES HORARIO (id),
		);
----------------------------------------------------


CREATE TABLE EVENTO  (
	id int IDENTITY(1,1) primary key NOT NULL,
	imagen VARCHAR(200) NOT NULL,
	titulo VARCHAR(200) NOT NULL,	
	cant_asistentes INT NOT NULL,
	fecha_inicio DATETIME NOT NULL,
	fecha_final DATETIME NOT NULL,
    id_area int NOT NULL FOREIGN KEY (id_area) REFERENCES AREA (id),
		);

CREATE TABLE IMAGEN_EVENTO (
	id int primary key NOT NULL,
	imagen IMAGE NOT NULL,
	id_evento int NOT NULL FOREIGN KEY (id_evento) REFERENCES EVENTO (id),
		);
----------------------------------------------

-------------------------------------------------------
CREATE TABLE GENERO (
    id INT PRIMARY KEY NOT NULL,
    genero VARCHAR(50) NOT NULL,
);

CREATE TABLE TIPO (
    id INT PRIMARY KEY NOT NULL,
    tipo VARCHAR(50) NOT NULL,
);

CREATE TABLE COLECCION (
    id int primary key NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    id_genero INT NOT NULL FOREIGN KEY (id_genero) REFERENCES GENERO (id),
    id_tipo INT NOT NULL FOREIGN KEY (id_tipo) REFERENCES TIPO (id),
);
-------------------------------------------------------
CREATE TABLE AREAXCOLECCION (
	id int primary key NOT NULL,
	id_area int NOT NULL FOREIGN KEY (id_area) REFERENCES AREA (id),
	id_coleccion int NOT NULL FOREIGN KEY (id_coleccion) REFERENCES COLECCION (id)
		);
--------------------------------------------------------
CREATE TABLE EDITORIAL (
    id int primary key NOT NULL,
    editorial VARCHAR(60) NOT NULL,
);

CREATE TABLE IDIOMA (
    id int primary key NOT NULL,
    idioma VARCHAR(60) NOT NULL,
);

CREATE TABLE FORMATO (
    id int primary key NOT NULL,
    formato VARCHAR(60) NOT NULL,
);

CREATE TABLE AUTOR (
    id int primary key NOT NULL,
    nombre_autor VARCHAR(60) NOT NULL,
);

CREATE TABLE EJEMPLAR (
    id int primary key NOT NULL,
    etiqueta VARCHAR(64), 
    nombre VARCHAR(100) NOT NULL,
    Palabras_claves VARCHAR(200),
    fecha_publicacion DATE,
    id_coleccion int NOT NULL FOREIGN KEY (id_coleccion) REFERENCES COLECCION (id),
    id_editorial int NOT NULL FOREIGN KEY (id_editorial) REFERENCES EDITORIAL (id),
    id_idioma int NOT NULL FOREIGN KEY (id_idioma) REFERENCES IDIOMA (id),
    id_formato int NOT NULL FOREIGN KEY (id_formato) REFERENCES FORMATO (id),
);

CREATE TABLE EJEMPLARXAUTOR (
    id int primary key NOT NULL,
	id_ejemplar int NOT NULL FOREIGN KEY (id_ejemplar) REFERENCES EJEMPLAR (id),
	id_autor int NOT NULL FOREIGN KEY (id_autor) REFERENCES AUTOR (id)
);

CREATE TABLE IMAGEN_EJEMPLAR (
    id int IDENTITY(1,1) primary key NOT NULL,
    imagen VARCHAR(100) NOT NULL,
    id_ejemplar int NOT NULL FOREIGN KEY (id_ejemplar) REFERENCES EJEMPLAR (id),
);
---------------------------------------------
CREATE TABLE OCUPACION (
    id int primary key NOT NULL,
    ocupacion VARCHAR(50) NOT NULL,
);

CREATE TABLE INSTITUCION(
	ID int IDENTITY(1,1) primary key NOT NULL,
	institucion VARCHAR(50) NOT NULL,
    id_ocupacion int NOT NULL FOREIGN KEY (id_ocupacion) REFERENCES OCUPACION (id),
    
);

 CREATE TABLE IMAGEN (
               id int IDENTITY (1,1) primary key NOT NULL,
               nombre NVARCHAR(50),
               imagen IMAGE
           );

        


CREATE TABLE USUARIO (
    id int IDENTITY(1,1) primary key NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    direccion VARCHAR(70) NOT NULL,
    telefono VARCHAR(10) NOT NULL, 
    correo VARCHAR(60) NOT NULL,
	id_institucion int NOT NULL FOREIGN KEY (id_institucion) REFERENCES INSTITUCION (id),
    fotografia VARCHAR(500) NOT NULL,
);


----------------------------------------------------------
CREATE TABLE PRESTA (
	id int IDENTITY(1,1) primary key NOT NULL,
	id_usuario int NOT NULL FOREIGN KEY (id_usuario) REFERENCES USUARIO (id),
	id_ejemplar int NOT NULL FOREIGN KEY (id_ejemplar) REFERENCES EJEMPLAR (id),
	fecha_prestamo DATETIME NOT NULL,
    fecha_devolucion DATETIME NOT NULL,
    
		);

CREATE TABLE RESERVA (
	id int IDENTITY(1,1) primary key NOT NULL,
	id_usuario int NOT NULL FOREIGN KEY (id_usuario) REFERENCES USUARIO (id),
	id_ejemplar int NOT NULL FOREIGN KEY (id_ejemplar) REFERENCES EJEMPLAR (id),
    fecha_reserva DATETIME NOT NULL,
    fecha_devolucion DATETIME NOT NULL,
		);
--------------------------------------------------------
CREATE TABLE USUARIOXAREA (
	id int primary key NOT NULL,
	id_usuario int NOT NULL FOREIGN KEY (id_usuario) REFERENCES USUARIO (id),
	id_area int NOT NULL FOREIGN KEY (id_area) REFERENCES AREA (id),
    fecha_entrada DATE NOT NULL,
    fecha_salida DATE NOT NULL,
    hora_entrada DATE NOT NULL,
    hora_salida DATE NOT NULL,
		);
--------------------------------------------------------------
INSERT INTO OCUPACION (id,ocupacion)
    VALUES (1,'Estudiante'),
           (2,'Trabajador'),
           (3,'Desempleado');    
--------------------------------------------------------------
INSERT INTO INSTITUCION (institucion,id_ocupacion)
    VALUES ('UCA',1),
           ('UES',1),
           ('SIMAN',2),
           ('FREUND',2),
           ('Ninguno/a',3)
------------------------------------------------------------
INSERT INTO EDITORIAL (id,editorial)
    VALUES (1,'MOLINO'),
            (2, 'RBA'),
            (3,'DEBOLSILLO'),
            (4,'BATAM'),
            (5,'SALAMANDRA'),
            (6, 'CRITICA'),
            (7,'PENGUIN BOOKS'),
            (8,'GREDOS'),
            (10, 'ALMA'),
            (11,'TECNOS'),
            (12, 'LOSADA'),
            (13,'AUSTRAL'),
            (14, 'TEMAS DE HOY'),
            (16, 'GRADIFCO'),
            (17,'PUFFIN'),
            (18,'TRAMA LITERARIA'),
            (19,'EDIMAT'),
            (20,'VERGARA Y RIBA'),
            (21,'IMPEDIMENTA'),
            (22, 'SCHOLASTIC'),
            (23,'ALIANZA'),
            (24,'HISPAMERICA BOOKS');
            

INSERT INTO AUTOR (id,nombre_autor)
    VALUES(1,'KINNEY,JEFF'),
            (2, 'STEPHEN KING'),
            (3, 'JOJO MOYES'),
            (4,'RICK RODAN'),
            (5, 'J.K ROWLING'),
            (6,'E.L. JAMES'),
            (7, 'STEPHEN HAWKING'),
            (8,'ARTHUR CONAN DOYLE'),
            (9,'SOFOCLES'),
            (10,'LEWIS CARROL'),
            (11,'FRIEDRICH NIETZCHE'),
            (12, 'EDGAR ALLAN POE'),
            (13,'KARL MAX'),
            (14,'HOMERO'),
            (15, 'VEGETTA777'),
            (16, 'DANTE ALIGHIERI'),
            (17,'ANTOINE SAINT EXUPERY'),
            (18,'BRAM STOKER'),
            (19,'MARY SHELLEY'),
            (20,'MIGUEL DE CERVANTES'),
            (21,'MARK TWAIN'),
            (22, 'JAMES DASHNER'),
            (23,'FRANZ KAFKA'),
            (24,'LOUISA MAY ALCOTT'),
            (25,'CHRISTOPHE GAULTIER'),
            (26, 'SUZANNE COLLINS'),
            (27,'WILLIAM SHAKESPEARE'),
            (28,'GEORGE ORWELL'),
            (29,'JANE AUSTEN'),
            (30,'HERMAN MELVILLE'),
            (31,'VICTOR HUGO'),
            (32,'ARI FOLMAN'),
            (33,'F.SCOTT FITZGERALD');


INSERT INTO IDIOMA (id, idioma) 
    VALUES (1,'Español'),
           (2,'Ingles');

INSERT INTO FORMATO (id, formato)
    VALUES (1,'Fisico'),
           (2,'Digital');


-----------------------------------------------------------

INSERT INTO TIPO (id,tipo)
    VALUES (1,'libro');



INSERT INTO GENERO (id, genero)
    VALUES  (1, 'FICCION'),
            (2, 'HORROR'),
            (3,'FILOSOFIA'),
            (4, 'ROMANCE'),
            (5,'CLASICOS'),
            (6,'CIENCIA FICCION'),
            (7,'POLICIACA'),
            (8,'CIENCIA'),
            (9, 'FANTASIAS'),
            (10,'EROTICO'),
            (11, 'MISTERIO'),
            (12, 'LITERTURA'),
            (13, 'POLITICO');
            
INSERT INTO COLECCION (id, nombre, id_tipo, id_genero)
    VALUES  (1, 'DIARIO DE GREG',1,1),
            (2, 'STEPHEN KING COLLECTION',1,2),
            (3, 'STEPHEN HAWKING THE COLLECTION',1,8),
            (4, 'DE BOLSILLO ROMANCE',1,4),
            (5, 'PERCY JACKSON',1,1),
            (6, 'HARRY POTTER',1,1),
            (7, 'CINCUENTA SOMBRAS',1,10),
            (8, 'HOLMES COLLECTION',1,7),
            (9, 'GREEK COLLECTION',1,5),
            (10, 'LOS ESENCIALES DE LA FILOSOFIA',1,3),
            (11, 'ALICIA',1,9),
            (12, 'OTROS CUENTOS',1,2),
            (13, 'COMMUNIST ESSENTIAL',1,13),
            (14, 'WIGETTA',1,1),
            (15, 'ROBLE PLUS',1,12),
            (16, 'CLASICOS POPULARES',1,5),
            (17, 'TERROR CLASICO',1,2),
            (18, 'MAZE RUNNER',1,6),
            (19, 'HUNGER GAMES',1,6),
            (20, 'DE BOLSILLA FICCION',1,6);
--------------------------------------------------------------------
INSERT INTO HORARIO (id, hora_apertura, hora_cierre)
	VALUES	(1, '09:00','05:00'),
            (2, '10:00','03:45'),
            (3, '09:45','04:45'),
            (4, '09:00','04:45'),
            (5, '09:00','05:00'),
            (6, '10:15','03:50'),
            (7, '08:00','06:00');

INSERT INTO PISO (id, piso)
    VALUES  (1, 'PISO 1'),
            (2, 'PISO 2'),
            (3, 'PISO 3'),
            (4, 'PISO 4');



INSERT INTO AREA (id, descripcion, nombre, id_piso, id_horario)
    VALUES  (1,'Area de juego, recreación, ocio, entretenimiento o diversión','Salones lúdicos 1',1,1),
            (2,'Area de juego, recreación, ocio, entretenimiento o diversión','Salones lúdicos 2',2,1),
            (3,'Area para ceremonias y eventos','Auditórium 1',1,2),
            (4,'Area para elementos audiovisuales','Sala de proyección 1',2,3),
            (5,'Area para elementos audiovisuales','Sala de proyección 2',3,3),
            (6,'Area para elementos audiovisuales','Sala de proyección 3',4,3),
            (7,'Area para uso de computadoras','Área de computación 1',1,4),
            (8,'Area para uso de computadoras','Área de computación 2',1,4),
            (9,'Area para uso de computadoras','Área de computación 3',2,1),
            (10,'Area para uso de computadoras','Área de computación 4',2,3),
            (11,'Area para uso de computadoras','Área de computación 5',3,2),
            (12,'Area para uso de computadoras','Área de computación 6',3,2),
            (13,'Area para uso de computadoras','Área de computación 7',4,6),
            (14,'Area para uso de computadoras','Área de computación 8',4,6),
            (15,'Area donde se promueven avtividades de inclusion para el publico','Área de promoción de inclusión 1' ,1,3),
            (16,'Area donde se promueven avtividades de inclusion para el publico','Área de promoción de inclusión 2',1,4),
            (17,'Area uilizada para la investigacion de distintos temas de actualidad','Sala de Investigación 1',4,7),
            (18,'Area uilizada para la investigacion de distintos temas de actualidad','Sala de Investigación 2',4,7),
            (19,'Area que almacena varia cantidad de libros','Área de biblioteca 1',1,7),
            (20,'Area que almacena varia cantidad de libros','Área de biblioteca 2',1,7),
            (21,'Area que almacena varia cantidad de libros','Área de biblioteca 3',2,7),
            (22,'Area que almacena varia cantidad de libros','Área de biblioteca 4',2,7),
            (23,'Area que almacena varia cantidad de libros','Área de biblioteca 5',3,7),
            (24,'Area que almacena varia cantidad de libros','Área de biblioteca 6',3,7),
            (25,'Area que almacena varia cantidad de libros','Área de biblioteca 7',4,7),
            (26,'Area que almacena varia cantidad de libros','Área de biblioteca 8',4,7);


            INSERT INTO AREAXCOLECCION (id,id_area,id_coleccion)
                VALUES (1,19,1),
                       (2,19,2),
                       (3,20,3),
                       (4,20,4),
                       (5,20,17),
                       (6,21,5),
                       (7,21,6),
                       (8,22,7),
                       (9,22,8),
                       (10,22,18),
                       (11,23,9),
                       (12,23,10),
                       (13,24,11),
                       (14,24,12),
                       (15,24,19),
                       (16,25,13),
                       (17,25,14),
                       (18,26,15),
                       (19,26,16),
                       (20,26,20);

INSERT INTO EJEMPLAR (id, nombre, Palabras_claves, fecha_publicacion, id_coleccion, id_editorial, id_idioma, id_formato, etiqueta)
    VALUES  (1, 'DIARIO DE GREG 16. EL NUMERO 1', 'AUTOSUPERACION, ESCUELA, PSICOLOGIA, NIÑEZ, BULLYING', CONVERT(DATE,'26/10/2021',103),1,1,1,1,'9788427216907'),
            (2, 'DIARIO DE GREG 15. TOCADO Y HUNDIDO', 'AUTOSUPERACION, ESCUELA, PSICOLOGIA, NIÑEZ, BULLYING', CONVERT(DATE,'27/10/2020',103) ,1,1,1,1,'9788427221239'),
            (3, 'DIARIO DE GREG 13. FRIO FATAL', 'AUTOSUPERACION, ESCUELA, PSICOLOGIA, NIÑEZ, BULLYING',  CONVERT(DATE,'30/10/2018',103),1,1,1,1,'9788427213128'),
            (4, 'CARRETERA MALDITA', 'CARRETERA, MALDITA, MIEDO, TERROR', CONVERT(DATE,'7/3/1981',103),2,3,1,1,'9788497596541'),
            (5,'YO ANTES DE TI',' YO, ANTES, TI, ROMANCE, ROMANTICO, AMOR, RECUENTOS DE VIDA',CONVERT(DATE,'5/1/2015',103),4,3,1,1,'9788483655931'),
            (6, 'BELLAS DURMIENTES','BELLAS DURMIENTES, TERROR, FANTASIA, MIEDO, DURMIENTES, BELLAS', CONVERT(DATE,'26/9/2017',103),2,3,1,1,'9788466346528'),
            (7,'FIN DE GUARDIA','GUARDIA, MISTERIO, POLICIACO, FIN',CONVERT(DATE,'7/6/2016',103),2,3,1,1,'9788466345454'),
            (8, 'A BRIEF HISTORY OF TIME','BRIEF, HISTORY, TIME, ',CONVERT(DATE,'2/4/1988',103),3,4,1,1,'978055280136'),
            (9,'LA ZONA MUERTA','LA, ZONA, MUERTA, FICCION, FANTASIA, FUTURO',CONVERT(DATE,'1/8/1979',103),2,3,1,1,'9788466357135'),
            (10, 'EL VIENTO POR LA CERRADURA', 'EL VIENTO, CERRADURA',CONVERT(DATE, '22/11/2012',103),2,3,1,1,'9788490325179'),
            (11,'LA DOS DESPUES DE LA MEDIANOCHE','MEDIANOCHE,LAS,DOS',CONVERT(DATE,'1/4/1994',103),2,3,1,1,'9788499086309'),
            (12,'PERCY JACKSON Y LOS HEROES GRIEGOS','PERCY, JACKSON, HEROES, GRIEGOS',CONVERT(DATE,'6/8/2015',103),5,5,1,1,'9788498388282'),
            (13,'A HOMBROS DE GIGANTE','HOMBROS, GIGANTE',CONVERT(DATE,'27/05/2010',103),3,6,1,1,'9788498920949'),
            (14,'HARRY POTTER Y LA ORDEN DEL FENIX','HARRY POTTER, ORDEN DEL FENIX',CONVERT(DATE,'21/6/2003',103),6,5,1,1,'9788418173141'),
            (15,'HARRY POTTER Y EL MISTERIO DEL PRINCIPE','HARRY POTTER, MISTERIO DEL PRINCIPE',CONVERT(DATE,'16/7/2005',103),6,5,1,1,'9788418173158'),
            (16,'CINCUENTAS SOMBRAS DE GREY','CINCUENTAS SOMBRAS, GREY',CONVERT(DATE,'25/5/2011',103),7,3,1,1,'9788490623749'),
            (17,'ADVENTURES OF SHERLOCK HOLMES','SHERLOCK HOLMES, MEMOIRS OF SHERLOCK HOLMES',CONVERT(DATE,'1/1/1894',103),8,7,2,1,'9780140437713'),
            (18,'AYAX','AYAX',NULL,10,8,1,1,'9788424939595'),
            (19,'AURORA','AURORA',CONVERT(DATE,'1/01/1881',103),10,11,1,1,'9788430970827'),
            (20,'ALICIA A TRAVES DEL ESPEJO','ALICIA, ESPEJO, A TRAVES',CONVERT(DATE,'27/12/1871',103),11,10,1,1,'9788417230429'),
            (21,'ALICIA','ALICIA',CONVERT(DATE,'26/11/1865',103),11,10,1,1,'9788418008177'),
            (22,'EL GATO NEGRO Y OTROS CUENTROS','EL GATO NEGRO,OTROS CUENTOS',CONVERT(DATE,'19/08/1843',103),12,12,1,1,'9789500308151'),
            (23,'ALICIA EN EL PAIS DE LAS MARAVILLAS','ALICIA, PAIS DE LAS MARAVILLAS',CONVERT(DATE,'25/11/1865',103),11,10,1,1,'9788418008498'),
            (24, 'WIGETTA UN VIAJE MÁGICO ', 'VEGETA, WILLY, VIJAE, MAGICO, WIGETTA',CONVERT(DATE, '11/8/2015'),14,14,1,1,'9786070727122'),
            (25,'LA CARTA ROBADA Y OTROS CUENTROS','CARTA ROBADA, OTROS CUENTOS',CONVERT(DATE,'1/01/1908',103),12,12,1,1,'9789500305730'),
            (26,'AVENTURAS DE ARTURO GORDON PYM','AVENTURAS, ARTURO, GORDOM',CONVERT(DATE,'2/06/1828',103),17,12,1,1,'9788496375024'),
            (27,'MANIFIESTO COMUNISTA','MANIFIESTO,COMUNISTA',CONVERT(DATE,'21/02/1848',103),13,3,1,1,'9788499427652'),
            (28,'EL ESCARABAJO DE ORO Y OTROS CUENTOS','ESCARABAJO DE ORO, OTROS CUENTOS',CONVERT(DATE,'21/06/1843',103),12,12,1,1,'9789500397124'),
            (29,'WIGETTA Y LOS GUSANOS GUASONES ', 'VEGETA, WILLY, GUSANOS, GUASONES, WIGETTA',CONVERT(DATE, '6/12/2016',103),14,14,1,1,'9786070736209'),
            (30,'ILIADA','ILIADA',NULL,9,8,1,1,'9788424938895'),
            (31,'WIGETTA Y LA FERIA FANTASMA ', 'VEGETA, WILLY, FERIA, FANTASMA WIGETTA',CONVERT(DATE, '4/7/2017',103),14,14,1,1,'9786070742095'),
            (32,'LA DIVINA COMEDIA','DIVINA, COMEDIA',CONVERT(DATE,'3/6/1960',103),15,16,1,1,'978971093700'),
            (33,'WIGETTA Y EL ANTIDOTO SECRETO','WIGETTA, ANTIDOTO SECRETO',CONVERT(DATE,'31/05/2016',103),14,14,1,1,'9786070733338'),
            (34,'EL PRINCIPITO','PRINCIPITO',CONVERT(DATE,'6/4/1943',103),16,5,1,1,'9788418174193'),
            (35,'DRACULA','DRACULA',CONVERT(DATE,'26/5/1897',103),16,17,1,1,'9780593203385'),
            (36, 'WIGETTA Y EL CUENTO JAMAS CONTADO ', 'VEGETA, WILLY, CUENTO, JAMAS, CONTADO, WIGETTA',CONVERT(DATE, '23/10/2018',103),14,14,1,1,'9786070745607'),
            (37,'WIGETTA Y EL BACULO DORADA','WIGETTA, BACULO, DORADO',CONVERT(DATE,'9/2/2016',103),14,14,1,2,'9786070731556'),
            (38,'WIGETTA EN EL PLANETA MIMISIKÚ ', 'VEGETA, WILLY, PLANETA, MIMISIKÚ, WIGETTA',CONVERT(DATE, '15/3/2017',103),14,14,1,2,'9786070740169'),
            (39,'WIGETTA Y LA ISLA DE MUMUCHUMU','WIGETTA,ISLA,DE,MUMUCHUMU',CONVERT(DATE,'18/12/2018',103),14,14,1,2,'9786070754692'),
            (40,'FRANKENSTEIN','FRANKENSTEIN',CONVERT(DATE, '1/1/1918',103),16,16,1,1,'9788418145155'),
            (41,'UNIVERSO WIGETTA 3 EL CORAZON OSCURO','WIGETTA,CORAZON,OSCURO,UNIVERSO',CONVERT(DATE,'24/11/2021',103),14,14,1,1,'9786070780967'),
            (42, 'WIGETTA Y EL TESORO DE CHOCATUSPALMAS ', 'VEGETA, WILLY, TESORO, CHOCATUSPALMAS, WIGETTA',CONVERT(DATE, '3/7/2018',103),14,14,1,1,'9786070751080'),
            (43,'DON QUIJOTE DE LA MANCHA','DON, QUIJOTE, MANCHA', CONVERT(DATE,'5/3/1605',103),16,19,1,2,'9788497943697'),
            (44,'MAZE RUNNER PRUEBA DE FUEGO','MAZE, RUNNER, PRUEBA, FUEGO',CONVERT(DATE,'18/9/2010',103),18,20,1,1,'9789876123549'),
            (45,'ADVENTURES OF TOM SAWYER', 'TOM, SAWYER, ADVENTURES, MISURI', CONVERT(DATE, '25/6/1876',103),16,17,2,1,'9780141321103'),
            (46,'MAZE RUNNER LA CURA MORTAL','MAZE, RUNNER, CURA, MORTAL',CONVERT(DATE,'11/10/2011',103),18,20,1,1,'9789876124232'),
            (47,'MAZE RUNNER CORRER O MORIR','MAZE,RUNNER,CORRER,MORIR',CONVERT(DATE,'6/10/2009',103),18,20,1,1,'9789876122672'),
            (48,'METAMORFOSIS','METAMORFOSIS',CONVERT(DATE,'1/1/1915',103),16,3,1,1,'9788467058758'),
            (49,'MUJERCITAS','MUJERCITAS',CONVERT(DATE, '30/7/1868',103),16,3,1,1,'9788491053910'),
            (50,'FANTASMA DE LA OPERA', 'FANTASMA, OPERA',CONVERT(DATE,'23/9/1909',103),16,21,1,1,'9788415979227'),
            (51,'HUNGER GAMES 2 CATCHING FIRE','HUNGER,GAMES,CATCHING,FIRE',CONVERT(DATE,'1/9/2009',103),19,22,2,1,'9780545586177'),
            (52,'ROMEO Y JULIETA','ROMEO, JULIETA',CONVERT(DATE,'29/1/1597',103),16,23,1,1,'9788420651408'),
            (53,'HAMLET','HAMLET',CONVERT(DATE,'1/1/1603',103),16,7,2,1,'9780141396507'),
            (54,'HUNGER GAMES 3 MOCKINGJAY', 'HUNGER GAMES, HUNGER, GAMES',CONVERT(DATE,'21/11/2014',103),19,22,2,1,'9780545663267'),
            (55,'1984','1984',CONVERT(DATE,'8/6/1949',103),20,3,1,1,'9789875669284'),
            (56,'ORGULLO Y PREJUCIO','ORGULLO, PREJUICIO',CONVERT(DATE,'28/01/1813',103),16,24,1,1,'9786079723958'),
            (57,'MOBY DICK','MOBY, DICK',CONVERT(DATE,'18/10/1851',103),16,7,1,1,'9788491054290'),
            (58,'MISERABLES','MISERABLES',CONVERT(DATE,'1/1/1862',103),16,13,1,1,'9786070769566'),
            (59,'ANTIGONA', 'ANTIGONA, MITOLOGIA, GRECIA',NULL,9,7,1,1,'9788491050780'),
            (60,'EL DIARIO DE ANNE FRANK','DIARIO, ANNE, FRANK',CONVERT(DATE,'25/6/1947',103),16,3,1,1,'9788466340564'),
            (61,'GRAN GATSBY','GRAN, GATSBY',CONVERT(DATE,'10/4/1925',103),16,10,1,2,'9788418395185');

INSERT INTO EJEMPLARXAUTOR(id,id_ejemplar, id_autor)
    VALUES (1,1,1),
           (2,2,1),
           (3,3,1),
           (4,4,2),
           (5,5,3),
           (6,6,2),
           (7,7,2),
           (8,8,3),
           (9,9,2),
           (10,10,2),
           (11,11,2),
           (12,12,4),
           (13,13,7),
           (14,14,5),
           (15,15,5),
           (16,16,6),
           (17,17,8),
           (18,18,9),
           (19,19,11),
           (20,20,10),
           (21,21,10),
           (22,22,12),
           (23,23,10),
           (24,24,15),
           (25,25,12),
           (26,26,12),
           (27,27,13),
           (28,28,12),
           (29,29,15),
           (30,30,14),
           (31,31,15),
           (32,32,16),
           (33,33,15),
           (34,34,17),
           (35,35,18),
           (36,36,15),
           (37,37,15),
           (38,38,15),
           (39,39,15),
           (40,40,19),
           (41,41,15),
           (42,42,15),
           (43,43,20),
           (44,44,22),
           (45,45,21),
           (46,46,22),
           (47,47,22),
           (48,48,23),
           (49,49,24),
           (50,50,25),
           (51,51,26),
           (52,52,27),
           (53,53,27),
           (54,54,26),
           (55,55,28),
           (56,56,29),
           (57,57,30),
           (58,58,31),
           (59,59,9),
           (60,60,32),
           (61,61,33);

INSERT INTO IMAGEN_EJEMPLAR (imagen, id_ejemplar)
    VALUES ('DIARIO DE GREG 16. EL NUMERO 1.jpg',1),
           ('DIARIO DE GREG 15. TOCADO Y HUNDIDO.jpg',2),
           ('DIARIO DE GREG 13. FRIO FATAL.jpg',3),
           ('CARRETERA MALDITA.jpg',4),
           ('YO ANTES DE TI.jpg',5),
           ('BELLAS DURMIENTES.jpg',6),
           ('FIN DE GUARDIA.jpg',7),
           ('A BRIEF HISTORY OF TIME.jpg',8),
           ('LA ZONA MUERTA.jpg',9),
           ('EL VIENTO POR LA CERRADURA.jpg',10),
           ('LA DOS DESPUES DE LA MEDIANOCHE.jpg',11),
           ('PERCY JACKSON Y LOS HEROES GRIEGOS.jpg',12),
           ('A HOMBROS DE GIGANTE.jpg',13),
           ('HARRY POTTER Y LA ORDEN DEL FENIX.jpg',14),
           ('HARRY POTTER Y EL MISTERIO DEL PRINCIPE.jpg',15),
           ('CINCUENTAS SOMBRAS DE GREY.jpg',16),
           ('ADVENTURES OF SHERLOCK HOLMES AND THE MEMOIRS OF SHERLOCK HOLMES.jpg',17),
           ('AYAX.jpg',18),
           ('AURORA.jpg',19),
           ('ALICIA A TRAVES DEL ESPEJO.jpg',20),
           ('ALICIA.jpg',21),
           ('EL GATO NEGRO Y OTROS CUENTROS.jpg',21),
           ('ALICIA EN EL PAIS DE LAS MARAVILLAS.jpg',23),
           ('WIGETTA UN VIAJE MÁGICO.jpg',24),
           ('LA CARTA ROBADA Y OTROS CUENTROS.jpg',25),
           ('AVENTURAS DE ARTURO GORDON PYM.jpg',26),
           ('MANIFIESTO COMUNISTA.jpg',27),
           ('EL ESCARABAJO DE ORO Y OTROS CUENTOS.jpg',28),
           ('WIGETTA Y LOS GUSANOS GUASONES.jpg',29),
           ('ILIADA.jpg',30),
           ('WIGETTA Y LA FERIA FANTASMA.jpg',31),
           ('LA DIVINA COMEDIA.jpg',32),
           ('WIGETTA Y EL ANTIDOTO SECRETO.jpg',33),
           ('EL PRINCIPITO.jpg',34),
           ('DRACULA.jpg',35),
           ('WIGETTA Y EL CUENTO JAMAS CONTADO.jpg',36),
           ('WIGETTA Y EL BACULO DORADA.jpg',37),
           ('WIGETTA EN EL PLANETA MIMISIKÚ.jpg',38),
           ('WIGETTA Y LA ISLA DE MUMUCHUMU.jpg',39),
           ('FRANKENSTEIN.jpg',40),
           ('UNIVERSO WIGETTA 3 EL CORAZON OSCURO.jpg',41),
           ('WIGETTA Y EL TESORO DE CHOCATUSPALMAS.jpg',42),
           ('DON QUIJOTE DE LA MANCHA.jpg',43),
           ('MAZE RUNNER PRUEBA DE FUEGO.jpg',44),
           ('ADVENTURES OF TOM SAWYER.jpg',45),
           ('MAZE RUNNER LA CURA MORTAL.jpg',46),
           ('MAZE RUNNER CORRER O MORIR.jpg',47),
           ('METAMORFOSIS.jpg',48),
           ('MUJERCITAS.jpg',49),
           ('FANTASMA DE LA OPERA.jpg',50),
           ('HUNGER GAMES 2 CATCHING FIRE.jpg',51),
           ('ROMEO Y JULIETA.jpg',52),
           ('HAMLET.jpg',53),
           ('HUNGER GAMES 3 MOCKINGJAY.jpg',54),
           ('1984.jpg',55),
           ('ORGULLO Y PREJUCIO.jpg',56),
           ('MOBY DICK.jpg',57),
           ('MISERABLES.jpg',58),
           ('ANTIGONA.jpg',59),
           ('EL DIARIO DE ANNE FRANK.jpg',60),
           ('GRAN GATSBY.jpg',61);
          

-------------------------------------------------------
------------------------------------------------------------------------------------
/*
SELECT IMAGEN_EJEMPLAR.imagen, EJEMPLAR.nombre, AUTOR.nombre_autor 
FROM IMAGEN_EJEMPLAR 
INNER JOIN EJEMPLAR 
ON IMAGEN_EJEMPLAR.id_ejemplar = EJEMPLAR.id
INNER JOIN EJEMPLARXAUTOR 
ON EJEMPLARXAUTOR.id_ejemplar = EJEMPLAR.id
INNER JOIN AUTOR 
ON EJEMPLARXAUTOR.id_autor = AUTOR.id
INNER JOIN FORMATO
ON EJEMPLAR.id_formato = FORMATO.id
WHERE EJEMPLAR.nombre = 'DIARIO DE GREG 16. EL NUMERO 1'
///////////////////////////////////////////////////////////////////////

SELECT IMAGEN_EJEMPLAR.imagen, EJEMPLAR.nombre, AUTOR.nombre_autor 
FROM IMAGEN_EJEMPLAR 
INNER JOIN EJEMPLAR 
ON IMAGEN_EJEMPLAR.id_ejemplar = EJEMPLAR.id
INNER JOIN EJEMPLARXAUTOR 
ON EJEMPLARXAUTOR.id_ejemplar = EJEMPLAR.id
INNER JOIN AUTOR 
ON EJEMPLARXAUTOR.id_autor = AUTOR.id
INNER JOIN FORMATO
ON EJEMPLAR.id_formato = FORMATO.id
WHERE EJEMPLAR.nombre LIKE '%AUTOSUPERACION%' OR EJEMPLAR.nombre = 'AUTOSUPERACION' OR EJEMPLAR.Palabras_claves LIKE '%AUTOSUPERACION%'

///////////////////////////////////////////////////////////////////////////
SELECT IMAGEN_EJEMPLAR.imagen, EJEMPLAR.nombre, AUTOR.nombre_autor 
FROM IMAGEN_EJEMPLAR 
INNER JOIN EJEMPLAR 
ON IMAGEN_EJEMPLAR.id_ejemplar = EJEMPLAR.id
INNER JOIN EJEMPLARXAUTOR 
ON EJEMPLARXAUTOR.id_ejemplar = EJEMPLAR.id
INNER JOIN AUTOR 
ON EJEMPLARXAUTOR.id_autor = AUTOR.id
INNER JOIN FORMATO
ON EJEMPLAR.id_formato = FORMATO.id
WHERE EJEMPLAR.Palabras_claves LIKE '%AUTOSUPERACION%' OR EJEMPLAR.Palabras_claves LIKE '%GREG%'


SELECT * FROM USUARIO


SELECT IMAGEN_EJEMPLAR.imagen, EJEMPLAR.nombre, AUTOR.nombre_autor
FROM EJEMPLAR, IMAGEN_EJEMPLAR, AUTOR, EJEMPLARXAUTOR
WHERE IMAGEN_EJEMPLAR.id_ejemplar = EJEMPLAR.id AND EJEMPLARXAUTOR.id_ejemplar = EJEMPLAR.id AND EJEMPLARXAUTOR.id_autor = AUTOR.id


SELECT IMAGEN_EJEMPLAR.imagen, EJEMPLAR.nombre, AUTOR.nombre_autor
FROM EJEMPLAR, IMAGEN_EJEMPLAR, AUTOR, EJEMPLARXAUTOR
WHERE IMAGEN_EJEMPLAR.id_ejemplar = EJEMPLAR.id AND EJEMPLARXAUTOR.id_ejemplar = EJEMPLAR.id AND EJEMPLARXAUTOR.id_autor = AUTOR.id AND AUTOR.nombre_autor = 'KINNEY,JEFF'

SELECT * FROM AUTOR
*/
SELECT IMAGEN_EJEMPLAR.imagen, EJEMPLAR.nombre, AUTOR.nombre_autor 
FROM IMAGEN_EJEMPLAR 
INNER JOIN EJEMPLAR 
ON IMAGEN_EJEMPLAR.id_ejemplar = EJEMPLAR.id
INNER JOIN EJEMPLARXAUTOR 
ON EJEMPLARXAUTOR.id_ejemplar = EJEMPLAR.id
INNER JOIN AUTOR 
ON EJEMPLARXAUTOR.id_autor = AUTOR.id
INNER JOIN FORMATO
ON EJEMPLAR.id_formato = FORMATO.id
WHERE AUTOR.nombre_autor = 'VEGETTA777' AND FORMATO.formato = 'Digital' OR AUTOR.nombre_autor = 'VEGETTA777' AND FORMATO.formato = '' 


SELECT * FROM USUARIO

SELECT id_ejemplar FROM RESERVA INNER JOIN EJEMPLAR ON RESERVA.id_ejemplar = EJEMPLAR.id
SELECT * from EJEMPLAR where EJEMPLAR.nombre = 'WIGETTA Y EL BACULO DORADAS'



INSERT INTO RESERVA(id_usuario, id_ejemplar, fecha_reserva, fecha_devolucion) VALUES(1,1, '06/25/2022 11:55', '06/30/2022 11:55')
INSERT INTO PRESTA(id_usuario, id_ejemplar, fecha_prestamo, fecha_devolucion) VALUES(1,1, CONVERT(DATETIME,'25/06/2022 11:55',100), CONVERT(DATETIME,'25/06/2022 11:55',100))
INSERT INTO PRESTA(id, id_usuario, id_ejemplar, fecha_prestamo, fecha_devolucion) VALUES(1,1,1, '06/25/2022 11:55', '06/30/2022 11:55')

SELECT id FROM USUARIO WHERE USUARIO.correo = '00086221@uca.edu.sv'

SELECT id FROM USUARIO WHERE USUARIO.correo = '00086221@uca.edu.sv'

SELECT * FROM PRESTA

SELECT * FROM RESERVA

UPDATE EJEMPLAR 
SET nombre = 'WIGETTA Y EL BACULO DORADAS' , palabras_claves = 'WIGETTA, BACULO, DORADO, VEGETA', id_idioma = 1, id_formato = 1
WHERE EJEMPLAR.id = 37

SELECT id
FROM COLECCION

SELECT * FROM EVENTO

INSERT INTO EVENTO (imagen, titulo, cant_asistentes, fecha_inicio, fecha_final) VALUES (@imagen, @titulo, @cant_asistentes, @fecha_inicio, @fecha_final)

SELECT EVENTO.imagen, EVENTO.titulo, EVENTO.cant_asistentes, EVENTO.fecha_inicio, EVENTO.fecha_final, AREA.nombre  FROM EVENTO INNER JOIN AREAXEVENTO ON AREAXEVENTO.id_evento = EVENTO.id INNER JOIN AREA ON AREAXEVENTO.id_area = AREA.id

INSERT INTO EVENTO (imagen, titulo, cant_asistentes, fecha_inicio, fecha_final) VALUES ('test', 'test', 3,'06/25/2022', '06/30/2022')

INSERT INTO AREAXEVENTO (id, id_area) VALUES (1,1)
INSERT INTO EVENTO (imagen, titulo, cant_asistentes, fecha_inicio, fecha_final, id_area) 
    VALUES ('Cine.png', 'Noche de Cine', 2, '06/25/2022', '06/30/2022', 2)