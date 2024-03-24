using HouseRentingSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Infrastructure.Common
{
	// We decide to create this because if there is any change (not using Entity Framework or other) then we have to change only this file (the context is here!).
	// This is upper level of abstraction.
	// This is Unit of Work pattern.
	public class Repository : IRepository // when they are created its good to be included in IoC container through ServiceCollectionExtension.cs`
	{
		private readonly DbContext context;

        public Repository(ApplicationDbContext context)
        {
            this.context = context;
        }

		private DbSet<T> DbSet<T>() where T : class // make method which return specific table
		{
			return context.Set<T>();
		}

        public IQueryable<T> All<T>() where T : class
		{
			return DbSet<T>();  // this method return DbSet ready
		}

		public IQueryable<T> AllReadOnly<T>() where T : class
		{
			return DbSet<T>().AsNoTracking(); // this method return DbSet ready without tracking
		}
	}
}
