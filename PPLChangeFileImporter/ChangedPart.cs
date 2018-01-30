using System;
using System.Collections.Generic;

namespace PPLChangeFileImporter
{
    class ChangedPart
    {
        #region Member variable definitions
        public string OriginalPN = "";
        public string PCCN = "";
        public string PLISN = "";
        public string INDC = "";
        public string CAGE = "";
        public string PN = "";
        public string RNCC = "";
        public string RNVC = "";
        public string DAC = "";
        public string PPSL = "";
        public string EC = "";
        public string NAME = "";
        public string SL = "";
        public string SLAC = "";
        public string COG = "";
        public string MCC = "";
        public string FSC = "";
        public string NIIN = "";
        public string NSNSUFF = "";
        public string UM = "";
        public string UMPRICE = "";
        public string UI = "";
        public string UIPRICE = "";
        public string CONV = "";
        public string QUP = "";
        public string SMR = "";
        public string DMIL = "";
        public string PLT = "";
        public string HCI = "";
        public string PSPC = "";
        public string PMIC = "";
        public string ADPEC = "";
        public string NHA = "";
        public string ORR = "";
        public string QPA = "";
        public string QPE = "";
        public string MRRI = "";
        public string MRRII = "";
        public string MRRMOD = "";
        public string TQR = "";
        public string SAPLISN = "";
        public string PRPLISN = "";
        public string MAOT = "";
        public string MAC = "";
        public string NRTS = "";
        public string UOC = "";
        public string REFDES = "";
        public string RDOC = "";
        public string RDC = "";
        public string SMCC = "";
        public string PLCC = "";
        public string SMIC = "";
        public string AIC = "";
        public string AICQTY = "";
        public string MRU = "";
        public string RMSS = "";
        public string RISS = "";
        public string RTLLQTY = "";
        public string RSR = "";
        public string OMTD = "";
        public string FMTD = "";
        public string HMTD = "";
        public string SRAMTD = "";
        public string DMTD = "";
        public string CEDMTD = "";
        public string CADMTD = "";
        public string ORCT = "";
        public string FRCT = "";
        public string HRCT = "";
        public string SRARCT = "";
        public string DRCT = "";
        public string CONRCT = "";
        public string ORTD = "";
        public string FRTD = "";
        public string HRTD = "";
        public string SRARTD = "";
        public string DRTD = "";
        public string DOP1 = "";
        public string DOP2 = "";
        public string CTIC = "";
        public string AMC = "";
        public string AMSC = "";
        public string IMC = "";
        public string RIP = "";
        public string CHANGEAUTHORITY1 = "";
        public string IC = "";
        public string SNFROM = "";
        public string SNTO = "";
        public string TIC = "";
        public string RSPLISN = "";
        public string QTYSHIPPED = "";
        public string QTYPROCURED = "";
        public string DCNUOC = "";
        public string PRORATEDELIN = "";
        public string PRORATEDQTY = "";
        public string LCN = "";
        public string ALTLCN = "";
        public string REMARKS = "";
        public string TMCODE = "";
        public string FIGNUM = "";
        public string ITEMNUM = "";
        public string TMCHG = "";
        public string TMIND = "";
        public string QTYFIG = "";
        public string WUCTMFGC = "";
        public string BASISOFISSUE1 = "";
        public string BASISOFISSUE2 = "";
        public string CC = "";
        public string INC = "";
        public string LRU = "";
        public string PROVNOM = "";
        public string ALTCAGE1 = "";
        public string ALTPN1 = "";
        public string ALTRNCC1 = "";
        public string ALTRNVC1 = "";
        public string ALTDAC1 = "";
        public string ALTPPSL1 = "";
        public string ALTCAGE2 = "";
        public string ALTPN2 = "";
        public string ALTRNCC2 = "";
        public string ALTRNVC2 = "";
        public string ALTDAC2 = "";
        public string ALTPPSL2 = "";
        public string ALTCAGE3 = "";
        public string ALTPN3 = "";
        public string ALTRNCC3 = "";
        public string ALTRNVC3 = "";
        public string ALTDAC3 = "";
        public string ALTPPSL3 = "";
        public string ALTCAGE4 = "";
        public string ALTPN4 = "";
        public string ALTRNCC4 = "";
        public string ALTRNVC4 = "";
        public string ALTDAC4 = "";
        public string ALTPPSL4 = "";
        public string ALTCAGE5 = "";
        public string ALTPN5 = "";
        public string ALTRNCC5 = "";
        public string ALTRNVC5 = "";
        public string ALTDAC5 = "";
        public string ALTPPSL5 = "";
        public string ALTCAGE6 = "";
        public string ALTPN6 = "";
        public string ALTRNCC6 = "";
        public string ALTRNVC6 = "";
        public string ALTDAC6 = "";
        public string ALTPPSL6 = "";
        public string MATERIAL1 = "";
        public string MATERIAL2 = "";
        public string MATERIAL3 = "";
        public string MATERIAL4 = "";
        public string RBD = "";
        public string SUPPNOMEN1 = "";
        public string AELA = "";
        public string AELB = "";
        public string AELC = "";
        public string AELD = "";
        public string AELE = "";
        public string AELF = "";
        public string AELG = "";
        public string AELH = "";
        public string SUPPNOMEN2 = "";
        public string AFC2 = "";
        public string AFCQTY2 = "";
        public string ANC2 = "";
        public string AOC2 = "";
        public string AOCQTY2 = "";
        public string LLTIL1 = "";
        public string PPL1 = "";
        public string SFPPL1 = "";
        public string CBIL1 = "";
        public string RIL1 = "";
        public string ISIL1 = "";
        public string PCL1 = "";
        public string TTEL1 = "";
        public string SCPL1 = "";
        public string DCN1 = "";
        public string ARF = "";
        public string LLTIL2 = "";
        public string PPL2 = "";
        public string SFPPL2 = "";
        public string CBIL2 = "";
        public string RIL2 = "";
        public string ISIL2 = "";
        public string PCL2 = "";
        public string TTEL2 = "";
        public string SCPL2 = "";
        public string DCN2 = "";
        public string ACCCODE = "";
        public string ALTNIINREL = "";
        public string ALTNIIN = "";
        public string ALTNIINREL2 = "";
        public string ALTNIIN2 = "";
        public string REFDES2 = "";
        public string RDOC2 = "";
        public string CHANGEAUTHORITY2 = "";
        public string IC2 = "";
        public string SNFROM2 = "";
        public string SNTO2 = "";
        public string TIC2 = "";
        public string RSPLISN2 = "";
        public string QTYSHIPPED2 = "";
        public string QTYPROCURED2 = "";
        public string DCNUOC2 = "";
        public string PRORATEDELIN2 = "";
        public string PRORATEDQTY2 = "";
        public string LCN2 = "";
        public string ALTLCN2 = "";
        public string LENGTH = "";
        public string WIDTH = "";
        public string HEIGHT = "";
        public string WEIGHT = "";
        public string TEMP1 = "";

