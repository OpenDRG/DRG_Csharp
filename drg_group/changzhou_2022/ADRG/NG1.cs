namespace drg_group.changzhou_2022{
    public class NG1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"Z31.100","Z31.200","Z31.200x003","Z31.201","Z31.300x001","Z31.300x002"};
            String[] adrg_zd1={};
            String[] adrg_ss={"65.9900x005","65.9900x006","65.9900x008","69.9200x004","69.9200x006","69.9200x007","69.9200x008","69.9201","69.9202","75.9900x004"};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0]) && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合NG1入组条件，匹配规则：主诊断匹配、主手术匹配");
                
                return "NG1";
            }else{
                return "";
            }
        }
    }
}