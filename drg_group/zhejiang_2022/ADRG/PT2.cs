namespace drg_group.zhejiang_2022{
    public class PT2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && record.weight>0 && record.weight>=2500 && record.ageDay<=28){
                Base.groupMessages.putMessage(record.Index,"符合PT2入组条件，匹配规则：体重大于2500克、新生儿");
                    
                if (MDCP_DRG.PT21_group(record))
                {
                    return "PT21";
                }
    
                if (MDCP_DRG.PT23_group(record))
                {
                    return "PT23";
                }
    
                if (MDCP_DRG.PT25_group(record))
                {
                    return "PT25";
                }

                return "PT2";
            }else{
                return "";
            }
        }
    }
}