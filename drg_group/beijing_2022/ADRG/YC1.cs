namespace drg_group.beijing_2022{
    public class YC1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && Base.SS_VALID.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合YC1入组条件，匹配规则：存在手术");
                    
                if (MDCY_DRG.YC19_group(record))
                {
                    return "YC19";
                }

                return "YC1";
            }else{
                return "";
            }
        }
    }
}