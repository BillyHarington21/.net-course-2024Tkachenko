using BankSystem.App.Services;
using BankSystemDomen.Modelss;

namespace ServiceTests
{
    public class EquivalenceTests
    {
        [Fact]
        public void GetHashCodeNecessityPositivTest()
        {
            TestDataGenerator testDataGenerator = new TestDataGenerator();

            var clientsDictionary = testDataGenerator.DictionaryClients();
            Random random = new Random();
            

            var dictionaryAccounts = testDataGenerator.DictionaryAccountsOfClients(clientsDictionary);         

            var listOfClientsFromDictionary = clientsDictionary.Values.ToList();
            var randomClient = listOfClientsFromDictionary[random.Next(listOfClientsFromDictionary.Count)];

            Client client = new Client()
            {
                Age = randomClient.Age,
                Id = randomClient.Id,
                Name = randomClient.Name,
                PhoneNumber = randomClient.PhoneNumber
            };
           
            List<Account> accountsRandomClientFromDictionary = dictionaryAccounts[client.GetHashCode()];
            
            Assert.NotEmpty(accountsRandomClientFromDictionary);// проверяем существование списка счетов, ожидаемый исход True при переопределенном методе GetHashCode, false при не переопределенном
            
        }
        [Fact]
        public void GetHashCodeNecessityPositivTest1()
        {
            TestDataGenerator testDataGenerator = new TestDataGenerator();

            var clientsDictionary = testDataGenerator.DictionaryClients();
            Random random = new Random();


            var dictionaryAccounts = testDataGenerator.DictionaryAccountsOfClients(clientsDictionary);

            var listOfClientsFromDictionary = clientsDictionary.Values.ToList();
            var randomClient = listOfClientsFromDictionary[random.Next(listOfClientsFromDictionary.Count)];

            Client client = new Client()
            {
                Age = randomClient.Age,
                Id = randomClient.Id,
                Name = randomClient.Name,
                PhoneNumber = randomClient.PhoneNumber
            };

            List<Account> accountsRandomClientFromDictionary = dictionaryAccounts[client.GetHashCode()];
            var keyFromValue = dictionaryAccounts.FirstOrDefault(w => w.Value == accountsRandomClientFromDictionary).Key;

            Assert.True(client.GetHashCode().Equals(keyFromValue));// проверяем равенство хэш-кодов к одному и тому же объекту при переопрделенном методе GetHashCode() ожидается - True, при не переопреденном - False  
        }

    }
}