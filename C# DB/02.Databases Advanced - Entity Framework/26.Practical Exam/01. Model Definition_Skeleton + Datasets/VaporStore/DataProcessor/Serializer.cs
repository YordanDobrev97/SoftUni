namespace VaporStore.DataProcessor
{
	using System;
    using System.Collections.Generic;
    using System.Linq;
    using Data;
    using Newtonsoft.Json;
    using VaporStore.Data.Models;
    using VaporStore.DataProcessor.Dto.Export;
    using XmlFacade;

    public static class Serializer
	{
		public static string ExportGamesByGenres(VaporStoreDbContext context, string[] genreNames)
		{
            /*
            var games = context.games
                .where(g => genrenames.contains(g.genre.name))
                .select(g => new
                {
                    id = g.genre.id,
                    genre = g.genre.name,
                    games = g.genre.games.select(genregame => new
                    {
                        id = genregame.id,
                        title = genregame.name,
                        developer = genregame.developer.name,
                        tags = string.join(", ", genregame.gametags.select(gt => gt.tag.name))
                    })
                });

            */
            var games = context.Genres
                .ToArray()
                .Where(g => genreNames.Contains(g.Name))
                .Select(g => new
                {
                    Id = g.Id,
                    Genre = g.Name,
                    Games = g.Games.Select(game => new
                    {
                        Id = game.Id,
                        Title = game.Name,
                        Developer = game.Developer.Name,
                        Tags = string.Join(", ", game.GameTags.Select(gt => gt.Tag.Name)),
                        Players = game.Purchases.Count
                    }),

                    TotalPlayers = g.Games.Sum(g => g.Purchases.Count)
                })
                .OrderByDescending(c => c.TotalPlayers)
                .ThenBy(c => c.Id)
                .ToList();

            var json = JsonConvert.SerializeObject(games, Formatting.Indented);
			return json;
		}

		public static string ExportUserPurchasesByType(VaporStoreDbContext context, string storeType)
		{
			var users = context.Users
				.Where(u => u.Cards.Count > 0)
				.Select(u => new ExportUserPurchasesTypeDTO
				{
					Username = u.Username,
					Purchases = u.Cards.Select(c => new PurchaseDTO
                    {
						Card = c.Number,
						Cvc = c.Cvc,
						
                    }).ToArray()
				});
				
				

			throw new NotImplementedException();
		}
	}
}