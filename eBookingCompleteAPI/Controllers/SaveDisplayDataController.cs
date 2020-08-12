﻿using EbookingComplete_DAL;
using eBookingCompleteAPI.Models;
using System;
using System.Data;
using System.Web.Http;

namespace eBookingCompleteAPI.Controllers
{
    public class SaveDisplayDataController : ApiController
    {
        [HttpPost]
        public BookingDetail Post(BookingDetail objbookingDetail)
        {
            string strXml = string.Empty;
            try
            {
                HomeDAL objHomeDAL = new HomeDAL();
                string dates = objbookingDetail.DateSelected;
                string[] selecteddate = dates.Split(',');
                string packages = objbookingDetail.PackageID;
                string[] selectedpackages = packages.Split(',');
                string peids = objbookingDetail.PEID;
                string[] selectedpeids = peids.Split(',');
                string adtypeids = objbookingDetail.AdtypeId;
                string[] selectedadtypeids = adtypeids.Split(',');
                string adsizeids = objbookingDetail.Adsizeid;
                string[] selectedadsizeids = adsizeids.Split(',');
                string adheights = objbookingDetail.AdsizeHeight;
                string[] selectedadheights = adheights.Split(',');
                string adwidths = objbookingDetail.AdsizeWidth;
                string[] selectedadwidths = adwidths.Split(',');
                string premiaids = objbookingDetail.Premiaid;
                string[] selectedpremiaids = premiaids.Split(',');
                string colorids = objbookingDetail.Colorid;
                string[] selectedcolorids = colorids.Split(',');
                string mattypeids = objbookingDetail.MaterialType;
                string[] selectedmattypeids = mattypeids.Split(',');
                string matsourceids = objbookingDetail.MaterialSource;
                string[] selectedmatsourceids = matsourceids.Split(',');
                string boxtypeids = objbookingDetail.BoxTypeID;
                string[] selectedboxtypeids = boxtypeids.Split(',');
                string uomids = objbookingDetail.UOMID;
                string[] selecteduomids = uomids.Split(',');
                string statusids = objbookingDetail.Status;
                string[] selectedstatusids = statusids.Split(',');
                string cauditstatusids = objbookingDetail.AuditStatus;
                string[] selectedcauditstatusids = cauditstatusids.Split(',');
                string cardrates = objbookingDetail.CardRate;
                string[] selectedcardrates = cardrates.Split(',');
                string cardamounts = objbookingDetail.CardAmount;
                string[] selectedcardamounts = cardamounts.Split(',');
                string ratecardids = objbookingDetail.RateCardID;
                string[] selectedratecardids = ratecardids.Split(',');
                string adrateids = objbookingDetail.AdRateID;
                string[] selectedadrateids = adrateids.Split(',');
                string agreedrates = objbookingDetail.AgreedRate;
                string[] selectedagreedrates = agreedrates.Split(',');
                string agreedamounts = objbookingDetail.AgreedAmount;
                string[] selectedagreedamounts = agreedamounts.Split(',');
                string agreeddispers = objbookingDetail.AgreedDiscPer;
                string[] selectedagreeddispers = agreeddispers.Split(',');
                string agreeddisamounts = objbookingDetail.AgreedDiscAmount;
                string[] selectedagreeddisamounts = agreeddisamounts.Split(',');
                string prevatamounts = objbookingDetail.PreVATAmount;
                string[] selectedprevatamounts = prevatamounts.Split(',');
                string vatapers = objbookingDetail.VATPer;
                string[] selectedvatapers = vatapers.Split(',');
                string vatamounts = objbookingDetail.VATAmount;
                string[] selectedvatamounts = vatamounts.Split(',');
                string agencycommissionpers = objbookingDetail.AgencyCommissionPer;
                string[] selectedagencycommissionpers = agencycommissionpers.Split(',');
                string agencycommissionamounts = objbookingDetail.AgencyCommissionAmount;
                string[] selectedagencycommissionamounts = agencycommissionamounts.Split(',');
                string schemeids = objbookingDetail.SchemeID;
                string[] selecteschemeids = schemeids.Split(',');
                string schemedetailids = objbookingDetail.SchemeDetailID;
                string[] selectedschemedetailids = schemedetailids.Split(',');
                string extrachargespers = objbookingDetail.ExtraChargesPer;
                string[] selectedextrachargespers = extrachargespers.Split(',');
                string extrachargesamounts = objbookingDetail.ExtraChargesAmount;
                string[] selectedextrachargesamounts = extrachargesamounts.Split(',');
                string extradiscpers = objbookingDetail.ExtraDiscPer;
                string[] selectedextradiscpers = extradiscpers.Split(',');
                string extradiscamount = objbookingDetail.ExtraDiscAmount;
                string[] selectedextradiscamount = extradiscamount.Split(',');
                string extraboxchargespers = objbookingDetail.ExtraBoxChargesPer;
                string[] selectedextraboxchargespers = extraboxchargespers.Split(',');
                string extraboxchargesamounts = objbookingDetail.ExtraBoxChargesAmount;
                string[] selectedextraboxchargesamounts = extraboxchargesamounts.Split(',');
                string receivableamounts = objbookingDetail.Receivable;
                string[] selectedreceivableamounts = receivableamounts.Split(',');
                string adcolumnsize = objbookingDetail.AdColumnSize;
                string[] selectedadcolumnsize = adcolumnsize.Split(',');
                string gutter = objbookingDetail.Gutter;
                string[] selectedgutter = gutter.Split(',');

                int FileLength = Convert.ToInt16(objbookingDetail.FileLength);
                string[] rofilename = { };
                string[] rofiletype = { };
                string[] rofiletitle = { };
                if (FileLength != 0)
                {
                    string filename = objbookingDetail.RoFileName;
                    rofilename = filename.Split(',');
                    string filetype = objbookingDetail.RoFileType;
                    rofiletype = filetype.Split(',');
                    string filetitle = objbookingDetail.RoFileTitle;
                    rofiletitle = filetitle.Split(',');

                }

                string packageids = string.Empty;
                if (selectedpackages.Length == 1)
                {
                    packageids = objbookingDetail.PackageID;
                }
                else
                {
                    packageids = "0";
                }

                if (selecteddate.Length > 0)
                {
                    strXml += "<ebooking>"
                       + "<orderlevel>"
                               + "<roid>" + objbookingDetail.ROID + "</roid>"
                               + "<bookingdate>" + objbookingDetail.BookingDate + "</bookingdate>"
                               + "<revenuecentreid>" + objbookingDetail.RevenueCentreID + "</revenuecentreid>"
                               + "<bookingcentreid>" + objbookingDetail.BookingCentreID + "</bookingcentreid>"
                               + "<bookingexecid>" + objbookingDetail.UserId + "</bookingexecid>"
                               + "<ronumber>" + objbookingDetail.RONumber + "</ronumber>"
                               + "<agencyid>" + objbookingDetail.AgencyID + "</agencyid>"
                               + "<clientid>" + objbookingDetail.ClientID + "</clientid>"
                               + "<canvassorid>" + objbookingDetail.CanvassorID + "</canvassorid>"
                               + "<loguserid>" + objbookingDetail.UserId + "</loguserid>"
                               + "<isclassified>" + objbookingDetail.IsClassified + "</isclassified>"
                               + "<sourceroid>" + objbookingDetail.SourceROID + "</sourceroid>"
                               + "<ratefieldchanged>" + objbookingDetail.RateFieldChanged + "</ratefieldchanged>"

                               + "<casualclientname>" + objbookingDetail.CasualClientName + "</casualclientname>"
                               + "<casualclientaddress>" + objbookingDetail.CasualClientAddress + "</casualclientaddress>"
                               + "<contactperson>" + objbookingDetail.ContactPerson + "</contactperson>"
                               + "<casualclientcity>" + objbookingDetail.CasualClientCity + "</casualclientcity>"
                               + "<casualclientzipcode>" + objbookingDetail.CasualClientZipCode + "</casualclientzipcode>"
                               + "<casualclientphoneno>" + objbookingDetail.CasualClientPhoneNo + "</casualclientphoneno>"
                               + "<casualcontactperson>" + objbookingDetail.CasualContactPerson + "</casualcontactperson>"
                               + "<casualclientnicnumber>" + objbookingDetail.CasualClientNicNumber + "</casualclientnicnumber>"
                               + "<casualclientvatnumber>" + objbookingDetail.CasualClientVatNumber + "</casualclientvatnumber>"
                               + "<casualclientemailid>" + objbookingDetail.CasualClientEmailID + "</casualclientemailid>"
                               + "<casualclientpassword>" + objbookingDetail.CasualClientPassword + "</casualclientpassword>"

                               + "<totalorders>" + objbookingDetail.TotalOrders + "</totalorders>"
                               + "<smeid>" + objbookingDetail.SMEID + "</smeid>"
                               + "<productid>" + objbookingDetail.ProductID + "</productid>"
                               + "<brandid>" + objbookingDetail.BrandID + "</brandid>"
                               + "<rotype>" + objbookingDetail.ROType + "</rotype>"
                               + "<reasonforunconfirmationid>" + objbookingDetail.UnConfirmReason + "</reasonforunconfirmationid>"
                               + "<billtype>" + objbookingDetail.BillType + "</billtype>"
                               + "<ordernumber>" + objbookingDetail.OrderNumber + "</ordernumber>"
                               + "<uniquenumber>" + objbookingDetail.UniqueCode + "</uniquenumber>"
                               + "<customertype>" + objbookingDetail.CustomerTypeID + "</customertype>"
                               + "<paymentmode>" + objbookingDetail.PaymentTypeID + "</paymentmode>"
                               + "<ismanualbilling>" + objbookingDetail.IsManualBilling + "</ismanualbilling>"
                               + "<rostatus>" + objbookingDetail.ROStatus + "</rostatus>"
                               + "<packagelist>" + objbookingDetail.PackageID + "</packagelist>"
                               + "<billinginstruction>" + objbookingDetail.BillingIns + "</billinginstruction>"
                               + "<receivableamount>" + objbookingDetail.ReceivableAmount + "</receivableamount>"
                               + "<saveflag>" + objbookingDetail.SaveFlag + "</saveflag>"
                               + "<machineid>" + objbookingDetail.MachineID + "</machineid>"
                               + "<machinename>" + objbookingDetail.MachineName + "</machinename>"
                               + "<deferredpayment>" + objbookingDetail.CheckDifferValue + "</deferredpayment>";



                    for (var i = 0; i < objbookingDetail.list.Count; i++)
                    {
                       // var date = selecteddate[i];
                        var date = objbookingDetail.list[i].ScheduledDate.Substring(0, 10);
                        strXml += "<insertlevel>"
                                 + "<insnum>" + objbookingDetail.list[i].InsNum + "</insnum>" //+ "<insnum>" + (i + 1) + "</insnum>"
                                 + "<packageid>" + packageids + "</packageid>"
                                 + "<no_of_insertions>" + selecteddate.Length + "</no_of_insertions>"
                                 + "<invoicenum>0</invoicenum>";
                        //for (var j = 0; j < selectedpeids.Length; j++)
                        //{
                            var peid = objbookingDetail.list[i].PEID; //selectedpeids[j];
                            strXml += "<itemlevel>"
                                 + "<peid>" + peid + "</peid>"
                                 + "<caption>" + objbookingDetail.Caption + "</caption>"
                                 + "<schedulinginstructions>" + objbookingDetail.SchedulingIns + "</schedulinginstructions>"
                                 + "<prodinstructions>" + objbookingDetail.ProdInstructions + "</prodinstructions>"
                                 + "<materialtype>" + objbookingDetail.list[i].MaterialType + "</materialtype>"
                                 + "<materialid>" + objbookingDetail.list[i].MaterialID + "</materialid>"
                                 + "<materialsource>" + objbookingDetail.MaterialSource + "</materialsource>"
                                 + "<boxtypeid>" + objbookingDetail.BoxTypeID + "</boxtypeid>"
                                 + "<boxaddress>" + objbookingDetail.BoxAddress + "</boxaddress>"
                                 + "<releaseid>0</releaseid>"
                                 + "<scheduleddate>" + date + "</scheduleddate>"
                                 + "<free_or_paid>1</free_or_paid>"
                                 + "<uom>" + objbookingDetail.list[i].UOM + "</uom>"
                                 + "<adtypeid>" + objbookingDetail.list[i].AdTypeID + "</adtypeid>"
                                 + "<ratecardid>" + objbookingDetail.list[i].RateCardID + "</ratecardid>"
                                 + "<adrateid>" + objbookingDetail.list[i].AdRateID + "</adrateid>"
                                 + "<premiaid>" + objbookingDetail.list[i].PremiaID + "</premiaid>"
                                 + "<color>" + objbookingDetail.list[i].ColorID + "</color>"
                                 + "<premiarate>" + objbookingDetail.list[i].PremiaRate + "</premiarate>"
                                 + "<colorrate>" + objbookingDetail.list[i].ColorRate + "</colorrate>"
                                 + "<status>" + objbookingDetail.list[i].Status + "</status>"
                                 + "<auditstatus>" + objbookingDetail.list[i].AuditStatus + "</auditstatus>"
                                 + "<paymentstatus>0</paymentstatus>"
                                 + "<materialstatus>0</materialstatus>"
                                 + "<cardrate>" + objbookingDetail.list[i].CardRate + "</cardrate>"
                                 + "<cardamount>" + objbookingDetail.list[i].CardAmount + "</cardamount>"
                                 + "<itemratefieldchanged>" + objbookingDetail.list[i].ItemRateFieldChanged + "</itemratefieldchanged>"
                                 + "<agreedrate>" + objbookingDetail.list[i].AgreedRate + "</agreedrate>"
                                 + "<agreedamount>" + objbookingDetail.list[i].AgreedAmount + "</agreedamount>"
                                 + "<agreeddiscount>" + objbookingDetail.list[i].AgreedDiscAmount + "</agreeddiscount>"
                                 + "<agreeddisper>" + objbookingDetail.list[i].AgreedDiscPer + "</agreeddisper>"
                                 + "<prevatamountforpe>" + objbookingDetail.list[i].PreVATAmount + "</prevatamountforpe>"
                                 + "<netamountforpe>" + objbookingDetail.list[i].Receivable + "</netamountforpe>"
                                 + "<pevatper>" + objbookingDetail.list[i].VATPer + "</pevatper>"
                                 + "<pevatamount>" + objbookingDetail.list[i].VATAmount + "</pevatamount>"
                                 + "<extrachargesper>" + objbookingDetail.list[i].ExtraChargesPer + "</extrachargesper>"
                                 + "<extrachargesforpe>" + objbookingDetail.list[i].ExtraChargesAmount + "</extrachargesforpe>"
                                 + "<extradiscper>" + objbookingDetail.list[i].ExtraDiscPer + "</extradiscper>"
                                 + "<extradiscountforpe>" + objbookingDetail.list[i].ExtraDiscAmount + "</extradiscountforpe>"
                                 + "<extraboxchargesper>" + selectedextraboxchargespers[i] + "</extraboxchargesper>"
                                 + "<extraboxchargesamount>" + objbookingDetail.list[i].ExtraBoxChargesAmount + "</extraboxchargesamount>"
                                 + "<commissionper>" + objbookingDetail.list[i].AgencyCommissionPer + "</commissionper>"
                                 + "<commissionamount>" + objbookingDetail.list[i].AgencyCommissionAmount + "</commissionamount>"
                                 + "<schemeid>" + objbookingDetail.list[i].SchemeID + "</schemeid>"
                                 + "<schemedetailid>" + objbookingDetail.list[i].SchemeDetailID + "</schemedetailid>"
                                 //+ "<adsize>" + selectedadheights[j] + "*" + selectedadwidths[j] + "</adsize>"
                                 + "<adcolumns>" + selectedadcolumnsize[i] + "</adcolumns>"
                                 + "<adgutter>" + selectedgutter[i] + "</adgutter>"
                                 + "<adsize>" + objbookingDetail.list[i].AdSizeHeight + '*' + objbookingDetail.list[i].AdSizeWidth + "</adsize>"
                                 + "<adsizeid>" + objbookingDetail.list[i].AdsizeID + "</adsizeid>"
                                 + "<adheight>" + objbookingDetail.list[i].AdSizeHeight + "</adheight>"
                                 + "<adwidth>" + objbookingDetail.list[i].AdSizeWidth + "</adwidth>"
                                 + "<adarea>" + Convert.ToDouble(objbookingDetail.list[i].AdSizeHeight) * Convert.ToDouble(objbookingDetail.list[i].AdSizeWidth) + "</adarea>"
                                 + "<billablesize>" + objbookingDetail.list[i].BillableSize + "</billablesize>"
                                 + "<billableheight>" + objbookingDetail.list[i].BillableSize.Split('*')[0] + "</billableheight>"
                                 + "<billablewidth>" + objbookingDetail.list[i].BillableSize.Split('*')[1] + "</billablewidth>"
                                 + "<billablearea>" + Convert.ToDouble(objbookingDetail.list[i].BillableSize.Split('*')[0]) * Convert.ToDouble(objbookingDetail.list[i].BillableSize.Split('*')[1]) + "</billablearea>"
                                 + "<boxnumber>" + objbookingDetail.list[i].BoxNumber + "</boxnumber>"
                                 + "<startcol>" + objbookingDetail.list[i].StartCol + "</startcol>"
                                 + "<yposition>" + objbookingDetail.list[i].Yposition + "</yposition>"
                          + "</itemlevel>";
                       // }
                        strXml += "</insertlevel>";
                    }
                    if (objbookingDetail.PaymentTypeID == 1 && objbookingDetail.CheckDifferValue == 0)
                    {
                        strXml += "<receiptetail>"
                             + "<receiptamount>" + objbookingDetail.TotalReceivable + "</receiptamount>"
                             + "<totalamountpaid>" + objbookingDetail.ReceiptAmount + "</totalamountpaid>"
                             + "<writeoffamount>" + objbookingDetail.WriteoffAmount + "</writeoffamount>"
                             + "<receiptdate>" + DateTime.Now.ToString("dd/MM/yyyy") + "</receiptdate>";
                        if (objbookingDetail.Amount != 0)
                        {
                            strXml += "<paymentdetail>"
                                + "<paymentmodeid>" + objbookingDetail.PaymentModeID + "</paymentmodeid>"
                                + "<chequenumber>" + objbookingDetail.ChequeNumber + "</chequenumber>"
                                + "<chequedate></chequedate>"
                                + "<amount>" + objbookingDetail.Amount + "</amount>"
                                + "<bankid>" + objbookingDetail.BankID + "</bankid>"
                                + "<bankname>" + objbookingDetail.BranchBankName + "</bankname>"
                                + "<branchid>" + objbookingDetail.BankNameID + "</branchid>"
                                + "<branchname>" + objbookingDetail.BranchName + "</branchname>"
                                + "<bankbranchcode>" + objbookingDetail.BankName + "</bankbranchcode>"
                           + "</paymentdetail>";
                        }
                        if (objbookingDetail.Amount1 != 0)
                        {
                            strXml += "<paymentdetail>"
                             + "<paymentmodeid>" + objbookingDetail.PaymentModeID1 + "</paymentmodeid>"
                             + "<chequenumber>" + objbookingDetail.ChequeNumber1 + "</chequenumber>"
                             + "<chequedate></chequedate>"
                             + "<amount>" + objbookingDetail.Amount1 + "</amount>"
                             + "<bankid>" + objbookingDetail.BankID1 + "</bankid>"
                             + "<bankname>" + objbookingDetail.BranchBankName1 + "</bankname>"
                             + "<branchid>" + objbookingDetail.BankNameID1 + "</branchid>"
                             + "<branchname>" + objbookingDetail.BranchName1 + "</branchname>"
                             + "<bankbranchcode>" + objbookingDetail.BankName1 + "</bankbranchcode>"
                        + "</paymentdetail>";
                        }
                        if (objbookingDetail.Amount2 != 0)
                        {
                            strXml += "<paymentdetail>"
                             + "<paymentmodeid>" + objbookingDetail.PaymentModeID2 + "</paymentmodeid>"
                             + "<chequenumber>" + objbookingDetail.ChequeNumber2 + "</chequenumber>"
                             + "<chequedate></chequedate>"
                             + "<amount>" + objbookingDetail.Amount2 + "</amount>"
                             + "<bankid>" + objbookingDetail.BankID2 + "</bankid>"
                             + "<bankname>" + objbookingDetail.BranchBankName2 + "</bankname>"
                             + "<branchid>" + objbookingDetail.BankNameID2 + "</branchid>"
                             + "<branchname>" + objbookingDetail.BranchName2 + "</branchname>"
                             + "<bankbranchcode>" + objbookingDetail.BankName2 + "</bankbranchcode>"
                         + "</paymentdetail>";
                        }
                        strXml += "</receiptetail>";
                    }
                    strXml += "<rofiles>"
                                    + "<roid>" + objbookingDetail.ROID + "</roid>"
                                    + "<loguserid>" + objbookingDetail.UserId + "</loguserid>";
                    if (FileLength == 0)
                    {
                        strXml += "<rofiledetail>"
                                     + "<rofilename></rofilename>"
                                     + "<rofiletype></rofiletype>"
                                     + "<rofiletitle></rofiletitle>"
                                     + "<isprinted>0</isprinted>"
                                     + "<portedflag>0</portedflag>"
                                + "</rofiledetail>";
                    }
                    else
                    {
                        for (var k = 0; k < FileLength; k++)
                        {
                            strXml += "<rofiledetail>"
                                         + "<rofilename>" + rofilename[k] + "</rofilename>"
                                         + "<rofiletype>" + rofiletype[k] + "</rofiletype>"
                                         + "<rofiletitle>" + rofiletitle[k] + "</rofiletitle>"
                                         + "<isprinted>0</isprinted>"
                                         + "<portedflag>0</portedflag>"
                                    + "</rofiledetail>";
                        }
                    }
                    strXml += "</rofiles>";
                    strXml += "</orderlevel></ebooking>";
                }

                DataTable objdt = objHomeDAL.BookOrdersXML(strXml).Tables[0];
                if (objdt.Rows.Count > 0)
                {
                    objbookingDetail.IsValid = Convert.ToInt16(objdt.Rows[0]["ErrorFlag"]);
                    //if (objbookingDetail.IsValid == 1 || objbookingDetail.IsValid == 2 || objbookingDetail.IsValid == 3 || objbookingDetail.IsValid == -2)
                    if (objbookingDetail.IsValid > 0)
                    {
                        objbookingDetail.ErrorMessage = Convert.ToString(objdt.Rows[0]["ErrorMessage"]);
                        objbookingDetail.IsValid = Convert.ToInt16(objdt.Rows[0]["ErrorFlag"]);
                    }
                    else
                    {
                        objbookingDetail.ROID = Convert.ToInt64(objdt.Rows[0]["ROID"]);
                        objbookingDetail.ReceiptID = Convert.ToInt64(objdt.Rows[0]["ReceiptID"]);
                        objbookingDetail.JobSequence = Convert.ToString(objdt.Rows[0]["JobSequence"]);
                        objbookingDetail.IsValid = Convert.ToInt16(objdt.Rows[0]["ErrorFlag"]);
                        objbookingDetail.ErrorMessage = Convert.ToString(objdt.Rows[0]["ErrorMessage"]);
                    }
                }
            }
            catch (Exception ex)
            {
                Utility.ReportLogError("SP_Name::EBK_SP_BookOrdersXML:", ex, strXml);
            }
            return objbookingDetail;

        }
    }
}
