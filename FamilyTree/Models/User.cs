﻿using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace FamilyTree.Models;

public class User
{
	public int Id { get; set; }
	[Required]
	public string FirstName { get; set; }
	public string MiddleName { get; set; }
	public string LastName { get; set; }
	public string EmailAddress { get; set; }
	public string Password { get; set; }
	public string Role { get; set; }
	public string MobileNumber { get; set; }
	public DateTime Birthday { get; set; }
	public string CivilStatus { get; set; }
	public int CreatedBy { get; set; }
	public DateTime CreatedOn { get; set; }
	public int UpdatedBy { get; set; }
	public DateTime UpdatedOn { get; set; }
	public bool IsActive { get; set; }
	public List<SocialMedia> SocialMedia { get; set; }
	public Address Address { get; set; }
	public List<Family> Families { get; set; }
}