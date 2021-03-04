using System.Collections.Generic;
using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(I=>I.Email == email);
        }

        public List<OperationClaim> GetClaim(User user)
        {
            return _userDal.GetClaims(user);
        }
    }
}