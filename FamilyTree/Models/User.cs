using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

namespace FamilyTree.Models;

public class User
{
	public int Id { get; set; }
	public string FirstName { get; set; }
	public string MiddleName { get; set; }
	public string LastName { get; set; }
	public string EmailAddress { get; set; }
	public string Password { get; set; }
	public string Role { get; set; }
	public int MobileNumber { get; set; }
	public DateTime Birthday { get; set; }
	public string CivilStatus { get; set; }
	public string CreatedBy { get; set; }
	public DateTime CreatedOn { get; set; }
	public string UpdatedBy { get; set; }
	public DateTime UpdatedOn { get; set; }
	public bool IsActive { get; set; }
	public List<SocialMedia> SocialMedia { get; set; }
}