using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccess.Repository;
using DataAccess;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        void IMemberRepository.DeleteMember(int memberId)
        {
            throw new NotImplementedException();
        }

        MemberObject IMemberRepository.GetMemberById(int memberId) => MemberDAO.Instance.GetMemberById(memberId);

        IEnumerable<MemberObject> IMemberRepository.GetMemberList() => MemberDAO.Instance.GetMemberList();

        void IMemberRepository.InsertMember(MemberObject member)
        {
            throw new NotImplementedException();
        }

        void IMemberRepository.UpdateMember(MemberObject member)
        {
            throw new NotImplementedException();
        }
    }
}
