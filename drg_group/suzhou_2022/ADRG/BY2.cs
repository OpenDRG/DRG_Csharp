namespace drg_group.suzhou_2022{
    public class BY2 
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"E53.801+G32.0*","E88.904+G99.2*","G04.101","G37.301","G82.000","G82.000x011","G82.000x021","G82.000x031","G82.000x041","G82.000x051","G82.000x061","G82.100","G82.100x021","G82.100x031","G82.100x041","G82.100x051","G82.100x061","G82.101","G82.200","G82.200x021","G82.200x031","G82.200x041","G82.201","G82.202","G82.203","G82.204","G82.300","G82.300x021","G82.300x031","G82.300x041","G82.300x051","G82.300x061","G82.301","G82.400","G82.400x011","G82.400x031","G82.400x041","G82.400x051","G82.400x061","G82.401","G82.500","G82.500x031","G82.500x041","G82.501","G82.502","G82.503","G82.504","G83.000","G83.000x002","G83.000x003","G83.100","G83.100x002","G83.100x003","G83.200","G83.200x002","G83.200x003","G83.300","G83.300x002","G83.300x003","G83.800x001","G83.800x003","G83.801","G83.802","G83.900x001","G83.900x002","G83.900x003","G83.900x004","G83.900x005","G83.901","G95.000","G95.002+M49.4*","G95.003","G95.100","G95.100x003","G95.100x004","G95.100x007","G95.100x008","G95.100x013","G95.101","G95.102","G95.103","G95.104","G95.105","G95.106","G95.107","G95.108","G95.109","G95.200","G95.800","G95.800x003","G95.800x004","G95.800x005","G95.800x007","G95.800x010","G95.800x011","G95.800x012","G95.800x014","G95.800x015","G95.800x016","G95.800x017","G95.801","G95.802","G95.803","G95.804","G95.805","G95.806","G95.807","G95.900","G95.900x003","G95.900x004","G95.901","G96.800x006","I77.000x012","I77.000x013","I77.002","M51.001+G99.2*","M51.002+G99.2*","M51.003+G99.2*","M51.004+G99.2*","Q27.300x006","Q27.300x008","Q28.800x003","Q28.800x005","S14.001","S14.002","S14.100x011","S14.100x021","S14.100x022","S14.100x031","S14.100x032","S14.100x033","S14.100x701","S14.100x711","S14.100x721","S14.100x731","S14.100x741","S14.100x751","S14.100x761","S14.100x771","S14.100x781","S14.101","S14.200","S14.200x001","S24.000x002","S24.001","S24.100x011","S24.100x021","S24.100x022","S24.100x023","S24.100x024","S24.100x701","S24.100x711","S24.100x721","S24.100x731","S24.100x741","S24.100x751","S24.100x761","S24.100x771","S24.101","S34.000x002","S34.001","S34.100x001","S34.100x002","S34.100x003","S34.100x701","S34.100x711","S34.100x721","S34.100x731","S34.100x741","S34.100x751","S34.100x761","S34.200x001","S34.200x002","S34.300","S34.800x001","T06.000x001","T06.100x001","T09.300","T09.300x003","T09.300x004","T09.300x005","T09.300x006","T09.300x007","T09.301","T91.300","T91.300x002","T91.300x003","T91.300x004","T91.301"};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合BY2入组条件，匹配规则：主诊断匹配");
                    
                if (MDCB_DRG.BY21_group(record))
                {
                    return "BY21";
                }
    
                if (MDCB_DRG.BY23_group(record))
                {
                    return "BY23";
                }
    
                if (MDCB_DRG.BY25_group(record))
                {
                    return "BY25";
                }

                return "BY2";
            }else{
                return "";
            }
        }
    }
}