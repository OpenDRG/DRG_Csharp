namespace drg_group.changzhou_2022{
    public class FC3
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"36.1000x001","36.1000x002","36.1100","36.1200","36.1300","36.1400","36.1500","36.1600","36.1700x001","36.1900x001","36.1900x002","36.2x00"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合FC3入组条件，匹配规则：主手术匹配");
                    
                if (MDCF_DRG.FC39_group(record))
                {
                    return "FC39";
                }

                return "FC3";
            }else{
                return "";
            }
        }
    }
}