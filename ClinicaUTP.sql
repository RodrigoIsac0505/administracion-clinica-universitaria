create database clinica_utp

drop database clinica_utp

use clinica_utp
--tipo_usuario cuando es 1 es paciente cuando es 2 es secretaria
Create table usuario 
(id_usuario int identity primary key not null,
nombre nchar(50),
apellido nchar(50),
cedula nchar(25),
correo nchar(50) not null,
password nchar(50) not null,
tipo_usuario int not null default 1)

Use clinica_utp
create table cita 
(id_cita int primary key not null identity,
 servicio nchar(100) not null,
 fecha nchar(50) not null)

 Use clinica_utp
 --status cuando es 1 esta disponible cuando esta en 2 no esta disponible
create table cita_hora 
(id_cita_hora int foreign key references cita(id_cita),
 hora nchar(50) not null,
 status int not null default 1,
 constraint PK_cita_hora_cita primary key (id_cita_hora, hora))

  Use clinica_utp
create table registro 
(id_registro int identity not null,
 id_cita_registro int foreign key references cita(id_cita) not null,
 id_usuario_registro int foreign key references usuario(id_usuario) not null,
 hora nchar(50),
 descripcion_paciente nchar(200),
 descripcion_doctor nchar(200),
 constraint PK_registro_compuesto primary key (id_cita_registro, id_usuario_registro))

Use clinica_utp
insert into usuario (correo ,password,tipo_usuario)
values('secretaria@utp.ac.pa','123',2)

Use clinica_utp
insert into usuario (correo ,password,tipo_usuario)
values('admin@utp.ac.pa','123',3)


select * from usuario

update usuario set correo='', password='', tipo_usuario=2 where correo = 'rodrigo@utp.ac.pa'











