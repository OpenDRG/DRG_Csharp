namespace drg_group.zhejiang_2022{
    public class SB1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true){
                Base.groupMessages.putMessage(record.Index,"符合SB1入组条件，匹配规则：");
                    
                if (MDCS_DRG.SB19_group(record))
                {
                    return "SB19";
                }

                return "SB1";
            }else{
                return "";
            }
        }
    }
}