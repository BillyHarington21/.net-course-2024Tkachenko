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
            
            Assert.NotEmpty(accountsRandomClientFromDictionary);// ��������� ������������� ������ ������, ��������� ����� True ��� ���������������� ������ GetHashCode, false ��� �� ����������������
            
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

            Assert.True(client.GetHashCode().Equals(keyFromValue));// ��������� ��������� ���-����� � ������ � ���� �� ������� ��� ��������������� ������ GetHashCode() ��������� - True, ��� �� �������������� - False  
        }

    }
}