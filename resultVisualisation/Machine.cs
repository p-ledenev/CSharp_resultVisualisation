using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace resultVisualisation
{
    class Machine : IPointList
    {
        public List<Slice> slices { get; set; }
        public double maxMoney { get; set; }
        public double endPeriodMoney { get; set; }
        public double maxLoss { get; set; }
        public String title { get; set; }

        public void addSlice(String strData)
        {
            String[] data = strData.Split(';');

            if (data[0] == null || !data[0].Any())
                return;

            Slice slice = new Slice(DateTime.Parse(data[1]), Int32.Parse(data[0]), Double.Parse(data[2].Replace('.',',')));

            slices.Add(slice);
        }

        public Machine()
        {
            slices = new List<Slice>();
        }

        public Machine(String title) : this()
        {
            this.title = title;
        }

        public PointPair this[int index]
        {
            get
            {
                return new PointPair(new XDate(slices[index].date), slices[index].value);
            }
        }

        public int Count
        {
            get { return slices.Count; }
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public DateTime getFirstDate()
        {
            return slices[0].date;
        }
        public DateTime getLastDate()
        {
            return slices[slices.Count-1].date;
        }

        public double getValueFor(Func<double, double, Boolean> comparation)
        {
            double result = slices[0].value;

            slices.ForEach(slice =>
            {
                if (comparation.Invoke(slice.value, result))
                    result = slice.value;
            }
            );

            return result;
        }
    }
}
