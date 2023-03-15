namespace drg_group
{
    public class Base
    {
        public static Messages groupMessages=new Messages();
        public static String[] SS_VALID=getList(getLines("SS_VALID.dat"));
        public static Dictionary<String,String> DRG=getDict(getLines("DRG.dat"));
        public static Dictionary<String,String> MCC=getDict(getLines("MCC.dat"));
        public static Dictionary<String,String> CC=getDict(getLines("CC.dat"));
        public static Dictionary<String,String> CCE=getDict(getLines("CCE.dat"));
        private static String[] getList(String[] lines){
            return lines.Select(x=>x.Split(' ')[0]).ToArray();
        }
        private static Dictionary<String,String> getDict(String[] lines){
            return lines.ToDictionary(x=>x.Substring(0,x.IndexOf(" ")),x=>x.Substring(x.IndexOf(" ")+1));
        }
        private static String[] getLines(String dataFile){
            // Console.WriteLine("a:"+AppDomain.CurrentDomain.BaseDirectory);
            // Console.WriteLine("b:"+System.Threading.Thread.GetDomain().BaseDirectory);
            // Console.WriteLine("c:"+Environment.CurrentDirectory);
            // Console.WriteLine("d:"+System.IO.Directory.GetCurrentDirectory());
            // Console.WriteLine("e:"+System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            var filename=Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"DATA",dataFile);
            return File.ReadAllLines(filename);
        }
        public static bool has_cc(String index,String mainZd,String[] otherZd){
            String cce="";
            if (Base.CCE.ContainsKey(mainZd)){
                cce=Base.CCE[mainZd];
                Base.groupMessages.putMessage(index,String.Format("主诊断{0}排除表{1}",mainZd,cce));
            }
            foreach (String zd in otherZd){
                if (Base.CC.ContainsKey(zd)){
                    String cc=Base.CC[zd];
                    Base.groupMessages.putMessage(index,String.Format("诊断{0}属于CC，排除表{1}",zd,cc));
                    if (cce.Length>0 && cce.Equals(cc)){
                        continue;
                    }else{
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool has_mcc(String index,String mainZd,String[] otherZd){
            String cce="";
            if (Base.CCE.ContainsKey(mainZd)){
                cce=Base.CCE[mainZd];
                Base.groupMessages.putMessage(index,String.Format("主诊断{0}排除表{1}",mainZd,cce));
            }
            foreach (String zd in otherZd){
                if (Base.MCC.ContainsKey(zd)){
                    String mcc=Base.MCC[zd];
                    Base.groupMessages.putMessage(index,String.Format("诊断{0}属于CC，排除表{1}",zd,mcc));
                    if (cce.Length>0 && cce.Equals(mcc)){
                        continue;
                    }else{
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool intersect(String[] a,String[] b){
            foreach(var x in a){
                foreach(var y in b){
                    if (x.Equals(y)){
                        return true;
                    }
                }
            }
            return false;
        }
    }
}