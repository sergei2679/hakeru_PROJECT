
namespace HOME_override_abstract_inheritance
{
    class FullTimeEmployee : BaseEmployee      
    {
        public int AnnualSalary { get; set; }             //  משכורת שנתית

        public override int GetMonthlySalary()              //  חישוב משכורת חודשית
        {
            return AnnualSalary / 12;
        }
    }
}
