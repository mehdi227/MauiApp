using JokeApp.Models;
using JokeApp.Services;
using System.Data;

namespace JokeApp;

public partial class MainPage : ContentPage {
    private readonly JokeService _jokeService = new();

    public MainPage() {
        InitializeComponent();
    }

    private void OnShowRandomJokeClicked(object? sender, EventArgs e) {
        var joke = _jokeService.GetRandom();
        currentJokeLabel.Text = joke.Text;
    }

    private void OnJokeTextChanged(object? sender, TextChangedEventArgs e) {
        addJokeButton.IsEnabled = !string.IsNullOrWhiteSpace(e.NewTextValue);
    }

    private void OnJokeTextCompleted(object? sender, EventArgs e) {
        TryAddJoke();
    }

    private void OnAddJokeClicked(object? sender, EventArgs e) {
        TryAddJoke();
    }

    private void TryAddJoke() {
        var joke = new Joke(jokeTextEntry.Text, 'o');
        _jokeService.AddJoke(joke);

        jokeTextEntry.Text = string.Empty;
        currentJokeLabel.Text = joke.Text;
        UpdateStatus();
    }

    private void UpdateStatus() {
        var count = _jokeService.GetAll().Count;
        statusLabel.Text = $"{count} grappen beschikbaar";
    }
}





