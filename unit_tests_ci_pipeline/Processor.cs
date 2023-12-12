using System;
namespace unit_tests_ci_pipeline
{
    public class Processor
    {
        public Processor()
        {
        }
        public Result Book(Request request)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }


            return new Result
            {
                FullName = request.FullName,
                Email = request.Email,
                DateOnly = request.DateOnly
            };
        }
    }
}

