namespace drg_group.qingyang_2023{
    public class RG1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"Z51.800x095","Z51.800x951","Z51.800x952","Z51.800x981","Z51.801","Z51.805","Z51.807","Z51.810"};
            String[] adrg_zd1={};
            String[] adrg_ss={"99.2800x004","99.2800x005","99.2800x006","99.2801"};
            String[] adrg_ss1={};
            String[] adrg_ss2={};
            if (true && adrg_zd.Contains(record.zdList[0]) && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合RG1入组条件，匹配规则：主诊断匹配、主手术匹配");
                
                    
                if (MDCR_DRG.RG19_group(record))
                {
                    return "RG19";
                }

                return "";
            }else{
                return "";
            }
        }
    }
}