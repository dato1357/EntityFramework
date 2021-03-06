// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.EntityFrameworkCore.FunctionalTests;
using Microsoft.EntityFrameworkCore.Internal;
using Xunit;

namespace Microsoft.EntityFrameworkCore.InMemory.FunctionalTests
{
    public class InheritanceInMemoryTest : InheritanceTestBase<InheritanceInMemoryFixture>
    {
        public override void Discriminator_used_when_projection_over_derived_type2()
        {
            Assert.Equal(
                CoreStrings.PropertyNotFound("Discriminator", "Bird"),
                Assert.Throws<InvalidOperationException>(() =>
                    base.Discriminator_used_when_projection_over_derived_type2()).Message);
        }

        public InheritanceInMemoryTest(InheritanceInMemoryFixture fixture)
            : base(fixture)
        {
        }
    }
}
