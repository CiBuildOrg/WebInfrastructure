﻿namespace Web.Domain.Criteria
{
    using Skeleton.CQRS.Abstractions.Queries;

    public class GetValueQueryCriterion : ICriterion<string>
    {
        public int Key { get; }

        public GetValueQueryCriterion(int key)
        {
            Key = key;
        }
    }
}