namespace drg_group.wuhan_2022{
    public class FL2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_ss={"37.3400x002","37.3401","37.3402","37.3403","37.3404","37.3405","37.3406"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合FL2入组条件，匹配规则：主手术匹配");
                    
                if (MDCF_DRG.FL2A_group(record))
                {
                    return "FL2A";
                }
    
                if (MDCF_DRG.FL25_group(record))
                {
                    return "FL25";
                }

                return "FL2";
            }else{
                return "";
            }
        }
    }
}