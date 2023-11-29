
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

-- INSERT TEST DATA

INSERT INTO publisher (publisher_name, publisher_description)
VALUES
('Spigot', 'Spigot''s debut title, Semi-Death, was released in 2023. Since then, we''ve released dozens of titles that didn''t change the world (and one that did). Today, a few people play our games sometimes.'),
('Headkick Studios', 'Indie game developer (kind of) based in the U.S. (kind of)'),
('De-Logic', 'Not known for anything - the mediocre 3D Sandbox Adventure that has entertained probably nobody anywhere - De-Logic seeks to embrace the status quo and do nothing for Indie gaming!');

INSERT INTO game (publisher_id, game_title, game_description, release_date, game_price, game_icon_link)
VALUES
(
	1,
 	'Semi-Death',
 	'A blend of action and adventure with award-winning technology that creates a frighteningly realistic world where players must think to survive.',
 	NOW(),
 	9.99,
	''
),
(
	1,
	'Anti-Strike',
	'An elite competitive experience shaped by millions of players from across the globe.',
	NOW(),
	0,
	''
),
(
	2,
	'Jerry''s Mod',
	'Jerry''s Mod is a physics sandbox with no predefined aims or goals. We give you the tools and leave you to play.',
	NOW(),
	9.99,
	''
),
(
	3,
	'Terrarium',
	'Dig, fight, explore, build! Everything is impossible in this action-packed adventure game.',
	NOW(),
	14.99,
	''
);

INSERT INTO Tag (tag_name, tag_description)
VALUES
('Sandbox', 'Play it your way'),
('FPS', 'Shoot things'),
('Casual', 'Sit up and relax');

INSERT INTO TaggedAs (game_id, tag_id)
VALUES
(1, 2),
(2, 2),
(3, 1),
(3, 3),
(4, 1);

INSERT INTO Customer (customer_username, customer_password, join_date)
VALUES
('gameplayer123', 'gamesgamesgames', NOW()),
('haterofgames', 'ihategames000', NOW());

INSERT INTO OwnedBy (customer_id, game_id)
VALUES
(1, 1),
(1, 2),
(1, 3),
(1, 4),
(2, 2),
(2, 4);

INSERT INTO Review (author_id, game_id, review_text, review_is_positive, post_date)
VALUES
(2, 4, 'This game is impossible!', FALSE, NOW()),
(2, 2, 'Gunplay stinks. 1/0', FALSE, NOW()),
(1, 4, 'this is like the dim souls of open world sandbox survival crafting games!', TRUE, NOW()),
(1, 1, 'Brilliant story, charming graphics, what more can you ask for?', TRUE, NOW());
