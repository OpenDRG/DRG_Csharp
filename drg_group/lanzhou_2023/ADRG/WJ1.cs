namespace drg_group.lanzhou_2023{
    public class WJ1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && Base.SS_VALID.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合WJ1入组条件，匹配规则：存在手术");
                    
                if (MDCW_DRG.WJ1B_group(record))
                {
                    return "WJ14";
                }
    
                if (MDCW_DRG.WJ11_group(record))
                {
                    return "WJ11";
                }

                return "WJ1";
            }else{
                return "";
            }
        }
    }
}