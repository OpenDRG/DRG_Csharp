namespace drg_group.suzhou_2023{
    public class PS4 
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"P07.200","P07.200x011","P07.200x021","P07.300","P07.300x001","P07.300x011","P07.300x021"};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true  && Base.intersect(record.zdList,adrg_zd) && record.weight>0 && record.weight>=2500){
                Base.groupMessages.putMessage(record.Index,"符合PS4入组条件，匹配规则：某一诊断匹配、体重大于2500克");
                    
                if (MDCP_DRG.PS41_group(record))
                {
                    return "PS41";
                }
    
                if (MDCP_DRG.PS4B_group(record))
                {
                    return "PS4B";
                }

                return "PS4";
            }else{
                return "";
            }
        }
    }
}