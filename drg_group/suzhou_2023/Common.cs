using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace drg_group
{
    public enum DrgGroupStatus{
        // CHECK_FAILED="信息校验不通过",
        // SUCCESS("分组成功"),
        // FAIL("无法入组"),
        // ZD_NOT_VALID("诊断不是有效的ICD编码"),
        // SS_NOT_VALID("手术操作不是有效的ICD编码"),
        // QY("歧义病案"),
        // ZD_NOT_MATCH_GENDER("主诊断与病人性别不相符"),
        // MAIN_ZD_NOT_MDC("主诊断不在所有MDC的主诊表内"),
        // SS_ERROR("手术选择错误"),
        // NEWBORN_ERROR("新生儿诊断或手术错误");
        [Description("信息校验不通过")]
        CHECK_FAILED,
        [Description("信息校验通过")]
        CHECK_SUCCESS,
        [Description("分组成功")]
        SUCCESS,
        [Description("无法入组")]
        FAIL,
        [Description("诊断不是有效的ICD编码")]
        ZD_NOT_VALID,
        [Description("手术操作不是有效的ICD编码")]
        SS_NOT_VALID,
        [Description("歧义病案")]
        QY
    }
    public static class Common
    {
        public static string GetDescription(this Enum enumValue){
            FieldInfo fieldInfo = enumValue.GetType().GetField(enumValue.ToString());
            DescriptionAttribute[] attrs =
                fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            return attrs.Length > 0 ? attrs[0].Description : enumValue.ToString();
        }
        public static IEnumerable<string> read_csv(String filename,String[] cols){
            try {
                String header=(new StreamReader(File.OpenRead(filename))).ReadLine();
                var cols_for_search=header.Split(',');
                var col_index=cols.Select(x=>Array.IndexOf(cols_for_search,x)).ToArray();
                if (col_index.Length!=cols.Length){
                    Console.WriteLine("字段名称与CSV文件不匹配");
                    System.Environment.Exit(-1);
                }
                return File.ReadLines(filename).Skip(1).Select(x=>string.Join(',',col_index.Select(y=>replace_csv(x).Split(',')[y]))
                // {
                    // var header_cols=replace_csv(x).Split(',');
                    // var result=col_index.Select(y=>header_cols[y]);
                    // return string.Join(',',result);
                // }
                );
            } catch (IOException e) {
                Console.WriteLine(e.Message);
                Console.WriteLine("文件读取失败");
                System.Environment.Exit(-1);
            }
            return new String[0];
        }
        public static String replace_csv(String csv){
            var matches =System.Text.RegularExpressions.Regex.Matches(csv,"\"(.*?)\"");
            foreach (System.Text.RegularExpressions.Match item in matches)
            {
               csv=csv.Replace(item.Groups[0].Value, item.Groups[1].Value.Replace(",", "|"));
            }
            return csv;
        }
        public static Dictionary<String,String> read_dataFile(String folder,String dataFile){
            return read_dataFile(folder,dataFile,false);
        }
        public static Dictionary<String,String> read_dataFile(String folder,String dataFile,Boolean dropSame){
            // var path=System.IO.Directory.GetCurrentDirectory();
            // var filename=Path.Combine(path,folder,dataFile+".dat");
            var filename=Path.Combine(folder,dataFile+".dat");
            if (dropSame){
                return File.ReadAllLines(filename).Where(x=>x.Substring(0,x.IndexOf(" "))!=x.Substring(x.IndexOf(" ")+1))
                    .ToDictionary(x=>x.Substring(0,x.IndexOf(" ")),x=>x.Substring(x.IndexOf(" ")+1));
            }else{
                return File.ReadAllLines(filename).ToDictionary(x=>x.Substring(0,x.IndexOf(" ")),x=>x.Substring(x.IndexOf(" ")+1));
            }
        }
    }

}