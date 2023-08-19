namespace FamilyTree.Models;

public class Address
{
	public int Id { get; set; }
	public string Block { get; set; }
	public string Lot { get; set; }
	public string UnitNumber { get; set; }
	public string Street { get; set; }
	public string Subdivision { get; set; }
	public string Barangay { get; set; }
	public string City { get; set; }
	public string Province { get; set; }
	public string ZipCode { get; set; }
	public int CreatedBy { get; set; }
	public int UpdatedBy { get; set; }
	public DateTime CreatedOn { get; set; }
	public DateTime UpdatedOn { get; set; }
	public bool IsActive { get; set; }
	public int UserId { get; set; }
	public User User { get; set; }
}