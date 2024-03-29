namespace drg_group.qingdao_2023{
    public class AH1_2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"39.6500"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && Base.intersect(record.ssList,adrg_ss)){
                Base.groupMessages.putMessage(record.Index,"符合AH1_2入组条件，匹配规则：某一手术匹配");
                    
                if (MDCA_DRG.AH19_group(record))
                {
                    return "AH19";
                }

                return "AH1";
            }else{
                return "";
            }
        }
    }
}