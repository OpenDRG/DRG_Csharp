namespace drg_group.linfen_2022{
    public class FL1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"I48.000","I48.100","I48.100x002","I48.100x003","I48.200","I48.300","I48.301","I48.400","I48.401","I48.900x003","I48.900x004","I48.900x015"};
            String[] adrg_zd1={};
            String[] adrg_ss={"37.3402","37.3403","37.3404","37.3405","37.3406"};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0]) && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合FL1入组条件，匹配规则：主诊断匹配、主手术匹配");
                    
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