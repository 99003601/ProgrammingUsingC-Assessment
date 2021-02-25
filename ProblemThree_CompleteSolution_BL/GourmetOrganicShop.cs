using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetOrganicShop : GourmetShop,ITaxCompute
    {
        public double totalBillValue { get; set; }


        public GourmetOrganicShop()
        {

        }

        public GourmetOrganicShop(int iCode, String iName, Dictionary<int, double> iPrice) : base(iCode, iName, iPrice)
        {
            ItemCode = iCode;
            ItemName = iName;
            ItemPrice = iPrice;
        }

        public override double PayPerPiece(int quantity)
        {
            throw new NotImplementedException();
        }

        public override double PayPerWeight(int weight)
        {
            throw new NotImplementedException();
        }

        double ITaxCompute.TaxOnTotalBill()
        {
            throw new NotImplementedException();
        }

    }
}
