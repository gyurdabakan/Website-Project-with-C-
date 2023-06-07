using System;
namespace WebSiteProject.Entity.Entities
{
	public class BaseEntity :IEntity
	{
	
		public int Id { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime UpdateDate { get; set; }
		public bool IsActive { get; set; }


		public BaseEntity()
		{
		}

        public BaseEntity(int id) : this() => Id = id;
    }
}

