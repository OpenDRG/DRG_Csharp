namespace drg_group.qingdao_2023{
    public class AH1_1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"31.1x00x005","31.2100x001","31.2900x001","31.7400","31.7400x001","96.5500"};
            String[] adrg_ss1={"96.7201"};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && Base.intersect(record.ssList,adrg_ss) && Base.intersect(record.ssList,adrg_ss1)){
                Base.groupMessages.putMessage(record.Index,"符合AH1_1入组条件，匹配规则：双手术匹配");
                    
                if (MDCA_DRG.AH19_group(record))
                {
                    return "AH19";
                }

                return "AH1";
            }else{
                return "";
            }
        }
    }
}