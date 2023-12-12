
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
 	'2023-11-27',
 	9.99,
	''
),
(
	1,
	'Anti-Strike',
	'An elite competitive experience shaped by millions of players from across the globe.',
	'2023-11-28',
	0,
	''
),
(
	2,
	'Jerry''s Mod',
	'Jerry''s Mod is a physics sandbox with no predefined aims or goals. We give you the tools and leave you to play.',
	'2023-11-30',
	9.99,
	''
),
(
	3,
	'Terrarium',
	'Dig, fight, explore, build! Everything is impossible in this action-packed adventure game.',
	'2023-11-28',
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
('gameplayer123', 'gamesgamesgames', '2023-12-01'),
('haterofgames', 'ihategames000', '2023-11-28');

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






