using System;

class CheckingAccount : BankAccount{
  public CheckingAccount():base() {
       
  }
  
  public CheckingAccount(double b):base(b) {

  }

  public override void CalculateInterest() {
    double interest = Balance * 0.005;
    Balance = Balance + interest;
  }

  public override void Withdraw(double amount) {
    base.Withdraw(amount);
  }  











}