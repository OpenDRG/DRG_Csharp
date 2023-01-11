namespace drg_group.suzhou_2022{
    public class IV1 
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"Q65.000","Q65.100","Q65.200","Q65.300","Q65.400","Q65.500","Q65.600","Q65.600x011","Q65.600x021","Q65.800x004","Q65.801","Q65.802","Q65.803","Q65.804","Q65.900","Q66.000","Q66.100","Q66.200","Q66.300","Q66.400","Q66.400","Q66.500","Q66.600","Q66.601","Q66.700","Q66.701","Q66.702","Q66.800x006","Q66.800x007","Q66.800x008","Q66.800x009","Q66.800x010","Q66.800x012","Q66.800x013","Q66.800x013","Q66.800x014","Q66.800x015","Q66.800x016","Q66.801","Q66.802","Q66.803","Q66.804","Q66.805","Q66.900","Q67.000","Q67.100","Q67.100x001","Q67.600","Q67.700","Q67.800x001","Q67.801","Q67.802","Q68.001","Q68.002","Q68.100","Q68.100x002","Q68.100x009","Q68.100x010","Q68.101","Q68.102","Q68.103","Q68.104","Q68.200","Q68.201","Q68.300","Q68.300x001","Q68.300x002","Q68.401","Q68.402","Q68.500","Q68.501","Q68.800x006","Q68.800x014","Q68.800x015","Q68.800x016","Q68.800x018","Q68.800x019","Q68.800x020","Q68.800x021","Q68.800x022","Q68.800x023","Q68.800x024","Q68.800x025","Q68.801","Q68.802","Q68.803","Q68.804","Q68.805","Q68.807","Q68.808","Q68.809","Q68.810","Q68.811","Q68.812","Q68.813","Q69.000","Q69.100","Q69.200","Q69.200x001","Q69.900x001","Q69.900x002","Q70.000","Q70.001","Q70.100","Q70.200","Q70.201","Q70.300","Q70.400x001","Q70.400x002","Q70.900x001","Q70.900x002","Q70.901","Q71.000","Q71.100","Q71.200x001","Q71.200x002","Q71.300x021","Q71.300x031","Q71.301","Q71.400","Q71.401","Q71.500","Q71.501","Q71.600","Q71.801","Q71.802","Q71.900","Q72.000","Q72.000x001","Q72.100","Q72.200","Q72.300x301","Q72.300x302","Q72.400","Q72.400x001","Q72.400x002","Q72.401","Q72.500","Q72.501","Q72.600","Q72.601","Q72.700","Q72.800","Q72.800x002","Q72.800x003","Q72.900","Q73.000","Q73.100","Q73.800","Q74.000x902","Q74.000x906","Q74.000x907","Q74.001","Q74.002","Q74.003","Q74.004","Q74.005","Q74.007","Q74.008","Q74.009","Q74.010","Q74.100x004","Q74.100x006","Q74.101","Q74.102","Q74.103","Q74.104","Q74.105","Q74.106","Q74.200x001","Q74.200x003","Q74.200x004","Q74.200x005","Q74.200x006","Q74.201","Q74.202","Q74.203","Q74.204","Q74.300","Q74.300x001","Q74.800x001","Q74.800x201","Q74.800x202","Q74.800x203","Q74.800x301","Q74.800x401","Q74.800x402","Q74.800x403","Q74.800x501","Q74.801","Q74.900","Q75.002","Q75.100","Q75.101","Q75.200","Q75.300","Q75.400x001","Q75.800x101","Q75.802","Q75.803","Q75.806","Q75.807","Q75.808","Q75.809","Q75.900","Q75.900x001","Q75.900x002","Q76.500","Q76.600x101","Q76.600x301","Q76.600x901","Q76.600x902","Q76.600x903","Q76.600x904","Q76.601","Q76.602","Q76.700","Q76.700x101","Q76.700x201","Q76.700x902","Q76.800","Q76.900","Q77.000","Q77.100","Q77.400","Q78.400x002","Q78.400x006","Q78.401","Q78.403","Q78.404","Q78.405","Q78.500","Q78.500x001","Q78.600","Q78.600x002","Q78.800","Q78.900","Q78.900x001","Q78.900x002","Q78.900x003","Q78.900x004","Q78.901","Q79.600","Q79.800x004","Q79.800x005","Q79.800x006","Q79.804","Q79.805","Q79.900","Q89.800x911","Q89.800x912"};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合IV1入组条件，匹配规则：主诊断匹配");
                    
                if (MDCI_DRG.IV19_group(record))
                {
                    return "IV19";
                }

                return "IV1";
            }else{
                return "";
            }
        }
    }
}