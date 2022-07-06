using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson01exercise3
{
    class MedicalRecord
    {
        public string strPatientName;
        public string strDoctorName;
        public float fltFees;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MedicalRecord objM1;
            objM1= new MedicalRecord();
            Console.Write("patient name: ");
            objM1.strPatientName = Console.ReadLine();
            Console.Write("doctor name: ");
            objM1.strDoctorName = Console.ReadLine();
            Console.Write("fees: ");
            objM1.fltFees = float.Parse(Console.ReadLine());

            MedicalRecord objM2;
            objM2= new MedicalRecord();
            Console.Write("patient name 2: ");
            objM2.strPatientName = Console.ReadLine();
            Console.Write("doctor name 2: ");
            objM2.strDoctorName = Console.ReadLine();
            Console.Write("fees: ");
            objM2.fltFees = float.Parse(Console.ReadLine());

            Console.WriteLine("Patient Name is {0}, Doctor Name is {1}, Fees: {2}, Patient Name 2 is {3}, Doctor Name 2 is {4}, Fees: {5}", objM1.strPatientName, objM1.strDoctorName, objM1.fltFees, objM2.strPatientName, objM2.strDoctorName, objM2.fltFees);

        }
    }
}
