using System;
using Shouldly;
namespace unit_tests_ci_pipeline
{
	public class ProcessorTest
	{
		public ProcessorTest()
		{
		}

        [Fact]
        public void Should_Return_Booking_Response_With_Details()
		{
            var request = new Request
            {
                FullName = "Test Name",
                Email = "test@gmail.com",
                DateOnly = new DateTime(2023, 12, 10)
            };

            var processor = new Processor();

            Result result = processor.Book(request);

            Assert.NotNull(result);

            Assert.Equal(request.FullName, result.FullName);
            Assert.Equal(request.Email, result.Email);
            Assert.Equal(request.Email, result.Email);

        }

        [Fact]
        public void Should_Throw_Exception_For_Null_Request()
        {
            var processor = new Processor();

            var exception = Assert.Throws<ArgumentNullException>(() => processor.Book(null!));

            // default xUnit
            //Assert.Throws<ArgumentNullException>(() => processor.Book(null!));

            exception.ParamName.ShouldBe("request");
        }
    }
}

