using BusinessObject;
using System;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public class MemBerRepository : IMemBerRepository
    {
        public IEnumerable<string> GetCityList()
        {
            return MemBerDAO.Instace.GetCityList();
        }

        public IEnumerable<string> GetCountryList()
        {
            return MemBerDAO.Instace.GetCountryList();
            //var listContry = contryList.Select(s => new { value = s }).ToList();
        }

        public IEnumerable<MemberObject> GetMemberById(int id)
        {
            return MemBerDAO.Instace.GetMemberById(id);
        }

        public IEnumerable<MemberObject> GetMemberByName(string name)
        {
            return MemBerDAO.Instace.GetMemberByName(name);
        }

       

        public bool LoginAsAdmin(string email, string password)
        {
            return MemBerDAO.Instace.LoginAsAdmin(email, password);
        }

        public MemberObject LoginAsUser(string email, string password, out string msg)
        {
            return MemBerDAO.Instace.LoginAsUser(email, password, out msg);
        }

        public IEnumerable<MemberObject> ReadAll()
        { 
            return MemBerDAO.Instace.GetAllMember();
        }

        public void RemoveMember(int id)
        {
            MemBerDAO.Instace.RemoveMember(id);
        }

        public bool IsValidateEmail(string email, out string msg)
        {
            return MemBerDAO.Instace.IsValidateEmail(email, out msg);
        }

        void IMemBerRepository.UpdateInfo(int id, string name, string email, string password, string city, string country)
        {
            MemBerDAO.Instace.UpdateInfo(id, name, email, password, city, country);
        }
        public MemberObject GetMember(string email, string password)
        {
            return MemBerDAO.Instace.GetMember(email, password);
        }
        public IEnumerable<MemberObject> DescendingSort()
        {
            return MemBerDAO.Instace.DescendingSort();
        }

        public IEnumerable<MemberObject> SortByCity(string city)
        {
            return MemBerDAO.Instace.SortByCity(city);
        }

        public IEnumerable<MemberObject> SortByCountry(string country)
        {
            return MemBerDAO.Instace.SortByCountry(country);
        }
        public void CreateMember(MemberObject member)
        {
            MemBerDAO.Instace.Create(member);
        }
    }
}
