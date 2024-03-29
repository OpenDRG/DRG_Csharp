namespace drg_group.changzhou_2022{
    public class HS3
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"B15.900","B15.901","B15.902","B15.903","B15.905","B16.100","B16.100x002","B16.100x003","B16.100x004","B16.101","B16.901","B16.902","B16.903","B16.904","B16.905","B17.100","B17.100x003","B17.100x006","B17.101","B17.200","B17.200x004","B17.202","B17.203","B17.900","B17.900x002","B17.900x002","B17.900x004","B17.902","B17.903","B17.904","B18.002","B18.003","B18.100","B18.100","B18.100","B18.100x007","B18.104","B18.105","B18.107","B18.200","B18.200","B18.200","B18.200x009","B18.201","B18.202","B18.203","B18.800x001","B18.800x002","B18.800x005","B18.801","B18.802","B18.900","B18.900","B18.900","B18.900x006","B18.901","B18.902","B19.900","B19.901"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合HS3入组条件，匹配规则：主诊断匹配");
                    
                if (MDCH_DRG.HS39_group(record))
                {
                    return "HS39";
                }

                return "HS3";
            }else{
                return "";
            }
        }
    }
}