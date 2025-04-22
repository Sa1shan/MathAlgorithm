namespace MathAlgorithm;

public class Program
{
    public static TwoArrow twoArrow = new TwoArrow();
    public static SquareRoot squareRoot = new SquareRoot();
    public static HIndex HIndex = new HIndex();
    public static FindNumber FindNumber = new FindNumber();
    public static RobingHouses RobingHouses = new RobingHouses();
    
    static void Main(string[] args)
    {
        // twoArrow.FindNumberTwoArrow();
        // squareRoot.FindSquareRoot();
        HIndex.FindHIndex();
        // FindNumber.FindNumberInTable();
        // RobingHouses.FindRobingHouses();
    }
}