namespace drg_group.wuhan_2022
{
    public class MDCY
    {
        public static String group(MedicalRecord record){
            String[] mdc_zd={"O98.700","B22.701","B23.801","B20.001","B22.000x001","B20.002","B20.005","B23.000","B20.004","B21.300","B20.400x001","B23.100","B22.700","B20.901","B20.300x001","B22.000x004","B20.700x001","B20.301","B21.900","B21.200x001","B23.201","I33.000x018","B22.000x003","B20.006","Z21.x00x001","B23.100x001","B23.800","B21.000x001","Z20.600","B22.100","B20.000x001","B21.700","B23.800x001","B21.100x001","B20.801","B21.800","B20.100x001","B20.600x001","B22.000x005","B23.100x002","B20.500x001","B22.200","B23.800x002","B20.003","B23.200","B20.200x001","B24.x01","B22.001+F02.4*","R75.x00x001"};
            String[] dept_list={};
            if (!(true && Base.intersect(record.zdList,mdc_zd))){
                return "";
            }
            
            Base.groupMessages.putMessage(record.Index,"符合MDCY入组条件，匹配规则：某一诊断匹配");
            String result;
    
            result=YC1.group(record);
            if (result.Length>0){
                return result;
            }
    
            if (false && record.ssList!=null && record.ssList.Length>0  && Base.intersect(Base.SS_VALID,record.ssList)){
                Base.groupMessages.putMessage(record.Index,"符合YQY入组条件，存在有效手术操作："+record.ssList.Intersect(Base.SS_VALID));
                return "YQY";
            }
    
            result=YR1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=YR2.group(record);
            if (result.Length>0){
                return result;
            }
    
            Base.groupMessages.putMessage(record.Index,"不符合MDCY的ADRG入组条件");
            return "";
        }
    }
}
