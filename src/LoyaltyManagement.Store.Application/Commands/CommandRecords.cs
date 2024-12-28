using LoyaltyManagement.Store.Core.Models;
using MediatR;

namespace LoyaltyManagement.Store.Application.Commands
{
    public record CreateStoreCommand(StoreModel Store) : IRequest;
    public record UpdateStoreCommand(StoreModel Store) : IRequest;
    public record DeleteStoreCommand(int Id) : IRequest;
}
