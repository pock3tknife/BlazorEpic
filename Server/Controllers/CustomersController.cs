using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Serialization.Formatters.Binary;
using BlazorEpic.Shared;

namespace BlazorEpic.Server.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CustomersController : ControllerBase
	{
		private static byte[] ObjectToBytes(object obj)
		{
			BinaryFormatter bf = new BinaryFormatter();
			using (var ms = new MemoryStream())
			{
				bf.Serialize(ms, obj);
				return ms.ToArray();
			}
		}
		private static object BytesToObject(byte[] bytes)
		{
			try
			{
				using (MemoryStream ms = new System.IO.MemoryStream(bytes))
				{
					BinaryFormatter bf = new BinaryFormatter();
					ms.Position = 0;
					return bf.Deserialize(ms);
				}
			}
			catch { return null; }
		}
		private string DataFolder { get; }
		private IWebHostEnvironment env { get; }
		public CustomersController(IWebHostEnvironment env)
		{
			this.env = env;
			DataFolder = env.ContentRootPath + "\\CustomersData";
			try
			{
				if (!System.IO.Directory.Exists(DataFolder))
					System.IO.Directory.CreateDirectory(DataFolder);
			}
			catch { }
		}

		[HttpPut("{id}")]
		public async Task<Customer> Put(string id, [FromBody] Customer cust)
		{
			return await Task.Run(() =>
			{
				try
				{
					cust.id = id;
					System.IO.File.WriteAllBytes(DataFolder + '\\' + id + ".bin", ObjectToBytes(cust));
					return cust;
				}
				catch { return null; }
			});
		}

		[HttpPatch("{id}")]
		public async Task<Customer> Patch(string id, [FromBody] Customer update)
		{
			return await Task.Run(() =>
			{
				var ip = HttpContext.Connection.RemoteIpAddress.ToString().Replace(':', '-');
				try
				{
					var cust = (Customer)BytesToObject(System.IO.File.ReadAllBytes(DataFolder + '\\' + ip + '-' + id + ".bin"));
					cust.name = (update.name == null) ? cust.name : update.name;
					cust.address = (update.address == null) ? cust.address : update.address;
					cust.zip = (update.zip == null) ? cust.zip : update.zip;
					System.IO.File.WriteAllBytes(DataFolder + '\\' + ip + '-' + id + ".bin", ObjectToBytes(cust));
					return cust;
				}
				catch { return null; }
			});
		}

		[HttpDelete("{id}")]
		public async Task<Customer> Delete(string id)
		{
			return await Task.Run(() =>
			{
				var di = new DirectoryInfo(DataFolder);
				try
				{
					string file = DataFolder + '\\' + id + ".bin";
					var cust = (Customer)BytesToObject(System.IO.File.ReadAllBytes(file));
					System.IO.File.Delete(file);
					return cust;
				}
				catch { return null; }
			});
		}

		[HttpPost]
		public async Task<Customer> Post([FromBody] Customer cust)
		{
			return await Task.Run(() =>
			{
				var di = new DirectoryInfo(DataFolder);
				string id = Guid.NewGuid().ToString("N");
				cust.id = id;
				if (cust.name == null)
					cust.name = string.Empty;
				else
					cust.name = cust.name.Substring(0, cust.name.Length > 100 ? 100 : cust.name.Length);
				if (cust.address == null)
					cust.address = string.Empty;
				else
					cust.address = cust.address.Substring(0, cust.address.Length > 100 ? 100 : cust.address.Length);
				if (cust.zip == null)
					cust.zip = string.Empty;
				else
					cust.zip = cust.zip.Substring(0, cust.zip.Length > 10 ? 10 : cust.zip.Length);
				try
				{
					System.IO.File.WriteAllBytes(DataFolder + '\\' + id + ".bin", ObjectToBytes(cust));
					return cust;
				}
				catch { return null; }
			});
		}

		[HttpGet]
		public async Task<IEnumerable<Customer>> Get()
		{
			return await Task.Run(() =>
			{
				var di = new DirectoryInfo(DataFolder);
				FileInfo[] fi = di.GetFiles("*", SearchOption.TopDirectoryOnly);
				var q = from f in fi orderby f.CreationTime descending select f;
				var custs = new List<Customer>();
				for (int i = 0; i < fi.Length; i++)
					custs.Add((Customer)BytesToObject(System.IO.File.ReadAllBytes(fi[i].FullName)));
				return custs;
			});
		}

		[HttpGet("{id}")]
		public async Task<Customer> Get(string id)
		{
			return await Task.Run(() =>
			{
				var di = new DirectoryInfo(DataFolder);
				try
				{
					return (Customer)BytesToObject(System.IO.File.ReadAllBytes(DataFolder + '\\' + id + ".bin"));
				}
				catch { return null; }
			});
		}
	}
}