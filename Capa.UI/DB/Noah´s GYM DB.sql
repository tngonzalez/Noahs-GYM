create database NoahsGYM; 
use NoahsGYM;

create table Genero 
( 
ID int Identity(1,1)Primary Key not null, 
Nombre varchar(50) not null
);

create table Administrador 
( 
ID int Primary Key not null, 
Nombre varchar(50) not null,
Apellidos varchar(100) not null, 
Foto image not null,  
FechaNac datetime not null, 
Correo varchar(100) not null,
Clave varchar(50) not null,
IDGenero int not null, 
Constraint FKGeneroAdm Foreign Key(IDGenero) references Genero(ID)
);

create table Instructor 
( 
ID int Primary Key not null, 
Nombre varchar(50) not null,
Apellidos varchar(100) not null, 
Foto image not null, 
FechaNac datetime not null, 
Correo varchar(100) not null,
Clave varchar(50) not null, 
IDGenero int not null,
Constraint FKGeneroIns Foreign Key(IDGenero) references Genero(ID)
);

create table Cliente 
( 
ID int Primary Key not null, 
Nombre varchar(50) not null,
Apellidos varchar(100) not null, 
Foto image not null, 
FechaNac datetime not null, 
Correo varchar(100) not null,
Clave varchar(50) not null, 
Telefono int not null,
IDGenero int not null,
Constraint FKGeneroCliente Foreign Key(IDGenero) references Genero(ID)
);
Alter table Cliente Alter Column Telefono varchar(100)

create table Medidas 
( 
ID int  identity(1,1) Primary Key not null, 
IDCliente int not null, 
FechaMedidas datetime not null,
Peso float not null, 
Altura float not null, 
IMC float not null,
MetaBasal float not null,
Estado varchar(100) not null,
Constraint FKClienteMedidas Foreign Key(IDCliente) references Cliente(ID)
); 

create table RegistroCliente 
( 
IDRegistro int identity(1,1) Primary Key not null, 
IDCliente int not null, 
HoraIngreso varchar(100) not null, 
HoraSalida varchar(100) not null,
Constraint FKClienteRegis Foreign Key(IDCliente) references Cliente(ID)
);

create table PaqueteGYM 
(
ID char(1) Primary Key not null,
Nombre varchar(50) not null,
Precio money not null,
Meses int,
Semanas int
);

create table PlanInscrito
(
ID int identity(1, 1) Primary Key not null, 
IDCliente int not null, 
IDPaqueteGYM char(1) not null, 
FechaIngreso datetime not null, 
FechaProximoPago datetime not null,
Estado varchar(20),
Constraint FKClientePl Foreign Key(IDCliente) references Cliente(ID),
Constraint FKPaquete Foreign Key(IDPaqueteGYM) references PaqueteGYM(ID)
);

create table ClienteMoroso
(
ID int identity(1,1) Primary Key not null, 
IDCliente int not null,
CantDias int,
Valor money,
Constraint FKCliMoro Foreign Key(IDCliente) references Cliente(ID)
); 

create table TipoEjercicio 
( 
ID int identity(1,1) Primary Key not null, 
Nombre varchar(50) not null
);

create table Ejercicio 
( 
ID int identity(1,1) Primary Key not null,
Nombre varchar(50) not null, 
Descripcion varchar(150) not null, 
Foto image not null, 
IDTipo int not null, 
Constraint FKTipoEjercicio Foreign Key(IDTipo) references TipoEjercicio(ID)
);

create table Rutina 
( 
ID int identity(1,1) Primary Key not null,
Nombre varchar(100) not null,
IDInstructor int not null,
IDEjercicio int not null,
SerieRepetion varchar(50) not null,
Descanso varchar(25) not null, 
Constraint FKEjercicio Foreign Key(IDEjercicio) references Ejercicio(ID),
Constraint FKInstructor Foreign Key(IDInstructor) references Instructor(ID)
);

create table ClienteRutina 
(
IDCliente int not null,
IDRutina int not null,  
Dia varchar(50),
Primary Key(IDCliente,IDRutina),
Constraint FKClienteR Foreign Key(IDCliente) references Cliente(ID),
Constraint FKRutina Foreign Key(IDRutina) references Rutina(ID)
);

