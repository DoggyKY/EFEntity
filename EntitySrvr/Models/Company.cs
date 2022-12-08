﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntitySrvr.Models;

[Table("company")]
[Index("Pozip", Name = "Co_POZip")]
[Index("Comptype", "Status", Name = "Comp_idx")]
[Index("Id", "Comptype", "Compseq", Name = "Company_idx", IsUnique = true)]
[Index("Cbi", Name = "company_CBI")]
[Index("Type", "Comptype", "Status", Name = "company_Type_Comptype_status")]
[Index("Authdate", Name = "company_authdatex")]
[Index("Chgdate", Name = "company_chgdatex")]
[Index("Filedate", Name = "company_filedatex")]
[Index("KyGovId", Name = "company_kygovid")]
[Index("Name", Name = "company_namex")]
[Index("Orgdate", Name = "company_orgdatex")]
[Index("Raresdte", Name = "company_raresdtex")]
[Index("Recorddate", "Status", "Type", Name = "company_recorddatex")]
[Index("Status", "Raname", Name = "company_status_raname_for_ra_search")]
[Index("Type", Name = "company_typex")]
[Index("Pocity", "Status", Name = "idx_City_Search")]
[Index("Pocity", Name = "idx_Company_CitySearch")]
[Index("Status", "Type", "Pocity", Name = "idx_Company_CitySearch_Type")]
[Index("Type", "Status", "Profit", Name = "idx_Company_Profit")]
[Index("Status", "Type", Name = "idx_Company_Status_Type")]
[Index("Type", "Status", Name = "idx_Company_Type_Status")]
[Index("Veteranowned", "Status", "Recorddate", Name = "idx_Company_VetOwned")]
[Index("Pozip", Name = "idx_Company_ZipSearch")]
[Index("Nameindex", Name = "namex")]
public partial class Company
{
    /// <summary>
    /// System-assigned numeric ID of this entity, non-unique. This is the official organization number given to a business when it is registered with the Secretary of State. The unique combination of ID, Comptype, and Compseq defines a company record. Related companies share the same ID.  Older versoins of the company (for example when a company is renamed by amendment) share an ID and comptype with different compseq.  An LLC (type 06) and its assumed names (type 12) share the same ID.  This file can be extended to link the initial officers associated with the business contained in &apos;All Initial Officers&apos; with the field &apos;ID&apos;.  Additionally, all current officers associated with a business contained in &apos;All Officers&apos; may be joined by using the combination of &apos;ID&apos; with &apos;comptype&apos; and &apos;compseq&apos;.
    /// </summary>
    [Column("ID")]
    [StringLength(7)]
    [Unicode(false)]
    public string Id { get; set; }

    /// <summary>
    /// Numeric entity type. Defined in entitytype
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string Comptype { get; set; }

    /// <summary>
    /// Company sequence is defined as a numeric value starting at 99999 and goes downward as new assumed names are added, or as the company is renamed. For a given ID-comptype combination, starts with 99999
    /// </summary>
    [StringLength(5)]
    [Unicode(false)]
    public string Compseq { get; set; }

    /// <summary>
    /// The name of the entity as shown on its organizing document. Official business name registered with the Secretary of State.
    /// </summary>
    [StringLength(255)]
    [Unicode(false)]
    public string Name { get; set; }

    /// <summary>
    /// G = good, B= bad. Bad means a annual report is late, or the entity was administratively dissolved. Null = ARP not required.
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string Standing { get; set; }

    /// <summary>
    /// A=active, I=inactive, X=pending dissolution, K=New Ky.Gov filing (not approved yet), N=New paper filing, not verified yet, D=Deleted. H = Historical Record (old and inactive, entered only so that we can destroy the old paper records)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string Status { get; set; }

    /// <summary>
    /// The country the entity was filed in, if not the USA.
    /// </summary>
    [StringLength(255)]
    [Unicode(false)]
    public string Country { get; set; }

    /// <summary>
    /// Two character state or country code, defined in states table.
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string State { get; set; }

