CREATE DATABASE samplejokedb;

CREATE TABLE joke(
    id SERIAL PRIMARY KEY,
    setup VARCHAR (255) NOT NULL,
    punchline VARCHAR (255) NOT NULL
);

INSERT INTO joke (setup, punchline)
VALUES 
    ('Yesterday I saw a guy spill all his Scrabble letters on the road', 'I asked him, Whats the word on the street?'),
    ('Did you hear about the actor who fell through the floorboards?', 'He was just going through a stage'),
    ('Did you hear about the claustrophobic astronaut?', 'He just needed a little space');
