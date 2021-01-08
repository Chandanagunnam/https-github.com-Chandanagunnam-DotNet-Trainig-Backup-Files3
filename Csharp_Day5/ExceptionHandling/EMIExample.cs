using System;

namespace ExceptionHandling
{
    //2. Write a class called LoanProcess with Loan_No, Customer Name, LoanAmount, EMI_Amount, Account_Balance 
    //as its members. 
    //Create a method calculate_EMI() for the LoanAmount, with the rate of interest as 13% for a total of 3 years 
    //and store it in the EMI_Amount.
    //The rest of the information to be passed through constructors.
    //Write another function CheckBalance() which checks if the Account_Balance is less than the EMI_AMount. 
    //If yes then throw a custom exception.Display " Not Sufficient Balance to repay Loan" in the finally. 
    //Give explanatory comments.
    class  BankBalanceException: Exception
    {
        internal BankBalanceException(string m) : base(m)
        {

        }
    }
    class LoanProcess
    {
        int Loan_No;
        string CustomerName;
        float EMI_Amount;
        float LoanAmount;
        float Account_Balance;
       
        internal LoanProcess(int Loan_No, string CustomerName, float Account_Balance,float LoanAmount)
        {
            this.Loan_No = Loan_No;
            this.CustomerName = CustomerName;
            this.Account_Balance = Account_Balance;
            this.LoanAmount = LoanAmount;
        }
        internal float Calculate_EMI()
        {
            float rate = 0.13f;
            int year = 3;
            EMI_Amount = ((LoanAmount * rate * year) + LoanAmount) / (year*12);
            //loan*rate*(rate+1)*tenure/((rate+1)*tenure -1)
            return EMI_Amount;
        }
        public void CheckBalance()
        {
            try
            {
                if (Account_Balance < EMI_Amount)
                {
                    throw new BankBalanceException(" Your EMI is more than AccountBalance");
                }
                else
                {
                    Console.WriteLine("Your LoanAmount is processed");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Message   :{0}", e.Message);
            }
            finally
            {
                if (Account_Balance < EMI_Amount)
                {
                    Console.WriteLine("Mr/Ms {2},Your EMI is {0} and Your AccountBalance is {1}.Not Sufficient Balance to repay Loan.Loan is Rejected", EMI_Amount, Account_Balance, CustomerName);
                }
                else
                {
                    Console.WriteLine("Mr/Ms {2},Your EMI is {0} and Your AccountBalance is {1}.Loan is Granted", EMI_Amount, Account_Balance, CustomerName);

                }
            }
        }
    }
    class EMIExample
    {
        static void Main()
        {
            LoanProcess loanProcess = new LoanProcess(101, "Arya", 52100,50000);
            LoanProcess loanProcess1 = new LoanProcess(102, "Vidya", 1500, 60000);
            Console.WriteLine(loanProcess.Calculate_EMI());
            Console.WriteLine(loanProcess1.Calculate_EMI());
            loanProcess.CheckBalance();
            loanProcess1.CheckBalance();
            Console.Read();
        }
    }
}
