CREATE TABLE ecommerce.client
(
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  cart_id INT NOT NULL REFERENCES ecommerce.cart(id),
  first_name VARCHAR(50) DEFAULT 'No name',
  last_name VARCHAR(50) DEFAULT 'No last name',
  email VARCHAR(255) NOT NULL UNIQUE,
  password VARCHAR(255) DEFAULT 'No password',
  INDEX (email)
)
  ENGINE InnoDB
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_unicode_ci;