        //public string PCCN = "";
        //public string PLISN = "";
        //public string INDC = "";
        //public string CAGE = "";
        //public string PN = "";                  // get data for this
        //public string RNCC = "";             // get data for this
        //public string RNVC = "";             // get data for this
        //public string DAC = "";               // get data for this
        //public string PPSL = "";
        //public string EC = "";
        //public string FRR = "";
        //public string WR = "";
        //public string SW = "";
        //public string AVERAGEPRICEOFPARTS = "";
        //public string MTTR = "";
        //public string MTBF = "";
        //public string DT = "";
        //public string TPSDEV = "";
        //public string TPSMAIN = "";
        //public string PAGESOFDOCUMENTATION = "";
        //public string LRUASSOC = "";
        //public string HASDOWNPARTS = "";
        //public string NAME = "";             // get data for this
        //public string SL = "";                   // get data for this
        //public string SLAC = "";
        //public string COG = "";
        //public string MCC = "";
        //public string FSC = "";     // get data for this
        //public string NIIN = "";     // get data for this
        //public string NSNSUFF = "";
        //public string UM = "";
        //public string UMPRICE = "";
        //public string UI = "";     // get data for this
        //public string UIPRICE = "";  // get data for this
        //public string CONV = "";
        //public string QUP = "";         // get data for this
        //public string SMR = "";
        //public string DMIL = "";        // get data for this
        //public string PLT = "";
        //public string HCI = "";
        //public string PSPC = "";
        //public string PMIC = "";        // get data for this
        //public string ADPEC = "";
        //public string NHA = "";
        //public string ORR = "";
        //public string QPA = "";
        //public string QPE = "";
        //public string MRRI = "";
        //public string MRRII = "";
        //public string MRRMOD = "";
        //public string TQR = "";
        //public string SAPLISN = "";
        //public string PRPLISN = "";
        //public string MAOT = "";
        //public string MAC = "";
        //public string NRTS = "";
        //public string UOC = "";
        //public string REFDES = "";
        //public string RDOC = "";
        //public string RDC = "";
        //public string SMCC = "";
        //public string PLCC = "";
        //public string SMIC = "";
        //public string AIC = "";
        //public string AICQTY = "";
        //public string MRU = "";
        //public string RMSS = "";
        //public string RISS = "";
        //public string RTLLQTY = "";
        //public string RSR = "";
        //public string OMTD = "";
        //public string FMTD = "";
        //public string HMTD = "";
        //public string SRAMTD = "";
        //public string DMTD = "";
        //public string CEDMTD = "";
        //public string CADMTD = "";
        //public string ORCT = "";
        //public string FRCT = "";
        //public string HRCT = "";
        //public string SRARCT = "";
        //public string DRCT = "";
        //public string CONRCT = "";
        //public string ORTD = "";
        //public string FRTD = "";
        //public string HRTD = "";
        //public string SRARTD = "";
        //public string DRTD = "";
        //public string DOP1 = "";
        //public string DOP2 = "";
        //public string CTIC = "";
        //public string AMC = "";
        //public string AMSC = "";
        //public string IMC = "";
        //public string RIP = "";
        //public string CHANGEAUTHORITY1 = "";
        //public string IC = "";
        //public string SNFROM = "";
        //public string SNTO = "";
        //public string TIC = "";
        //public string RSPLISN = "";
        //public string QTYSHIPPED = "";
        //public string QTYPROCURED = "";
        //public string DCNUOC = "";
        //public string PRORATEDELIN = "";
        //public string PRORATEDQTY = "";
        //public string LCN = "";
        //public string ALTLCN = "";
        //public string REMARKS = "";
        //public string TMCODE = "";
        //public string FIGNUM = "";
        //public string ITEMNUM = "";
        //public string TMCHG = "";
        //public string TMIND = "";
        //public string QTYFIG = "";
        //public string WUCTMFGC = "";
        //public string BASISOFISSUE1 = "";
        //public string BASISOFISSUE2 = "";
        //public string CC = "";
        //public string INC = "";     // get data for this
        //public string LRU = "";
        //public string PROVNOM = "";
        //public string ALTCAGE1 = "";     // get data for this
        //public string ALTPN1 = "";     // get data for this
        //public string ALTRNCC1 = "";     // get data for this
        //public string ALTRNVC1 = "";     // get data for this
        //public string ALTDAC1 = "";     // get data for this
        //public string ALTPPSL1 = "";
        //public string ALTCAGE2 = "";
        //public string ALTPN2 = "";
        //public string ALTRNCC2 = "";
        //public string ALTRNVC2 = "";
        //public string ALTDAC2 = "";
        //public string ALTPPSL2 = "";
        //public string ALTCAGE3 = "";
        //public string ALTPN3 = "";
        //public string ALTRNCC3 = "";
        //public string ALTRNVC3 = "";
        //public string ALTDAC3 = "";
        //public string ALTPPSL3 = "";
        //public string ALTCAGE4 = "";
        //public string ALTPN4 = "";
        //public string ALTRNCC4 = "";
        //public string ALTRNVC4 = "";
        //public string ALTDAC4 = "";
        //public string ALTPPSL4 = "";
        //public string ALTCAGE5 = "";
        //public string ALTPN5 = "";
        //public string ALTRNCC5 = "";
        //public string ALTRNVC5 = "";
        //public string ALTDAC5 = "";
        //public string ALTPPSL5 = "";
        //public string ALTCAGE6 = "";
        //public string ALTPN6 = "";
        //public string ALTRNCC6 = "";
        //public string ALTRNVC6 = "";
        //public string ALTDAC6 = "";
        //public string ALTPPSL6 = "";
        //public string MATERIAL1 = "";
        //public string MATERIAL2 = "";
        //public string MATERIAL3 = "";
        //public string MATERIAL4 = "";
        //public string RBD = "";
        //public string SUPPNOMEN1 = "";
        //public string AELA = "";
        //public string AELB = "";
        //public string AELC = "";
        //public string AELD = "";
        //public string AELE = "";
        //public string AELF = "";
        //public string AELG = "";
        //public string AELH = "";
        //public string SUPPNOMEN2 = "";
        //public string AFC2 = "";
        //public string AFCQTY2 = "";
        //public string ANC2 = "";
        //public string AOC2 = "";
        //public string AOCQTY2 = "";
        //public string LLTIL1 = "";
        //public string PPL1 = "";
        //public string SFPPL1 = "";
        //public string CBIL1 = "";
        //public string RIL1 = "";
        //public string ISIL1 = "";
        //public string PCL1 = "";
        //public string TTEL1 = "";
        //public string SCPL1 = "";
        //public string DCN1 = "";
        //public string ARF = "";
        //public string LLTIL2 = "";
        //public string PPL2 = "";
        //public string SFPPL2 = "";
        //public string CBIL2 = "";
        //public string RIL2 = "";
        //public string ISIL2 = "";
        //public string PCL2 = "";
        //public string TTEL2 = "";
        //public string SCPL2 = "";
        //public string DCN2 = "";
        //public string ACCCODE = "";
        //public string ALTNIINREL = "";
        //public string ALTNIIN = "";
        //public string ALTNIINREL2 = "";
        //public string ALTNIIN2 = "";
        //public string REFDES2 = "";
        //public string RDOC2 = "";
        //public string CHANGEAUTHORITY2 = "";
        //public string IC2 = "";
        //public string SNFROM2 = "";
        //public string SNTO2 = "";
        //public string TIC2 = "";
        //public string RSPLISN2 = "";
        //public string QTYSHIPPED2 = "";
        //public string QTYPROCURED2 = "";
        //public string DCNUOC2 = "";
        //public string PRORATEDELIN2 = "";
        //public string PRORATEDQTY2 = "";
        //public string LCN2 = "";
        //public string ALTLCN2 = "";
        //public string LENGTH = "";
        //public string WIDTH = "";
        //public string HEIGHT = "";
        //public string WEIGHT = "";
        //public string TEMP1 = "";
        public string DA = "";
        public string[] rowData = new string[] { };
        List<string[]> SortedAlternates = new List<string[]>();
        #endregion

