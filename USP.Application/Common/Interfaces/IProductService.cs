using USP.Domain.Entities;

namespace USP.Application.Common.Interfaces;

public interface IProductService
{
    Task<List<Domain.Entities.Product>> GetAllProductsAsync(CancellationToken cancellationToken);
}