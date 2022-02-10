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
-- Table structure for table `student_has_opo`
--

DROP TABLE IF EXISTS `student_has_opo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `student_has_opo` (
  `Student_Persoon_idPersoon` int NOT NULL,
  `OPO_idOPO` int NOT NULL,
  PRIMARY KEY (`Student_Persoon_idPersoon`,`OPO_idOPO`),
  KEY `fk_Student_has_OPO_OPO1_idx` (`OPO_idOPO`),
  KEY `fk_Student_has_OPO_Student1_idx` (`Student_Persoon_idPersoon`),
  CONSTRAINT `fk_Student_has_OPO_OPO1` FOREIGN KEY (`OPO_idOPO`) REFERENCES `opo` (`idOPO`),
  CONSTRAINT `fk_Student_has_OPO_Student1` FOREIGN KEY (`Student_Persoon_idPersoon`) REFERENCES `student` (`Persoon_idPersoon`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student_has_opo`
--

LOCK TABLES `student_has_opo` WRITE;
/*!40000 ALTER TABLE `student_has_opo` DISABLE KEYS */;
INSERT INTO `student_has_opo` VALUES (1,1),(2,2),(3,3),(1,4),(2,4),(3,4);
/*!40000 ALTER TABLE `student_has_opo` ENABLE KEYS */;
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
