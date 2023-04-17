namespace drg_group.changzhou_2022{
    public class OR1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"O75.700x001","O80.000","O80.100","O80.800","O80.900","O84.000"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合OR1入组条件，匹配规则：主诊断匹配");
                    
                if (MDCO_DRG.OR19_group(record))
                {
                    return "OR19";
                }

                return "OR1";
            }else{
                return "";
            }
        }
    }
}