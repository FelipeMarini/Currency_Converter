namespace Currency_Converter
{
    public static class Converter
    {
        public static string currencyName;
        public static float dollarQuotation;
        public static float euroQuotation;
        public static float dollarAmount;
        public static float euroAmount;
        public static float currencyAmount;
        public static int choice;
        public static float result1;
        public static float result2;
        public static float result3;
        public static float result4;



        public static float Convert_Dollar_To_Currency(float dollarAmount) {

            return  result1 = dollarQuotation * dollarAmount;
        }     
        
        public static float Convert_Currency_To_Dollar(float currencyAmount) {

            return  result2 = currencyAmount / dollarQuotation;
        }     
        
        
        public static float Convert_Euro_To_Currency(float euroAmount) {

            return  result3 = euroQuotation * euroAmount;
        }     
        
        public static float Convert_Currency_To_Euro(float currencyAmount) {

            return result4 = currencyAmount / euroQuotation;
        }     
    }
}