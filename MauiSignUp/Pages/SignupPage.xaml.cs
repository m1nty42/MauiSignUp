namespace MauiSignUp.Pages;

public partial class SignupPage : ContentPage
{
    public SignupPage()
    {
        InitializeComponent();
    }

    private async void OnSignUpClicked(object sender, EventArgs e)
    {
        ErrorLabel.IsVisible = false;
        ErrorLabel.Text = string.Empty;

        string username = UsernameEntry.Text?.Trim() ?? string.Empty;
        string email = EmailEntry.Text?.Trim() ?? string.Empty;
        string password = PasswordEntry.Text ?? string.Empty;
        string confirm = ConfirmPasswordEntry.Text ?? string.Empty;

        if (string.IsNullOrWhiteSpace(username) ||
            string.IsNullOrWhiteSpace(email) ||
            string.IsNullOrWhiteSpace(password) ||
            string.IsNullOrWhiteSpace(confirm))
        {
            ShowError("Please fill in all required fields.");
            return;
        }

        if (!password.Equals(confirm))
        {
            ShowError("Passwords do not match.");
            return;
        }

        // Use URI escaping to keep query parameters safe.
        var u = Uri.EscapeDataString(username);
        var em = Uri.EscapeDataString(email);

        await Shell.Current.GoToAsync($"profile?Username={u}&Email={em}");
    }

    private void ShowError(string message)
    {
        ErrorLabel.Text = message;
        ErrorLabel.IsVisible = true;
    }
}
