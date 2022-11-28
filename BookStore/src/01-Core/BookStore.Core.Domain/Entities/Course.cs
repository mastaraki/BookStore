using BookStore.Core.Domain.ValueObjects;
using System.Text.Json.Serialization;

namespace BookStore.Core.Domain.Entities
{
    public class Course : BaseEntity
    {
        public string Name { get; set; }

        public LicensingModel LicensingModel { get; set; }



        internal ExpirationDate GetExpirationDate()
        {
            ExpirationDate result;

            switch (LicensingModel)
            {

                case LicensingModel.TwoDays:
                    result = (ExpirationDate)DateTime.UtcNow.AddDays(2);
                    break;
                case LicensingModel.LifeLong:
                    result = ExpirationDate.Infinite;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return result;
        }


        internal Rial CalculatePrice(CustomerStatus status)
        {
            Rial price;

            switch (LicensingModel)
            {

                case LicensingModel.TwoDays:
                    price = Rial.of(4);
                    break;
                case LicensingModel.LifeLong:
                    price = Rial.of(8);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            if (status.IsAdvanced)
            {
                price = price * 0.75m;
            }

            return price;

        }
    }
}