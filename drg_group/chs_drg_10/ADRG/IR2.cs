namespace drg_group.chs_drg_10{
    public class IR2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"S72.000","S72.000x011","S72.000x021","S72.000x031","S72.000x041","S72.000x051","S72.000x081","S72.000x082","S72.010","S72.100x001","S72.100x002","S72.101","S72.110","S72.200x001","S72.210","S72.910"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合IR2入组条件，匹配规则：主诊断匹配");
                    
                if (MDCI_DRG.IR21_group(record))
                {
                    return "IR21";
                }
    
                if (MDCI_DRG.IR23_group(record))
                {
                    return "IR23";
                }
    
                if (MDCI_DRG.IR25_group(record))
                {
                    return "IR25";
                }

                return "IR2";
            }else{
                return "";
            }
        }
    }
}