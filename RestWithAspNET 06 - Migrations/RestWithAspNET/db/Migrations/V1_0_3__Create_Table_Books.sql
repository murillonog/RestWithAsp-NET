CREATE TABLE IF NOT EXISTS `books`(
  `id` varchar(127) PRIMARY KEY NOT NULL,
  `Author` TEXT,
  `LaunchDate` datetime(6) NOT NULL,
  `Price` decimal(65,2) NOT NULL,
  `Title` TEXT
) ENGINE=InnoDB;