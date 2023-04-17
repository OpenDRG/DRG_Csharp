namespace drg_group.suzhou_2023{
    public class AH1 
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_ss={"37.5200x001","39.6500","96.7201"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合AH1入组条件，匹配规则：主手术匹配");
                    
                if (MDCA_DRG.AH19_group(record))
                {
                    return "AH19";
                }

                return "AH1";
            }else{
                return "";
            }
        }
    }
}