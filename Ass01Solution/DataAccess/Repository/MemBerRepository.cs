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

        public IEnumerable<MemberObject> ReadAll()
        { 
            return MemBerDAO.Instace.GetAllMember();
        }
    }
}
