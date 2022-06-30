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
        public void UpdateInfo(int id, string name, string email, string password, string city, string country);
        void RemoveMember(int id);
        public bool IsValidateEmail(string email, out string msg);
        public bool LoginAsAdmin(string email, string password);
        public MemberObject LoginAsUser(string email, string password,out string msg);
        public MemberObject GetMember(string email, string password);
        public IEnumerable<MemberObject> DescendingSort();
        public IEnumerable<MemberObject> SortByCity(string city);
        public IEnumerable<MemberObject> SortByCountry(string country);
        public void CreateMember(MemberObject member);



    }
}
