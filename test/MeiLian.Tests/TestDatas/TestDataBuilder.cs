using MeiLian.EntityFrameworkCore;

namespace MeiLian.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly MeiLianDbContext _context;
        private readonly int _tenantId;

        public TestDataBuilder(MeiLianDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            new TestOrganizationUnitsBuilder(_context, _tenantId).Create();
            new TestSubscriptionPaymentBuilder(_context, _tenantId).Create();

            _context.SaveChanges();
        }
    }
}
