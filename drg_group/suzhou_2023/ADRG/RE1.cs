namespace drg_group.suzhou_2023{
    public class RE1 
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"Z51.101","Z51.102","Z51.103","Z51.104"};
            String[] adrg_ss={"03.8x01","54.9701","54.9702","54.9703","99.2500x036","99.2500x037","99.2500x038","99.2500x039","99.2502","99.2503","99.2504","99.2505","99.2506","99.2800x006","99.2801"};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0]) && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合RE1入组条件，匹配规则：主诊断匹配、主手术匹配");
                    
                if (MDCR_DRG.RE11_group(record))
                {
                    return "RE11";
                }
    
                if (MDCR_DRG.RE1B_group(record))
                {
                    return "RE1B";
                }

                return "RE1";
            }else{
                return "";
            }
        }
    }
}