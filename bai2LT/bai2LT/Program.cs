using System;
using System.Text;

namespace SimpleBankAccount
{
    // Bước 1: Tạo các lớp ngoại lệ tùy chỉnh
    public class InfullFundsException : Exception
    {
        public InfullFundsException(string message) : base(message)
        {
        }
    }

    public class NegativeAmountException : Exception
    {
        public NegativeAmountException(string message) : base(message)
        {
        }
    }

    // Bước 2: Tạo lớp BankAccount
    public class BankAccount
    {
        private decimal balance;

        public BankAccount()
        {
            balance = 0;
        }

        public decimal Balance
        {
            get { return balance; }
        }

        // Phương thức gửi tiền
        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new NegativeAmountException("Số tiền gửi phải là số dương.");
            }
            balance += amount;
            Console.WriteLine($"Gửi {amount:C} thành công. Số dư hiện tại: {balance:C}");
        }

        // Phương thức rút tiền
        public void Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new NegativeAmountException("Số tiền rút phải là số dương.");
            }
            if (amount > balance)
            {
                throw new InfullFundsException("Số dư không đủ để rút tiền.");
            }
            balance -= amount;
            Console.WriteLine($"Rút {amount:C} thành công. Số dư hiện tại: {balance:C}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            BankAccount account = new BankAccount();

            while (true)
            {
                Console.WriteLine("\nChọn thao tác:");
                Console.WriteLine("1. Gửi tiền");
                Console.WriteLine("2. Rút tiền");
                Console.WriteLine("3. Xem số dư");
                Console.WriteLine("4. Thoát");
                Console.Write("Lựa chọn của bạn: ");
                char choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                try
                {
                    switch (choice)
                    {
                        case '1':
                            Console.Write("Nhập số tiền muốn gửi: ");
                            decimal depositAmount = decimal.Parse(Console.ReadLine());
                            account.Deposit(depositAmount);
                            break;
                        case '2':
                            Console.Write("Nhập số tiền muốn rút: ");
                            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                            account.Withdraw(withdrawAmount);
                            break;
                        case '3':
                            Console.WriteLine($"Số dư hiện tại: {account.Balance:C}");
                            break;
                        case '4':
                            return;
                        default:
                            Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                            break;
                    }
                }
                catch (NegativeAmountException ex)
                {
                    Console.WriteLine($"Lỗi: {ex.Message}");
                }
                catch (InfullFundsException ex)
                {
                    Console.WriteLine($"Lỗi: {ex.Message}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lỗi: Vui lòng nhập một số hợp lệ.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi không xác định: {ex.Message}");
                }
            }
        }
    }
}
