namespace drg_group
{
    public class MedicalRecord
    {
        public MedicalRecord(String Index, String gender, int age, int ageDay, int weight, String dept,
            int inHospitalTime, String leavingType, String[] zdList, String[] ssList, String remark)
        {
            this.Index = Index;
            this.gender = gender;
            this.age = age;
            this.ageDay = ageDay;
            this.weight = weight;
            this.dept = dept;
            this.inHospitalTime = inHospitalTime;
            this.leavingType = leavingType;
            this.zdList = zdList;
            this.ssList = ssList;
            this.remark = remark;
        }
        public String Index;
        public String gender;
        public int age;
        public int ageDay;
        public int weight;
        public String dept;
        public int inHospitalTime;
        public String leavingType;
        public String[] zdList;
        public String[] ssList;
        public String remark;

        // public override string ToString() 
        // {
        //     PropertyDescriptorCollection coll = TypeDescriptor.GetProperties(this);
        //     StringBuilder builder = new StringBuilder();
        //     foreach(PropertyDescriptor pd in coll)
        //     {
        //         builder.Append(string.Format("{0} : {1}", pd.Name , pd.GetValue(this).ToString()));
        //     }
        //     return builder.ToString();
        // }
        public override String ToString()
        {
            String zdList_str=this.zdList==null||this.zdList.Length==0?"":"\""+string.Join(",", this.zdList)+"\"";
            String ssList_str=this.ssList==null||this.ssList.Length==0?"":"\""+string.Join(",", this.ssList)+"\"";
            return "MedicalRecord [Index=" + this.Index + ", gender=" + this.gender + ", age=" + this.age +
                ", ageDay=" + this.ageDay + ", weight=" + this.weight + ", dept=" + this.dept +
                ", inHospitalTime=" + this.inHospitalTime + ", leavingType=" + this.leavingType +
                ", zdList=" + zdList_str + ", ssList=" + ssList_str + ", remark=" + this.remark + "]";
        }
        public MedicalRecord(String[] s) {
            this.Index = s[0];
            this.gender = s[1];
            this.age = s[2]==""?0:(int)Convert.ToDouble(s[2]);
            this.ageDay = s[3]==""?0:(int)Convert.ToDouble(s[3]);
            this.weight = s[4]==""?0:(int)Convert.ToDouble(s[4]);
            this.dept = s[5];
            this.inHospitalTime = s[6]==""?0:(int)Convert.ToDouble(s[6]);
            this.leavingType = s[7];
            this.zdList = s[8].Split("|");
            this.ssList = s[9]==""?new String[0]:s[9].Split("|");
            this.remark = s.Length>10?s[10]:"";
        }
    }
}