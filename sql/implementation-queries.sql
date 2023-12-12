-- get games owned by a customer
SELECT game.game_id, game_title, game_description, release_date, game_price FROM ownedby
JOIN game ON ownedby.game_id = game.game_id
WHERE ownedby.customer_id = 2;

-- get publisher of a game
SELECT publisher.publisher_id, publisher_name, publisher_description FROM publisher JOIN game ON game.publisher_id = publisher.publisher_id WHERE game_id = 1;

-- get tag ids for a game
SELECT tag_id FROM taggedas WHERE game_id = 3;

-- select games under $10
SELECT * FROM game WHERE game_price < CAST(10 AS MONEY) ORDER BY game_price DESC;

-- get game reviews with descending positivity
SELECT review.review_id, customer_username, review_text, review_is_positive, post_date FROM review
JOIN customer ON customer.customer_id = review.author_id
WHERE game_id = 4
ORDER BY review_is_positive DESC;
		  
-- get the most amount of reviews for a game
SELECT MAX(reviews_per_game.count) FROM (SELECT game_id, COUNT(game_id) FROM review GROUP BY game_id) reviews_per_game;

-- most discussed game
SELECT game_id, COUNT(game_id) FROM review GROUP BY game_id;
SELECT * FROM (SELECT game_id, COUNT(game_id) FROM review GROUP BY game_id) reviews_per_game ORDER BY reviews_per_game.count DESC LIMIT 1;

SELECT game_title, most_popular_game.count FROM game
JOIN (SELECT * FROM (SELECT game_id, COUNT(game_id) FROM review GROUP BY game_id) reviews_per_game ORDER BY reviews_per_game.count DESC LIMIT 1) most_popular_game
	ON game.game_id = most_popular_game.game_id;
	
-- oldest customer
SELECT * FROM customer ORDER BY join_date ASC LIMIT 1;

-- search by title
SELECT * FROM game WHERE LOWER(game_title) LIKE '%';