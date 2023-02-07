namespace drg_group.beijing_2022{
    public class AH1_3
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"37.5200x001","39.6500"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && Base.intersect(record.ssList,adrg_ss)){
                Base.groupMessages.putMessage(record.Index,"符合AH1_3入组条件，匹配规则：某一手术匹配");
                    
                if (MDCA_DRG.AH11_group(record))
                {
                    return "AH11";
                }
    
                if (MDCA_DRG.AH15_group(record))
                {
                    return "AH15";
                }

                return "AH1";
            }else{
                return "";
            }
        }
    }
}