-- --------------------------------------------------------
-- Host:                         bv2rebwf6zzsv341.cbetxkdyhwsb.us-east-1.rds.amazonaws.com
-- Versión del servidor:         8.0.23 - Source distribution
-- SO del servidor:              Linux
-- HeidiSQL Versión:             12.0.0.6468
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Volcando datos para la tabla w5cs9lzy1kkfo467.crop: ~0 rows (aproximadamente)
INSERT INTO `crop` (`CropId`, `Type`, `Name`, `PlotId`, `Status`) VALUES
	('41f8cecf-88c3-400a-84ab-8f2a1fafb027', 'Cereales', 'Maiz', '030accff-0bd2-456a-be56-f2a36acdc13c', 0),
	('5e4368a8-b75f-45bd-b812-41f8cecf-88c', 'Cereales', 'Arroz', '0dcdcd7e-7e70-4072-b41d-f3c3de079ea9', 0),
	('8fc6aae6-36ea-4e32-82e4-fabd28dde035', 'Leguminosas', 'Frijol', '3a12e682-fac6-451b-9091-72561f192d00', 1),
	('994fb87a-32a0-45d0-9747-d00fa2bf1415', 'Frutales', 'Mango', '3f27d514-eeb0-42b8-8d82-368fa4cc46c5', 3),
	('9a9f724d-9815-4e08-b095-62839bf81317', 'Oleaginosas', 'Soja', '9897a6ca-7bc7-466f-884d-ac7ae1dc7d8e', 1),
	('b48ff4a4-1833-4024-ac11-a4ffedd6bf83', 'Hortalizas', 'Tomate', '2dfda251-0795-4522-85b8-d24fd3fb9ca7', 2),
	('bec8e2ab-96f1-4337-9b70-19f42ae1919f', 'Hortalizas', 'Lechuga', '842b7b99-a9a9-4cda-93b5-526cc97093d1', 2),
	('f5868f0a-bae6-45a1-8c54-d24fc4416a12', 'Frutales', 'Aguacate', '4e9d85f9-1861-4181-9be2-df63cacc0f78', 3);

-- Volcando datos para la tabla w5cs9lzy1kkfo467.inventory: ~0 rows (aproximadamente)
INSERT INTO `inventory` (`InvetoryId`, `Type`, `Amount`, `Warehouse`) VALUES
	('179de588-1ab5-4fde-ada7-0e9c55dcd1db', 'Leguminosas', 23, 'Caldas '),
	('3b109a0e-25cd-4945-a020-0c5a4ee01367', 'Frutales', 20000, 'Monteria'),
	('776f4653-cc00-437d-be76-50e9b256e3a8', 'Hortalizas', 0, 'Bogotá'),
	('8d80ac1a-91c0-47f7-8843-801d96d72353', 'Oleaginosas', 300, 'Bello'),
	('c3effe35-364a-43c7-8ed9-f328f886313c', 'Cereal', 1000, 'Medellin');

-- Volcando datos para la tabla w5cs9lzy1kkfo467.plot: ~0 rows (aproximadamente)
INSERT INTO `plot` (`PlotId`, `Size`, `Location`, `CropSuitability`, `Status`) VALUES
	('030accff-0bd2-456a-be56-f2a36acdc13c', '250 m2', 'Guainía	', 'Cereales', 1),
	('0dcdcd7e-7e70-4072-b41d-f3c3de079ea9', '200 m2', 'Antioquia', 'Cereales', 1),
	('2dfda251-0795-4522-85b8-d24fd3fb9ca7', '500 m2', 'Antioquia', 'Hortalizas', 2),
	('3a12e682-fac6-451b-9091-72561f192d00', '600 m2', 'Cundinamarca', 'Leguminosas', 1),
	('3f27d514-eeb0-42b8-8d82-368fa4cc46c5', '400 m2', 'Cundinamarca', 'Frutales', 0),
	('4e9d85f9-1861-4181-9be2-df63cacc0f78', '1000 m2', 'Cundinamarca', 'Frutales', 0),
	('842b7b99-a9a9-4cda-93b5-526cc97093d1', '2000 m2', 'Guaviare	', 'Hortalizas', 2),
	('9897a6ca-7bc7-466f-884d-ac7ae1dc7d8e', '700 m2', 'Huila', 'Oleaginosas', 0);

-- Volcando datos para la tabla w5cs9lzy1kkfo467.__efmigrationshistory: ~1 rows (aproximadamente)
INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
	('20220428173818_InitialCreate', '6.0.4'),
	('20220428202710_InitialCreate', '6.0.4'),
	('20220428205854_InitialCreate', '6.0.4');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
