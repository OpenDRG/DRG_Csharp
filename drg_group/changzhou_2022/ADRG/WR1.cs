namespace drg_group.changzhou_2022{
    public class WR1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true){
                Base.groupMessages.putMessage(record.Index,"符合WR1入组条件，匹配规则：");
                    
                if (MDCW_DRG.WR13_group(record))
                {
                    return "WR13";
                }
    
                if (MDCW_DRG.WR15_group(record))
                {
                    return "WR15";
                }

                return "WR1";
            }else{
                return "";
            }
        }
    }
}