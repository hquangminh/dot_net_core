﻿using System.ComponentModel.DataAnnotations;


namespace MyMvcApp.Models
{
	public class Category
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		public int DisplayOrder { get; set; }
		public DateTime dateTime { get; set; } = DateTime.Now;

	}
}

