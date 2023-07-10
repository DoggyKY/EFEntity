using EFEntityMgr.DataSet1TableAdapters;
using EntitySrvr;
using EntitySrvr.Models;
using Microsoft.EntityFrameworkCore;
using PropertyChanged;
using ClassLibrary1;

namespace EFEntityMgr
{
    public partial class Form1 : Form
    {
        Company? bgrr;
        List<Activity>? acts;
        SOSContext ctx, ctxact;
        List<Officer> offs;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            ctx = new SOSContext();
            ctxact = new SOSContext();
            //ctx.SavingChanges += Ctx_SavingChanges;
            bgrr = await EntityM.GetCompanyByFileID(ctx, "0062584", "09", "99999");
            if (bgrr == null) return;
            acts = await EntityM.GetActivitiesByCompanyID(ctxact, bgrr.Id, bgrr.Comptype, bgrr.Compseq);
            offs = await EntityM.GetOfficersByCompanyID(ctxact, bgrr.Id, bgrr.Comptype, bgrr.Compseq);
            bsCompany.DataSource = bgrr;
            bsActs.DataSource = acts;
            //var ata = new ActionsTableAdapter()
            var atd = await Task.Run(() => ActionsM.GetActions());
            var etd = Task.Run(() => EntitytypesM.GetEntitytypes()).GetAwaiter().GetResult();
            var aoc = await AocM.GetAOCCodes();
            bsaocs.DataSource = aoc;
        }



        private async void button2_Click(object sender, EventArgs e)
        {
            bsActs.EndEdit();
            await ctxact.SaveChangesAsync();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            bsCompany.EndEdit();
            await ctx.SaveChangesAsync();
        }

        private void Ctx_SavingChanges(object? sender, SavingChangesEventArgs e)
        {
            var str = ctx.ChangeTracker.DebugView;
        }
    }
}