        #region Constructors
        public ChangedPart()
        {

        }

        public ChangedPart(string[] partData)
        {
            PN = GetPartNumber(partData);
            OriginalPN = PN;
            CAGE = GetCAGE(partData);
            RNCC = GetReferenceNumberCategoryCode(partData);
            RNVC = GetReferenceNumberVariationCode(partData);
            DAC = GetDAC(partData);
            NAME = GetName(partData);
            SL = GetSL(partData);
            FSC = GetFederalSupplyClass(partData);
            NIIN = GetNationalItemIdentificationNumber(partData);
            UI = GetUI(partData);
            UIPRICE = GetUIPrice(partData);
            QUP = GetQUP(partData);
            DMIL = GetDemilitarizationCode(partData);
            PMIC = GetPMIC(partData);
            INC = GetItemNameCode(partData);
            DA = GetDA(partData);
            // using TEMP1 cell to identify rows that are added to the original list so that it may be highlighted green
            // using TEMP1 cell to idnicate that DA is present so that UI & UI PRICE it may be highlighted red
            if (DA != "DA")
            {
                TEMP1 = "    ";
            }
            else
            {
                TEMP1 = "   ";
            }

            rowData = new string[212] { PCCN, PLISN, INDC, CAGE, PN, RNCC, RNVC, DAC, PPSL, EC, NAME, SL, SLAC, COG, MCC, FSC, NIIN, NSNSUFF, UM, UMPRICE, UI, UIPRICE, CONV, QUP, SMR, DMIL, PLT, HCI, PSPC, PMIC, ADPEC, NHA, ORR, QPA, QPE, MRRI, MRRII, MRRMOD, TQR, SAPLISN, PRPLISN, MAOT, MAC, NRTS, UOC, REFDES, RDOC, RDC, SMCC, PLCC, SMIC, AIC, AICQTY, MRU, RMSS, RISS, RTLLQTY, RSR, OMTD, FMTD, HMTD, SRAMTD, DMTD, CEDMTD, CADMTD, ORCT, FRCT, HRCT, SRARCT, DRCT, CONRCT, ORTD, FRTD, HRTD, SRARTD, DRTD, DOP1, DOP2, CTIC, AMC, AMSC, IMC, RIP, CHANGEAUTHORITY1, IC, SNFROM, SNTO, TIC, RSPLISN, QTYSHIPPED, QTYPROCURED, DCNUOC, PRORATEDELIN, PRORATEDQTY, LCN, ALTLCN, REMARKS, TMCODE, FIGNUM, ITEMNUM, TMCHG, TMIND, QTYFIG, WUCTMFGC, BASISOFISSUE1, BASISOFISSUE2, CC, INC, LRU, PROVNOM, ALTCAGE1, ALTPN1, ALTRNCC1, ALTRNVC1, ALTDAC1, ALTPPSL1, ALTCAGE2, ALTPN2, ALTRNCC2, ALTRNVC2, ALTDAC2, ALTPPSL2, ALTCAGE3, ALTPN3, ALTRNCC3, ALTRNVC3, ALTDAC3, ALTPPSL3, ALTCAGE4, ALTPN4, ALTRNCC4, ALTRNVC4, ALTDAC4, ALTPPSL4, ALTCAGE5, ALTPN5, ALTRNCC5, ALTRNVC5, ALTDAC5, ALTPPSL5, ALTCAGE6, ALTPN6, ALTRNCC6, ALTRNVC6, ALTDAC6, ALTPPSL6, MATERIAL1, MATERIAL2, MATERIAL3, MATERIAL4, RBD, SUPPNOMEN1, AELA, AELB, AELC, AELD, AELE, AELF, AELG, AELH, SUPPNOMEN2, AFC2, AFCQTY2, ANC2, AOC2, AOCQTY2, LLTIL1, PPL1, SFPPL1, CBIL1, RIL1, ISIL1, PCL1, TTEL1, SCPL1, DCN1, ARF, LLTIL2, PPL2, SFPPL2, CBIL2, RIL2, ISIL2, PCL2, TTEL2, SCPL2, DCN2, ACCCODE, ALTNIINREL, ALTNIIN, ALTNIINREL2, ALTNIIN2, REFDES2, RDOC2, CHANGEAUTHORITY2, IC2, SNFROM2, SNTO2, TIC2, RSPLISN2, QTYSHIPPED2, QTYPROCURED2, DCNUOC2, PRORATEDELIN2, PRORATEDQTY2, LCN2, ALTLCN2, LENGTH, WIDTH, HEIGHT, WEIGHT, TEMP1 };
            SortedAlternates = CreateAlternates(partData);
            AssignAlternates(SortedAlternates);
            rowData = new string[212] { PCCN, PLISN, INDC, CAGE, PN, RNCC, RNVC, DAC, PPSL, EC, NAME, SL, SLAC, COG, MCC, FSC, NIIN, NSNSUFF, UM, UMPRICE, UI, UIPRICE, CONV, QUP, SMR, DMIL, PLT, HCI, PSPC, PMIC, ADPEC, NHA, ORR, QPA, QPE, MRRI, MRRII, MRRMOD, TQR, SAPLISN, PRPLISN, MAOT, MAC, NRTS, UOC, REFDES, RDOC, RDC, SMCC, PLCC, SMIC, AIC, AICQTY, MRU, RMSS, RISS, RTLLQTY, RSR, OMTD, FMTD, HMTD, SRAMTD, DMTD, CEDMTD, CADMTD, ORCT, FRCT, HRCT, SRARCT, DRCT, CONRCT, ORTD, FRTD, HRTD, SRARTD, DRTD, DOP1, DOP2, CTIC, AMC, AMSC, IMC, RIP, CHANGEAUTHORITY1, IC, SNFROM, SNTO, TIC, RSPLISN, QTYSHIPPED, QTYPROCURED, DCNUOC, PRORATEDELIN, PRORATEDQTY, LCN, ALTLCN, REMARKS, TMCODE, FIGNUM, ITEMNUM, TMCHG, TMIND, QTYFIG, WUCTMFGC, BASISOFISSUE1, BASISOFISSUE2, CC, INC, LRU, PROVNOM, ALTCAGE1, ALTPN1, ALTRNCC1, ALTRNVC1, ALTDAC1, ALTPPSL1, ALTCAGE2, ALTPN2, ALTRNCC2, ALTRNVC2, ALTDAC2, ALTPPSL2, ALTCAGE3, ALTPN3, ALTRNCC3, ALTRNVC3, ALTDAC3, ALTPPSL3, ALTCAGE4, ALTPN4, ALTRNCC4, ALTRNVC4, ALTDAC4, ALTPPSL4, ALTCAGE5, ALTPN5, ALTRNCC5, ALTRNVC5, ALTDAC5, ALTPPSL5, ALTCAGE6, ALTPN6, ALTRNCC6, ALTRNVC6, ALTDAC6, ALTPPSL6, MATERIAL1, MATERIAL2, MATERIAL3, MATERIAL4, RBD, SUPPNOMEN1, AELA, AELB, AELC, AELD, AELE, AELF, AELG, AELH, SUPPNOMEN2, AFC2, AFCQTY2, ANC2, AOC2, AOCQTY2, LLTIL1, PPL1, SFPPL1, CBIL1, RIL1, ISIL1, PCL1, TTEL1, SCPL1, DCN1, ARF, LLTIL2, PPL2, SFPPL2, CBIL2, RIL2, ISIL2, PCL2, TTEL2, SCPL2, DCN2, ACCCODE, ALTNIINREL, ALTNIIN, ALTNIINREL2, ALTNIIN2, REFDES2, RDOC2, CHANGEAUTHORITY2, IC2, SNFROM2, SNTO2, TIC2, RSPLISN2, QTYSHIPPED2, QTYPROCURED2, DCNUOC2, PRORATEDELIN2, PRORATEDQTY2, LCN2, ALTLCN2, LENGTH, WIDTH, HEIGHT, WEIGHT, TEMP1 };
        }
        #endregion

