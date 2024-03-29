namespace drg_group.chs_drg_10{
    public class JB2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"85.2100x003","85.2100x019","85.2100x020","85.2100x021","85.2100x022","85.2100x023","85.2101","85.2200","85.2300x001","85.2301","85.2400x006","85.3300x001","85.3400x002","85.3401","85.3600x001","85.3601","85.4100x001","85.4200x001","85.4200x003","85.9400","85.9500","85.9600"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合JB2入组条件，匹配规则：主手术匹配");
                    
                if (MDCJ_DRG.JB29_group(record))
                {
                    return "JB29";
                }

                return "JB2";
            }else{
                return "";
            }
        }
    }
}