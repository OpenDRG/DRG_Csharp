namespace drg_group.wuhan_2022{
    public class YC1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true){
                Base.groupMessages.putMessage(record.Index,"符合YC1入组条件，匹配规则：");
                    
                if (MDCY_DRG.YC11_group(record))
                {
                    return "YC11";
                }
    
                if (MDCY_DRG.YC13_group(record))
                {
                    return "YC13";
                }
    
                if (MDCY_DRG.YC15_group(record))
                {
                    return "YC15";
                }

                return "YC1";
            }else{
                return "";
            }
        }
    }
}