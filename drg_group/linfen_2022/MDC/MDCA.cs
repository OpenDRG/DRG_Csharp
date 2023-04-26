namespace drg_group.linfen_2022
{
    public class MDCA
    {
        public static String group(MedicalRecord record){
            String[] mdc_zd={};
            String[] dept_list={};
            if (!(true && record.ssList!=null && record.ssList.Length>0 && Base.SS_VALID.Contains(record.ssList[0]))){
                return "";
            }
            
            Base.groupMessages.putMessage(record.Index,"符合MDCA入组条件，匹配规则：存在手术");
            String result;
    
            result=AA1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=AB1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=AC1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=AD1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=AE1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=AF1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=AG1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=AG2.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=AH1.group(record);
            if (result.Length>0){
                return result;
            }
    
            if (false && record.ssList!=null && record.ssList.Length>0 && Base.SS_VALID.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合AQY入组条件，存在有效手术操作："+record.ssList.Intersect(Base.SS_VALID));
                return "AQY";
            }
    
            Base.groupMessages.putMessage(record.Index,"不符合MDCA的ADRG入组条件");
            return "";
        }
    }
}
