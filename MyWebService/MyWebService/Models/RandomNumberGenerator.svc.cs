using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWebService.Models
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RandomNumberGenerator" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RandomNumberGenerator.svc or RandomNumberGenerator.svc.cs at the Solution Explorer and start debugging.
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        public NumberModel GetRandomNumbers()
        {
            var random = new Random();
            var NumberObject = new NumberModel
            {
                RandomNumber1 = random.Next(-500, 5000),
                RandomNumber2 = random.Next(-500, 5000),
                RandomNumber3 = random.Next(-500, 5000)
            };
            return NumberObject;
        }
    }
}
