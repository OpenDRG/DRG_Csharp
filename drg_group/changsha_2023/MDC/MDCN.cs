namespace drg_group.changsha_2023
{
    public class MDCN
    {
        public static String group(MedicalRecord record){
            String[] mdc_zd={"A18.100x019+N77.1*","A18.100x024+N74.1*","A18.100x026+N74.1*","A18.100x030+N77.0*","A18.100x032","A18.102","A18.111+N74.1*","A18.112+N74.0*","A18.113+N74.1*","A18.114+N74.1*","A18.115+N74.1*","A51.400x009+N74.2*","A54.003","A54.004","A54.005","A54.102","A54.200x004+N74.3*","A54.201+N74.3*","A56.002","A56.003","A56.004","A56.100x003+N74.4*","A56.100x004+N74.4*","A56.101+N74.4*","A56.104+N74.4*","A59.002+N77.1*","A60.000x003+N77.1*","B26.800x009+N74.8*","B37.300+N77.1*","B37.300x002+N77.1*","B37.301+N77.1*","B37.302+N77.1*","C45.100","C46.700x001","C48.100x006","C51.000","C51.001","C51.100","C51.200","C51.800","C51.900","C52.x00","C53.000","C53.100","C53.800","C53.801","C53.900","C54.000","C54.001","C54.100","C54.200","C54.300","C54.800","C54.900","C55.x00","C56.x00","C56.x00x003","C57.000","C57.000x002","C57.100","C57.101","C57.200","C57.300","C57.300x001","C57.301","C57.400","C57.700","C57.701","C57.702","C57.800x004","C57.800x005","C57.801","C57.802","C57.803","C57.900","C58.x00","C58.x00x002","C58.x00x003","C76.307","C77.500x003","C79.600","C79.800x202","C79.800x205","C79.800x206","C79.800x209","C79.800x211","C79.800x213","C79.800x214","C79.800x215","C79.800x216","C79.800x218","C79.800x219","C79.800x220","C79.800x222","C79.800x223","C79.800x228","C79.812","C79.813","C79.814","C79.821","C79.822","C79.823","C79.824","C79.833","D06.000","D06.100","D06.700","D06.900","D06.900x002","D07.000","D07.100","D07.100x002","D07.200","D07.200x002","D07.301","D07.302","D07.303","D07.304","D17.300x003","D17.700x024","D18.000x817","D18.000x824","D18.000x853","D18.000x854","D18.000x856","D20.103","D25.000","D25.000x002","D25.100x001","D25.100x002","D25.200","D25.200x002","D25.900","D25.900x001","D25.901","D26.000","D26.100","D26.100x002","D26.700","D26.701","D26.702","D26.900","D27.x00","D27.x01","D28.000","D28.000x002","D28.100","D28.200x002","D28.200x003","D28.201","D28.202","D28.203","D28.204","D28.205","D28.206","D28.700x001","D28.900","D39.000x001","D39.000x002","D39.001","D39.002","D39.003","D39.004","D39.005","D39.100x001","D39.100x003","D39.101","D39.200x001","D39.200x002","D39.201","D39.202","D39.203","D39.204","D39.700x001","D39.700x002","D39.701","D39.702","D39.703","D39.704","D39.705","D39.706","D39.707","D39.708","D39.709","D39.710","D39.900x001","D39.901","D39.902","D39.903","D48.127","E28.000","E28.100","E28.200","E28.200x003","E28.300x001","E28.300x002","E28.300x005","E28.300x008","E28.301","E28.302","E28.303","E28.800x002","E28.900","E30.900","E89.400x001","E89.400x002","E89.401","I77.009","I86.200","I86.300","I89.000x018","I89.000x019","I89.800x032","I89.800x033","L29.200","M35.202+N77.8*","N32.004","N70.000","N70.001","N70.002","N70.100","N70.101","N70.102","N70.103","N70.104","N70.900","N70.900x003","N70.900x007","N70.901","N70.902","N70.903","N70.904","N70.905","N70.906","N71.001","N71.002","N71.101","N71.102","N71.900x001","N71.901","N71.902","N72.x00x003","N72.x00x006","N72.x01","N72.x02","N72.x03","N73.001","N73.002","N73.003","N73.101","N73.102","N73.103","N73.104","N73.201","N73.202","N73.203","N73.300","N73.400","N73.500","N73.501","N73.600","N73.600x006","N73.601","N73.602","N73.603","N73.604","N73.605","N73.606","N73.800x002","N73.801","N73.902","N73.903","N75.000","N75.100","N75.801","N75.802","N75.900","N76.000","N76.000x001","N76.000x003","N76.000x004","N76.000x006","N76.001","N76.100x001","N76.100x002","N76.101","N76.200","N76.201","N76.300x001","N76.301","N76.400","N76.401","N76.500","N76.600","N76.601","N76.801","N76.802","N80.000","N80.001","N80.100","N80.100x001","N80.200","N80.200x001","N80.300","N80.301","N80.302","N80.303","N80.401","N80.500","N80.501","N80.600","N80.601","N80.602","N80.603","N80.800x007","N80.800x010","N80.800x011","N80.801","N80.802","N80.803","N80.804","N80.805","N80.806","N80.807","N80.808","N80.809","N80.900","N81.000","N81.100","N81.101","N81.102","N81.200","N81.201","N81.202","N81.203","N81.300","N81.301","N81.400","N81.500","N81.500x002","N81.500x003","N81.600","N81.601","N81.602","N81.800x004","N81.800x005","N81.801","N81.802","N81.803","N81.900","N82.000","N82.100x001","N82.101","N82.102","N82.103","N82.200","N82.300","N82.301","N82.303","N82.401","N82.500","N82.501","N82.502","N82.801","N82.900","N82.900x003","N82.901","N82.902","N83.000","N83.000x002","N83.001","N83.100","N83.100x002","N83.100x003","N83.101","N83.102","N83.201","N83.202","N83.203","N83.204","N83.205","N83.206","N83.207","N83.300x001","N83.300x002","N83.401","N83.500x004","N83.500x007","N83.501","N83.502","N83.503","N83.504","N83.600","N83.601","N83.700","N83.800x012","N83.800x013","N83.800x015","N83.800x016","N83.800x017","N83.800x021","N83.801","N83.802","N83.803","N83.804","N83.805","N83.806","N83.807","N83.808","N83.809","N83.810","N83.811","N83.812","N83.901","N83.902","N83.903","N84.000","N84.001","N84.100","N84.100","N84.200","N84.300","N84.301","N84.302","N84.800x002","N84.900","N85.000","N85.000x002","N85.000x004","N85.001","N85.002","N85.003","N85.100","N85.101","N85.200","N85.300","N85.300x001","N85.400","N85.401","N85.402","N85.403","N85.404","N85.500","N85.600","N85.600x001","N85.700","N85.800x003","N85.801","N85.802","N85.803","N85.804","N85.805","N85.806","N85.807","N85.808","N85.809","N85.810","N85.811","N85.812","N85.813","N85.814","N85.815","N85.816","N85.901","N86.x00x004","N86.x01","N86.x02","N87.000","N87.001","N87.002","N87.100","N87.101","N87.200x001","N87.900","N87.901","N88.000","N88.100","N88.101","N88.102","N88.200x001","N88.201","N88.300","N88.400","N88.800x010","N88.801","N88.802","N88.803","N88.804","N88.805","N88.806","N88.807","N88.808","N88.900","N89.000","N89.001","N89.100","N89.101","N89.200","N89.300","N89.400","N89.501","N89.502","N89.503","N89.600","N89.600x001","N89.600x002","N89.601","N89.700","N89.800x009","N89.801","N89.802","N89.803","N89.804","N89.805","N89.806","N89.807","N89.808","N89.809","N89.810","N89.811","N89.901","N90.000","N90.001","N90.100","N90.101","N90.200","N90.300","N90.301","N90.302","N90.400","N90.401","N90.402","N90.403","N90.404","N90.500","N90.501","N90.600","N90.601","N90.700","N90.701","N90.800x009","N90.800x010","N90.800x011","N90.800x012","N90.800x024","N90.800x025","N90.801","N90.802","N90.803","N90.804","N90.805","N90.806","N90.807","N90.808","N90.809","N90.810","N90.811","N90.901","N90.902","N91.000","N91.100","N91.200","N91.200x002","N91.300","N91.400","N91.500","N92.000x001","N92.000x002","N92.100x001","N92.101","N92.200","N92.300","N92.400","N92.400x001","N92.400x003","N92.400x004","N92.401","N92.500","N92.600","N92.601","N93.000x001","N93.801","N93.900","N93.901","N94.000","N94.100","N94.200","N94.300","N94.400","N94.500","N94.600","N94.800x009","N94.802","N94.803","N94.804","N94.805","N94.806","N94.807","N94.808","N94.808","N94.900","N95.000","N95.100","N95.101","N95.200","N95.201","N95.300x001","N95.800","N95.900x001","N96.x00","N96.x00x002","N96.x00x003","N97.000x001","N97.100x001","N97.100x003","N97.101","N97.200x001","N97.200x002","N97.300","N97.400x001","N97.400x002","N97.800x004","N97.801","N97.900","N97.901","N97.902","N98.000","N98.100","N98.200","N98.300","N98.800","N98.900","N99.200","N99.201","N99.300","N99.800x003","N99.800x005","N99.800x007","N99.800x010","N99.801","N99.807","Q27.813","Q27.814","Q27.816","Q50.000","Q50.000x011","Q50.000x021","Q50.100","Q50.200","Q50.300x101","Q50.301","Q50.302","Q50.303","Q50.400","Q50.401","Q50.501","Q50.502","Q50.503","Q50.504","Q50.600","Q50.600x903","Q50.600x904","Q50.601","Q50.602","Q50.603","Q51.000","Q51.000x001","Q51.001","Q51.100","Q51.100x001","Q51.201","Q51.202","Q51.203","Q51.300","Q51.400","Q51.501","Q51.502","Q51.600","Q51.800x007","Q51.800x011","Q51.800x012","Q51.801","Q51.802","Q51.803","Q51.804","Q51.805","Q51.806","Q51.808","Q51.900","Q51.901","Q52.000","Q52.101","Q52.103","Q52.104","Q52.200","Q52.300","Q52.400x006","Q52.400x007","Q52.401","Q52.402","Q52.403","Q52.404","Q52.405","Q52.406","Q52.407","Q52.408","Q52.500x001","Q52.601","Q52.700x003","Q52.700x004","Q52.700x005","Q52.701","Q52.702","Q52.703","Q52.800x004","Q52.901","Q56.000","Q56.200","Q56.300","Q56.400","Q85.900x016","Q85.900x045","Q85.900x047","R87.000","R87.100","R87.200","R87.300","R87.400","R87.500","R87.600","R87.700","R87.800","R93.800x006","R93.800x007","R93.803","S30.200x007","S30.200x008","S30.200x010","S30.207","S31.400x001","S31.400x002","S31.400x003","S31.401","S31.402","S37.400","S37.410","S37.500","S37.510","S37.600","S37.600x002","S37.601","S37.602","S37.610","S37.710","S37.810","S38.200x001","S38.200x002","S38.200x006","S39.901","S39.902","T19.201","T19.202","T19.300x001","T28.300x001","T28.300x001","T28.300x002","T28.300x002","T28.300x003","T28.300x003","T28.800x001","T28.800x002","T28.800x002","T28.800x003","T83.301","T83.302","T83.303","T83.304","T83.305","T83.400","T83.400x001","Z01.400x001","Z01.800x003","Z31.000x001","Z31.100","Z31.200","Z31.200x003","Z31.201","Z31.300x001","Z31.300x002","Z52.800x001"};
            String[] dept_list={};
            if (!(true && mdc_zd.Contains(record.zdList[0]) && record.gender!=null && record.gender.Equals("2"))){
                return "";
            }
            
            Base.groupMessages.putMessage(record.Index,"符合MDCN入组条件，匹配规则：主诊断匹配、女性");
            String result;
    
            result=NA1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=NA2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=NB1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=NC1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=ND1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=NE1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=NF1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=NG1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=NJ1.group(record);
            if (result.Length>0){
                return result;
            }
    
            if (false && record.ssList!=null && record.ssList.Length>0  && Base.intersect(Base.SS_VALID,record.ssList)){
                Base.groupMessages.putMessage(record.Index,"符合NQY入组条件，存在有效手术操作："+record.ssList.Intersect(Base.SS_VALID));
                return "NQY";
            }
    
            result=NR1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=NS1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=NZ1.group(record);
            if (result.Length>0){
                return result;
            }
    
            Base.groupMessages.putMessage(record.Index,"不符合MDCN的ADRG入组条件");
            return "";
        }
    }
}
