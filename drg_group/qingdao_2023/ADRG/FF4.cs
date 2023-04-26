namespace drg_group.qingdao_2023{
    public class FF4
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"20.7100","20.7903","38.0700x001","38.0701","38.5701","38.7x00x010","38.8700x010","38.9900x002","38.9900x501","38.9900x701","38.9900x901","39.3201","44.4400x001","55.9902","99.1000x011"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合FF4入组条件，匹配规则：主手术匹配");
                
                return "FF4";
            }else{
                return "";
            }
        }
    }
}