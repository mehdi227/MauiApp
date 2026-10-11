using System;
using System.Collections.Generic;
using System.Text;

namespace JokeApp.Models {
    public sealed class Joke {
        public Guid Id { get; init; } = Guid.NewGuid();
        public string Text { get; set; }
        public char JokeCategory;

        public Joke(string text, char jokeCategory) {
            Text = text;
            JokeCategory = jokeCategory;
        }
    }
}
