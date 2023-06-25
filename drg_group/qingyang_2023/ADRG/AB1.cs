namespace drg_group.qingyang_2023{
    public class AB1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"50.5100","50.5100x001","50.5900x001","50.5900x004","50.5900x005","50.5901","50.5902"};
            String[] adrg_ss1={};
            String[] adrg_ss2={};
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合AB1入组条件，匹配规则：主手术匹配");
                
                    
                if (MDCA_DRG.AB19_group(record))
                {
                    return "AB19";
                }

                return "";
            }else{
                return "";
            }
        }
    }
}