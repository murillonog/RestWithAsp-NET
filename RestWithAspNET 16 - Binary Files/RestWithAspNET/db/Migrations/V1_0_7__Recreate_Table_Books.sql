CREATE TABLE `books`(
  `id` INT(10) AUTO_INCREMENT PRIMARY KEY,
  `Author` TEXT,
  `LaunchDate` datetime(6) NOT NULL,
  `Price` decimal(65,2) NOT NULL,
  `Title` TEXT
) ENGINE=InnoDB;