namespace drg_group.changsha_2023{
    public class FK1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"I11.001","I11.002","I13.000x001","I21.000x005","I21.001","I21.002","I21.003","I21.004","I21.103","I21.104","I21.105","I21.106","I21.200x003","I21.200x009","I21.200x010","I21.200x011","I21.200x014","I21.200x015","I21.200x016","I21.200x017","I21.200x018","I21.200x019","I21.200x020","I21.200x021","I21.200x022","I21.200x023","I21.200x024","I21.200x025","I21.200x026","I21.200x027","I21.200x029","I21.200x030","I21.204","I21.205","I21.206","I21.207","I21.208","I21.210","I21.211","I21.212","I21.213","I21.300x003","I21.300x004","I21.300x005","I21.300x008","I21.302","I21.303","I21.400x003","I21.401","I21.402","I21.900","I21.900x001","I21.901","I22.000x001","I22.000x002","I22.000x003","I22.000x004","I22.000x005","I22.100x001","I22.100x002","I22.100x003","I22.800x001","I22.800x002","I22.800x003","I22.800x004","I22.800x005","I22.800x006","I22.800x007","I22.800x008","I22.800x009","I22.800x010","I22.800x011","I22.800x012","I22.800x013","I22.800x014","I22.800x015","I22.800x016","I22.800x017","I22.800x018","I22.900x001","I23.000x001","I23.100x001","I23.200x001","I23.300x001","I23.400x001","I23.500x001","I23.601","I23.800x001","I50.000","I50.000x005","I50.000x006","I50.001","I50.002","I50.100","I50.100x006","I50.101","I50.102","I50.103","I50.104","I50.105","I50.900","I50.900x001","I50.900x002","I50.900x007","I50.900x008","I50.900x009","I50.900x010","I50.900x014","I50.900x015","I50.900x016","I50.900x017","I50.900x018","I50.900x019","I50.907","I50.908","I97.100x004","I97.101","I97.102","I97.803","R57.000","R57.100","R57.101","R57.200","R57.800x003","R57.801","R57.802","R57.803","R57.900","R57.900x002","R57.901","R68.800x001","T81.800x010"};
            String[] adrg_zd1={};
            String[] adrg_ss={"00.5000x001","00.5000x004","00.5000x005","00.5001","00.5002","00.5100x001","00.5101","00.5102","00.5301","00.5302","00.5401","00.5402"};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0]) && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合FK1入组条件，匹配规则：主诊断匹配、主手术匹配");
                    
                if (MDCF_DRG.FK19_group(record))
                {
                    return "FK19";
                }

                return "FK1";
            }else{
                return "";
            }
        }
    }
}