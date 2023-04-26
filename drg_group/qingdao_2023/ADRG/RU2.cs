namespace drg_group.qingdao_2023{
    public class RU2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"Z51.800x095","Z51.800x951","Z51.800x952","Z51.802","Z51.805","Z51.808","Z51.810"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合RU2入组条件，匹配规则：主诊断匹配");
                
                return "RU2";
            }else{
                return "";
            }
        }
    }
}