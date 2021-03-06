﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.OData.E2E.Tests.Commons
{
    /// <summary>
    /// Helper class for generating test data for XUnit's <see cref="TheoryDataSet"/>-based tests.
    /// </summary>
    /// <typeparam name="TParam">First parameter type</typeparam>
    public class TheoryDataSet<TParam> : TheoryDataSet
    {
        public void Add(TParam p)
        {
            AddItem(p);
        }
    }

    /// <summary>
    /// Helper class for generating test data for XUnit's <see cref="TheoryDataSet"/>-based tests.
    /// </summary>
    /// <typeparam name="TParam1">First parameter type</typeparam>
    /// <typeparam name="TParam2">Second parameter type</typeparam>
    public class TheoryDataSet<TParam1, TParam2> : TheoryDataSet
    {
        public void Add(TParam1 p1, TParam2 p2)
        {
            AddItem(p1, p2);
        }
    }

    /// <summary>
    /// Helper class for generating test data for XUnit's <see cref="TheoryDataSet"/>-based tests.
    /// </summary>
    /// <typeparam name="TParam1">First parameter type</typeparam>
    /// <typeparam name="TParam2">Second parameter type</typeparam>
    /// <typeparam name="TParam3">Third parameter type</typeparam>
    public class TheoryDataSet<TParam1, TParam2, TParam3> : TheoryDataSet
    {
        public void Add(TParam1 p1, TParam2 p2, TParam3 p3)
        {
            AddItem(p1, p2, p3);
        }
    }

    /// <summary>
    /// Helper class for generating test data for XUnit's <see cref="TheoryDataSet"/>-based tests.
    /// </summary>
    /// <typeparam name="TParam1">First parameter type</typeparam>
    /// <typeparam name="TParam2">Second parameter type</typeparam>
    /// <typeparam name="TParam3">Third parameter type</typeparam>
    /// <typeparam name="TParam4">Fourth parameter type</typeparam>
    public class TheoryDataSet<TParam1, TParam2, TParam3, TParam4> : TheoryDataSet
    {
        public void Add(TParam1 p1, TParam2 p2, TParam3 p3, TParam4 p4)
        {
            AddItem(p1, p2, p3, p4);
        }
    }

    /// <summary>
    /// Helper class for generating test data for XUnit's <see cref="TheoryDataSet"/>-based tests.
    /// </summary>
    /// <typeparam name="TParam1">First parameter type</typeparam>
    /// <typeparam name="TParam2">Second parameter type</typeparam>
    /// <typeparam name="TParam3">Third parameter type</typeparam>
    /// <typeparam name="TParam4">Fourth parameter type</typeparam>
    /// <typeparam name="TParam5">Fifth parameter type</typeparam>
    public class TheoryDataSet<TParam1, TParam2, TParam3, TParam4, TParam5> : TheoryDataSet
    {
        public void Add(TParam1 p1, TParam2 p2, TParam3 p3, TParam4 p4, TParam5 p5)
        {
            AddItem(p1, p2, p3, p4, p5);
        }
    }
}
