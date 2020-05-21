namespace DisassemblyNumber
{
    class Statistics
    {
        private int number;
        private int other;
        private int digitCounter;
        private int digitSum;
        private int maxDigit;
        private int minDigit;
        private int reversed;
        private string numberStr;
        private string reversedStr;

        public Statistics(int number)
        {
            this.number = number;
            numberStr = string.Format(number.ToString());
            other = 0;
            digitCounter = 0;
            digitSum = 0;
            maxDigit = 0;
            minDigit = 0;
            reversed = 0;
            reversedStr = "";              // 290 = 092;
            SetNumber(number);
            SetDigitCounter(number);
            SetDigitSum(number);
            SetMaxDigit(number);
            SetMinDigit(number);
            SetReversed(number);
        }
        
        public Statistics(Statistics other)    // copy constructor (recomendate)
        {
            this.other = other.number;
        }
      

        // ------------------------------ number -----------
        public int GetNumber()
        {
            return number;
        }
        private void SetNumber(int number)
        {
            this.number = number;
        }

        
        // ------------------------------------- distance ---------------------

        public int Distance(int value1, int value2)
        {
            if (value1 >= value2)
                return value1 - value2;
            else
                return value2 - value1;
        }

      
        // ------------------------------  COUNT DIGITS  --------------
        public int GetDigitCounter()
        {
            return digitCounter;
        }

        private void SetDigitCounter(int number)
        {
            while (number > 0)
            {
                digitCounter += 1;
                number /= 10;
            }
        }

        // ------------------------------  SUM DIGITS  --------------
        private static int DigitSum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        private void SetDigitSum(int number)
        {
            digitSum = DigitSum(number);      // for each new instance of class include  'digitSum' has own static 'DigitSum(number)'
        }

        public int GetDigitSum()
        {
            return digitSum;
        }

        // ------------------------------  MAX DIGIT  --------------
      
        private static int MaxDigit(int num)    //  num = 812
        {
            int max = 0;
            while (num > 0)
            {
                if (max < num % 10)
                    max = num % 10;     // max = 2                                  
                num /= 10;              // num = 81 // num = 8
            }
            return max;
        }
        private void SetMaxDigit(int number)    //  num = 812
        {
            maxDigit = MaxDigit(number);
        }

        public int GetMaxDigit()    //  num = 812
        {
            return maxDigit;
        }

        // ------------------------------  MIN DIGIT  --------------
        private static int MinDigit(int num)    //  num = 812
        {
            int min = num;
            while (num > 0)
            {
                if (min > num % 10)
                    min = num % 10;                                      
                num /= 10;        
            }
            return min;
        }

        private void SetMinDigit(int num)   
        {
            minDigit = MinDigit(num);
        }

        public int GetMinDigit()    //  num = 812
        {
            return minDigit;
        }


        // ------------------------------  REVERSE DIGITS  --------------

        private void Reversed(int number)   
        {
            int remainder;

            while (number != 0)
            {
                remainder = number % 10;
                reversed = reversed * 10 + remainder;       //  num = 290 
                reversedStr += remainder.ToString();
                number /= 10;
            }
        }
        public int GetReversed()    //  num = 290 
        {
            return reversed;
        }

        private void SetReversed(int number)    //  num = 290 
        {
            Reversed(number);
        }

        // ------------------------------  INFO  --------------

        public string toString()
        {
            return
                    "\n   number "         + numberStr +
                    "\n ---------------- | -----------" +
                    "\n   Reversed       | " + reversedStr    +
                    "\n   Max Digit      | " + maxDigit       +
                    "\n   Min Digit      | " + minDigit       +
                    "\n   Sum Digits     | " + digitSum       +
                    "\n   Count Digits   | " + digitCounter   + 
                    "\n ----------------   -----------";

        }
    }
}