create table EncFactura 
( 
NumFactura int identity(1,1) Primary Key not null, 
IDCliente int not null, 
QRCod image not null,
Fecha datetime not null,
Constraint FKClienteF Foreign Key(IDCliente) references Cliente(ID)
);

create table DetalleFac 
( 
NumDet int identity(1,1) not null, 
IDFactura int not null, 
IDPlanInscrito int not null,
TipoCambio decimal,
Primary Key(IDFactura, NumDet),
Constraint FKEncFactura Foreign Key(IDFactura) references EncFactura(NumFactura),
Constraint FKPlanIns Foreign Key(IDPlanInscrito) references PlanInscrito(ID)
);

----------------------------------------------------------------------------
                     ---Procedimientos almacenados---
----------------------------------------------------------------------------

--==========================================================================================================================

--- TipoEjercicio ----------------------------

Insert into TipoEjercicio values ('Resistencia');
Insert into TipoEjercicio values ('Fortalecimiento');
Insert into TipoEjercicio values ('Flexibilidad');
Insert into TipoEjercicio values ('Aeróbicos');

--Mostrar TiposEjerc

CREATE PROCEDURE PA_SeleccionarTipoEjercicios	 
AS
BEGIN
	SELECT *
	FROM TipoEjercicio
END
 
--Mostorar por ID
CREATE PROCEDURE PA_SeleccionarTipoEjerciciosXID	
@IDTE int

AS
BEGIN
	SELECT *
	FROM TipoEjercicio WHERE ID = @IDTE
END
 
----- Genero  --------------------

Insert into Genero values ('Femenino');
Insert into Genero values ('Masculino');
Insert into Genero values ('No aplica');

--Mostrar Genero

CREATE PROCEDURE PA_SeleccionarGenero
	 
AS
BEGIN
	SELECT *
	FROM Genero
END

--Mostorar por ID
CREATE PROCEDURE PA_SeleccionarGeneroXID	
@IDGe int

AS
BEGIN
	SELECT *
	FROM Genero WHERE ID = @IDGe
END


--==========================================================================================================================

----Administrador ------------------------------------------------------------------------

--- Insertar 

CREATE PROCEDURE PA_InsertarAdm
(
@IDA int,
@NombreA varchar(50),
@ApellidosA varchar(100),
@FotoA image, 
@FechaNacA datetime, 
@CorreoA varchar(100),
@ClaveA varchar(50), 
@IDGeneroA int
)

AS
BEGIN 
	INSERT INTO Administrador(ID,Nombre,Apellidos,Foto,FechaNac,Correo,Clave,IDGenero)
			VALUES(@IDA, @NombreA, @ApellidosA,@FotoA,@FechaNacA,@CorreoA,@ClaveA,@IDGeneroA)
END

--Actualizar

CREATE PROCEDURE PA_ActualizarAdm
(
@IDAd int,
@NombreAd varchar(50),
@ApellidosAd varchar(100),
@FotoAd image, 
@FechaNacAd datetime, 
@CorreoAd varchar(100),
@ClaveAd varchar(50), 
@IDGeneroAd int
)

AS
BEGIN
	UPDATE Administrador	
	  SET ID = @IDAd, Nombre = @NombreAd, Apellidos = @ApellidosAd, Foto = @FotoAd, FechaNac = @FechaNacAd,
	    Correo = @CorreoAd ,Clave = @ClaveAd, IDGenero = @IDGeneroAd
	WHERE ID = @IDAd
END


--- PA para saber si existe el Correo y Clave ingresado 


CREATE PROCEDURE PA_LoginAdministrador
(
@userAdmi varchar(100),
@ClaveAdmi  varchar(50)
)
AS
BEGIN
	SELECT * FROM Administrador WHERE (ID = @userAdmi AND Clave = @ClaveAdmi) OR (Correo = @userAdmi  AND Clave = @ClaveAdmi) 
END

-- Eliminar

