namespace drg_group.taizhou_2022{
    public class TB1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && Base.SS_VALID.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合TB1入组条件，匹配规则：存在手术");
                    
                if (MDCT_DRG.TB11_group(record))
                {
                    return "TB11";
                }
    
                if (MDCT_DRG.TB13_group(record))
                {
                    return "TB13";
                }
    
                if (MDCT_DRG.TB15_group(record))
                {
                    return "TB15";
                }

                return "TB1";
            }else{
                return "";
            }
        }
    }
}