namespace drg_group.beijing_2022{
    public class AH1_1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={"Z93.000"};
            String[] adrg_ss={"96.7201"};
            String[] adrg_ss1={};
            
            if (true && Base.intersect(record.zdList[1..],adrg_zd1) && record.ssList!=null &&record.ssList.Length>0 && Base.intersect(record.ssList,adrg_ss)){
                Base.groupMessages.putMessage(record.Index,"符合AH1_1入组条件，匹配规则：其他诊断匹配、某一手术匹配");
                    
                if (MDCA_DRG.AH11_group(record))
                {
                    return "AH11";
                }
    
                if (MDCA_DRG.AH15_group(record))
                {
                    return "AH15";
                }

                return "AH1";
            }else{
                return "";
            }
        }
    }
}