CREATE PROCEDURE PA_EliminarAdm
(
	@IDAdmin int
)
AS
BEGIN
	DELETE FROM Administrador
    WHERE ID = @IDAdmin
END

--Mostorar por ID

CREATE PROCEDURE PA_SeleccionarAdmin
@IDAdminis int

AS
BEGIN
	SELECT *
	FROM Administrador WHERE ID = @IDAdminis
END

--Mostorar

CREATE PROCEDURE PA_SeleccionarAdminTodo
AS
BEGIN
	SELECT *
	FROM Administrador
END
--==========================================================================================================================

---Instructor --------------------------------------------------------------------------

--- Insertar 

CREATE PROCEDURE PA_InsertarIns
(
@IDI int,
@NombreI varchar(50),
@ApellidosI varchar(100),
@FotoI image, 
@FechaNacI datetime, 
@CorreoI varchar(100),
@ClaveI varchar(50), 
@IDGeneroI int
)

AS
BEGIN 
	INSERT INTO Instructor(ID,Nombre,Apellidos,Foto,FechaNac,Correo,Clave,IDGenero)
			VALUES(@IDI, @NombreI, @ApellidosI,@FotoI,@FechaNacI,@CorreoI,@ClaveI,@IDGeneroI)
END

--Actualizar

CREATE PROCEDURE PA_ActualizarIns
(
@IDIn int,
@NombreIn varchar(50),
@ApellidosIn varchar(100),
@FotoIn image, 
@FechaNacIn datetime, 
@CorreoIn varchar(100),
@ClaveIn varchar(50), 
@IDGeneroIn int
)

AS
BEGIN
	UPDATE Instructor	
	  SET ID = @IDIn, Nombre = @NombreIn, Apellidos = @ApellidosIn, Foto = @FotoIn, FechaNac = @FechaNacIn,
	    Correo = @CorreoIn ,Clave = @ClaveIn, IDGenero = @IDGeneroIn
	WHERE ID = @IDIn
END


-- Eliminar

CREATE PROCEDURE PA_EliminarIns
(
	@IDIns int
)
AS
BEGIN
	DELETE FROM Instructor
    WHERE ID = @IDIns
END

--- PA para saber si existe el Correo y Clave ingresado 

CREATE PROCEDURE PA_LoginInstructor
(
@userInst varchar(100),
@ClaveInst  varchar(50)
)
AS
BEGIN
	SELECT * FROM Instructor WHERE (ID = @userInst AND Clave = @ClaveInst) OR (Correo = @userInst  AND Clave = @ClaveInst) 
END


--Mostrar InstructorXID

CREATE PROCEDURE PA_SeleccionarInstructorXID
@IDInstructor int	 
AS
BEGIN
	SELECT *
	FROM Instructor WHERE ID = @IDInstructor
END

--Mostrar Instructor

CREATE PROCEDURE PA_SeleccionarInstructor
	 
AS
BEGIN
	SELECT *
	FROM Instructor
END
--==========================================================================================================================


----Cliente ----------------------------------------------

--Insertar

CREATE PROCEDURE PA_InsertarCliente
(
@IDC int,
@NombreC varchar(50),
@ApellidosC varchar(100),
@FotoC image, 
@FechaNacC datetime, 
@CorreoC varchar(100),
@ClaveC varchar(50), 
@TelefonoC varchar(100),
@IDGeneroC int
)

AS
BEGIN 
	INSERT INTO Cliente(ID,Nombre,Apellidos,Foto,FechaNac,Correo,Clave,Telefono,IDGenero)
			VALUES(@IDC, @NombreC, @ApellidosC,@FotoC,@FechaNacC,@CorreoC,@ClaveC,@TelefonoC, @IDGeneroC)
END


--Actualizar

