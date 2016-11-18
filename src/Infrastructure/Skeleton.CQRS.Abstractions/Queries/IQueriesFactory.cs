﻿namespace Skeleton.CQRS.Abstractions.Queries
{
    /// <summary>
    /// Queries factory interface
    /// </summary>
    public interface IQueriesFactory
    {
        /// <summary>
        /// Method for qsueries creation
        /// </summary>
        /// <typeparam name="TCriterion">Query criterion type</typeparam>
        /// <typeparam name="TResult">Query result type</typeparam>
        /// <returns>Query instance</returns>
        IQuery<TCriterion, TResult> Create<TCriterion, TResult>() where TCriterion : ICriterion;
    }
}