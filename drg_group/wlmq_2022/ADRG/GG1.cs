namespace drg_group.wlmq_2022{
    public class GG1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"54.5100","54.5100x005","54.5100x009","54.5101","54.5102","54.5103","54.5900x007","54.5901","54.5902","54.5903","54.5904","54.5905","54.5906"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合GG1入组条件，匹配规则：主手术匹配");
                    
                if (MDCG_DRG.GG13_group(record))
                {
                    return "GG13";
                }
    
                if (MDCG_DRG.GG15_group(record))
                {
                    return "GG15";
                }

                return "GG1";
            }else{
                return "";
            }
        }
    }
}