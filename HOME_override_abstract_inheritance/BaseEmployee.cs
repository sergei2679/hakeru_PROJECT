namespace HOME_override_abstract_inheritance
{
    public abstract class BaseEmployee   //  abstract class   CAN NOT BE INSTANTIETED 
    {
        public int ID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

        public string GetFullName()        //  this method occur only from derrived class
        {
            return Fname + " " + Lname;
        }

        public abstract int GetMonthlySalary();      // override method / from derrived class

    }
}
