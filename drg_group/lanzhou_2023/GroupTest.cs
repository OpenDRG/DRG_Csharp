using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static drg_group.GroupProxy;

namespace drg_group
{
    public class GroupTest
    {
        static void Main(string[] args)
        {
            GroupProxy grouper=new GroupProxy();
            // Console.WriteLine(grouper.group_record("22082078,1,24, 9105, 3470,13050201, 6, 1,\"K63.500,K52.910\",\"00.5500,45.4300x010,45.4300x013\"")); 
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
    }
}