﻿using BusinessObject;
using System;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public class MemBerRepository : IMemBerRepository
    {
        public IEnumerable<MemberObject> DescendingSort()
        {
            return MemBerDAO.Instace.DescendingSort();
        }

        public IEnumerable<string> GetCityList()
        {
            return MemBerDAO.Instace.GetCityList();
        }

        public IEnumerable<string> GetCountryList()
        {
            return MemBerDAO.Instace.GetCountryList();
            //var listContry = contryList.Select(s => new { value = s }).ToList();
        }

        public IEnumerable<MemberObject> GetMemberByCity(string city)
        {
            return MemBerDAO.Instace.GetMemberByCity(city);
        }

        public IEnumerable<MemberObject> GetMemberByCountry(string country)
        {
            return MemBerDAO.Instace.GetMemberByCountry(country);
        }

        public IEnumerable<MemberObject> GetMemberById(int id)
        {
            return MemBerDAO.Instace.GetMemberById(id);
        }

        public IEnumerable<MemberObject> GetMemberByName(string name)
        {
            return MemBerDAO.Instace.GetMemberByName(name);
        }

        public bool Login(string email, string password, out string msg)
        {
            return MemBerDAO.Instace.Login(email, password, out msg);
        }

        public IEnumerable<MemberObject> ReadAll()
        { 
            return MemBerDAO.Instace.GetAllMember();
        }
    }
}
