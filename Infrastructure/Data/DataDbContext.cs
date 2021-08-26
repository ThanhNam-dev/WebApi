﻿using Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
	public class DataDbContext : DbContext
	{
		public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
		{

		}
		public DbSet<Product> Products { get; set; }
	}
}