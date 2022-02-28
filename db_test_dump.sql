-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: pat.infolab.ecam.be    Database: Bovlo
-- ------------------------------------------------------
-- Server version	8.0.27-0ubuntu0.20.04.1

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
-- Table structure for table `Customer`
--

DROP TABLE IF EXISTS `Customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Customer` (
  `Customer_id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) DEFAULT NULL,
  `TVA` varchar(50) DEFAULT NULL,
  `Address` varchar(50) DEFAULT NULL,
  `Contact` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Customer_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Customer`
--

LOCK TABLES `Customer` WRITE;
/*!40000 ALTER TABLE `Customer` DISABLE KEYS */;
INSERT INTO `Customer` VALUES (1,'ol','0','1','2'),(2,'','','','');
/*!40000 ALTER TABLE `Customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Panier`
--

DROP TABLE IF EXISTS `Panier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Panier` (
  `Session_key` varchar(50) NOT NULL,
  `Quantity` varchar(50) DEFAULT NULL,
  `Product_type` varchar(50) DEFAULT NULL,
  `Price` varchar(50) DEFAULT NULL,
  `Size` varchar(50) DEFAULT NULL,
  `Colour` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Panier`
--

LOCK TABLES `Panier` WRITE;
/*!40000 ALTER TABLE `Panier` DISABLE KEYS */;
INSERT INTO `Panier` VALUES ('1','10','da','20','20','dza'),('2','20','City','500E','27','Blue'),('7X15T139FHUMGQS6UPOJ','10','City','500E','28','Blue'),('FWU4KO5M8B1PCDEZ37AX','15','Explorer','600E','28','Black'),('FWU4KO5M8B1PCDEZ37AX','20','Adventure','700E','27','Black'),('X9S4JAZW4JPUZZ8JRBX0','20','City','500E','27','Blue'),('X9S4JAZW4JPUZZ8JRBX0','20','Explorer','600E','27','Black'),('3XZHH3HERPBQ5CGFAOGM','20','City','500E','28','Blue'),('3XZHH3HERPBQ5CGFAOGM','20','City','500E','28','Green'),('3XZHH3HERPBQ5CGFAOGM','20','Explorer','600E','28','Black'),('HAQ6FUQUUQFJCOZBNSYD','20','City','500E','28','Blue'),('HAQ6FUQUUQFJCOZBNSYD','20','City','500E','28','Rose'),('EONQHYKNIXL70IVJP2KD','20','City','500E','28','Rose'),('EONQHYKNIXL70IVJP2KD','20','Explorer','600E','28','Black'),('EONQHYKNIXL70IVJP2KD','20','Explorer','600E','28','Black'),('DN3QFA05K8IXS3AN7ERN','10','City','500E','27','White'),('DN3QFA05K8IXS3AN7ERN','10','Explorer','600E','27','White'),('DN3QFA05K8IXS3AN7ERN','10','Explorer','600E','28','White'),('ZS605P5K0MS8W3Q593L3','10','City','500E','27','White'),('ZS605P5K0MS8W3Q593L3','7','Explorer','600E','28','Black');
/*!40000 ALTER TABLE `Panier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Stock_Velo`
--

DROP TABLE IF EXISTS `Stock_Velo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Stock_Velo` (
  `City` int DEFAULT NULL,
  `Adventure` int DEFAULT NULL,
  `Explorer` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Stock_Velo`
--

LOCK TABLES `Stock_Velo` WRITE;
/*!40000 ALTER TABLE `Stock_Velo` DISABLE KEYS */;
/*!40000 ALTER TABLE `Stock_Velo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Users`
--

DROP TABLE IF EXISTS `Users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Users` (
  `User_id` int NOT NULL AUTO_INCREMENT,
  `Pass` varchar(50) DEFAULT NULL,
  `Permission` varchar(50) DEFAULT NULL,
  `Username` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`User_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Users`
--

LOCK TABLES `Users` WRITE;
/*!40000 ALTER TABLE `Users` DISABLE KEYS */;
INSERT INTO `Users` VALUES (1,'user','Admin','User');
/*!40000 ALTER TABLE `Users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-02-28 13:08:16
