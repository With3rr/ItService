﻿using FluentValidation;

namespace ITService.Domain.Query.ShoppingCart
{
    class SearchShoppingCartsQueryValidator : AbstractValidator<SearchShoppingCartsQuery>
    {
        public SearchShoppingCartsQueryValidator()
        {
            RuleFor(x => x)
                .Custom((value, context) =>
                {
                    if (value.PageNumber <= 0)
                    {
                        context.AddFailure("PageNumber", "Page number must be greater than 0.");
                    }

                    if (value.PageSize <= 0)
                    {
                        context.AddFailure("PageSize", "Page size must be greater than 0.");
                    }
                });
        }
    }
}
