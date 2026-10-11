using JokeApp.Models;

namespace JokeApp.Services {
    public sealed class JokeService {
        private readonly List<Joke> _jokes = new() {
            new Joke("Er zijn 10 soorten mensen: zij die binair begrijpen en zij die dat niet doen.", 'p'),
            new Joke("Een SQL-query loopt een café binnen, stapt naar twee tabellen en vraagt: mag ik erbij komen?", 'p')
        };
        public IReadOnlyList<Joke> GetAll() {
            return _jokes.AsReadOnly();
        }
        public Joke GetRandom() {
            var index = Random.Shared.Next(_jokes.Count);
            return _jokes[index];
        }
        public void AddJoke(Joke joke) {
            ArgumentNullException.ThrowIfNull(joke);
            _jokes.Add(joke);
        }
    }
}
