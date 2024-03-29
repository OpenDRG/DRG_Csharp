namespace drg_group.chs_drg_10{
    public class HT1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"B25.200+K87.1*","B26.300+K87.1*","K85.000","K85.001","K85.002","K85.100","K85.101","K85.102","K85.200","K85.201","K85.202","K85.300","K85.301","K85.302","K85.800x001","K85.800x002","K85.800x003","K85.803","K85.807","K85.808","K85.809","K85.813","K85.814","K85.815","K85.816","K85.817","K85.818","K85.821","K85.822","K85.900","K85.900x002","K85.900x003","K85.901","K85.902"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合HT1入组条件，匹配规则：主诊断匹配");
                    
                if (MDCH_DRG.HT19_group(record))
                {
                    return "HT19";
                }

                return "HT1";
            }else{
                return "";
            }
        }
    }
}