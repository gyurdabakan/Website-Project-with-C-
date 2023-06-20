using System;
using WebSiteProject.Common.DTOs.Issuing;

namespace WebSiteProject.Core.Services
{
	public interface IIssuingService
	{

		void AddIssuing(AddIssuingDto dto);
		void UpdateIssuing(UpdateIssuingDto dto);
		void DeleteIssuing(DeleteIssuingDto dto);
		IssuingDto GetIssuingById(int id);
		List<IssuingDto> GetAllIssuings();

		
	}
}

