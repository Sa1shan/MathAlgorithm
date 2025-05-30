namespace MathAlgorithm;

public class Program
{
    public static TwoArrow twoArrow = new TwoArrow();
    public static HIndex HIndex = new HIndex();
    public static FindNumber FindNumber = new FindNumber();
    public static ChangeSymbol ChangeSymbol = new ChangeSymbol();
    
    static void Main(string[] args)
    {
        twoArrow.FindNumberTwoArrow();
        // HIndex.FindHIndex();
        // FindNumber.FindNumberInTable();
        // ChangeSymbol.SymbolChenging();
    }
}