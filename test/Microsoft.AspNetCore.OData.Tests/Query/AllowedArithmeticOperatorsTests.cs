﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.OData.Query;
using Xunit;

namespace Microsoft.AspNetCore.OData.Tests.Query
{
    public class AllowedArithmeticOperatorsTests
    {
        [Fact]
        public void None_MatchesNone()
        {
            Assert.Equal(AllowedArithmeticOperators.None, AllowedArithmeticOperators.All & AllowedArithmeticOperators.None);
        }

        [Fact]
        public void All_Contains_AllArithmeticOperators()
        {
            AllowedArithmeticOperators allArithmeticOperators = 0;
            foreach (AllowedArithmeticOperators allowedArithmeticOperator in Enum.GetValues(typeof(AllowedArithmeticOperators)))
            {
                if (allowedArithmeticOperator != AllowedArithmeticOperators.All)
                {
                    allArithmeticOperators |= allowedArithmeticOperator;
                }
            }

            Assert.Equal(AllowedArithmeticOperators.All, allArithmeticOperators);
        }
    }
}
