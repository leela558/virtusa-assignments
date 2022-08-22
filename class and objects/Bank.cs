namespace oopsAssignment
{
   class Bank
    {
		public string Name;
		public int Acc_no;
		public string Type_Acc;
		public int Balance;
	}
	class BankRepository
    {
		private Bank[] bankk=new Bank[100];
		int i = 0;
		public void AddBank(Bank bank)
        {
			if(i<bankk.Length)
            {
				bankk[i] = bank;
				i++;
            }
        }
		public Bank GetBankByAcc(int Acc_no)
        {
			foreach(Bank b in bankk)
            {
				if(b!=null)
                {
					if(b.Acc_no==Acc_no)
                    {
						return b;
                    }
                    else
                    {
						break;
                    }
                }
            }
			return null;
        }
		public Bank[] GetAllDetails()
        {
			return bankk;
        }

	}
	class Test_BankRepository
    {
		static void Main()
        {
			BankRepository repository = new BankRepository();
            do
            {
				Console.WriteLine("1.AddBank");
                Console.WriteLine("2.Deposit");
                Console.WriteLine("3.get all data");	
                Console.WriteLine("4.Withdraw");
                Console.WriteLine("5.Balance");
                Console.WriteLine("6.Exit App");
                Console.WriteLine("Enter your choice");
				int ch=int.Parse(Console.ReadLine());
				switch(ch)
                {
					case 1:
                        {
							Bank bank = new Bank();
							Console.WriteLine("Enter Name");
							bank.Name = Console.ReadLine();
							Console.WriteLine("Enter Acc_No");
							bank.Acc_no=int.Parse(Console.ReadLine());
							Console.WriteLine("Enter Acc_Type");
							bank.Type_Acc = Console.ReadLine();
                            Console.WriteLine("Enter Balance");
							bank.Balance=int.Parse(Console.ReadLine());
							repository.AddBank(bank);
                        }
						break;
					case 2:
                        {
							//Deposite Amount
							Console.WriteLine("Enter Account Number");
							int Acc_no = int.Parse(Console.ReadLine());
							Bank bank = repository.GetBankByAcc(Acc_no);
							if(bank!=null)
                            {
								Console.WriteLine("Enter Amount To Deposite");
								int Amount = int.Parse(Console.ReadLine());
								bank.Balance = bank.Balance+Amount;
                                Console.WriteLine("Updated Balnce:{0}",bank.Balance);
                            }
						}
						break;
					case 3:
                        {
							Bank[] bankk = repository.GetAllDetails();
							foreach(Bank bb in bankk)
                            {
								if(bb!=null)
                                {
                                    Console.WriteLine($"Name:{bb.Name} Account_NO:{bb.Acc_no} Type_Account:{bb.Type_Acc} Balance:{bb.Balance}");
                                }
                            }
                        }
						break;
					case 4:
                        {
							Console.WriteLine("Enter Account Number");
							int Acc_no = int.Parse(Console.ReadLine());
							Bank bank = repository.GetBankByAcc(Acc_no);
							if (bank != null)
							{
								Console.WriteLine("Enter Amount To Withdraw");
								int Amount = int.Parse(Console.ReadLine());
								bank.Balance = bank.Balance - Amount;
								Console.WriteLine("Updated Balnce:{0}", bank.Balance);
							}
						}
						break;
					case 5:
                        {
							Console.WriteLine("Enter Account Number");
							int Acc_no = int.Parse(Console.ReadLine());
							Bank bank = repository.GetBankByAcc(Acc_no);
                            {
								if(bank != null)
                                {
                                    Console.WriteLine($"Name:{bank.Name} Balance:{bank.Balance}");
                                }
                            }
						}
						break;
					case 6:
                        {
							Environment.Exit(0);
                        }
						break;
                }
            }while(true);
        }
    }
}