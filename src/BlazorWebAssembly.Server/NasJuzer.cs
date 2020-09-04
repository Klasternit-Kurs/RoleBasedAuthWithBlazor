using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Server
{
	public class NasJuzer : IdentityUser
	{
		public string Bla { get; set; }
	}
	public class DrugiJuzer : IdentityUser
	{
		public int NestoNesto { get; set; }
	}
}
