namespace drg_group.tongchuan_2022{
    public class SZ1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"A01.000x008","A01.000x009","A01.000x010","A01.000x011","A01.000x012","A01.000x014","A02.000","A02.000x005","A02.000x006","A02.000x007","A02.000x009","A02.000x010","A02.001","A02.002","A02.003","A02.004","A02.900x003","A06.000","A06.000x001","A06.001","A06.002","A06.100","A06.100x002","A06.200","A06.200x001","A06.300","A06.300x001","A06.700","A06.800x001","A06.800x002","A06.800x003","A06.900","A18.100x021+N37.8*","A18.100x022+N37.8*","A18.100x025+N29.1*","A18.100x031","A18.101","A18.103+N29.1*","A18.104+N29.1*","A18.105+N29.1*","A18.106+N29.1*","A18.107+N29.1*","A18.108+N33.0*","A18.200x006","A18.200x010","A18.206","A18.207","A18.208","A18.209","A18.210","A18.211","A18.212","A18.700+E35.1*","A18.700x002+E35.1*","A18.801+E35.8*","A18.806+E35.0*","A18.813+D77*","A20.100","A20.101","A20.200","A20.300","A20.800x004","A20.800x005","A21.100","A21.300","A21.300x002","A21.301","A22.000","A22.200","A22.200x001","A23.900x003","A23.900x006","A23.903+N16.0*","A24.100x003","A26.000","A27.900x004","A27.900x005","A27.900x006","A28.100","A30.100x003","A30.900x005","A30.900x008","A31.000","A31.000x001","A31.000x004","A31.000x005","A31.001","A31.002","A31.100","A31.100x002","A31.101","A31.102","A31.800x007","A31.802","A32.000","A32.803","A36.800x005+N33.8*","A36.804+N16.0*","A42.000","A42.100","A42.200","A42.200x002","A42.800x002","A42.801","A42.802","A42.803","A42.804","A42.805","A43.100","A43.801","A43.802","A44.000","A44.100","A48.000","A48.100","A48.100x001","A48.100x003","A48.200","A48.300","A48.801","A50.000","A50.100","A50.200","A50.400","A50.400x001","A50.401","A50.500","A50.500x001","A50.600","A50.700","A50.900","A51.000","A51.000x002","A51.001","A51.002","A51.100x001","A51.200","A51.201","A51.300x002","A51.300x003","A51.300x004","A51.300x005","A51.301","A51.302","A51.303","A51.304","A51.400x001","A51.400x010","A51.500","A51.900","A52.100","A52.100x011","A52.101","A52.200","A52.300","A52.700x001","A52.700x012+N08.0*","A52.709+N08.0*","A52.800","A52.801","A52.900","A53.000x001","A53.000x002","A53.900","A54.001","A54.002","A54.100x002","A54.500","A54.600x001","A54.601","A54.602","A54.809","A54.900","A54.900x001","A54.900x002","A55.x00","A56.000x003","A56.001","A56.200","A56.300x001","A56.301","A56.302","A56.400","A56.800","A57.x00x002","A57.x00x003","A58.x00","A58.x01","A59.000","A59.001+N37.0*","A59.800x001","A59.900","A60.001","A60.002","A60.900","A63.000","A63.001","A63.002","A63.003","A63.800","A64.x00","A65.x00","A66.000","A66.100","A66.200","A66.300","A66.400","A66.600","A66.700","A66.800","A66.900","A67.000","A67.100","A67.200","A67.300","A67.900","A68.000","A68.100","A68.900","A69.200","A69.800","A69.900","A70.x00","A74.900","A75.000x002","A75.000x003","A75.000x004","A75.001","A75.100","A75.200x001","A75.300x001","A75.900","A77.000","A77.000x001","A77.100","A77.100x001","A77.200","A77.200x001","A77.300","A77.300x001","A77.800","A77.900","A77.900x001","A78.x00","A79.000","A79.100","A79.800x002","A79.801","A79.900","A79.901","A92.300x002","A92.300x003","A92.300x004","A92.500","A93.801","B00.001","B00.202","B00.204","B00.205","B01.800x002+N08.0*","B01.800x004","B01.801","B02.900x001","B03.x00","B05.400","B05.800x009","B05.801","B05.802","B05.803","B07.x00x009","B08.100","B08.200","B08.200x002","B08.300","B08.800x004","B18.103+N08.0*","B18.205+N08.0*","B18.904+N08.0*","B26.800x004","B26.800x008+N08.0*","B26.800x010","B26.800x011","B26.804","B26.805+N08.0*","B26.900x001","B33.000","B33.000x001","B36.800","B36.801","B37.400x001+N37.0*","B37.401+N37.0*","B37.800x085","B37.800x088","B37.801","B37.802","B37.808","B37.900","B37.901","B38.700","B38.800","B38.900","B39.300","B39.400","B39.400x001","B39.500","B39.500x001","B39.900","B40.700","B40.800","B40.900","B41.700","B41.800x001","B41.800x003","B41.900","B42.100","B42.100x001","B42.100x002","B42.100x003","B42.700","B42.800","B42.900","B43.100","B43.800","B43.801","B43.900","B44.100x003","B44.700","B44.800x003","B44.800x005","B44.801","B44.802","B44.900x001","B45.100","B45.700","B45.800x002","B45.801","B45.900","B46.100x001+G99.8*","B46.400","B46.500","B46.800x001","B46.800x002","B46.900x002","B47.000","B47.100","B47.100x001","B47.900","B48.000","B48.000x001","B48.200","B48.201","B48.300","B48.300x001","B48.400","B48.401","B48.402","B48.700","B48.800x001","B49.x00x007","B49.x00x013","B49.x00x021","B49.x02+E35.8*","B49.x11","B49.x18","B50.000","B50.800","B50.801","B50.900x001","B51.000","B51.000x001+D77*","B51.800","B51.900","B52.000","B52.000x002+N08.0*","B52.001+N08.0*","B52.800","B52.900x001","B53.000x001","B53.100","B53.800x001","B54.x00x004","B54.x00x006","B54.x00x008","B55.000","B55.000x001","B55.000x003","B55.100","B55.100x001","B55.200","B55.200x001","B55.900","B56.000x001","B56.100x001","B56.900x001","B57.100","B57.200x001","B57.200x003","B57.300","B57.500","B58.801+N16.0*","B58.900x001","B60.000","B60.000x001","B60.800x001","B64.x00","B65.000x001","B65.001","B65.100x001","B65.101","B65.200x001","B65.300","B65.800x001","B65.800x002","B65.800x003","B65.900x006","B65.900x007","B65.900x008","B65.905+N08.0*","B66.000","B66.000x001","B66.100","B66.101","B66.200","B66.300","B66.300x001","B66.400","B66.400x001","B66.500","B66.800x001","B66.800x002","B66.800x003","B66.800x004","B66.800x005","B66.800x006","B66.800x007","B66.900","B66.901","B66.902","B67.301","B67.302+E35.0*","B67.400x001","B67.401","B67.600x001","B67.600x002","B67.600x003","B67.601","B67.700x001","B67.901","B67.902","B67.903","B67.904","B67.905","B67.906","B67.907","B68.000","B68.100","B68.900x002","B68.900x003","B68.900x004","B68.901","B69.100","B69.800x003","B69.800x004","B69.800x005","B69.800x008","B69.801","B69.802","B69.803","B69.804","B69.805","B69.900x001","B70.000","B70.100","B71.000","B71.100","B71.800","B71.900","B73.x00","B74.000x001","B74.000x002","B74.000x003","B74.100x001","B74.100x002","B74.100x003","B74.200x001","B74.200x002","B74.200x003","B74.300","B74.400","B74.400x001","B74.400x002","B74.400x003","B74.800x001","B74.900","B74.900x003","B74.900x005","B74.901","B74.902","B75.x00","B76.000","B76.100","B76.800","B76.900","B76.900x003","B76.901","B76.902","B77.800x002","B77.800x004","B77.800x005","B77.803","B77.900","B78.000","B78.700","B78.901","B78.902+N08.0*","B79.x00","B80.x00","B81.000","B81.100","B81.200","B81.300","B81.400","B81.800x001","B81.800x002","B81.801","B81.802","B83.000","B83.000x001","B83.000x002","B83.100","B83.200x001","B83.200x003","B83.201","B83.300","B83.400","B83.800x001","B83.800x002","B83.800x003","B83.800x004","B83.800x005","B83.800x006","B83.800x007","B83.800x008","B83.800x009","B83.900","B85.000","B85.100","B85.200","B85.300","B85.400","B87.100","B87.300","B87.800x001","B87.900","B88.000x002","B88.000x003","B88.100","B88.200x001","B88.300","B88.800x001","B88.800x002","B88.800x004","B88.900x001","B88.900x002","B88.900x003","B89.x00","B89.x01","B90.102+N29.1*","B99.x00x001","B99.x01","O98.600x001","P37.000","P37.100","P37.300","T80.200","T80.200x004","T88.000"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合SZ1入组条件，匹配规则：主诊断匹配");
                    
                if (MDCS_DRG.SZ13_group(record))
                {
                    return "SZ13";
                }
    
                if (MDCS_DRG.SZ15_group(record))
                {
                    return "SZ15";
                }

                return "SZ1";
            }else{
                return "";
            }
        }
    }
}