namespace drg_group.lanzhou_2023{
    public class NG1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"N96.x00x003","N97.000x001","N97.100x001","N97.100x003","N97.101","N97.200x001","N97.200x002","N97.300","N97.800x004","N97.801","N97.900","N97.901","N97.902","Z31.100","Z31.200","Z31.200x003","Z31.201","Z31.300x001","Z31.300x002"};
            String[] adrg_zd1={};
            String[] adrg_ss={"65.9900x008","69.9200x004","69.9200x006","69.9200x007","69.9200x008","69.9201","69.9202"};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0]) && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合NG1入组条件，匹配规则：主诊断匹配、主手术匹配");
                    
                if (MDCN_DRG.NG19_group(record))
                {
                    return "NG19";
                }

                return "NG1";
            }else{
                return "";
            }
        }
    }
}