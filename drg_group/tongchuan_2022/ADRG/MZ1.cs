namespace drg_group.tongchuan_2022{
    public class MZ1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"D17.600x001","D17.700x033","D17.700x034","D18.000x815","D18.000x818","D18.000x855","D18.108","D29.000","D29.001","D29.100","D29.200","D29.300","D29.400","D29.401","D29.700x004","D29.700x005","D29.701","D29.702","D29.703","D29.900","D48.127","E29.000","E29.000x002","E29.001","E29.002","E29.100","E29.100x002","E29.100x004","E29.101","E29.102","E29.103","E29.104","E29.105","E29.106","E29.800","E29.900","E89.501","I86.100","I86.101","I86.200","I87.120","I87.804","I89.000x022","I89.000x023","I89.000x024","I89.008","I89.800x010","N36.801","N40.x00","N40.x01","N42.000","N42.101","N42.102","N42.200","N42.300","N42.300","N42.301","N42.801","N42.802","N42.901","N43.000","N43.001","N43.201","N43.300","N43.301","N43.302","N43.400","N44.x00","N44.x01","N44.x02","N46.x00","N46.x00x007","N46.x01","N46.x02","N47.x00x001","N47.x01","N47.x02","N47.x03","N48.000","N48.000x003","N48.101","N48.300","N48.301","N48.400","N48.400x005","N48.400x006","N48.400x007","N48.400x008","N48.401","N48.402","N48.403","N48.500","N48.600","N48.800x005","N48.800x009","N48.801","N48.802","N48.803","N48.804","N48.805","N48.806","N48.807","N48.808","N48.809","N48.810","N48.811","N48.812","N48.813","N48.901","N49.900","N50.000","N50.100x001","N50.101","N50.102","N50.103","N50.800","N50.800x001","N50.800x002","N50.800x012","N50.800x014","N50.800x016","N50.800x023","N50.800x024","N50.800x025","N50.800x027","N50.800x028","N50.800x038","N50.800x041","N50.800x042","N50.801","N50.802","N50.803","N50.804","N50.805","N50.806","N50.807","N50.808","N50.809","N50.810","N50.811","N50.812","N50.813","N50.814","N50.815","N50.816","N50.817","N50.818","N50.819","N50.820","N50.821","N50.822","N50.823","N50.824","N50.825","N50.826","N50.827","N50.900x005","N50.900x006","N50.900x007","N50.900x008","N50.901","N50.902","N50.903","Q53.000","Q53.000x002","Q53.000x003","Q53.100","Q53.100x001","Q53.101","Q53.102","Q53.200","Q53.200x001","Q53.201","Q53.202","Q53.900","Q53.901","Q53.902","Q54.000","Q54.001","Q54.100","Q54.200","Q54.300","Q54.400","Q54.800","Q54.900","Q54.901","Q55.001","Q55.002","Q55.003","Q55.004","Q55.100x002","Q55.101","Q55.200x901","Q55.201","Q55.202","Q55.203","Q55.300","Q55.400x006","Q55.400x008","Q55.401","Q55.402","Q55.403","Q55.404","Q55.405","Q55.501","Q55.502","Q55.600x007","Q55.600x008","Q55.600x009","Q55.601","Q55.602","Q55.603","Q55.604","Q55.605","Q55.606","Q55.800","Q55.800x001","Q55.801","Q55.802","Q55.900","Q55.901","Q56.000","Q56.001","Q56.002","Q56.100","Q56.300","Q56.400","Q85.900x032","R86.000","R86.100","R86.200","R86.300","R86.400","R86.500","R86.600","R86.700","R86.800","R86.900x003","R86.901","R86.902","R86.903","R93.802","S30.202","S30.203","S30.205","S30.206","S30.208","S31.200","S31.300x001","S31.300x002","S31.301","S31.501","S37.801","S37.802","S37.804","S37.811","S37.910","S38.000","S38.001","S38.200x003","S38.200x004","S38.200x005","S39.900x007","S39.900x009","S39.900x010","S39.904","T19.800x002","T83.401","Z31.000x004","Z41.200"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合MZ1入组条件，匹配规则：主诊断匹配");
                    
                if (MDCM_DRG.MZ19_group(record))
                {
                    return "MZ19";
                }

                return "MZ1";
            }else{
                return "";
            }
        }
    }
}