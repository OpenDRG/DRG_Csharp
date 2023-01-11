namespace drg_group.suzhou_2022
{
    public class MDCP
    {
        public static String group(MedicalRecord record){
            String[] mdc_zd={"P96.100x002","P29.800x901","P74.401","P13.301","P78.800x009","P58.403","P27.801","P55.102","P54.300x003","P35.300","P78.300x005","P81.902","P78.300x003","P04.900","P55.101","P50.800","P04.300","P28.402","P83.802","P20.000","P39.100x003","P24.102","P78.300x004","P07.300x021","P35.401","P07.200x011","P10.800","P78.800x012","P74.202","P25.000","P13.200","P74.400","P92.300","P36.400","P15.900","P26.000","P83.302","P24.200","P92.400","A04.200x002","P70.000","P78.800x006","P11.101","P14.300","P61.401","P10.200","R95.900","P59.203","P92.000","P78.801","P52.200x001","P28.000","P36.800x004","P10.100","P27.000","P36.800x003","P57.000","P28.800x201","P23.600x002","P57.800","P90.x00","P52.600x001","P36.500","P93.x01","P78.001","P52.802","P29.800x201","Q87.300x901","A04.000x001","P39.800x004","P92.001","P37.200","P22.000","P23.300","P76.000","P83.500x003","P07.102","P36.900","P72.100","Q87.300x301","L01.006","P23.900","P39.101","P78.806","P96.803","P22.101","P61.500","P71.400","P83.800x007","P04.500","P15.803","P27.802","P13.800","P74.301","P91.802","P29.400","P78.802","P96.000x001","P80.801","P93.x00","P35.000x001","P58.800x001","L00.x01","P96.200","P05.200","P23.600","P11.200","P20.900","P91.900","P28.800x903","P71.902","P04.101","P14.800x002","P04.200","P35.200","P24.300","P08.100x001","P26.900","P13.100","P27.900","P15.000","P72.200x001","P59.301","P70.100","P37.800x001","A33.x00","P39.100x004","P74.900","P58.300","P52.500","R95.000","P83.400","P39.402","P10.300","P92.900","P78.000x006","P07.001","P24.800","E55.000x006","P58.100","P08.200x002","P50.400","P55.001","P21.101","P37.400","P71.200","P56.900","P28.800x202","P29.401","P58.800","Q89.003","P36.200","P71.901","P83.600","P23.000x001","P56.000","P04.102","P29.200","P51.801","P15.400","P58.900","P91.800x001","P74.800x003","P29.900","P14.800x001","P23.800","P24.900","P39.000","A04.402","P58.402","Q89.001","P11.100","P12.000x001","P54.000","P78.000x005","P78.803","P74.402","P15.804","P50.000","P96.800x904","P76.100","P54.300x001","P07.300x001","P28.302","P54.800x002","P58.401","P83.100","P28.800x901","P23.200","P80.000","P21.102","Q86.000","P59.902","P96.000x002","P37.800x002","P78.300x002","P81.901","P83.803","P51.000","P54.802","P28.303","P55.800x002","P23.600x001","P21.900","P59.000","P96.801","P61.200","P70.400x002","P07.200x021","P04.800x001","P57.901","P72.800","P61.800","P70.300","P28.400","P96.301","P29.802","P12.400","P59.201","P15.600","P58.500","P12.100","P96.100x001","P28.401","P74.501","P08.100x002","P83.801","A09.900x005","P94.900","P77.x01","P05.102","P59.100","P71.800","P52.801","P11.000","P04.600","P12.801","P28.301","P50.100","K10.200x009","P29.000","P55.801","P15.500","P36.800x001","P39.800x006","P24.001","P96.800x101","Q89.801","P35.400","P53.x00x001","P76.801","P24.101","P04.400","P55.900","P15.300","P10.901","P92.500","P74.403","P26.800","P39.800x007","P21.000","P39.200","P13.801","P25.200","P61.300","P07.300x011","P81.800","P51.900","E84.101+P75*","P35.100","P15.100","P80.900","P91.500","P29.800x902","P28.500","P54.600","P11.400","P12.300","P39.300","P78.800x004","P07.300","P28.801","P22.801","P25.100","P78.804","P36.101","P78.807","P39.102","P52.600x002","Q86.200","P15.800x004","A04.400x003","P28.102","P05.001","P35.000","P91.200","P96.500","P94.200x002","P36.902","P83.301","P50.200","P55.000x002","P94.200x001","P39.800x005","P92.800x003","P54.900","P71.100","P27.100","P60.x00","P38.x01","P52.200x002","P37.900","P74.002","P04.800","P61.900","P39.801","P50.900","P08.000","P12.900","P78.900","P21.900x002","P96.400","P70.801","Q89.400","P52.900","P61.001","P24.002","P74.201","P91.300","P28.800x101","P23.500","P23.600x004","P05.900x001","P39.800x008","P83.800x005","P15.201","P13.900","P81.001","P07.200","P52.300","P50.300","P74.801","P94.100x001","P14.900","P78.000x003","P92.100x001","P20.100","P91.400","P74.302","P22.000x001","P78.800x007","P71.100x001","P71.300x001","P36.800x002","P54.500","P04.001","P13.300","P54.400","P07.100","P28.900","P22.900","P91.801","P13.000","P35.900x001","P78.901","P15.802","P12.201","P78.805","P74.100","P57.900","P36.800x005","P70.401","P58.200","P78.800x005","P27.000x001","P10.000","P83.500","P91.600","P54.200","P94.800","P78.002","P29.301","P91.700","P80.800x001","P39.401","P78.100x001","P83.500x002","P50.500","P28.200","P92.800x001","P78.800x010","P37.500","P11.500x002","P78.300x001","Q27.000","P83.000","P78.000x004","P55.002","P07.002","P70.200","P52.400","P91.000x002","P36.301","P39.900","A04.100x002","P70.400x001","P76.900","P15.801","P38.x00x001","P14.100","P29.300","P26.100","P78.800x008","P24.901","P13.400","P23.600x003","P54.300x002","P59.801","A04.301","Q86.100","P91.100","P36.901","P25.801","P07.101","P29.100","P53.x00x002","P61.601","P11.500x003","P52.000","P83.800x006","P14.200","P72.000","P83.200","P54.100","P52.100","P05.900","P35.900","P54.801","P35.800x001","P78.200x001","P23.100","P61.100","P81.000","P10.400","P83.800x004","Q89.000","P36.000","P96.804","P28.300","Q87.300x902","P96.300","P59.202","P92.200","P96.900x001","P15.901","P25.300","P14.000","P61.000","P74.802","P54.800x003","P94.000","P23.400","P59.901","A54.301+H13.1*","P74.001","P93.x02","P83.401","P78.000x007","P71.000","P20.901","P95.x00","P07.000","P37.901","P72.900","P39.403","P22.100x003","Q89.002","P96.802","P58.000","P11.300","P70.900","P11.900x001","P76.200","P91.900x001","P83.901"};
            String[] dept_list={};
            if (!(true && mdc_zd.Contains(record.zdList[0]) && record.age==0)){
                return "";
            }
            
            Base.groupMessages.putMessage(record.Index,"符合MDCP入组条件，匹配规则：主诊断匹配、婴儿");
            String result;
    
            result=PB1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=PC1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=PJ1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=PK1.group(record);
            if (result.Length>0){
                return result;
            }
    
            if (record.ssList!=null && record.ssList.Length>0 && Base.SS_VALID.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合PQY入组条件，存在有效手术操作："+record.ssList.Intersect(Base.SS_VALID));
                return "PQY";
            }
    
            result=PR1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=PS1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=PS2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=PS3.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=PS4.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=PU1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=PV1.group(record);
            if (result.Length>0){
                return result;
            }
    
            Base.groupMessages.putMessage(record.Index,"不符合MDCP的ADRG入组条件");
            return "";
        }
    }
}
