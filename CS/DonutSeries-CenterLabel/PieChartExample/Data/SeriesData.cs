using System.Collections.Generic;
using DevExpress.XamarinForms.Charts;

namespace PieChartExample.Data {
    public class SeriesData : IPieSeriesData {
        List<KeyValuePair<string, double>> data;

        public SeriesData() {
            data = new List<KeyValuePair<string, double>>() {
                new KeyValuePair<string, double>("Income", 132826.00),
                new KeyValuePair<string, double>("Growth", 208816.0),
                new KeyValuePair<string, double>("Speculation", 24700.00),
                new KeyValuePair<string, double>("Hedge", 80114.00)
            };
        }
        public int GetDataCount() => data.Count;
        public string GetLabel(int index) => data[index].Key;
        public double GetValue(int index) => data[index].Value;
        public object GetKey(int index) => null;
    }
}
