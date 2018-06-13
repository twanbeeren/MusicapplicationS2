SELECT acc.Name AS ArtistName FROM Song_Artists sa
JOIN Artist a ON a.Artist_Id = sa.Artist_id
JOIN Account acc ON acc.Account_Id = a.Account_Id
WHERE Song_id = 2