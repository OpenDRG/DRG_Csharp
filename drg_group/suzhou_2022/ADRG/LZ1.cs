namespace drg_group.suzhou_2022{
    public class LZ1 
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"D17.700x016","I86.201","N18.100","N18.200","N25.004","N27.000","N27.100","N27.900","N28.001","N28.002","N28.003","N28.004","N28.005","N28.100","N28.101","N28.102","N28.803","N28.804","N28.805","N28.806","N28.807","N28.808","N28.809","N28.810","N28.811","N28.812","N28.813","N28.814","N28.815","N28.816","N28.818","N28.819","N28.820","N28.821","N28.822","N28.823","N28.824","N28.825","N28.826","N28.827","N28.828","N28.829","N28.830","N28.831","N28.832","N28.833","N28.835","N28.837","N28.900x010","N28.902","N30.100","N30.400","N30.800x004","N30.802","N30.803","N30.804","N30.805","N30.806","N30.807","N30.808","N30.809","N30.810","N30.900","N30.901","N30.902","N31.000x001","N31.100x001","N31.200x001","N31.200x002","N31.200x003","N31.200x006","N31.200x007","N31.201","N31.201","N31.202","N31.203","N31.800","N31.901","N32.100","N32.101","N32.102","N32.103","N32.104","N32.200","N32.201","N32.202","N32.203","N32.204","N32.300","N32.301","N32.400","N32.800x003","N32.800x008","N32.800x009","N32.800x012","N32.800x014","N32.800x019","N32.801","N32.802","N32.804","N32.805","N32.806","N32.807","N32.808","N32.809","N32.810","N32.811","N32.812","N32.813","N32.814","N32.815","N32.900x002","N32.901","N36.000","N36.000x007","N36.001","N36.002","N36.003","N36.004","N36.005","N36.100","N36.200","N36.201","N36.300","N36.301","N36.302","N36.802","N36.803","N36.805","N36.806","N36.807","N36.808","N36.809","N36.901","N39.800","N39.800x001","N39.900","N99.500","N99.800x006","N99.800x011","N99.808","Q27.305","Q42.200x201","Q51.701","Q60.000","Q60.100","Q60.200","Q60.300","Q60.400","Q60.400x001","Q60.500","Q60.501","Q60.600","Q61.000","Q61.100","Q61.200","Q61.300","Q61.800","Q61.801","Q61.900","Q61.901","Q62.000","Q62.200","Q62.201","Q62.202","Q62.300x101","Q62.300x301","Q62.300x901","Q62.301","Q62.400","Q62.400x001","Q62.400x002","Q62.500","Q62.600","Q62.601","Q62.602","Q62.700","Q62.700x001","Q62.700x101","Q62.700x201","Q62.800","Q63.000","Q63.001","Q63.002","Q63.101","Q63.102","Q63.103","Q63.200","Q63.201","Q63.203","Q63.301","Q63.302","Q63.800x101","Q63.800x902","Q63.801","Q63.900","Q64.000","Q64.100","Q64.100x091","Q64.200","Q64.200x001","Q64.200x021","Q64.301","Q64.302","Q64.303","Q64.304","Q64.400x301","Q64.400x902","Q64.401","Q64.402","Q64.403","Q64.501","Q64.502","Q64.600","Q64.700x201","Q64.700x601","Q64.700x701","Q64.700x801","Q64.700x901","Q64.700x902","Q64.700x904","Q64.701","Q64.702","Q64.703","Q64.704","Q64.705","Q64.706","Q64.707","Q64.708","Q64.800x001","Q64.900","S37.000","S37.000x012","S37.000x013","S37.000x015","S37.000x016","S37.000x022","S37.000x023","S37.000x031","S37.000x032","S37.001","S37.002","S37.003","S37.004","S37.010","S37.011","S37.100","S37.101","S37.111","S37.200","S37.200x011","S37.200x022","S37.200x023","S37.200x024","S37.200x081","S37.201","S37.211","S37.300","S37.300x004","S37.300x005","S37.300x011","S37.300x021","S37.300x031","S37.300x081","S37.300x082","S37.300x083","S37.301","S37.302","S37.303","S37.310","S37.813","S37.814","T19.000","T19.100","T19.800x001","T19.801","T19.900","T28.300","T28.800","T28.800x001","T81.800x011","T81.800x014","T83.000x001","T83.001","T83.002","T83.003","T83.004","T83.100","T83.100x001","T83.100x002","T83.100x003","T83.100x004","T83.101","T83.102","T83.103","T83.200","T83.800","T83.800x001","T83.801","T83.802","T83.804","T86.811","Z45.800x007","Z46.600x001","Z46.601","Z46.603","Z46.800x001","Z46.800x002","Z49.000","Z49.000x002","Z49.000x004","Z49.101","Z52.400"};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合LZ1入组条件，匹配规则：主诊断匹配");
                    
                if (MDCL_DRG.LZ1A_group(record))
                {
                    return "LZ1A";
                }
    
                if (MDCL_DRG.LZ15_group(record))
                {
                    return "LZ15";
                }

                return "LZ1";
            }else{
                return "";
            }
        }
    }
}