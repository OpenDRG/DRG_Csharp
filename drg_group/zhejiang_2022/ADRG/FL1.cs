namespace drg_group.zhejiang_2022{
    public class FL1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"37.3401","37.3402","37.3403","37.3404","37.3405","37.3406","37.9200x002"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && Base.intersect(record.ssList,adrg_ss)){
                Base.groupMessages.putMessage(record.Index,"符合FL1入组条件，匹配规则：某一手术匹配");
                    
                if (MDCF_DRG.FL19_group(record))
                {
                    return "FL19";
                }

                return "FL1";
            }else{
                return "";
            }
        }
    }
}