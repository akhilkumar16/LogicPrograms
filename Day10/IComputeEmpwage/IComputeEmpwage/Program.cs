using System;
using System.Collections.Generic;
using static IComputeEmpwage.IComputeEmpwage;

namespace IComputeEmpwage
{
    public class EmpwageBuilder : IComputeEmpwage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private LinkedList<companyEmpwage> companyEmpwageList;
        private object companyToEmpwageMap;
        private object comapnyToEmpwageMap;
        private object totalEmpwage;

        private Dictionary<string, companyToEmpwageMap>
            public EmpwageBuilder()
        {
            this.companyEmpwageList = new LinkedList<companyEmpwage>();
            this.companyToEmpwageMap = new Dictionary<string, companyEmpwage>();
        }
        public void addcompanyEmpwage(string company , int empRateperHour, int numofWorkingDays, int maxHoursperMonth)
        {
            companyEmpwage companyEmpwage = new companyEmpwage(company, empRateperHour, numofWorkingDays, maxHoursperMonth);
            this.companyEmpwageList.AddLast(companyEmpwage);
            this.companyToEmpwageMap.Add(company, companyEmpwage);
        }
        public void computeEmpwage()
        {
            foreach ( CompanyEmpwage companyEmpwage in this.companyEmpwageList)
            {
                companyEmpwage.setTotalEmpwage(this.computeEmpwage(computeEmpwage));
                Console.WriteLine(companyEmpwage.ToString());
            }
        }

        private object computeEmpwage(Action computeEmpwage)
        {
            throw new NotImplementedException();
        }

        private int ComputeEmpwage(CompanyEmpwage companyEmpwage)
            public int getTotalwage(string company)
        {
            return comapnyToEmpwageMap[company],totalEmpwage;
        }

        public void AddcompanyEmpwage(string company, int empRAtePerHour, int numOfworkingDays, int maxHourPerMonth)
        {
            throw new NotImplementedException();
        }

        public void ComputeEmpwage()
        {
            throw new NotImplementedException();
        }

        public int GetTotalwage(string company)
        {
            throw new NotImplementedException();
        }

        private class companyEmpwage
        {
            public companyEmpwage(string company, int empRateperHour, int numofWorkingDays, int maxHoursperMonth)
            {
            }
        }
    }

    internal class companyToEmpwageMap
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            EmpwageBuilder empwageBuilder = new EmpwageBuilder();
            empwageBuilder.addcompanyEmpwage("DMART", 20, 2, 10);
            empwageBuilder.addcompanyEmpwage("RELIANCE", 10, 4, 20);
            empwageBuilder.computeEmpwage();
            Console.WriteLine("Total wage for Dmart company : " + empwageBuilder.getTotalwage("Dmart"));
        }
    }
}