using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerce_API.Data;
using Microsoft.EntityFrameworkCore;

namespace eCommerce_API_RST.Services
{
	public class Seeder
	{
		private readonly rst374_cloud12Context _context;
		private readonly FreightContext _contextf;
		public Seeder(rst374_cloud12Context context,
						FreightContext contextf)
		{
			_context = context;
			_contextf = contextf;
		}

		public async Task Seeding()
		{
			await _context.Database.MigrateAsync();
			await _contextf.Database.MigrateAsync();
		}
	}
}
