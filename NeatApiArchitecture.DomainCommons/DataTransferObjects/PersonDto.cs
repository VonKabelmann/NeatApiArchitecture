namespace NeatApiArchitecture.DomainCommons.DataTransferObjects;

//A record matching Person
public record PersonDto(
			int Id,
			string FirstName,
			string LastName,
			int Age,
			string Email,
			string Phone,
			string? Description,
			DateTime CreatedAt
		);