﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfEx
{
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Infrastructure;

	public partial class WpfExEntities : DbContext
	{
		private static WpfExEntities _context;
		public WpfExEntities()
			: base("name=WpfExEntities")
		{
		}

		public static WpfExEntities GetContext()
		{
			if (_context == null)
				_context = new WpfExEntities();
			return _context;
		}


		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			throw new UnintentionalCodeFirstException();
		}

		public virtual DbSet<User> User { get; set; }
	}
}
