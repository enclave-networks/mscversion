using System;
using System.Collections.Generic;
using System.Linq;

namespace MscVersion
{
    public static class VcRuntime
    {
        public static IEnumerable<VcRuntimeVersion> GetInstalled(Func<VcRuntimeVersion, bool> predicate)
        {
            return KnownRuntimeVersions.Where(predicate);
        }

        public static List<VcRuntimeVersion> KnownRuntimeVersions => new List<VcRuntimeVersion>
        {
            // MSVC++ 8.0  _MSC_VER == 1400 (Visual Studio 2005)
            new VcRuntimeVersion(Guid.Parse("{A49F249F-0C91-497F-86DF-B2585E8E76B7}"), MscVer.Vs_2005, ArchType.x86),
            new VcRuntimeVersion(Guid.Parse("{6E8E85E8-CE4B-4FF5-91F7-04999C9FAE6A}"), MscVer.Vs_2005, ArchType.x64),
            new VcRuntimeVersion(Guid.Parse("{03ED71EA-F531-4927-AABD-1C31BCE8E187}"), MscVer.Vs_2005, ArchType.IA64),
            new VcRuntimeVersion(Guid.Parse("{C1C4F017-81CC-94C4-C8FB-1542C0981A2A}"), MscVer.Vs_2005, ArchType.x86, "6.0.2900.2180"),
            new VcRuntimeVersion(Guid.Parse("{1AF2A8DA-7E60-D0B4-29D7-E6453B3D0182}"), MscVer.Vs_2005, ArchType.x64, "6.0.2900.2180"),
            new VcRuntimeVersion(Guid.Parse("{7299052B-02A4-4627-81F2-1818DA5D550D}"), MscVer.Vs_2005, ArchType.x86, "SP1"),
            new VcRuntimeVersion(Guid.Parse("{071C9B48-7C32-4621-A0AC-3F809523288F}"), MscVer.Vs_2005, ArchType.x64, "SP1"),
            new VcRuntimeVersion(Guid.Parse("{0F8FB34E-675E-42ED-850B-29D98C2ECE08}"), MscVer.Vs_2005, ArchType.IA64, "SP1"),
            new VcRuntimeVersion(Guid.Parse("{837B34E3-7C30-493C-8F6A-2B0F04E2912C}"), MscVer.Vs_2005, ArchType.x86, "SP1_ATL_SEC_UPD"),
            new VcRuntimeVersion(Guid.Parse("{6CE5BAE9-D3CA-4B99-891A-1DC6C118A5FC}"), MscVer.Vs_2005, ArchType.x64, "SP1_ATL_SEC_UPD"),
            new VcRuntimeVersion(Guid.Parse("{85025851-A784-46D8-950D-05CB3CA43A13}"), MscVer.Vs_2005, ArchType.IA64, "SP1_ATL_SEC_UPD"),
            
            // MSVC++ 9.0  _MSC_VER == 1500 (Visual Studio 2008)
            new VcRuntimeVersion(Guid.Parse("{FF66E9F6-83E7-3A3E-AF14-8DE9A809A6A4}"), MscVer.Vs_2008, ArchType.x86),
            new VcRuntimeVersion(Guid.Parse("{350AA351-21FA-3270-8B7A-835434E766AD}"), MscVer.Vs_2008, ArchType.x64),
            new VcRuntimeVersion(Guid.Parse("{2B547B43-DB50-3139-9EBE-37D419E0F5FA}"), MscVer.Vs_2008, ArchType.IA64),
            new VcRuntimeVersion(Guid.Parse("{6E815EB9-6CCE-9A53-884E-7857C57002F0}"), MscVer.Vs_2008, ArchType.x86, "9.0.30729.5677"),
            new VcRuntimeVersion(Guid.Parse("{67D6ECF5-CD5F-BA73-2B8B-22BAC8DE1B4D}"), MscVer.Vs_2008, ArchType.x64, "9.0.30729.5677"),
            new VcRuntimeVersion(Guid.Parse("{9A25302D-30C0-39D9-BD6F-21E6EC160475}"), MscVer.Vs_2008, ArchType.x86, "SP1"),
            new VcRuntimeVersion(Guid.Parse("{8220EEFE-38CD-377E-8595-13398D740ACE}"), MscVer.Vs_2008, ArchType.x64, "SP1"),
            new VcRuntimeVersion(Guid.Parse("{5827ECE1-AEB0-328E-B813-6FC68622C1F9}"), MscVer.Vs_2008, ArchType.IA64, "SP1"),
            new VcRuntimeVersion(Guid.Parse("{1F1C2DFC-2D24-3E06-BCB8-725134ADF989}"), MscVer.Vs_2008, ArchType.x86, "SP1_ATL_SEC_UPD"),
            new VcRuntimeVersion(Guid.Parse("{4B6C7001-C7D6-3710-913E-5BC23FCE91E6}"), MscVer.Vs_2008, ArchType.x64, "SP1_ATL_SEC_UPD"),
            new VcRuntimeVersion(Guid.Parse("{977AD349-C2A8-39DD-9273-285C08987C7B}"), MscVer.Vs_2008, ArchType.IA64, "SP1_ATL_SEC_UPD"),
            new VcRuntimeVersion(Guid.Parse("{9BE518E6-ECC6-35A9-88E4-87755C07200F}"), MscVer.Vs_2008, ArchType.x86, "9.0.30729.6161 - SP1_MFC_SEC_UPD"),
            new VcRuntimeVersion(Guid.Parse("{5FCE6D76-F5DC-37AB-B2B8-22AB8CEDB1D4}"), MscVer.Vs_2008, ArchType.x64, "9.0.30729.6161 - SP1_MFC_SEC_UPD"),
            new VcRuntimeVersion(Guid.Parse("{515643D1-4E9E-342F-A75A-D1F16448DC04}"), MscVer.Vs_2008, ArchType.IA64, "9.0.30729.6161 - SP1_MFC_SEC_UPD"),
            
            // MSVC++ 10.0 _MSC_VER == 1600 (Visual Studio 2010)
            new VcRuntimeVersion(Guid.Parse("{196BB40D-1578-3D01-B289-BEFC77A11A1E}"), MscVer.Vs_2010, ArchType.x86),
            new VcRuntimeVersion(Guid.Parse("{DA5E371C-6333-3D8A-93A4-6FD5B20BCC6E}"), MscVer.Vs_2010, ArchType.x64),
            new VcRuntimeVersion(Guid.Parse("{C1A35166-4301-38E9-BA67-02823AD72A1B}"), MscVer.Vs_2010, ArchType.IA64),
            new VcRuntimeVersion(Guid.Parse("{F0C3E5D1-1ADE-321E-8167-68EF0DE699A5}"), MscVer.Vs_2010, ArchType.x86, "10.0.40219 - SP1"),
            new VcRuntimeVersion(Guid.Parse("{1D8E6291-B0D5-35EC-8441-6616F567A0F7}"), MscVer.Vs_2010, ArchType.x64, "10.0.40219 - SP1"),
            new VcRuntimeVersion(Guid.Parse("{88C73C1C-2DE5-3B01-AFB8-B46EF4AB41CD}"), MscVer.Vs_2010, ArchType.IA64, "10.0.40219 - SP1"),
            new VcRuntimeVersion(Guid.Parse("{1D5E3C0F-EDA1-E123-1876-86FED06E995A}"), MscVer.Vs_2010, ArchType.x86, "10.0.40219.325"),
            new VcRuntimeVersion(Guid.Parse("{1926E8D1-5D0B-CE53-4814-66615F760A7F}"), MscVer.Vs_2010, ArchType.x64, "10.0.40219.325"),
            
            // MSVC++ 11.0 _MSC_VER == 1700 (Visual Studio 2012)
            new VcRuntimeVersion(Guid.Parse("{33D1FD90-4274-48A1-9BC1-97E33D9C2D6F}"), MscVer.Vs_2012, ArchType.x86, "11.0.61030.0"),
            new VcRuntimeVersion(Guid.Parse("{CA67548A-5EBE-413A-B50C-4B9CEB6D66C6}"), MscVer.Vs_2012, ArchType.x64, "11.0.61030.0"),
            new VcRuntimeVersion(Guid.Parse("{BD95A8CD-1D9F-35AD-981A-3E7925026EBB}"), MscVer.Vs_2012, ArchType.x86, "11.0.61030.0 - Minimum runtime (Update 4)"),
            new VcRuntimeVersion(Guid.Parse("{CF2BEA3C-26EA-32F8-AA9B-331F7E34BA97}"), MscVer.Vs_2012, ArchType.x64, "11.0.61030.0 - Minimum runtime (Update 4)"),
            new VcRuntimeVersion(Guid.Parse("{B175520C-86A2-35A7-8619-86DC379688B9}"), MscVer.Vs_2012, ArchType.x86, "11.0.61030.0 - Additional runtime (Update 4)"),
            new VcRuntimeVersion(Guid.Parse("{37B8F9C7-03FB-3253-8781-2517C99D7C00}"), MscVer.Vs_2012, ArchType.x64, "11.0.61030.0 - Additional runtime (Update 4)"),

            // MSVC++ 12.0 _MSC_VER == 1800 (Visual Studio 2013)

            new VcRuntimeVersion(Guid.Parse("{F65DB027-AFF3-4070-886A-0D87064AABB1}"), MscVer.Vs_2013, ArchType.x86, "12.0.30501"),
            new VcRuntimeVersion(Guid.Parse("{050D4FC8-5D48-4B8F-8972-47C82C46020F}"), MscVer.Vs_2013, ArchType.x64, "12.0.30501"),
            new VcRuntimeVersion(Guid.Parse("{13A4EE12-23EA-3371-91EE-EFB36DDFFF3E}"), MscVer.Vs_2013, ArchType.x86, "12.0.30501 - Minimum runtime"),
            new VcRuntimeVersion(Guid.Parse("{A749D8E6-B613-3BE3-8F5F-045C84EBA29B}"), MscVer.Vs_2013, ArchType.x64, "12.0.30501 - Minimum runtime"),
            new VcRuntimeVersion(Guid.Parse("{F8CFEB22-A2E7-3971-9EDA-4B11EDEFC185}"), MscVer.Vs_2013, ArchType.x86, "12.0.30501 - Additional runtime"),
            new VcRuntimeVersion(Guid.Parse("{929FBD26-9020-399B-9A7A-751D61F0B942}"), MscVer.Vs_2013, ArchType.x64, "12.0.30501 - Additional runtime"),

            // MSVC++ 14.0 _MSC_VER == 1900 (Visual Studio 2015)
            new VcRuntimeVersion(Guid.Parse("{74D0E5DB-B326-4DAE-A6B2-445B9DE1836E}"), MscVer.Vs_2015, ArchType.x86, "14.0.23026"),
            new VcRuntimeVersion(Guid.Parse("{E46ECA4F-393B-40DF-9F49-076FAF788D83}"), MscVer.Vs_2015, ArchType.x64, "14.0.23026"),
            new VcRuntimeVersion(Guid.Parse("{A2563E55-3BEC-3828-8D67-E5E8B9E8B675}"), MscVer.Vs_2015, ArchType.x86, "14.0.23026 - Minimum runtime"),
            new VcRuntimeVersion(Guid.Parse("{0D3E9E15-DE7A-300B-96F1-B4AF12B96488}"), MscVer.Vs_2015, ArchType.x64, "14.0.23026 - Minimum runtime"),
            new VcRuntimeVersion(Guid.Parse("{BE960C1C-7BAD-3DE6-8B1A-2616FE532845}"), MscVer.Vs_2015, ArchType.x86, "14.0.23026 - Additional runtime"),
            new VcRuntimeVersion(Guid.Parse("{BC958BD2-5DAC-3862-BB1A-C1BE0790438D}"), MscVer.Vs_2015, ArchType.x64, "14.0.23026 - Additional runtime"),

            new VcRuntimeVersion(Guid.Parse("{2E085FD2-A3E4-4B39-8E10-6B8D35F55244}"), MscVer.Vs_2015, ArchType.x86, "14.0.23918.0"),
            new VcRuntimeVersion(Guid.Parse("{DAB68466-3A7D-41A8-A5CF-415E3FF8EF71}"), MscVer.Vs_2015, ArchType.x64, "14.0.23918.0"),

            new VcRuntimeVersion(Guid.Parse("{8FD71E98-EE44-3844-9DAD-9CB0BBBC603C}"), MscVer.Vs_2015, ArchType.x86, "14.0.24210"),
            new VcRuntimeVersion(Guid.Parse("{C0B2C673-ECAA-372D-94E5-E89440D087AD}"), MscVer.Vs_2015, ArchType.x64, "14.0.24210"),

            new VcRuntimeVersion(Guid.Parse("{BBF2AC74-720C-3CB3-8291-5E34039232FA}"), MscVer.Vs_2015, ArchType.x86, "14.0.24215 - Minimum runtime"),
            new VcRuntimeVersion(Guid.Parse("{50A2BC33-C9CD-3BF1-A8FF-53C10A0B183C}"), MscVer.Vs_2015, ArchType.x64, "14.0.24215 - Minimum runtime"),
            new VcRuntimeVersion(Guid.Parse("{C956892E-D1F3-3781-935C-8D9060E7CD7E}"), MscVer.Vs_2015, ArchType.x86, "14.0.24215 - Debug runtime"),
            new VcRuntimeVersion(Guid.Parse("{406CC721-9FAD-3610-B44E-3130F84358D8}"), MscVer.Vs_2015, ArchType.x64, "14.0.24215 - Debug runtime"),
            new VcRuntimeVersion(Guid.Parse("{69BCE4AC-9572-3271-A2FB-9423BDA36A43}"), MscVer.Vs_2015, ArchType.x86, "14.0.24215 - Additional runtime"),
            new VcRuntimeVersion(Guid.Parse("{EF1EC6A9-17DE-3DA9-B040-686A1E8A8B04}"), MscVer.Vs_2015, ArchType.x64, "14.0.24215 - Additional runtime"),

            new VcRuntimeVersion(Guid.Parse("{E2803110-78B3-4664-A479-3611A381656A}"), MscVer.Vs_2015, ArchType.x86, "14.0.24215.1"),
            new VcRuntimeVersion(Guid.Parse("{D992C12E-CAB2-426F-BDE3-FB8C53950B0D}"), MscVer.Vs_2015, ArchType.x64, "14.0.24215.1"),
            
            // MSVC++ 14.1 _MSC_VER >= 1910 (Visual Studio 2017)
            new VcRuntimeVersion(Guid.Parse("{7d9c81d7-a921-4503-8518-38fc0c94b692}"), MscVer.Vs_2017_15_0, ArchType.x86, "14.10.24629.0-rc1"),
            new VcRuntimeVersion(Guid.Parse("{c60f2e5a-912d-426c-a6b1-8a80bebab424}"), MscVer.Vs_2017_15_0, ArchType.x64, "14.10.24629.0-rc1"),
            new VcRuntimeVersion(Guid.Parse("{27B6EB53-CB9C-3461-B05D-EB5210EBA3D4}"), MscVer.Vs_2017_15_0, ArchType.x86, "14.10.24629 - Minimum runtime"),
            new VcRuntimeVersion(Guid.Parse("{C8086B63-C436-3F8B-8064-CE8F27815C5F}"), MscVer.Vs_2017_15_0, ArchType.x64, "14.10.24629 - Minimum runtime"),
            new VcRuntimeVersion(Guid.Parse("{44EC2AE5-F313-3E2A-8167-9923138ED5B4}"), MscVer.Vs_2017_15_0, ArchType.x86, "14.10.24629 - Additional runtime"),
            new VcRuntimeVersion(Guid.Parse("{ADC1B84A-D61D-3B2F-854A-8F872E51BB65}"), MscVer.Vs_2017_15_0, ArchType.x64, "14.10.24629 - Additional runtime"),

            new VcRuntimeVersion(Guid.Parse("{C64E9A20-DF31-4B11-ADA1-00909EB1B508}"), MscVer.Vs_2017_15_0, ArchType.x86, "14.10.24911-rc5"),
            new VcRuntimeVersion(Guid.Parse("{0A898FD4-A90B-46E2-8F20-46DDB3F24B6E}"), MscVer.Vs_2017_15_0, ArchType.x64, "14.10.24911-rc5"),
            new VcRuntimeVersion(Guid.Parse("{0C1C3F23-69C2-3D3D-9865-F8B6215289CD}"), MscVer.Vs_2017_15_0, ArchType.x86, "14.10.24911-rc5 - Minimum runtime"),
            new VcRuntimeVersion(Guid.Parse("{F0793C5B-0227-3294-91DE-0385602C6CBC}"), MscVer.Vs_2017_15_0, ArchType.x64, "14.10.24911-rc5 - Minimum runtime"),
            new VcRuntimeVersion(Guid.Parse("{568BE2F1-A2B2-3705-BF3E-8E6197382A46}"), MscVer.Vs_2017_15_0, ArchType.x86, "14.10.24911-rc5 - Additional runtime"),
            new VcRuntimeVersion(Guid.Parse("{E9A123F9-306E-3A29-88B9-5CD521D9109D}"), MscVer.Vs_2017_15_0, ArchType.x64, "14.10.24911-rc5 - Additional runtime"),

            new VcRuntimeVersion(Guid.Parse("{3E053C90-8E3B-4A1B-AB2E-AFB57D20F4B0}"), MscVer.Vs_2017_15_0, ArchType.x86, "14.10.24930-rc6"),
            new VcRuntimeVersion(Guid.Parse("{20B93B94-495D-4022-A84F-F598998991BF}"), MscVer.Vs_2017_15_0, ArchType.x64, "14.10.24930-rc6"),
            new VcRuntimeVersion(Guid.Parse("{984D10BE-0781-3A9D-80FB-03540E0C3B42}"), MscVer.Vs_2017_15_0, ArchType.x86, "14.10.24930-rc6 - Minimum runtime"),
            new VcRuntimeVersion(Guid.Parse("{9F50D497-02C0-3BBB-9103-BFE6204FA318}"), MscVer.Vs_2017_15_0, ArchType.x64, "14.10.24930-rc6 - Minimum runtime"),
            new VcRuntimeVersion(Guid.Parse("{9AAEB713-D24D-37A4-8FBC-7A24739D3156}"), MscVer.Vs_2017_15_0, ArchType.x86, "14.10.24930-rc6 - Additional runtime"),
            new VcRuntimeVersion(Guid.Parse("{A8755EE8-AD62-37FE-B106-243DC209CF52}"), MscVer.Vs_2017_15_0, ArchType.x64, "14.10.24930-rc6 - Additional runtime"),

            new VcRuntimeVersion(Guid.Parse("{C239CEA1-D49E-4E16-8E87-8C055765F7EC}"), MscVer.Vs_2017_15_0, ArchType.x86, "14.10.25008-rtm"),
            new VcRuntimeVersion(Guid.Parse("{F1E7E313-06DF-4C56-96A9-99FDFD149C51}"), MscVer.Vs_2017_15_0, ArchType.x64, "14.10.25008-rtm"),
            new VcRuntimeVersion(Guid.Parse("{C6CDA568-CD91-3CA0-9EDE-DAD98A13D6E1}"), MscVer.Vs_2017_15_0, ArchType.x86, "14.10.25008-rtm - Minimum runtime"),
            new VcRuntimeVersion(Guid.Parse("{8D50D8C6-1E3D-3BAB-B2B7-A5399EA1EBD1}"), MscVer.Vs_2017_15_0, ArchType.x64, "14.10.25008-rtm - Minimum runtime"),
            new VcRuntimeVersion(Guid.Parse("{2F8A908C-0CCD-3BDD-9212-DC6696525139}"), MscVer.Vs_2017_15_0, ArchType.x86, "14.10.25008-rtm - Debug runtime"),
            new VcRuntimeVersion(Guid.Parse("{B0763AF1-2B66-33B7-B6AF-78E123AEA826}"), MscVer.Vs_2017_15_0, ArchType.x64, "14.10.25008-rtm - Debug runtime"),
            new VcRuntimeVersion(Guid.Parse("{E6222D59-608C-3018-B86B-69BD241ACDE5}"), MscVer.Vs_2017_15_0, ArchType.x86, "14.10.25008-rtm - Additional runtime"),
            new VcRuntimeVersion(Guid.Parse("{C668F044-4825-330D-8F9F-3CBFC9F2AB89}"), MscVer.Vs_2017_15_0, ArchType.x64, "14.10.25008-rtm - Additional runtime"),

            new VcRuntimeVersion(Guid.Parse("{404c9c27-8377-4fd1-b607-7ca635db4e49}"), MscVer.Vs_2017_15_3, ArchType.x86, "14.11.25325"),
            new VcRuntimeVersion(Guid.Parse("{6c6356fe-cbfa-4944-9bed-a9e99f45cb7a}"), MscVer.Vs_2017_15_3, ArchType.x64, "14.11.25325"),
            new VcRuntimeVersion(Guid.Parse("{029DA848-1A80-34D3-BFC1-A6447BFC8E7F}"), MscVer.Vs_2017_15_3, ArchType.x86, "14.11.25325 - Minimum runtime"),
            new VcRuntimeVersion(Guid.Parse("{B0037450-526D-3448-A370-CACBD87769A0}"), MscVer.Vs_2017_15_3, ArchType.x64, "14.11.25325 - Minimum runtime"),
            new VcRuntimeVersion(Guid.Parse("{568CD07E-0824-3EEB-AEC1-8FD51F3C85CF}"), MscVer.Vs_2017_15_3, ArchType.x86, "14.11.25325 - Additional runtime"),
            new VcRuntimeVersion(Guid.Parse("{B13B3E11-1555-353F-A63A-8933EE104FBD}"), MscVer.Vs_2017_15_3, ArchType.x64, "14.11.25325 - Additional runtime"),

            new VcRuntimeVersion(Guid.Parse("{e2ee15e2-a480-4bc5-bfb7-e9803d1d9823}"), MscVer.Vs_2017_15_5, ArchType.x64, "14.12.25810"),
            new VcRuntimeVersion(Guid.Parse("{56e11d69-7cc9-40a5-a4f9-8f6190c4d84d}"), MscVer.Vs_2017_15_5, ArchType.x86, "14.12.25810"),
            new VcRuntimeVersion(Guid.Parse("{2CD849A7-86A1-34A6-B8F9-D72F5B21A9AE}"), MscVer.Vs_2017_15_5, ArchType.x64, "14.12.25810 - Additional Runtime"),
            new VcRuntimeVersion(Guid.Parse("{7FED75A1-600C-394B-8376-712E2A8861F2}"), MscVer.Vs_2017_15_5, ArchType.x86, "14.12.25810 - Additional Runtime"),
            new VcRuntimeVersion(Guid.Parse("{C99E2ADC-0347-336E-A603-F1992B09D582}"), MscVer.Vs_2017_15_5, ArchType.x64, "14.12.25810 - Minimum runtime"),
            new VcRuntimeVersion(Guid.Parse("{828952EB-5572-3666-8CA9-000B6CE79350}"), MscVer.Vs_2017_15_5, ArchType.x86, "14.12.25810 - Minimum runtime"),

            new VcRuntimeVersion(Guid.Parse("{7753EC39-3039-3629-98BE-447C5D869C09}"), MscVer.Vs_2017_15_7, ArchType.x86, "14.14.26429 - Minimum Runtime"),
            new VcRuntimeVersion(Guid.Parse("{03EBF679-E886-38AD-8E70-28658449F7F9}"), MscVer.Vs_2017_15_7, ArchType.x64, "14.14.26429 - Minimum Runtime"),
            new VcRuntimeVersion(Guid.Parse("{6F0267F3-7467-350D-A8C8-33B72E3658D8}"), MscVer.Vs_2017_15_7, ArchType.x86, "14.14.26429 - Additional Runtime"),
            new VcRuntimeVersion(Guid.Parse("{B12F584A-DE7A-3EE3-8EC4-8A64DBC0F2A7}"), MscVer.Vs_2017_15_7, ArchType.x64, "14.14.26429 - Additional Runtime")

            // todo 14.16.27012
        };
    }
}
