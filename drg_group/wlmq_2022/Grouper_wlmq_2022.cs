using drg_group.wlmq_2022;

namespace drg_group
{
    public class Grouper_wlmq_2022
    {
        public static GroupResult group(MedicalRecord record){
            String drgCode=Grouper.group(record);
            GroupResult result=new GroupResult(record,drgCode);
            result.messages=Base.groupMessages.returnMessages(record.Index);
            return result;
        }
    }
}