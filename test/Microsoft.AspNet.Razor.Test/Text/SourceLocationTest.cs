﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using Microsoft.AspNet.Razor.Text;
using Microsoft.TestCommon;

namespace Microsoft.AspNet.Razor.Test.Text
{
    public class SourceLocationTest
    {
        [Fact]
        public void ConstructorWithLineAndCharacterIndexSetsAssociatedProperties()
        {
            // Act
            SourceLocation loc = new SourceLocation(0, 42, 24);

            // Assert
            Assert.Equal(0, loc.AbsoluteIndex);
            Assert.Equal(42, loc.LineIndex);
            Assert.Equal(24, loc.CharacterIndex);
        }
    }
}
