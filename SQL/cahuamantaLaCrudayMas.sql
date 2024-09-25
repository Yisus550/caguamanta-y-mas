use master
GO
if exists (select * from sysdatabases where name = 'PuntoVentaCahuamanta')
		drop database PuntoVentaCahuamanta
go
--creacion de la base de datos
create database PuntoVentaCahuamanta
go

use PuntoVentaCahuamanta
go

--tabla horarios --
create table Puestos(
idPue int identity (1,1) primary key,
Nombre varchar (50) check(Nombre not like '%[^a-zA-Z]%_%[^a-zA-Z]%') not null unique,
Sueldo money
)
go
				-- Procedimientos incertar, modificar, borrar y vista--
				create proc InsertPuesto
				@Nombre varchar(50),
				@Sueldo money
				as
				insert into Puestos(Nombre,Sueldo)
				values(@Nombre,@Sueldo)
				print 'Puesto insertado correctamente.'
				go
	           exec InsertPuesto 'Administrador',2000
			   exec InsertPuesto 'Cajero',1400
			   exec InsertPuesto 'Cocinero',1300
				go
				-- procedimiento ver horarios --
				create proc MostrarPuesto
				as
					select * from Puestos
				go
				-- procedimiento borrar horarios--
				create proc EliminarPuesto
				@id int
				as
				delete from Puestos where idPue = @id
				go
				-- proc actualizar horarios  --
				create proc ActualizaPuesto
				@id int,
				@Nombre varchar(50),
				@Sueldo money
				as
				   update Puestos set Nombre= @Nombre, Sueldo= @Sueldo where idPue = @id
				print 'Puesto Actualizado correctamente.'
				go

--tabla horarios --
create table horarios(
idH int identity(1,1) primary key,
turno varchar(80),
HoraEnt time,
Horasal time,
)
go
				-- Procedimientos incertar, modificar, borrar y vista--
				create proc IncertarHorario
				@turno varchar(80),
				@HoraEnt time,
				@Horasal time
				as
				insert into horarios(turno, HoraEnt, Horasal) values (@turno, @HoraEnt, @Horasal)
				go
				exec IncertarHorario 'matutino','07:00:00','14:00:00'
				go
				-- procedimiento ver horarios --
				create proc verHorarios
				as
				select * from horarios
				go
				-- procedime¿iento borrar horarios--
				create proc borrarHorario
				@idH int
				as
				delete from horarios where idH = @idH
				go
				-- proc actualizar horarios  --
				create proc actualizarHorario
				@id int,
				@turno int,
				@hEnt time,
				@hSal time
				as
				  update horarios set turno = @turno, HoraEnt=@hEnt, Horasal = @hSal 
				  where idH = @id
				go
