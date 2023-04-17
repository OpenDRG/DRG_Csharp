namespace drg_group
{
    public class GroupTest
    {
        private static GroupProxy grouper=new GroupProxy();
        static void Main(string[] args)
        {
            // grouper.group_txt();
            // group_yancheng();
            // group_suzhou();
            // String str="22082078,1,24, 9105, 3470,13050201, 6, 1,\"K63.500,K52.910\",\"00.5500,45.4300x010,45.4300x013\"";
            // Console.WriteLine(grouper.group_record(new GroupProxy.GroupDelegate(Grouper_suzhou_2023.group),Common.replace_csv(str))); 
            // System.Environment.Exit(-1);

            if (args==null||args.Length==0){
                var path=System.IO.Directory.GetCurrentDirectory();
                if (!File.Exists(Path.Combine(path,"input.txt"))){
                    Console.WriteLine(String.Format("文件不存在:{0}", Path.Combine(path,"input.txt")));
                    System.Environment.Exit(-1);
                }
                grouper.group_txt();
            }else if (args.Length==1){
                GroupResult result=grouper.group_record(args[0]);
                Console.WriteLine(result);
            }else{
                if (!File.Exists(args[0])){
                    Console.WriteLine(String.Format("文件不存在:{0}", args[0]));
                    System.Environment.Exit(-1);
                }
                grouper.group_csv(args[0],args[1].Split(","));
            }
        }
        // public static void group_yancheng(){
        //     String yearMonth="202209";
        //     var filename=Path.Combine("c:\\yb\\yc",String.Format("ba_group_info_{0}.csv", yearMonth));
        //     String[] cols={"BAHM","BRXB","NL","NLT","XSECSTZ","CYKS","ZYTS","LYFS","ICD10_DRGS","ICD9_DRGS"};
        //     grouper.group_csv(new GroupDelegate(Grouper_chs_drg_11.group),filename,cols);
        // }
        // public static void group_suzhou(){
        //     String yearMonth="202201-202206";
        //     var filename=Path.Combine("c:\\yb\\sz",String.Format("hqms_group_{0}.csv", yearMonth));
        //     String[] cols={"病案号","性别","年龄","年龄天","出生体重","出院科别","实际住院（天）","离院方式","诊断编码","手术操作编码"};
        //     // grouper.group_csv(filename,cols);
        //     grouper.group_csv(new GroupDelegate(grouper_suzhou_2023.group),filename,cols);
        // }
    }
}