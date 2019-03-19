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
        public List<InvoiceDto> Invoices { get; set; }

        public InvoicesDataStore()
        {
            Invoices = new List<InvoiceDto>()
            {
                new InvoiceDto()
                {
                    Id = 1, 
                    Name = "Mökkilan50",
                    Amount = 600,
                    Description = "Paras Lani ikinä",
                    ExpenseItems = new List<ExpenseItemDto>()
                    {
                        new ExpenseItemDto()
                        {
                            ExpenseCreditor = 1, 
                            ExpenseDebitors = new List<UserDto>()
                            {
                                new UserDto()
                                {
                                    Email = "epituo@gmail.com",
                                    Id = 1,
                                    Password = "isokulli",
                                    UserName = "Epitus,",
                                    UserRole = (int)RoleType.Admin
                                }
                            },
                            ExpenseType = ExpenseTypeDto.Personal,
                            Id = 1,
                            InvoiceGuid = 1
                        }
                    },
                    LanPartyId = 1
                },
                new InvoiceDto()
                {
                    Id = 2,
                    Name = "Mökkilan40",
                    Amount = 600,
                    Description = "Paskin Lani ikinä",
                    ExpenseItems = new List<ExpenseItemDto>()
                    {
                        new ExpenseItemDto()
                        {
                            ExpenseCreditor = 1,
                            ExpenseDebitors = new List<UserDto>()
                            {
                                new UserDto()
                                {
                                    Email = "kitupelle@gmail.com",
                                    Id = 3,
                                    Password = "pienikulli",
                                    UserName = "Pälli,",
                                    UserRole = (int)RoleType.Normal
                                }
                            },
                            ExpenseType = ExpenseTypeDto.Personal,
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
