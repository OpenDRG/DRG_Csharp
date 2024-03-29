namespace drg_group.changzhou_2022{
    public class FR1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"A48.300","I11.001","I11.002","I13.000x001","I50.000","I50.000x005","I50.000x006","I50.001","I50.002","I50.100","I50.100x006","I50.101","I50.102","I50.103","I50.104","I50.105","I50.900","I50.900x001","I50.900x002","I50.900x017","I50.900x018","I50.900x019","I50.907","I50.908","I97.100x004","I97.101","I97.102","I97.803","R57.000","R57.100","R57.101","R57.200","R57.800x003","R57.801","R57.802","R57.803","R57.900","R57.900x002","R57.901","R68.800x001","T81.800x010"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合FR1入组条件，匹配规则：主诊断匹配");
                    
                if (MDCF_DRG.FR11_group(record))
                {
                    return "FR11";
                }
    
                if (MDCF_DRG.FR13_group(record))
                {
                    return "FR13";
                }
    
                if (MDCF_DRG.FR15_group(record))
                {
                    return "FR15";
                }
    
                if (MDCF_DRG.FR17_group(record))
                {
                    return "FR17";
                }

                return "FR1";
            }else{
                return "";
            }
        }
    }
}