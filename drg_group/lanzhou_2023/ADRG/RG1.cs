namespace drg_group.lanzhou_2023{
    public class RG1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"Z51.800x095","Z51.800x951","Z51.800x952","Z51.800x981","Z51.801","Z51.805","Z51.807","Z51.810"};
            String[] adrg_zd1={};
            String[] adrg_ss={"99.2800x004","99.2800x005","99.2800x006","99.2801"};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0]) && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合RG1入组条件，匹配规则：主诊断匹配、主手术匹配");
                    
                if (MDCR_DRG.RG1B_group(record))
                {
                    return "RG14";
                }
    
                if (MDCR_DRG.RG11_group(record))
                {
                    return "RG11";
                }

                return "RG1";
            }else{
                return "";
            }
        }
    }
}