using Domain.Entities;
using MediatR;

namespace Application.Features.Brands.Commands.Create;

public class CreateBrandCommand : IRequest<CreatedBrandResponse>
{
    public string Name { get; set; } = string.Empty;

    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreatedBrandResponse>
    {
        private readonly IBrandRepository _brandRepository;

        public CreateBrandCommandHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<CreatedBrandResponse>? Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            Brand brand = new();
            brand.Name = request.Name;
            brand.Id = Guid.NewGuid();
            
            var result = await _brandRepository.AddAsync(brand);
            
            CreatedBrandResponse createdBrandResponse = new()
            {
                Id = brand.Id,
                Name = brand.Name
            };

            return createdBrandResponse;
        }
    }
}