namespace drg_group.wlmq_2022
{
    public class MDCP_DRG 
    {
    
        public static bool PB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool PC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool PJ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool PS19_group(MedicalRecord record){
            return true;
        }
    
        public static bool PS29_group(MedicalRecord record){
            return true;
        }
    
        public static bool PS39_group(MedicalRecord record){
            return true;
        }
    
        public static bool PS49_group(MedicalRecord record){
            return true;
        }
    
        public static bool PV19_group(MedicalRecord record){
            return true;
        }
    
        public static bool PK11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool PR11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool PU13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool PK15_group(MedicalRecord record){
            return true;
        }
    
        public static bool PR15_group(MedicalRecord record){
            return true;
        }
    
        public static bool PU15_group(MedicalRecord record){
            return true;
        }
    
    }
}
