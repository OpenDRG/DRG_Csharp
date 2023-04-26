namespace drg_group.qingdao_2023{
    public class AA1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"37.5100"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合AA1入组条件，匹配规则：主手术匹配");
                    
                if (MDCA_DRG.AA19_group(record))
                {
                    return "AA19";
                }

                return "AA1";
            }else{
                return "";
            }
        }
    }
}