namespace drg_group.suzhou_2023{
    public class XJ1 
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && Base.SS_VALID.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合XJ1入组条件，匹配规则：存在手术");
                    
                if (MDCX_DRG.XJ11_group(record))
                {
                    return "XJ11";
                }
    
                if (MDCX_DRG.XJ13_group(record))
                {
                    return "XJ13";
                }
    
                if (MDCX_DRG.XJ15_group(record))
                {
                    return "XJ15";
                }

                return "XJ1";
            }else{
                return "";
            }
        }
    }
}