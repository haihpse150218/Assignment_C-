using BusinessObject;
using System;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public interface IMemBerRepository
    {
        public IEnumerable<MemberObject> ReadAll();
        public IEnumerable<MemberObject> GetMemberById(int id);
        public IEnumerable<MemberObject> GetMemberByName(string name);
        public IEnumerable<string> GetCountryList();
        public IEnumerable<string> GetCityList();
        
        public bool LoginAsAdmin(string email, string password);
        public MemberObject LoginAsUser(string email, string password,out string msg);
        public MemberObject GetMember(string email, string password);
    }
}