-- Creacion de la tabla de los usuarios--
create table Usuarios(
idU int identity (1,1) primary key,
Nombres varchar(80),
Apellidos varchar(80),
idPuesto int references Puestos(idPue),
FhNa date,
FhCon date,
Dir varchar(80) unique,
Tel char(10) check(Tel like '%[0-9]%') unique,
Correo varchar(80) check (Correo like '%_%@%_%.%_') unique,
idTurno int,
usuario Varchar(60) unique,
contraseña varchar(25)
constraint FK_turnoEmpleado foreign key (idTurno) references horarios(idH),
)
go
select * from Usuarios
go
				-- Procedimientos incertar usuarios--
				create proc InsertarUsuarios
				@Nombres varchar(80),
				@Apellidos varchar(80),
				@Puesto int,
				@FhNa date,
				@FhCon date,
				@Dir varchar(80),
				@Tel char(10),
				@cor varchar(80),
				@idTurno int,
				@usuario Varchar(60),
				@contraseña varchar(25)
				as
				  insert into Usuarios(Nombres,Apellidos, idPuesto, FhNa, FhCon, Dir, Tel,Correo, idTurno, usuario, contraseña) 
				  values (@Nombres,@Apellidos, @Puesto, @FhNa, @FhCon, @Dir, @Tel,@cor, @idTurno, @usuario, @contraseña)
				print ('Usuario registrado con exito.');
				go
				create proc ActualizaMisDatos
				@id int,
				@Nombres varchar(80),
				@Apellidos varchar(80),
				@FhNa date,
				@Dir varchar(80),
				@Tel char(10),
				@cor varchar(80),
				@usuario Varchar(60),
				@contraseña varchar(25)
				as
				update Usuarios set Nombres= @Nombres,Apellidos = @Apellidos, FhNa= @FhNa, Dir =@Dir, Tel= @Tel,Correo= @cor, usuario= @usuario, contraseña=@contraseña
				where idU = @id
				go
				-- Procedimientos modificar usuarios--
				create proc ActualizarUsuarios
				@id int,
				@Nombres varchar(80),
				@Apellidos varchar(80),
				@Puesto int,
				@FhNa date,
				@FhCon date,
				@Dir varchar(80),
				@Tel char(10),
				@cor varchar(80),
				@idTurno int,
				@usuario Varchar(60),
				@contraseña varchar(25)
				as
				 update Usuarios set Nombres = @Nombres, Apellidos = @Apellidos ,idPuesto = @Puesto,
				 FhNa= @FhNa, FhCon =@FhCon, Dir = @Dir, Tel= @Tel, Correo=@cor, idTurno = @idTurno,  usuario= @usuario, contraseña=@contraseña 
				 where idU = @id
				 print ('Usuario modificado con exito.');
				go
				-- Procedimientos borrar usuarios--
				create proc borrarUsuarios
				@id int
				as 
				  delete from Usuarios where idU= @id
				  print ('Usuario borrado con exito.')
				  go
				-- Procedimientos mostrar usuarios--
				create proc MostrarUsuarios
				as
				select * from Usuarios as u inner join horarios as h on u.idTurno = h.idH inner join Puestos as p on u.idPuesto = p.idPue;
				go
-- tabla material --
create table Material (
idM int identity(1,1) primary key,
NomM varchar (80),
Cant int,
Proveedor varchar(80),
costo money,
UnidadMedida char(3),
fechaCad date,
idCate int,
stock int
)
go
				-- Procedimientos incertar --
				create proc insertarMaterial
				@idM int,
				@NomM varchar (80),
				@Cant int,
				@Proveedor varchar(80),
				@costo money,
				@UnidadMedida char(3),
				@fechaCad date,
				@idCate int,
				@stock int
				as
				 insert into Material(NomM,Cant,Proveedor,costo,UnidadMedida,fechaCad,idCate,stock) 
				 values(@NomM,@Cant,@Proveedor,@costo,@UnidadMedida,@fechaCad,@idCate,@stock)
				 print ('material incertado con exito.')
				go
				-- Procedimientos modificar --
				create proc modificarMaterial
				@idM int,
				@NomM varchar (80),
				@Cant int,
				@Proveedor varchar(80),
				@costo money,
				@UnidadMedida char(3),
				@fechaCad date,
				@idCate int,
				@stock int
				as 
				 update Material set NomM=@NomM,Cant=@Cant,Proveedor=@Proveedor,costo=@costo,UnidadMedida=@UnidadMedida,
				 fechaCad=@fechaCad,idCate=@idCate,stock=@stock where idM =@idM
				 print ('material incertado con exito.')
				go
				-- Procedimientos borrar  --
				create proc borrarMaterial
				@id int
				as
				delete from Material where idM = @id
				print ('material borrado con exito.')
				go
				-- Procedimientos vista --
				create proc verMaterial
				as
				select * from Material
				go
-- tabla material --
create table Clientes(
idC int primary key identity(1,1),
Nombre varchar(80),
importancia char(8)
)
go
				-- Procedimientos incertar --
				create proc insertarCliente
				@Nombre varchar(80),
				@imp char(8)
				as
				insert into Clientes(Nombre,importancia) values(@Nombre,@imp)
				go
				-- Procedimientos modificar --
				create proc modificarCliente
				@idC int,
				@Nombre varchar(80),
				@imp char(8)
				as
				 update Clientes set Nombre=@Nombre,importancia= @imp
				 where idC = @idC
				go
				-- Procedimientos borrar y vista --
				create proc borarCliente
				@idC int
				as
				delete from Clientes where idC = @idC
				go
				-- Procedimientos vista --
				create proc verCliente
				as
				select * from Clientes
				go
