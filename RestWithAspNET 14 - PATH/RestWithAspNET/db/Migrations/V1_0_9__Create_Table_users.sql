CREATE TABLE `users`(
  `id` INT(10) AUTO_INCREMENT PRIMARY KEY,
  `Login` VARCHAR(50) UNIQUE NOT NULL,
  `AccessKey` VARCHAR(50) NOT NULL
) ENGINE=InnoDB;