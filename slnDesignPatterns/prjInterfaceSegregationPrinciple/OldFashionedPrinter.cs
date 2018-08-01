namespace prjInterfaceSegregationPrinciple
{
    public class OldFashionedPrinter : IMachine
    {
        public void Print(Document d)
        {
            // Only printer function
        }

        public void Fax(Document d)
        {
            //Function not supported
        }

        public void Scan(Document d)
        {
            //Function not supported
        }
    }
}
