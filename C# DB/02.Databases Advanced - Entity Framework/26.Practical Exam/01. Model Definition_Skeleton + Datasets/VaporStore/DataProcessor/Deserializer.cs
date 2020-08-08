namespace VaporStore.DataProcessor
{
	using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using Data;
    using Newtonsoft.Json;
    using VaporStore.Data.Models;
    using VaporStore.Data.Models.Enums;
    using VaporStore.DataProcessor.Dto.Import;
    using XmlFacade;

    public static class Deserializer
	{
		public static string ImportGames(VaporStoreDbContext context, string jsonString)
		{
			StringBuilder sb = new StringBuilder();

			var data = JsonConvert.DeserializeObject<ImportGamesDeveloperGenreTagDTO[]>(jsonString);

            foreach (var item in data)
            {
                if (!IsValid(item))
                {
					sb.AppendLine("Invalid Data");
					continue;
                }

				//invalid tags
                if (item.Tags == null || item.Tags.Length == 0)
                {
					sb.AppendLine("Invalid Data");
					continue;
				}

				var isValidDate = DateTime.TryParseExact(item.ReleaseDate.ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime releaseDate);

				//invalid Release Date
				if (!isValidDate)
                {
					sb.AppendLine("Invalid Data");
					continue;
				}

				//doesn’t exist developer
				if (!context.Developers.Any(d => d.Name == item.Developer))
                {
					context.Developers.Add(new Developer
					{
						Name = item.Developer
					});

					context.SaveChanges();
                }

				//doesn’t exist genre
				if (!context.Genres.Any(g => g.Name == item.Genre))
                {
					context.Genres.Add(new Genre
					{
						Name = item.Genre
					});

					context.SaveChanges();
				}

				List<Tag> tags = new List<Tag>();
                foreach (var tag in item.Tags.Distinct())
                {
                    if (context.Tags.Any(t => t.Name == tag))
                    {
						continue;
                    }

                    if (!tags.Any(t => t.Name == tag))
                    {
						tags.Add(new Tag
						{
							Name = tag
						});
                    }
                }

				context.Tags.AddRange(tags);
				context.SaveChanges();

				var developer = context.Developers.FirstOrDefault(d => d.Name == item.Developer);
				var genre = context.Genres.FirstOrDefault(g => g.Name == item.Genre);
				
				var game = new Game
				{
					Name = item.Name,
					Price = item.Price,
					ReleaseDate = releaseDate,
					DeveloperId = developer.Id,
					GenreId = genre.Id
				};

				//add gametags in mapping table
                foreach (var tag in tags)
                {
					context.GameTags.Add(new GameTag
					{
						Game = game,
						Tag = tag
					});
                }

				context.Games.Add(game);
				context.SaveChanges();

				sb.AppendLine(string.Format("Added {0} ({1}) with {2} tags", item.Name, item.Genre, tags.Count));
            }

			return sb.ToString();
		}

		public static string ImportUsers(VaporStoreDbContext context, string jsonString)
		{
			StringBuilder sb = new StringBuilder();

			var data = JsonConvert.DeserializeObject<UserCardDTO[]>(jsonString);

			List<User> users = new List<User>();
            foreach (var item in data)
            {
                if (!IsValid(item))
                {
					sb.AppendLine("Invalid Data");
					continue;
                }

				List<Card> cards = new List<Card>();
                foreach (var card in item.Cards)
                {
                    if (!IsValid(card))
                    {
						sb.AppendLine("Invalid Data");
						continue;
					}

					Enum.TryParse<CardType>(card.Type.ToString(), out CardType type);
					cards.Add(new Card
					{
						Number = card.Number,
						Cvc = card.CVC,
						Type = type
					});
                }

				var user = new User
				{
					FullName = item.FullName,
					Username = item.Username,
					Age = item.Age,
					Email = item.Email,
					Cards = cards
				};

				users.Add(user);
				sb.AppendLine(string.Format("Imported {0} with {1} cards", user.Username, user.Cards.Count));
            }

			context.Users.AddRange(users);
			context.SaveChanges();

			return sb.ToString();
		}

		public static string ImportPurchases(VaporStoreDbContext context, string xmlString)
		{
			StringBuilder sb = new StringBuilder();

			var data = XmlConverter.Deserializer<ImportPurchasesDTO>(xmlString, "Purchases");

			List<Purchase> purchases = new List<Purchase>();
            foreach (var item in data)
            {
				var isValidDate = DateTime.TryParseExact(item.Date, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date);

                if (!isValidDate)
                {
					sb.AppendLine("Invalid Data");
					continue;
                }

				var card = context.Cards.FirstOrDefault(c => c.Number == item.Card);
				var username = card.User;

				var game = context.Games.FirstOrDefault(g => g.Name == item.Title);

				var purchase = new Purchase
				{
					Game = game,
					ProductKey = item.Key,
					Card = card,
					Date = date,
				};

				purchases.Add(purchase);
				sb.AppendLine(string.Format("Imported {0} for {1}", game.Name, username.Username));
			}

			context.Purchases.AddRange(purchases);
			context.SaveChanges();

			return sb.ToString();
		}

		private static bool IsValid(object dto)
		{
			var validationContext = new ValidationContext(dto);
			var validationResult = new List<ValidationResult>();

			return Validator.TryValidateObject(dto, validationContext, validationResult, true);
		}
	}
}