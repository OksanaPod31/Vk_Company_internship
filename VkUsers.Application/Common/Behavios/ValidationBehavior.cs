﻿using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkUsers.Application.Common.Behavios
{
    public class ValidationBehavior<TRequest, TResponse> :
       IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }
        public Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next,
            CancellationToken cancellationToken)
        {
            var context = new ValidationContext<TRequest>(request);
            var failrules = _validators
                .Select(v => v.Validate(context))
                .SelectMany(result => result.Errors)
                .Where(failrule => failrule != null)
                .ToList();
            if (failrules.Count != 0)
            {
                throw new ValidationException(failrules);
            }
            return next();


        }


    }
}
