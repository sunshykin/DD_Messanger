using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ChatterBox.Model;

namespace ChatterBox.Client.WinForms.Helpers
{
    public class AuthSerializationHelper
    {
        private string _login;
        private string _password;
        private string _path;
        private readonly byte[] _aditionalEntropy;
        
        public AuthSerializationHelper()
        {
            _path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\ChatterBox\\Settings\\";
            _aditionalEntropy = new byte[] { 1, 2, 94, 54, 161, 204, 4, 199 };
        }

        public void Save(string login, string password)
        {
            _login = login;
            _password = password;
            Serialize();
        }

        public Auth Load()
        {
            return Deserialize();
        }

        private void Serialize()
        {
            if (!Directory.Exists(_path))
                Directory.CreateDirectory(_path);
            XmlSerializer formatter = new XmlSerializer(typeof(Auth));
            using (FileStream fs = new FileStream(_path + "AuthInfo.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, new Auth {Login = _login, Password = Protect(_password)});
            }
        }

        private string Protect(string pass)
        {
            var bytes = Encoding.Unicode.GetBytes(pass);
            var protetcedBytes = ProtectedData.Protect(bytes, _aditionalEntropy, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(protetcedBytes);
        }

        private Auth Deserialize()
        {
            Auth temp;
            XmlSerializer formatter = new XmlSerializer(typeof(Auth));
            using (FileStream fs = new FileStream(_path + "AuthInfo.xml", FileMode.OpenOrCreate))
            {
                temp = formatter.Deserialize(fs) as Auth;
            }
            return new Auth() {Login = temp.Login, Password = Unprotect(temp.Password)};
        }

        private string Unprotect(string pass)
        {
            var bytes = Convert.FromBase64String(pass);
            var unprotetcedBytes = ProtectedData.Unprotect(bytes, _aditionalEntropy, DataProtectionScope.CurrentUser);
            return Encoding.Unicode.GetString(unprotetcedBytes);
        }
    }
}
