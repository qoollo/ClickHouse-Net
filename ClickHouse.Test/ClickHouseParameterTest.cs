using ClickHouse.Ado;
using NUnit.Framework;
using System;

namespace ClickHouse.Test
{
    [TestFixture]
    public class ClickHouseParameterTest
    {
        [Test]
        public void AsSubstitudeDateTime()
        {
            //Arrange 
            ClickHouseParameter parameter = new ClickHouseParameter()
            {
                DbType = System.Data.DbType.DateTime,
                Value = new DateTime(2020, 1, 1, 10, 0, 0, DateTimeKind.Utc)
            };

            //Act
            var res = parameter.AsSubstitute();

            //Assert
            Assert.AreEqual("toDateTime('2020-01-01 10:00:00', 'UTC')", res);
        }

        [Test]
        public void AsSubstitudeDate()
        {
            //Arrange 
            ClickHouseParameter parameter = new ClickHouseParameter()
            {
                DbType = System.Data.DbType.Date,
                Value = new DateTime(2020, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            };

            //Act
            var res = parameter.AsSubstitute();

            //Assert
            Assert.AreEqual("toDate('2020-01-01', 'UTC')", res);
        }
    }
}