        #region Data extraction methods
        private void AssignAlternates(List<string[]> sortedAlternates)
        {
            int counter = 1;
            
            foreach (string[] AltPartArray in sortedAlternates)
            {
                if (counter <= 6 || counter <= sortedAlternates.Count)
                {
                    if (counter == 1)
                    {
                        ALTCAGE1 = AltPartArray[0];
                        ALTPN1 = AltPartArray[1];
                        ALTRNCC1 = AltPartArray[2];
                        ALTRNVC1 = AltPartArray[3];
                        ALTDAC1 = AltPartArray[4];
                    }
                    else if (counter == 2)
                    {
                        ALTCAGE2 = AltPartArray[0];
                        ALTPN2 = AltPartArray[1];
                        ALTRNCC2 = AltPartArray[2];
                        ALTRNVC2 = AltPartArray[3];
                        ALTDAC2 = AltPartArray[4];
                    }
                    else if (counter == 3)
                    {
                        ALTCAGE3 = AltPartArray[0];
                        ALTPN3 = AltPartArray[1];
                        ALTRNCC3 = AltPartArray[2];
                        ALTRNVC3 = AltPartArray[3];
                        ALTDAC3 = AltPartArray[4];
                    }
                    else if (counter == 4)
                    {
                        ALTCAGE4 = AltPartArray[0];
                        ALTPN4 = AltPartArray[1];
                        ALTRNCC4 = AltPartArray[2];
                        ALTRNVC4 = AltPartArray[3];
                        ALTDAC4 = AltPartArray[4];
                    }
                    else if (counter == 5)
                    {
                        ALTCAGE5 = AltPartArray[0];
                        ALTPN5 = AltPartArray[1];
                        ALTRNCC5 = AltPartArray[2];
                        ALTRNVC5 = AltPartArray[3];
                        ALTDAC5 = AltPartArray[4];
                    }
                    else if (counter == 6)
                    {
                        ALTCAGE6 = AltPartArray[0];
                        ALTPN6 = AltPartArray[1];
                        ALTRNCC6 = AltPartArray[2];
                        ALTRNVC6 = AltPartArray[3];
                        ALTDAC6 = AltPartArray[4];
                    }
                }
                else
                {
                    break;
                }
                counter++;
            }

            if (ALTCAGE1 != "")
            {
                // swap the original data found with the alternate part data that has been sorted to the top of the list
                string tempCAGE = rowData[3];
                string tempPN = rowData[4];
                string tempRNCC = rowData[5];
                string tempRNVC = rowData[6];
                string tempDAC = rowData[7];

                rowData[3] = ALTCAGE1;
                rowData[4] = ALTPN1;
                rowData[5] = ALTRNCC1;
                rowData[6] = ALTRNVC1;
                rowData[7] = ALTDAC1;

                ALTCAGE1 = tempCAGE;
                ALTPN1 = tempPN;
                ALTRNCC1 = tempRNCC;
                ALTRNVC1 = tempRNVC;
                ALTDAC1 = tempDAC;
            }
    }

