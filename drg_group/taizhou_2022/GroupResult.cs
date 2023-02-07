using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drg_group
{
    public class GroupResult
    {
        public String Index;
        public String status;
        public String[] check_messages;
        public String[] group_messages;
        public String mdc;
        public String adrg;
        public String drg;
        public MedicalRecord record;
        public GroupResult(String index, String status, String[] check_messages, String[] group_messages, String mdc,
            String adrg, String drg,MedicalRecord record) {
            Index = index;
            this.status = status;
            this.check_messages = check_messages;
            this.group_messages = group_messages;
            this.mdc = mdc;
            this.adrg = adrg;
            this.drg = drg;
            this.record=record;
        }
        public GroupResult(MedicalRecord record,String drgCode){
            this.Index=record.Index;
            this.drg=drgCode;
            if (drgCode.Equals("0000")){
                this.status=DrgGroupStatus.FAIL.GetDescription();
                this.mdc="0000";
                this.adrg="00";
            }else if (drgCode.Substring(1, 2).Equals("00")){
                this.status=DrgGroupStatus.FAIL.GetDescription();
                this.mdc="MDC"+drgCode.Substring(0,1);
                this.adrg="00";
            }else if (drgCode.Substring(1, 2).Equals("QY")){
                this.status=DrgGroupStatus.QY.GetDescription();
                this.mdc="MDC"+drgCode.Substring(0,1);
                this.adrg="QY";
            }else{
                this.status=DrgGroupStatus.SUCCESS.GetDescription();
                this.mdc="MDC"+drgCode.Substring(0,1);
                this.adrg=drgCode.Substring(0,3);
            }
            this.record=record;
        }
        public override String ToString() {
            String check_messages_str=check_messages==null||check_messages.Length==0?"":"\""+string.Join("|", check_messages)+"\"";
            String group_messages_str=group_messages==null||group_messages.Length==0?"":"\""+string.Join("|", group_messages)+"\"";
            return this.record + "\nGroupResult [Index=" + this.Index + ", status=" + this.status + ", check_messages="
                + check_messages_str + ", group_messages=" + group_messages_str + ", mdc="
                + this.mdc + ", adrg=" + this.adrg + ", drg=" + this.drg + "]"
                ;
            // return this.drg;
        }
        public String ToCsv() 
        {
            String zdList_str=this.record.zdList==null||this.record.zdList.Length==0?"":"\""+string.Join(",", this.record.zdList)+"\"";
            String ssList_str=this.record.ssList==null||this.record.ssList.Length==0?"":"\""+string.Join(",", this.record.ssList)+"\"";
            String check_messages_str=check_messages==null||check_messages.Length==0?"":"\""+string.Join("|", check_messages)+"\"";
            String group_messages_str=group_messages==null||group_messages.Length==0?"":"\""+string.Join("|", group_messages)+"\"";
            return this.Index + "," +this.record.gender + "," + this.record.age + "," + this.record.ageDay + "," + record.weight + "," + 
                this.record.dept + "," + this.record.inHospitalTime + "," + this.record.leavingType + "," + zdList_str + "," + ssList_str + "," + this.record.remark + ","+
                this.status + "," + check_messages_str+ "," + group_messages_str + "," + this.mdc + "," + this.adrg + "," + this.drg;
        }
    }
}