-- tabla categoria --
create table Categoria(
id int identity(1,1) primary key,
NomC varchar(80),
Descripcion text
)
go
				-- Procedimientos incertar --
				create proc insertarCategoria
				@nombre varchar(80),
				@desc text
				as
				insert into Categoria(NomC,Descripcion) values (@nombre,@desc)
				go
				exec insertarCategoria 'Cahuamanta','productos elaborados con cahuamanta'
				go
				-- Procedimientos modificar --
				create proc modificarCategoria
				@id int,
				@nombre varchar(80),
				@desc text
				as
				 update Categoria set NomC=@nombre, Descripcion=@desc where id=@id
				go
				-- Procedimientos borrar--
				create proc borrarCategoria
				@idCate int
				as
				delete from Categoria where id=@idCate
				go
				-- Procedimientos vista --
				create proc verCategorias
				as
				 select * from Categoria
				go

-- tabla platillos -- 
create table Platillos(
id int identity(1,1) primary key,
NomP varchar(80),
Descripcion text,
Categoria int references Categoria(id),
PrecioUnidad money
)
go
				-- Procedimientos incertar --
				create proc insertarPlatillo
				@nom varchar(80),
				@des text,
				@Categoria int,
				@preunit money
				as
				insert into Platillos(NomP,Descripcion,Categoria,PrecioUnidad) values(@nom,@des,@Categoria,@preunit)
				go
				-- Procedimientos modificar --
				create proc modificarPlatillo
				@id int,
				@nom varchar(80),
				@des text,
				@Categoria int,
				@preunit money
				as
				update Platillos set NomP=@nom,Descripcion=@des,Categoria=@Categoria,PrecioUnidad=@preunit
				where id=@id
				print('platillo actualizado con exito')
				go
				-- Procedimientos borrar y vista --
				create proc borrarPlatillo
				@id int
				as
				delete from Platillos where id=@id
				print('platillo borrado con exito')
				go
				-- Procedimientos vista --
				create proc verPlatillos
				as
				select * from Platillos as p inner join Categoria as c on p.Categoria = c.id
				go
go
-- tabla proveedores --
create table Proveedores(
idProveedor int primary key identity (1,1),
NombrePv varchar(50) check (NombrePv not like '%[^a-zA-Z]%_%[^a-zA-Z]%') not null,-- puedes ingresas dos nombres con solo letras
ApellidoPv varchar(50)check (ApellidoPv not like '%[^a-zA-Z]%_%[^a-zA-Z]%') not null,-- igusl que con el nombre
Lada char(3) check (Lada like '%+%[0-9]%[0-9]%') not null,--solo se ingres un + posterior a dos numeros
Telefono char(14) check (Telefono like '[0-9][0-9]%-%[0-9][0-9]%-%[0-9][0-9]%-%[0-9][0-9]%-%[0-9][0-9]') unique not null,
Correo varchar(60) check (Correo like '%_%@%_%.%_') unique not null,
Empresa varchar(80) not null,
recurso varchar(60),
Descripcion text
)
go
				-- Procedimientos incertar --
				create proc insertarProveedores
				@id int,
				@nom varchar(50),
				@ape varchar(50),
				@lada char(3),
				@Telefono char(14),
				@Correo varchar(60),
				@Empresa varchar(80),
				@recurso varchar(60),
				@Descripcion text
				as
				insert into Proveedores(NombrePv,ApellidoPv,Lada,Telefono,Correo,Empresa,recurso,Descripcion)
				values(@nom,@ape,@lada,@Telefono,@Correo,@Empresa,@recurso,@Descripcion)
				go
				-- Procedimientos modificar --
				create proc modificarProveedores
				@id int,
				@nom varchar(50),
				@ape varchar(50),
				@lada char(3),
				@Telefono char(14),
				@Correo varchar(60),
				@Empresa varchar(80),
				@recurso varchar(60),
				@Descripcion text
				as
				 update Proveedores set NombrePv =@nom ,ApellidoPv=@ape,Lada=@lada,Telefono=@Telefono,Correo=@Correo,
				 Empresa=@Empresa,recurso=@recurso,Descripcion=@Descripcion where idProveedor=@id
				go
				-- Procedimientos borrar y vista --
				create proc borrarProveedores
				@id int
				as
				delete from Proveedores where idProveedor=@id
				go
				-- Procedimientos vista --
				create proc verproveedores
				as
				select * from Proveedores
				go
