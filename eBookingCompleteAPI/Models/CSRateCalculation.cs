﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eBookingCompleteAPI.Models
{
    public class CSRateCalculation
    {
        public string StartCol { get; set; }
        public string Yposition { get; set; }
        public string BoxNumber { get; set; }
        public int RecID { get; set; }
        public double BaseRate { get; set; }
        public double CardRate { get; set; }
        public double CardAmount { get; set; }
        public double AgreedRate { get; set; }
        public double AgreedAmount { get; set; }
        public double AgreedDiscPer { get; set; }
        public double AgreedDiscAmount { get; set; }
        public int RateCardID { get; set; }
        public int AdRateID { get; set; }
        public double RateDiff { get; set; }
        public double BillableArea { get; set; }
        public int SizeID { get; set; }
        public double AdSizeWidth { get; set; }
        public double AdSizeHeight { get; set; }
        public double AdSizeArea { get; set; }
        public double ColWidth { get; set; }
        public double ColumnSize { get; set; }
        public double Gutter { get; set; }
        public double AgencyCommissionPer { get; set; }
        public double AgencyCommissionAmount { get; set; }
        public double PreVATAmount { get; set; }
        public double Receivable { get; set; }
        public double NetReceivable { get; set; }
        public double ColorRate { get; set; }
        public double PremiaRate { get; set; }
        public double VATPer { get; set; }
        public double VATAmount { get; set; }
        public double WtPer { get; set; }
        public double WTAmount { get; set; }
        public double ExtraDiscPer { get; set; }
        public double ExtraDiscAmount { get; set; }
        public double ExtraChargesPer { get; set; }
        public double ExtraChargesAmount { get; set; }
        public double ExtraBoxChargesPer { get; set; }
        public double ExtraBoxChargesAmount { get; set; }
        public string ScheduledDate { get; set; }
        public int InsNum { get; set; }
        public int PackageID { get; set; }
        public int PackageIDSent { get; set; }
        public int PublicationID { get; set; }
        public int PEID { get; set; }
        public int PremiaID { get; set; }
        public int ColorID { get; set; }
        public int SchemeID { get; set; }
        public int SchemeDetailID { get; set; }
        public double SchemeAmount { get; set; }
        public string SchemeName { get; set; }
        public string SchemeDays { get; set; }
        public int AdTypeID { get; set; }
        public int StyleSheetID { get; set; }
        public string StyleSheetName { get; set; }
        public double MinAmount { get; set; }
        public double MinArea { get; set; }
        public int UOM { get; set; }
        public int Status { get; set; }
        public int AuditStatus { get; set; }
        public int MaterialType { get; set; }
        public int MaterialSource { get; set; }
        public int IsValid { get; set; }
        public string ErrorMessage { get; set; }
        public int ReceiptPayTypeID { get; set; }
        public string MBodyCount { get; set; }
        public int RateFieldChanged { get; set; }
        public int ItemRateFieldChanged { get; set; }
        public string PECode { get; set; }
        public string AdStatus { get; set; }
        public string AdClassification { get; set; }
        public int AdtypeID1 { get; set; }
        public int AdtypeID2 { get; set; }
        public int AdtypeID3 { get; set; }
        public int AdtypeID4 { get; set; }
        public string MaterialID { get; set; }
        public string ReadOnlyFlag { get; set; }
        public string AdColumns { get; set; }
    }
}