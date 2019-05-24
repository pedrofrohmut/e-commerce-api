CREATE TABLE ecommerce.product
(
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  title NVARCHAR(255) DEFAULT 'No title',
  img NVARCHAR(255) DEFAULT 'No image',
  price DECIMAL(18,2) DEFAULT 0.0,
  company NVARCHAR(255) DEFAULT 'No company',
  info TEXT,
  INDEX (title)
)
  ENGINE InnoDB
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_unicode_ci;