-- tabla compras--
create table Compra(
idCompra int primary key identity(1,1),
FechaCompra date not null,
IDEmpleado int not null,
IDProveedor int not null,
Importe money,
constraint FK_CompraEmpleado foreign key (IDEmpleado) references Usuarios(idU),
constraint FK_CompraProveedor foreign key (IDProveedor) references Proveedores(IDProveedor)
)
				go
				-- Procedimientos incertar --
				create proc incertarCompra
				@FechaCompra date,
				@IDEmpleado int ,
				@IDProveedor int,
				@Importe money
				as
				insert into Compra(FechaCompra,IDEmpleado,IDProveedor,Importe) values(@FechaCompra,@IDEmpleado,@IDProveedor,@Importe)
				go
				-- Procedimientos modificar --
				create proc modificarCompra
				@id int,
				@FechaCompra date,
				@IDEmpleado int ,
				@IDProveedor int,
				@Importe money
				as
				update Compra set FechaCompra=@FechaCompra,IDEmpleado=@IDEmpleado,IDProveedor=@IDProveedor,Importe=@Importe
				go
				-- Procedimientos borrar y vista --
				create proc borrarCompra
				@id int
				as
				delete from Compra where idCompra=@id
				go
				-- Procedimientos vista --
				create proc verCompra
				as
				select * from Compra
				go

-- tabla detalle de compras --
create table DetalleCompras(
IDCompra int not null,
IDProducto int not null,
PrecioUnidad money not null,
Cantidad int not null,
Importe money,
constraint FK_DetalleCompraProd foreign key (IDProducto) references Material(idM),
constraint FK_DetalleCompraCompra foreign key (IDCompra) references Compra(idCompra)
)
go
				-- Procedimientos incertar --
				create proc incertarDetalleCompras
				@id int,
				@IDProducto int,
				@PrecioUnidad money,
				@Cantidad int,
				@Importe money
				as
				insert into DetalleCompras(IDProducto,PrecioUnidad,Cantidad,Importe) values (@IDProducto,@PrecioUnidad,@Cantidad,@Importe)
				go
				-- Procedimientos modificar --
				create proc modificarDetalleCompras
				@id int,
				@IDProducto int,
				@PrecioUnidad money,
				@Cantidad int,
				@Importe money
				as
				update DetalleCompras set IDProducto=@IDProducto,PrecioUnidad=@PrecioUnidad,Cantidad=@Cantidad,Importe=@Importe
				go
				-- Procedimientos borrar y vista --
				create proc borrarDetalleCompras
				@id int
				as
				delete from DetalleCompras where IDCompra= @id
				go
				-- Procedimientos vista --
				create proc verDetalleCompras
				as
				select * from DetalleCompras
				go
create table Venta(
idVenta int primary key identity (1,1),
FechaVenta date not null,
IDEmpleado int not null,
IDCliente int not null,
Importe money,
constraint FK_VentaEmpleado foreign key (IDEmpleado) references Usuarios(idU),
constraint FK_VentaCliente foreign key (IDCliente) references Clientes(idC)
)
go
create table DetalleVentas(
IDVenta int not null,
IDProducto int not null,
PrecioUnidad money not null,
Cantidad int not null,
Importe as Cantidad * PrecioUnidad,
constraint FK_DetalleVentaProd foreign key (IDProducto) references Platillos(id),
constraint FK_DetalleVentaVentas foreign key (IDVenta) references Venta(idVenta)
)
go
-- incertar ventas--
create proc InsertVenta
@Fecha date,
@IdEmpleado int,
@IdCliente int,
@Importe money
as
insert into Venta(FechaVenta,IDEmpleado,IDCliente,Importe)
values(@Fecha,@IdEmpleado,@IdCliente,@Importe)
print 'Venta insertado correctamente.'
go

