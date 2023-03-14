namespace drg_group.zhejiang_2022{
    public class AA1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"37.5100"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && Base.intersect(record.ssList,adrg_ss)){
                Base.groupMessages.putMessage(record.Index,"符合AA1入组条件，匹配规则：某一手术匹配");
                    
                if (MDCA_DRG.AA19_group(record))
                {
                    return "AA19";
                }

                return "AA1";
            }else{
                return "";
            }
        }
    }
}