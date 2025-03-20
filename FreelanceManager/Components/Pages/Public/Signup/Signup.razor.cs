using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using FreelanceManager.Shared;
using FreelanceManager.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace FreelanceManager.Components.Pages.Public.Signup
{
    public partial class Signup : ComponentBase
    {
        [Inject]
        HttpClient Http { get; set; }

        [Inject]
        ILogger<ApplicationUserModel> Logger { get; set; }

        protected ApplicationUserModel registration = new();

        protected CustomFormValidator customFormValidator;

        protected bool isRegistrationSuccess = false;

        protected async Task CreateApplicationUser()
        {
            customFormValidator.ClearFormErrors();
            isRegistrationSuccess = false;
            try
            {
                Console.WriteLine(registration);
                // var response = await Http.PostAsJsonAsync("api/Student", registration);
                // var errors = await response.Content.ReadFromJsonAsync<Dictionary<string, List<string>>>();

                // if (response.StatusCode == HttpStatusCode.BadRequest && errors.Count > 0)
                // {
                //     customFormValidator.DisplayFormErrors(errors);
                //     throw new HttpRequestException($"Validation failed. Status Code: {response.StatusCode}");
                // }
                // else
                // {
                //     isRegistrationSuccess = true;
                //     Logger.LogInformation("The registration is successful");
                // }

            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
            }
        }

    }
}