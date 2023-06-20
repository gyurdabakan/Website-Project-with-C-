using System;
using WebSiteProject.Common.DTOs.Issuing;
using WebSiteProject.Core.Services;
using WebSiteProject.Entity.Entities;
using WebSiteProject.Persistance.Abstract;

namespace WebSiteProject.Core.Managers
{
	public class IssuingManager:IIssuingService
	{
        private readonly IIssuingRepository _ıssuingRepository;

		public IssuingManager(IIssuingRepository ıssuingRepository)
		{
            _ıssuingRepository = ıssuingRepository;
		}

        public void AddIssuing(AddIssuingDto dto)
        {
            try
            {

                Issuing ıssuing = new Issuing();
                ıssuing.publisherName = dto.publisherName;
                ıssuing.UpdateDate = dto.UpdateDate;
                ıssuing.IsActive = dto.IsActive;
                ıssuing.CreatedDate = dto.CreateDate;

                _ıssuingRepository.Add(ıssuing);
                _ıssuingRepository.SaveChanges();


            }
            catch (Exception ex)
            {

            }
        }

        public void DeleteIssuing(DeleteIssuingDto dto)
        {
            Issuing ıssuing = new Issuing();
            ıssuing.Id = dto.Id;

            _ıssuingRepository.Delete(ıssuing);
            _ıssuingRepository.SaveChanges();

        }

        public List<IssuingDto> GetAllIssuings()
        {
            List<Issuing> list = _ıssuingRepository.GetAll();

            return list.Select(ıssuing => new IssuingDto()
            {

                Id=ıssuing.Id,
                publisherName=ıssuing.publisherName,
                CreateDate=ıssuing.CreatedDate,
                IsActive=ıssuing.IsActive,
                UpdateDate=ıssuing.UpdateDate,

            }).ToList();
        }

        public IssuingDto GetIssuingById(int id)
        {
            Issuing ıssuing = _ıssuingRepository.Get(id);


            return new IssuingDto()
            {

                Id = ıssuing.Id,
                publisherName = ıssuing.publisherName,
                CreateDate = ıssuing.CreatedDate,
                IsActive = ıssuing.IsActive,
                UpdateDate = ıssuing.UpdateDate,

            };

        }

        public void UpdateIssuing(UpdateIssuingDto dto)
        {
            Issuing ıssuing = new Issuing();
            ıssuing.Id = dto.Id;
            ıssuing.publisherName = dto.publisherName;
            ıssuing.CreatedDate = dto.CreateDate;
            ıssuing.IsActive = dto.IsActive;
            ıssuing.UpdateDate = dto.UpdateDate;

            _ıssuingRepository.Update(ıssuing);
            _ıssuingRepository.SaveChanges();
            

        }
    }
}