create Proc InsertDetalleVenta
@Venta int,
@IdProducto int,
@PrecioU money,
@Cantidad int,
@Importe money
as
insert into DetalleVentas(IDVenta, IDProducto ,PrecioUnidad, Cantidad)
values(@Venta ,@IdProducto, @PrecioU, @Cantidad)
print 'Detalle de ventas insertado correctamente.'
go
 -- insertar ventas -- 
create proc InsertCompra
@Fecha date,
@IdEmpleado int,
@IdProveedor int,
@Importe money
as
insert into Compra(FechaCompra,IDEmpleado,IDProveedor,Importe)
values(@Fecha,@IdEmpleado,@IdProveedor,@Importe)
print 'Compra insertado correctamente.'
go

create proc InsetDetalleCompra
@Compra int,
@IdProducto int,
@PrecioU money,
@Cantidad int,
@Importe money
as
insert into DetalleCompras(IDCompra,IDProducto,PrecioUnidad,Cantidad)
values(@Compra, @IdProducto, @PrecioU, @Cantidad)
print 'Detalle de compras insertado correctamente.'
go
--  actualizar compras y ventas con detalles--
create proc ActualizaVenta
@id int,
@Fecha date,
@IdEmpleado int,
@IdCliente int,
@Importe money
as
 update Venta set FechaVenta= @Fecha, IDEmpleado= @IdEmpleado,IDCliente= @IdCliente,Importe= @Importe where IDCliente =@id
print 'Venta Actualizado correctamente.'
go

create proc ActualizaCompra
@id int,
@Fecha date,
@IdEmpleado int,
@IdProveedor int,
@Importe money
as
 update Compra set FechaCompra = @Fecha, @IdEmpleado = @IdEmpleado, IDProveedor = @IdProveedor, Importe = @Importe
print 'Compra Actualizado correctamente.'
go

create Proc ActualizaDetalleVenta
@id int,
@Venta int,
@IdProducto int,
@PrecioU money,
@Cantidad int,
@Importe money
as
update DetalleVentas set IDVenta = @Venta, IDProducto = @IdProducto, PrecioUnidad = @PrecioU, Cantidad = @Cantidad
where IDVenta = @id
print 'Detalle de Venta Actualizado correctamente.'
go

create proc ActualizaDetalleCompra
@Id int,
@Compra int,
@IdProducto int,
@PrecioU money,
@Cantidad int,
@Importe money
as
update DetalleCompras set IDCompra=@Compra, IDProducto = @IdProducto, PrecioUnidad = @PrecioU, Cantidad = @Cantidad
where IDCompra = @Id
print 'Detalle de compra Actualizado correctamente.'
go
-- --
create proc verVentas
as
select * from Venta
go

create proc verDetalleVentas
as
select * from DetalleVentas
go



           --- CREACION DE TRIGER ---
create trigger ActualizaStockCompra on DetalleCompras
after insert
as
	update Material set Stock = (Stock + Cantidad) from inserted
	inner join Material on Material.idM = inserted.IDProducto
	print 'Se añadieron productos al stock'
go
exec InsertarUsuarios  'abraham','favela', 1, '2002-05-04', '2020-09-16', 'calle 14 manganecio', '6621731410','favela@gmail.com', '1', 'Admin', 'pepe12'
go
exec InsertarUsuarios 'abraham','favela', '1', '05/04/2002', '2020-09-16', 'calle 14 ', '662173410','cajero@g.com', '1', 'cajero', '1234'

go

exec insertarPlatillo 'vaso cahuamanta','vaso de 12oz con manta aleta y camaron',1,80
go

exec MostrarUsuarios
exec verPlatillos
exec verHorarios
 exec verproveedores 
 exec verCliente
 exec verCategorias
 exec verCompra
 exec verDetalleCompras 
 exec verDetalleVentas
 exec verMaterial
 exec verVentas
 exec MostrarPuesto
