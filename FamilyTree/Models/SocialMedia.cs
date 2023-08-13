namespace FamilyTree.Models;

public class SocialMedia
{
	public int Id { get; set; }
	public string Platform { get; set; }
	public int CreatedBy { get; set; }
	public DateTime CreatedOn { get; set; }
	public int UpdatedBy { get; set; }
	public DateTime UpdatedOn { get; set; }
	public bool IsActive { get; set; }
	public User User { get; set; }
	public int UserId { get; set; }
}