CREATE PROCEDURE PA_ActualizarCliente
(
@IDCl int,
@NombreCl varchar(50),
@ApellidosCl varchar(100),
@FotoCl image, 
@FechaNacCl datetime, 
@CorreoCl varchar(100),
@ClaveCl varchar(50), 
@TelefonoCl varchar(100),
@IDGeneroCl int
)
AS
BEGIN
	UPDATE Cliente	
	  SET ID = @IDCl, Nombre = @NombreCl, Apellidos = @ApellidosCl, Foto = @FotoCl, FechaNac = @FechaNacCl,
	    Correo = @CorreoCl ,Clave = @ClaveCl, Telefono = @TelefonoCl, IDGenero = @IDGeneroCl
	WHERE ID = @IDCl
END


-- Mostrar Cliente por ID 

CREATE PROCEDURE PA_SeleccionarClienteXID
	
	@IDCli int

AS
BEGIN
	SELECT * FROM Cliente
	WHERE ID = @IDCli

END


--Mostrar Clientes

CREATE PROCEDURE PA_SeleccionarClientes
	 
AS
BEGIN
	SELECT *
	FROM Cliente
END

-- EliminarXID

CREATE PROCEDURE PA_EliminarCliente
(
	@IDCliE int
)
AS
BEGIN
	DELETE  FROM Cliente
    WHERE ID = @IDCliE
END

--- PA para saber si existe el Correo y Clave ingresado 

CREATE PROCEDURE PA_LoginCliente
(
@UserClient varchar(100),
@ClaveClient  varchar(50)
)
AS
BEGIN
	SELECT * FROM Cliente WHERE (ID = @UserClient AND Clave = @ClaveClient) OR (Correo = @UserClient  AND Clave = @ClaveClient) 
END 

--==========================================================================================================================

------ Medidas ----------------------------------------------------------------------------

--- Insertar 

CREATE PROCEDURE PA_InsertarMedidas
(
@IDClienteM int,
@FechaM datetime,
@PesoM float, 
@AlturaM float, 
@IMCM float,
@MetaBasalM float,
@EstadoM varchar(100)
)

AS
BEGIN 
	INSERT INTO Medidas(IDCliente,FechaMedidas, Peso,Altura,IMC, MetaBasal, Estado)
			VALUES(@IDClienteM,@FechaM, @PesoM,@AlturaM,@IMCM, @MetaBasalM, @EstadoM)
END

-- Eliminar

CREATE PROCEDURE PA_EliminarMedidas
(
@IDClienteXM int	
)
AS
BEGIN
	DELETE FROM Medidas
    WHERE IDCliente = @IDClienteXM
END
-- Mostrar Medidas por IDCliente 

CREATE PROCEDURE PA_SeleccionarMedidasXIDCliente
	@IDCliente int

AS
BEGIN
	SELECT *
			FROM Medidas
WHERE IDCliente = @IDCliente 

END


-- Mostrar Medidas por Apellidos 

CREATE PROCEDURE PA_SeleccionarMedidasXCliente
	@ApellidosM varchar(100)

AS
BEGIN
	SELECT (c.Nombre + ' ' + c.Apellidos) AS Cliente,  FechaMedidas,
			Peso, Altura, IMC, MetaBasal, Estado
			FROM Medidas
		INNER JOIN Cliente c ON Medidas.IDCliente = c.ID
WHERE c.Apellidos = @ApellidosM

END


--Mostrar Medidas

CREATE PROCEDURE PA_SeleccionarMedidas
	 
AS
BEGIN
	SELECT *
	FROM Medidas
END

--==========================================================================================================================


------ RegistroCliente ----------------------------------------------------------------------------

--- Insertar 

CREATE PROCEDURE PA_InsertarRegistroCliente
(
@IDClienteRC int, 
@HoraIngresoRC varchar(100), 
@HoraSalidaRC varchar(100)
)

AS
BEGIN 
	INSERT INTO RegistroCliente(IDCliente, HoraIngreso, HoraSalida)
			VALUES(@IDClienteRC, @HoraIngresoRC, @HoraSalidaRC)
END

-- Buscar por IDCLiente

CREATE PROCEDURE PA_SeleccionarRegistroXIDCliente

	@IDClienteRCl varchar(20) 

AS
BEGIN
	SELECT * FROM RegistroCliente
	WHERE IDCliente = @IDClienteRCl
END

--==========================================================================================================================

------ PaqueteGYM ----------------------------------------------------------------------------

