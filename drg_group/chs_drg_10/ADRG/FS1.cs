namespace drg_group.chs_drg_10{
    public class FS1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"C38.000","C38.000x004","C38.001","C38.002","C38.800","C45.200","C49.300x006","C49.402","C49.900x001","C75.500x001","C75.501","C79.800x807","C79.800x819","C79.800x830","C79.800x863","C79.808","D15.100","D15.101","D15.102","D15.103","D15.104","D15.105","D15.106","D18.000x822","D18.000x835","D18.000x836","D18.000x837","D18.000x840","D18.000x841","D18.010","D18.109","D21.300x005","D21.400x004","D35.600x001","D35.601","D48.100x024","D48.711","D48.712"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合FS1入组条件，匹配规则：主诊断匹配");
                    
                if (MDCF_DRG.FS11_group(record))
                {
                    return "FS11";
                }
    
                if (MDCF_DRG.FS13_group(record))
                {
                    return "FS13";
                }
    
                if (MDCF_DRG.FS15_group(record))
                {
                    return "FS15";
                }

                return "FS1";
            }else{
                return "";
            }
        }
    }
}