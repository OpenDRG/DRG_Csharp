namespace drg_group.changzhou_2022{
    public class OJ1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"38.7x01","38.7x02","38.7x03","38.7x04","54.1202","54.2100x005","54.6101","73.8x00x005","73.8x00x006","73.8x01","73.8x02","75.1x00","75.1x00x002","75.2x00x001","75.3100","75.3101","75.3200","75.3300x001","75.3300x002","75.3301","75.3302","75.3303","75.3600","75.3600x002","75.3700","75.9900x002","75.9900x004","75.9900x005","96.1800x001","97.7101","97.7102"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合OJ1入组条件，匹配规则：主手术匹配");
                    
                if (MDCO_DRG.OJ19_group(record))
                {
                    return "OJ19";
                }

                return "OJ1";
            }else{
                return "";
            }
        }
    }
}