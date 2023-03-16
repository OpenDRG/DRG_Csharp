using drg_group.chs_drg_10;

namespace drg_group
{
    public class Grouper_chs_drg_10
    {
        public static GroupResult group(MedicalRecord record){
            String drgCode=Grouper.group(record);
            GroupResult result=new GroupResult(record,drgCode);
            result.messages=Base.groupMessages.returnMessages(record.Index);
            return result;
        }
    }
}