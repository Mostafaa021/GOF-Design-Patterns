using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    /// <summary>
    /// Creator
    /// </summary>
    public abstract class DiscountFactory
    {
        public abstract DiscountService CreateDiscountService();
    }

    /// <summary>
    /// Concrete Creator
    /// </summary>
    public class CodeDiscountFactory : DiscountFactory
    {
        private readonly Guid _code;
        public CodeDiscountFactory(Guid code)
        {
            _code = code;
        }

        public override DiscountService CreateDiscountService()
        {
            return new CodeDiscountService(_code);
        }
    }
    /// /// <summary>
    /// Concrete Creator
    /// </summary>
    public class CountryDiscountFactory : DiscountFactory
    {
        private readonly string _countryIdentifer;
        public CountryDiscountFactory(string countryIdentifier)
        {
            _countryIdentifer = countryIdentifier;
        }

        public override DiscountService CreateDiscountService()
        {
            return new CountryDiscountService(_countryIdentifer);
        }
    }
    public class GenderDiscountFactory : DiscountFactory
    {
        private readonly bool male;
        public GenderDiscountFactory(bool IsMale)
        {
            male = IsMale;
        }

        public override DiscountService CreateDiscountService()
        {
            return new GenderDiscountService(male);
        }
    }
}
