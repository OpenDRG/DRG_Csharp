namespace drg_group.qingdao_2023{
    public class SB1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && Base.SS_VALID.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合SB1入组条件，匹配规则：存在手术");
                    
                if (MDCS_DRG.SB11_group(record))
                {
                    return "SB11";
                }
    
                if (MDCS_DRG.SB13_group(record))
                {
                    return "SB13";
                }
    
                if (MDCS_DRG.SB15_group(record))
                {
                    return "SB15";
                }

                return "SB1";
            }else{
                return "";
            }
        }
    }
}