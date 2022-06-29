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
        public MemberObject GetMember(string email, string password)
        {
            return MemBerDAO.Instace.GetMember(email, password);
        }

        void IMemBerRepository.UpdateInfo(int id, string name, string email, string password, string city, string country)
        {
            MemBerDAO.Instace.UpdateInfo(id, name, email, password, city, country);
        }

    }
}
