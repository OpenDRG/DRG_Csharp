namespace drg_group.chs_drg_10{
    public class YR2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true){
                Base.groupMessages.putMessage(record.Index,"符合YR2入组条件，匹配规则：");
                    
                if (MDCY_DRG.YR29_group(record))
                {
                    return "YR29";
                }

                return "YR2";
            }else{
                return "";
            }
        }
    }
}