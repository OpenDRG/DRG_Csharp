using drg_group.wuxi_2022;

namespace drg_group
{
    public class Grouper_wuxi_2022
    {
        public static GroupResult group(MedicalRecord record){
            String drgCode=Grouper.group(record);
            GroupResult result=new GroupResult(record,drgCode);
            result.group_messages=Base.groupMessages.returnMessages(record.Index).ToArray();
            return result;
        }
    }
}