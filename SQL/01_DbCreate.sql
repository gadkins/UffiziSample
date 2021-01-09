USE [master]
GO

IF db_id('SampleJokeDb') IS NULL
  CREATE DATABASE [SampleJokeDb]
GO

USE [SampleJokeDb]
GO


DROP TABLE IF EXISTS Joke;


CREATE TABLE Joke (
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    [Setup] VARCHAR(255) NOT NULL,
    Punchline VARCHAR(255) NOT NULL,
);

SET IDENTITY_INSERT Joke ON
INSERT INTO Joke 
    (Id, [Setup], Punchline)
VALUES 
    (1, 'Yesterday I saw a guy spill all his Scrabble letters on the road', 'I asked him, What’s the word on the street?'),
    (2, 'Did you hear about the actor who fell through the floorboards?', 'He was just going through a stage'),
    (3, 'Did you hear about the claustrophobic astronaut?', 'He just needed a little space');
SET IDENTITY_INSERT Joke OFF