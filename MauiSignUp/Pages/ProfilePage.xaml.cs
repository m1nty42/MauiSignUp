using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiSignUp.Pages;

[QueryProperty(nameof(Username), "Username")]
[QueryProperty(nameof(Email), "Email")]
public partial class ProfilePage : ContentPage, INotifyPropertyChanged
{
    private string _username = string.Empty;
    private string _email = string.Empty;

    public string Username
    {
        get => _username;
        set
        {
            if (_username == value) return;
            _username = value;
            OnPropertyChanged();
        }
    }

    public string Email
    {
        get => _email;
        set
        {
            if (_email == value) return;
            _email = value;
            OnPropertyChanged();
        }
    }

    public ProfilePage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    private async void OnSignOutClicked(object sender, EventArgs e)
    {
        // Navigate back to the Signup page (absolute route).
        await Shell.Current.GoToAsync("//signup");
    }

    public new event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
