namespace drg_group.qingyang_2023{
    public class FK2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"00.5000x001","00.5000x004","00.5000x005","00.5001","00.5002","00.5100x001","00.5101","00.5102","00.5301","00.5302","00.5401","00.5402"};
            String[] adrg_ss1={};
            String[] adrg_ss2={};
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合FK2入组条件，匹配规则：主手术匹配");
                
                    
                if (MDCF_DRG.FK29_group(record))
                {
                    return "FK29";
                }

                return "";
            }else{
                return "";
            }
        }
    }
}