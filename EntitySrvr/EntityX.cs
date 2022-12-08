using Microsoft.Identity.Client;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Z.EntityFramework.Plus;

namespace EntitySrvr.Models
{
    public partial class SOSContext
    {
        public DbSet<AuditEntry>? AuditEntries { get; set; }
        public DbSet<AuditEntryProperty>? AuditEntryProperties { get; set; }
        static SOSContext()
        {
            AuditManager.DefaultConfiguration.AutoSavePreAction = (context, audit) =>
               // ADD "Where(x => x.AuditEntryID == 0)" to allow multiple SaveChanges with same Audit
               (context as SOSContext).AuditEntries.AddRange(audit.Entries);
        }
    }
    [AddINotifyPropertyChangedInterface] public partial class Activity { }
    [AddINotifyPropertyChangedInterface] public partial class Action { }
    [AddINotifyPropertyChangedInterface] public partial class Certificate { }
    [AddINotifyPropertyChangedInterface] public partial class Certtype { }
    [AddINotifyPropertyChangedInterface] public partial class Change { }
    [AddINotifyPropertyChangedInterface] public partial class Company { }
    [AddINotifyPropertyChangedInterface] public partial class Country { }
    [AddINotifyPropertyChangedInterface] public partial class Emailaddress { }
    [AddINotifyPropertyChangedInterface] public partial class Entitytype { }
    [AddINotifyPropertyChangedInterface] public partial class Erslog { }
    [AddINotifyPropertyChangedInterface] public partial class ErsmanageQ { }
    [AddINotifyPropertyChangedInterface] public partial class Ersqueue { }
    [AddINotifyPropertyChangedInterface] public partial class Fee { }
    [AddINotifyPropertyChangedInterface] public partial class Filmcode { }
    [AddINotifyPropertyChangedInterface] public partial class FutureAct { }
    [AddINotifyPropertyChangedInterface] public partial class FutureProcessed { }
    [AddINotifyPropertyChangedInterface] public partial class Image { }
    [AddINotifyPropertyChangedInterface] public partial class Letter { }
    [AddINotifyPropertyChangedInterface] public partial class Lettertype  { }
    [AddINotifyPropertyChangedInterface] public partial class NewArpOfficer { }
    [AddINotifyPropertyChangedInterface] public partial class NewArpOfficerChange { }
    [AddINotifyPropertyChangedInterface] public partial class NewArpOfficerDeleted { }
    [AddINotifyPropertyChangedInterface] public partial class NewArponline { }
    [AddINotifyPropertyChangedInterface] public partial class NextID { }
    [AddINotifyPropertyChangedInterface] public partial class Officer
    {
        [NotMapped] public string? FullName 
        {
            get
            {
                StringBuilder sb = new(4);
                if (Oname != null) sb.Append(Oname + " ");
                else
                {
                    if (Lname!= null)  sb.Append(Lname + ", "); 
                    if (Fname != null)  sb.Append(Fname + " ");
                    if (Mname != null) sb.Append(Mname + " ");
                }
                return sb.ToString().Trim();
            }   
        }
        [NotMapped] public string? Title
        {
            get
            {
                return !string.IsNullOrEmpty(Office) ? Offtype[Office.ToUpper()].Title : string.Empty ;       
            }
        }
        [NotMapped]public static Dictionary<string, Offtype> Offtype { get; set; }
        static Officer()
        {
            using (var ctx = new SOSContext())
            {
                Offtype = ctx.Offtypes.Select(o => o).ToDictionaryAsync(o => o.Office).GetAwaiter().GetResult();
            }

        }
    }
    [AddINotifyPropertyChangedInterface] public partial class Offtype { }
    [AddINotifyPropertyChangedInterface] public partial class OnlineFiling { }
    [AddINotifyPropertyChangedInterface] public partial class Payment { }
    [AddINotifyPropertyChangedInterface] public partial class Person
    {
        [NotMapped]
        public string? FullName
        {
            get
            {
                StringBuilder sb = new(4);
                if (Oname != null) sb.Append(Oname + " ");
                else
                {
                    if (Lname != null) sb.Append(Lname + ", ");
                    if (Fname != null) sb.Append(Fname + " ");
                    if (Mname != null) sb.Append(Mname + " ");
                }
                return sb.ToString().Trim();
            }
        }
        public string? Title
        {
            get
            {
                return Type != null ? Officer.Offtype[Type].Title : string.Empty;
            }
        }
    }
    [AddINotifyPropertyChangedInterface] public partial class Racpocreturn { }
    [AddINotifyPropertyChangedInterface] public partial class ReturnLetter { }
    [AddINotifyPropertyChangedInterface] public partial class ReturnLetterlink { }
    [AddINotifyPropertyChangedInterface] public partial class ReturnLettersubject { }
    [AddINotifyPropertyChangedInterface] public partial class ReturnLetterText { }
    [AddINotifyPropertyChangedInterface] public partial class Searchlog { }
    [AddINotifyPropertyChangedInterface] public partial class State { }
    [AddINotifyPropertyChangedInterface] public partial class Xstatus { }

}

