﻿using System;
using FluentAssertions;
using Xunit;

namespace TDD.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData("", 0)]
        [InlineData("1", 1)]
        [InlineData("1,2", 3)]

        public void Add_AddsUpTwoNumber_WhenStringIsValid(string calculation, int expected)
        {

            //Arrange
            var sut = new Calculator();

            //Act
            var result = sut.Add(calculation);

            //Assert
            result.Should().Be(expected);

        }

        [Theory]
        [InlineData("1,2,3", 6)]
        [InlineData("10,90,10,20", 130)]
        public void Add_AddsUpToAnyNumber_WhenStringIsValid(string calculation, int expected)
        {

            //Arrange
            var sut = new Calculator();

            //Act
            var result = sut.Add(calculation);

            //Assert
            result.Should().Be(expected);

        }
    }
}
