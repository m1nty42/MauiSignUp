namespace MauiSignUp;

using MauiSignUp.Pages;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Route for URI-based navigation
        Routing.RegisterRoute("profile", typeof(ProfilePage));
    }
}
