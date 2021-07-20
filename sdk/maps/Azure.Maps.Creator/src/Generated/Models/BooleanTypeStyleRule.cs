// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Maps.Creator.Models
{
    /// <summary> The boolean type style rule object. </summary>
    public partial class BooleanTypeStyleRule : StyleObject
    {
        /// <summary> Initializes a new instance of BooleanTypeStyleRule. </summary>
        /// <param name="keyName"> Stateset style key name. Key names are random strings but they should be unique inside style array. </param>
        /// <param name="rules"> Boolean style rules. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> or <paramref name="rules"/> is null. </exception>
        public BooleanTypeStyleRule(string keyName, IEnumerable<BooleanRuleObject> rules) : base(keyName)
        {
            if (keyName == null)
            {
                throw new ArgumentNullException(nameof(keyName));
            }
            if (rules == null)
            {
                throw new ArgumentNullException(nameof(rules));
            }

            Rules = rules.ToList();
            Type = StyleObjectType.BooleanTypeStyleRule;
        }

        /// <summary> Initializes a new instance of BooleanTypeStyleRule. </summary>
        /// <param name="keyName"> Stateset style key name. Key names are random strings but they should be unique inside style array. </param>
        /// <param name="type"> The type of stateset style. </param>
        /// <param name="rules"> Boolean style rules. </param>
        internal BooleanTypeStyleRule(string keyName, StyleObjectType type, IList<BooleanRuleObject> rules) : base(keyName, type)
        {
            Rules = rules;
            Type = type;
        }

        /// <summary> Boolean style rules. </summary>
        public IList<BooleanRuleObject> Rules { get; }
    }
}
