namespace drg_group.suzhou_2023{
    public class DB2 
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_ss={"20.9501","20.9502","20.9601","20.9602","20.9701","20.9702","20.9801","20.9802"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合DB2入组条件，匹配规则：主手术匹配");
                    
                if (MDCD_DRG.DB29_group(record))
                {
                    return "DB29";
                }

                return "DB2";
            }else{
                return "";
            }
        }
    }
}