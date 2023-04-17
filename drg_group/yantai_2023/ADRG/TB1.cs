namespace drg_group.yantai_2023{
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
                    
                if (MDCT_DRG.TB19_group(record))
                {
                    return "TB19";
                }

                return "TB1";
            }else{
                return "";
            }
        }
    }
}