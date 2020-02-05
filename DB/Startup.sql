-- for resetting test data

USE burgershackdb;

DROP TABLE burgers;
DROP TABLE sides;


-- Create tables
CREATE TABLE burgers (
  id int NOT NULL AUTO_INCREMENT,
  name VARCHAR(500) NOT NULL,
  description VARCHAR(255),
  price float,
  PRIMARY KEY (id)
);

CREATE TABLE sides (
  id int NOT NULL AUTO_INCREMENT,
  name VARCHAR(255) NOT NULL,
  description VARCHAR(255),
  price float,
  kidSized boolean,
  PRIMARY KEY (id)
);

-- Create entries
INSERT INTO burgers (name, description, price) VALUES ("Blue Cheese Burger", "Delicious", 6.25);
INSERT INTO burgers (name, description, price) VALUES ("Jalapeno Burger", "Spicy & tasty", 5.75);
INSERT INTO burgers (name, description, price) VALUES ("Bacon Burger", "Bacon makes everything better", 6.50);

INSERT INTO sides (name, description, price, kidSized) VALUES ("French Fries", "Starch, Oil, & Salt", 6.25, true);
INSERT INTO sides (name, description, price, kidSized) VALUES ("Onion Rings", "Deep Fried Goodness", 5.75, false);
INSERT INTO sides (name, description, price, kidSized) VALUES ("Salad", "What Your Food Eats", 6.50, true);



-- GetAll. * could be replaced with name, etc.
-- SELECT * FROM burgers;