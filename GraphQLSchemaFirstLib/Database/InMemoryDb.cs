using GraphQLSchemaFirstLib.Models;

namespace GraphQLSchemaFirstLib.Database
{
    public class InMemoryDb
    {
        private readonly List<Employee> _employees;
        private readonly List<Card> _cards;
        public InMemoryDb() 
        {
            _employees = new List<Employee>
            {
                new Employee(1, "Anar", "123WQER", new Address
                (1, "Baku", "Khatai 56/78")),
                new Employee(2, "Hasan", "6567RTY", new Address
                (2, "London", "Oxford Street 34/21")),
                new Employee(3, "Mustafa", "6567RTY", new Address
                (3, "London", "Carnaby Street 11/11"))
            };

            _cards = new List<Card>()
            {
                new Card(1, "Anar Mammadov","3344-5566-7788-8878", CardType.Visa,_employees[0]),
                new Card(2, "Anar Mammadov","1111-2233-4455-6565", CardType.Master,_employees[0]),
                new Card(3, "Hasan John","2345-6789-5678-7689", CardType.Visa,_employees[1]),
                new Card(4, "Mustafa McLein","0001-2345-5678-1234", CardType.Master,_employees[2])
            };
        }

        public Task<List<Employee>> GetEmployeesAsync()
        {
            return Task.FromResult( _employees);
        }

        public Task<List<Card>> GetCardsAsync()
        {
            return Task.FromResult(_cards);
        }

        public Task<Employee?> GetEmployeeByIdAsync(int employeeId)
        {
            return Task.FromResult(_employees.FirstOrDefault(x => x.Id == employeeId));
        }

        public Task<Card?> GetCardByIdAsync(int cardId)
        {
            return Task.FromResult(_cards.FirstOrDefault(x => x.Id == cardId));
        }
    }
}
