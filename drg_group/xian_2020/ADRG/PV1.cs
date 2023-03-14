namespace drg_group.xian_2020{
    public class PV1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true){
                Base.groupMessages.putMessage(record.Index,"符合PV1入组条件，匹配规则：");
                    
                if (MDCP_DRG.PV19_group(record))
                {
                    return "PV19";
                }

                return "PV1";
            }else{
                return "";
            }
        }
    }
}