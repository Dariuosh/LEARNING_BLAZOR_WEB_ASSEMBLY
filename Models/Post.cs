﻿namespace Models
{
	public class Post : object
	{
		public Post() : base()
		{
		}

		public int Id { get; set; }

		public string Body { get; set; }

		public string Title { get; set; }
	}
}
