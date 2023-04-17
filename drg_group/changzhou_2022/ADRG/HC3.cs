namespace drg_group.changzhou_2022{
    public class HC3
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"51.2100","51.2200","51.2200x004","51.2201","51.2300","51.2301","51.2400","51.2401"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合HC3入组条件，匹配规则：主手术匹配");
                    
                if (MDCH_DRG.HC39_group(record))
                {
                    return "HC39";
                }

                return "HC3";
            }else{
                return "";
            }
        }
    }
}