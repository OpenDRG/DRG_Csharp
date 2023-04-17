using System.Collections.Concurrent;

namespace drg_group
{
  public class Messages
    {

        private ConcurrentDictionary<String,List<String>> messages=new ConcurrentDictionary<String,List<String>>();
        public void initMessage(String index){
            // if (!messages.ContainsKey(index)){
            //     messages.Add(index, new List<String>());
            // }
            messages.TryAdd(index, new List<String>());
        }
        public void putMessage(String index,String message){
            messages[index].Add(message);
        }
        public List<String> returnMessages(String index){
            List<String> result=messages[index];
            if (result.Contains("不符合MDCA的ADRG入组条件")){
                return result.Skip(result.IndexOf("不符合MDCA的ADRG入组条件")+1).ToList();
            }
            else{
                return result;
            }
        }
    }
}