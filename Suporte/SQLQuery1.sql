create database VENDASNETCORE

go

use VENDASNETCORE



create table Menu(
idMenu int primary key identity(1,1),
descricao varchar(30),
idMenuPai int references Menu(idMenu),
icone varchar(30),
controlador varchar(30),
paginaAcao varchar(30),
isActivo bit,
fechaRegistro datetime default getdate()
)












create table Rol(
idRol int primary key identity(1,1),
descricao varchar(30),
isActivo bit,
fechaRegistro datetime default getdate()
)





 
 create table RolMenu(
 idRolMenu int primary key identity(1,1),
 idRol int references Rol(idRol),
 idMenu int references Menu(idMenu),
 isActivo bit,
 fechaRegistro datetime default getdate()
 )





create table Usuario(
idUsuario int primary key identity(1,1),
nome varchar(50),
email varchar(50),
telefone varchar(50),
idRol int references Rol(idRol),
urlFoto varchar(500),
nomeFoto varchar(100),
dica varchar(100),
isActivo bit,
fechaRegistro datetime default getdate()
)






































create table Categoria(
idCategoria int primary key identity(1,1),
descricao varchar(50),
isActivo bit,
fechaRegistro datetime default getdate()
)



create table Produto(
idProduto int primary key identity(1,1),
codigoBarra varchar(50),
marca varchar(50),
descricao varchar(100),
idCategoria int references Categoria(idCategoria),
stock int,
urlImagen varchar(500),
nomeImagen varchar(100),
preco decimal(10,2),
isActivo bit,
fechaRegistro datetime default getdate()
)

go



create table NumeroCorrelativo(
idNumeroCorrelativo int primary key identity(1,1),
ultimoNumero int,
quantidadeDigitos int,
gerenciamento varchar(100),
fechaActualizacion datetime
)


go

create table TipoDocumentoVenda(
idTipoDocumentoVenda int primary key identity(1,1),
descricao varchar(50),
isActivo bit,
fechaRegistro datetime default getdate()
)

go

create table Venda(
idVenda int primary key identity(1,1),
numeroVenda varchar(6),
idTipoDocumentoVenda int references TipoDocumentoVenda(idTipoDocumentoVenda),
idUsuario int references Usuario(idUsuario),
documentoCliente varchar(10),
nomeCliente varchar(20),
subTotal decimal(10,2),
impuestoTotal decimal(10,2),
Total decimal(10,2),
fechaRegistro datetime default getdate()
)

go

create table DetalheVenda(
idDetalheVenda int primary key identity(1,1),
idVenda int references Venda(idVenda),
idProduto int,
marcaProduto varchar(100),
descricaoProduto varchar(100),
categoriaProduto varchar(100),
quantidade int,
preco decimal(10,2),
total decimal(10,2)
)

go

create table Negocio(
idNegocio int primary key,
urlLogo varchar(500),
nomeLogo varchar(100),
numeroDocumento varchar(50),
nome varchar(50),
email varchar(50),
endereco varchar(50),
telefone varchar(50),
porcentagemImposto decimal(10,2),
simboloMoeda varchar(5)
)

go

create table Configuracao(
recurso varchar(50),
propriedade varchar(50),
valor varchar(60)
)

