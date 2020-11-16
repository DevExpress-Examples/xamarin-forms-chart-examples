using PieChartExample.Data;

namespace PieChartExample.ViewModels {
    public class MainViewModel {
        readonly SeriesData donutSeriesData;

        public SeriesData DonutSeriesData => donutSeriesData;
        public string DonutCenterLabelPattern => "Total\n{TV}";

        public MainViewModel() {
            donutSeriesData = new SeriesData();
        }
    }
}