--Insertar 

CREATE PROCEDURE PA_InsertarPaqueteGYM
(
@IDPaGYM char(1), 
@NombrePaGYM varchar(50), 
@PrecioPaGYM money,
@MesesPaGYM int, 
@SemanasPaGYM int
)

AS
BEGIN 
	INSERT INTO PaqueteGYM(ID, Nombre, Precio, Meses, Semanas) 
			VALUES(@IDPaGYM, @NombrePaGYM, @PrecioPaGYM, @MesesPaGYM, @SemanasPaGYM)
END

--Mostrar PaqueteGYM

CREATE PROCEDURE PA_SeleccionarPaquetesGYM
	 
AS
BEGIN
	SELECT *
	FROM PaqueteGYM
END

-- Mostrar Paquete por ID 

CREATE PROCEDURE PA_SeleccionarPaquetesGYMID
	@IDPaqGYM CHAR(1)

AS
BEGIN
	SELECT * FROM PaqueteGYM
	WHERE ID = @IDPaqGYM

END


-- EliminarXID

CREATE PROCEDURE PA_EliminarPaquete
(
	@IDPaque char(1)
)
AS
BEGIN
	DELETE  FROM PaqueteGYM
    WHERE ID = @IDPaque
END

--==========================================================================================================================

------ PlanInscrito ----------------------------------------------------------------------------

---Consulta Si existe IDClient en PlanInscrito o no, para asi crearlo o actualizarlo 

CREATE PROCEDURE PA_ConsultaPlanInscrito 
(
@IDClientePI int,
@IDPaqueteGYMPI char(1),
@FechaIngresoPI datetime,
@FechaProximoPagoPI datetime,
@EstadoPI varchar(50)
) 
AS 
set @EstadoPI = 'Pendiente' 
	IF EXISTS(SELECT IDCliente FROM PlanInscrito WHERE IDCliente = @IDClientePI)
	
BEGIN 
	UPDATE PlanInscrito	
	  SET IDCliente = @IDClientePI,IDPaqueteGYM = @IDPaqueteGYMPI, FechaIngreso = @FechaIngresoPI, FechaProximoPago = @FechaProximoPagoPI,	Estado = @EstadoPI
	WHERE IDCliente = @IDClientePI
END 
	ELSE
BEGIN 
	INSERT INTO PlanInscrito(IDCliente,IDPaqueteGYM, FechaIngreso, FechaProximoPago, Estado)
			VALUES(@IDClientePI,@IDPaqueteGYMPI,@FechaIngresoPI,@FechaProximoPagoPI, @EstadoPI)
END 


-- Eliminar

CREATE PROCEDURE PA_EliminarPlanInscrito
(
@IDClientePIns int	
)
AS
BEGIN
	DELETE FROM PlanInscrito
    WHERE IDCliente = @IDClientePIns
END



-- Mostrar PlanInscrito  por IDCliente 

CREATE PROCEDURE PA_SeleccionarPlanInscritoXCliente
	@IDClientePInsc int

AS
BEGIN
	SELECT * FROM PlanInscrito
	WHERE IDCliente = @IDClientePInsc

END

-- Mostrar PlanInscrito  por IDPlan 

CREATE PROCEDURE PA_SeleccionarPlanInscritoXIDPlan
	@IDPlan int

AS
BEGIN
	SELECT * FROM PlanInscrito
	WHERE ID = @IDPlan
END

--Mostrar PlanesInscritos

CREATE PROCEDURE PA_SeleccionarPlanesInscritos
	
AS
BEGIN
	SELECT *
	FROM PlanInscrito
END

-- Modificar Estado Plan  por IDCliente 

CREATE PROCEDURE PA_ModificarEstadoXCliente
	@IDClientePInscrito int

AS
BEGIN
	UPDATE PlanInscrito	
	  SET Estado = 'Tramitado'
	WHERE IDCliente = @IDClientePInscrito

END


--==========================================================================================================================

------ ClienteMoroso ----------------------------------------------------------------------------
 
---Consulta Si existe IDCliente en Plan Inscrito y si la fechaProximoPago es menor que la actual  o no, para asi crearlo 

