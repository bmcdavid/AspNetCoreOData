﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.OData.Routing.Template;
using Microsoft.OData.Edm;

namespace Microsoft.AspNetCore.OData.Routing
{
    internal class ODataHttpMethodMetadata
    {
        public ODataHttpMethodMetadata(params string[] httpMethods)
        {
            Methods = new HashSet<string>(httpMethods, StringComparer.OrdinalIgnoreCase);
        }

        public ISet<string> Methods { get; }
    }

    /// <summary>
    /// Represents OData Endpoint metadata used during routing.
    /// </summary>
    public sealed class ODataRoutingMetadata : IODataRoutingMetadata
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ODataRoutingMetadata"/> class.
        /// </summary>
        /// <param name="prefix">The prefix string.</param>
        /// <param name="model">The Edm model.</param>
        /// <param name="template">The Routing path template.</param>
        public ODataRoutingMetadata(string prefix, IEdmModel model, ODataPathTemplate template)
        {
            Prefix = prefix ?? throw new ArgumentNullException(nameof(prefix));

            Model = model ?? throw new ArgumentNullException(nameof(model));

            Template = template ?? throw new ArgumentNullException(nameof(template));
        }

        /// <summary>
        /// Gets the prefix string.
        /// </summary>
        public string Prefix { get; }

        /// <summary>
        /// Gets the Edm model.
        /// </summary>
        public IEdmModel Model { get; }

        /// <summary>
        /// Gets the OData path template
        /// </summary>
        public ODataPathTemplate Template { get; }
    }
}
