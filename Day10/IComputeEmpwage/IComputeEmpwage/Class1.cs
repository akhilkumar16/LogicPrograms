using System;
using System.Collections.Generic;
using System.Text;

namespace IComputeEmpwage
{
    public interface IComputeEmpwage
    {
        public void AddcompanyEmpwage(string company, int empRAtePerHour, int numOfworkingDays, int maxHourPerMonth);
        public void ComputeEmpwage();
        public int GetTotalwage(string company);

        public class CompanyEmpwage
        {
            internal void setTotalEmpwage(object p)
            {
                throw new NotImplementedException();
            }
        }

        public string comapny;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpwage;
        public CompanyEmpwage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.comapny = company;
            this.numOfWorkingDays = numOfWorkingDays;
            this.empRatePerHour = empRatePerHour;
            this.maxHoursPerMonth = maxHoursPerMonth;
            this.totalEmpwage = 0;
        }
        public void SetTotalEmpwage(int totalEmpwage)
        {
            this.totalEmpwage = totalEmpwage;
        }
        public string Tostring()
        {
            return "Total emp wage for comapny : " + this.comapny + " is: " + this.totalEmpwage;
        }
    }
}