CREATE PROCEDURE PA_ConsultaClienteMoroso
(

@IDClienteMo int,
@cantMoro int
) 
AS 
	IF (SELECT FechaProximoPago FROM PlanInscrito WHERE IDCliente = @IDClienteMo AND FechaProximoPago < GETDATE()) > 0 
	

BEGIN 
	INSERT INTO ClienteMoroso(IDCliente, CantDias, Valor ) 
			VALUES(@IDClienteMo, @cantMoro, (@cantMoro * 1000))
END 

-- Eliminar
CREATE PROCEDURE PA_EliminarClienteMoroso
(
@IDClienteM int	
)
AS
BEGIN
	DELETE FROM ClienteMoroso
    WHERE IDCliente = @IDClienteM
END

--Mostrar ClienteMoroso

CREATE PROCEDURE PA_SeleccionarClientesMoroso	 
AS
BEGIN
	SELECT C.IDCliente, (m.Nombre + ' ' + m.Apellidos) as Cliente, c.CantDias 
	FROM ClienteMoroso c
	INNER JOIN Cliente m ON c.IDCliente = m.ID
END
--==========================================================================================================================


---Ejercicios--------------------------------------------------

--- Insertar 

CREATE PROCEDURE PA_InsertarEjercicio
(
@NombreE varchar(50),
@DescripcionE varchar(150), 
@FotoE image, 
@IDTipoE int
)

AS
BEGIN 
	INSERT INTO Ejercicio(Nombre,Descripcion,Foto,IDTipo)
			VALUES(@NombreE, @DescripcionE,@FotoE, @IDTipoE)
END

-- Eliminar

CREATE PROCEDURE PA_EliminarEjercicios
(
	@NombreEje varchar(50)
)
AS
BEGIN
	DELETE FROM Ejercicio
    WHERE Nombre = @NombreEje
END

-- Buscar por TipoEjercicios 

CREATE PROCEDURE PA_SeleccionarEjerciciosXTipo

	@IDTipoEjer int 

AS
BEGIN
	SELECT * FROM Ejercicio
	WHERE IDTipo = @IDTipoEjer
END

-- Buscar Todos

CREATE PROCEDURE PA_SeleccionarEjercicios

AS
BEGIN
	SELECT * FROM Ejercicio
END

-- Buscar por ID

CREATE PROCEDURE PA_SeleccionarEjerciciosXID

	@IDEjercicio int

AS
BEGIN
	SELECT * FROM Ejercicio
	WHERE ID = @IDEjercicio
END

--==========================================================================================================================

---- Rutina ----------------------------------------------------------------------------------

--- Insertar 

CREATE PROCEDURE PA_InsertarRutina
(
@NombreR varchar(50),
@IDInstructorR int,
@IDEjercicioR int,
@SerieRepeticion varchar(50),
@Descanso varchar(25)
)

AS
BEGIN 
	INSERT INTO Rutina(Nombre, IDInstructor, IDEjercicio, SerieRepetion, Descanso)
			VALUES(@NombreR, @IDInstructorR, @IDEjercicioR, @SerieRepeticion, @Descanso)
END


-- Eliminar

CREATE PROCEDURE PA_EliminarRutina
(
	@IDRut int
)
AS
BEGIN
	DELETE FROM Rutina
    WHERE ID = @IDRut
END

-- Mostrar RutinasXInstructor

CREATE PROCEDURE PA_SeleccionarRutinasXInstructor
	@IDInsRut int

AS
BEGIN
	SELECT * FROM Rutina
	WHERE IDInstructor = @IDInsRut

END

-- Mostrar Rutinas

CREATE PROCEDURE PA_SeleccionarRutinas

AS
BEGIN
	SELECT * FROM Rutina
END

--==========================================================================================================================



----ClienteRutina ----------------------------------------------------------------------------------

--- Insertar 

CREATE PROCEDURE PA_InsertarClienteRutina
(
@IDClienteCR int,
@IDRutinaCR int,
@DiaRut varchar(50)
)

