namespace drg_group.changzhou_2022{
    public class AG1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"41.0200","41.0300","41.0500","41.0600","41.0800x001"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合AG1入组条件，匹配规则：主手术匹配");
                    
                if (MDCA_DRG.AG19_group(record))
                {
                    return "AG19";
                }

                return "AG1";
            }else{
                return "";
            }
        }
    }
}