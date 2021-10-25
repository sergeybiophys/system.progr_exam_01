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

        public AccountDTO CreateNewAccount(AccountDTO account)
        {
            var tmp = new Account
            {
                FirstName = account.FirstName,
                LastName = account.LastName,
                Password = account.Password,
                Phone = account.Phone,
                Email = account.Email,
                AccountStatus = account.AccountStatus
            };

            this.uow.AccountRepository.Create(tmp);
            this.uow.SaveChanges();

            return mapper.Map<AccountDTO>(tmp);
 
        }

        public AccountDTO GetAccountById(Guid id)
        {
            var account = this.uow.AccountRepository.Get(id);
            return new AccountDTO
            {
                Id = account.Id,
                FirstName = account.FirstName,
                LastName = account.LastName,
                Password = account.Password,
                Phone = account.Phone,
                Email = account.Email,
                AccountStatus = account.AccountStatus
            };
        }

        public IEnumerable<AccountDTO> GetAllAccounts()
        {
            var accounts = this.uow.AccountRepository.GetAll();

            return accounts.Select((a) => new AccountDTO
            {
                Id = a.Id,
                FirstName = a.FirstName,
                LastName = a.LastName,
                Password = a.Password,
                Phone = a.Phone,
                Email = a.Email,
                AccountStatus = a.AccountStatus
            }).ToList();
        }

        public void RemoveAccountById(Guid id)
        {
            this.uow.AccountRepository.Remove(id);
            this.uow.SaveChanges();
        }

        public AccountDTO UpdateAccount(AccountDTO account)
        {
            var tmp = new Account
            {
                Id = account.Id,
                FirstName = account.FirstName,
                LastName = account.LastName,
                Password = account.Password,
                Phone = account.Phone,
                Email = account.Email,
                AccountStatus = account.AccountStatus
            };

            this.uow.AccountRepository.Update(tmp);
            this.uow.SaveChanges();

            return mapper.Map<AccountDTO>(tmp);              
        }
    }
}
