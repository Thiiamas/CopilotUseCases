using CopilotUseCases;

namespace CopilotTest
{
    [TestClass]
    public class BankTest
    {
        BankAccount bankAccountInstance;

        /*
         * write multiple test function to test bankAcocountInstance
         */
        [TestMethod]
        public void TestMethod1()
        {
            bankAccountInstance = new BankAccount("Mr. Bryan Walton", 11.99);
            bankAccountInstance.Credit(5.77);
            bankAccountInstance.Debit(11.22);
            Assert.AreEqual(6.54, bankAccountInstance.Balance);
        }

        [TestMethod]
        public void TestMethod2()
        {
            bankAccountInstance = new BankAccount("Mr. Bryan Walton", 11.99);
            bankAccountInstance.Credit(5.77);
            Assert.AreEqual(17.76, bankAccountInstance.Balance);
        }
        //write function to test bankAccount debit
        [TestMethod]
        public void TestMethod3()
        {
            bankAccountInstance = new BankAccount("Mr. Bryan Walton", 11.99);
            bankAccountInstance.Debit(11.22);
            Assert.AreEqual(0.77, bankAccountInstance.Balance);
        }
        //write function to test bankAccount debit with exception
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethod4()
        {
            bankAccountInstance = new BankAccount("Mr. Bryan Walton", 11.99);
            bankAccountInstance.Debit(12.22);
        }
        //write function to test bankAccount credit with exception
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethod5()
        {
            bankAccountInstance = new BankAccount("Mr. Bryan Walton", 11.99);
            bankAccountInstance.Credit(-12.22);
        }
        //write function to test bankAccount debit with exception
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethod6()
        {
            bankAccountInstance = new BankAccount("Mr. Bryan Walton", 11.99);
            bankAccountInstance.Debit(-12.22);
        }        //write function to test bankAccount credit





    }
}