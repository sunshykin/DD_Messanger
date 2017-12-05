using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatterBox.Model;
using ChatterBox.Model.Additional;
using Microsoft.Win32.SafeHandles;
using Newtonsoft.Json;

namespace ChatterBox.Client.WinForms.Helpers
{
    public static class DataBaseHelper
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

        #region PictureMethods

        public static byte[] SerializeImage(Image img)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                return stream.ToArray();
            }
        }

        public static Image DeserializeImage(byte[] array)
        {
            if (array.Length == 0 || array.Length == 8000)
                return Properties.Resources.DefaultImage;
            using (MemoryStream stream = new MemoryStream(array))
            {
                return Image.FromStream(stream);
            }
        }

        public static bool IsImage(byte[] array)
        {
            try
            {
                DeserializeImage(array);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region AttachMethods

        public static Model.Additional.File SerializeFile(string path)
        {
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    return new Model.Additional.File(Path.GetFileName(path), reader.ReadBytes((int)stream.Length));
                }
            }
        }

        public static void DeserializeFile(Model.Additional.File file)
        {
            var folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                using (var fs = new FileStream(folderDialog.SelectedPath + "\\" + file.FileName, FileMode.Create, FileAccess.Write))
                    fs.Write(file.FileData, 0, file.FileData.Length);
            }
        }

        public static void DeserializeFiles(IEnumerable<Model.Additional.File> files)
        {
            var folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var f in files)
                    using (var fs = new FileStream(folderDialog.SelectedPath + "\\" + f.FileName, FileMode.Create, FileAccess.Write))
                        fs.Write(f.FileData, 0, f.FileData.Length);
            }
        }

        #endregion


        #region UserAPI

        #region POST
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

        public static void ChangeName(Guid userId, string newName)
        {
            if (!isInitialized)
                Initialize();

            HttpResponseMessage response =
                client.PostAsJsonAsync(prefix + $"users/{userId}/changename", newName).Result;
            if (!response.IsSuccessStatusCode)
                throw new Exception(response.Content.ReadAsStringAsync().Result);
        }

        public static void ChangeLogin(Guid userId, string newLogin, string password)
        {
            if (!isInitialized)
                Initialize();

            HttpResponseMessage response =
                client.PostAsJsonAsync(prefix + $"users/{userId}/changelogin", 
                new []{newLogin, password}).Result;
            if (!response.IsSuccessStatusCode)
                throw new Exception(response.Content.ReadAsStringAsync().Result);
        }

        public static void ChangePassword(Guid userId, string oldPassword, string newPassword)
        {
            if (!isInitialized)
                Initialize();

            HttpResponseMessage response =
                client.PostAsJsonAsync(prefix + $"users/{userId}/changepass", 
                new []{oldPassword, newPassword}).Result;
            if (!response.IsSuccessStatusCode)
                throw new Exception(response.Content.ReadAsStringAsync().Result);
        }

        public static void ChangeUserPicture(Guid userId, Image pic)
        {
            if (!isInitialized)
                Initialize();

            HttpResponseMessage response =
                client.PostAsJsonAsync(prefix + $"users/{userId}/changepicture", SerializeImage(pic)).Result;
            if (!response.IsSuccessStatusCode)
                throw new Exception(response.Content.ReadAsStringAsync().Result);
        }

        #endregion

        #region GET

        public static User GetUser(Guid userId)
        {
            if (!isInitialized)
                Initialize();

            HttpResponseMessage response =
                client.GetAsync(prefix + $"users/{userId}").Result;
            if (response.IsSuccessStatusCode)
                return response.Content.ReadAsAsync<User>().Result;
            else
                throw new Exception(response.Content.ReadAsStringAsync().Result);
        }

        public static IEnumerable<User> GetUserContacts(Guid userId)
        {
            if (!isInitialized)
                Initialize();

            HttpResponseMessage response =
                client.GetAsync(prefix + $"users/{userId}/contacts").Result;
            if (response.IsSuccessStatusCode)
                return response.Content.ReadAsAsync<IEnumerable<User>>().Result;
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

        #endregion

        #region DELETE
        
        public static void DeleteUserContact(Guid userId, Guid contactId)
        {
            if (!isInitialized)
                Initialize();
            /*var request = new HttpRequestMessage()
            {
                Content = new StringContent(JsonConvert.SerializeObject(contactId), Encoding.UTF8, "application/json"),
                Method = HttpMethod.Delete,
                RequestUri = new Uri(client.BaseAddress + prefix + $"users/{userId}/delcontact")
            };
            HttpResponseMessage response = client.SendAsync(request).Result;
            if (!response.IsSuccessStatusCode)
                throw new Exception(response.Content.ReadAsStringAsync().Result);*/



            HttpResponseMessage response =
                client.DeleteAsync(prefix + $"users/{userId}/delcontact/{contactId}").Result;
            if (!response.IsSuccessStatusCode)
                throw new Exception(response.Content.ReadAsStringAsync().Result);
        }

        #endregion

        #endregion

        #region ChatAPI

        #region POST

        public static void ChangeTitle(Guid chatId, string title)
        {
            if (!isInitialized)
                Initialize();

            HttpResponseMessage response =
                client.PostAsJsonAsync(prefix + $"chats/{chatId}/changetitle", title).Result;
            if (!response.IsSuccessStatusCode)
                throw new Exception(response.Content.ReadAsStringAsync().Result);
        }

        public static void ChangeChatPicture(Guid chatId, Image pic)
        {
            if (!isInitialized)
                Initialize();

            HttpResponseMessage response =
                client.PostAsJsonAsync(prefix + $"chats/{chatId}/changepicture", SerializeImage(pic)).Result;
            if (!response.IsSuccessStatusCode)
                throw new Exception(response.Content.ReadAsStringAsync().Result);
        }
        
        public static void AddMembersToChat(Guid chatId, List<Guid> users)
        {
            if (!isInitialized)
                Initialize();

            HttpResponseMessage response =
                client.PostAsJsonAsync(prefix + $"chats/{chatId}/add", users).Result;
            if (!response.IsSuccessStatusCode)
                throw new Exception(response.Content.ReadAsStringAsync().Result);
        }
        
        public static void CreateChat(Guid userId, List<Guid> users)
        {
            if (!isInitialized)
                Initialize();
            var chat = new ChatOnCreate()
            {
                Title = "Новый чат",
                Members = users.Union(new List<Guid> {userId}),
                Picture = new byte[] {}
            };
            HttpResponseMessage response =
                client.PostAsJsonAsync(prefix + "chats", chat).Result;
            if (!response.IsSuccessStatusCode)
                throw new Exception(response.Content.ReadAsStringAsync().Result);
        }

        #endregion

        #region GET

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

        public static IEnumerable<User> GetChatMembers(Guid chatId)
        {
            if (!isInitialized)
                Initialize();

            HttpResponseMessage response =
                client.GetAsync(prefix + $"chats/{chatId}/users").Result;
            if (response.IsSuccessStatusCode)
                return response.Content.ReadAsAsync<IEnumerable<User>>().Result;
            else
                throw new Exception(response.Content.ReadAsStringAsync().Result);
        }

        public static IEnumerable<Attach> GetChatAttachs(Guid chatId)
        {
            if (!isInitialized)
                Initialize();

            HttpResponseMessage response =
                client.GetAsync(prefix + $"chats/{chatId}/attachs").Result;
            if (response.IsSuccessStatusCode)
                return response.Content.ReadAsAsync<IEnumerable<Attach>>().Result;
            else
                throw new Exception(response.Content.ReadAsStringAsync().Result);
        }
        
        public static Chat GetChat(Guid chatId)
        {
            if (!isInitialized)
                Initialize();

            HttpResponseMessage response =
                client.GetAsync(prefix + $"chats/{chatId}").Result;
            if (response.IsSuccessStatusCode)
                return response.Content.ReadAsAsync<Chat>().Result;
            else
                throw new Exception(response.Content.ReadAsStringAsync().Result);
        }

        #endregion

        #region DELETE

        public static void DeleteChatMembers(Guid chatId, Guid[] users)
        {
            if (!isInitialized)
                Initialize();
            var request = new HttpRequestMessage()
            {
                Content = new StringContent(JsonConvert.SerializeObject(users), Encoding.UTF8, "application/json"),
                Method = HttpMethod.Delete,
                RequestUri = new Uri(client.BaseAddress + prefix + $"chats/{chatId}/del")
            };
            HttpResponseMessage response = client.SendAsync(request).Result;
            if (!response.IsSuccessStatusCode)
                throw new Exception(response.Content.ReadAsStringAsync().Result);
        }

        public static void DeleteChat(Guid chatId)
        {
            if (!isInitialized)
                Initialize();

            HttpResponseMessage response =
                client.DeleteAsync(prefix + $"chats/{chatId}").Result;
            if (!response.IsSuccessStatusCode)
                throw new Exception(response.Content.ReadAsStringAsync().Result);
        }

        #endregion

        #endregion

        #region MessageAPI

        #region POST

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

        #endregion

        #region GET

        public static Model.Message GetMessage(Guid messageId)
        {
            if (!isInitialized)
                Initialize();

            HttpResponseMessage response =
                client.GetAsync(prefix + $"messages/{messageId}").Result;
            if (response.IsSuccessStatusCode)
                return response.Content.ReadAsAsync<Model.Message>().Result;
            else
                throw new Exception(response.Content.ReadAsStringAsync().Result);
        }

        #endregion

        #region DELETE
        
        public static void DeleteMessage(Guid messageId)
        {
            if (!isInitialized)
                Initialize();

            HttpResponseMessage response =
                client.DeleteAsync(prefix + $"messages/{messageId}").Result;
            if (!response.IsSuccessStatusCode)
                throw new Exception(response.Content.ReadAsStringAsync().Result);
        }

        #endregion

        #endregion
    }
}
