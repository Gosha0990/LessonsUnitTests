using LessonsUnitTests;
using NUnit.Framework;

namespace TestPhoneNumber
{
    public class Tests
    {
        private NumberPhone numberPhone;
        [SetUp]
        public void Setup()
        {
            numberPhone = new NumberPhone();
        }

        [Test]
        public void TestReturnTrue()
        {
            //Arrange
            bool sut = false;

            //Assert
            Assert.AreEqual(true, sut);
        }

        [Test]
        public void GetNumber_SetStringAndDigit_ReturnTrue()
        {
            //Arrange
            long? phone = null;
            string requestStr = "8 - 916 / 555 / 55 {55}";

            //Act
            var sut = numberPhone.GetNumber(requestStr, out phone);
             
            //Assert
            Assert.AreEqual(true, sut);
            Assert.AreEqual(89165555555, phone);
        }

        [Test]
        public void GetNumber_SetStringNotDigit_ReturnFalse()
        {
            //Arrange
            long? phone = null;
            string requestStr = "Ўла саша по шоссе и сасала";

            //Act
            var sut = numberPhone.GetNumber(requestStr, out phone);

            //Assert
            Assert.AreEqual(false, sut);
        }

        [Test]
        public void GetNumber_SetStringNull_ReturnFalse()
        {
            //Arrange
            long? phone = null;
            string requestStr = null;

            //Act
            var sut = numberPhone.GetNumber(requestStr, out phone);

            //Assert
            Assert.AreEqual(false, sut);
        }

        [Test]
        public void GetNumber_SetStringEmpty_ReturnFalse()
        {
            //Arrange
            long? phone = null;
            string requestStr = string.Empty;

            //Act
            var sut = numberPhone.GetNumber(requestStr, out phone);

            //Assert
            Assert.AreEqual(false, sut);
        }

        [Test]
        public void  GetNumber_SetStringNumberMoreEight_ReturnFalse()
        {
            //Arrange
            long? number = null;
            string numberStr = "9 912-444-44-44";

            //Act
            var sut = numberPhone.GetNumber(numberStr, out number);

            //Assert
            Assert.AreEqual(false, sut);
            Assert.AreEqual(null, number);
        }

        [Test]
        public void GetNumber_SetStringNumberLessSeven_ReturnFalse()
        {
            //Arrange
            long? number = null;
            string numberStr = "6 912-444-44-44";

            //Act
            var sut = numberPhone.GetNumber(numberStr, out number);

            //Assert
            Assert.AreEqual(false, sut);
            Assert.AreEqual(null, number);
        }

        [Test]
        public void GetNumber_SetStringNumberLengthMoreEleven_ReturnFalse()
        {
            //Arrange
            long? phone = null;
            string requestStr = "8 - 916 / 5555 / 55 {55}";

            //Act
            var sut = numberPhone.GetNumber(requestStr, out phone);

            //Assert
            Assert.AreEqual(false, sut);
            Assert.AreEqual(null, phone);
        }

        [Test]
        public void GetNumber_SetStringNumberLengthLessEleven_ReturnFalse()
        {
            //Arrange
            long? phone = null;
            string requestStr = "8";

            //Act
            var sut = numberPhone.GetNumber(requestStr, out phone);

            //Assert
            Assert.AreEqual(false, sut);
            Assert.AreEqual(null, phone);
        }
    }
}