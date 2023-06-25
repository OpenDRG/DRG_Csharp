namespace drg_group.qingyang_2023{
    public class ST1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"R50.800x002","R50.801","R50.802","R50.803","R50.900","R50.900x002","R50.901"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            String[] adrg_ss2={};
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合ST1入组条件，匹配规则：主诊断匹配");
                
                    
                if (MDCS_DRG.ST11_group(record))
                {
                    return "ST11";
                }
    
                if (MDCS_DRG.ST13_group(record))
                {
                    return "ST13";
                }
    
                if (MDCS_DRG.ST15_group(record))
                {
                    return "ST15";
                }

                return "";
            }else{
                return "";
            }
        }
    }
}