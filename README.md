Endpoints da API
GET /games
Retorna uma lista de todos os jogos cadastrados.

Response:
```
[
  {
    "id": 1,
    "name": "The Legend of Zelda: Breath of the Wild",
    "genre": "Adventure",
    "price": 59.99,
    "releaseDate": "2017-03-03"
  },
  {
    "id": 2,
    "name": "Cyberpunk 2077",
    "genre": "RPG",
    "price": 49.99,
    "releaseDate": "2020-12-10"
  }
]
```

GET /games/{id}
Retorna os detalhes de um jogo específico com base no ID fornecido.

Response:
```
{
  "id": 1,
  "name": "The Legend of Zelda: Breath of the Wild",
  "genre": "Adventure",
  "price": 59.99,
  "releaseDate": "2017-03-03"
}
```

POST /games
Cria um novo jogo com base nos dados fornecidos no corpo da requisição.

Corpo da requisição:
```
{
  "name": "The Last of Us Part II",
  "genre": "Action-Adventure",
  "price": 69.99,
  "releaseDate": "2020-06-19"
}
```

Response(código 200 OK):
```
{
  "id": 3,
  "name": "The Last of Us Part II",
  "genre": "Action-Adventure",
  "price": 69.99,
  "releaseDate": "2020-06-19"
}
```