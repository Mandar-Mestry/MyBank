using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    public static class Database
    {
        public static List<Person> people = new List<Person>();
        public static List<Account> accounts = new List<Account>();
        public static List<Owner> owners = new List<Owner>();

        public static void InitData()
        {
            // Populate people data
            people.Add(new Person(1, "Mandar Mestry"));
            people.Add(new Person(2, "Dwayne Johnson"));
            people.Add(new Person(3, "Fernando Torres"));
            people.Add(new Person(4, "Maria Evergreen"));
            people.Add(new Person(5, "James James"));

            //Populate Account Data
            accounts.Add(new Account(1, "Checking", 100));
            accounts.Add(new Account(2, "Savings", 200));
            accounts.Add(new Account(3, "Savings", 300));
            accounts.Add(new Account(4, "Checking", 400));
            accounts.Add(new Account(5, "Savings", 500));
            accounts.Add(new Account(6, "Checking", 600));
            accounts.Add(new Account(7, "Checking", 700));

            //Populate Owners
            owners.Add(new Owner(1, 1));
            owners.Add(new Owner(1, 2));
            owners.Add(new Owner(2, 3));
            owners.Add(new Owner(3, 4));
            owners.Add(new Owner(4, 5));
            owners.Add(new Owner(5, 6));
        }
    }
}
