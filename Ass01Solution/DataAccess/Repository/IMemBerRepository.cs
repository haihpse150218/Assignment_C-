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
        public IEnumerable<MemberObject> GetMemberByCountry(string country);
        public IEnumerable<MemberObject> GetMemberByCity(string city);
        public IEnumerable<MemberObject> DescendingSort();
        public IEnumerable<string> GetCountryList();
        public IEnumerable<string> GetCityList();
        public bool Login(string email, string password, out string msg);
    }
}
