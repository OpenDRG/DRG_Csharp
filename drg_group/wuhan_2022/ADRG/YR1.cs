namespace drg_group.wuhan_2022{
    public class YR1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true){
                Base.groupMessages.putMessage(record.Index,"符合YR1入组条件，匹配规则：");
                    
                if (MDCY_DRG.YR11_group(record))
                {
                    return "YR11";
                }
    
                if (MDCY_DRG.YR13_group(record))
                {
                    return "YR13";
                }
    
                if (MDCY_DRG.YR15_group(record))
                {
                    return "YR15";
                }

                return "YR1";
            }else{
                return "";
            }
        }
    }
}