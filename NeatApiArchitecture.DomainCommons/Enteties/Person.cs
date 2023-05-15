using System.ComponentModel.DataAnnotations;

namespace NeatApiArchitecture.DomainCommons.Enteties;

public class Person
{
	public int Id { get; set; }
	public string FirstName { get; set; } = string.Empty;
	public string LastName { get; set; } = string.Empty;
	public int Age { get; set; }
	[EmailAddress]
	public string Email { get; set; } = string.Empty;
	[Phone]
	public string Phone { get; set; } = string.Empty;
	public string? Description { get; set; }
	public DateTime CreatedAt { get; set; }
}