using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



class BankAccount
{
    public int accountNumber {  get; set; }
    public int balance { get; set; }

    public BankAccount(int acc,int b)
    {  accountNumber = acc; balance = b; }

    public bool deposit(int c)
    {
        if (c > 1000)
        {
            return false;
        }
        else
        {
            balance += c;
            return true; ;
        }
    }

    public bool withdraw(int c)
    {
        if (balance - c < 0)
        {
            return false;
        }
        else
        {
            balance -= c;
            return true;
        }
    }
};
namespace WebApplication1
{
    public partial class B2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Session["bank"] = new BankAccount(1, 0);
            }
            showBalance();

        }

        void showBalance()
        {
            BankAccount ba = (BankAccount)Session["bank"];
            lblmsg.Text = "Current balance: " + ba.balance; 
        }

        protected void withdraw_Click(object sender, EventArgs e)
        {
            BankAccount ba = (BankAccount)Session["bank"];
            int c = Convert.ToInt32(balance.Text);

            if(ba.withdraw(c))
            {
                lblres.Text = "Withdraw Successful";
            }
            else
            {
                lblres.Text = "Invalid Withdraw ";
            }

            showBalance();

        }

        protected void deposit_Click(object sender, EventArgs e)
        {
            BankAccount ba = (BankAccount)Session["bank"];
            int c = Convert.ToInt32(balance.Text);

            if (ba.deposit(c))
            {
                lblres.Text = "Deposit Successful";
            }
            else
            {
                lblres.Text = "Invalid Deposit";
               
            }
            showBalance();
        }
    }
}