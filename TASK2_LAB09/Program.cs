namespace Accounts
{
    public class Account
    {
        private string accountNo;
        private string accountName;
        private double balance;

        public void setAccountNo(string accountNo)
        {
            this.accountNo = accountNo;
        }

        public void setAccountName(string accountName)
        {
            this.accountName = accountName;
        }

        public void setBalance(double balance)
        {
            this.balance = balance;
        }

        public string getAccountNo()
        {
            return accountNo;
        }

        public string getAccountName()
        {
            return accountName;
        }

        public double getBalance()
        {
            return balance;
        }
    }

    public class CurrentAccount : Account
    {
        private const int serviceCharge = 100;
        private const string accountPrefix = "100";
        private static int nextAccount = 300000;

        public CurrentAccount()
        {
            nextAccount++;
        }

        public string getNextAccountNo()
        {
            return (accountPrefix + Convert.ToString(nextAccount));
        }

        public double calcBalance(double balance)
        {
            return (balance - serviceCharge);
        }

        public string description()
        {
            return "-------------------- Current Account --------------------";
        }
    }

    public class SavingsAccount : Account
    {
        private double interestRate;
        private double monthlyDepositAmount;
        private const string accountPrefix = "200";
        private static int nextAccount = 300000;

        public SavingsAccount()
        {
            nextAccount++;
        }

        public string getNextAccountNo()
        {
            return (accountPrefix + Convert.ToString(nextAccount));
        }

        public void setInterestRate(double interestRate)
        {
            this.interestRate = interestRate;
        }

        public void setMonthlyDepositAmount(double monthlyDepositAmount)
        {
            this.monthlyDepositAmount = monthlyDepositAmount;
        }

        public double getInterestRate()
        {
            return interestRate;
        }

        public double getMonthlyDepositAmount()
        {
            return monthlyDepositAmount;
        }

        public double calcBalance()
        {
            return (monthlyDepositAmount + (monthlyDepositAmount * (interestRate / 100)));
        }

        public string description()
        {
            return "-------------------- Savings Account --------------------";
        }
    }

    public class MonthlyDepositScheme : Account
    {
        private double interestRate;
        private double monthlyDepositAmount;
        private const string accountPrefix = "300";
        private static int nextAccount = 300000;

        public MonthlyDepositScheme()
        {
            nextAccount++;
        }

        public string getNextAccountNo()
        {
            return (accountPrefix + Convert.ToString(nextAccount));
        }

        public void setInterestRate(double interestRate)
        {
            this.interestRate = interestRate;
        }

        public void setMonthlyDepositAmount(double monthlyDepositAmount)
        {
            this.monthlyDepositAmount = monthlyDepositAmount;
        }

        public double getInterestRate()
        {
            return interestRate;
        }

        public double getMonthlyDepositAmount()
        {
            return monthlyDepositAmount;
        }

        public double calcBalance()
        {
            return (monthlyDepositAmount + (monthlyDepositAmount * (interestRate / 100)));
        }
    }

    public class LoanAccount : Account
    {
        private double interestRate;
        private double monthlyDepositAmount;
        private const string accountPrefix = "900";
        private static int nextAccount = 300000;

        public LoanAccount()
        {
            nextAccount++;
        }

        public string getNextAccountNo()
        {
            return (accountPrefix + Convert.ToString(nextAccount));
        }

        public void setInterestRate(double interestRate)
        {
            this.interestRate = interestRate;
        }

        public void setMonthlyDepositAmount(double monthlyDepositAmount)
        {
            this.monthlyDepositAmount = monthlyDepositAmount;
        }

        public double getInterestRate()
        {
            return interestRate;
        }

        public double getMonthlyDepositAmount()
        {
            return monthlyDepositAmount;
        }

        public double calcBalance()
        {
            return (monthlyDepositAmount + (monthlyDepositAmount * (interestRate / 100)));
        }

        public string description()
        {
            return "--------------------- Loan Account ----------------------";
        }
    }

    public class TwoYearMDS : MonthlyDepositScheme
    {
        private double maximumInterest;

        public void setMaximumInterest(double maximumInterest)
        {
            this.maximumInterest = maximumInterest;
        }

        public double getMaximumInterest()
        {
            return maximumInterest;
        }

        public string description()
        {
            return "----------- Two Year Monthly Deposit Account ------------";
        }
    }

    public class FiveYearMDS : MonthlyDepositScheme
    {
        private double maximumInterest;

        public void setMaximumInterest(double maximumInterest)
        {
            this.maximumInterest = maximumInterest;
        }

        public double getMaximumInterest()
        {
            return maximumInterest;
        }

        public string description()
        {
            return "----------- Five Year Monthly Deposit Account -----------";
        }
    }

    public class InitialDepositMDS : MonthlyDepositScheme
    {
        private double maximumInterest;
        private double initalDepositAmount;

        public void setInitialDepositAmount(double initialDepositAmount)
        {
            this.initalDepositAmount = initialDepositAmount;
        }

        public double getInitialDepositAmount()
        {
            return initalDepositAmount;
        }

        public void setMaximumInterest(double interestRate, double initialDepositAmount)
        {
            this.maximumInterest = initialDepositAmount * (interestRate / 100);
        }

        public double getMaximumInterest()
        {
            return maximumInterest;
        }

        public string description()
        {
            return "-------- Initial Deposit Monthly Deposit Account --------";
        }

        public double calcBalance(double interestRate, double initialDepositAmount)
        {
            return (initialDepositAmount + (initialDepositAmount * (interestRate / 100)));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Current Account

            CurrentAccount dummy_current = new CurrentAccount();

            dummy_current.setAccountName("Adeba Islam");
            dummy_current.setBalance(15000);

            Console.WriteLine(dummy_current.description());
            Console.WriteLine("Account Name: " + dummy_current.getAccountName());
            Console.WriteLine("Account No.: " + dummy_current.getNextAccountNo());
            Console.WriteLine("Balance: " + dummy_current.calcBalance(dummy_current.getBalance()));

            CurrentAccount dummy_current2 = new CurrentAccount();

            dummy_current2.setAccountName("rahnuma janoshhi");
            dummy_current2.setBalance(150000);

            Console.WriteLine("\n" + dummy_current2.description());
            Console.WriteLine("Account Name: " + dummy_current2.getAccountName());
            Console.WriteLine("Account No.: " + dummy_current2.getNextAccountNo());
            Console.WriteLine("Balance: " + dummy_current2.calcBalance(dummy_current2.getBalance()));

            //Savings

            SavingsAccount dummy_savings = new SavingsAccount();

            dummy_savings.setAccountName("tasnim rahman");
            dummy_savings.setInterestRate(4.2);
            dummy_savings.setMonthlyDepositAmount(5000);

            Console.WriteLine("\n" + dummy_savings.description());
            Console.WriteLine("Account Name: " + dummy_savings.getAccountName());
            Console.WriteLine("Account No.: " + dummy_savings.getNextAccountNo());
            Console.WriteLine("Balance: " + dummy_savings.calcBalance());

            SavingsAccount dummy_savings2 = new SavingsAccount();

            dummy_savings2.setAccountName("Ammarah Ashrafi");
            dummy_savings2.setInterestRate(4.5);
            dummy_savings2.setMonthlyDepositAmount(9000.50);

            Console.WriteLine("\n" + dummy_savings2.description());
            Console.WriteLine("Account Name: " + dummy_savings2.getAccountName());
            Console.WriteLine("Account No.: " + dummy_savings2.getNextAccountNo());
            Console.WriteLine("Balance: " + dummy_savings2.calcBalance());

            //Two Year Monthly Deposit Scheme

            TwoYearMDS dummy_2yrMDS = new TwoYearMDS();

            dummy_2yrMDS.setAccountName("Anika Tasnim");
            dummy_2yrMDS.setInterestRate(6);
            dummy_2yrMDS.setMonthlyDepositAmount(50000);
            dummy_2yrMDS.setMaximumInterest(2000);

            Console.WriteLine("\n" + dummy_2yrMDS.description());
            Console.WriteLine("Account Name: " + dummy_2yrMDS.getAccountName());
            Console.WriteLine("Account No.: " + dummy_2yrMDS.getNextAccountNo());

            if (dummy_2yrMDS.calcBalance() > (dummy_2yrMDS.getMonthlyDepositAmount() + dummy_2yrMDS.getMaximumInterest()))
            {
                dummy_2yrMDS.setBalance(dummy_2yrMDS.getMonthlyDepositAmount() + dummy_2yrMDS.getMaximumInterest());
                Console.WriteLine("Balance: " + dummy_2yrMDS.getBalance());
            }

            else
            {
                Console.WriteLine("Balance: " + dummy_2yrMDS.calcBalance());
            }

            TwoYearMDS dummy_2yrMDS2 = new TwoYearMDS();

            dummy_2yrMDS2.setAccountName("Romana Islam");
            dummy_2yrMDS2.setInterestRate(9);
            dummy_2yrMDS2.setMonthlyDepositAmount(21000);
            dummy_2yrMDS2.setMaximumInterest(2000);

            Console.WriteLine("\n" + dummy_2yrMDS2.description());
            Console.WriteLine("Account Name: " + dummy_2yrMDS2.getAccountName());
            Console.WriteLine("Account No.: " + dummy_2yrMDS2.getNextAccountNo());

            if (dummy_2yrMDS2.calcBalance() > (dummy_2yrMDS2.getMonthlyDepositAmount() + dummy_2yrMDS2.getMaximumInterest()))
            {
                dummy_2yrMDS2.setBalance(dummy_2yrMDS2.getMonthlyDepositAmount() + dummy_2yrMDS2.getMaximumInterest());
                Console.WriteLine("Balance: " + dummy_2yrMDS2.getBalance());
            }

            else
            {
                Console.WriteLine("Balance: " + dummy_2yrMDS2.calcBalance());
            }

            //Five Year Monthly Deposit Scheme

            FiveYearMDS dummy_5yrMDS = new FiveYearMDS();

            dummy_5yrMDS.setAccountName("Shaira Sadia");
            dummy_5yrMDS.setInterestRate(11);
            dummy_5yrMDS.setMonthlyDepositAmount(20000);
            dummy_5yrMDS.setMaximumInterest(3000);

            Console.WriteLine("\n" + dummy_5yrMDS.description());
            Console.WriteLine("Account Name: " + dummy_5yrMDS.getAccountName());
            Console.WriteLine("Account No.: " + dummy_5yrMDS.getNextAccountNo());

            if (dummy_5yrMDS.calcBalance() > (dummy_5yrMDS.getMonthlyDepositAmount() + dummy_5yrMDS.getMaximumInterest()))
            {
                dummy_5yrMDS.setBalance(dummy_5yrMDS.getMonthlyDepositAmount() + dummy_5yrMDS.getMaximumInterest());
                Console.WriteLine("Balance: " + dummy_5yrMDS.getBalance());
            }

            else
            {
                Console.WriteLine("Balance: " + dummy_5yrMDS.calcBalance());
            }

            FiveYearMDS dummy_5yrMDS2 = new FiveYearMDS();

            dummy_5yrMDS2.setAccountName("Samia Nasreen");
            dummy_5yrMDS2.setInterestRate(18);
            dummy_5yrMDS2.setMonthlyDepositAmount(35000);
            dummy_5yrMDS2.setMaximumInterest(6000);

            Console.WriteLine("\n" + dummy_5yrMDS2.description());
            Console.WriteLine("Account Name: " + dummy_5yrMDS2.getAccountName());
            Console.WriteLine("Account No.: " + dummy_5yrMDS2.getNextAccountNo());

            if (dummy_5yrMDS2.calcBalance() > (dummy_5yrMDS2.getMonthlyDepositAmount() + dummy_5yrMDS2.getMaximumInterest()))
            {
                dummy_5yrMDS2.setBalance(dummy_5yrMDS2.getMonthlyDepositAmount() + dummy_5yrMDS2.getMaximumInterest());
                Console.WriteLine("Balance: " + dummy_5yrMDS2.getBalance());
            }

            else
            {
                Console.WriteLine("Balance: " + dummy_5yrMDS2.calcBalance());
            }

            //Initial Deposit Monthly Deposit Scheme

            InitialDepositMDS dummy_initialMDS = new InitialDepositMDS();

            dummy_initialMDS.setAccountName("Nexus");
            dummy_initialMDS.setInterestRate(3);
            dummy_initialMDS.setInitialDepositAmount(2000);
            dummy_initialMDS.setMaximumInterest(dummy_initialMDS.getInterestRate(), dummy_initialMDS.getInitialDepositAmount());

            Console.WriteLine("\n" + dummy_initialMDS.description());
            Console.WriteLine("Account Name: " + dummy_initialMDS.getAccountName());
            Console.WriteLine("Account No.: " + dummy_initialMDS.getNextAccountNo());
            Console.WriteLine("Balance: " + dummy_initialMDS.calcBalance(dummy_initialMDS.getInterestRate(), dummy_initialMDS.getInitialDepositAmount()));
            Console.WriteLine("Maximum Interest: " + dummy_initialMDS.getMaximumInterest());

            //Loan Account

            LoanAccount dummy_loan = new LoanAccount();

            dummy_loan.setAccountName("Samia Nawsheen");
            dummy_loan.setInterestRate(33);
            dummy_loan.setMonthlyDepositAmount(15000000);

            Console.WriteLine("\n" + dummy_loan.description());
            Console.WriteLine("Account Name: " + dummy_loan.getAccountName());
            Console.WriteLine("Account No.: " + dummy_loan.getNextAccountNo());
            Console.WriteLine("Balance: " + dummy_loan.calcBalance());

            LoanAccount dummy_loan2 = new LoanAccount();

            dummy_loan2.setAccountName("Lost");
            dummy_loan2.setInterestRate(29);
            dummy_loan2.setMonthlyDepositAmount(50000000);

            Console.WriteLine("\n" + dummy_loan2.description());
            Console.WriteLine("Account Name: " + dummy_loan2.getAccountName());
            Console.WriteLine("Account No.: " + dummy_loan2.getNextAccountNo());
            Console.WriteLine("Balance: " + dummy_loan2.calcBalance());
        }
    }
}
