namespace drg_group.changzhou_2022{
    public class FK3
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"00.5100x001","00.5101","00.5102","00.5401","00.5402","37.9400x001","37.9400x002","37.9401","37.9402","37.9403","37.9404","37.9500x001","37.9500x002","37.9600x001","37.9600x002","37.9700x001","37.9700x002","37.9800x001","37.9800x002","37.9800x003","37.9800x004"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合FK3入组条件，匹配规则：主手术匹配");
                    
                if (MDCF_DRG.FK39_group(record))
                {
                    return "FK39";
                }

                return "FK3";
            }else{
                return "";
            }
        }
    }
}