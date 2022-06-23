using BusinessObject;
using System;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public interface IMemBerRepository
    {
        public IEnumerable<MemberObject> ReadAll();
        public IEnumerable<MemberObject> GetMemberById(int id);
    }
}
