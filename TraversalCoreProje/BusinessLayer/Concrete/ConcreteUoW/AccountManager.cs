using BusinessLayer.Abstract.AbstractUoW;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.ConcreteUoW
{
    public class AccountManager : IAccountService
    {
        private readonly IAccountDal _accountdal;
        private readonly IUoWDal _uoWDal;

        public AccountManager(IAccountDal accountdal, IUoWDal uoWDal)
        {
            _accountdal = accountdal;
            _uoWDal = uoWDal;
        }

        public Account TGetByID(int id)
        {
          return  _accountdal.GetByID(id);
        }

        public void TInsert(Account t)
        {
            _accountdal.Insert(t);
            _uoWDal.Save();
        }

        public void TMultiUpdate(List<Account> t)
        {
            _accountdal.MultiUpdate(t);
            _uoWDal.Save();
        }

        public void TUpdate(Account t)
        {
            _accountdal.Update(t);
            _uoWDal.Save();
        }
    }
}
