namespace MoneyPattern
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// ISO 4217 currency code and numeric code.
    /// </summary>
    public abstract class CurrencyOf
    {
        public static readonly CurrencyOf AedType = new AED();
        public static readonly CurrencyOf AfnType = new AFN();
        public static readonly CurrencyOf AllType = new ALL();
        public static readonly CurrencyOf AmdType = new AMD();
        public static readonly CurrencyOf AngType = new ANG();
        public static readonly CurrencyOf AoaType = new AOA();
        public static readonly CurrencyOf ArsType = new ARS();
        public static readonly CurrencyOf AudType = new AUD();
        public static readonly CurrencyOf AwgType = new AWG();
        public static readonly CurrencyOf AznType = new AZN();
        public static readonly CurrencyOf BamType = new BAM();
        public static readonly CurrencyOf BbdType = new BBD();
        public static readonly CurrencyOf BdtType = new BDT();
        public static readonly CurrencyOf BgnType = new BGN();
        public static readonly CurrencyOf BhdType = new BHD();
        public static readonly CurrencyOf BifType = new BIF();
        public static readonly CurrencyOf BmdType = new BMD();
        public static readonly CurrencyOf BndType = new BND();
        public static readonly CurrencyOf BobType = new BOB();
        public static readonly CurrencyOf BovType = new BOV();
        public static readonly CurrencyOf BrlType = new BRL();
        public static readonly CurrencyOf BsdType = new BSD();
        public static readonly CurrencyOf BtnType = new BTN();
        public static readonly CurrencyOf BwpType = new BWP();
        public static readonly CurrencyOf ByrType = new BYR();
        public static readonly CurrencyOf BzdType = new BZD();
        public static readonly CurrencyOf CadType = new CAD();
        public static readonly CurrencyOf CdfType = new CDF();
        public static readonly CurrencyOf CheType = new CHE();
        public static readonly CurrencyOf ChfType = new CHF();
        public static readonly CurrencyOf ChwType = new CHW();
        public static readonly CurrencyOf ClfType = new CLF();
        public static readonly CurrencyOf ClpType = new CLP();
        public static readonly CurrencyOf CnyType = new CNY();
        public static readonly CurrencyOf CopType = new COP();
        public static readonly CurrencyOf CouType = new COU();
        public static readonly CurrencyOf CrcType = new CRC();
        public static readonly CurrencyOf CucType = new CUC();
        public static readonly CurrencyOf CupType = new CUP();
        public static readonly CurrencyOf CveType = new CVE();
        public static readonly CurrencyOf CzkType = new CZK();
        public static readonly CurrencyOf DjfType = new DJF();
        public static readonly CurrencyOf DkkType = new DKK();
        public static readonly CurrencyOf DopType = new DOP();
        public static readonly CurrencyOf DzdType = new DZD();
        public static readonly CurrencyOf EgpType = new EGP();
        public static readonly CurrencyOf ErnType = new ERN();
        public static readonly CurrencyOf EtbType = new ETB();
        public static readonly CurrencyOf EurType = new EUR();
        public static readonly CurrencyOf FjdType = new FJD();
        public static readonly CurrencyOf FkpType = new FKP();
        public static readonly CurrencyOf GbpType = new GBP();
        public static readonly CurrencyOf GelType = new GEL();
        public static readonly CurrencyOf GhsType = new GHS();
        public static readonly CurrencyOf GipType = new GIP();
        public static readonly CurrencyOf GmdType = new GMD();
        public static readonly CurrencyOf GnfType = new GNF();
        public static readonly CurrencyOf GtqType = new GTQ();
        public static readonly CurrencyOf GydType = new GYD();
        public static readonly CurrencyOf HkdType = new HKD();
        public static readonly CurrencyOf HnlType = new HNL();
        public static readonly CurrencyOf HrkType = new HRK();
        public static readonly CurrencyOf HtgType = new HTG();
        public static readonly CurrencyOf HufType = new HUF();
        public static readonly CurrencyOf IdrType = new IDR();
        public static readonly CurrencyOf IlsType = new ILS();
        public static readonly CurrencyOf InrType = new INR();
        public static readonly CurrencyOf IqdType = new IQD();
        public static readonly CurrencyOf IrrType = new IRR();
        public static readonly CurrencyOf IskType = new ISK();
        public static readonly CurrencyOf JmdType = new JMD();
        public static readonly CurrencyOf JodType = new JOD();
        public static readonly CurrencyOf JpyType = new JPY();
        public static readonly CurrencyOf KesType = new KES();
        public static readonly CurrencyOf KgsType = new KGS();
        public static readonly CurrencyOf KhrType = new KHR();
        public static readonly CurrencyOf KmfType = new KMF();
        public static readonly CurrencyOf KpwType = new KPW();
        public static readonly CurrencyOf KrwType = new KRW();
        public static readonly CurrencyOf KwdType = new KWD();
        public static readonly CurrencyOf KydType = new KYD();
        public static readonly CurrencyOf KztType = new KZT();
        public static readonly CurrencyOf LakType = new LAK();
        public static readonly CurrencyOf LbpType = new LBP();
        public static readonly CurrencyOf LkrType = new LKR();
        public static readonly CurrencyOf LrdType = new LRD();
        public static readonly CurrencyOf LslType = new LSL();
        public static readonly CurrencyOf LydType = new LYD();
        public static readonly CurrencyOf MadType = new MAD();
        public static readonly CurrencyOf MdlType = new MDL();
        public static readonly CurrencyOf MgaType = new MGA();
        public static readonly CurrencyOf MkdType = new MKD();
        public static readonly CurrencyOf MmkType = new MMK();
        public static readonly CurrencyOf MntType = new MNT();
        public static readonly CurrencyOf MopType = new MOP();
        public static readonly CurrencyOf MroType = new MRO();
        public static readonly CurrencyOf MurType = new MUR();
        public static readonly CurrencyOf MvrType = new MVR();
        public static readonly CurrencyOf MwkType = new MWK();
        public static readonly CurrencyOf MxnType = new MXN();
        public static readonly CurrencyOf MxvType = new MXV();
        public static readonly CurrencyOf MyrType = new MYR();
        public static readonly CurrencyOf MznType = new MZN();
        public static readonly CurrencyOf NadType = new NAD();
        public static readonly CurrencyOf NgnType = new NGN();
        public static readonly CurrencyOf NioType = new NIO();
        public static readonly CurrencyOf NokType = new NOK();
        public static readonly CurrencyOf NprType = new NPR();
        public static readonly CurrencyOf NzdType = new NZD();
        public static readonly CurrencyOf OmrType = new OMR();
        public static readonly CurrencyOf PabType = new PAB();
        public static readonly CurrencyOf PenType = new PEN();
        public static readonly CurrencyOf PgkType = new PGK();
        public static readonly CurrencyOf PhpType = new PHP();
        public static readonly CurrencyOf PkrType = new PKR();
        public static readonly CurrencyOf PlnType = new PLN();
        public static readonly CurrencyOf PygType = new PYG();
        public static readonly CurrencyOf QarType = new QAR();
        public static readonly CurrencyOf RonType = new RON();
        public static readonly CurrencyOf RsdType = new RSD();
        public static readonly CurrencyOf RubType = new RUB();
        public static readonly CurrencyOf RwfType = new RWF();
        public static readonly CurrencyOf SarType = new SAR();
        public static readonly CurrencyOf SbdType = new SBD();
        public static readonly CurrencyOf ScrType = new SCR();
        public static readonly CurrencyOf SdgType = new SDG();
        public static readonly CurrencyOf SekType = new SEK();
        public static readonly CurrencyOf SgdType = new SGD();
        public static readonly CurrencyOf ShpType = new SHP();
        public static readonly CurrencyOf SllType = new SLL();
        public static readonly CurrencyOf SosType = new SOS();
        public static readonly CurrencyOf SrdType = new SRD();
        public static readonly CurrencyOf SspType = new SSP();
        public static readonly CurrencyOf StdType = new STD();
        public static readonly CurrencyOf SvcType = new SVC();
        public static readonly CurrencyOf SypType = new SYP();
        public static readonly CurrencyOf SzlType = new SZL();
        public static readonly CurrencyOf ThbType = new THB();
        public static readonly CurrencyOf TjsType = new TJS();
        public static readonly CurrencyOf TmtType = new TMT();
        public static readonly CurrencyOf TndType = new TND();
        public static readonly CurrencyOf TopType = new TOP();
        public static readonly CurrencyOf TryType = new TRY();
        public static readonly CurrencyOf TtdType = new TTD();
        public static readonly CurrencyOf TwdType = new TWD();
        public static readonly CurrencyOf TzsType = new TZS();
        public static readonly CurrencyOf UahType = new UAH();
        public static readonly CurrencyOf UgxType = new UGX();
        public static readonly CurrencyOf UsdType = new USD();
        public static readonly CurrencyOf UsnType = new USN();
        public static readonly CurrencyOf UyiType = new UYI();
        public static readonly CurrencyOf UyuType = new UYU();
        public static readonly CurrencyOf UzsType = new UZS();
        public static readonly CurrencyOf VefType = new VEF();
        public static readonly CurrencyOf VndType = new VND();
        public static readonly CurrencyOf VuvType = new VUV();
        public static readonly CurrencyOf WstType = new WST();
        public static readonly CurrencyOf XafType = new XAF();
        public static readonly CurrencyOf XagType = new XAG();
        public static readonly CurrencyOf XauType = new XAU();
        public static readonly CurrencyOf XbaType = new XBA();
        public static readonly CurrencyOf XbbType = new XBB();
        public static readonly CurrencyOf XbcType = new XBC();
        public static readonly CurrencyOf XbdType = new XBD();
        public static readonly CurrencyOf XcdType = new XCD();
        public static readonly CurrencyOf XdrType = new XDR();
        public static readonly CurrencyOf XofType = new XOF();
        public static readonly CurrencyOf XpdType = new XPD();
        public static readonly CurrencyOf XpfType = new XPF();
        public static readonly CurrencyOf XptType = new XPT();
        public static readonly CurrencyOf XsuType = new XSU();
        public static readonly CurrencyOf XtsType = new XTS();
        public static readonly CurrencyOf XuaType = new XUA();
        public static readonly CurrencyOf XxxType = new XXX();
        public static readonly CurrencyOf YerType = new YER();
        public static readonly CurrencyOf ZarType = new ZAR();
        public static readonly CurrencyOf ZmwType = new ZMW();
        public static readonly CurrencyOf ZwlType = new ZWL();

        private readonly string _key;
        public string Key => _key;

        private readonly string _value;
        public string Value => _value;

        private CurrencyOf(string name, string isoCode)
        {
            this._key = isoCode;
            this._value = name;
        }

        public static IReadOnlyCollection<CurrencyOf> GetAll()
        {
            return new[] { AedType };
        }

        private static T ThrowException<T>()
        {
            throw new ArgumentOutOfRangeException();
        }

        public static CurrencyOf FindBy(string isoCode)
        {
            return GetAll().SingleOrDefault(s => s.Key == isoCode) ?? ThrowException<CurrencyOf>();
        }

        private class AED : CurrencyOf
        {
            public AED() : base(nameof(AED), "784") { }
        }

        private class AFN : CurrencyOf
        {
            public AFN() : base(nameof(AFN), "971") { }
        }

        private class ALL : CurrencyOf
        {
            public ALL() : base(nameof(ALL), "008") { }
        }

        private class AMD : CurrencyOf
        {
            public AMD() : base(nameof(AMD), "051")
            {
            }
        }

        private class ANG : CurrencyOf
        {
            public ANG() : base(nameof(ANG), "532")
            {
            }
        }

        private class AOA : CurrencyOf
        {
            public AOA() : base(nameof(AOA), "973")
            {
            }
        }

        private class ARS : CurrencyOf
        {
            public ARS() : base(nameof(ARS), "032") { }
        }

        private class AUD : CurrencyOf
        {
            public AUD() : base(nameof(AUD), "036") { }
        }

        private class AWG : CurrencyOf
        {
            public AWG() : base(nameof(AWG), "533") { }
        }

        private class AZN : CurrencyOf
        {
            public AZN() : base(nameof(AZN), "944") { }
        }

        private class BAM : CurrencyOf
        {
            public BAM() : base(nameof(BAM), "977") { }
        }

        private class BBD : CurrencyOf
        {
            public BBD() : base(nameof(BBD), "052") { }
        }

        private class BDT : CurrencyOf
        {
            public BDT() : base(nameof(BDT), "050") { }
        }

        private class BGN : CurrencyOf
        {
            public BGN() : base(nameof(BGN), "975") { }
        }

        private class BHD : CurrencyOf
        {
            public BHD() : base(nameof(BHD), "048") { }
        }

        private class BIF : CurrencyOf
        {
            public BIF() : base(nameof(BIF), "108") { }
        }

        private class BMD : CurrencyOf
        {
            public BMD() : base(nameof(BMD), "060") { }
        }

        private class BND : CurrencyOf
        {
            public BND() : base(nameof(BND), "096") { }
        }

        private class BOB : CurrencyOf
        {
            public BOB() : base(nameof(BOB), "068") { }
        }

        private class BOV : CurrencyOf
        {
            public BOV() : base(nameof(BOV), "984") { }
        }

        private class BRL : CurrencyOf
        {
            public BRL() : base(nameof(BRL), "986") { }
        }

        private class BSD : CurrencyOf
        {
            public BSD() : base(nameof(BSD), "044") { }
        }

        private class BTN : CurrencyOf
        {
            public BTN() : base(nameof(BTN), "064") { }
        }

        private class BWP : CurrencyOf
        {
            public BWP() : base(nameof(BWP), "072") { }
        }

        private class BYR : CurrencyOf
        {
            public BYR() : base(nameof(BYR), "974") { }
        }

        private class BZD : CurrencyOf
        {
            public BZD() : base(nameof(BZD), "084") { }
        }

        private class CAD : CurrencyOf
        {
            public CAD() : base(nameof(CAD), "124") { }
        }

        private class CDF : CurrencyOf
        {
            public CDF() : base(nameof(CDF), "976") { }
        }

        private class CHE : CurrencyOf
        {
            public CHE() : base(nameof(CHE), "947") { }
        }

        private class CHF : CurrencyOf
        {
            public CHF() : base(nameof(CHF), "756") { }
        }

        private class CHW : CurrencyOf
        {
            public CHW() : base(nameof(CHW), "948") { }
        }

        private class CLF : CurrencyOf
        {
            public CLF() : base(nameof(CLF), "990") { }
        }

        private class CLP : CurrencyOf
        {
            public CLP() : base(nameof(CLP), "152") { }
        }

        private class CNY : CurrencyOf
        {
            public CNY() : base(nameof(CNY), "156") { }
        }

        private class COP : CurrencyOf
        {
            public COP() : base(nameof(COP), "170") { }
        }

        private class COU : CurrencyOf
        {
            public COU() : base(nameof(COU), "970") { }
        }

        private class CRC : CurrencyOf
        {
            public CRC() : base(nameof(CRC), "188") { }
        }

        private class CUC : CurrencyOf
        {
            public CUC() : base(nameof(CUC), "931") { }
        }

        private class CUP : CurrencyOf
        {
            public CUP() : base(nameof(CUP), "192") { }
        }

        private class CVE : CurrencyOf
        {
            public CVE() : base(nameof(CVE), "132") { }
        }

        private class CZK : CurrencyOf
        {
            public CZK() : base(nameof(CZK), "203") { }
        }

        private class DJF : CurrencyOf
        {
            public DJF() : base(nameof(DJF), "262") { }
        }

        private class DKK : CurrencyOf
        {
            public DKK() : base(nameof(DKK), "208") { }
        }

        private class DOP : CurrencyOf
        {
            public DOP() : base(nameof(DOP), "214") { }
        }

        private class DZD : CurrencyOf
        {
            public DZD() : base(nameof(DZD), "012") { }
        }

        private class EGP : CurrencyOf
        {
            public EGP() : base(nameof(EGP), "818") { }
        }

        private class ERN : CurrencyOf
        {
            public ERN() : base(nameof(ERN), "232") { }
        }

        private class ETB : CurrencyOf
        {
            public ETB() : base(nameof(ETB), "230") { }
        }

        private class EUR : CurrencyOf
        {
            public EUR() : base(nameof(EUR), "978") { }
        }

        private class FJD : CurrencyOf
        {
            public FJD() : base(nameof(FJD), "242") { }
        }

        private class FKP : CurrencyOf
        {
            public FKP() : base(nameof(FKP), "238") { }
        }

        private class GBP : CurrencyOf
        {
            public GBP() : base(nameof(GBP), "826") { }
        }

        private class GEL : CurrencyOf
        {
            public GEL() : base(nameof(GEL), "981") { }
        }

        private class GHS : CurrencyOf
        {
            public GHS() : base(nameof(GHS), "936") { }
        }

        private class GIP : CurrencyOf
        {
            public GIP() : base(nameof(GIP), "292") { }
        }

        private class GMD : CurrencyOf
        {
            public GMD() : base(nameof(GMD), "270") { }
        }

        private class GNF : CurrencyOf
        {
            public GNF() : base(nameof(GNF), "324") { }
        }

        private class GTQ : CurrencyOf
        {
            public GTQ() : base(nameof(GTQ), "320") { }
        }

        private class GYD : CurrencyOf
        {
            public GYD() : base(nameof(GYD), "328") { }
        }

        private class HKD : CurrencyOf
        {
            public HKD() : base(nameof(HKD), "344") { }
        }

        private class HNL : CurrencyOf
        {
            public HNL() : base(nameof(HNL), "340") { }
        }

        private class HRK : CurrencyOf
        {
            public HRK() : base(nameof(HRK), "191") { }
        }

        private class HTG : CurrencyOf
        {
            public HTG() : base(nameof(HTG), "332") { }
        }

        private class HUF : CurrencyOf
        {
            public HUF() : base(nameof(HUF), "348") { }
        }

        private class IDR : CurrencyOf
        {
            public IDR() : base(nameof(IDR), "360") { }
        }

        private class ILS : CurrencyOf
        {
            public ILS() : base(nameof(ILS), "376") { }
        }

        private class INR : CurrencyOf
        {
            public INR() : base(nameof(INR), "356") { }
        }

        private class IQD : CurrencyOf
        {
            public IQD() : base(nameof(IQD), "368") { }
        }

        private class IRR : CurrencyOf
        {
            public IRR() : base(nameof(IRR), "364") { }
        }

        private class ISK : CurrencyOf
        {
            public ISK() : base(nameof(ISK), "352") { }
        }

        private class JMD : CurrencyOf
        {
            public JMD() : base(nameof(JMD), "388") { }
        }

        private class JOD : CurrencyOf
        {
            public JOD() : base(nameof(JOD), "400") { }
        }

        private class JPY : CurrencyOf
        {
            public JPY() : base(nameof(JPY), "392") { }
        }

        private class KES : CurrencyOf
        {
            public KES() : base(nameof(KES), "404") { }
        }

        private class KGS : CurrencyOf
        {
            public KGS() : base(nameof(KGS), "417") { }
        }

        private class KHR : CurrencyOf
        {
            public KHR() : base(nameof(KHR), "116") { }
        }

        private class KMF : CurrencyOf
        {
            public KMF() : base(nameof(KMF), "174") { }
        }

        private class KPW : CurrencyOf
        {
            public KPW() : base(nameof(KPW), "408") { }
        }

        private class KRW : CurrencyOf
        {
            public KRW() : base(nameof(KRW), "410") { }
        }

        private class KWD : CurrencyOf
        {
            public KWD() : base(nameof(KWD), "414") { }
        }

        private class KYD : CurrencyOf
        {
            public KYD() : base(nameof(KYD), "136") { }
        }

        private class KZT : CurrencyOf
        {
            public KZT() : base(nameof(KZT), "398") { }
        }

        private class LAK : CurrencyOf
        {
            public LAK() : base(nameof(LAK), "418") { }
        }

        private class LBP : CurrencyOf
        {
            public LBP() : base(nameof(LBP), "422") { }
        }

        private class LKR : CurrencyOf
        {
            public LKR() : base(nameof(LKR), "144") { }
        }

        private class LRD : CurrencyOf
        {
            public LRD() : base(nameof(LRD), "430") { }
        }

        private class LSL : CurrencyOf
        {
            public LSL() : base(nameof(LSL), "426") { }
        }

        private class LYD : CurrencyOf
        {
            public LYD() : base(nameof(LYD), "434") { }
        }

        private class MAD : CurrencyOf
        {
            public MAD() : base(nameof(MAD), "504") { }
        }

        private class MDL : CurrencyOf
        {
            public MDL() : base(nameof(MDL), "498") { }
        }

        private class MGA : CurrencyOf
        {
            public MGA() : base(nameof(MGA), "969") { }
        }

        private class MKD : CurrencyOf
        {
            public MKD() : base(nameof(MKD), "807") { }
        }

        private class MMK : CurrencyOf
        {
            public MMK() : base(nameof(MMK), "104") { }
        }

        private class MNT : CurrencyOf
        {
            public MNT() : base(nameof(MNT), "496") { }
        }

        private class MOP : CurrencyOf
        {
            public MOP() : base(nameof(MOP), "446") { }
        }

        private class MRO : CurrencyOf
        {
            public MRO() : base(nameof(MRO), "478") { }
        }

        private class MUR : CurrencyOf
        {
            public MUR() : base(nameof(MUR), "480") { }
        }

        private class MVR : CurrencyOf
        {
            public MVR() : base(nameof(MVR), "462") { }
        }

        private class MWK : CurrencyOf
        {
            public MWK() : base(nameof(MWK), "454") { }
        }

        private class MXN : CurrencyOf
        {
            public MXN() : base(nameof(MXN), "484") { }
        }

        private class MXV : CurrencyOf
        {
            public MXV() : base(nameof(MXV), "979") { }
        }

        private class MYR : CurrencyOf
        {
            public MYR() : base(nameof(MYR), "458") { }
        }

        private class MZN : CurrencyOf
        {
            public MZN() : base(nameof(MZN), "943") { }
        }

        private class NAD : CurrencyOf
        {
            public NAD() : base(nameof(NAD), "516") { }
        }

        private class NGN : CurrencyOf
        {
            public NGN() : base(nameof(NGN), "566") { }
        }

        private class NIO : CurrencyOf
        {
            public NIO() : base(nameof(NIO), "558") { }
        }

        private class NOK : CurrencyOf
        {
            public NOK() : base(nameof(NOK), "578") { }
        }

        private class NPR : CurrencyOf
        {
            public NPR() : base(nameof(NPR), "524") { }
        }

        private class NZD : CurrencyOf
        {
            public NZD() : base(nameof(NZD), "554") { }
        }

        private class OMR : CurrencyOf
        {
            public OMR() : base(nameof(OMR), "512") { }
        }

        private class PAB : CurrencyOf
        {
            public PAB() : base(nameof(PAB), "590") { }
        }

        private class PEN : CurrencyOf
        {
            public PEN() : base(nameof(PEN), "604") { }
        }

        private class PGK : CurrencyOf
        {
            public PGK() : base(nameof(PGK), "598") { }
        }

        private class PHP : CurrencyOf
        {
            public PHP() : base(nameof(PHP), "608") { }
        }

        private class PKR : CurrencyOf
        {
            public PKR() : base(nameof(PKR), "586") { }
        }

        private class PLN : CurrencyOf
        {
            public PLN() : base(nameof(PLN), "985") { }
        }

        private class PYG : CurrencyOf
        {
            public PYG() : base(nameof(PYG), "600") { }
        }

        private class QAR : CurrencyOf
        {
            public QAR() : base(nameof(QAR), "634") { }
        }

        private class RON : CurrencyOf
        {
            public RON() : base(nameof(RON), "946") { }
        }

        private class RSD : CurrencyOf
        {
            public RSD() : base(nameof(RSD), "941") { }
        }

        private class RUB : CurrencyOf
        {
            public RUB() : base(nameof(RUB), "643") { }
        }

        private class RWF : CurrencyOf
        {
            public RWF() : base(nameof(RWF), "646") { }
        }

        private class SAR : CurrencyOf
        {
            public SAR() : base(nameof(SAR), "682") { }
        }

        private class SBD : CurrencyOf
        {
            public SBD() : base(nameof(SBD), "090") { }
        }

        private class SCR : CurrencyOf
        {
            public SCR() : base(nameof(SCR), "690") { }
        }

        private class SDG : CurrencyOf
        {
            public SDG() : base(nameof(SDG), "938") { }
        }

        private class SEK : CurrencyOf
        {
            public SEK() : base(nameof(SEK), "752") { }
        }

        private class SGD : CurrencyOf
        {
            public SGD() : base(nameof(SGD), "702") { }
        }

        private class SHP : CurrencyOf
        {
            public SHP() : base(nameof(SHP), "654") { }
        }

        private class SLL : CurrencyOf
        {
            public SLL() : base(nameof(SLL), "694") { }
        }

        private class SOS : CurrencyOf
        {
            public SOS() : base(nameof(SOS), "706") { }
        }

        private class SRD : CurrencyOf
        {
            public SRD() : base(nameof(SRD), "968") { }
        }

        private class SSP : CurrencyOf
        {
            public SSP() : base(nameof(SSP), "728") { }
        }

        private class STD : CurrencyOf
        {
            public STD() : base(nameof(STD), "678") { }
        }

        private class SVC : CurrencyOf
        {
            public SVC() : base(nameof(SVC), "222") { }
        }

        private class SYP : CurrencyOf
        {
            public SYP() : base(nameof(SYP), "760") { }
        }

        private class SZL : CurrencyOf
        {
            public SZL() : base(nameof(SZL), "748") { }
        }

        private class THB : CurrencyOf
        {
            public THB() : base(nameof(THB), "764") { }
        }

        private class TJS : CurrencyOf
        {
            public TJS() : base(nameof(TJS), "972") { }
        }

        private class TMT : CurrencyOf
        {
            public TMT() : base(nameof(TMT), "934") { }
        }

        private class TND : CurrencyOf
        {
            public TND() : base(nameof(TND), "788") { }
        }

        private class TOP : CurrencyOf
        {
            public TOP() : base(nameof(TOP), "776") { }
        }

        private class TRY : CurrencyOf
        {
            public TRY() : base(nameof(TRY), "949") { }
        }

        private class TTD : CurrencyOf
        {
            public TTD() : base(nameof(TTD), "780") { }
        }

        private class TWD : CurrencyOf
        {
            public TWD() : base(nameof(TWD), "901") { }
        }

        private class TZS : CurrencyOf
        {
            public TZS() : base(nameof(TZS), "834") { }
        }

        private class UAH : CurrencyOf
        {
            public UAH() : base(nameof(UAH), "980") { }
        }

        private class UGX : CurrencyOf
        {
            public UGX() : base(nameof(UGX), "800") { }
        }

        private class USD : CurrencyOf
        {
            public USD() : base(nameof(USD), "840") { }
        }

        private class USN : CurrencyOf
        {
            public USN() : base(nameof(USN), "997") { }
        }

        private class UYI : CurrencyOf
        {
            public UYI() : base(nameof(UYI), "940") { }
        }

        private class UYU : CurrencyOf
        {
            public UYU() : base(nameof(UYU), "858") { }
        }

        private class UZS : CurrencyOf
        {
            public UZS() : base(nameof(UZS), "860") { }
        }

        private class VEF : CurrencyOf
        {
            public VEF() : base(nameof(VEF), "937") { }
        }

        private class VND : CurrencyOf
        {
            public VND() : base(nameof(VND), "704") { }
        }

        private class VUV : CurrencyOf
        {
            public VUV() : base(nameof(VUV), "548") { }
        }

        private class WST : CurrencyOf
        {
            public WST() : base(nameof(WST), "882") { }
        }

        private class XAF : CurrencyOf
        {
            public XAF() : base(nameof(XAF), "950") { }
        }

        private class XAG : CurrencyOf
        {
            public XAG() : base(nameof(XAG), "961") { }
        }

        private class XAU : CurrencyOf
        {
            public XAU() : base(nameof(XAU), "959") { }
        }

        private class XBA : CurrencyOf
        {
            public XBA() : base(nameof(XBA), "955") { }
        }

        private class XBB : CurrencyOf
        {
            public XBB() : base(nameof(XBB), "956") { }
        }

        private class XBC : CurrencyOf
        {
            public XBC() : base(nameof(XBC), "957") { }
        }

        private class XBD : CurrencyOf
        {
            public XBD() : base(nameof(XBD), "958") { }
        }

        private class XCD : CurrencyOf
        {
            public XCD() : base(nameof(XCD), "951") { }
        }

        private class XDR : CurrencyOf
        {
            public XDR() : base(nameof(XDR), "960") { }
        }

        private class XOF : CurrencyOf
        {
            public XOF() : base(nameof(XOF), "952") { }
        }

        private class XPD : CurrencyOf
        {
            public XPD() : base(nameof(XPD), "964") { }
        }

        private class XPF : CurrencyOf
        {
            public XPF() : base(nameof(XPF), "953") { }
        }

        private class XPT : CurrencyOf
        {
            public XPT() : base(nameof(XPT), "962") { }
        }

        private class XSU : CurrencyOf
        {
            public XSU() : base(nameof(XSU), "994") { }
        }

        private class XTS : CurrencyOf
        {
            public XTS() : base(nameof(XTS), "963") { }
        }

        private class XUA : CurrencyOf
        {
            public XUA() : base(nameof(XUA), "965") { }
        }

        private class XXX : CurrencyOf
        {
            public XXX() : base(nameof(XXX), "999") { }
        }

        private class YER : CurrencyOf
        {
            public YER() : base(nameof(YER), "886") { }
        }

        private class ZAR : CurrencyOf
        {
            public ZAR() : base(nameof(ZAR), "710") { }
        }

        private class ZMW : CurrencyOf
        {
            public ZMW() : base(nameof(ZMW), "967") { }
        }

        private class ZWL : CurrencyOf
        {
            public ZWL() : base(nameof(ZWL), "932") { }
        }

    }

}