namespace drg_group.chs_drg_10{
    public class BC2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"02.2200x005","02.2206","02.2207","02.2208","02.2208","02.2210","02.2211","02.2212","02.2213","02.2214","02.2215","02.2216","02.3101","02.3102","02.3103","02.3200x001","02.3201","02.3202","02.3203","02.3204","02.3300x001","02.3301","02.3400x002","02.3401","02.3402","02.3403","02.3404","02.3405","02.3501","02.3502","02.3901","02.4101","02.4102","02.4201","02.4202","02.4203","02.4204","02.4301","04.0726","54.9502"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合BC2入组条件，匹配规则：主手术匹配");
                    
                if (MDCB_DRG.BC29_group(record))
                {
                    return "BC29";
                }

                return "BC2";
            }else{
                return "";
            }
        }
    }
}