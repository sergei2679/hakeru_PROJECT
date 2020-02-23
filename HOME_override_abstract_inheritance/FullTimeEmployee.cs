namespace HOME_override_abstract_inheritance
{
    class FullTimeEmployee : BaseEmployee      
    {
        public FullTimeEmployee(int ID, string Fname, string Lname, int AnnualSalary)
        {
            base.ID = ID;
            base.Fname = Fname;
            base.Lname = Lname;
            GetFullName();                   //  base.GetFullName();
            this.AnnualSalary = AnnualSalary;
        }
        public int AnnualSalary { get; set; }     //  סך הכל סכום משכורת שנתית של עובד במשרה מלאה

        public override int GetMonthlySalary()    //  חישוב משכורת חודשית
        {
            return AnnualSalary / 12;
        }
    }
}
