using drg_group.suzhou_2023;

namespace drg_group
{
    public class Grouper_suzhou_2023
    {
        public static GroupResult group(MedicalRecord record){
            String drgCode=Grouper.group(record);
            GroupResult result=new GroupResult(record,drgCode);
            result.group_messages=Base.groupMessages.returnMessages(record.Index).ToArray();
            return result;
        }
    }
}