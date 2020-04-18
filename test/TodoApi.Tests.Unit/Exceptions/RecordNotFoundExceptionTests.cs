﻿using FluentAssertions;
using TodoApi.Implementations.Exceptions;
using Xunit;

namespace TodoApi.Tests.Unit.Exceptions
{
    public class RecordNotFoundExceptionTests
    {
        [Fact]
        public void WithCustomErrorMessage()
        {
            const string entity = "entity";
            const long key = 1;
            
            // Arrange
            var exception = new RecordNotFoundException(entity: entity, key: key);
            
            // Assert
            exception.Message.Should().Be(expected: $"Entity '{entity}' does not matter with the '{key}' key.");
        }
    }
}