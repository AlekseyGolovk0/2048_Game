using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _2048GameWinFormsApp
{
    public class UserManager
    {
        public static string _fileName = "User_Results.json";

        public static List<User> GetAll()
        {
            if (!FileProvider.Exist(_fileName))
            {
                return new List<User>();
            }
            try
            {
                var jsonData = FileProvider.Read(_fileName);
                return JsonSerializer.Deserialize<List<User>>(jsonData) ?? new List<User>();
            }
            catch
            {
                return new List<User>();
            }
        }
        public static void Add(User newUser)
        {
            var users = GetAll();
            users.Add(newUser);

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            var jsonData = JsonSerializer.Serialize(users, options);
            FileProvider.Save(_fileName, jsonData);
        }
    }
}
