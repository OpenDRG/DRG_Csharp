namespace drg_group.qingdao_2023{
    public class FV4
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"R07.101","R07.200","R07.301","R07.400","Z03.400"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合FV4入组条件，匹配规则：主诊断匹配");
                
                return "FV4";
            }else{
                return "";
            }
        }
    }
}