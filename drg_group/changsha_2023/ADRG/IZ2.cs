namespace drg_group.changsha_2023{
    public class IZ2
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={"B33.001","C79.827","D16.000x002","D16.001","D16.002","D16.003","D16.004","D16.100x005","D16.101","D16.102","D16.103","D16.200x005","D16.201","D16.202","D16.203","D16.300x003","D16.300x004","D16.300x005","D16.300x008","D16.301","D16.302","D16.303","D16.304","D16.600x002","D16.600x003","D16.600x004","D16.600x005","D16.700x003","D16.701","D16.702","D16.800x001","D16.800x002","D16.800x006","D16.801","D16.802","D16.803","D16.804","D16.900x001","D16.900x002","D16.900x003","D17.700x028","D18.000x846","D18.000x860","D18.000x861","D18.009","D18.014","D21.100","D21.100x002","D21.100x003","D21.100x004","D21.101","D21.102","D21.200","D21.200x003","D21.200x004","D21.200x006","D21.200x007","D21.201","D21.202","D21.300","D21.300x001","D21.300x004","D21.301","D21.303","D21.400x001","D21.400x002","D21.400x003","D21.401","D21.402","D21.403","D21.500","D21.500x001","D21.500x002","D21.500x005","D21.501","D21.502","D21.503","D21.504","D21.505","D21.507","D21.508","D21.509","D21.600","D21.600x002","D21.601","D21.602","D21.900x001","D21.900x002","D21.900x003","D21.900x005","D21.900x007","D21.900x008","D21.900x009","D21.900x012","D21.900x013","D21.900x014","D48.113","D48.119","D48.123","D48.125","D48.131","D48.133","D86.800x007","D86.900","D86.901","E10.600x014+M14.2*","E11.600x014+M14.2*","E14.600x014+M14.2*","E34.902+M82.1*","I89.000x020","I89.000x021","I89.004","I89.800x031","M15.801","M20.000","M20.000x004","M20.000x005","M20.000x011","M20.002","M20.003","M20.005","M20.006","M20.007","M20.100x001","M20.100x002","M20.200x001","M20.301","M20.302","M20.400x001","M20.501","M20.502","M20.503","M20.504","M20.505","M20.506","M20.507","M20.508","M20.600","M21.000x051","M21.000x071","M21.001","M21.002","M21.003","M21.100x011","M21.100x051","M21.100x072","M21.101","M21.102","M21.103","M21.104","M21.105","M21.200x001","M21.200x021","M21.200x031","M21.200x032","M21.200x041","M21.200x061","M21.201","M21.202","M21.301","M21.302","M21.400","M21.401","M21.402","M21.501","M21.502","M21.503","M21.504","M21.505","M21.600x071","M21.600x072","M21.601","M21.602","M21.603","M21.604","M21.605","M21.700","M21.700x031","M21.700x061","M21.701","M21.702","M21.703","M21.704","M21.705","M21.706","M21.801","M21.802","M21.803","M21.804","M21.805","M21.806","M21.807","M21.808","M21.900","M21.900x011","M21.900x041","M21.900x051","M21.901","M21.902","M21.903","M21.904","M21.905","M21.906","M21.907","M21.908","M22.900","M24.206","M24.207","M24.208","M24.209","M24.210","M24.304","M24.701","M24.802","M24.804","M24.901","M24.902","M24.903","M24.904","M24.905","M24.906","M24.907","M32.100x016","M32.113+H36.8*","M34.800x004+N08.5*","M34.800x007+N08.5*","M35.802","M53.101","M60.000","M60.000x051","M60.000x061","M60.000x092","M60.000x093","M60.001","M60.002","M60.003","M60.004","M60.005","M60.006","M60.007","M60.008","M60.100","M60.200x091","M60.201","M60.800x061","M60.800x081","M60.801","M60.802","M60.803","M60.804","M60.805","M61.000","M61.000x051","M61.100","M61.101","M61.102","M61.201","M61.301","M61.400","M61.501","M61.502","M61.900","M62.000","M62.100","M62.200","M62.200x001","M62.202","M62.203","M62.300","M62.400","M62.401","M62.402","M62.403","M62.404","M62.405","M62.406","M62.407","M62.408","M62.409","M62.410","M62.411","M62.501","M62.502","M62.503","M62.504","M62.505","M62.506","M62.507","M62.508","M62.509","M62.510","M62.511","M62.512","M62.513","M62.600","M62.601","M62.602","M62.603","M62.604","M62.605","M62.606","M62.607","M62.800x002","M62.800x051","M62.800x053","M62.800x061","M62.800x062","M62.800x081","M62.800x095","M62.800x096","M62.800x097","M62.800x101","M62.800x102","M62.802","M62.803","M62.804","M62.805","M62.806","M62.807","M62.808","M62.809","M62.810","M62.811","M62.812","M62.813","M62.814","M62.815","M62.817","M62.819","M62.821","M62.822","M62.901","M65.000","M65.001","M65.002","M65.003","M65.004","M65.005","M65.006","M65.007","M65.008","M65.009","M65.010","M65.101","M65.200","M65.300","M65.301","M65.400","M65.800x093","M65.802","M65.803","M65.804","M65.805","M65.806","M65.900x062","M65.900x093","M65.901","M65.902","M65.903","M65.904","M65.905","M65.906","M65.907","M65.908","M65.909","M65.910","M66.000","M66.101","M66.102","M66.103","M66.104","M66.105","M66.106","M66.107","M66.108","M66.109","M66.110","M66.111","M66.112","M66.113","M66.201","M66.202","M66.203","M66.204","M66.205","M66.206","M66.207","M66.208","M66.209","M66.301","M66.302","M66.303","M66.304","M66.305","M66.306","M66.307","M66.308","M66.309","M66.400","M66.501","M66.502","M67.001","M67.100x041","M67.100x051","M67.101","M67.102","M67.103","M67.104","M67.200","M67.300","M67.301","M67.302","M67.400","M67.400x031","M67.401","M67.402","M67.800x041","M67.800x091","M67.800x092","M67.800x093","M67.800x094","M67.800x095","M67.800x096","M67.803","M67.804","M67.805","M67.806","M67.807","M67.901","M70.001","M70.002","M70.100","M70.101","M70.102","M70.200","M70.201","M70.202","M70.301","M70.402","M70.403","M70.500x002","M70.501","M70.502","M70.503","M70.504","M70.600","M70.600x001","M70.700","M70.700x002","M70.701","M70.702","M70.800","M70.800x001","M70.901","M70.902","M71.000","M71.001","M71.002","M71.003","M71.004","M71.005","M71.006","M71.007","M71.008","M71.009","M71.100","M71.101","M71.102","M71.103","M71.104","M71.105","M71.106","M71.107","M71.108","M71.109","M71.200","M71.200x001","M71.300x021","M71.301","M71.302","M71.303","M71.304","M71.305","M71.306","M71.307","M71.308","M71.309","M71.310","M71.400","M71.401","M71.402","M71.403","M71.404","M71.405","M71.406","M71.407","M71.408","M71.501","M71.502","M71.503","M71.504","M71.505","M71.506","M71.507","M71.508","M71.801","M71.900","M71.900x001","M71.900x002","M71.900x003","M71.900x004","M71.900x005","M71.900x006","M71.900x007","M71.909","M72.000","M72.001","M72.100","M72.200","M72.201","M72.202","M72.400","M72.401","M72.402","M72.403","M72.404","M72.405","M72.406","M72.407","M72.408","M72.409","M72.410","M72.600","M72.601","M72.602","M72.603","M72.604","M72.605","M72.606","M72.607","M72.608","M72.609","M72.800x091","M72.800x092","M72.801","M72.802","M72.803","M72.804","M72.805","M72.806","M72.900x051","M72.900x052","M72.900x071","M72.900x073","M72.900x081","M72.900x082","M72.900x083","M72.900x084","M72.900x093","M72.901","M72.903","M72.904","M72.905","M72.906","M72.907","M72.908","M72.909","M72.910","M72.911","M72.912","M72.913","M72.914","M72.915","M72.916","M72.917","M72.918","M72.919","M72.920","M72.921","M72.922","M75.000","M75.000x001","M75.001","M75.002","M75.003","M75.004","M75.100","M75.101","M75.102","M75.103","M75.200","M75.201","M75.300","M75.301","M75.302","M75.400","M75.500","M75.501","M75.502","M75.503","M75.504","M75.600","M75.802","M75.803","M75.804","M75.900","M76.000","M76.100","M76.200","M76.300","M76.301","M76.302","M76.400","M76.400x001","M76.500","M76.600","M76.602","M76.603","M76.700","M76.701","M76.800x072","M76.801","M76.802","M76.803","M76.804","M76.805","M76.806","M76.807","M76.900","M77.000","M77.001","M77.100","M77.101","M77.200","M77.300","M77.400","M77.500","M77.501","M77.502","M77.503","M77.800x001","M77.800x002","M77.801","M77.804","M77.900","M77.901","M77.902","M77.903","M77.905","M77.906","M79.000","M79.000x092","M79.000x093","M79.000x095","M79.002","M79.100","M79.101","M79.102","M79.103","M79.104","M79.105","M79.106","M79.107","M79.108","M79.109","M79.201","M79.203","M79.206","M79.209","M79.300","M79.300x051","M79.301","M79.302","M79.303","M79.500","M79.500x061","M79.500x082","M79.501","M79.502","M79.503","M79.504","M79.505","M79.506","M79.507","M79.508","M79.509","M79.510","M79.511","M79.600","M79.600x002","M79.600x011","M79.600x021","M79.600x051","M79.601","M79.602","M79.603","M79.604","M79.700","M79.701","M79.702","M79.703","M79.704","M79.705","M79.800x001","M79.800x081","M79.800x082","M79.800x083","M79.800x091","M79.800x096","M79.808","M79.812","M79.900x001","M79.901","M79.902","M79.903","M79.904","M79.905","M79.906","M79.907","M79.908","M79.909","M83.500","M83.801","M83.802","M84.000","M84.000x021","M84.000x031","M84.000x032","M84.000x041","M84.000x042","M84.000x051","M84.000x061","M84.000x071","M84.000x072","M84.000x073","M84.000x081","M84.000x082","M84.100x011","M84.100x021","M84.100x031","M84.100x032","M84.100x041","M84.100x042","M84.100x043","M84.100x051","M84.100x061","M84.100x071","M84.100x072","M84.200","M84.401","M84.801","M84.900","M85.202","M85.801","M85.802","M85.803","M85.900","M89.900x101","M89.900x102","M89.900x103","M89.900x104","M89.902","M89.904","M89.905","M89.907","M89.908","M89.909","M89.910","M89.913","M89.914","M89.916","M89.921","M89.922","M89.923","M89.924","M89.925","M89.927","M89.929","M92.300","M92.301","M92.302","M92.303","M94.803","M94.804","M94.805","M94.806","M94.807","M95.301","M95.401","M95.402","M95.403","M95.404","M95.405","M95.406","M95.407","M95.408","M95.409","M95.410","M95.501","M95.502","M95.503","M95.504","M95.505","M95.506","M95.507","M95.508","M95.509","M95.510","M95.801","M95.802","M96.001","M96.801","M96.900","M99.000","M99.100x001","M99.100x002","M99.100x003","M99.100x004","M99.100x005","M99.100x006","M99.800","M99.900","N25.003+M90.8*","Q77.200","Q77.201","Q77.300","Q77.301","Q77.500","Q77.600","Q77.700","Q77.701","Q77.800","Q77.801","Q77.900","Q78.000","Q78.100","Q78.100x001","Q78.100x002","Q78.200","Q78.201","Q78.300","Q78.400","Q85.900x008","Q85.900x014","Q85.900x023","Q85.900x027","Q85.900x030","Q85.900x039","Q85.900x040","Q85.900x051","Q85.900x057","Q86.800","Q87.000x201","Q87.000x501","Q87.000x904","Q87.000x905","Q87.000x906","Q87.000x907","Q87.000x909","Q87.001","Q87.001","Q87.002","Q87.003","Q87.100x601","Q87.100x701","Q87.100x901","Q87.100x903","Q87.101","Q87.102","Q87.103","Q87.104","Q87.105","Q87.106","Q87.200","Q87.200x601","Q87.200x701","Q87.202","Q87.204","Q87.301","Q87.302","Q87.500","Q87.800","Q87.800x902","Q87.802","Q87.803","Q87.805","R07.300x002","R29.400","R93.600","R93.700","S22.910","S32.710","S32.711","S32.712","S33.701","S33.702","S39.000x001","S39.000x003","S39.000x005","S39.001","S39.002","S39.800x001","S39.800x002","S39.800x003","S39.800x004","S39.800x005","S42.800","S42.810","S48.900","S57.800","S59.800","S62.810","S72.810","S78.900","S79.800","S79.800x001","S88.900","S98.300","S98.400","T02.100x001","T02.110","T02.900","T02.910","T03.000x001","T03.000x002","T03.000x003","T03.100x001","T03.100x002","T03.100x003","T03.200x001","T03.200x002","T03.300x001","T03.300x002","T03.300x003","T03.400x001","T03.400x002","T03.400x003","T03.800x001","T03.800x002","T03.900","T03.900x001","T03.900x002","T04.800x001","T05.800x003","T06.400x001","T06.400x002","T06.401","T06.800x001","T09.200","T09.200x006","T09.200x009","T09.500","T09.500x002","T09.500x003","T11.200","T11.200x001","T11.200x002","T11.200x003","T11.200x004","T11.200x007","T14.200","T14.210","T14.300","T14.500","T14.501","T14.601","T14.602","T14.701","T14.702","T79.600","T79.600x003","T79.600x004","T79.600x006","T79.601","T79.602","T79.603","T79.800x002","T87.300","T87.300x001","T87.300x002","T87.400","T87.500","T87.600x002","T87.600x003","T87.600x004","T87.601","T87.602","T91.100","T91.101","T91.102","T91.103","T91.104","T93.100x007","Z52.200","M23.200x092","M23.205","M23.206","M23.207","M23.210","M23.213","M23.800x011","M23.800x021","M23.800x031","M23.800x041","M23.800x094","M23.800x095","M24.100x071","M24.100x072","M24.202","M24.801"};
            String[] adrg_zd1={};
            String[] adrg_ss={};
            String[] adrg_ss1={};
            
            if (true && adrg_zd.Contains(record.zdList[0])){
                Base.groupMessages.putMessage(record.Index,"符合IZ2入组条件，匹配规则：主诊断匹配");
                    
                if (MDCI_DRG.IZ21_group(record))
                {
                    return "IZ21";
                }
    
                if (MDCI_DRG.IZ25_group(record))
                {
                    return "IZ25";
                }

                return "IZ2";
            }else{
                return "";
            }
        }
    }
}