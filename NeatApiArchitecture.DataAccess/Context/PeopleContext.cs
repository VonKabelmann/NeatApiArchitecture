using Microsoft.EntityFrameworkCore;
using NeatApiArchitecture.DomainCommons.Enteties;

namespace NeatApiArchitecture.DataAccess.Context;

public class PeopleContext : DbContext
{
	public PeopleContext(DbContextOptions<PeopleContext> options) : base(options)
	{
	}
	public DbSet<Person> People { get; set; } = null!;
}