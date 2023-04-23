namespace drg_group.changzhou_2022
{
    public class MDCS
    {
        public static String group(MedicalRecord record){
            String[] mdc_zd={};
            String[] dept_list={};
            if (!(true)){
                return "";
            }
            
            Base.groupMessages.putMessage(record.Index,"符合MDCS入组条件，匹配规则：无限制条件");
            String result;
    
            result=SB1.group(record);
            if (result.Length>0){
                return result;
            }
    
            if (false && record.ssList!=null && record.ssList.Length>0 && Base.SS_VALID.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合SQY入组条件，存在有效手术操作："+record.ssList.Intersect(Base.SS_VALID));
                return "SQY";
            }
    
            result=SR1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=SS1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=ST1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=SU1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=SV1.group(record);
            if (result.Length>0){
                return result;
            }
    
            result=SZ1.group(record);
            if (result.Length>0){
                return result;
            }
    
            Base.groupMessages.putMessage(record.Index,"不符合MDCS的ADRG入组条件");
            return "";
        }
    }
}
