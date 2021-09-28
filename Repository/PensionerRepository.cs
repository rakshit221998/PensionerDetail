using PensionerDetailApi.Model;
using PensionerDetailApi.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PensionerDetailApi.Repository
{
    public class PensionerRepository : IPensionerRepository
    {

        
        public PensionerDetail PensionerDetailByAadhar(string aadhar)
        {
            List<PensionerDetail> pensionDetails = GetDetailsCsv();
            
            return pensionDetails.FirstOrDefault(s => s.AadharNumber == aadhar);
        }
        public List<PensionerDetail> GetDetailsCsv()
        {

            List<PensionerDetail> pensionerdetail;
            pensionerdetail = new List<PensionerDetail>
               {
                   new PensionerDetail
                   {
                       Name="Dipika",
                       Dateofbirth=new DateTime(1998,06,05),
                       Pan="BCPURD",
                       SalaryEarned=20000,
                       Allowances=5000,
                       AadharNumber="111122223333",
                       PensionType=(PensionTypeValue)1,
                       BankName="hdfc",
                       AccountNumber="34HDJD",
                       BankType=(BankType)1

                   }
               };
           
                //using (StreamReader sr = new StreamReader("details.csv"))
                //{
                //    string line;
                //    while ((line = sr.ReadLine()) != null)
                //    {
                //        string[] values = line.Split(',');
                //        pensionerdetail.Add(new PensionerDetail() { Name = values[0], Dateofbirth = Convert.ToDateTime(values[1]), Pan = values[2], AadharNumber = values[3], SalaryEarned = Convert.ToInt32(values[4]), Allowances = Convert.ToInt32(values[5]), PensionType = (PensionTypeValue)Enum.Parse(typeof(PensionTypeValue), values[6]), BankName = values[7], AccountNumber = values[8], BankType = (BankType)Enum.Parse(typeof(BankType), values[9]) });
                //    }

                //}
               
               
            return pensionerdetail;
        }

    }
}
