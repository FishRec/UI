-- --------------------------------------------------------
-- 主機:                           127.0.0.1
-- 服務器版本:                        10.3.7-MariaDB - mariadb.org binary distribution
-- 服務器操作系統:                      Win64
-- HeidiSQL 版本:                  9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- 導出 fish 的資料庫結構
CREATE DATABASE IF NOT EXISTS `fish` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci */;
USE `fish`;

-- 導出  表 fish.uc0101_1 結構
CREATE TABLE IF NOT EXISTS `uc0101_1` (
  `companyid` text COLLATE utf8_unicode_ci NOT NULL,
  `company` text COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- 正在導出表  fish.uc0101_1 的資料：~0 rows (大約)
/*!40000 ALTER TABLE `uc0101_1` DISABLE KEYS */;
INSERT INTO `uc0101_1` (`companyid`, `company`) VALUES
	('cgm', 'cgm');
/*!40000 ALTER TABLE `uc0101_1` ENABLE KEYS */;

-- 導出  表 fish.uc0101_2 結構
CREATE TABLE IF NOT EXISTS `uc0101_2` (
  `companyid` text COLLATE utf8_unicode_ci NOT NULL,
  `userid` text COLLATE utf8_unicode_ci NOT NULL,
  `password` text COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- 正在導出表  fish.uc0101_2 的資料：~0 rows (大約)
/*!40000 ALTER TABLE `uc0101_2` DISABLE KEYS */;
INSERT INTO `uc0101_2` (`companyid`, `userid`, `password`) VALUES
	('cgm', 'cgm106091', 'cgm$$$$$$$$');
/*!40000 ALTER TABLE `uc0101_2` ENABLE KEYS */;

-- 導出  表 fish.uc0102 結構
CREATE TABLE IF NOT EXISTS `uc0102` (
  `temperature` text COLLATE utf8_unicode_ci NOT NULL,
  `longitude` text COLLATE utf8_unicode_ci NOT NULL,
  `latitude` text COLLATE utf8_unicode_ci NOT NULL,
  `date` text COLLATE utf8_unicode_ci NOT NULL,
  `time` text COLLATE utf8_unicode_ci NOT NULL,
  `source` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- 正在導出表  fish.uc0102 的資料：~14 rows (大約)
/*!40000 ALTER TABLE `uc0102` DISABLE KEYS */;
INSERT INTO `uc0102` (`temperature`, `longitude`, `latitude`, `date`, `time`, `source`) VALUES
	('23.56°C', '123.458°E', '66.123°N', '2018/07/02', '06:43:25', 1),
	('24.73°C', '115.387°E', '69.859°N', '2018/07/01', '07:45:38', 1),
	(' ', '123.458°E', '66.123°N', '2018/07/03', '05:36:08', 2),
	('23.56°C', '123.458°E', '66.123°N', '2018/07/02', '06:43:25', 1),
	('23.56°C', '123.458°E', '66.123°N', '2018/07/02', '06:43:25', 1),
	('23.56°C', '123.458°E', '66.123°N', '2018/07/02', '06:43:25', 1),
	('23.56°C', '123.458°E', '66.123°N', '2018/07/02', '06:43:25', 1),
	('23.56°C', '123.458°E', '66.123°N', '2018/07/02', '06:43:25', 1),
	('23.56°C', '123.458°E', '66.123°N', '2018/07/02', '06:43:25', 1),
	('23.56°C', '123.458°E', '66.123°N', '2018/07/02', '06:43:25', 1),
	('23.56°C', '123.458°E', '66.123°N', '2018/07/02', '06:43:25', 1),
	('23.56°C', '123.458°E', '66.123°N', '2018/07/02', '06:43:25', 1),
	('23.56°C', '123.458°E', '66.123°N', '2018/07/02', '06:43:25', 1),
	(' ', '123.458°E', '66.123°N', '2018/07/02', '06:43:25', 2);
/*!40000 ALTER TABLE `uc0102` ENABLE KEYS */;

-- 導出  表 fish.uc0102_argo 結構
CREATE TABLE IF NOT EXISTS `uc0102_argo` (
  `date` text COLLATE utf8_unicode_ci DEFAULT NULL,
  `time` text COLLATE utf8_unicode_ci DEFAULT NULL,
  `temperature` text COLLATE utf8_unicode_ci DEFAULT NULL,
  `meter` text COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- 正在導出表  fish.uc0102_argo 的資料：~8 rows (大約)
/*!40000 ALTER TABLE `uc0102_argo` DISABLE KEYS */;
INSERT INTO `uc0102_argo` (`date`, `time`, `temperature`, `meter`) VALUES
	('2018/07/03', '05:36:08', '23.38°C', '5m'),
	('2018/07/03', '05:36:08', '23.32°C', '48m'),
	('2018/07/03', '05:36:08', '22.87°C', '100m'),
	('2018/07/03', '05:36:08', '22.65°C', '149m'),
	('2018/07/02', '06:43:25', '23.38°C', '5m'),
	('2018/07/02', '06:43:25', '23.32°C', '48m'),
	('2018/07/02', '06:43:25', '24.87°C', '100m'),
	('2018/07/02', '06:43:25', '29.65°C', '149m');
/*!40000 ALTER TABLE `uc0102_argo` ENABLE KEYS */;

-- 導出  表 fish.uc0104_2 結構
CREATE TABLE IF NOT EXISTS `uc0104_2` (
  `latitude` text COLLATE utf8_unicode_ci NOT NULL,
  `longitude` text COLLATE utf8_unicode_ci NOT NULL,
  `big` int(11) NOT NULL,
  `clear` int(11) NOT NULL,
  `ghost` int(11) NOT NULL,
  `white` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- 正在導出表  fish.uc0104_2 的資料：~0 rows (大約)
/*!40000 ALTER TABLE `uc0104_2` DISABLE KEYS */;
INSERT INTO `uc0104_2` (`latitude`, `longitude`, `big`, `clear`, `ghost`, `white`) VALUES
	('45°N', '123°E', 55, 86, 30, 68);
/*!40000 ALTER TABLE `uc0104_2` ENABLE KEYS */;

-- 導出  表 fish.uc0104_3 結構
CREATE TABLE IF NOT EXISTS `uc0104_3` (
  `latitude` text COLLATE utf8_unicode_ci NOT NULL,
  `longitude` text COLLATE utf8_unicode_ci NOT NULL,
  `ledtype` text COLLATE utf8_unicode_ci NOT NULL,
  `date` text COLLATE utf8_unicode_ci NOT NULL,
  `time` text COLLATE utf8_unicode_ci NOT NULL,
  `wave` text COLLATE utf8_unicode_ci NOT NULL,
  `fish` text COLLATE utf8_unicode_ci NOT NULL,
  `times` text COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- 正在導出表  fish.uc0104_3 的資料：~8 rows (大約)
/*!40000 ALTER TABLE `uc0104_3` DISABLE KEYS */;
INSERT INTO `uc0104_3` (`latitude`, `longitude`, `ledtype`, `date`, `time`, `wave`, `fish`, `times`) VALUES
	('45°N', '123°E', 'RYDH-265381561', '2018/07/07', '11:43:58', '480-500nm', '鯖魚', '11'),
	('45°N', '123°E', 'RYDH-265381562', '2018/07/07', '12:24:03', '500-510nm', '大目鰱', '3'),
	('45°N', '123°E', 'RYDH-265381563', '2018/07/06', '11:43:58', '480-500nm', '白帶魚', '9'),
	('45°N', '123°E', 'RYDH-265381564', '2018/07/06', '12:24:03', '500-510nm', '鬼頭刀', '5'),
	('45°N', '123°E', 'RYDH-265381563', '2018/07/04', '11:43:58', '480-500nm', '鯖魚', '5'),
	('45°N', '123°E', 'RYDH-265381561', '2018/07/05', '12:24:03', '500-510nm', '大目鰱', '20'),
	('45°N', '123°E', 'RYDH-265381564', '2018/07/04', '11:43:58', '480-500nm', '白帶魚', '7'),
	('45°N', '123°E', 'RYDH-265381562', '2018/07/05', '12:24:03', '500-510nm', '鬼頭刀', '13');
/*!40000 ALTER TABLE `uc0104_3` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
