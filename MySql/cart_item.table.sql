CREATE TABLE ecommerce.cart_item
(
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  product_id INT NOT NULL REFERENCES ecommerce.product(id),
  cart_id INT NOT NULL REFERENCES ecommerce.cart(id),
  quantity INT DEFAULT 1
)
  ENGINE InnoDB
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_unicode_ci;
