using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatterBox.Model;
using ChatterBox.Model.Additional;

namespace ChatterBox.Client.WinForms
{
    public static class Methods
    {
        static HttpClient client = new HttpClient();
        private static bool isInitialized = false;
        private static string prefix = "api/v0.1/";

        private static void Initialize()
        {
            client.BaseAddress = new Uri("http://localhost:59163/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            isInitialized = true;
        }

        public static void ExceptionHandler(string ex)
        {
            string response = String.Empty;
            switch (ex)
            {
                case "Пользователь с таким логином/паролем не найден":
                    response = "Неверно введены логин и/или пароль.";
                    break;
                default:
                    response = ex;
                    break;
            }
            MessageBox.Show(response, "Ошибка", MessageBoxButtons.OK);
        }

        public static User SignIn(string login, string password)
        {
            if (!isInitialized)
                Initialize();

            HttpResponseMessage response =
                client.PostAsJsonAsync(prefix + "users/signin", new[] { login, password }).Result;
            if (response.IsSuccessStatusCode)
                return response.Content.ReadAsAsync<User>().Result;
            else
                throw new Exception(response.Content.ReadAsStringAsync().Result);
        }

        public static User SignUp(UserOnCreate user)
        {
            if (!isInitialized)
                Initialize();

            HttpResponseMessage response =
                client.PostAsJsonAsync(prefix + "users", user).Result;
            if (response.IsSuccessStatusCode)
                return response.Content.ReadAsAsync<User>().Result;
            else
                throw new Exception(response.Content.ReadAsStringAsync().Result);
        }

        public static IEnumerable<Chat> UserChats(Guid userId)
        {
            if (!isInitialized)
                Initialize();

            HttpResponseMessage response =
                client.GetAsync(prefix + $"users/{userId}/chats").Result;
            if (response.IsSuccessStatusCode)
                return response.Content.ReadAsAsync<IEnumerable<Chat>>().Result;
            else
                throw new Exception(response.Content.ReadAsStringAsync().Result);
        }

        public static IEnumerable<Model.Message> ChatMessages(Guid chatId)
        {
            if (!isInitialized)
                Initialize();

            HttpResponseMessage response =
                client.GetAsync(prefix + $"chats/{chatId}/messages").Result;
            if (response.IsSuccessStatusCode)
                return response.Content.ReadAsAsync<IEnumerable<Model.Message>>().Result;
            else
                throw new Exception(response.Content.ReadAsStringAsync().Result);
        }

        public static Model.Message SendMessage(MessageOnCreate message)
        {
            if (!isInitialized)
                Initialize();

            HttpResponseMessage response =
                client.PostAsJsonAsync(prefix + "messages", message).Result;
            if (response.IsSuccessStatusCode)
                return response.Content.ReadAsAsync<Model.Message>().Result;
            else
                throw new Exception(response.Content.ReadAsStringAsync().Result);
        }


    }
}
