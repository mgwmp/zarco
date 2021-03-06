USE [master]
GO
/****** Object:  Database [floreria]    Script Date: 03/05/2017 07:45:55 p. m. ******/
CREATE DATABASE [floreria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'floreria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\floreria.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'floreria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\floreria_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [floreria] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [floreria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [floreria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [floreria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [floreria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [floreria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [floreria] SET ARITHABORT OFF 
GO
ALTER DATABASE [floreria] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [floreria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [floreria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [floreria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [floreria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [floreria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [floreria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [floreria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [floreria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [floreria] SET  DISABLE_BROKER 
GO
ALTER DATABASE [floreria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [floreria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [floreria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [floreria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [floreria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [floreria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [floreria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [floreria] SET RECOVERY FULL 
GO
ALTER DATABASE [floreria] SET  MULTI_USER 
GO
ALTER DATABASE [floreria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [floreria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [floreria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [floreria] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [floreria] SET DELAYED_DURABILITY = DISABLED 
GO
USE [floreria]
GO
/****** Object:  Table [dbo].[asistencia]    Script Date: 03/05/2017 07:45:55 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[asistencia](
	[entrada] [varchar](100) NULL,
	[salida] [varchar](100) NULL,
	[id_empleado] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 03/05/2017 07:45:55 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cliente](
	[id_cliente] [int] NOT NULL,
	[nombre_cliente] [varchar](50) NOT NULL,
	[direccion_cliente] [varchar](50) NOT NULL,
	[rfc] [varchar](50) NOT NULL,
	[telefono_cliente] [varchar](15) NOT NULL,
 CONSTRAINT [PK_cliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cuentas_por_cobrar]    Script Date: 03/05/2017 07:45:55 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cuentas_por_cobrar](
	[id_empleado] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_factura] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[dias_credito] [datetime] NOT NULL,
	[vencimiento] [datetime] NOT NULL,
	[importe] [money] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[detalle_venta]    Script Date: 03/05/2017 07:45:55 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_venta](
	[id_detalle_venta] [int] NOT NULL,
	[precio] [money] NOT NULL,
	[cantidad] [int] NOT NULL,
	[id_venta] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
 CONSTRAINT [PK_detalle_venta] PRIMARY KEY CLUSTERED 
(
	[id_detalle_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[empleado]    Script Date: 03/05/2017 07:45:55 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[empleado](
	[id_empleado] [int] NOT NULL,
	[id_puesto] [int] NOT NULL,
	[nombre_empleado] [varchar](50) NOT NULL,
	[direccion_empleado] [varchar](50) NOT NULL,
	[telefono_empleado] [varchar](50) NOT NULL,
	[rfc_empleado] [varchar](50) NOT NULL,
	[nss] [char](20) NOT NULL,
 CONSTRAINT [PK_empleado] PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[evento]    Script Date: 03/05/2017 07:45:55 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[evento](
	[id_evento] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[fecha_evento] [datetime] NOT NULL,
	[id_local] [int] NOT NULL,
	[observaciones_evento] [varchar](max) NOT NULL,
	[id_empleado] [int] NOT NULL,
	[id_venta] [int] NULL,
 CONSTRAINT [PK_evento] PRIMARY KEY CLUSTERED 
(
	[id_evento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[factura_compra]    Script Date: 03/05/2017 07:45:55 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[factura_compra](
	[id_factura] [int] NOT NULL,
	[id_empleado] [int] NOT NULL,
	[id_proveedor] [int] NOT NULL,
	[total] [money] NOT NULL,
	[tipo_pago] [money] NOT NULL,
	[fecha] [money] NOT NULL,
	[subtotal] [money] NOT NULL,
 CONSTRAINT [PK_factura_compra] PRIMARY KEY CLUSTERED 
(
	[id_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hola_tu]    Script Date: 03/05/2017 07:45:55 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hola_tu](
	[id_hora] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[local]    Script Date: 03/05/2017 07:45:55 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[local](
	[id_local] [int] NOT NULL,
	[direccion_local] [varchar](50) NOT NULL,
	[nombre_local] [varchar](50) NOT NULL,
 CONSTRAINT [PK_local] PRIMARY KEY CLUSTERED 
(
	[id_local] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[nomina]    Script Date: 03/05/2017 07:45:55 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nomina](
	[id_nomina] [int] NOT NULL,
	[id_empleado] [int] NOT NULL,
	[fecha_nomina] [datetime] NOT NULL,
	[dias_trabajados] [int] NOT NULL,
	[horas_trabajadas] [int] NOT NULL,
	[sueldo_neto] [money] NOT NULL,
	[bonos] [money] NULL,
	[adelantos] [money] NULL,
 CONSTRAINT [PK_nomina] PRIMARY KEY CLUSTERED 
(
	[id_nomina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[pedido]    Script Date: 03/05/2017 07:45:55 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pedido](
	[id_factura] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio_unitario] [money] NOT NULL,
	[importe] [money] NOT NULL,
	[medida] [int] NOT NULL,
	[descripcion] [varchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[producto]    Script Date: 03/05/2017 07:45:55 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[producto](
	[id_producto] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[tipo] [varchar](50) NOT NULL,
	[stock] [int] NOT NULL,
 CONSTRAINT [PK_producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[proveedor]    Script Date: 03/05/2017 07:45:55 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[proveedor](
	[id_proveedor] [int] NOT NULL,
	[nombre_proveedor] [varchar](50) NOT NULL,
	[telefono] [char](10) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[direccion_proveedor] [varchar](50) NOT NULL,
	[rfc] [varchar](20) NOT NULL,
	[codigo_postal] [char](10) NOT NULL,
 CONSTRAINT [PK_proveedor] PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[puesto]    Script Date: 03/05/2017 07:45:55 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[puesto](
	[id_puesto] [int] NOT NULL,
	[nombre_puesto] [varchar](50) NOT NULL,
	[salario] [money] NOT NULL,
	[horario] [varchar](100) NOT NULL,
 CONSTRAINT [PK_puesto] PRIMARY KEY CLUSTERED 
(
	[id_puesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[venta]    Script Date: 03/05/2017 07:45:55 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[venta](
	[id_venta] [int] NOT NULL,
	[fecha_venta] [date] NOT NULL,
	[nombre_envio] [varchar](50) NOT NULL,
	[direccion_envio] [varchar](50) NOT NULL,
	[precio] [money] NOT NULL,
	[observaciones] [varchar](100) NOT NULL,
	[tipo_venta] [int] NOT NULL,
	[tipo_arreglo] [varchar](50) NOT NULL,
	[credito] [bit] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_empleado] [int] NOT NULL,
	[id_evento] [int] NOT NULL,
 CONSTRAINT [PK_venta] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[asistencia]  WITH CHECK ADD  CONSTRAINT [FK_asistencia_empleado] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[empleado] ([id_empleado])
GO
ALTER TABLE [dbo].[asistencia] CHECK CONSTRAINT [FK_asistencia_empleado]
GO
ALTER TABLE [dbo].[cuentas_por_cobrar]  WITH CHECK ADD  CONSTRAINT [FK_cuentas_por_cobrar_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[cuentas_por_cobrar] CHECK CONSTRAINT [FK_cuentas_por_cobrar_cliente]
GO
ALTER TABLE [dbo].[cuentas_por_cobrar]  WITH CHECK ADD  CONSTRAINT [FK_cuentas_por_cobrar_empleado] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[empleado] ([id_empleado])
GO
ALTER TABLE [dbo].[cuentas_por_cobrar] CHECK CONSTRAINT [FK_cuentas_por_cobrar_empleado]
GO
ALTER TABLE [dbo].[detalle_venta]  WITH CHECK ADD  CONSTRAINT [FK_detalle_venta_producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[producto] ([id_producto])
GO
ALTER TABLE [dbo].[detalle_venta] CHECK CONSTRAINT [FK_detalle_venta_producto]
GO
ALTER TABLE [dbo].[detalle_venta]  WITH CHECK ADD  CONSTRAINT [FK_detalle_venta_venta] FOREIGN KEY([id_venta])
REFERENCES [dbo].[venta] ([id_venta])
GO
ALTER TABLE [dbo].[detalle_venta] CHECK CONSTRAINT [FK_detalle_venta_venta]
GO
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD  CONSTRAINT [FK_empleado_puesto] FOREIGN KEY([id_puesto])
REFERENCES [dbo].[puesto] ([id_puesto])
GO
ALTER TABLE [dbo].[empleado] CHECK CONSTRAINT [FK_empleado_puesto]
GO
ALTER TABLE [dbo].[evento]  WITH CHECK ADD  CONSTRAINT [FK_evento_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[evento] CHECK CONSTRAINT [FK_evento_cliente]
GO
ALTER TABLE [dbo].[evento]  WITH CHECK ADD  CONSTRAINT [FK_evento_empleado] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[empleado] ([id_empleado])
GO
ALTER TABLE [dbo].[evento] CHECK CONSTRAINT [FK_evento_empleado]
GO
ALTER TABLE [dbo].[evento]  WITH CHECK ADD  CONSTRAINT [FK_evento_local] FOREIGN KEY([id_local])
REFERENCES [dbo].[local] ([id_local])
GO
ALTER TABLE [dbo].[evento] CHECK CONSTRAINT [FK_evento_local]
GO
ALTER TABLE [dbo].[evento]  WITH CHECK ADD  CONSTRAINT [FK_evento_venta] FOREIGN KEY([id_venta])
REFERENCES [dbo].[venta] ([id_venta])
GO
ALTER TABLE [dbo].[evento] CHECK CONSTRAINT [FK_evento_venta]
GO
ALTER TABLE [dbo].[factura_compra]  WITH CHECK ADD  CONSTRAINT [FK_factura_compra_empleado] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[empleado] ([id_empleado])
GO
ALTER TABLE [dbo].[factura_compra] CHECK CONSTRAINT [FK_factura_compra_empleado]
GO
ALTER TABLE [dbo].[factura_compra]  WITH CHECK ADD  CONSTRAINT [FK_factura_compra_proveedor] FOREIGN KEY([id_proveedor])
REFERENCES [dbo].[proveedor] ([id_proveedor])
GO
ALTER TABLE [dbo].[factura_compra] CHECK CONSTRAINT [FK_factura_compra_proveedor]
GO
ALTER TABLE [dbo].[nomina]  WITH CHECK ADD  CONSTRAINT [FK_nomina_empleado1] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[empleado] ([id_empleado])
GO
ALTER TABLE [dbo].[nomina] CHECK CONSTRAINT [FK_nomina_empleado1]
GO
ALTER TABLE [dbo].[pedido]  WITH CHECK ADD  CONSTRAINT [FK_pedido_factura_compra] FOREIGN KEY([id_factura])
REFERENCES [dbo].[factura_compra] ([id_factura])
GO
ALTER TABLE [dbo].[pedido] CHECK CONSTRAINT [FK_pedido_factura_compra]
GO
ALTER TABLE [dbo].[pedido]  WITH CHECK ADD  CONSTRAINT [FK_pedido_producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[producto] ([id_producto])
GO
ALTER TABLE [dbo].[pedido] CHECK CONSTRAINT [FK_pedido_producto]
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD  CONSTRAINT [FK_venta_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[venta] CHECK CONSTRAINT [FK_venta_cliente]
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD  CONSTRAINT [FK_venta_empleado] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[empleado] ([id_empleado])
GO
ALTER TABLE [dbo].[venta] CHECK CONSTRAINT [FK_venta_empleado]
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD  CONSTRAINT [FK_venta_evento] FOREIGN KEY([id_evento])
REFERENCES [dbo].[evento] ([id_evento])
GO
ALTER TABLE [dbo].[venta] CHECK CONSTRAINT [FK_venta_evento]
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD  CONSTRAINT [FK_venta_evento1] FOREIGN KEY([id_evento])
REFERENCES [dbo].[evento] ([id_evento])
GO
ALTER TABLE [dbo].[venta] CHECK CONSTRAINT [FK_venta_evento1]
GO
USE [master]
GO
ALTER DATABASE [floreria] SET  READ_WRITE 
GO
