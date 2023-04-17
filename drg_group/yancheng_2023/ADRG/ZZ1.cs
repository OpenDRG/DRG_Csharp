namespace drg_group.yancheng_2023{
    public class ZZ1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && (record.ssList==null || record.ssList.Length==0 || !Base.SS_VALID.Contains(record.ssList[0]))){
                Base.groupMessages.putMessage(record.Index,"符合ZZ1入组条件，匹配规则：无手术");
                    
                if (MDCZ_DRG.ZZ11_group(record))
                {
                    return "ZZ11";
                }
    
                if (MDCZ_DRG.ZZ15_group(record))
                {
                    return "ZZ15";
                }

                return "ZZ1";
            }else{
                return "";
            }
        }
    }
}