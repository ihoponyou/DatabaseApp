SELECT game.game_id, game_title, game_description, release_date, game_price FROM ownedby
JOIN game ON ownedby.game_id = game.game_id
WHERE ownedby.customer_id = 2;

SELECT publisher.publisher_id, publisher_name, publisher_description FROM publisher JOIN game ON game.publisher_id = publisher.publisher_id WHERE game_id = 1;

SELECT tag_id FROM taggedas WHERE game_id = 3;

SELECT * FROM game WHERE game_price < CAST(10 AS MONEY) ORDER BY game_price DESC;

SELECT review.review_id, customer_username, review_text, review_is_positive, post_date FROM review
JOIN customer ON customer.customer_id = review.author_id
WHERE game_id = 4
ORDER BY review_is_positive DESC;
		  
SELECT MAX(reviews_per_game.count) FROM (SELECT game_id, COUNT(game_id) FROM review GROUP BY game_id) reviews_per_game;