AS
BEGIN 
	INSERT INTO ClienteRutina(IDCliente, IDRutina, Dia)
			VALUES(@IDClienteCR, @IDRutinaCR, @DiaRut)
END


-- Eliminar

CREATE PROCEDURE PA_EliminarClienteRutina
(
	@IDClienteCRut int,
	@IDRutinaCRut int	
)
AS
BEGIN
	DELETE FROM ClienteRutina
    WHERE IDRutina = @IDRutinaCRut AND IDCliente = @IDClienteCRut
END


-- Mostrar ClienteRutina por IDCliente 
CREATE PROCEDURE PA_SeleccionarClienteRutinaXCliente
	@Apellidos varchar(100)
AS
BEGIN
	SELECT c.IDCliente as Identificacion, (e.Nombre + ' ' + e.Apellidos) AS Cliente,
	m.Nombre as Rutina, r.Nombre as Ejercicio, SerieRepetion, Descanso, Dia, r.Foto,
	i.FechaIngreso, i.FechaProximoPago
	FROM Rutina m
	INNER JOIN ClienteRutina c ON c.IDRutina = m.ID 
	INNER JOIN Ejercicio r on  r.ID = m.IDEjercicio
	INNER JOIN Cliente e ON c.IDCliente = e.ID
	INNER JOIN PlanInscrito i ON c.IDCliente = i.IDCliente
	WHERE e.Apellidos = @Apellidos
END

--==========================================================================================================================


-----------------EncFactura --------------------------------------------------------------------------


--- Insertar 

CREATE PROCEDURE PA_InsertarEncFactura
(
@IDClienteEF int, 
@QRCodEF image,
@FechaEF datetime 
)

AS
	IF EXISTS(SELECT IDCliente FROM EncFactura WHERE IDCliente = @IDClienteEF)
BEGIN 
UPDATE EncFactura	
	  SET IDCliente = @IDClienteEF, QRCod = @QRCodEF, Fecha = @FechaEF
	WHERE IDCliente = @IDClienteEF

END
	ELSE
BEGIN 
	INSERT INTO EncFactura(IDCliente,QRCod, Fecha)
			VALUES(@IDClienteEF, @QRCodEF, @FechaEF)
END

--==========================================================================================================================

CREATE PROCEDURE PA_SeleccionarEncXIDCliente
	@IDCliente int

AS
BEGIN
	SELECT * FROM EncFactura
	WHERE IDCliente = @IDCliente

END


--==========================================================================================================================
------ DetalleFac ----------------------------------------------------------------------------

--- Insertar 

CREATE PROCEDURE PA_InsertarDetalleFac
(
@IDFacturaDF int, 
@IDPlanInscritoDF int,
@TipoCambioDF int
)

AS
	IF EXISTS(SELECT IDFactura FROM DetalleFac WHERE IDFactura = @IDFacturaDF)
BEGIN
UPDATE DetalleFac	
	  SET IDFactura = @IDFacturaDF, IDPlanInscrito = @IDPlanInscritoDF, TipoCambio = @TipoCambioDF
	WHERE IDFactura = @IDFacturaDF
END 

	ELSE 
BEGIN 
	INSERT INTO DetalleFac(IDFactura,IDPlanInscrito, TipoCambio)
			VALUES(@IDFacturaDF, @IDPlanInscritoDF, @TipoCambioDF)
END

---Seleccionar datos Factura 
CREATE PROCEDURE PA_GenerarFactura
(
	@ApellidosF varchar(100)
)	
AS 
			IF EXISTS(SELECT IDCliente FROM ClienteMoroso m INNER JOIN Cliente c 
		ON m.IDCliente = c.ID WHERE c.Apellidos = @ApellidosF)

BEGIN

	SELECT d.IDFactura, e.QRCod, e.Fecha, (c.Nombre + ' ' + c.Apellidos) AS Cliente,
	p.FechaIngreso, p.FechaProximoPago, m.Nombre, m.Precio, d.TipoCambio, x.Valor AS Multa,
	((m.Precio / d.TipoCambio) + (X.Valor / d.TipoCambio)) as Total 
