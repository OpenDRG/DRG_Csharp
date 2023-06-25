namespace drg_group.qingyang_2023{
    public class GG1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"54.5100","54.5100x005","54.5100x009","54.5101","54.5102","54.5103","54.5900x007","54.5901","54.5902","54.5903","54.5904","54.5905","54.5906"};
            String[] adrg_ss1={};
            String[] adrg_ss2={};
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合GG1入组条件，匹配规则：主手术匹配");
                
                    
                if (MDCG_DRG.GG19_group(record))
                {
                    return "GG19";
                }

                return "";
            }else{
                return "";
            }
        }
    }
}