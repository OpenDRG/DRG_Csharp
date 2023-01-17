namespace drg_group.wuxi_2022{
    public class PK1 
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_ss={"93.9000x003","93.9001","96.7101"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0]) && record.ageDay<=28){
                Base.groupMessages.putMessage(record.Index,"符合PK1入组条件，匹配规则：主手术匹配、新生儿");
                
                return "PK1";
            }else{
                return "";
            }
        }
    }
}