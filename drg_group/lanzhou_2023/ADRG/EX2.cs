namespace drg_group.lanzhou_2023{
    public class EX2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"A36.201","A37.000","A37.100","A37.800x001","A37.900","A37.900x003","A37.900x004","A37.901+J17.0*","J20.000","J20.100","J20.200","J20.300","J20.400","J20.500","J20.600","J20.700","J20.800","J20.900","J20.901","J20.902","J21.000","J21.100","J21.801","J21.900","J21.900x002","J21.901","J39.803","J40.x00","J40.x00x002","J40.x01","J44.800x001","T17.501"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合EX2入组条件，匹配规则：主诊断匹配");
                    
                if (MDCE_DRG.EX2AA_group(record))
                {
                    return "EX22A";
                }
    
                if (MDCE_DRG.EX2AB_group(record))
                {
                    return "EX22B";
                }
    
                if (MDCE_DRG.EX25A_group(record))
                {
                    return "EX25A";
                }
    
                if (MDCE_DRG.EX25B_group(record))
                {
                    return "EX25B";
                }

                return "EX2";
            }else{
                return "";
            }
        }
    }
}