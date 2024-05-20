using AutoMapper;
using Restaurant.Core.Application.Interfaces.Repositories;
using Restaurant.Core.Application.Interfaces.Services;

namespace Restaurant.Core.Application.Services
{
    public class GenericService<SaveViewModel, ViewModel, Model> : IGenericService<SaveViewModel, ViewModel, Model>
    where SaveViewModel : class
    where ViewModel : class
    where Model : class
    {
        private readonly IGenericRepository<Model> _repository;
        private readonly IMapper _mapper;
        public GenericService(IGenericRepository<Model> repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public virtual async Task Update(SaveViewModel viewModel, int id)
        {
            Model entity = _mapper.Map<Model>(viewModel);
            await _repository.UpdateAsync(entity, id);
        }

        public virtual async Task<List<ViewModel>> GetAllViewModel()
        {
            var entitylist = await _repository.GetAllAsync();

            return _mapper.Map<List<ViewModel>>(entitylist);
        }

        public virtual async Task<SaveViewModel> Add(SaveViewModel viewModel)
        {
            Model entity = _mapper.Map<Model>(viewModel);
            entity = await _repository.AddAsync(entity);
            SaveViewModel Savevm = _mapper.Map<SaveViewModel>(entity);
            return Savevm;
        }


        public virtual async Task<SaveViewModel> GetByIdSaveViewModel(int id)
        {
            Model entity = await _repository.GetById(id);

            SaveViewModel Savevm = _mapper.Map<SaveViewModel>(entity);
            return Savevm;
        }

        public virtual async Task Delete(int id)
        {
            var entity = await _repository.GetById(id);
            await _repository.DeleteAsync(entity);
        }
    }
}