    /// <summary>
    /// Three character company type, defined in entitytypes table
    /// </summary>
    [StringLength(3)]
    [Unicode(false)]
    public string Type { get; set; }

    /// <summary>
    /// registered agent name, or &apos;KY SEC OF STATE&apos; if agent resigned
    /// </summary>
    [Column("RAname")]
    [StringLength(255)]
    [Unicode(false)]
    public string Raname { get; set; }

    /// <summary>
    /// Registered agent address, line 1
    /// </summary>
    [Column("RAaddr1")]
    [StringLength(255)]
    [Unicode(false)]
    public string Raaddr1 { get; set; }

    /// <summary>
    /// Registered agent address, line 2
    /// </summary>
    [Column("RAaddr2")]
    [StringLength(50)]
    [Unicode(false)]
    public string Raaddr2 { get; set; }

    /// <summary>
    /// Registered agent address, line 3
    /// </summary>
    [Column("RAaddr3")]
    [StringLength(50)]
    [Unicode(false)]
    public string Raaddr3 { get; set; }

    /// <summary>
    /// Registered agent address, line 4
    /// </summary>
    [Column("RAaddr4")]
    [StringLength(50)]
    [Unicode(false)]
    public string Raaddr4 { get; set; }

    /// <summary>
    /// Registered agent address city name
    /// </summary>
    [Column("RAcity")]
    [StringLength(32)]
    [Unicode(false)]
    public string Racity { get; set; }

    /// <summary>
    /// Registered agent address 2 char state code, must be KY
    /// </summary>
    [Column("RAstate")]
    [StringLength(2)]
    [Unicode(false)]
    public string Rastate { get; set; }

    /// <summary>
    /// Registered agent address zip code
    /// </summary>
    [Column("RAzip")]
    [StringLength(10)]
    [Unicode(false)]
    public string Razip { get; set; }

    /// <summary>
    /// Principal office address line 1
    /// </summary>
    [Column("POAddr1")]
    [StringLength(255)]
    [Unicode(false)]
    public string Poaddr1 { get; set; }

    /// <summary>
    /// Principal office address line 2
    /// </summary>
    [Column("POAddr2")]
    [StringLength(50)]
    [Unicode(false)]
    public string Poaddr2 { get; set; }

    /// <summary>
    /// Principal office address line 3
    /// </summary>
    [Column("POAddr3")]
    [StringLength(50)]
    [Unicode(false)]
    public string Poaddr3 { get; set; }

    /// <summary>
    /// Principal office address line 4
    /// </summary>
    [Column("POAddr4")]
    [StringLength(50)]
    [Unicode(false)]
    public string Poaddr4 { get; set; }

    /// <summary>
    /// Principal office address city
    /// </summary>
    [Column("POCity")]
    [StringLength(32)]
    [Unicode(false)]
    public string Pocity { get; set; }

    /// <summary>
    /// Principal office address state or country defined in states table
    /// </summary>
    [Column("POState")]
    [StringLength(2)]
    [Unicode(false)]
    public string Postate { get; set; }

    /// <summary>
    /// Principal office address postal code
    /// </summary>
    [Column("POZip")]
    [StringLength(10)]
    [Unicode(false)]
    public string Pozip { get; set; }

    /// <summary>
    /// This field contains the date the business record was filed with the Secretary of State.  A business record contains either filedate, orgdate, or authdate, whichever is appropriate for the company type.
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? Filedate { get; set; }

    /// <summary>
    /// This field contains the date the LLC was filed with the Secretary of State.  A business record contains either filedate, orgdate, or authdate, whichever is appropriate for the company type.
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? Orgdate { get; set; }

