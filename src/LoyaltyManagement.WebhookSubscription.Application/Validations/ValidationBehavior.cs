﻿using FluentValidation;
using MediatR;

namespace LoyaltyManagement.WebhookSubscription.Application.Validations
{
    public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var context = new ValidationContext<TRequest>(request);

            var validationResults = _validators
                .Select(v => v.Validate(context))
                .Where(r => !r.IsValid)
                .ToList();

            if (validationResults.Any())
            {
                var errors = validationResults
                    .SelectMany(r => r.Errors)
                    .Where(f => f != null)
                    .ToList();

                throw new ValidationException("Invalid request", errors);
            }

            return await next();
        }
    }
}
