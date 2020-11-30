using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using WebLabsV06.DAL.Entities;
using WebLabsV06.Models;
using Xunit;

namespace WebLabsV06.Tests
{
    public class ListViewModelTests
    {
        [Fact]
        public void ListViewModelCountsPages()
        {
            // Act
            var model = ListViewModel<Dish>.GetModel(TestData.GetDishesList(), 1, 3, d => true);

            // Assert
            Assert.Equal(2, model.TotalPages);
        }
        [Theory]
        [MemberData(memberName: nameof(TestData.Params), MemberType = typeof(TestData))]
        public void ListViewModelSelectsCorrectQty(int page, int qty, int id)
        {
            // Act
            var model = ListViewModel<Dish>.GetModel(TestData.GetDishesList(), page, 3, d => true);

            // Assert
            Assert.Equal(qty, model.Count);
        }
        [Theory]
        [MemberData(memberName: nameof(TestData.Params), MemberType = typeof(TestData))]
        public void ListViewModelHasCorrectData(int page, int qty, int id)
        {
            // Act
            var model = ListViewModel<Dish>.GetModel(TestData.GetDishesList(), page, 3, d => true);

            // Assert
            Assert.Equal(id, model[0].DishId);
        }

    }
}
