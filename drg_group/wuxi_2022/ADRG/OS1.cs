namespace drg_group.wuxi_2022{
    public class OS1 
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"O15.201","O71.200","O71.201","O72.201","O72.202","O72.300","O72.300x002","O72.300x003","O72.301","O73.000","O73.001","O73.002","O73.101","O73.102","O85.x00","O85.x00x006","O85.x01","O85.x03","O86.000","O86.001","O86.002","O86.100x002","O86.101","O86.102","O86.201","O86.300x001","O86.400x001","O86.401","O86.402","O86.800x001","O86.801","O86.802","O87.000","O87.100","O87.200","O87.300","O87.301","O87.801","O87.802","O87.900","O87.900x003","O87.901","O89.000x001","O89.000x002","O89.000x003","O89.000x004","O89.100x001","O89.100x002","O89.200","O89.300","O89.400","O89.500","O89.600","O89.800","O89.900","O90.000","O90.101","O90.102","O90.201","O90.202","O90.300","O90.400","O90.400x002","O90.500","O90.800x004","O90.800x005","O90.800x006","O90.800x007","O90.800x008","O90.800x009","O90.801","O90.802","O90.900","O91.000","O91.001","O91.101","O91.102","O91.200x005","O91.200x007","O91.200x008","O91.201","O92.000","O92.100","O92.100x001","O92.200","O92.300","O92.400","O92.500x001","O92.500x002","O92.600","O92.700","O92.700x002","O92.701","O98.000x031","O98.100x031","O98.200x031","O98.400x031","O98.800x032","O99.000x031","O99.100x032","O99.100x033","O99.200x014","O99.200x031","O99.300x031","O99.300x032","O99.400x032","O99.400x034","O99.401","O99.402","O99.600x016","O99.600x017","O99.600x031","Z39.000x001","Z39.000x011","Z39.000x021","Z39.000x031"};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合OS1入组条件，匹配规则：主诊断匹配");
                    
                if (MDCO_DRG.OS13_group(record))
                {
                    return "OS13";
                }
    
                if (MDCO_DRG.OS15_group(record))
                {
                    return "OS15";
                }

                return "OS1";
            }else{
                return "";
            }
        }
    }
}