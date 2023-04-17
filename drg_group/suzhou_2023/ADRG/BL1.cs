namespace drg_group.suzhou_2023{
    public class BL1 
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_ss={"99.1005","99.1006","99.1008","99.1009"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合BL1入组条件，匹配规则：主手术匹配");
                    
                if (MDCB_DRG.BL19_group(record))
                {
                    return "BL19";
                }

                return "BL1";
            }else{
                return "";
            }
        }
    }
}