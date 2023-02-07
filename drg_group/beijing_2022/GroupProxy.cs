using System.ComponentModel;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace drg_group
{
    public class GroupProxy
    {
        
        GroupDelegate groupDelegate=new GroupDelegate(Grouper_beijing_2022.group);
        public delegate GroupResult GroupDelegate(MedicalRecord record);
        // private static 
        
        private static Dictionary<String,String> ZD_INFO=Common.read_dataFile("ICD","ZD_INFO");
        private static Dictionary<String,String> SS_INFO=Common.read_dataFile("ICD","SS_INFO");
        private static Dictionary<String,String> ZD_Mapping=Common.read_dataFile("ICD","ZD_MAP",true);
        private static Dictionary<String,String> SS_Mapping=Common.read_dataFile("ICD","SS_MAP",true);
        public static Messages checkMessages=new Messages();
        private bool TRANS_CODE=false;
        public GroupProxy(){
        }
        public GroupProxy(bool TRANS_CODE){
            this.TRANS_CODE=TRANS_CODE;
        }
        private static DrgGroupStatus check(MedicalRecord record){
            try{
                if (record.gender.Length==0){
                    checkMessages.putMessage(record.Index,"病人性别为空");
                    return DrgGroupStatus.CHECK_FAILED;
                }
                if (record.age==0 && record.ageDay<=28 && record.weight==0){
                    checkMessages.putMessage(record.Index,"新生儿的出生体重必须有值");
                    return DrgGroupStatus.CHECK_FAILED;
                }
                if (record.zdList.Length==0){
                    checkMessages.putMessage(record.Index,"诊断信息为空");
                    return DrgGroupStatus.CHECK_FAILED;
                }
                if (record.gender.IndexOf(".")>=0){
                    record.gender=record.gender.Substring(0,record.gender.IndexOf("."));
                }else if (record.gender.Equals("男")){
                    record.gender="1";
                }else if (record.gender.Equals("女")){
                    record.gender="2";
                }
                if (record.dept.IndexOf(".")>=0){
                    record.dept=record.dept.Substring(0,record.dept.IndexOf("."));
                }
                if (record.leavingType.IndexOf(".")>=0){
                    record.leavingType=record.leavingType.Substring(0,record.leavingType.IndexOf("."));
                }
            }catch (Exception e) {
                Console.WriteLine(e.Message);
                checkMessages.putMessage(record.Index,"病案信息解析出错");
                return DrgGroupStatus.CHECK_FAILED;
            }
            return DrgGroupStatus.CHECK_SUCCESS;
        }
        private static DrgGroupStatus trans(MedicalRecord record){
            foreach (String x in record.zdList){
                String zd=x;
                if (ZD_Mapping.ContainsKey(x)){
                    zd=ZD_Mapping[x];
                    record.zdList.SetValue(zd,Array.IndexOf(record.zdList,x));
                    checkMessages.putMessage(record.Index, String.Format("诊断{0}转换为{1} {2}",x,zd,ZD_INFO.ContainsKey(zd)?ZD_INFO[zd]:""));
                }else{
                    checkMessages.putMessage(record.Index, String.Format("诊断{0}无法转换为分组器支持的编码",zd));
                    return DrgGroupStatus.ZD_NOT_MAPPING;
                }  
            }
            foreach (String x in record.ssList){
                String ss=x;
                if (SS_Mapping.ContainsKey(x)){
                    ss=SS_Mapping[x];
                    record.ssList.SetValue(ss,Array.IndexOf(record.ssList,x));
                    checkMessages.putMessage(record.Index, String.Format("手术操作{0}转换为{1} {2}",x,ss,SS_INFO.ContainsKey(ss)?SS_INFO[ss]:""));
                    continue;
                }else{
                    checkMessages.putMessage(record.Index, String.Format("手术操作{0}无法转换为分组器支持的编码",ss));
                    return DrgGroupStatus.SS_NOT_MAPPING;
                } 
            }
            return DrgGroupStatus.CHECK_SUCCESS;
        }
        public GroupResult group_record(MedicalRecord record){
            return group_record(this.groupDelegate,record);
        }
        public GroupResult group_record(GroupDelegate groupDelegate,MedicalRecord record) {
            checkMessages.initMessage(record.Index);
            DrgGroupStatus status;
            if (TRANS_CODE){
                status=trans(record);
                if (status!=DrgGroupStatus.CHECK_SUCCESS){
                    return new GroupResult(record.Index,status.GetDescription(),checkMessages.returnMessages(record.Index).ToArray(),null,
                        "0000","00","0000",record);
                }
            }
            status=check(record);
            if (status!=DrgGroupStatus.CHECK_SUCCESS){
                return new GroupResult(record.Index,status.GetDescription(),checkMessages.returnMessages(record.Index).ToArray(),null,
                    "0000","00","0000",record);
            }
            GroupResult result=groupDelegate(record);
            result.check_messages=checkMessages.returnMessages(record.Index).ToArray();
            return result;
        }
        public GroupResult group_record(String record_str) {
            return group_record(this.groupDelegate,record_str);
        }
        public GroupResult group_record(GroupDelegate groupDelegate,String record_str) {
            return group_record(groupDelegate,new MedicalRecord(record_str.Split(',')));
        }
        public void group_txt(){
            group_txt(this.groupDelegate);
        }
        public void group_txt(GroupDelegate grouper){
            var d1= DateTime.Now;
            var path=System.IO.Directory.GetCurrentDirectory();
            try {
                var result =File.ReadAllLines(Path.Combine(path,"input.txt")).Skip(1).Select(x=>group_record(grouper,x).ToString());
                File.WriteAllLines(Path.Combine(path,"output.txt"),result,System.Text.Encoding.UTF8);
            } catch (IOException e) {
                Console.WriteLine(e.Message);
                Console.WriteLine("读取input.txt失败，请确保文件存在，且内容符合CSV格式，且字段顺序为：Index,gender,age,ageDay,weight,dept,inHospitalTime,leavingType,zdList,ssList");
                System.Environment.Exit(-1);
            }
            var d2= DateTime.Now;
            Console.WriteLine(String.Format("group time {0}",(d2- d1).TotalSeconds));
        }
        public void group_csv(String filename,String[] cols){
            group_csv(this.groupDelegate,filename,cols);
        }
        public void group_csv(GroupDelegate groupDelegate,String filename,String[] cols){
            var d1= DateTime.Now;
            // var sr=new StreamWriter(File.OpenWrite(filename.Replace(".csv", "_csharp_result.csv")));
            // sr.WriteLine(header);
            var result=Common.read_csv(filename,cols).AsParallel().Select(x=>group_record(groupDelegate,x).ToCsv()).ToList();
            var d2= DateTime.Now;
            Console.WriteLine(String.Format("group time {0}",(d2- d1).TotalSeconds));
            result.Insert(0,"Index,gender,age,ageDay,weight,dept,inHospitalTime,leavingType,zdList,ssList,remark,status,check_messages,group_messages,mdc,adrg,drg");
            try{
                File.WriteAllLines(filename.Replace(".csv", "_csharp_result.csv"),result,System.Text.Encoding.UTF8);
            }catch(IOException e) {
                Console.WriteLine(e.Message);
                Console.WriteLine(String.Format("文件写入失败%s", filename.Replace(".csv", "_csharp_result.csv")));
                System.Environment.Exit(-1);
            }
        }
    }
}