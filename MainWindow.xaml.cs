using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Map;

namespace VectorTiles_Wpf {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            MapControl map = new MapControl() {
                CenterPoint = new GeoPoint(51.5, 0),
                ZoomLevel = 14 //road names for screenshot 1
                //ZoomLevel = 13.5 //fractional zoom level for screenshot 2
                //ZoomLevel = 17 //overscaled zoom level for screenshot 3
            };
            ImageLayer layer = new ImageLayer();
            MbTilesDataProvider dataProvider = new MbTilesDataProvider() { FileUri = new Uri(@"\\corp\internal\common\4pshenichny\VectorTileRenderer\2017-07-03_great-britain_england.mbtiles") };
            layer.DataProvider = dataProvider;
            map.Layers.Add(layer);
            this.grid.Children.Add(map);
        }
    }
}
