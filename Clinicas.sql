/*
SQLyog Enterprise v13.1.1 (64 bit)
MySQL - 5.7.33 : Database - clinicas
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`clinicas` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `clinicas`;

/*Table structure for table `area_eva` */

DROP TABLE IF EXISTS `area_eva`;

CREATE TABLE `area_eva` (
  `ID_area` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID_area`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `area_eva` */

/*Table structure for table `catalogo_signos` */

DROP TABLE IF EXISTS `catalogo_signos`;

CREATE TABLE `catalogo_signos` (
  `ID_sign` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `descripcion` varchar(200) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  `medida` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`ID_sign`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `catalogo_signos` */

/*Table structure for table `consulta` */

DROP TABLE IF EXISTS `consulta`;

CREATE TABLE `consulta` (
  `ID_consulta` int(11) NOT NULL AUTO_INCREMENT,
  `ID_paciente` int(11) DEFAULT NULL,
  `ID_signos` int(11) DEFAULT NULL,
  `nombre_provisional` varchar(50) DEFAULT NULL,
  `fecha_crea` datetime DEFAULT NULL,
  `motivo` varchar(200) DEFAULT NULL,
  `usuario_crea` int(11) DEFAULT NULL,
  `fecha_sig` datetime DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  `Usuario_creador` int(11) DEFAULT NULL,
  `Usuario_modifica` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_consulta`),
  KEY `ID_signos` (`ID_signos`),
  KEY `ID_paciente` (`ID_paciente`),
  KEY `Usuario_creador` (`Usuario_creador`),
  CONSTRAINT `consulta_ibfk_1` FOREIGN KEY (`ID_signos`) REFERENCES `signos` (`ID_signos`),
  CONSTRAINT `consulta_ibfk_2` FOREIGN KEY (`ID_paciente`) REFERENCES `paciente` (`ID_paciente`),
  CONSTRAINT `consulta_ibfk_3` FOREIGN KEY (`Usuario_creador`) REFERENCES `usuario` (`ID_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `consulta` */

/*Table structure for table `evaluacion` */

DROP TABLE IF EXISTS `evaluacion`;

CREATE TABLE `evaluacion` (
  `ID_eva` int(11) NOT NULL AUTO_INCREMENT,
  `ID_area` int(11) DEFAULT NULL,
  `ID_consulta` int(11) DEFAULT NULL,
  `evaluacion` varchar(200) DEFAULT NULL,
  `laboratorios` varchar(200) DEFAULT NULL,
  `receta` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`ID_eva`),
  KEY `ID_area` (`ID_area`),
  KEY `ID_consulta` (`ID_consulta`),
  CONSTRAINT `evaluacion_ibfk_1` FOREIGN KEY (`ID_area`) REFERENCES `area_eva` (`ID_area`),
  CONSTRAINT `evaluacion_ibfk_2` FOREIGN KEY (`ID_consulta`) REFERENCES `consulta` (`ID_consulta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `evaluacion` */

/*Table structure for table `modulos` */

DROP TABLE IF EXISTS `modulos`;

CREATE TABLE `modulos` (
  `ID_mod` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `fecha_crea` datetime DEFAULT NULL,
  PRIMARY KEY (`ID_mod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `modulos` */

/*Table structure for table `paciente` */

DROP TABLE IF EXISTS `paciente`;

CREATE TABLE `paciente` (
  `ID_paciente` int(11) NOT NULL AUTO_INCREMENT,
  `nombres` varchar(75) DEFAULT NULL,
  `apellidos` varchar(75) DEFAULT NULL,
  `DPI` varchar(10) DEFAULT NULL,
  `fecha_nacimiento` date DEFAULT NULL,
  `sexo` tinyint(4) DEFAULT NULL,
  `telefono` varchar(10) DEFAULT NULL,
  `celular` varchar(10) DEFAULT NULL,
  `tipo_sangre` varchar(15) DEFAULT NULL,
  `alergias` varchar(100) DEFAULT NULL,
  `Usuario_crea` int(11) DEFAULT NULL,
  `Usuario_modifica` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_paciente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `paciente` */

/*Table structure for table `permisos` */

DROP TABLE IF EXISTS `permisos`;

CREATE TABLE `permisos` (
  `ID_permisos` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `ID_mod` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_permisos`),
  KEY `ID_mod` (`ID_mod`),
  CONSTRAINT `permisos_ibfk_1` FOREIGN KEY (`ID_mod`) REFERENCES `modulos` (`ID_mod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `permisos` */

/*Table structure for table `rol` */

DROP TABLE IF EXISTS `rol`;

CREATE TABLE `rol` (
  `ID_rol` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `usuario_crea` int(11) DEFAULT NULL,
  `usuario_modifica` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_rol`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `rol` */

/*Table structure for table `rol_permisos` */

DROP TABLE IF EXISTS `rol_permisos`;

CREATE TABLE `rol_permisos` (
  `id_rolper` int(11) NOT NULL AUTO_INCREMENT,
  `ID_rol` int(11) DEFAULT NULL,
  `ID_permiso` int(11) DEFAULT NULL,
  `estado` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_rolper`),
  KEY `ID_rol` (`ID_rol`),
  KEY `ID_permiso` (`ID_permiso`),
  CONSTRAINT `rol_permisos_ibfk_1` FOREIGN KEY (`ID_rol`) REFERENCES `rol` (`ID_rol`),
  CONSTRAINT `rol_permisos_ibfk_2` FOREIGN KEY (`ID_permiso`) REFERENCES `permisos` (`ID_permisos`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `rol_permisos` */

/*Table structure for table `rol_usuario` */

DROP TABLE IF EXISTS `rol_usuario`;

CREATE TABLE `rol_usuario` (
  `ID_rolu` int(11) NOT NULL AUTO_INCREMENT,
  `ID_usuario` int(11) DEFAULT NULL,
  `ID_rol` int(11) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`ID_rolu`),
  KEY `ID_usuario` (`ID_usuario`),
  KEY `ID_rol` (`ID_rol`),
  CONSTRAINT `rol_usuario_ibfk_1` FOREIGN KEY (`ID_usuario`) REFERENCES `usuario` (`ID_usuario`),
  CONSTRAINT `rol_usuario_ibfk_2` FOREIGN KEY (`ID_rol`) REFERENCES `rol` (`ID_rol`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `rol_usuario` */

/*Table structure for table `signos` */

DROP TABLE IF EXISTS `signos`;

CREATE TABLE `signos` (
  `ID_signos` int(11) NOT NULL AUTO_INCREMENT,
  `ID_sign` int(11) DEFAULT NULL,
  `valor1` float DEFAULT NULL,
  `valor2` float DEFAULT NULL,
  `fecha_hora` datetime DEFAULT NULL,
  `observacion` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`ID_signos`),
  KEY `ID_sign` (`ID_sign`),
  CONSTRAINT `signos_ibfk_1` FOREIGN KEY (`ID_sign`) REFERENCES `catalogo_signos` (`ID_sign`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `signos` */

/*Table structure for table `usuario` */

DROP TABLE IF EXISTS `usuario`;

CREATE TABLE `usuario` (
  `ID_usuario` int(11) NOT NULL AUTO_INCREMENT,
  `nombres` varchar(150) DEFAULT NULL,
  `apellidos` varchar(150) DEFAULT NULL,
  `usuario` varchar(75) DEFAULT NULL,
  `pass` varchar(75) DEFAULT NULL,
  `fecha_crea` datetime DEFAULT NULL,
  PRIMARY KEY (`ID_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `usuario` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
