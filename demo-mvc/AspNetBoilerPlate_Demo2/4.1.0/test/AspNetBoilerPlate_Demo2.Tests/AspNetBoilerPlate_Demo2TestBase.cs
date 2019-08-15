using System;
using System.Threading.Tasks;
using Abp.TestBase;
using AspNetBoilerPlate_Demo2.EntityFrameworkCore;
using AspNetBoilerPlate_Demo2.Tests.TestDatas;

namespace AspNetBoilerPlate_Demo2.Tests
{
    public class AspNetBoilerPlate_Demo2TestBase : AbpIntegratedTestBase<AspNetBoilerPlate_Demo2TestModule>
    {
        public AspNetBoilerPlate_Demo2TestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<AspNetBoilerPlate_Demo2DbContext> action)
        {
            using (var context = LocalIocManager.Resolve<AspNetBoilerPlate_Demo2DbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<AspNetBoilerPlate_Demo2DbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<AspNetBoilerPlate_Demo2DbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<AspNetBoilerPlate_Demo2DbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<AspNetBoilerPlate_Demo2DbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<AspNetBoilerPlate_Demo2DbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<AspNetBoilerPlate_Demo2DbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
