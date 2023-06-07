using System;
namespace WebSiteProject.Entity.Entities
{
	public class Issuing : BaseEntity
	{
		public string publisherName { get; set; }



		public Issuing()
		{
		}

		public Issuing(int id,string publisherName , DateTime? publishedAt)
		{

			Id = id;
			publisherName = publisherName;
			publishedAt = publishedAt;


		}
	}
}

