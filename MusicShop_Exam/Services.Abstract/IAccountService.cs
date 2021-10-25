using Services.Abstract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IAccountService
    {
        IEnumerable<AccountDTO> GetAllAccounts();
        AccountDTO GetAccountById(Guid id);
        AccountDTO UpdateAccount(AccountDTO category);
        AccountDTO CreateNewAccount(AccountDTO category);
        void RemoveAccountById(Guid id);
    }
}
