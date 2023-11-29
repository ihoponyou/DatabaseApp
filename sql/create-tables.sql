
-- CREATE TABLES

CREATE TABLE IF NOT EXISTS Publisher (
	publisher_id SERIAL,
	publisher_name VARCHAR(50) UNIQUE NOT NULL,
	publisher_description VARCHAR(250),
	
	PRIMARY KEY (publisher_id)
);

CREATE TABLE IF NOT EXISTS Tag (
	tag_id SERIAL,
	tag_name VARCHAR(50) UNIQUE NOT NULL,
	tag_description VARCHAR(250),
	
	PRIMARY KEY (tag_id)
);

CREATE TABLE IF NOT EXISTS Game (
	game_id SERIAL,
	publisher_id INT NOT NULL,
	game_title VARCHAR(50) NOT NULL,
	game_description VARCHAR(250),
	release_date DATE NOT NULL,
	game_price MONEY NOT NULL,
	game_icon_link VARCHAR(100),
	
	PRIMARY KEY (game_id),
	FOREIGN KEY (publisher_id) REFERENCES Publisher (publisher_id)
);

CREATE TABLE IF NOT EXISTS TaggedAs (
	game_id INT NOT NULL,
	tag_id INT NOT NULL,
	
	PRIMARY KEY (game_id, tag_id),
	FOREIGN KEY (game_id) REFERENCES Game (game_id),
	FOREIGN KEY (tag_id) REFERENCES Tag (tag_id)
);

CREATE TABLE IF NOT EXISTS Customer (
	customer_id SERIAL,
	customer_username VARCHAR(32) UNIQUE NOT NULL,
	customer_password VARCHAR(64) NOT NULL,
	join_date DATE NOT NULL,
	
	PRIMARY KEY (customer_id)
);

CREATE TABLE IF NOT EXISTS OwnedBy (
	customer_id INT NOT NULL,
	game_id INT NOT NULL,
	
	PRIMARY KEY (customer_id, game_id),
	FOREIGN KEY (customer_id) REFERENCES Customer (customer_id),
	FOREIGN KEY (game_id) REFERENCES Game (game_id)
);

CREATE TABLE IF NOT EXISTS Review (
	review_id SERIAL,
	author_id INT NOT NULL,
	game_id INT NOT NULL,
	review_text VARCHAR(250),
	review_is_positive BOOL NOT NULL,
	post_date DATE NOT NULL,
	
	PRIMARY KEY (review_id),
	FOREIGN KEY (author_id) REFERENCES Customer (customer_id),
	FOREIGN KEY (game_id) REFERENCES Game (game_id)
);
