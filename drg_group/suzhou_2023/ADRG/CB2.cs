namespace drg_group.suzhou_2023{
    public class CB2 
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_ss={"12.1100x002","12.1101","12.1200x001","12.1201","12.1202","12.1203","12.1300","12.1400x001","12.1400x008","12.1401","12.1402","12.1403","12.1404","12.3100","12.3200x001","12.3300","12.3301","12.3500","12.3501","12.3502","12.3503","12.3504","12.3900x001","12.3900x004","12.3901","12.3902","12.4100x001","12.4100x002","12.4100x003","12.4100x004","12.4401","12.6301","12.9701","12.9702","12.9703"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合CB2入组条件，匹配规则：主手术匹配");
                    
                if (MDCC_DRG.CB29_group(record))
                {
                    return "CB29";
                }

                return "CB2";
            }else{
                return "";
            }
        }
    }
}