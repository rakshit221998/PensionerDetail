using PensionerDetailApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PensionerDetailApi.Services.IServices
{
    public interface IPensionerService
    {
        PensionerDetail PensionerDetailByAdhaarService(string adhaar);
    }
}