        private List<string[]> CreateAlternates(string[] partData)
        {
            List<string[]> UnsortedAlternates = new List<string[]>();
            List<string[]> SortedAlternates = new List<string[]>();

            string PartType = GetPartType(partData);
            partData = GetLinesForThisPartTypeOnly(partData, PartType);

            for (int i = 0; i < partData.Length; i++)
            {
                // check to see if line from the partData array is a segment code C and a segment line number 1 as this type of line holds alternate part data
                if (GetSegmentCode(partData[i]).ToUpper() == "C" && GetSegmentLineNumber(partData[i]).ToUpper() == "1")
                {
                    List<string> currentAlternatePartData = new List<string>();
                    currentAlternatePartData.Add(partData[i].Substring(54, 5).Trim());
                    currentAlternatePartData.Add(partData[i].Substring(59, 16).Trim());
                    currentAlternatePartData.Add(partData[i].Substring(43, 1).Trim());
                    currentAlternatePartData.Add(partData[i].Substring(45, 1).Trim());
                    currentAlternatePartData.Add(partData[i].Substring(47, 1).Trim());

                    UnsortedAlternates.Add(currentAlternatePartData.ToArray());
                }
            }
            SortedAlternates = SortAlternates(UnsortedAlternates);
            return SortedAlternates;
        }

