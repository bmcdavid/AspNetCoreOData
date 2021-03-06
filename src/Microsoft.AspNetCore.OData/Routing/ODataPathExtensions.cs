﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.OData.Routing.Template;
using Microsoft.OData.Edm;
using Microsoft.OData.UriParser;

namespace Microsoft.AspNetCore.OData.Routing
{
    /// <summary>
    /// </summary>
    public static class ODataPathExtensions
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static IEdmType GetEdmType(this ODataPath path)
        {
            if (path == null)
            {
                return null;
            }

            ODataPathSegment lastSegment = path.LastSegment;

            EntitySetSegment entitySet = lastSegment as EntitySetSegment;
            if (entitySet != null)
            {
                return entitySet.EdmType;
            }


            // TODO
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static IEdmNavigationSource GetNavigationSource(this ODataPath path)
        {
            if (path == null)
            {
                return null;
            }

            ODataPathSegment lastSegment = path.LastSegment;

            EntitySetSegment entitySet = lastSegment as EntitySetSegment;
            if (entitySet != null)
            {
                return entitySet.EntitySet;
            }

            SingletonSegment singleton = lastSegment as SingletonSegment;
            if (singleton != null)
            {
                return singleton.Singleton;
            }


            // TODO
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="segments"></param>
        /// <returns></returns>
        public static string GetPathString(this IList<ODataPathSegment> segments)
        {
            if (segments == null)
            {
                throw new ArgumentNullException(nameof(segments));
            }

            ODataPathSegmentHandler handler = new ODataPathSegmentHandler();
            foreach (var segment in segments)
            {
                segment.HandleWith(handler);
            }

            return handler.PathLiteral;
        }
    }
}
