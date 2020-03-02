namespace HOME_override_abstract_inheritance
{
    class ContractEmployee : BaseEmployee
    {
        public ContractEmployee(int ID, string Fname, string Lname, int HourlyPay, int TotalHoursWorked)
        {
            base.ID = ID;
            base.Fname = Fname;
            base.Lname = Lname;
            GetFullName();                  // base.GetFullName()
            this.HourlyPay = HourlyPay;
            this.TotalHoursWorked = TotalHoursWorked;
        }

        public int HourlyPay { get; set; }             // תשלום לשעת עבודה
        public int TotalHoursWorked { get; set; }      // כמות שעות חודשית

        public override int GetMonthlySalary()
        {
            return this.HourlyPay * this.TotalHoursWorked;
        }
    }
}