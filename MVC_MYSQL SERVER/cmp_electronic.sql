-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: localhost    Database: cmp_electronic
-- ------------------------------------------------------
-- Server version	8.0.31

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
-- Table structure for table `categorie`
--

DROP TABLE IF EXISTS `categorie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categorie` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(145) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `name_UNIQUE` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categorie`
--

LOCK TABLES `categorie` WRITE;
/*!40000 ALTER TABLE `categorie` DISABLE KEYS */;
INSERT INTO `categorie` VALUES (6,'Accessoire Ordinateur'),(5,'Electrique'),(4,'Materiel Bureau'),(3,'Ordinateur');
/*!40000 ALTER TABLE `categorie` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `corbeille_employe`
--

DROP TABLE IF EXISTS `corbeille_employe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `corbeille_employe` (
  `id` int NOT NULL AUTO_INCREMENT,
  `code` varchar(105) NOT NULL,
  `nom` varchar(105) NOT NULL,
  `prenom` varchar(145) NOT NULL,
  `date_naiss` varchar(145) NOT NULL,
  `sexe` varchar(1) NOT NULL,
  `adresse` varchar(145) NOT NULL,
  `nif` varchar(45) NOT NULL,
  `email` varchar(145) NOT NULL,
  `tel` varchar(45) NOT NULL,
  `poste` varchar(45) NOT NULL,
  `date_embauche` varchar(45) NOT NULL,
  `photo` longblob,
  `date_save` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE KEY `code_UNIQUE` (`code`),
  UNIQUE KEY `nif_UNIQUE` (`nif`),
  UNIQUE KEY `email_UNIQUE` (`email`),
  UNIQUE KEY `tel_UNIQUE` (`tel`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `corbeille_employe`
--

LOCK TABLES `corbeille_employe` WRITE;
/*!40000 ALTER TABLE `corbeille_employe` DISABLE KEYS */;
INSERT INTO `corbeille_employe` VALUES (2,'CMP-QW-777-8','Julien','Marc','2/8/2000','F','Madeline','233-333-333-3','marc@gmail.com','(509) 3453-3443','Vendeur','8/13/2023',_binary 'ÿ\Øÿ\à\0JFIF\0\0`\0`\0\0ÿ\á\0ZExif\0\0MM\0*\0\0\0\0\0\0\0\0\0\0\0J\0\0\0\0\0\0\0\0Q\0\0\0\0\0\0\0Q\0\0\0\0\0\0\0\0Q\0\0\0\0\0\0\0\0\0\0\0\0\0† \0\0±ÿ\Û\0C\0		\n\r\Z\Z $.\' \",#(7),01444\'9=82<.342ÿ\Û\0C			\r\r2!!22222222222222222222222222222222222222222222222222ÿÀ\0\0`\0`\"\0ÿ\Ä\0\0\0\0\0\0\0\0\0\0\0	\nÿ\Ä\0µ\0\0\0}\0!1AQa\"q2‘¡#B±ÁR\Ñğ$3br‚	\n\Z%&\'()*456789:CDEFGHIJSTUVWXYZcdefghijstuvwxyzƒ„…†‡ˆ‰Š’“”•–—˜™š¢£¤¥¦§¨©ª²³´µ¶·¸¹º\Â\Ã\Ä\Å\Æ\Ç\È\É\Ê\Ò\Ó\Ô\Õ\Ö\×\Ø\Ù\Ú\á\â\ã\ä\å\æ\ç\è\é\êñòóôõö÷øùúÿ\Ä\0\0\0\0\0\0\0\0	\nÿ\Ä\0µ\0\0w\0!1AQaq\"2B‘¡±Á	#3Rğbr\Ñ\n$4\á%ñ\Z&\'()*56789:CDEFGHIJSTUVWXYZcdefghijstuvwxyz‚ƒ„…†‡ˆ‰Š’“”•–—˜™š¢£¤¥¦§¨©ª²³´µ¶·¸¹º\Â\Ã\Ä\Å\Æ\Ç\È\É\Ê\Ò\Ó\Ô\Õ\Ö\×\Ø\Ù\Ú\â\ã\ä\å\æ\ç\è\é\êòóôõö÷øùúÿ\Ú\0\0\0?\0ùşŠ( Š( Š\éôı\Ò9®[\Ív@\ŞYR¸>½³\Æ:õ\ë[JªŠ@U\0À >¢½DYch\Üe\\a\ê\rs7~·Á/FK.\ÜÃ“ô‹EPEPEPZº\rŸ\Úo¼\Ö»ƒy\êİ¿–\nÊ®‡\Âÿ\0òõÿ\0\0ÿ\0Ù¨¡©m\í§»”Eo“Hz,jXş•\éú€4›L5É’\îAıóµ!ıI®’\Ş\Ö\Ş\Ò/*\Ú\áŒj~•\ã\Ö\Î)\ÇJjÿ\0\è\Ó\Ë\æş7c\Ìtÿ\0\0\ê÷xk.\Ò3ÿ\0=\æü‡õ\"±u\ëE¾kk¥÷GuÇ¨¯n¬ıcGµ\Ö\ìZ\Ú\å}\ÒA÷úŠå£›\Ôö—©ğùT\Ë\á\É\în|\Í\âQ\rø•W0\ÏûÃ¯ô?dWC\âùuÿ\0ÿ\0\ìµ\ÏW\Ñ@QE\0QE\0W­ø;Áj>¶\Ô-—Q¸i÷·\ÊÁY”/·\İ\Î}I\ÏÇ’W}ğ\ÏÅš…‡ˆô\Íkö]*Y™<–@\Ã{©\nÁ +Ğ’I\êk\Z«{>j.\Í;ú¥}Œ3§\ÏjŠ\é\è{¾§{ı§Ow\å4¾R\çbõ<Ñ¦\Şÿ\0h\é\Ğ]ùMš¹\Ø\İG5nŠù;«ZÚş·*jw¿\Ù\Út÷~SK\å.v/S\Í\Zm\ïöß”\Ñy«\ÔsV\è¢\êÖ¶¡­\Ïñ‚-ô\ß\Ü\ênÍ¨Û´l¥\åPÌªW\ß\ïg> cŒ\ç\È\ë¾ø™\â\ÍBÿ\0\Äz‘ Í¥E2§’¨oE8€áº’2p5õ˜[\ÙóVwm\ß\Ñ;hx—O\ÔÕ’\Ğ(¢Š\ì9ÂŠ( Ÿ²A2M±°dtbH\äGCL¢€>ğ\',|M¦Aosr‘k¨X¤eV™€\å\Ğp8$€>^{`Î¾wğ&‹¨\éş4\Ón/-^\İ)\n\ã1°Só’;w¯r[‰a\\\ãßšøüŞœpX…4š¿\âÏ Ëª}f2i´\ìkW\ã¿XøgL\Ş\Ú\å%\Ö$SP\Æ\Ê\ÍÃ¸\ç\0dù¸\í’7Z\âgg8ö\â¼7\Çz.£¨x\ÓR¸³µ{„&0D3œF \áG\ÌpA\íÚŒ¢š\Æ\â,\ÚJÿ\0ŠÆ§\Õh©6“n\Ç,²O3\Í4$²1gwbY‰\ä’OSL¢Šû\çÂŠ( Š( \r\rF½×µ8\ì,\"\ß+òI\áQ{³Àõ†I½\ÓÃ\Ò<9M5\ê¯\Ïw\"\å\É\ç%¸9#¶3µW\áŞ‰\áKyHSq|¢\æG\è\Ã\ä\\\à\Ç8%±Öº\Êöğ˜X\Â*r\İş\Í\ãñ²©7N.\Ñ_‰\Ëø«HY#\Ô\ì\Ã¢x^¸†J];\Æ6’B«~\Z€\Ã0RTûñÈ®³\î´M2ñ\Ë\Ïg9\ê\Ã*OÔŒVY–S†\Ì`£]j¶kF‡–\æ\Õğn“\Ñô{\ZŒm#…–À4\Ó…b¤(÷\ç“I\á]\"xMNğ0šPv\ëƒ\Écõ­‹]M³pğYÆ®:1\Ëô\'5¡F[”\á²\è8\ĞZ½\ÛÕ°Ì³jøù\'U\èº-w\Ä~\Ò<G­4\r\ë.\î5Ãƒ\Æ|pl\àµ\ázÎ{ \êrX_Å²T\äÊºöe=Áÿ\0\ëE}-\\Ÿ\ÄM=cÂ·|«qb­qŸ@2\ëœ‚£§…\Ík‹\Â\Æqs\ëñ*sT\ä\ïøEWˆ} QEõ5ò\Í\êiÿ\0wñÿ\0€x\Ø\ß\ßü?\àŸSQ_,\ÑGöŸ÷øııÿ\0\Ãş	õ5ò\Íiÿ\0wñÿ\0€\Ø\ß\ßü?\àŸSQ_,\ÑGöŸ÷øııÿ\0\ÃşQE\å\áÿ\Ù','2023-09-11 15:58:49');
/*!40000 ALTER TABLE `corbeille_employe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `corbeille_sales`
--

DROP TABLE IF EXISTS `corbeille_sales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `corbeille_sales` (
  `id` int NOT NULL AUTO_INCREMENT,
  `code` varchar(145) NOT NULL,
  `client` varchar(145) NOT NULL,
  `produit` int NOT NULL,
  `quantite` int DEFAULT NULL,
  `montant` double DEFAULT NULL,
  `date_save` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `fk_produit1_idx` (`produit`),
  CONSTRAINT `fk_produit1` FOREIGN KEY (`produit`) REFERENCES `supply` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `corbeille_sales`
--

LOCK TABLES `corbeille_sales` WRITE;
/*!40000 ALTER TABLE `corbeille_sales` DISABLE KEYS */;
INSERT INTO `corbeille_sales` VALUES (1,'MA-15-6','Louis Lit',2,3,1800,'2023-08-17 21:40:19'),(2,'MA-15-6','Louis Lit',3,3,60,'2023-08-17 21:40:19'),(4,'MA-15-6','Louis Lit',2,3,1800,'2023-08-17 21:40:22'),(5,'MA-15-6','Louis Lit',3,3,60,'2023-08-17 21:40:22'),(7,'MA-15-6','Louis Lit',2,3,1800,'2023-08-18 15:58:07'),(8,'MA-15-6','Louis Lit',3,3,60,'2023-08-18 15:58:07'),(10,'MA-15-6','Louis Lit',2,3,1800,'2023-08-18 15:58:09'),(11,'MA-15-6','Louis Lit',3,3,60,'2023-08-18 15:58:09'),(13,'MA-15-6','Louis Lit',2,3,1800,'2023-08-18 16:00:16'),(14,'MA-15-6','Louis Lit',3,3,60,'2023-08-18 16:00:16'),(16,'MA-23-7','Jean',2,50,30000,'2023-08-18 16:02:55'),(17,'MA-23-7','Jean',3,50,1000,'2023-08-18 16:02:55'),(19,'MA-56-8','Louis',3,10,200,'2023-08-18 16:05:25'),(20,'MA-56-8','Louis',3,10,200,'2023-08-18 16:05:25'),(22,'MA-30-10','Pierre',2,5,3000,'2023-08-18 16:07:13'),(23,'MA-30-10','Pierre',4,5,2500,'2023-08-18 16:07:13'),(24,'MA-30-10','Pierre',3,5,100,'2023-08-18 16:07:13'),(25,'EL-82-9','marie',2,10,6000,'2023-08-18 16:09:24'),(26,'EL-82-9','marie',3,5,100,'2023-08-18 16:09:24'),(27,'EL-82-9','marie',5,2,2000,'2023-08-18 16:09:24'),(28,'OR-64-11','gfd',2,5,3000,'2023-08-18 16:11:01'),(29,'OR-64-11','gfd',4,5,2500,'2023-08-18 16:11:01'),(31,'EL-35-12','Louis',2,6,3600,'2023-08-18 16:19:08'),(32,'EL-35-12','Louis',3,6,120,'2023-08-18 16:19:08'),(33,'EL-35-12','Louis',5,2,2000,'2023-08-18 16:19:08'),(34,'MA-40-14','Melanie',3,5,100,'2023-08-18 18:09:51'),(35,'EL-43-15','Willy',3,4,80,'2023-08-25 14:23:43'),(36,'EL-43-15','Willy',4,5,2500,'2023-08-25 14:23:43'),(37,'EL-43-15','Willy',5,2,2000,'2023-08-25 14:23:43'),(38,'OR-52-13','Marie',4,5,2500,'2023-08-25 14:25:26'),(39,'AC-24-18','MK',4,10,5000,'2023-09-11 17:44:47'),(40,'AC-24-18','MK',7,5,40000,'2023-09-11 17:44:47');
/*!40000 ALTER TABLE `corbeille_sales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employe`
--

DROP TABLE IF EXISTS `employe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employe` (
  `id` int NOT NULL AUTO_INCREMENT,
  `code` varchar(105) NOT NULL,
  `nom` varchar(105) NOT NULL,
  `prenom` varchar(145) NOT NULL,
  `date_naiss` varchar(145) NOT NULL,
  `sexe` varchar(1) NOT NULL,
  `adresse` varchar(145) NOT NULL,
  `nif` varchar(45) NOT NULL,
  `email` varchar(145) NOT NULL,
  `tel` varchar(45) NOT NULL,
  `poste` varchar(45) NOT NULL,
  `date_embauche` varchar(45) NOT NULL,
  `photo` longblob,
  `date_save` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE KEY `code_UNIQUE` (`code`),
  UNIQUE KEY `nif_UNIQUE` (`nif`),
  UNIQUE KEY `email_UNIQUE` (`email`),
  UNIQUE KEY `tel_UNIQUE` (`tel`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employe`
--

LOCK TABLES `employe` WRITE;
/*!40000 ALTER TABLE `employe` DISABLE KEYS */;
INSERT INTO `employe` VALUES (4,'CMP-DA-449-5','Jean Baptiste','Melanie','5/30/2000','F','Champin','111-111-111-1','melanie@gmail.com','(509) 1111-1111','Secretaire','8/14/2023',_binary 'ÿ\Øÿ\à\0JFIF\0\0`\0`\0\0ÿ\á\0ZExif\0\0MM\0*\0\0\0\0\0\0\0\0\0\0\0J\0\0\0\0\0\0\0\0Q\0\0\0\0\0\0\0Q\0\0\0\0\0\0\0\0Q\0\0\0\0\0\0\0\0\0\0\0\0\0† \0\0±ÿ\Û\0C\0		\n\r\Z\Z $.\' \",#(7),01444\'9=82<.342ÿ\Û\0C			\r\r2!!22222222222222222222222222222222222222222222222222ÿÀ\0\0`\0`\"\0ÿ\Ä\0\0\0\0\0\0\0\0\0\0\0	\nÿ\Ä\0µ\0\0\0}\0!1AQa\"q2‘¡#B±ÁR\Ñğ$3br‚	\n\Z%&\'()*456789:CDEFGHIJSTUVWXYZcdefghijstuvwxyzƒ„…†‡ˆ‰Š’“”•–—˜™š¢£¤¥¦§¨©ª²³´µ¶·¸¹º\Â\Ã\Ä\Å\Æ\Ç\È\É\Ê\Ò\Ó\Ô\Õ\Ö\×\Ø\Ù\Ú\á\â\ã\ä\å\æ\ç\è\é\êñòóôõö÷øùúÿ\Ä\0\0\0\0\0\0\0\0	\nÿ\Ä\0µ\0\0w\0!1AQaq\"2B‘¡±Á	#3Rğbr\Ñ\n$4\á%ñ\Z&\'()*56789:CDEFGHIJSTUVWXYZcdefghijstuvwxyz‚ƒ„…†‡ˆ‰Š’“”•–—˜™š¢£¤¥¦§¨©ª²³´µ¶·¸¹º\Â\Ã\Ä\Å\Æ\Ç\È\É\Ê\Ò\Ó\Ô\Õ\Ö\×\Ø\Ù\Ú\â\ã\ä\å\æ\ç\è\é\êòóôõö÷øùúÿ\Ú\0\0\0?\0ùşŠ( Š( Š\éôı\Ò9®[\Ív@\ŞYR¸>½³\Æ:õ\ë[JªŠ@U\0À >¢½DYch\Üe\\a\ê\rs7~·Á/FK.\ÜÃ“ô‹EPEPEPZº\rŸ\Úo¼\Ö»ƒy\êİ¿–\nÊ®‡\Âÿ\0òõÿ\0\0ÿ\0Ù¨¡©m\í§»”Eo“Hz,jXş•\éú€4›L5É’\îAıóµ!ıI®’\Ş\Ö\Ş\Ò/*\Ú\áŒj~•\ã\Ö\Î)\ÇJjÿ\0\è\Ó\Ë\æş7c\Ìtÿ\0\0\ê÷xk.\Ò3ÿ\0=\æü‡õ\"±u\ëE¾kk¥÷GuÇ¨¯n¬ıcGµ\Ö\ìZ\Ú\å}\ÒA÷úŠå£›\Ôö—©ğùT\Ë\á\É\în|\Í\âQ\rø•W0\ÏûÃ¯ô?dWC\âùuÿ\0ÿ\0\ìµ\ÏW\Ñ@QE\0QE\0W­ø;Áj>¶\Ô-—Q¸i÷·\ÊÁY”/·\İ\Î}I\ÏÇ’W}ğ\ÏÅš…‡ˆô\Íkö]*Y™<–@\Ã{©\nÁ +Ğ’I\êk\Z«{>j.\Í;ú¥}Œ3§\ÏjŠ\é\è{¾§{ı§Ow\å4¾R\çbõ<Ñ¦\Şÿ\0h\é\Ğ]ùMš¹\Ø\İG5nŠù;«ZÚş·*jw¿\Ù\Út÷~SK\å.v/S\Í\Zm\ïöß”\Ñy«\ÔsV\è¢\êÖ¶¡­\Ïñ‚-ô\ß\Ü\ênÍ¨Û´l¥\åPÌªW\ß\ïg> cŒ\ç\È\ë¾ø™\â\ÍBÿ\0\Äz‘ Í¥E2§’¨oE8€áº’2p5õ˜[\ÙóVwm\ß\Ñ;hx—O\ÔÕ’\Ğ(¢Š\ì9ÂŠ( Ÿ²A2M±°dtbH\äGCL¢€>ğ\',|M¦Aosr‘k¨X¤eV™€\å\Ğp8$€>^{`Î¾wğ&‹¨\éş4\Ón/-^\İ)\n\ã1°Só’;w¯r[‰a\\\ãßšøüŞœpX…4š¿\âÏ Ëª}f2i´\ìkW\ã¿XøgL\Ş\Ú\å%\Ö$SP\Æ\Ê\ÍÃ¸\ç\0dù¸\í’7Z\âgg8ö\â¼7\Çz.£¨x\ÓR¸³µ{„&0D3œF \áG\ÌpA\íÚŒ¢š\Æ\â,\ÚJÿ\0ŠÆ§\Õh©6“n\Ç,²O3\Í4$²1gwbY‰\ä’OSL¢Šû\çÂŠ( Š( \r\rF½×µ8\ì,\"\ß+òI\áQ{³Àõ†I½\ÓÃ\Ò<9M5\ê¯\Ïw\"\å\É\ç%¸9#¶3µW\áŞ‰\áKyHSq|¢\æG\è\Ã\ä\\\à\Ç8%±Öº\Êöğ˜X\Â*r\İş\Í\ãñ²©7N.\Ñ_‰\Ëø«HY#\Ô\ì\Ã¢x^¸†J];\Æ6’B«~\Z€\Ã0RTûñÈ®³\î´M2ñ\Ë\Ïg9\ê\Ã*OÔŒVY–S†\Ì`£]j¶kF‡–\æ\Õğn“\Ñô{\ZŒm#…–À4\Ó…b¤(÷\ç“I\á]\"xMNğ0šPv\ëƒ\Écõ­‹]M³pğYÆ®:1\Ëô\'5¡F[”\á²\è8\ĞZ½\ÛÕ°Ì³jøù\'U\èº-w\Ä~\Ò<G­4\r\ë.\î5Ãƒ\Æ|pl\àµ\ázÎ{ \êrX_Å²T\äÊºöe=Áÿ\0\ëE}-\\Ÿ\ÄM=cÂ·|«qb­qŸ@2\ëœ‚£§…\Ík‹\Â\Æqs\ëñ*sT\ä\ïøEWˆ} QEõ5ò\Í\êiÿ\0wñÿ\0€x\Ø\ß\ßü?\àŸSQ_,\ÑGöŸ÷øııÿ\0\Ãş	õ5ò\Íiÿ\0wñÿ\0€\Ø\ß\ßü?\àŸSQ_,\ÑGöŸ÷øııÿ\0\ÃşQE\å\áÿ\Ù','2023-08-14 19:36:23'),(6,'CMP-WJ-508-10','Montrevil','Kensly','10/12/1999','M','Cap-Haitien','434-236-454-6','mk1311@gmail.com','(509) 3443-4332','Secretaire','8/13/2023',_binary 'ÿ\Øÿ\à\0JFIF\0\0`\0`\0\0ÿ\á\0ZExif\0\0MM\0*\0\0\0\0\0\0\0\0\0\0\0J\0\0\0\0\0\0\0\0Q\0\0\0\0\0\0\0Q\0\0\0\0\0\0\0\0Q\0\0\0\0\0\0\0\0\0\0\0\0\0† \0\0±ÿ\Û\0C\0		\n\r\Z\Z $.\' \",#(7),01444\'9=82<.342ÿ\Û\0C			\r\r2!!22222222222222222222222222222222222222222222222222ÿÀ\0\0`\0`\"\0ÿ\Ä\0\0\0\0\0\0\0\0\0\0\0	\nÿ\Ä\0µ\0\0\0}\0!1AQa\"q2‘¡#B±ÁR\Ñğ$3br‚	\n\Z%&\'()*456789:CDEFGHIJSTUVWXYZcdefghijstuvwxyzƒ„…†‡ˆ‰Š’“”•–—˜™š¢£¤¥¦§¨©ª²³´µ¶·¸¹º\Â\Ã\Ä\Å\Æ\Ç\È\É\Ê\Ò\Ó\Ô\Õ\Ö\×\Ø\Ù\Ú\á\â\ã\ä\å\æ\ç\è\é\êñòóôõö÷øùúÿ\Ä\0\0\0\0\0\0\0\0	\nÿ\Ä\0µ\0\0w\0!1AQaq\"2B‘¡±Á	#3Rğbr\Ñ\n$4\á%ñ\Z&\'()*56789:CDEFGHIJSTUVWXYZcdefghijstuvwxyz‚ƒ„…†‡ˆ‰Š’“”•–—˜™š¢£¤¥¦§¨©ª²³´µ¶·¸¹º\Â\Ã\Ä\Å\Æ\Ç\È\É\Ê\Ò\Ó\Ô\Õ\Ö\×\Ø\Ù\Ú\â\ã\ä\å\æ\ç\è\é\êòóôõö÷øùúÿ\Ú\0\0\0?\0ùşŠ( Š( Š\éôı\Ò9®[\Ív@\ŞYR¸>½³\Æ:õ\ë[JªŠ@U\0À >¢½DYch\Üe\\a\ê\rs7~·Á/FK.\ÜÃ“ô‹EPEPEPZº\rŸ\Úo¼\Ö»ƒy\êİ¿–\nÊ®‡\Âÿ\0òõÿ\0\0ÿ\0Ù¨¡©m\í§»”Eo“Hz,jXş•\éú€4›L5É’\îAıóµ!ıI®’\Ş\Ö\Ş\Ò/*\Ú\áŒj~•\ã\Ö\Î)\ÇJjÿ\0\è\Ó\Ë\æş7c\Ìtÿ\0\0\ê÷xk.\Ò3ÿ\0=\æü‡õ\"±u\ëE¾kk¥÷GuÇ¨¯n¬ıcGµ\Ö\ìZ\Ú\å}\ÒA÷úŠå£›\Ôö—©ğùT\Ë\á\É\în|\Í\âQ\rø•W0\ÏûÃ¯ô?dWC\âùuÿ\0ÿ\0\ìµ\ÏW\Ñ@QE\0QE\0W­ø;Áj>¶\Ô-—Q¸i÷·\ÊÁY”/·\İ\Î}I\ÏÇ’W}ğ\ÏÅš…‡ˆô\Íkö]*Y™<–@\Ã{©\nÁ +Ğ’I\êk\Z«{>j.\Í;ú¥}Œ3§\ÏjŠ\é\è{¾§{ı§Ow\å4¾R\çbõ<Ñ¦\Şÿ\0h\é\Ğ]ùMš¹\Ø\İG5nŠù;«ZÚş·*jw¿\Ù\Út÷~SK\å.v/S\Í\Zm\ïöß”\Ñy«\ÔsV\è¢\êÖ¶¡­\Ïñ‚-ô\ß\Ü\ênÍ¨Û´l¥\åPÌªW\ß\ïg> cŒ\ç\È\ë¾ø™\â\ÍBÿ\0\Äz‘ Í¥E2§’¨oE8€áº’2p5õ˜[\ÙóVwm\ß\Ñ;hx—O\ÔÕ’\Ğ(¢Š\ì9ÂŠ( Ÿ²A2M±°dtbH\äGCL¢€>ğ\',|M¦Aosr‘k¨X¤eV™€\å\Ğp8$€>^{`Î¾wğ&‹¨\éş4\Ón/-^\İ)\n\ã1°Só’;w¯r[‰a\\\ãßšøüŞœpX…4š¿\âÏ Ëª}f2i´\ìkW\ã¿XøgL\Ş\Ú\å%\Ö$SP\Æ\Ê\ÍÃ¸\ç\0dù¸\í’7Z\âgg8ö\â¼7\Çz.£¨x\ÓR¸³µ{„&0D3œF \áG\ÌpA\íÚŒ¢š\Æ\â,\ÚJÿ\0ŠÆ§\Õh©6“n\Ç,²O3\Í4$²1gwbY‰\ä’OSL¢Šû\çÂŠ( Š( \r\rF½×µ8\ì,\"\ß+òI\áQ{³Àõ†I½\ÓÃ\Ò<9M5\ê¯\Ïw\"\å\É\ç%¸9#¶3µW\áŞ‰\áKyHSq|¢\æG\è\Ã\ä\\\à\Ç8%±Öº\Êöğ˜X\Â*r\İş\Í\ãñ²©7N.\Ñ_‰\Ëø«HY#\Ô\ì\Ã¢x^¸†J];\Æ6’B«~\Z€\Ã0RTûñÈ®³\î´M2ñ\Ë\Ïg9\ê\Ã*OÔŒVY–S†\Ì`£]j¶kF‡–\æ\Õğn“\Ñô{\ZŒm#…–À4\Ó…b¤(÷\ç“I\á]\"xMNğ0šPv\ëƒ\Écõ­‹]M³pğYÆ®:1\Ëô\'5¡F[”\á²\è8\ĞZ½\ÛÕ°Ì³jøù\'U\èº-w\Ä~\Ò<G­4\r\ë.\î5Ãƒ\Æ|pl\àµ\ázÎ{ \êrX_Å²T\äÊºöe=Áÿ\0\ëE}-\\Ÿ\ÄM=cÂ·|«qb­qŸ@2\ëœ‚£§…\Ík‹\Â\Æqs\ëñ*sT\ä\ïøEWˆ} QEõ5ò\Í\êiÿ\0wñÿ\0€x\Ø\ß\ßü?\àŸSQ_,\ÑGöŸ÷øııÿ\0\Ãş	õ5ò\Íiÿ\0wñÿ\0€\Ø\ß\ßü?\àŸSQ_,\ÑGöŸ÷øııÿ\0\ÃşQE\å\áÿ\Ù','2023-08-14 20:09:36'),(7,'CMP-HC-579-11','Colad','Hans-Gregory','11/17/1999','M','Trou-du-Nord','332-541-184-7','colas@gmail.com','(509) 4900-4955','Vendeur','8/17/2023',_binary 'ÿ\Øÿ\à\0JFIF\0\0`\0`\0\0ÿ\á\0ZExif\0\0MM\0*\0\0\0\0\0\0\0\0\0\0\0J\0\0\0\0\0\0\0\0Q\0\0\0\0\0\0\0Q\0\0\0\0\0\0\0\0Q\0\0\0\0\0\0\0\0\0\0\0\0\0† \0\0±ÿ\Û\0C\0		\n\r\Z\Z $.\' \",#(7),01444\'9=82<.342ÿ\Û\0C			\r\r2!!22222222222222222222222222222222222222222222222222ÿÀ\0\0`\0`\"\0ÿ\Ä\0\0\0\0\0\0\0\0\0\0\0	\nÿ\Ä\0µ\0\0\0}\0!1AQa\"q2‘¡#B±ÁR\Ñğ$3br‚	\n\Z%&\'()*456789:CDEFGHIJSTUVWXYZcdefghijstuvwxyzƒ„…†‡ˆ‰Š’“”•–—˜™š¢£¤¥¦§¨©ª²³´µ¶·¸¹º\Â\Ã\Ä\Å\Æ\Ç\È\É\Ê\Ò\Ó\Ô\Õ\Ö\×\Ø\Ù\Ú\á\â\ã\ä\å\æ\ç\è\é\êñòóôõö÷øùúÿ\Ä\0\0\0\0\0\0\0\0	\nÿ\Ä\0µ\0\0w\0!1AQaq\"2B‘¡±Á	#3Rğbr\Ñ\n$4\á%ñ\Z&\'()*56789:CDEFGHIJSTUVWXYZcdefghijstuvwxyz‚ƒ„…†‡ˆ‰Š’“”•–—˜™š¢£¤¥¦§¨©ª²³´µ¶·¸¹º\Â\Ã\Ä\Å\Æ\Ç\È\É\Ê\Ò\Ó\Ô\Õ\Ö\×\Ø\Ù\Ú\â\ã\ä\å\æ\ç\è\é\êòóôõö÷øùúÿ\Ú\0\0\0?\0ùşŠ( Š( Š\éôı\Ò9®[\Ív@\ŞYR¸>½³\Æ:õ\ë[JªŠ@U\0À >¢½DYch\Üe\\a\ê\rs7~·Á/FK.\ÜÃ“ô‹EPEPEPZº\rŸ\Úo¼\Ö»ƒy\êİ¿–\nÊ®‡\Âÿ\0òõÿ\0\0ÿ\0Ù¨¡©m\í§»”Eo“Hz,jXş•\éú€4›L5É’\îAıóµ!ıI®’\Ş\Ö\Ş\Ò/*\Ú\áŒj~•\ã\Ö\Î)\ÇJjÿ\0\è\Ó\Ë\æş7c\Ìtÿ\0\0\ê÷xk.\Ò3ÿ\0=\æü‡õ\"±u\ëE¾kk¥÷GuÇ¨¯n¬ıcGµ\Ö\ìZ\Ú\å}\ÒA÷úŠå£›\Ôö—©ğùT\Ë\á\É\în|\Í\âQ\rø•W0\ÏûÃ¯ô?dWC\âùuÿ\0ÿ\0\ìµ\ÏW\Ñ@QE\0QE\0W­ø;Áj>¶\Ô-—Q¸i÷·\ÊÁY”/·\İ\Î}I\ÏÇ’W}ğ\ÏÅš…‡ˆô\Íkö]*Y™<–@\Ã{©\nÁ +Ğ’I\êk\Z«{>j.\Í;ú¥}Œ3§\ÏjŠ\é\è{¾§{ı§Ow\å4¾R\çbõ<Ñ¦\Şÿ\0h\é\Ğ]ùMš¹\Ø\İG5nŠù;«ZÚş·*jw¿\Ù\Út÷~SK\å.v/S\Í\Zm\ïöß”\Ñy«\ÔsV\è¢\êÖ¶¡­\Ïñ‚-ô\ß\Ü\ênÍ¨Û´l¥\åPÌªW\ß\ïg> cŒ\ç\È\ë¾ø™\â\ÍBÿ\0\Äz‘ Í¥E2§’¨oE8€áº’2p5õ˜[\ÙóVwm\ß\Ñ;hx—O\ÔÕ’\Ğ(¢Š\ì9ÂŠ( Ÿ²A2M±°dtbH\äGCL¢€>ğ\',|M¦Aosr‘k¨X¤eV™€\å\Ğp8$€>^{`Î¾wğ&‹¨\éş4\Ón/-^\İ)\n\ã1°Só’;w¯r[‰a\\\ãßšøüŞœpX…4š¿\âÏ Ëª}f2i´\ìkW\ã¿XøgL\Ş\Ú\å%\Ö$SP\Æ\Ê\ÍÃ¸\ç\0dù¸\í’7Z\âgg8ö\â¼7\Çz.£¨x\ÓR¸³µ{„&0D3œF \áG\ÌpA\íÚŒ¢š\Æ\â,\ÚJÿ\0ŠÆ§\Õh©6“n\Ç,²O3\Í4$²1gwbY‰\ä’OSL¢Šû\çÂŠ( Š( \r\rF½×µ8\ì,\"\ß+òI\áQ{³Àõ†I½\ÓÃ\Ò<9M5\ê¯\Ïw\"\å\É\ç%¸9#¶3µW\áŞ‰\áKyHSq|¢\æG\è\Ã\ä\\\à\Ç8%±Öº\Êöğ˜X\Â*r\İş\Í\ãñ²©7N.\Ñ_‰\Ëø«HY#\Ô\ì\Ã¢x^¸†J];\Æ6’B«~\Z€\Ã0RTûñÈ®³\î´M2ñ\Ë\Ïg9\ê\Ã*OÔŒVY–S†\Ì`£]j¶kF‡–\æ\Õğn“\Ñô{\ZŒm#…–À4\Ó…b¤(÷\ç“I\á]\"xMNğ0šPv\ëƒ\Écõ­‹]M³pğYÆ®:1\Ëô\'5¡F[”\á²\è8\ĞZ½\ÛÕ°Ì³jøù\'U\èº-w\Ä~\Ò<G­4\r\ë.\î5Ãƒ\Æ|pl\àµ\ázÎ{ \êrX_Å²T\äÊºöe=Áÿ\0\ëE}-\\Ÿ\ÄM=cÂ·|«qb­qŸ@2\ëœ‚£§…\Ík‹\Â\Æqs\ëñ*sT\ä\ïøEWˆ} QEõ5ò\Í\êiÿ\0wñÿ\0€x\Ø\ß\ßü?\àŸSQ_,\ÑGöŸ÷øııÿ\0\Ãş	õ5ò\Íiÿ\0wñÿ\0€\Ø\ß\ßü?\àŸSQ_,\ÑGöŸ÷øııÿ\0\ÃşQE\å\áÿ\Ù','2023-08-18 19:53:55'),(8,'CMP-WP-949-12','Prophete','Wislin Herntz','9/23/1998','M','La Fossette','232-614-949-1','wislinherntz20@gmail.com','(509) 4444-1410','Administrateur','8/18/2023',_binary 'ÿ\Øÿ\à\0JFIF\0\0`\0`\0\0ÿ\á\0ZExif\0\0MM\0*\0\0\0\0\0\0\0\0\0\0\0J\0\0\0\0\0\0\0\0Q\0\0\0\0\0\0\0Q\0\0\0\0\0\0\0\0Q\0\0\0\0\0\0\0\0\0\0\0\0\0† \0\0±ÿ\Û\0C\0		\n\r\Z\Z $.\' \",#(7),01444\'9=82<.342ÿ\Û\0C			\r\r2!!22222222222222222222222222222222222222222222222222ÿÀ\0\0`\0`\"\0ÿ\Ä\0\0\0\0\0\0\0\0\0\0\0	\nÿ\Ä\0µ\0\0\0}\0!1AQa\"q2‘¡#B±ÁR\Ñğ$3br‚	\n\Z%&\'()*456789:CDEFGHIJSTUVWXYZcdefghijstuvwxyzƒ„…†‡ˆ‰Š’“”•–—˜™š¢£¤¥¦§¨©ª²³´µ¶·¸¹º\Â\Ã\Ä\Å\Æ\Ç\È\É\Ê\Ò\Ó\Ô\Õ\Ö\×\Ø\Ù\Ú\á\â\ã\ä\å\æ\ç\è\é\êñòóôõö÷øùúÿ\Ä\0\0\0\0\0\0\0\0	\nÿ\Ä\0µ\0\0w\0!1AQaq\"2B‘¡±Á	#3Rğbr\Ñ\n$4\á%ñ\Z&\'()*56789:CDEFGHIJSTUVWXYZcdefghijstuvwxyz‚ƒ„…†‡ˆ‰Š’“”•–—˜™š¢£¤¥¦§¨©ª²³´µ¶·¸¹º\Â\Ã\Ä\Å\Æ\Ç\È\É\Ê\Ò\Ó\Ô\Õ\Ö\×\Ø\Ù\Ú\â\ã\ä\å\æ\ç\è\é\êòóôõö÷øùúÿ\Ú\0\0\0?\0ùşŠ( Š( Š\éôı\Ò9®[\Ív@\ŞYR¸>½³\Æ:õ\ë[JªŠ@U\0À >¢½DYch\Üe\\a\ê\rs7~·Á/FK.\ÜÃ“ô‹EPEPEPZº\rŸ\Úo¼\Ö»ƒy\êİ¿–\nÊ®‡\Âÿ\0òõÿ\0\0ÿ\0Ù¨¡©m\í§»”Eo“Hz,jXş•\éú€4›L5É’\îAıóµ!ıI®’\Ş\Ö\Ş\Ò/*\Ú\áŒj~•\ã\Ö\Î)\ÇJjÿ\0\è\Ó\Ë\æş7c\Ìtÿ\0\0\ê÷xk.\Ò3ÿ\0=\æü‡õ\"±u\ëE¾kk¥÷GuÇ¨¯n¬ıcGµ\Ö\ìZ\Ú\å}\ÒA÷úŠå£›\Ôö—©ğùT\Ë\á\É\în|\Í\âQ\rø•W0\ÏûÃ¯ô?dWC\âùuÿ\0ÿ\0\ìµ\ÏW\Ñ@QE\0QE\0W­ø;Áj>¶\Ô-—Q¸i÷·\ÊÁY”/·\İ\Î}I\ÏÇ’W}ğ\ÏÅš…‡ˆô\Íkö]*Y™<–@\Ã{©\nÁ +Ğ’I\êk\Z«{>j.\Í;ú¥}Œ3§\ÏjŠ\é\è{¾§{ı§Ow\å4¾R\çbõ<Ñ¦\Şÿ\0h\é\Ğ]ùMš¹\Ø\İG5nŠù;«ZÚş·*jw¿\Ù\Út÷~SK\å.v/S\Í\Zm\ïöß”\Ñy«\ÔsV\è¢\êÖ¶¡­\Ïñ‚-ô\ß\Ü\ênÍ¨Û´l¥\åPÌªW\ß\ïg> cŒ\ç\È\ë¾ø™\â\ÍBÿ\0\Äz‘ Í¥E2§’¨oE8€áº’2p5õ˜[\ÙóVwm\ß\Ñ;hx—O\ÔÕ’\Ğ(¢Š\ì9ÂŠ( Ÿ²A2M±°dtbH\äGCL¢€>ğ\',|M¦Aosr‘k¨X¤eV™€\å\Ğp8$€>^{`Î¾wğ&‹¨\éş4\Ón/-^\İ)\n\ã1°Só’;w¯r[‰a\\\ãßšøüŞœpX…4š¿\âÏ Ëª}f2i´\ìkW\ã¿XøgL\Ş\Ú\å%\Ö$SP\Æ\Ê\ÍÃ¸\ç\0dù¸\í’7Z\âgg8ö\â¼7\Çz.£¨x\ÓR¸³µ{„&0D3œF \áG\ÌpA\íÚŒ¢š\Æ\â,\ÚJÿ\0ŠÆ§\Õh©6“n\Ç,²O3\Í4$²1gwbY‰\ä’OSL¢Šû\çÂŠ( Š( \r\rF½×µ8\ì,\"\ß+òI\áQ{³Àõ†I½\ÓÃ\Ò<9M5\ê¯\Ïw\"\å\É\ç%¸9#¶3µW\áŞ‰\áKyHSq|¢\æG\è\Ã\ä\\\à\Ç8%±Öº\Êöğ˜X\Â*r\İş\Í\ãñ²©7N.\Ñ_‰\Ëø«HY#\Ô\ì\Ã¢x^¸†J];\Æ6’B«~\Z€\Ã0RTûñÈ®³\î´M2ñ\Ë\Ïg9\ê\Ã*OÔŒVY–S†\Ì`£]j¶kF‡–\æ\Õğn“\Ñô{\ZŒm#…–À4\Ó…b¤(÷\ç“I\á]\"xMNğ0šPv\ëƒ\Écõ­‹]M³pğYÆ®:1\Ëô\'5¡F[”\á²\è8\ĞZ½\ÛÕ°Ì³jøù\'U\èº-w\Ä~\Ò<G­4\r\ë.\î5Ãƒ\Æ|pl\àµ\ázÎ{ \êrX_Å²T\äÊºöe=Áÿ\0\ëE}-\\Ÿ\ÄM=cÂ·|«qb­qŸ@2\ëœ‚£§…\Ík‹\Â\Æqs\ëñ*sT\ä\ïøEWˆ} QEõ5ò\Í\êiÿ\0wñÿ\0€x\Ø\ß\ßü?\àŸSQ_,\ÑGöŸ÷øııÿ\0\Ãş	õ5ò\Íiÿ\0wñÿ\0€\Ø\ß\ßü?\àŸSQ_,\ÑGöŸ÷øııÿ\0\ÃşQE\å\áÿ\Ù','2023-08-18 19:55:06'),(11,'CMP-MJ-957-13','Jean','Mark','2/1/2000','M','Milot','378-464-837-2','mark@gmail.com','(509) 4324-3232','Livreur','9/11/2023',_binary 'ÿ\Øÿ\à\0JFIF\0\0`\0`\0\0ÿ\á\0ZExif\0\0MM\0*\0\0\0\0\0\0\0\0\0\0\0J\0\0\0\0\0\0\0\0Q\0\0\0\0\0\0\0Q\0\0\0\0\0\0\0\0Q\0\0\0\0\0\0\0\0\0\0\0\0\0† \0\0±ÿ\Û\0C\0		\n\r\Z\Z $.\' \",#(7),01444\'9=82<.342ÿ\Û\0C			\r\r2!!22222222222222222222222222222222222222222222222222ÿÀ\0\0`\0`\"\0ÿ\Ä\0\0\0\0\0\0\0\0\0\0\0	\nÿ\Ä\0µ\0\0\0}\0!1AQa\"q2‘¡#B±ÁR\Ñğ$3br‚	\n\Z%&\'()*456789:CDEFGHIJSTUVWXYZcdefghijstuvwxyzƒ„…†‡ˆ‰Š’“”•–—˜™š¢£¤¥¦§¨©ª²³´µ¶·¸¹º\Â\Ã\Ä\Å\Æ\Ç\È\É\Ê\Ò\Ó\Ô\Õ\Ö\×\Ø\Ù\Ú\á\â\ã\ä\å\æ\ç\è\é\êñòóôõö÷øùúÿ\Ä\0\0\0\0\0\0\0\0	\nÿ\Ä\0µ\0\0w\0!1AQaq\"2B‘¡±Á	#3Rğbr\Ñ\n$4\á%ñ\Z&\'()*56789:CDEFGHIJSTUVWXYZcdefghijstuvwxyz‚ƒ„…†‡ˆ‰Š’“”•–—˜™š¢£¤¥¦§¨©ª²³´µ¶·¸¹º\Â\Ã\Ä\Å\Æ\Ç\È\É\Ê\Ò\Ó\Ô\Õ\Ö\×\Ø\Ù\Ú\â\ã\ä\å\æ\ç\è\é\êòóôõö÷øùúÿ\Ú\0\0\0?\0ùşŠ( Š( Š\éôı\Ò9®[\Ív@\ŞYR¸>½³\Æ:õ\ë[JªŠ@U\0À >¢½DYch\Üe\\a\ê\rs7~·Á/FK.\ÜÃ“ô‹EPEPEPZº\rŸ\Úo¼\Ö»ƒy\êİ¿–\nÊ®‡\Âÿ\0òõÿ\0\0ÿ\0Ù¨¡©m\í§»”Eo“Hz,jXş•\éú€4›L5É’\îAıóµ!ıI®’\Ş\Ö\Ş\Ò/*\Ú\áŒj~•\ã\Ö\Î)\ÇJjÿ\0\è\Ó\Ë\æş7c\Ìtÿ\0\0\ê÷xk.\Ò3ÿ\0=\æü‡õ\"±u\ëE¾kk¥÷GuÇ¨¯n¬ıcGµ\Ö\ìZ\Ú\å}\ÒA÷úŠå£›\Ôö—©ğùT\Ë\á\É\în|\Í\âQ\rø•W0\ÏûÃ¯ô?dWC\âùuÿ\0ÿ\0\ìµ\ÏW\Ñ@QE\0QE\0W­ø;Áj>¶\Ô-—Q¸i÷·\ÊÁY”/·\İ\Î}I\ÏÇ’W}ğ\ÏÅš…‡ˆô\Íkö]*Y™<–@\Ã{©\nÁ +Ğ’I\êk\Z«{>j.\Í;ú¥}Œ3§\ÏjŠ\é\è{¾§{ı§Ow\å4¾R\çbõ<Ñ¦\Şÿ\0h\é\Ğ]ùMš¹\Ø\İG5nŠù;«ZÚş·*jw¿\Ù\Út÷~SK\å.v/S\Í\Zm\ïöß”\Ñy«\ÔsV\è¢\êÖ¶¡­\Ïñ‚-ô\ß\Ü\ênÍ¨Û´l¥\åPÌªW\ß\ïg> cŒ\ç\È\ë¾ø™\â\ÍBÿ\0\Äz‘ Í¥E2§’¨oE8€áº’2p5õ˜[\ÙóVwm\ß\Ñ;hx—O\ÔÕ’\Ğ(¢Š\ì9ÂŠ( Ÿ²A2M±°dtbH\äGCL¢€>ğ\',|M¦Aosr‘k¨X¤eV™€\å\Ğp8$€>^{`Î¾wğ&‹¨\éş4\Ón/-^\İ)\n\ã1°Só’;w¯r[‰a\\\ãßšøüŞœpX…4š¿\âÏ Ëª}f2i´\ìkW\ã¿XøgL\Ş\Ú\å%\Ö$SP\Æ\Ê\ÍÃ¸\ç\0dù¸\í’7Z\âgg8ö\â¼7\Çz.£¨x\ÓR¸³µ{„&0D3œF \áG\ÌpA\íÚŒ¢š\Æ\â,\ÚJÿ\0ŠÆ§\Õh©6“n\Ç,²O3\Í4$²1gwbY‰\ä’OSL¢Šû\çÂŠ( Š( \r\rF½×µ8\ì,\"\ß+òI\áQ{³Àõ†I½\ÓÃ\Ò<9M5\ê¯\Ïw\"\å\É\ç%¸9#¶3µW\áŞ‰\áKyHSq|¢\æG\è\Ã\ä\\\à\Ç8%±Öº\Êöğ˜X\Â*r\İş\Í\ãñ²©7N.\Ñ_‰\Ëø«HY#\Ô\ì\Ã¢x^¸†J];\Æ6’B«~\Z€\Ã0RTûñÈ®³\î´M2ñ\Ë\Ïg9\ê\Ã*OÔŒVY–S†\Ì`£]j¶kF‡–\æ\Õğn“\Ñô{\ZŒm#…–À4\Ó…b¤(÷\ç“I\á]\"xMNğ0šPv\ëƒ\Écõ­‹]M³pğYÆ®:1\Ëô\'5¡F[”\á²\è8\ĞZ½\ÛÕ°Ì³jøù\'U\èº-w\Ä~\Ò<G­4\r\ë.\î5Ãƒ\Æ|pl\àµ\ázÎ{ \êrX_Å²T\äÊºöe=Áÿ\0\ëE}-\\Ÿ\ÄM=cÂ·|«qb­qŸ@2\ëœ‚£§…\Ík‹\Â\Æqs\ëñ*sT\ä\ïøEWˆ} QEõ5ò\Í\êiÿ\0wñÿ\0€x\Ø\ß\ßü?\àŸSQ_,\ÑGöŸ÷øııÿ\0\Ãş	õ5ò\Íiÿ\0wñÿ\0€\Ø\ß\ßü?\àŸSQ_,\ÑGöŸ÷øııÿ\0\ÃşQE\å\áÿ\Ù','2023-09-11 16:06:42'),(12,'CMP-NS-145-14','Saint-Fort','Norah','2/1/2000','F','Rue 24K','111-112-256-6','norah34@gmail.com','(509) 4752-3311','Comptable','9/3/2023',_binary 'ÿ\Øÿ\à\0JFIF\0\0`\0`\0\0ÿ\á\0ZExif\0\0MM\0*\0\0\0\0\0\0\0\0\0\0\0J\0\0\0\0\0\0\0\0Q\0\0\0\0\0\0\0Q\0\0\0\0\0\0\0\0Q\0\0\0\0\0\0\0\0\0\0\0\0\0† \0\0±ÿ\Û\0C\0		\n\r\Z\Z $.\' \",#(7),01444\'9=82<.342ÿ\Û\0C			\r\r2!!22222222222222222222222222222222222222222222222222ÿÀ\0\0`\0`\"\0ÿ\Ä\0\0\0\0\0\0\0\0\0\0\0	\nÿ\Ä\0µ\0\0\0}\0!1AQa\"q2‘¡#B±ÁR\Ñğ$3br‚	\n\Z%&\'()*456789:CDEFGHIJSTUVWXYZcdefghijstuvwxyzƒ„…†‡ˆ‰Š’“”•–—˜™š¢£¤¥¦§¨©ª²³´µ¶·¸¹º\Â\Ã\Ä\Å\Æ\Ç\È\É\Ê\Ò\Ó\Ô\Õ\Ö\×\Ø\Ù\Ú\á\â\ã\ä\å\æ\ç\è\é\êñòóôõö÷øùúÿ\Ä\0\0\0\0\0\0\0\0	\nÿ\Ä\0µ\0\0w\0!1AQaq\"2B‘¡±Á	#3Rğbr\Ñ\n$4\á%ñ\Z&\'()*56789:CDEFGHIJSTUVWXYZcdefghijstuvwxyz‚ƒ„…†‡ˆ‰Š’“”•–—˜™š¢£¤¥¦§¨©ª²³´µ¶·¸¹º\Â\Ã\Ä\Å\Æ\Ç\È\É\Ê\Ò\Ó\Ô\Õ\Ö\×\Ø\Ù\Ú\â\ã\ä\å\æ\ç\è\é\êòóôõö÷øùúÿ\Ú\0\0\0?\0ùşŠ( Š( Š\éôı\Ò9®[\Ív@\ŞYR¸>½³\Æ:õ\ë[JªŠ@U\0À >¢½DYch\Üe\\a\ê\rs7~·Á/FK.\ÜÃ“ô‹EPEPEPZº\rŸ\Úo¼\Ö»ƒy\êİ¿–\nÊ®‡\Âÿ\0òõÿ\0\0ÿ\0Ù¨¡©m\í§»”Eo“Hz,jXş•\éú€4›L5É’\îAıóµ!ıI®’\Ş\Ö\Ş\Ò/*\Ú\áŒj~•\ã\Ö\Î)\ÇJjÿ\0\è\Ó\Ë\æş7c\Ìtÿ\0\0\ê÷xk.\Ò3ÿ\0=\æü‡õ\"±u\ëE¾kk¥÷GuÇ¨¯n¬ıcGµ\Ö\ìZ\Ú\å}\ÒA÷úŠå£›\Ôö—©ğùT\Ë\á\É\în|\Í\âQ\rø•W0\ÏûÃ¯ô?dWC\âùuÿ\0ÿ\0\ìµ\ÏW\Ñ@QE\0QE\0W­ø;Áj>¶\Ô-—Q¸i÷·\ÊÁY”/·\İ\Î}I\ÏÇ’W}ğ\ÏÅš…‡ˆô\Íkö]*Y™<–@\Ã{©\nÁ +Ğ’I\êk\Z«{>j.\Í;ú¥}Œ3§\ÏjŠ\é\è{¾§{ı§Ow\å4¾R\çbõ<Ñ¦\Şÿ\0h\é\Ğ]ùMš¹\Ø\İG5nŠù;«ZÚş·*jw¿\Ù\Út÷~SK\å.v/S\Í\Zm\ïöß”\Ñy«\ÔsV\è¢\êÖ¶¡­\Ïñ‚-ô\ß\Ü\ênÍ¨Û´l¥\åPÌªW\ß\ïg> cŒ\ç\È\ë¾ø™\â\ÍBÿ\0\Äz‘ Í¥E2§’¨oE8€áº’2p5õ˜[\ÙóVwm\ß\Ñ;hx—O\ÔÕ’\Ğ(¢Š\ì9ÂŠ( Ÿ²A2M±°dtbH\äGCL¢€>ğ\',|M¦Aosr‘k¨X¤eV™€\å\Ğp8$€>^{`Î¾wğ&‹¨\éş4\Ón/-^\İ)\n\ã1°Só’;w¯r[‰a\\\ãßšøüŞœpX…4š¿\âÏ Ëª}f2i´\ìkW\ã¿XøgL\Ş\Ú\å%\Ö$SP\Æ\Ê\ÍÃ¸\ç\0dù¸\í’7Z\âgg8ö\â¼7\Çz.£¨x\ÓR¸³µ{„&0D3œF \áG\ÌpA\íÚŒ¢š\Æ\â,\ÚJÿ\0ŠÆ§\Õh©6“n\Ç,²O3\Í4$²1gwbY‰\ä’OSL¢Šû\çÂŠ( Š( \r\rF½×µ8\ì,\"\ß+òI\áQ{³Àõ†I½\ÓÃ\Ò<9M5\ê¯\Ïw\"\å\É\ç%¸9#¶3µW\áŞ‰\áKyHSq|¢\æG\è\Ã\ä\\\à\Ç8%±Öº\Êöğ˜X\Â*r\İş\Í\ãñ²©7N.\Ñ_‰\Ëø«HY#\Ô\ì\Ã¢x^¸†J];\Æ6’B«~\Z€\Ã0RTûñÈ®³\î´M2ñ\Ë\Ïg9\ê\Ã*OÔŒVY–S†\Ì`£]j¶kF‡–\æ\Õğn“\Ñô{\ZŒm#…–À4\Ó…b¤(÷\ç“I\á]\"xMNğ0šPv\ëƒ\Écõ­‹]M³pğYÆ®:1\Ëô\'5¡F[”\á²\è8\ĞZ½\ÛÕ°Ì³jøù\'U\èº-w\Ä~\Ò<G­4\r\ë.\î5Ãƒ\Æ|pl\àµ\ázÎ{ \êrX_Å²T\äÊºöe=Áÿ\0\ëE}-\\Ÿ\ÄM=cÂ·|«qb­qŸ@2\ëœ‚£§…\Ík‹\Â\Æqs\ëñ*sT\ä\ïøEWˆ} QEõ5ò\Í\êiÿ\0wñÿ\0€x\Ø\ß\ßü?\àŸSQ_,\ÑGöŸ÷øııÿ\0\Ãş	õ5ò\Íiÿ\0wñÿ\0€\Ø\ß\ßü?\àŸSQ_,\ÑGöŸ÷øııÿ\0\ÃşQE\å\áÿ\Ù','2023-09-11 17:37:49');
/*!40000 ALTER TABLE `employe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sales`
--

DROP TABLE IF EXISTS `sales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sales` (
  `id` int NOT NULL AUTO_INCREMENT,
  `code` varchar(145) NOT NULL,
  `client` varchar(145) NOT NULL,
  `produit` int NOT NULL,
  `quantite` int DEFAULT NULL,
  `montant` double DEFAULT NULL,
  `date_save` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `fk_produit_idx` (`produit`),
  CONSTRAINT `fk_produit` FOREIGN KEY (`produit`) REFERENCES `supply` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=47 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sales`
--

LOCK TABLES `sales` WRITE;
/*!40000 ALTER TABLE `sales` DISABLE KEYS */;
INSERT INTO `sales` VALUES (39,'OR-3-16','Jean Willy',5,2,2000,'2023-08-25 14:26:15'),(40,'OR-3-16','Jean Willy',3,2,40,'2023-08-25 14:26:15'),(41,'OR-3-16','Jean Willy',2,1,600,'2023-08-25 14:26:15'),(42,'OR-3-16','Jean Willy',4,1,500,'2023-08-25 14:26:15'),(43,'OR-35-17','Majis',3,2,40,'2023-09-08 20:01:32'),(44,'OR-35-17','Majis',2,6,3600,'2023-09-08 20:01:32');
/*!40000 ALTER TABLE `sales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sales_code_auto`
--

DROP TABLE IF EXISTS `sales_code_auto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sales_code_auto` (
  `id` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sales_code_auto`
--

LOCK TABLES `sales_code_auto` WRITE;
/*!40000 ALTER TABLE `sales_code_auto` DISABLE KEYS */;
INSERT INTO `sales_code_auto` VALUES (19);
/*!40000 ALTER TABLE `sales_code_auto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supply`
--

DROP TABLE IF EXISTS `supply`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `supply` (
  `id` int NOT NULL AUTO_INCREMENT,
  `code` varchar(45) DEFAULT NULL,
  `categorie` int NOT NULL,
  `product_name` varchar(145) NOT NULL,
  `marque` varchar(145) NOT NULL,
  `model` varchar(145) NOT NULL,
  `quantite` int NOT NULL,
  `prix` double NOT NULL,
  `mesure` varchar(145) NOT NULL,
  `fournisseur` varchar(145) NOT NULL,
  `date_reception` varchar(145) NOT NULL,
  `date_save` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE KEY `code_UNIQUE` (`code`),
  KEY `fk_categ_idx` (`categorie`),
  CONSTRAINT `fk_categ` FOREIGN KEY (`categorie`) REFERENCES `categorie` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supply`
--

LOCK TABLES `supply` WRITE;
/*!40000 ALTER TABLE `supply` DISABLE KEYS */;
INSERT INTO `supply` VALUES (1,'OR-86-1',3,'Laptop','Dell','Intel Inside',0,700,'UnitÃ©','ALIBABA','8/8/2023','2023-08-17 13:50:58'),(2,'OR-88-2',3,'Boitier','Acer','AMD',258,600,'UnitÃ©','Amazon','8/8/2023','2023-08-17 16:31:10'),(3,'MA-33-3',4,'Souris','Logitech','Sans fil',340,20,'UnitÃ©','Alibaba','9/8/2023','2023-08-17 16:31:10'),(4,'OR-91-4',3,'Laptop','Samsung','Intel Core i3',203,500,'UnitÃ©','Alibaba','8/15/2023','2023-08-17 18:20:04'),(5,'EL-50-6',5,'Kit Energetique','Ti SolÃ¨y','Fireon',46,1000,'Ensemble','TI SOLEY SA','8/14/2023','2023-08-17 19:04:52'),(6,'AC-32-7',6,'Ram','Intel','DDR3 4Go',200,1500,'UnitÃ©','Amazon','8/11/2023','2023-09-11 16:49:13'),(7,'AC-1-8',6,'CPU','AMD','Core i7',105,8000,'PiÃ¨ce','ALIBABA','9/10/2023','2023-09-11 17:20:52'),(9,'AC-62-11',6,'CPU','INTEL','core i3',100,900,'UnitÃ©','ALIBABA','8/16/2023','2023-09-11 17:23:15');
/*!40000 ALTER TABLE `supply` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supply_code_auto`
--

DROP TABLE IF EXISTS `supply_code_auto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `supply_code_auto` (
  `id` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supply_code_auto`
--

LOCK TABLES `supply_code_auto` WRITE;
/*!40000 ALTER TABLE `supply_code_auto` DISABLE KEYS */;
INSERT INTO `supply_code_auto` VALUES (12);
/*!40000 ALTER TABLE `supply_code_auto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblcodeemp`
--

DROP TABLE IF EXISTS `tblcodeemp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblcodeemp` (
  `id` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblcodeemp`
--

LOCK TABLES `tblcodeemp` WRITE;
/*!40000 ALTER TABLE `tblcodeemp` DISABLE KEYS */;
INSERT INTO `tblcodeemp` VALUES (16);
/*!40000 ALTER TABLE `tblcodeemp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbltransaction`
--

DROP TABLE IF EXISTS `tbltransaction`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbltransaction` (
  `id` int NOT NULL AUTO_INCREMENT,
  `code` varchar(45) DEFAULT NULL,
  `libelle` varchar(45) DEFAULT NULL,
  `heure_transaction` varchar(45) DEFAULT NULL,
  `date_transaction` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=70 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbltransaction`
--

LOCK TABLES `tbltransaction` WRITE;
/*!40000 ALTER TABLE `tbltransaction` DISABLE KEYS */;
INSERT INTO `tbltransaction` VALUES (8,'CMP-WP-949-12','Herntz connecter ','16 Hres','8/18/2023 4:07:04 PM'),(9,'CMP-WP-949-12','Herntz Deconnecter ','16 Hres','8/18/2023 4:07:50 PM'),(10,'CMP-HC-579-11','Colas connecter ','16 Hres','8/18/2023 4:07:50 PM'),(11,'CMP-WP-949-12','Herntz connecter ','16 Hres','8/18/2023 4:31:29 PM'),(12,'CMP-WP-949-12','Herntz connecter ','10 Hres','8/25/2023 10:21:38 AM'),(13,'CMP-WP-949-12','Herntz Deconnecter ','10 Hres','8/25/2023 10:27:24 AM'),(14,'CMP-WJ-508-10','MK connecter ','16 Hres','8/25/2023 4:47:45 PM'),(15,'CMP-WJ-508-10','MK Deconnecter ','16 Hres','8/25/2023 4:50:22 PM'),(16,'CMP-WP-949-12','Herntz connecter ','15 Hres','9/8/2023 3:03:59 PM'),(17,'CMP-WP-949-12','Herntz connecter ','15 Hres','9/8/2023 3:20:18 PM'),(18,'CMP-WP-949-12','Herntz connecter ','15 Hres','9/8/2023 3:22:10 PM'),(19,'CMP-WP-949-12','Herntz connecter ','15 Hres','9/8/2023 3:23:50 PM'),(20,'CMP-WP-949-12','Herntz connecter ','15 Hres','9/8/2023 3:29:24 PM'),(21,'CMP-WP-949-12','Herntz connecter ','15 Hres','9/8/2023 3:33:15 PM'),(22,'CMP-WP-949-12','Herntz Deconnecter ','15 Hres','9/8/2023 3:34:03 PM'),(23,'CMP-WP-949-12','Herntz connecter ','16 Hres','9/8/2023 4:00:12 PM'),(24,'CMP-WP-949-12','Herntz connecter ','12 Hres','9/9/2023 12:32:12 PM'),(25,'CMP-WJ-508-10','MK connecter ','12 Hres','9/9/2023 12:37:18 PM'),(26,'CMP-WP-949-12','Herntz connecter ','12 Hres','9/9/2023 12:58:24 PM'),(27,'CMP-WP-949-12','Herntz connecter ','13 Hres','9/9/2023 1:00:24 PM'),(28,'CMP-WP-949-12','Herntz connecter ','13 Hres','9/9/2023 1:11:29 PM'),(29,'CMP-WP-949-12','Herntz connecter ','13 Hres','9/9/2023 1:12:42 PM'),(30,'CMP-WP-949-12','Herntz connecter ','13 Hres','9/9/2023 1:24:21 PM'),(31,'CMP-WP-949-12','Herntz connecter ','13 Hres','9/9/2023 1:26:38 PM'),(32,'CMP-WP-949-12','Herntz connecter ','13 Hres','9/9/2023 1:37:17 PM'),(33,'CMP-WP-949-12','Herntz connecter ','13 Hres','9/9/2023 1:41:30 PM'),(34,'CMP-DA-449-5','Melanie connecter ','13 Hres','9/9/2023 1:42:38 PM'),(35,'CMP-HC-579-11','Colas connecter ','13 Hres','9/9/2023 1:45:09 PM'),(36,'CMP-WJ-508-10','MK connecter ','13 Hres','9/9/2023 1:47:33 PM'),(37,'CMP-WJ-508-10','MK Deconnecter ','13 Hres','9/9/2023 1:48:40 PM'),(38,'CMP-WP-949-12','Herntz connecter ','13 Hres','9/9/2023 1:51:49 PM'),(39,'CMP-WJ-508-10','MK connecter ','13 Hres','9/9/2023 1:59:49 PM'),(40,'CMP-HC-579-11','Colas connecter ','14 Hres','9/9/2023 2:03:51 PM'),(41,'CMP-HC-579-11','Colas Deconnecter ','14 Hres','9/9/2023 2:04:27 PM'),(42,'CMP-DA-449-5','Melanie connecter ','14 Hres','9/9/2023 2:04:28 PM'),(43,'CMP-WJ-508-10','MK connecter ','14 Hres','9/9/2023 2:07:03 PM'),(44,'CMP-WJ-508-10','MK Deconnecter ','14 Hres','9/9/2023 2:09:21 PM'),(45,'CMP-WP-949-12','Herntz connecter ','14 Hres','9/9/2023 2:10:08 PM'),(46,'CMP-WP-949-12','Herntz connecter ','11 Hres','9/11/2023 11:37:23 AM'),(47,'CMP-WP-949-12','Herntz connecter ','11 Hres','9/11/2023 11:55:10 AM'),(48,'CMP-WP-949-12','Herntz Deconnecter ','11 Hres','9/11/2023 11:56:25 AM'),(49,'CMP-WP-949-12','Herntz connecter ','11 Hres','9/11/2023 11:57:30 AM'),(50,'CMP-WJ-508-10','MK connecter ','12 Hres','9/11/2023 12:04:54 PM'),(51,'CMP-WJ-508-10','MK connecter ','12 Hres','9/11/2023 12:36:30 PM'),(52,'CMP-HC-579-11','Colas connecter ','12 Hres','9/11/2023 12:37:15 PM'),(53,'CMP-WJ-508-10','MK connecter ','12 Hres','9/11/2023 12:42:59 PM'),(54,'CMP-WJ-508-10','MK connecter ','12 Hres','9/11/2023 12:52:43 PM'),(55,'CMP-HC-579-11','Colas connecter ','12 Hres','9/11/2023 12:57:16 PM'),(56,'CMP-WJ-508-10','MK connecter ','13 Hres','9/11/2023 1:00:00 PM'),(57,'CMP-WJ-508-10','MK Deconnecter ','13 Hres','9/11/2023 1:03:59 PM'),(58,'CMP-WJ-508-10','MK connecter ','13 Hres','9/11/2023 1:19:06 PM'),(59,'CMP-HC-579-11','Colas connecter ','13 Hres','9/11/2023 1:20:19 PM'),(60,'CMP-HC-579-11','Colas Deconnecter ','13 Hres','9/11/2023 1:23:17 PM'),(61,'CMP-WJ-508-10','MK connecter ','13 Hres','9/11/2023 1:30:43 PM'),(62,'CMP-WJ-508-10','MK Deconnecter ','13 Hres','9/11/2023 1:38:15 PM'),(63,'CMP-HC-579-11','Colas connecter ','13 Hres','9/11/2023 1:38:15 PM'),(64,'CMP-HC-579-11','Colas Deconnecter ','13 Hres','9/11/2023 1:39:37 PM'),(65,'CMP-WP-949-12','Herntz connecter ','13 Hres','9/11/2023 1:39:37 PM'),(66,'CMP-HC-579-11','Colas connecter ','13 Hres','9/11/2023 1:26:13 PM'),(67,'CMP-HC-579-11','Colas Deconnecter ','13 Hres','9/11/2023 1:40:22 PM'),(68,'CMP-WP-949-12','Herntz Deconnecter ','13 Hres','9/11/2023 1:54:00 PM'),(69,'CMP-WP-949-12','Herntz connecter ','13 Hres','9/11/2023 1:52:52 PM');
/*!40000 ALTER TABLE `tbltransaction` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `employe` int NOT NULL,
  `username` varchar(100) DEFAULT NULL,
  `password` varchar(105) DEFAULT NULL,
  `role` varchar(45) DEFAULT NULL,
  `etat` int DEFAULT NULL,
  `date_save` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `fk_emp_idx` (`employe`),
  CONSTRAINT `fk_emp` FOREIGN KEY (`employe`) REFERENCES `employe` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (4,4,'Melanie','Melanie12','Vendeur',0,'2023-08-15 20:18:24'),(5,6,'MK','MK1311','Secretaire',0,'2023-08-18 19:57:44'),(6,8,'Herntz','Herntz3.0','Administrateur',1,'2023-08-18 19:58:01'),(7,7,'Colas','COLAS1999','Secretaire',0,'2023-08-18 19:58:22');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-09-11 14:08:28
