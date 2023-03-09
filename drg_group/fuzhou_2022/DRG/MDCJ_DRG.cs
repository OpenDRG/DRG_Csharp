namespace drg_group.fuzhou_2022
{
    public class MDCJ_DRG 
    {
    
        public static bool JS29_group(MedicalRecord record){
            return true;
        }
    
        public static bool JT19_group(MedicalRecord record){
            return true;
        }
    
        public static bool JV19_group(MedicalRecord record){
            return true;
        }
    
        public static bool JV29_group(MedicalRecord record){
            return true;
        }
    
        public static bool JZ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool JU11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool JU13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool JU15_group(MedicalRecord record){
            return true;
        }
    
    }
}
