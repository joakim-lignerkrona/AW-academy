namespace TransactionDemo {
    internal class Program {

        static string[] transactionLog = new string[3];
        static int numberOfTransactions = 0;

        static void Main(string[] args) {


            for(int i = 0; i < 5000000; i++) {

                MakeATransaktion();
            }

            LogLatest();


        }

        private static void LogLatest() {
            int index = numberOfTransactions - 1;
            for(int i = 0; i < transactionLog.Length; i++) {
                if(index >= 0)
                    Console.WriteLine(transactionLog[index-- % transactionLog.Length]);
            }
        }

        private static void MakeATransaktion() {
            transactionLog[numberOfTransactions++ % transactionLog.Length] = $"Transaction number: {numberOfTransactions.ToString("000,000.00")}";
        }

    }
}