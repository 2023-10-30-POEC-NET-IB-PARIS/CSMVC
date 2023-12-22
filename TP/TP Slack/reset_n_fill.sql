DROP TABLE IF EXISTS message;
DROP TABLE IF EXISTS thread;
DROP TABLE IF EXISTS user;

CREATE TABLE user (
	id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	name varchar(50) NOT NULL
);

CREATE TABLE thread (
    id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    label varchar(255) NOT NULL
);

CREATE TABLE message (
    id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    author_id INTEGER NOT NULL,
	thread_id INTEGER NOT NULL REFERENCES thread ON DELETE CASCADE,
    content text NOT NULL,
    date timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT messages_author FOREIGN KEY (author_id) REFERENCES user(id),
    CONSTRAINT messages_thread FOREIGN KEY (thread_id) REFERENCES thread(id)
);


INSERT INTO user (id, name) VALUES
(1, 'Susan Chan'),
(2, 'Amy Miller'),
(3, 'Douglas Ruiz');

INSERT INTO thread (id, label) VALUES
(1, 'Miss win trip technology among character.'),
(2, 'Make main soon might child investment.');


INSERT INTO message (id, author_id, thread_id, content, date) VALUES
(1, 3, 1, 'Piece discussion support church...', '2023-03-12 10:12:38'),
(2, 1, 2, 'True out term just...', '2023-02-14 12:41:43'),
(3, 3, 1, 'Learn do safe suggest table...', '2023-03-26 14:26:37'),
(4, 2, 2, 'Improve different beautiful protect...', '2023-12-03 05:30:06'),
(5, 2, 1, 'Bad art travel positive half...', '2023-10-21 06:09:04'),
(6, 1, 1, 'Father black continue resource...', '2023-03-10 17:05:46'),
(7, 3, 1, 'Rise such music season near...', '2023-02-28 02:26:17'),
(8, 2, 2, 'Old real art individual rate...', '2023-01-25 22:25:05'),
(9, 3, 1, 'Against car sort leg only...', '2023-11-15 01:49:29'),
(10, 2, 1, 'Road much eight...', '2023-05-14 20:20:01');

