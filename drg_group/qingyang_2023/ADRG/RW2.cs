namespace drg_group.qingyang_2023{
    public class RW2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"Z51.000x013","Z51.100x004","Z51.500x003","Z51.800x953","Z51.800x983"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            String[] adrg_ss2={};
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合RW2入组条件，匹配规则：主诊断匹配");
                
                    
                if (MDCR_DRG.RW29_group(record))
                {
                    return "RW29";
                }

                return "";
            }else{
                return "";
            }
        }
    }
}