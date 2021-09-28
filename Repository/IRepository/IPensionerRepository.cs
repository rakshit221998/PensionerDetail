using PensionerDetailApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PensionerDetailApi.Repository.IRepository
{
    public interface IPensionerRepository
    {
    
        PensionerDetail PensionerDetailByAadhar(string aadhar);
    }
}
