using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace resultVisualisation
{
    class StrategiesParamsExtracter
    {
        public static String path = "results/";
        public static String fileNamePrefix = "averageMoney";

        public List<DataFileName> fileNames { get; private set; }

        public StrategiesParamsExtracter()
        {
            fileNames = new List<DataFileName>();

            foreach (String fileName in Directory.EnumerateFiles(path, fileNamePrefix + "*"))
            {
                fileNames.Add(DataFileName.buildFrom(fileName));
            }
        }

        public Object[] getYears()
        {
            return getArrayOf(fileName => fileName.year);
        }

        public Object[] getStrategies()
        {
            return getArrayOf(fileName => fileName.strategyName);
        }

        public Object[] getTickets()
        {
            return getArrayOf(fileName => fileName.ticket);
        }

        public Object[] getSieveParams()
        {
            return getArrayOf(fileName => fileName.sieveParam);
        }

        public Object[] getFillingGapsNumber()
        {
            return getArrayOf(fileName => fileName.fillingGapsNumber);
        }

        private Object[] getArrayOf(Func<DataFileName, Object> lambda)
        {
            ISet<Object> set = new SortedSet<Object>();
            fileNames.ForEach(fileName =>
            {
                set.Add(lambda.Invoke(fileName));
            });

            return toArray(set);
        }

        private Object[] toArray<T>(IEnumerable<T> enumeration)
        {
            Object[] result = new Object[enumeration.Count()];

            int i = 0;
            foreach (T element in enumeration)
            {
                result[i++] = element;
            }

            return result;
        }
    }
}
