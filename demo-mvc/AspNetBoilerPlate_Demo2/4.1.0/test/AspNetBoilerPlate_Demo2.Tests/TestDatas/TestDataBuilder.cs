using AspNetBoilerPlate_Demo2.EntityFrameworkCore;

namespace AspNetBoilerPlate_Demo2.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly AspNetBoilerPlate_Demo2DbContext _context;

        public TestDataBuilder(AspNetBoilerPlate_Demo2DbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}