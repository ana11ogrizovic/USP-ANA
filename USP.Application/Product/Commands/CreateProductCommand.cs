
using MongoDB.Entities;
using MediatR;
using USP.Application.Common.Dto;
using USP.Application.Common.Mappers;
using USP.Domain.Entities;
using USP.Domain.Enums;
using ProductDetailsDto = USP.Application.Common.Dto.ProductDetailsDto;

namespace USP.Application.Product.Commands;
public record CreateProductCommand(ProductCreateDto Product) : IRequest<string>, IRequest<ProductDetailsDto>;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ProductDetailsDto>
{        public async Task<ProductDetailsDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {


        var userEntity = new User
        {
            Email = "hhhh",
            FirstName = "hhhh",
            LastName = "hhhh",
        };

        await userEntity.SaveAsync(cancellation: cancellationToken);
        
        var entity = request.Product.ToEntitiyFromCreateDto(userEntity, new One<User>(userEntity));
        await entity.SaveAsync(cancellation:cancellationToken);
        var dto = entity.ToDto();
        return dto;
    }
    
}