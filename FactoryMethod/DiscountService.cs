using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    /// <summary>
    /// Product
    /// </summary>
    public abstract class DiscountService
    {
        public abstract int DiscountPrecentage { get; }
        public override string ToString() => GetType().Name;

    }
    /// <summary>
    ///  Concrete Product
    /// </summary>
    public class CodeDiscountService : DiscountService
    {
        private readonly Guid _code;
        public CodeDiscountService(Guid code)
        {
            _code = code;
        }
        public override int DiscountPrecentage
        {
            get => 10;

        }
    }
    /// <summary>
    ///  Concrete Product
    /// </summary>
    public class CountryDiscountService : DiscountService
    {
        private readonly string _countryIdentrifer;
        public CountryDiscountService(string countryIdentifier)
        {
            _countryIdentrifer = countryIdentifier;
        }
        public override int DiscountPrecentage
        {
            get
            {
                switch (_countryIdentrifer)
                {
                    case "EGY":
                        return 30;
                    case "BE":
                        return 15;
                    default:
                        return 10;
                }
            }
        }

    }
    public class GenderDiscountService : DiscountService
    {
        private readonly bool male;
        public GenderDiscountService(bool IsMale)
        {
            male = IsMale;
        }
        public override int DiscountPrecentage
        {
            get => 50;

        }
    }

}
