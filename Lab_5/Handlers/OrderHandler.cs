using Lab_5.Models;
using Lab_5.Repositories;

namespace Lab_5.Handlers;

public class OrderHandler : Handler
{
    private readonly IRepository _repository;

    public OrderHandler(IRepository repository)
    {
        _repository = repository;
    }

    protected override IRepository GetRepository() => _repository;

    protected override string GetValidationError() => "";

    protected override bool ValidateData(Item oldItem, Item newItem) => true;

    protected override void ProcessIfFailed(Item item)
    {
    }

    protected override Response CreateResponse(Item item)
    => new OrderResponse { Status = "Updated", Code = 200, Json = item.ToString() };

    // Hooks for future use
    protected override void PreValidation(Item item)
    {
    }

    protected override void Initialization()
    {
    }

    protected override void ReleaseConnection()
    {
    }
}
