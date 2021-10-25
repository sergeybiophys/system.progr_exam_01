using AutoMapper;
using Domain.Entity;
using Domain.Repository;
using Services.Abstract;
using Services.Abstract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Services
{
    public class AccountService:IAccountService
    {
        readonly IUnitOfWork uow;
        readonly IMapper mapper;

        public AccountService(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        public AccountDTO CreateNewAccount(AccountDTO category)
        {
            var tmp = new Account
            {

            };
        }

        public AccountDTO GetAccountById(Guid id)
        {
            
        }

        public IEnumerable<AccountDTO> GetAllAccounts()
        {
           
        }

        public void RemoveAccountById(Guid id)
        {
            
        }

        public AccountDTO UpdateAccount(AccountDTO category)
        {
           
        }
    }
}
