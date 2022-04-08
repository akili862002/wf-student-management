
CREATE DATABASE students
GO

USE students_db

CREATE TABLE users (
	username VARCHAR(100) NOT NULL PRIMARY KEY,
	password VARCHAR(100) NOT NULL,
	email VARCHAR(100) NOT NULL
)

insert into users (username, password, email) values ('admin123', 'admin123', 'admin123@gmail.com')

CREATE TABLE students (
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	first_name VARCHAR(50),
	 last_name VARCHAR(50), 
	 birthdate DATE,
	 gender VARCHAR(20) NOT NULL,
		phone VARCHAR (15),  
		address VARCHAR(255), 
		avatar VARCHAR(400)
)

insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Randall', 'Titcombe', '1/14/2002', 'Male', '3311736335', '86 Dunning Circle', 'https://robohash.org/seddoloribusut.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Emmalynn', 'Burgett', '11/14/2001', 'Female', '2697816055', '27 Stone Corner Way', 'https://robohash.org/nullaautautem.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Ariella', 'Gridon', '9/30/1999', 'Female', '6711083075', '1356 Holy Cross Hill', 'https://robohash.org/atnatussed.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Christoph', 'Belison', '3/10/2001', 'Male', '5803656614', '226 Russell Road', 'https://robohash.org/omnissitpariatur.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Cazzie', 'Rumbold', '5/2/2001', 'Male', '9007900391', '147 Mitchell Circle', 'https://robohash.org/magnamsedaut.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Palm', 'Vasichev', '10/8/1999', 'Male', '4133147145', '74677 Loftsgordon Place', 'https://robohash.org/debitisettemporibus.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Constantin', 'Pestridge', '1/5/2002', 'Male', '6575206923', '7180 Blaine Place', 'https://robohash.org/doloribusfugiteligendi.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Izak', 'Crux', '12/20/2001', 'Male', '4239738039', '192 Packers Hill', 'https://robohash.org/perferendissedmaxime.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Timotheus', 'Reddecliffe', '10/6/2000', 'Male', '8276205074', '4615 Fairfield Circle', 'https://robohash.org/rationeidin.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Ailyn', 'Hadkins', '5/23/1999', 'Female', '2816417793', '320 Canary Park', 'https://robohash.org/saepeerroramet.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Alisha', 'VanBrugh', '4/9/2000', 'Female', '9025253754', '3668 Lighthouse Bay Parkway', 'https://robohash.org/optioanimiveritatis.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Ariel', 'Ripsher', '11/19/2000', 'Female', '4716386828', '84931 Utah Road', 'https://robohash.org/consecteturetnihil.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Salome', 'Clay', '2/27/2000', 'Female', '2927179458', '55 Amoth Street', 'https://robohash.org/quilaborumreprehenderit.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Brietta', 'Ablewhite', '12/8/1999', 'Female', '9601262894', '7 Daystar Junction', 'https://robohash.org/illovoluptatesdolorum.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Hoebart', 'Cuckson', '9/9/1999', 'Male', '4575140689', '19 Reindahl Parkway', 'https://robohash.org/blanditiisimpeditsit.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Lucio', 'Angerstein', '10/2/2001', 'Male', '8087537489', '163 Granby Junction', 'https://robohash.org/perspiciatisrerumvoluptas.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Tallulah', 'Hawkins', '3/26/2000', 'Female', '5441578607', '7794 Village Place', 'https://robohash.org/nonsaepeimpedit.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Lorant', 'Gossart', '11/13/2000', 'Male', '6657133225', '952 Fremont Drive', 'https://robohash.org/utidmolestias.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Carie', 'Auletta', '1/2/2000', 'Female', '8266192394', '811 La Follette Drive', 'https://robohash.org/quiadictanostrum.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Devan', 'Durn', '11/2/2001', 'Female', '4327442040', '1751 Farwell Trail', 'https://robohash.org/possimusquidolorum.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Idette', 'Westraw', '9/16/2000', 'Female', '5719709279', '5 Corry Terrace', 'https://robohash.org/cumqueevenietrepellat.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Tremayne', 'McSporrin', '1/10/2000', 'Male', '1764663646', '36 Hallows Hill', 'https://robohash.org/voluptatequiaut.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Dynah', 'Bruyns', '3/9/2002', 'Female', '7317450404', '01 Debra Place', 'https://robohash.org/sintsedvoluptas.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Lutero', 'Ghelardi', '6/20/2000', 'Male', '6437717359', '75 Eastwood Pass', 'https://robohash.org/corruptiinomnis.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Colleen', 'Trowbridge', '8/2/2000', 'Female', '7961341014', '14597 Rutledge Place', 'https://robohash.org/estexplicabovoluptatem.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Quintilla', 'Waber', '6/20/2000', 'Female', '8319377496', '0 Montana Lane', 'https://robohash.org/omnisrerumfugit.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Rania', 'Cancellario', '8/8/2001', 'Female', '5444256659', '2974 Merry Alley', 'https://robohash.org/voluptatesdictaeveniet.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Elbert', 'Pellatt', '5/7/1999', 'Male', '1741759004', '38 Redwing Point', 'https://robohash.org/architectovitaemolestias.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Reagan', 'Matei', '10/3/1999', 'Male', '7877131973', '6975 Anderson Avenue', 'https://robohash.org/consequunturquaerataperiam.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Mattheus', 'Pearlman', '9/22/2000', 'Male', '2679922232', '724 Bayside Street', 'https://robohash.org/quianullaasperiores.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Cassaundra', 'Sloat', '10/13/1999', 'Female', '9975878913', '8 Hollow Ridge Circle', 'https://robohash.org/inventorenumquamet.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Isahella', 'Bancroft', '8/16/2001', 'Female', '5434598442', '80 Esker Drive', 'https://robohash.org/adidab.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Laina', 'Covolini', '2/13/2002', 'Female', '7912615060', '58 Loomis Parkway', 'https://robohash.org/eaexplicaboenim.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Eloisa', 'Drust', '9/30/2000', 'Female', '7381586271', '325 Armistice Drive', 'https://robohash.org/evenietuteaque.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Parsifal', 'Andriessen', '6/20/2000', 'Male', '1144189564', '76 Lukken Alley', 'https://robohash.org/praesentiumaliquamlaborum.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Thayne', 'Ornils', '2/10/2001', 'Male', '5395816679', '16975 Riverside Point', 'https://robohash.org/temporavoluptasest.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Gustaf', 'Franschini', '10/5/2000', 'Male', '9041166617', '5870 Jackson Circle', 'https://robohash.org/nobiseosprovident.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Prent', 'Crabb', '5/19/2001', 'Male', '2486388890', '877 Badeau Terrace', 'https://robohash.org/velsequialiquam.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Belita', 'Denisyev', '2/12/2000', 'Female', '3642437786', '246 Anhalt Parkway', 'https://robohash.org/sintestin.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Wolfy', 'Dun', '12/15/2000', 'Male', '4744536372', '74 Badeau Crossing', 'https://robohash.org/rationeestad.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Kennie', 'Alleyn', '9/2/2000', 'Male', '6907089436', '5 Alpine Trail', 'https://robohash.org/voluptatesmaximemagnam.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Bee', 'Hackforth', '3/4/2000', 'Female', '9235197139', '94 Westridge Center', 'https://robohash.org/namlaboriosamsunt.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Rice', 'Chmiel', '3/8/2000', 'Male', '2515923770', '1 Paget Alley', 'https://robohash.org/debitiscupiditateet.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Sally', 'Fortune', '4/7/2000', 'Female', '9091213145', '0242 Lyons Road', 'https://robohash.org/iuretemporeiste.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Violette', 'MacGillavery', '11/21/2001', 'Female', '4761630177', '73 Schiller Center', 'https://robohash.org/aetomnis.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Harriet', 'Sloegrave', '5/5/2000', 'Female', '7906485920', '85225 Jenna Circle', 'https://robohash.org/quospossimusnon.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Philbert', 'Donegan', '8/11/2000', 'Male', '4989045731', '51 Nova Park', 'https://robohash.org/suntenimmolestiae.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Des', 'Lampett', '1/21/2000', 'Male', '8134438968', '511 Fallview Drive', 'https://robohash.org/etquiaut.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Ely', 'Conklin', '9/29/2001', 'Male', '6591365461', '9 Darwin Way', 'https://robohash.org/essequiipsam.jpg?size=200x200&set=set1');
insert into students (first_name, last_name, birthdate, gender, phone, address, avatar) values ('Edgard', 'Danett', '2/2/2002', 'Male', '5493628969', '69 La Follette Alley', 'https://robohash.org/fugaquamdolor.jpg?size=200x200&set=set1');
