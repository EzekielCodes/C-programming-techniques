-- MySQL dump 10.13  Distrib 8.0.23, for Win64 (x86_64)
--
-- Host: localhost    Database: laboapplicatie01
-- ------------------------------------------------------
-- Server version	8.0.23

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
-- Table structure for table `opo_has_docenten`
--

DROP TABLE IF EXISTS `opo_has_docenten`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `opo_has_docenten` (
  `OPO_idOPO` int NOT NULL,
  `Docenten_Personeelslid_Persoon_idPersoon` int NOT NULL,
  PRIMARY KEY (`OPO_idOPO`,`Docenten_Personeelslid_Persoon_idPersoon`),
  KEY `fk_OPO_has_Docenten_Docenten1_idx` (`Docenten_Personeelslid_Persoon_idPersoon`),
  KEY `fk_OPO_has_Docenten_OPO1_idx` (`OPO_idOPO`),
  CONSTRAINT `fk_OPO_has_Docenten_Docenten1` FOREIGN KEY (`Docenten_Personeelslid_Persoon_idPersoon`) REFERENCES `docenten` (`Personeelslid_Persoon_idPersoon`),
  CONSTRAINT `fk_OPO_has_Docenten_OPO1` FOREIGN KEY (`OPO_idOPO`) REFERENCES `opo` (`idOPO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `opo_has_docenten`
--

LOCK TABLES `opo_has_docenten` WRITE;
/*!40000 ALTER TABLE `opo_has_docenten` DISABLE KEYS */;
INSERT INTO `opo_has_docenten` VALUES (2,4),(1,5),(4,5),(3,6);
/*!40000 ALTER TABLE `opo_has_docenten` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-02-10 13:26:30
