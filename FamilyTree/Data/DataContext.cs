using FamilyTree.Models;
using Microsoft.EntityFrameworkCore;

namespace FamilyTree.Data;

public class DataContext : DbContext
{
	public DataContext(DbContextOptions<DataContext> options) : base(options)
	{

	}

	public DbSet<User> Users { get; set; }
	public DbSet<SocialMedia> SocialMedias { get; set; }
	public DbSet<Address> Addresses { get; set; }
	public DbSet<Family> Families { get; set; }
}