namespace drg_group.fuzhou_2022{
    public class AD1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"52.8000","52.8200","52.8300"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合AD1入组条件，匹配规则：主手术匹配");
                
                return "AD1";
            }else{
                return "";
            }
        }
    }
}