
namespace HOME_override_abstract_inheritance
{
    public abstract class BaseEmployee   //    CAN NOT BE INTANTIETED 
    {
        public int ID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

        public string GetFullName()
        {
            return this.Fname + " " + this.Lname;
        }

        public abstract int GetMonthlySalary();

    }
}
