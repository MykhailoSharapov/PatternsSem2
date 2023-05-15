using Lab_5.Models;
using Lab_5.Repositories;

namespace Lab_5.Handlers
{
    public abstract class Handler
    {
        protected abstract IRepository GetRepository();
        protected abstract Response CreateResponse(Item item);
        protected abstract string GetValidationError();
        protected abstract bool ValidateData(Item oldItem, Item newItem);
        protected abstract void ProcessIfFailed(Item item);
        protected abstract void PreValidation(Item item);
        protected abstract void Initialization();
        protected abstract void ReleaseConnection();

        public Response Handle(Item item)
        {
            Initialization();

            var repository = GetRepository();
            var oldItem = repository.Get(item.Id);

            PreValidation(item);

            bool isValid = ValidateData(oldItem, item);

            if (!isValid)
            {
                ProcessIfFailed(item);
                return new Response
                {
                    Code = 400,
                    Status = GetValidationError()
                };
            }

            var newItem = repository.Update(item);

            ReleaseConnection();

            return CreateResponse(newItem);
        }
    }
}
