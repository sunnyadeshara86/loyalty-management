using LoyaltyManagement.Store.Core.Models;
using MediatR;

namespace LoyaltyManagement.Store.Application.Queries
{
    public record GetAllStoresQuery : IRequest<IEnumerable<StoreModel>>;
    public record GetStoreByIdQuery(int Id) : IRequest<StoreModel>;
}
