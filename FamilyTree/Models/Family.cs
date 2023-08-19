namespace FamilyTree.Models;

public class Family
{
	public int Id { get; set; }
	public string FamilyName { get; set; }
	public string Role { get; set; }
	public int CreatedBy { get; set; }
	public int UpdatedBy { get; set; }
	public DateTime CreatedOn { get; set; }
	public DateTime UpdatedOn { get; set; }
	public bool IsActive { get; set; }
	public List<User> Users { get; set; }
}