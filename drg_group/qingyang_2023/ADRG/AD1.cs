namespace drg_group.qingyang_2023{
    public class AD1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"52.8000","52.8200","52.8300"};
            String[] adrg_ss1={};
            String[] adrg_ss2={};
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合AD1入组条件，匹配规则：主手术匹配");
                
                    
                if (MDCA_DRG.AD19_group(record))
                {
                    return "AD19";
                }

                return "";
            }else{
                return "";
            }
        }
    }
}