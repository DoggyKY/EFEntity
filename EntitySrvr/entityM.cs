using EntitySrvr.Models;
using Microsoft.EntityFrameworkCore;
using PropertyChanged;

namespace EntitySrvr
{
    public class EntityM
    {
        public static Task<Company?> GetCompanyByFileID(SOSContext ctx,string ID, string comptype, string compseq)
        {
            if (ctx == null) ctx=new SOSContext();
            return ctx.Companies.Where(c => c.Id == ID && c.Comptype == comptype && c.Compseq == compseq).FirstOrDefaultAsync();
        }

        public static Task<List<Activity>> GetActivitiesByCompanyID(SOSContext ctx, string ID, string comptype, string compseq)
        {
            if (ctx == null) ctx = new SOSContext();
            return ctx.Activities.Where(a => a.Id == ID && a.Comptyp == comptype && a.Compseq == compseq).OrderByDescending(a => a.Dt ).ToListAsync();
        }
        public static Task<List<Officer>> GetOfficersByCompanyID(SOSContext ctx, string ID, string comptype, string compseq)
        {
            if (ctx == null) ctx = new SOSContext();
            return ctx.Officers.Where(a => a.Id == ID && a.Comptype == comptype && a.Compseq == compseq).OrderBy(p => p.Lname).ThenBy(p => p.Fname).ToListAsync();
        }
        public static Task<List<Officer>> GetOfficersByEntity(SOSContext ctx, Company entity)
        {
            return GetOfficersByCompanyID(ctx, entity.Id, entity.Comptype, entity.Compseq);
        }
    }
}