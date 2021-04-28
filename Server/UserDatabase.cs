using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlazorEpic.Server
{
	public class User
	{
		public string Email { get; }
		public User(string email)
		{
			Email = email;
		}
	}
	public interface IUserDatabase
	{
		Task<User> AuthenticateUser(string email, string password);
		Task<User> AddUser(string email, string password);
	}
	public class UserDatabase : IUserDatabase
	{
		private readonly IWebHostEnvironment env;
		public UserDatabase(IWebHostEnvironment env) => this.env = env;
		private static string CreateHash(string password)
		{
			var salt = "997eff51db1544c7a3c2ddeb2053f052";
			var md5 = new HMACMD5(Encoding.UTF8.GetBytes(salt + password));
			byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
			password = string.Empty;
			foreach (var x in data)
				password += x.ToString("X2");
			return password;
		}
		public async Task<User> AuthenticateUser(string email, string password)
		{
			return await Task.Run(() =>
			{
				if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
					return null;
				var path = env.ContentRootPath + "\\Users";
				if (!System.IO.Directory.Exists(path))
					return null;
				path += '\\' + email;
				if (!System.IO.File.Exists(path))
					return null;
				if (System.IO.File.ReadAllText(path) != CreateHash(password))
					return null;
				return new User(email);
			});
		}
		public async Task<User> AddUser(string email, string password)
		{
			return await Task.Run(() =>
			{
				try
				{
					if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
						return null;
					var path = env.ContentRootPath + "\\Users"; // THIS WILL CREATE THE "USERS" FOLDER IN THE PROJECT'S FOLDER!!!
					if (!System.IO.Directory.Exists(path))
						System.IO.Directory.CreateDirectory(path);
					path += '\\' + email;
					if (System.IO.File.Exists(path))
						return null;
					System.IO.File.WriteAllText(path, CreateHash(password));
					return new User(email);
				}
				catch
				{
					return null;
				}
			});
		}
	}
}
