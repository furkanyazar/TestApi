using Application.Features.Products.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Products.Queries.GetById;

public class GetByIdProductQuery : IRequest<GetByIdProductResponse>
{
    public int Id { get; set; }

    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQuery, GetByIdProductResponse>
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        private readonly ProductBusinessRules _productBusinessRules;

        public GetByIdProductQueryHandler(
            IMapper mapper,
            IProductRepository productRepository,
            ProductBusinessRules productBusinessRules
        )
        {
            _mapper = mapper;
            _productRepository = productRepository;
            _productBusinessRules = productBusinessRules;
        }

        public async Task<GetByIdProductResponse> Handle(GetByIdProductQuery request, CancellationToken cancellationToken)
        {
            Product? product = await _productRepository.GetAsync(
                predicate: p => p.Id == request.Id,
                cancellationToken: cancellationToken
            );
            await _productBusinessRules.ProductShouldExistWhenSelected(product);

            GetByIdProductResponse response = _mapper.Map<GetByIdProductResponse>(product);
            return response;
        }
    }
}
