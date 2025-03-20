using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace FreelanceManager.Components.Pages
{
    public partial class Login
    {
        private string Email { get; set; } = string.Empty;
        private string Password { get; set; } = string.Empty;
        private bool LoginError { get; set; } = false;
        private string ErrorMessage { get; set; } = string.Empty;

        private bool IsSignupPopupVisible { get; set; } = false;
        private string SignupEmail { get; set; } = string.Empty;
        private string SignupUsername { get; set; } = string.Empty;
        private string SignupFullName { get; set; } = string.Empty;
        private string SignupPhoneNumber { get; set; } = string.Empty;
        private string SignupPassword { get; set; } = string.Empty;
        private bool SignupError { get; set; } = false;
        private string SignupErrorMessage { get; set; } = string.Empty;

        private async Task HandleLogin()
        {
            try
            {
                var payload = new { Email, Password }; // Use Email instead of Username
                Console.WriteLine($"Sending Login Payload: {System.Text.Json.JsonSerializer.Serialize(payload)}");
                var response = new HttpResponseMessage();
                try{
                    response = await Http.PostAsJsonAsync("https://localhost:7158/api/Authentication/SignIn", payload);
                    }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex}");
                }

                if (response.IsSuccessStatusCode)
                {
                    LoginError = false;
                    NavigationManager.NavigateTo("/");
                }
                else
                {
                    LoginError = true;
                    ErrorMessage = "Invalid email or password.";
                }
            }
            catch (Exception ex)
            {
                LoginError = true;
                ErrorMessage = $"An error occurred: {ex.Message}";
            }
        }

        private void ShowSignupPopup()
        {
            IsSignupPopupVisible = true;
        }

        public class ApplicationUserModel
        {
            public string? Id { get; set; }
            public string Email { get; set; } = string.Empty;
            public string UserName { get; set; } = string.Empty;
            public string FullName { get; set; } = string.Empty;
            public string PhoneNumber { get; set; } = string.Empty;
            public List<string> Roles { get; set; } = new List<string>();
            public bool IsActive { get; set; }
        }

private async Task HandleSignup()
{
    try
    {
        var model = new ApplicationUserModel
        {
            Email = SignupEmail,
            UserName = SignupUsername,
            FullName = SignupFullName,
            PhoneNumber = SignupPhoneNumber,
            IsActive = true,

        };

        Console.WriteLine($"Sending Payload: {System.Text.Json.JsonSerializer.Serialize(model)}");
        var response = await Http.PostAsJsonAsync("https://localhost:7158/api/ApplicationUsers/Create", model);

        if (response.IsSuccessStatusCode)
        {
            IsSignupPopupVisible = false;
            SignupError = false;
        }
        else
        {
            SignupError = true;
            SignupErrorMessage = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"API detailed error: {SignupErrorMessage}");
        }
    }
    catch (Exception ex)
    {
        SignupError = true;
        SignupErrorMessage = $"An error occurred: {ex.Message}";
        Console.WriteLine(SignupErrorMessage);
    }
}

        [Inject]
        private HttpClient Http { get; set; } = default!;

        [Inject]
        private NavigationManager NavigationManager { get; set; } = default!;
    }
}