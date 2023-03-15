namespace drg_group.changsha_2023{
    public class ND1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"65.0100x002","65.0100x002","65.0100x003","65.0101","65.0103","65.0105","65.0900x003","65.0900x003","65.0900x004","65.0900x005","65.0901","65.0903","65.0905","65.1200x001","65.1201","65.1300","65.2100","65.2200","65.2300","65.2400","65.2500x003","65.2500x005","65.2500x011","65.2501","65.2502","65.2503","65.2504","65.2505","65.2900x001","65.2900x007","65.2900x011","65.2900x022","65.2901","65.2902","65.2903","65.2904","65.2905","65.2906","65.3100","65.3900x001","65.3900x002","65.4100","65.4900x001","65.4901","65.5100","65.5100x001","65.5100x003","65.5200","65.5200x001","65.5300","65.5400","65.6100","65.6101","65.6200x001","65.6300","65.6301","65.6400","65.7100x001","65.7200x001","65.7300x001","65.7400","65.7500","65.7600","65.7900x008","65.7900x009","65.7900x010","65.7901","65.7902","65.7903","65.7904","65.7905","65.8101","65.8102","65.8900x001","65.8901","65.8902","65.9100","65.9101","65.9200","65.9300","65.9400","65.9500","65.9900x005","65.9900x006","65.9900x007","65.9901","65.9902","66.0100x003","66.0100x005","66.0100x008","66.0101","66.0102","66.0200","66.0202","66.1100","66.1101","66.2101","66.2102","66.2200x001","66.2201","66.2900x001","66.2900x003","66.2901","66.2902","66.2903","66.3100","66.3200x001","66.3200x002","66.3201","66.3900x001","66.3900x004","66.3901","66.3902","66.4x00","66.4x01","66.4x02","66.5100","66.5101","66.5102","66.5200","66.5201","66.6100x001","66.6100x002","66.6100x003","66.6100x006","66.6100x007","66.6100x008","66.6100x011","66.6100x012","66.6100x014","66.6101","66.6102","66.6103","66.6104","66.6300","66.6301","66.6900x001","66.6900x002","66.6901","66.6902","66.7100","66.7100x002","66.7200","66.7300","66.7301","66.7400","66.7401","66.7900x004","66.7900x008","66.7900x009","66.7900x010","66.7901","66.7902","66.7903","66.7904","66.7905","66.7906","66.8x01","66.8x02","66.8x03","66.9100x003","66.9100x004","66.9200x001","66.9201","66.9202","66.9203","66.9204","66.9205","66.9301","66.9302","66.9400","66.9500x001","66.9500x004","66.9501","66.9502","66.9600","66.9600x002","66.9600x003","66.9700","66.9900"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合ND1入组条件，匹配规则：主手术匹配");
                    
                if (MDCN_DRG.ND19_group(record))
                {
                    return "ND19";
                }

                return "ND1";
            }else{
                return "";
            }
        }
    }
}