namespace drg_group.zhejiang_2022{
    public class XJ1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true){
                Base.groupMessages.putMessage(record.Index,"符合XJ1入组条件，匹配规则：");
                    
                if (MDCX_DRG.XJ19_group(record))
                {
                    return "XJ19";
                }

                return "XJ1";
            }else{
                return "";
            }
        }
    }
}