        private List<string[]> SortAlternates(List<string[]> unsortedAlternates)
        {
            List<string[]> SortedAlts = new List<string[]>();

            List<string[]> Seq1 = new List<string[]>(); // for RNCC, RNVC: 1,2
            List<string[]> Seq2 = new List<string[]>(); // for RNCC, RNVC: 1,3
            List<string[]> Seq3 = new List<string[]>(); // for RNCC, RNVC: 7,2
            List<string[]> Seq4 = new List<string[]>(); // for RNCC, RNVC: 2,2
            List<string[]> Seq5 = new List<string[]>(); // for RNCC, RNVC: 2,9
            List<string[]> Seq6 = new List<string[]>(); // for RNCC, RNVC: 3,2
            List<string[]> Seq7 = new List<string[]>(); // for RNCC, RNVC: 3,3
            List<string[]> Seq8 = new List<string[]>(); // for RNCC, RNVC: 3,9
            List<string[]> Seq9 = new List<string[]>(); // for RNCC, RNVC: 7,9
            List<string[]> Seq10 = new List<string[]>(); // for RNCC, RNVC: 5,2
            List<string[]> Seq11 = new List<string[]>(); // for RNCC, RNVC: 5,3
            List<string[]> Seq12 = new List<string[]>(); // for RNCC, RNVC: 8,2
            List<string[]> Seq13 = new List<string[]>(); // for RNCC, RNVC: 2,1
            List<string[]> Seq14 = new List<string[]>(); // for RNCC, RNVC: 4,1
            List<string[]> Seq15 = new List<string[]>(); // for RNCC, RNVC: 3,1
            List<string[]> Seq16 = new List<string[]>(); // for RNCC, RNVC: 7,1
            List<string[]> Seq17 = new List<string[]>(); // for RNCC, RNVC: 5,1
            List<string[]> Seq18 = new List<string[]>(); // for RNCC, RNVC: 6,9
            List<string[]> Seq19 = new List<string[]>(); // for RNCC, RNVC: D,9
            List<string[]> Seq20 = new List<string[]>(); // for RNCC, RNVC: 8,1
            List<string[]> Seq21 = new List<string[]>(); // for RNCC, RNVC: A,2
            List<string[]> Seq22 = new List<string[]>(); // for RNCC, RNVC: A,1
            List<string[]> Seq23 = new List<string[]>(); // for RNCC, RNVC: 5,9
            List<string[]> Seq24 = new List<string[]>(); // for RNCC, RNVC: C,1
            List<string[]> Seq25 = new List<string[]>(); // for RNCC, RNVC: E,8
            List<string[]> Seq26 = new List<string[]>(); // for RNCC RNVC patterns that don't match any of the above sequences

            List<string[]>[] SortList;
            SortList = new List<string[]>[] { Seq1, Seq2, Seq3, Seq4, Seq5, Seq6, Seq7, Seq8, Seq9, Seq10, Seq11, Seq12, Seq13, Seq14, Seq15, Seq16, Seq17, Seq18, Seq19, Seq20, Seq21, Seq22, Seq23, Seq24, Seq25, Seq26 };
                        
            foreach (string[] item in unsortedAlternates)
            {
                if ((item[2] + item[3]) == "12")
                {
                    Seq1.Add(item);
                }
                else if ((item[2] + item[3]) == "13")
                {
                    Seq2.Add(item);
                }
                else if ((item[2] + item[3]) == "72")
                {
                    Seq3.Add(item);
                }
                else if ((item[2] + item[3]) == "22")
                {
                    Seq4.Add(item);
                }
                else if ((item[2] + item[3]) == "29")
                {
                    Seq5.Add(item);
                }
                else if ((item[2] + item[3]) == "32")
                {
                    Seq6.Add(item);
                }
                else if ((item[2] + item[3]) == "33")
                {
                    Seq7.Add(item);
                }
                else if ((item[2] + item[3]) == "39")
                {
                    Seq8.Add(item);
                }
                else if ((item[2] + item[3]) == "79")
                {
                    Seq9.Add(item);
                }
                else if ((item[2] + item[3]) == "52")
                {
                    Seq10.Add(item);
                }
                else if ((item[2] + item[3]) == "53")
                {
                    Seq11.Add(item);
                }
                else if ((item[2] + item[3]) == "82")
                {
                    Seq12.Add(item);
                }
                else if ((item[2] + item[3]) == "21")
                {
                    Seq13.Add(item);
                }
                else if ((item[2] + item[3]) == "41")
                {
                    Seq14.Add(item);
                }
                else if ((item[2] + item[3]) == "31")
                {
                    Seq15.Add(item);
                }
                else if ((item[2] + item[3]) == "71")
                {
                    Seq16.Add(item);
                }
                else if ((item[2] + item[3]) == "51")
                {
                    Seq17.Add(item);
                }
                else if ((item[2] + item[3]) == "69")
                {
                    Seq18.Add(item);
                }
                else if ((item[2] + item[3]) == "D9")
                {
                    Seq19.Add(item);
                }
                else if ((item[2] + item[3]) == "81")
                {
                    Seq20.Add(item);
                }
                else if ((item[2] + item[3]) == "A2")
                {
                    Seq21.Add(item);
                }
                else if ((item[2] + item[3]) == "A1")
                {
                    Seq22.Add(item);
                }
                else if ((item[2] + item[3]) == "59")
                {
                    Seq23.Add(item);
                }
                else if ((item[2] + item[3]) == "C1")
                {
                    Seq24.Add(item);
                }
                else if ((item[2] + item[3]) == "E8")
                {
                    Seq25.Add(item);
                }
                else
                {
                    Seq26.Add(item);
                }
            }

            if (unsortedAlternates.Count > 0)
            {
                for (int i = 0; i < SortList.Length; i++)
                {
                    foreach (string[] AltArray in SortList[i])
                    {
                        SortedAlts.Add(AltArray);
                    }
                }
            }

            return SortedAlts;
        }

