namespace drg_group.linfen_2022{
    public class HL2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"51.1000","51.1100","51.1101","51.1104","51.1105","51.1500","52.1302","52.1303"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合HL2入组条件，匹配规则：主手术匹配");
                    
                if (MDCH_DRG.HL29_group(record))
                {
                    return "HL29";
                }

                return "HL2";
            }else{
                return "";
            }
        }
    }
}