namespace drg_group.zhejiang_2022{
    public class WJ1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true){
                Base.groupMessages.putMessage(record.Index,"符合WJ1入组条件，匹配规则：");
                    
                if (MDCW_DRG.WJ19_group(record))
                {
                    return "WJ19";
                }

                return "WJ1";
            }else{
                return "";
            }
        }
    }
}