        private string GetALTCAGE(string[] partData)
        {
            string ALTCAGE1 = string.Empty;

            return ALTCAGE1;
        }

        private string GetALTPN(string[] partData)
        {
            string ALTPN1 = string.Empty;

            return ALTPN1;
        }

        private string GetALTRNCC(string[] partData)
        {
            string ALTRNCC1 = string.Empty;

            return ALTRNCC1;
        }

        private string GetALTRNVC(string[] partData)
        {
            string ALTRNVC1 = string.Empty;

            return ALTRNVC1;
        }

        private string GetALTDAC(string[] partData)
        {
            string ALTDAC1 = string.Empty;

            return ALTDAC1;
        }

        private string GetCAGE(string[] partData)
        {
            string CAGE = string.Empty;

            CAGE = ExtractCellData(partData, "J", "1", 41, 5);
            return CAGE;
        }

        private string GetItemNameCode(string[] partData)
        {
            string PartType = GetPartType(partData);
            partData = GetLinesForThisPartTypeOnly(partData, PartType);
            string INC = string.Empty;

            INC = ExtractCellData(partData, "A", "J", 46, 5);
            return INC;
        }

        private string GetPMIC(string[] partData)
        {
            string PartType = GetPartType(partData);
            partData = GetLinesForThisPartTypeOnly(partData, PartType);
            string PMIC = string.Empty;

            PMIC = ExtractCellData(partData, "A", "2", 42, 1);
            return PMIC;
        }

        private string GetDemilitarizationCode(string[] partData)
        {
            string PartType = GetPartType(partData);
            partData = GetLinesForThisPartTypeOnly(partData, PartType);
            string DMIL = string.Empty;

            DMIL = ExtractCellData(partData, "A", "J", 73, 1);
            return DMIL;
        }

        private string GetQUP(string[] partData)
        {
            string PartType = GetPartType(partData);
            partData = GetLinesForThisPartTypeOnly(partData, PartType);
            string QUP = string.Empty;

            QUP = ExtractCellData(partData, "H", "2", 41, 1);
            return QUP;
        }

        private string GetUIPrice(string[] partData)
        {
            string PartType = GetPartType(partData);
            partData = GetLinesForThisPartTypeOnly(partData, PartType);
            string UIPrice = string.Empty;

            UIPrice = ExtractCellData(partData, "H", "J", 69, 9);

            if (UIPrice != "")
            {
                //insert decimal point before the tenths place 
                string unformattedUIPrice;
                unformattedUIPrice = UIPrice.Insert(UIPrice.Length - 2, ".");
                //remove leading zeros
                UIPrice = unformattedUIPrice.TrimStart('0');
                //add leading zero if price is less than 1.00
                if (UIPrice[0].ToString() == ".")
                {
                    UIPrice = "0" + UIPrice;
                }
            }

            return UIPrice;
        }

        private string GetUI(string[] partData)
        {
            string PartType = GetPartType(partData);
            partData = GetLinesForThisPartTypeOnly(partData, PartType);
            string UI = string.Empty;

            UI = ExtractCellData(partData, "H", "J", 63, 2);
            return UI;
        }

