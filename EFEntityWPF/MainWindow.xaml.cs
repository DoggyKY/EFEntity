using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
using EntitySrvr;
using EntitySrvr.Models;
using Microsoft.EntityFrameworkCore;
using static EntitySrvr.EntityM;
using Z.EntityFramework.Plus;
using System.Collections.ObjectModel;

namespace EFEntityWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
 
    public partial class MainWindow : Window
    {
        Company? bgrr;
        ObservableCollection<Activity>? acts;
        SOSContext? ctx, ctxoff;
        ObservableCollection<Officer>? offs;

        public  MainWindow()
        {
            InitializeComponent();
            ctx = new();
            ctxoff = new();
            SetupCompany();
         }

        private async void bSave_Click(object sender, RoutedEventArgs e)
        {
            await ctx.SaveChangesAsync(new Audit());
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SetupCompany();
        }

        private async void boffSave_Click(object sender, RoutedEventArgs e)
        {
            await ctxoff.SaveChangesAsync(new Audit());
        }
        private void bNewOff_Click(object sender, RoutedEventArgs e)
        {
            Officer no = new();
            no.Id = bgrr?.Id;
            no.Comptype = bgrr?.Comptype;
            no.Compseq = bgrr?.Compseq;
            no.Office = "";
            no.Fname = "new officer";
            offs?.Add(no);
            ctxoff?.Officers.Add(no);
        }
        private void bOffDel_Click(object sender, RoutedEventArgs e)
        {   if (dataGrid.SelectedItem != null)
            {
               ctxoff?.Officers.Remove(dataGrid.SelectedItem  as Officer);
               var ok = offs?.Remove(dataGrid.SelectedItem as Officer);
            }
         }
        async void SetupCompany()
        {
           bgrr = await GetCompanyByFileID(ctx, "0062584", "09", "99999");
            
            offs = new(await GetOfficersByEntity(ctxoff,  bgrr));
            this.DataContext = bgrr;
            dataGrid.DataContext = offs;
            dataGrid.ItemsSource = offs;
        }
    }
}
