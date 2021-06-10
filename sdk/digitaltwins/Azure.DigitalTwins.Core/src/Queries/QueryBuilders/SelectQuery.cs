﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Globalization;
using Azure.DigitalTwins.Core.Queries.QueryBuilders;
using System.Collections.Generic;
using System.Text;

namespace Azure.DigitalTwins.Core.QueryBuilder
{
    /// <summary>
    /// Query object without any clauses.
    /// </summary>
    public sealed class SelectQuery : QueryBase
    {
        private readonly FromQuery _delegationClause;
        private readonly AdtQueryBuilder _parent;
        private SelectClause _clause;

        /// <summary>
        /// Initializes a new instance of this class.
        /// </summary>
        internal SelectQuery(AdtQueryBuilder parent, FromQuery upstreamFromQuery)
        {
            _parent = parent;
            _delegationClause = upstreamFromQuery;
        }

        /// <summary>
        /// Used to add a select clause (and its corresponding argument) to the query.
        /// </summary>
        /// <param name="args"> The arguments that define what we select (e.g., *). </param>
        /// <returns> Query that contains a select clause. </returns>
        public FromQuery Select(params string[] args)
        {
            _clause = new SelectClause(args);
            return _delegationClause;
        }

        /// <summary>
        /// Used when applying the <see href="https://docs.microsoft.com/en-us/azure/digital-twins/reference-query-clause-select#select-top">TOP()</see> aggregate from the ADT query language. Same functionality as select
        /// but inserts TOP() into the query structure as well.
        /// </summary>
        /// <param name="count"> The argument for TOP(), ie the number of instances to return. </param>
        /// <param name="args"> The arguments that can be optionally passed with top (e.g., property name). </param>
        /// <returns> Query that contains a select clause. </returns>
        public FromQuery SelectTop(int count, params string[] args)
        {
            // turn into correct format -- eg. SELECT TOP(3)
            StringBuilder topArg = new StringBuilder().Append($"{QueryConstants.Top}({count})").Append(' ');

            // append optional arguments separated by commas
            topArg.Append(string.Join(", ", args));

            _clause = new SelectClause(new string[] { topArg.ToString() });
            return _delegationClause;
        }

        /// <summary>
        /// Used when applying the <see href="https://docs.microsoft.com/en-us/azure/digital-twins/reference-query-clause-select#select-count">COUNT()</see> aggregate from the ADT query language.
        /// </summary>
        /// <returns> Query that contains a select clause. </returns>
        public FromQuery SelectCount()
        {
            string countArg = $"{QueryConstants.Count}() ";

            _clause = new SelectClause(new string[] { countArg });
            return _delegationClause;
        }

        /// <summary>
        /// Used when overriding the query builder with the literal query string.
        /// </summary>
        /// <param name="literalQuery"> Query in string format. </param>
        /// <returns> Query that contains a select clause. </returns>
        public FromQuery SelectOverride(string literalQuery)
        {
            // TODO -- just use select?
            // approach 1 - method overload
            // approach 2 - seperate method
            _clause = new SelectClause(new string[] { literalQuery });

            return _delegationClause;
        }

        /// <inheritdoc/>
        public override AdtQueryBuilder Build()
        {
            // Build can only be called on queries that have (at minimum) SELECT and FROM clauses
            throw new InvalidOperationException("Queries that contain just a SELECT statement are not valid.");
        }

        /// <inheritdoc/>
        public override string Stringify()
        {
            var selectComponents = new StringBuilder();
            selectComponents.Append(QueryConstants.Select).Append(' ');
            selectComponents.Append(string.Join(", ", _clause.ClauseArgs));

            return selectComponents.ToString().Trim();
        }
    }
}
