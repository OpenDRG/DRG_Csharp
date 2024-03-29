namespace drg_group.linfen_2022{
    public class PR1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"P22.000","P22.000x001","P22.100x003","P22.101","P22.801","P22.900"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0]) && record.ageDay<=28){
                Base.groupMessages.putMessage(record.Index,"符合PR1入组条件，匹配规则：主诊断匹配、新生儿");
                    
                if (MDCP_DRG.PR19_group(record))
                {
                    return "PR19";
                }

                return "PR1";
            }else{
                return "";
            }
        }
    }
}