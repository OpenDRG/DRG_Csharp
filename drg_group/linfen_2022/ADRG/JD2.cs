namespace drg_group.linfen_2022{
    public class JD2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"21.9900x002","21.9901","21.9902","86.2800x012"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合JD2入组条件，匹配规则：主手术匹配");
                    
                if (MDCJ_DRG.JD29_group(record))
                {
                    return "JD29";
                }

                return "JD2";
            }else{
                return "";
            }
        }
    }
}