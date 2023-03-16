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
        public List<String> messages;
        public String mdc;
        public String adrg;
        public String drg;
        public MedicalRecord record;
        public GroupResult(String index, String status, List<String> messages, String mdc,
            String adrg, String drg,MedicalRecord record) {
            Index = index;
            this.status = status;
            this.messages = messages;
            this.mdc = mdc;
            this.adrg = adrg;
            this.drg = drg;
            this.record=record;
        }
        public GroupResult(String status, List<String> messages, MedicalRecord record) {
            Index = record.Index;
            this.status = status;
            this.messages = messages;
            this.mdc = "0000";
            this.adrg = "00";
            this.drg = "0000";
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
            String messages_str=messages==null||messages.Count==0?"":"\""+string.Join("|", messages)+"\"";
            return this.record + "\nGroupResult [Index=" + this.Index + ", status=" + this.status + ", messages=" + 
                messages_str +", mdc="+ this.mdc + ", adrg=" + this.adrg + ", drg=" + this.drg + "]";
        }
        public String ToCsv() 
        {
            String zdList_str=this.record.zdList==null||this.record.zdList.Length==0?"":"\""+string.Join(",", this.record.zdList)+"\"";
            String ssList_str=this.record.ssList==null||this.record.ssList.Length==0?"":"\""+string.Join(",", this.record.ssList)+"\"";
            String messages_str=messages==null||messages.Count==0?"":"\""+string.Join("|", messages)+"\"";
            return this.Index + "," +this.record.gender + "," + this.record.age + "," + this.record.ageDay + "," + record.weight + "," + 
                this.record.dept + "," + this.record.inHospitalTime + "," + this.record.leavingType + "," + zdList_str + "," + ssList_str + "," + this.record.remark + ","+
                this.status + "," + messages_str + "," + this.mdc + "," + this.adrg + "," + this.drg;
        }
    }
}