namespace drg_group.changzhou_2022{
    public class PT2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"P07.200x011","P07.300x021"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && Base.intersect(record.zdList,adrg_zd) && record.weight>0 && record.weight>=2500 && record.ageDay<=28){
                Base.groupMessages.putMessage(record.Index,"符合PT2入组条件，匹配规则：某一诊断匹配、体重大于2500克、新生儿");
                    
                if (MDCP_DRG.PT29_group(record))
                {
                    return "PT29";
                }

                return "PT2";
            }else{
                return "";
            }
        }
    }
}