FROM DetalleFac d
INNER JOIN EncFactura e ON d.IDFactura = e.NumFactura
INNER JOIN Cliente c ON e.IDCliente = c.ID
INNER JOIN PlanInscrito p ON d.IDPlanInscrito = p.ID
INNER JOIN PaqueteGYM m ON p.IDPaqueteGYM = m.ID
INNER JOIN ClienteMoroso x ON c.ID = x.IDCliente
WHERE c.Apellidos = @ApellidosF

END
		ELSE 
BEGIN 
	SELECT d.IDFactura, e.QRCod, e.Fecha, (c.Nombre + ' ' + c.Apellidos) AS Cliente,
	p.FechaIngreso, p.FechaProximoPago, m.Nombre, m.Precio, d.TipoCambio, 0 AS Multa,
	((m.Precio / d.TipoCambio) + (0 / d.TipoCambio)) as Total 
FROM DetalleFac d
INNER JOIN EncFactura e ON d.IDFactura = e.NumFactura
INNER JOIN Cliente c ON e.IDCliente = c.ID
INNER JOIN PlanInscrito p ON d.IDPlanInscrito = p.ID
INNER JOIN PaqueteGYM m ON p.IDPaqueteGYM = m.ID
WHERE c.Apellidos = @ApellidosF

END
--==========================================================================================================================


---- Reportes -----------------------------------------------------------------------

--======================================================================

---- Agrupar Rutinas por Clientes

CREATE PROCEDURE PA_SeleccionarAgrupacionRutinaXCliente

@ApellidosCR varchar(100)

AS
BEGIN
		SELECT p.FechaIngreso, p.FechaProximoPago, (l.Nombre + ' ' + l.Apellidos) AS Cliente, r.Nombre as Rutina, e.Nombre, r.SerieRepetion, r.Descanso, M.Dia , e.Foto FROM  ClienteRutina m
	INNER JOIN Rutina r ON m.IDRutina = r.ID
	INNER JOIN Cliente l ON m.IDCliente = l.ID
	INNER JOIN Ejercicio e ON r.IDEjercicio = e.ID
	INNER JOIN PlanInscrito p ON p.IDCliente = l.ID
	WHERE l.Apellidos = @ApellidosCR

END

--======================================================================

--- Seleccionar los ejercicios mas usados (Graficos)

CREATE PROCEDURE PA_SeleccionarEjerciciosFrecuentes
AS
BEGIN
	SELECT TOP 10 Nombre, COUNT(Nombre) AS CantidadUsos FROM Ejercicio
	GROUP BY Nombre
	ORDER BY CantidadUsos DESC
END
--======================================================================
--SELECCIONAR POR TIPO DE EJERCICIO 

CREATE PROCEDURE PA_SeleccionarEjerciciosXTipoEjer
AS
BEGIN
	SELECT p.Nombre, e.Nombre as Ejercicio, e.Foto FROM Ejercicio e
	INNER JOIN TipoEjercicio p ON e.IDTipo = p.ID
	ORDER BY p.Nombre
END
--======================================================================

---Facturacion por filtro de fecha 

CREATE PROCEDURE PA_SeleccionarFacturaRangoFechas
(
@Inicio datetime, 
@Fin datetime 
)
AS
BEGIN

	SELECT d.IDFactura, e.Fecha, (c.Nombre + ' ' + c.Apellidos) AS Cliente,
	p.FechaIngreso, p.FechaProximoPago, m.Nombre, m.Precio, x.Valor AS Multa,
	((m.Precio / d.TipoCambio) + (X.Valor / d.TipoCambio)) as Total 
FROM DetalleFac d
INNER JOIN EncFactura e ON d.IDFactura = e.NumFactura
INNER JOIN Cliente c ON e.IDCliente = c.ID
INNER JOIN PlanInscrito p ON d.IDPlanInscrito = p.ID
INNER JOIN PaqueteGYM m ON p.IDPaqueteGYM = m.ID
INNER JOIN ClienteMoroso x ON c.ID = x.IDCliente
WHERE e.Fecha  BETWEEN @Inicio AND @Fin

END
