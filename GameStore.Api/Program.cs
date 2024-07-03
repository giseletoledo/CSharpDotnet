using GameStore.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


const string GetGameEndpointName = "GetGame";


List<GameDto> games = [
        
            new GameDto(1, "The Legend of Zelda: Breath of the Wild", "Adventure", 59.99m, new DateOnly(2017, 3, 3)),
            new GameDto(2, "Super Mario Odyssey", "Platform", 49.99M, new DateOnly(2017, 10, 27)),
            new GameDto(3, "Tom Raider", "Adventure", 29.99M, new DateOnly(2020, 12, 10)),
            new GameDto(4, "Fortnite", "Action", 39.99M, new DateOnly(2018, 10, 26)),
            new GameDto(5, "Lego", "Adventure", 24.99M, new DateOnly(2020, 9, 17))
];


// GET /games
app.MapGet("games", () => games);


// GET /games/1
app.MapGet("games/{id}", (int id) => games.Find(game => game.Id == id))
.WithName(GetGameEndpointName);

// POST /games
app.MapPost("games", (CreateGameDto newGame) => {
    GameDto game = new(
        games.Count + 1,
        newGame.Name,
        newGame.Genre,
        newGame.Price,
        newGame.ReleaseDate);

        games.Add(game);

        return Results.CreatedAtRoute(GetGameEndpointName, new { id = game.Id}, game);
});
app.Run();
