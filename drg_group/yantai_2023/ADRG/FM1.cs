namespace drg_group.yantai_2023{
    public class FM1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"36.0601","36.0602","36.0700x004","36.0701","36.0700"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合FM1入组条件，匹配规则：主手术匹配");
                    
                if (MDCF_DRG.FM19_group(record))
                {
                    return "FM19";
                }

                return "FM1";
            }else{
                return "";
            }
        }
    }
}