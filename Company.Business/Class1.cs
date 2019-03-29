using System;
using System.Collections.Generic;

namespace Company.Business
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Domain { get; set; }
        public string Title { get; set; }
    }
    public class User
    {
        public Guid CompanyId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Pwd { get; set; }
    }

    public interface ICompanyRepo
    {
        void Create(Company company, User user);
        void Save(Company company);
    }
    public class CompanyService
    {
        private ICompanyRepo companyRepo;
        public CompanyService(ICompanyRepo companyRepo)
        {
            this.companyRepo = companyRepo;
        }
        public bool Create(string domain, string title, string adminEmail)
        {
            var cid = Guid.NewGuid();
            return companyRepo.Create(new Company { Id = cid, Domain = domain, Title = title }, new User { CompanyId = cid, Email = adminEmail });
        }
        public G
    }

    public interface IUserRepo
    {
        Guid Save(User user);
    }
    public class UserService
    {

    }
}
