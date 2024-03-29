namespace drg_group.chs_drg_10{
    public class BX1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"F01.000","F01.100","F01.102","F01.200","F01.300","F01.800x001","F01.900","F01.901","F01.902","F03.x00","F03.x01","G10.x00","G10.x01+F02.2*","G93.804","M30.005+F02.8*","N18.502+F02.8*"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合BX1入组条件，匹配规则：主诊断匹配");
                    
                if (MDCB_DRG.BX19_group(record))
                {
                    return "BX19";
                }

                return "BX1";
            }else{
                return "";
            }
        }
    }
}