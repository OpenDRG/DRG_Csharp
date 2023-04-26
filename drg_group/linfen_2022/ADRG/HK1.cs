namespace drg_group.linfen_2022{
    public class HK1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"43.4100x020","96.0601"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合HK1入组条件，匹配规则：主手术匹配");
                    
                if (MDCH_DRG.HK11_group(record))
                {
                    return "HK11";
                }
    
                if (MDCH_DRG.HK15_group(record))
                {
                    return "HK15";
                }

                return "HK1";
            }else{
                return "";
            }
        }
    }
}