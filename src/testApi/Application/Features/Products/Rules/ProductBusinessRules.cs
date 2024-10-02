using Application.Features.Products.Constants;
using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;

namespace Application.Features.Products.Rules;

public class ProductBusinessRules : BaseBusinessRules
{
    private readonly IProductRepository _productRepository;
    private readonly ILocalizationService _localizationService;

    public ProductBusinessRules(IProductRepository productRepository, ILocalizationService localizationService)
    {
        _productRepository = productRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, ProductsBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task ProductShouldExistWhenSelected(Product? product)
    {
        if (product == null)
            await throwBusinessException(ProductsBusinessMessages.ProductNotExists);
    }

    public async Task ProductIdShouldExistWhenSelected(int id, CancellationToken cancellationToken)
    {
        Product? product = await _productRepository.GetAsync(
            predicate: p => p.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await ProductShouldExistWhenSelected(product);
    }

    public async Task ProductNameShouldNotBeExistWhenInsert(string name, CancellationToken cancellationToken)
    {
        bool checkAny = await _productRepository.AnyAsync(predicate: p => p.Name == name, cancellationToken: cancellationToken);
        if (checkAny)
            await throwBusinessException(ProductsBusinessMessages.ProductNameAlreadyExists);
    }

    public async Task ProductNameShouldNotBeExistWhenUpdate(int id, string name, CancellationToken cancellationToken)
    {
        bool checkAny = await _productRepository.AnyAsync(
            predicate: p => p.Id != id && p.Name == name,
            cancellationToken: cancellationToken
        );
        if (checkAny)
            await throwBusinessException(ProductsBusinessMessages.ProductNameAlreadyExists);
    }
}
