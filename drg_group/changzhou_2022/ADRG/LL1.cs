namespace drg_group.changzhou_2022{
    public class LL1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"39.9500x004","39.9500x005","39.9500x006","39.9500x007","39.9501","39.9600x002","39.9600x003","54.9800","54.9800x005","54.9800x006","54.9800x007","54.9800x008"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合LL1入组条件，匹配规则：主手术匹配");
                    
                if (MDCL_DRG.LL19_group(record))
                {
                    return "LL19";
                }

                return "LL1";
            }else{
                return "";
            }
        }
    }
}