CREATE DATABASE  IF NOT EXISTS `dbo` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `dbo`;
-- MySQL dump 10.13  Distrib 8.0.26, for Win64 (x86_64)
--
-- Host: 10.251.8.242    Database: dbo
-- ------------------------------------------------------
-- Server version	5.6.21-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `attachedproduct`
--

DROP TABLE IF EXISTS `attachedproduct`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `attachedproduct` (
  `MainProductID` int(11) NOT NULL,
  `AttachedProductID` int(11) NOT NULL,
  PRIMARY KEY (`MainProductID`,`AttachedProductID`),
  KEY `attachedproduct_idx` (`AttachedProductID`),
  CONSTRAINT `attachedproduct` FOREIGN KEY (`AttachedProductID`) REFERENCES `product` (`id`),
  CONSTRAINT `mainproduct` FOREIGN KEY (`MainProductID`) REFERENCES `product` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `attachedproduct`
--

LOCK TABLES `attachedproduct` WRITE;
/*!40000 ALTER TABLE `attachedproduct` DISABLE KEYS */;
/*!40000 ALTER TABLE `attachedproduct` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `client` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `LastName` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `Patronymic` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `Birthday` datetime DEFAULT NULL,
  `RegistrationDate` datetime DEFAULT NULL,
  `Email` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `Phone` int(11) DEFAULT NULL,
  `GenderCode` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `gender_idx` (`GenderCode`),
  CONSTRAINT `gender` FOREIGN KEY (`GenderCode`) REFERENCES `gender` (`Code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientservice`
--

DROP TABLE IF EXISTS `clientservice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientservice` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ClientID` int(11) DEFAULT NULL,
  `ServiceID` int(11) DEFAULT NULL,
  `StartTime` datetime DEFAULT NULL,
  `Comment` varchar(150) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `client_idx` (`ClientID`),
  KEY `service_idx` (`ServiceID`),
  CONSTRAINT `client` FOREIGN KEY (`ClientID`) REFERENCES `client` (`id`),
  CONSTRAINT `service` FOREIGN KEY (`ServiceID`) REFERENCES `service` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientservice`
--

LOCK TABLES `clientservice` WRITE;
/*!40000 ALTER TABLE `clientservice` DISABLE KEYS */;
/*!40000 ALTER TABLE `clientservice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `documentbyservice`
--

DROP TABLE IF EXISTS `documentbyservice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `documentbyservice` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ClientServiceID` int(11) DEFAULT NULL,
  `DocumentPath` longtext COLLATE utf8_bin,
  PRIMARY KEY (`id`),
  KEY `clientservice_idx` (`ClientServiceID`),
  CONSTRAINT `clientservicee` FOREIGN KEY (`ClientServiceID`) REFERENCES `clientservice` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `documentbyservice`
--

LOCK TABLES `documentbyservice` WRITE;
/*!40000 ALTER TABLE `documentbyservice` DISABLE KEYS */;
/*!40000 ALTER TABLE `documentbyservice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gender`
--

DROP TABLE IF EXISTS `gender`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `gender` (
  `Code` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`Code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gender`
--

LOCK TABLES `gender` WRITE;
/*!40000 ALTER TABLE `gender` DISABLE KEYS */;
/*!40000 ALTER TABLE `gender` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `logs`
--

DROP TABLE IF EXISTS `logs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `logs` (
  `idLog` int(11) NOT NULL AUTO_INCREMENT,
  `userId` int(11) DEFAULT NULL,
  `action` enum('Вход','Выход') COLLATE utf8_bin DEFAULT NULL,
  `time` datetime DEFAULT NULL,
  PRIMARY KEY (`idLog`),
  KEY `uid_idx` (`userId`),
  CONSTRAINT `uid` FOREIGN KEY (`userId`) REFERENCES `user` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=95 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `logs`
--

LOCK TABLES `logs` WRITE;
/*!40000 ALTER TABLE `logs` DISABLE KEYS */;
INSERT INTO `logs` VALUES (1,1,'Вход','2021-09-20 00:00:00'),(2,1,'Вход','2021-09-20 00:00:00'),(3,1,'Вход','2021-09-20 02:37:45'),(4,1,'Вход','2021-09-20 02:39:39'),(5,1,'Вход','2021-09-20 02:41:01'),(6,1,'Вход','2021-09-20 02:44:53'),(7,1,'Вход','2021-09-20 02:50:12'),(8,1,'Вход','2021-09-20 04:45:01'),(9,1,'Вход','2021-09-20 04:49:01'),(10,1,'Вход','2021-09-20 04:57:05'),(11,1,'Вход','2021-09-20 05:01:22'),(12,1,'Вход','2021-09-20 05:02:58'),(13,1,'Вход','2021-09-20 05:04:43'),(14,1,'Вход','2021-09-20 05:05:24'),(15,1,'Вход','2021-09-20 05:08:56'),(16,1,'Вход','2021-09-20 05:22:00'),(17,1,'Вход','2021-09-20 05:27:29'),(18,1,'Вход','2021-09-20 05:29:32'),(19,1,'Вход','2021-09-20 05:31:32'),(20,1,'Вход','2021-09-20 05:35:09'),(21,1,'Вход','2021-09-20 05:37:32'),(22,1,'Вход','2021-09-20 05:38:35'),(23,1,'Вход','2021-09-20 05:39:47'),(24,1,'Вход','2021-09-20 05:42:11'),(25,1,'Вход','2021-09-20 05:44:11'),(26,1,'Вход','2021-09-20 05:46:31'),(27,1,'Вход','2021-09-20 05:48:52'),(28,1,'Вход','2021-09-20 06:10:33'),(29,1,'Вход','2021-09-20 06:19:14'),(30,1,'Вход','2021-09-20 06:21:34'),(31,1,'Вход','2021-09-20 06:38:30'),(32,1,'Вход','2021-09-20 06:39:38'),(33,1,'Вход','2021-09-20 06:40:15'),(34,1,'Вход','2021-09-20 06:43:05'),(35,1,'Вход','2021-09-20 06:44:34'),(36,1,'Вход','2021-09-20 06:49:07'),(37,1,'Вход','2021-09-20 07:03:57'),(38,1,'Вход','2021-09-20 07:08:34'),(39,1,'Вход','2021-09-20 07:14:42'),(40,1,'Вход','2021-09-20 07:19:48'),(41,1,'Вход','2021-09-20 07:21:40'),(42,1,'Вход','2021-09-20 07:23:25'),(43,1,'Вход','2021-09-20 07:33:36'),(44,1,'Вход','2021-09-20 07:38:24'),(45,1,'Вход','2021-09-20 07:41:35'),(46,1,'Вход','2021-09-20 07:43:15'),(47,1,'Вход','2021-09-20 07:45:20'),(48,1,'Вход','2021-09-20 07:47:11'),(49,1,'Вход','2021-09-20 07:50:15'),(50,1,'Вход','2021-09-20 07:56:33'),(51,1,'Вход','2021-09-20 12:32:59'),(52,1,'Вход','2021-09-20 12:37:19'),(53,1,'Вход','2021-09-20 12:46:26'),(54,1,'Вход','2021-09-20 12:48:56'),(55,1,'Вход','2021-09-20 12:53:25'),(56,1,'Выход','2021-09-20 12:53:27'),(57,1,'Вход','2021-09-20 13:00:00'),(58,1,'Выход','2021-09-20 13:00:10'),(59,1,'Вход','2021-09-20 13:02:32'),(60,1,'Вход','2021-09-20 13:04:50'),(61,1,'Выход','2021-09-20 13:05:06'),(62,2,'Вход','2021-09-20 13:05:22'),(63,2,'Выход','2021-09-20 13:05:28'),(64,1,'Вход','2021-09-20 13:13:54'),(65,1,'Вход','2021-09-20 13:16:33'),(66,1,'Вход','2021-09-20 13:23:42'),(67,1,'Вход','2021-09-20 13:27:20'),(68,1,'Вход','2021-09-20 13:27:54'),(69,1,'Вход','2021-09-20 13:28:56'),(70,1,'Вход','2021-09-21 15:40:08'),(71,1,'Вход','2021-09-21 15:43:30'),(72,1,'Вход','2021-09-21 15:54:55'),(73,1,'Выход','2021-09-21 15:54:57'),(74,1,'Выход','2021-09-21 15:54:57'),(75,1,'Вход','2021-09-21 15:59:16'),(76,1,'Выход','2021-09-21 15:59:18'),(77,1,'Вход','2021-09-21 15:59:26'),(78,1,'Выход','2021-09-21 15:59:32'),(79,1,'Вход','2021-09-21 16:09:04'),(80,1,'Вход','2021-09-21 16:09:04'),(81,1,'Вход','2021-09-21 16:14:42'),(82,1,'Вход','2021-09-21 16:15:57'),(83,1,'Вход','2021-09-21 16:21:07'),(84,1,'Выход','2021-09-21 16:22:31'),(85,1,'Вход','2021-09-21 16:46:18'),(86,1,'Выход','2021-09-21 16:46:29'),(87,1,'Вход','2021-09-21 16:47:03'),(88,1,'Выход','2021-09-21 16:47:07'),(89,1,'Вход','2021-09-21 16:48:48'),(90,1,'Выход','2021-09-21 16:49:30'),(91,1,'Вход','2021-09-21 16:50:05'),(92,1,'Выход','2021-09-21 16:51:32'),(93,1,'Вход','2021-09-21 16:52:21'),(94,1,'Выход','2021-09-21 16:52:40');
/*!40000 ALTER TABLE `logs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `manufacturer`
--

DROP TABLE IF EXISTS `manufacturer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `manufacturer` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `StartDate` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `manufacturer`
--

LOCK TABLES `manufacturer` WRITE;
/*!40000 ALTER TABLE `manufacturer` DISABLE KEYS */;
INSERT INTO `manufacturer` VALUES (1,'TEST','2021-09-20 06:42:03');
/*!40000 ALTER TABLE `manufacturer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Title` varchar(145) COLLATE utf8_bin DEFAULT NULL,
  `Cost` int(11) DEFAULT NULL,
  `Description` varchar(150) COLLATE utf8_bin DEFAULT NULL,
  `IsActive` tinyint(4) DEFAULT NULL,
  `ManufacturerID` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `manaufacturer_idx` (`ManufacturerID`),
  CONSTRAINT `manaufacturer` FOREIGN KEY (`ManufacturerID`) REFERENCES `manufacturer` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES (1,'Тест1',5,'Простое описание',1,1),(2,'ф',3,'вап',1,1),(3,'SELECT * FROM dbo.manufacturer;',4,'вап',1,1),(4,'ифпфавп',3,'вап',1,1),(5,'уифпфавп',3,'вап',1,1),(6,'2уифпфавп',3,'вап',1,1),(7,'ц2уифпфавп',3,'вап',1,1),(9,'privet',53,'privet opisanie',1,1);
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productsale`
--

DROP TABLE IF EXISTS `productsale`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productsale` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `SaleDate` datetime DEFAULT NULL,
  `ProductID` int(11) DEFAULT NULL,
  `Quantity` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `ClientServiceID` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `product_idx` (`ProductID`),
  KEY `clientservice_idx` (`ClientServiceID`),
  CONSTRAINT `clientservice` FOREIGN KEY (`ClientServiceID`) REFERENCES `clientservice` (`id`),
  CONSTRAINT `product` FOREIGN KEY (`ProductID`) REFERENCES `product` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productsale`
--

LOCK TABLES `productsale` WRITE;
/*!40000 ALTER TABLE `productsale` DISABLE KEYS */;
/*!40000 ALTER TABLE `productsale` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `service`
--

DROP TABLE IF EXISTS `service`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `service` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Title` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `Cost` int(11) DEFAULT NULL,
  `DurationInSeconds` int(11) DEFAULT NULL,
  `Description` varchar(150) COLLATE utf8_bin DEFAULT NULL,
  `Discount` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `service`
--

LOCK TABLES `service` WRITE;
/*!40000 ALTER TABLE `service` DISABLE KEYS */;
/*!40000 ALTER TABLE `service` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tag`
--

DROP TABLE IF EXISTS `tag`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tag` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Title` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `Color` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tag`
--

LOCK TABLES `tag` WRITE;
/*!40000 ALTER TABLE `tag` DISABLE KEYS */;
/*!40000 ALTER TABLE `tag` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tagofclient`
--

DROP TABLE IF EXISTS `tagofclient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tagofclient` (
  `clientid` int(11) NOT NULL,
  `TagID` int(11) DEFAULT NULL,
  PRIMARY KEY (`clientid`),
  KEY `tag_idx` (`TagID`),
  CONSTRAINT `clienttag` FOREIGN KEY (`clientid`) REFERENCES `client` (`id`),
  CONSTRAINT `tag` FOREIGN KEY (`TagID`) REFERENCES `tag` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tagofclient`
--

LOCK TABLES `tagofclient` WRITE;
/*!40000 ALTER TABLE `tagofclient` DISABLE KEYS */;
/*!40000 ALTER TABLE `tagofclient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `Surname` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `Post` enum('Администратор','Работник') COLLATE utf8_bin DEFAULT NULL,
  `Login` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  `Password` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'Георгий','Таскабулов','Администратор','root','qwerty'),(2,'Дмитрий','Еремеев','Работник','dm_e','123321'),(3,'т1','т1','Администратор','т1','т1');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-09-21 16:57:34
