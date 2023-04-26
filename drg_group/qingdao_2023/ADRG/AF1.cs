namespace drg_group.qingdao_2023{
    public class AF1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"33.5000","33.5100","33.5200","33.6x00"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合AF1入组条件，匹配规则：主手术匹配");
                    
                if (MDCA_DRG.AF19_group(record))
                {
                    return "AF19";
                }

                return "AF1";
            }else{
                return "";
            }
        }
    }
}