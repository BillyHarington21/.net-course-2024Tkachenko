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

            var clients = testDataGenerator.Clients(1000);
            Random random = new Random();
            

            var dictionaryAccounts = testDataGenerator.DictionaryAccountsOfClients(clients);         

            var listOfClientsFromDictionary = clients.ToList();
            var randomClient = listOfClientsFromDictionary[random.Next(listOfClientsFromDictionary.Count)];

            Client client = new Client()
            {
                Age = randomClient.Age,
                Id = randomClient.Id,
                Name = randomClient.Name,
                PhoneNumber = randomClient.PhoneNumber
            };
           
            List<Account> accountsRandomClientFromDictionary = dictionaryAccounts[client];
            
            Assert.NotEmpty(accountsRandomClientFromDictionary);// ��������� ������������� ������ ������, ��������� ����� True ��� ���������������� ������ GetHashCode, false ��� �� ����������������
            
        }
        [Fact]
        public void GetHashCodeNecessityPositivTest1()
        {
            TestDataGenerator testDataGenerator = new TestDataGenerator();

            var clients = testDataGenerator.Clients(1000);
            Random random = new Random();


            var dictionaryAccounts = testDataGenerator.DictionaryAccountsOfClients(clients);

            
            var randomClient = clients[random.Next(clients.Count)];

            Client client = new Client()
            {
                Age = randomClient.Age,
                Id = randomClient.Id,
                Name = randomClient.Name,
                PhoneNumber = randomClient.PhoneNumber
            };

            List<Account> accountsRandomClientFromDictionary = dictionaryAccounts[client];
            var keyFromValue = dictionaryAccounts.FirstOrDefault(w => w.Value == accountsRandomClientFromDictionary).Key;

            Assert.True(accountsRandomClientFromDictionary.Equals(dictionaryAccounts[keyFromValue]));// ��������� ��������� ���-����� � ������ � ���� �� ������� ��� ��������������� ������ GetHashCode() ��������� - True, ��� �� �������������� - False  
        }

    }
}