        private string GetNationalItemIdentificationNumber(string[] partData)
        {
            string PartType = GetPartType(partData);
            partData = GetLinesForThisPartTypeOnly(partData, PartType);
            string NIIN = string.Empty;

            NIIN = ExtractCellData(partData, "A", "J", 30, 9);
            return NIIN;
        }

        private string GetSL(string[] partData)
        {
            string PartType = GetPartType(partData);
            partData = GetLinesForThisPartTypeOnly(partData, PartType);
            string SL = string.Empty;

            SL = ExtractCellData(partData, "H", "2", 45, 1);
            return SL;
        }

        private string GetDAC(string[] partData)
        {
            string PartType = GetPartType(partData);
            partData = GetLinesForThisPartTypeOnly(partData, PartType);
            string DAC = string.Empty;

            DAC = ExtractCellData(partData, "C", "1", 45, 1);
            return DAC;
        }

        private string GetDA(string[] partData)
        {
            string PartType = GetPartType(partData);
            partData = GetLinesForThisPartTypeOnly(partData, PartType);
            string DA = string.Empty;

            DA = ExtractCellData(partData, "H", "J", 54, 2);
            return DA;
        }

        private string GetName(string[] partData)
        {
            string PartType = GetPartType(partData);
            partData = GetLinesForThisPartTypeOnly(partData, PartType);
            string Name = string.Empty;

            Name = ExtractCellData(partData, "A", "J", 51, 19);
            return Name;
        }

        private string GetReferenceNumberVariationCode(string[] partData)
        {
            string PartType = GetPartType(partData);
            partData = GetLinesForThisPartTypeOnly(partData, PartType);
            string RNVC = string.Empty;

            RNVC = ExtractCellData(partData, "C", "1", 45, 1);
            return RNVC;
        }

        private string GetReferenceNumberCategoryCode(string[] partData)
        {
            string PartType = GetPartType(partData);
            partData = GetLinesForThisPartTypeOnly(partData, PartType);
            string RNCC = string.Empty;

            RNCC = ExtractCellData(partData, "C", "1", 43, 1);
            return RNCC;
        }

        private string GetFederalSupplyClass(string[] partData)
        {
            string PartType = GetPartType(partData);
            partData = GetLinesForThisPartTypeOnly(partData, PartType);
            string FSC = string.Empty;

            FSC = ExtractCellData(partData, "A", "J", 26, 4);
            return FSC;
        }

        private string[] GetLinesForThisPartTypeOnly(string[] partData, string partType)
        {
            List<string> newPartData = new List<string>();
            for (int i = 0; i < partData.Length; i++)
            {
                string lineCode = (partData[i][0].ToString() + partData[i][1].ToString() + partData[i][2].ToString());
                //KMA lines are treated the same as KMR
                if (lineCode == "KMA")
                {
                    lineCode = "KMP";
                }
                if (lineCode == partType)
                {
                    newPartData.Add(partData[i]);
                }
            }
            string[] newPartDataArray = newPartData.ToArray();
            return newPartDataArray;
        }

        private string GetPartType(string[] partData)
        {
            string PartType = string.Empty;
            List<string> lineCodeList = new List<string>();

            for (int i = 0; i < partData.Length; i++)
            {
                lineCodeList.Add(GetLineCode(partData[i]));
            }

            if (lineCodeList.Contains("KME"))
            {
                PartType = "KME";
            }
            else if (lineCodeList.Contains("KMT"))
            {
                PartType = "KMT";
            }
            else
            {
                PartType = "KMP";
            }

            return PartType;
        }

        private string ExtractCellData(string[] partData, string segCode, string segLineNum, int pos, int len)
        {
            string extractedData = string.Empty;
            for (int i = 0; i < partData.Length; i++)
            {
                // looking for specified segment on specified line, once found, assign data, break for loop, and return value
                if (GetSegmentCode(partData[i]).ToUpper() == segCode && GetSegmentLineNumber(partData[i]).ToUpper() == segLineNum)
                {
                    extractedData = partData[i].Substring(pos, len).Trim();
                    break;
                }
            }
            return extractedData;
        }

        private string GetPartNumber(string[] partData)
        {
            string PN = string.Empty;

            if (GetLineCode(partData[0]) == "KMR")
            {
                PN = partData[0].Substring(47, 32).Trim();
            }

            return PN.ToUpper();
        }

        private string GetLineCode(string partData)
        {
            string lineCode = string.Empty;
            char[] pplChar = partData.ToCharArray();
            if (partData.Length > 3)
            {
                lineCode = (pplChar[0].ToString() + pplChar[1].ToString() + pplChar[2].ToString());
            }
            return lineCode;
        }

        private string GetSegmentCode(string partData)
        {
            string segmentCode = string.Empty;
            if (partData[39].ToString() != null)
            {
                segmentCode = partData[39].ToString();
            }
            return segmentCode;
        }

        private string GetSegmentLineNumber(string partData)
        {
            string segmentLineNumber = string.Empty;
            if (partData[79].ToString() != null)
            {
                segmentLineNumber = partData[79].ToString();
            }
            return segmentLineNumber;
        }
        #endregion
    }
}
