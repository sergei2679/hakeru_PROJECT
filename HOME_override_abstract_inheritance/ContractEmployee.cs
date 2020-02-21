
namespace HOME_override_abstract_inheritance
{
    class ContractEmployee : BaseEmployee
    {
        public int HourlyPay { get; set; }        // תשלום לשעת עבודה
        public int TotalHoursWorked { get; set; }      // כמות שעות חודשית

        public override int GetMonthlySalary()
        {
            return this.HourlyPay * this.TotalHoursWorked;
        }
    }
}