    /// <summary>
    /// This field contains the date the business record has authority to operate in the Commonwealth.  This field only contains an entry for foreign businesses.  A business record contains either filedate, orgdate, or authdate, whichever is appropriate for the company type.
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? Authdate { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string Numofcr { get; set; }

    /// <summary>
    /// Ten numeric digits, profit corporations total number of authorized shares of stock. Used to compute organizational tax
    /// </summary>
    [Column("numofshr")]
    [StringLength(10)]
    [Unicode(false)]
    public string Numofshr { get; set; }

    /// <summary>
    /// Registered agent resign date
    /// </summary>
    [Column("raresdte", TypeName = "datetime")]
    public DateTime? Raresdte { get; set; }

    /// <summary>
    /// Expiration date of entity, as defined in its organizational document, or as defined by statute for assumed names
    /// </summary>
    [Column("expdte", TypeName = "datetime")]
    public DateTime? Expdte { get; set; }

    /// <summary>
    /// LLC tpe of management, 1=by members, 2=by management.
    /// </summary>
    [Column("mangnum")]
    [StringLength(1)]
    [Unicode(false)]
    public string Mangnum { get; set; }

    /// <summary>
    /// Date as assumed name or name reservation was renewed.
    /// </summary>
    [Column("rendte", TypeName = "datetime")]
    public DateTime? Rendte { get; set; }

    [Column("applname")]
    [StringLength(50)]
    [Unicode(false)]
    public string Applname { get; set; }

    [Column("appltitl")]
    [StringLength(50)]
    [Unicode(false)]
    public string Appltitl { get; set; }

    /// <summary>
    /// Date last annual report was filed
    /// </summary>
    [Column("lastrdte", TypeName = "datetime")]
    public DateTime? Lastrdte { get; set; }

    /// <summary>
    /// Date previous annual report was filed
    /// </summary>
    [Column("prevrdte", TypeName = "datetime")]
    public DateTime? Prevrdte { get; set; }

    /// <summary>
    /// 10 numeric digits, preferred shares of stock. Rolled into numofshr. deprecated.
    /// </summary>
    [Column("parpre")]
    [StringLength(10)]
    [Unicode(false)]
    public string Parpre { get; set; }

    /// <summary>
    /// 10 numeric digits, number of common nopar shares of stock. Rolled into numofshr.Deprecated
    /// </summary>
    [Column("parcomno")]
    [StringLength(10)]
    [Unicode(false)]
    public string Parcomno { get; set; }

    /// <summary>
    /// 10 numeric digits, number of common shares of stock. Rolled into numofshr. Deprecated.
    /// </summary>
    [Column("parcom")]
    [StringLength(10)]
    [Unicode(false)]
    public string Parcom { get; set; }

    /// <summary>
    /// 10 numeric digits. Number of preferred nopar shares.  Rolled into numofshr. Deprecated.
    /// </summary>
    [Column("parpreno")]
    [StringLength(10)]
    [Unicode(false)]
    public string Parpreno { get; set; }

    /// <summary>
    /// A normalized version of the company name, used for searches and name availability
    /// </summary>
    [Column("nameindex")]
    [StringLength(50)]
    [Unicode(false)]
    public string Nameindex { get; set; }

    /// <summary>
    /// For corporation and LLCs, P=profit, N=non-profit.
    /// </summary>
    [Column("profit")]
    [StringLength(1)]
    [Unicode(false)]
    public string Profit { get; set; }

    /// <summary>
    /// A location for archived documents for this entity
    /// </summary>
    [Column("docloc")]
    [StringLength(8)]
    [Unicode(false)]
    public string Docloc { get; set; }

    /// <summary>
    /// A single field showing the date the company was first recorded in Kentucky, comes from orgdate, authdate, filedate as appropriate
    /// </summary>
    [Column("recorddate", TypeName = "datetime")]
    public DateTime? Recorddate { get; set; }

    /// <summary>
    /// SQl assigned unique key for the record.
    /// </summary>
    [Key]
    [Column("ctr")]
    public int Ctr { get; set; }

    [Column("chgdate", TypeName = "datetime")]
    public DateTime? Chgdate { get; set; }

    [Column("FEIN")]
    [StringLength(1000)]
    [Unicode(false)]
    public string Fein { get; set; }

    [Column("termdate", TypeName = "datetime")]
    public DateTime? Termdate { get; set; }

    /// <summary>
    /// Deprecated.  Was a 4-digit random pin number for filing online annual reports
    /// </summary>
    [Column("arppin")]
    [StringLength(4)]
    [Unicode(false)]
    public string Arppin { get; set; }

    /// <summary>
    /// Date the entity met requirements of KRS 277??
    /// </summary>
    [Column("krs277date", TypeName = "datetime")]
    public DateTime? Krs277date { get; set; }

    /// <summary>
    /// Indication of whether an annual report or assumed name renewal has been printed
    /// </summary>
    [Column("printed")]
    public bool Printed { get; set; }

    [Column("longform", TypeName = "text")]
    public string Longform { get; set; }

    /// <summary>
    /// The entity is a coop
    /// </summary>
    [Column("coop")]
    public bool? Coop { get; set; }

    [Column("dontchange")]
    public bool? Dontchange { get; set; }

    /// <summary>
    /// The entity is a coop under KRS 279
    /// </summary>
    [Column("coop279")]
    public bool? Coop279 { get; set; }

    /// <summary>
    /// For online KY.Gov filings, the XML document submitted by Ky.Gov
    /// </summary>
    [Column("KyGovXML")]
    [Unicode(false)]
    public string KyGovXml { get; set; }

    /// <summary>
    /// The purpose of a professional service corporation, for online Ky.Gov filings only.
    /// </summary>
    [StringLength(1000)]
    [Unicode(false)]
    public string Purpose { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string FilerName { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string FilerAddr1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string FilerAddr2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string FilerAddr3 { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string FilerCity { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string FilerState { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string FilerZip { get; set; }

    /// <summary>
    /// userid of original Secretary of State filing officer.
    /// </summary>
    [Column("userid")]
    [StringLength(50)]
    [Unicode(false)]
    public string Userid { get; set; }

    /// <summary>
    /// Email address for annual report notification.
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Unique ID assigned by Ky.Gov to a filing made online.
    /// </summary>
    [Column("KyGovID")]
    public int? KyGovId { get; set; }

    /// <summary>
    /// Internal use. indicates an annual report has been printed for this entity.
    /// </summary>
    public bool? Arpprinted { get; set; }

    [Column("CBI")]
    [StringLength(10)]
    public string Cbi { get; set; }

    [Column("RAprefix")]
    [StringLength(255)]
    public string Raprefix { get; set; }

    [Column("RAfname")]
    [StringLength(255)]
    public string Rafname { get; set; }

    [Column("RAmname")]
    [StringLength(255)]
    public string Ramname { get; set; }

    [Column("RAlname")]
    [StringLength(255)]
    public string Ralname { get; set; }

    [Column("RAsuffix")]
    [StringLength(255)]
    public string Rasuffix { get; set; }

    [Column("RAoname")]
    [StringLength(255)]
    public string Raoname { get; set; }

    [Column("ERSCountry")]
    [StringLength(3)]
    public string Erscountry { get; set; }

    [StringLength(100)]
    public string FilerEmail { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string FilerPhone { get; set; }

    [Column("LLLP")]
    public bool? Lllp { get; set; }

    [Column("PLLC")]
    public bool? Pllc { get; set; }

    public bool? SeriesTrust { get; set; }

    [Column("NCR")]
    [StringLength(255)]
    public string Ncr { get; set; }

    [Column("POCountry")]
    [StringLength(3)]
    public string Pocountry { get; set; }

    [Column("ranameremoved")]
    public bool? Ranameremoved { get; set; }

    [Column("raaddrremoved")]
    public bool? Raaddrremoved { get; set; }

    [Column("CBILetterSent", TypeName = "datetime")]
    public DateTime? CbiletterSent { get; set; }

    [Column("benefit")]
    public bool? Benefit { get; set; }

    [Column("veteranowned")]
    public bool? Veteranowned { get; set; }

    [Column("cantupdateonline")]
    public bool? Cantupdateonline { get; set; }

    [Column("interrogatory")]
    public bool? Interrogatory { get; set; }

    /// <summary>
    /// Signature of representative of entity registered agent                                  
    /// </summary>
    [Column("RAEntitysig")]
    [StringLength(255)]
    public string Raentitysig { get; set; }
}