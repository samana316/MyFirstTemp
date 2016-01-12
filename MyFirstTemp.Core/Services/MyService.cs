using MyFirstTemp.Core.Models;
using MyFirstTemp.Core.Repositories;

namespace MyFirstTemp.Core.Services
{
    public sealed class MyService
    {
        private readonly IMyRepository repository;

        public MyService(
            IMyRepository repository)
        {
            this.repository = repository;
        }

        public int DoSomething()
        {
            var result = 0;

            var data = this.repository.Get();

            this.repository.Add(new MyModel());
            result++;

            foreach (var item in data)
            {
                item.Name = (item.Id++).ToString();
                result += this.repository.Update(item);
            }

            return result;
        }
    }
}
