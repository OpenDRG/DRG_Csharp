namespace drg_group.beijing_2022{
    public class WR1_2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={"T31.300","T31.400","T31.500","T31.600","T31.700","T31.800","T31.900","T32.300","T32.400","T32.500","T32.600","T32.700","T32.800","T32.900"};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && Base.intersect(record.zdList[1..],adrg_zd1)){
                Base.groupMessages.putMessage(record.Index,"符合WR1_2入组条件，匹配规则：其他诊断匹配");
                    
                if (MDCW_DRG.WR11_group(record))
                {
                    return "WR11";
                }
    
                if (MDCW_DRG.WR15_group(record))
                {
                    return "WR15";
                }

                return "WR1";
            }else{
                return "";
            }
        }
    }
}