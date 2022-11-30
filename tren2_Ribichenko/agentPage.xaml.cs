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
using System.Windows.Threading;
using tren2_Ribichenko.AppDataFile;

namespace tren2_Ribichenko
{
    /// <summary>
    /// Логика взаимодействия для agentPage.xaml
    /// </summary>
    public partial class agentPage : Page
    {
        public agentPage()
        {
            InitializeComponent();
            var currentAgents = Ribichenko_2Entities.GetContext().agents.ToList();
            LV.ItemsSource = currentAgents;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += UpdateData;
            timer.Start();

        }

        private void UpdateData(object sender, object e)
        {
            var holdrex = Ribichenko_2Entities.GetContext().agents.ToList();
            foreach (var abs in holdrex)
            {
                var coldrex = abs.history_sales1.Select(a => a.count_product);
                abs.count = (int)coldrex.Sum();
            }

            var db = Ribichenko_2Entities.GetContext().agents.ToList();

            foreach (var abs in db)
            {
                //var P_A = abs.

                double persent = (double)abs.history_sales1.Select(a => a.count_product * a.products.min_price).Sum();

                if (persent < 10000 && persent >= 0)
                {
                    abs.sale = 0;
                }
                else if (persent > 10000 && persent < 50000)
                {
                    abs.sale = 5;
                }
                else if (persent > 50000 && persent < 150000)
                {
                    abs.sale = 10;
                }
                else if (persent > 150000 && persent < 500000)
                {
                    abs.sale = 20;
                }
                else
                {
                    abs.sale = 25;
                }
            }


        }
        
    }
}
