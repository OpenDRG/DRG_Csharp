namespace drg_group.wuxi_2022{
    public class PJ1 
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_ss={"21.0902","31.3x03","31.7900x004","31.7900x005","45.9301","45.9303","47.1900x001","49.9100","58.0x05","58.3103","58.3905","58.5x00","58.5x01","59.0201","59.0202"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0]) && record.ageDay<=28){
                Base.groupMessages.putMessage(record.Index,"符合PJ1入组条件，匹配规则：主手术匹配、新生儿");
                
                return "PJ1";
            }else{
                return "";
            }
        }
    }
}