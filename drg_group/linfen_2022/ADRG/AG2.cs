namespace drg_group.linfen_2022{
    public class AG2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"41.0100","41.0401","41.0701","41.0900"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合AG2入组条件，匹配规则：主手术匹配");
                    
                if (MDCA_DRG.AG29_group(record))
                {
                    return "AG29";
                }

                return "AG2";
            }else{
                return "";
            }
        }
    }
}