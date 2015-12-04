using System;

namespace resultVisualisation
{
    internal class DataFileName
    {
        public Int32 year { get; set; }
        public String ticket { get; set; }
        public String strategyName { get; set; }
        public Double sieveParam { get; set; }
        public Int32 fillingGapsNumber { get; set; }

        public static DataFileName buildFrom(String fileName)
        {
            String[] parameters = fileName.Split('_');

            return new DataFileName
            {
                year = Int32.Parse(parameters[2]),
                ticket = parameters[1],
                sieveParam = Double.Parse(parameters[3].Replace(".", ",")),
                fillingGapsNumber = Int32.Parse(parameters[4]),
                strategyName = parameters[5].Split('.')[0]
            };


        }
    }
}
