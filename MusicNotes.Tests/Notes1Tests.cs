using System;
using System.Collections.Generic;
using System.Text;
using MusicNotes.Models;
using Xunit;

namespace MusicNotes.Tests
{
    public class Notes1Tests
    {
        [Fact]
        public void TestAdd_OK()
        {
            //Arrange
            Notes1 notes1 = new Notes1(4);

            //Act
            notes1.Add(1);

            notes1.Add(2);
            notes1.Add(2);

            notes1.Add(4);
            notes1.Add(4);
            notes1.Add(4);
            notes1.Add(8);
            notes1.Add(8);

            notes1.Add(2);
            notes1.Add(8);
            notes1.Add(8);
            notes1.Add(8);
            notes1.Add(16);
            notes1.Add(16);

            //Assert
            Assert.Equal("1 2 2 4 4 4 8 8 2 8 8 8 16 16", notes1.Write());
        }

        [Fact]
        public void TestAdd_quantity_exeption()
        {
            //Arrange
            Notes1 notes1 = new Notes1(5);

            //Act&Assert
            var ex = Assert.Throws<Exception>(() => notes1.Add(3));
            Assert.Equal("Размер ноты может быть равен: 1, 2, 4, 8, 16", ex.Message);
            
        }

        [Fact]
        public void TestAdd_quantity_exeption1()
        {
            //Arrange
            Notes1 notes1 = new Notes1(1);

            //Act
            notes1.Add(2);

            //Act&Assert
            var ex = Assert.Throws<Exception>(() => notes1.Add(1));
            Assert.Equal("Не хватает места для ноты", ex.Message);

        }

        [Fact]
        public void TestAdd_quantity_exeption2()
        {
            //Arrange
            Notes1 notes1 = new Notes1(1);

            //Act
            notes1.Add(2);
            notes1.Add(4);

            //Act&Assert
            var ex = Assert.Throws<Exception>(() => notes1.Add(2));
            Assert.Equal("Не хватает места для ноты", ex.Message);

        }

        [Fact]
        public void TestAdd_quantity_exeption4()
        {
            //Arrange
            Notes1 notes1 = new Notes1(1);

            //Act
            notes1.Add(2);
            notes1.Add(4);
            notes1.Add(8);

            //Act&Assert
            var ex = Assert.Throws<Exception>(() => notes1.Add(4));
            Assert.Equal("Не хватает места для ноты", ex.Message);

        }

        [Fact]
        public void TestAdd_quantity_exeption8()
        {
            //Arrange
            Notes1 notes1 = new Notes1(1);

            notes1.Add(2);
            notes1.Add(4);
            notes1.Add(8);
            notes1.Add(16);

            //Act&Assert
            var ex = Assert.Throws<Exception>(() => notes1.Add(8));
            Assert.Equal("Не хватает места для ноты", ex.Message);

        }

        [Fact]
        public void TestAdd_quantity_exeption16()
        {
            //Arrange
            Notes1 notes1 = new Notes1(1);

            notes1.Add(2);
            notes1.Add(4);
            notes1.Add(8);
            notes1.Add(16);
            notes1.Add(16);

            //Act&Assert
            var ex = Assert.Throws<Exception>(() => notes1.Add(16));
            Assert.Equal("Нота не помещается", ex.Message);
        }
    }
}
