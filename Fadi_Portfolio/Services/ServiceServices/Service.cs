using AutoMapper;
using Fadi_Portfolio.Data.Repositories.ServiceRepo;
using Fadi_Portfolio.Models;
using System.Linq.Dynamic.Core;

namespace Fadi_Portfolio.Services.ServiceServices
{
    public class Service : IService
    {
        private readonly IServiceRepository _serviceRepository;
        private readonly IMapper _mapper;
        
        public Service(IServiceRepository serviceRepository, IMapper mapper)
        {
            _serviceRepository = serviceRepository;
            _mapper = mapper;
        }

        public async Task<List<ServiceModel>> GetAllAsync()
        {
            var list = await _serviceRepository.GetAllNoTrackingAsync();
            var models = list.Select(x => _mapper.Map<ServiceModel>(x)).ToList();

            return models;
        }

        public async Task<ServiceModel> GetAsync(int id)
        {
            var entity = await _serviceRepository.FindNoTrackingAsync(id);
            if (entity == null)
                throw new Exception("null");

            var model = _mapper.Map<ServiceModel>(entity);
            return model;
        }

        public async Task Create(ServiceModel model)
        {
            if (model.Id > 0)
                throw new Exception("null");

            var entity = _mapper.Map<Entities.Service>(model);
            await _serviceRepository.AddAsync(entity);
        }

        public async Task UpdateAsync(ServiceModel model)
        {
            if(!model.Id.HasValue)
                throw new Exception("null");

            var entity = await _serviceRepository.FindNoTrackingAsync(model.Id.Value);
            if (entity == null)
                throw new Exception("null");

            entity = _mapper.Map<Entities.Service>(model);
            await _serviceRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _serviceRepository.FindAsync(id);
            if (entity == null)
                throw new Exception("null");

            await _serviceRepository.DeleteAsync(entity);

        }




    }
}
