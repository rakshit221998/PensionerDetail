using PensionerDetailApi.Model;
using PensionerDetailApi.Repository.IRepository;
using PensionerDetailApi.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PensionerDetailApi.Services
{
    public class PensionerService : IPensionerService
    {
        private IPensionerRepository pensionerRepository;

        public PensionerService(IPensionerRepository pensionerRepository)
        {
            this.pensionerRepository = pensionerRepository;
        }

        public PensionerDetail PensionerDetailByAdhaarService(string adhaar)
        {
            PensionerDetail pensioner = pensionerRepository.PensionerDetailByAadhar(adhaar);
            return pensioner;
        }


    }
}
