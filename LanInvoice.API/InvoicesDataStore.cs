using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanInvoice.API.Models;

namespace LanInvoice.API
{
    public class InvoicesDataStore
    {
        public static InvoicesDataStore Current { get; } = new InvoicesDataStore();
        public List<Invoice> Invoices { get; set; }

        public InvoicesDataStore()
        {
            Invoices = new List<Invoice>()
            {
                new Invoice()
                {
                    Id = 1, 
                    Name = "Mökkilan50",
                    Amount = 600,
                    Description = "Paras Lani ikinä",
                    ExpenseItems = new List<ExpenseItem>()
                    {
                        new ExpenseItem()
                        {
                            ExpenseCreditor = 1, 
                            ExpenseDebitors = new List<User>()
                            {
                                new User()
                                {
                                    Email = "epituo@gmail.com",
                                    Id = 1,
                                    Password = "isokulli",
                                    UserName = "Epitus,",
                                    UserRole = (int)RoleType.Admin
                                }
                            },
                            ExpenseType = ExpenseType.Personal,
                            Id = 1,
                            InvoiceGuid = 1
                        }
                    },
                    LanPartyId = 1
                },
                new Invoice()
                {
                    Id = 2,
                    Name = "Mökkilan40",
                    Amount = 600,
                    Description = "Paskin Lani ikinä",
                    ExpenseItems = new List<ExpenseItem>()
                    {
                        new ExpenseItem()
                        {
                            ExpenseCreditor = 1,
                            ExpenseDebitors = new List<User>()
                            {
                                new User()
                                {
                                    Email = "kitupelle@gmail.com",
                                    Id = 3,
                                    Password = "pienikulli",
                                    UserName = "Pälli,",
                                    UserRole = (int)RoleType.Normal
                                }
                            },
                            ExpenseType = ExpenseType.Personal,
                            Id = 1,
                            InvoiceGuid = 1
                        }
                    },
                    LanPartyId = 2
                }
            };
        }
    }
}
