namespace drg_group.changzhou_2022{
    public class FK2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"00.5000x004","00.5000x005","00.5201","00.5202","00.5302","37.7000","37.7100","37.7200","37.7300","37.7401","37.7402","37.7501","37.7600x002","37.7701","37.7800","37.7900x003","37.7900x004","37.7901","37.7902","37.8000x002","37.8501","37.8601","37.8701","37.8901","37.8902","37.8903","39.6400"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合FK2入组条件，匹配规则：主手术匹配");
                    
                if (MDCF_DRG.FK29_group(record))
                {
                    return "FK29";
                }

                return "FK2";
            }else{
                return "";
            }
        }
    }
}