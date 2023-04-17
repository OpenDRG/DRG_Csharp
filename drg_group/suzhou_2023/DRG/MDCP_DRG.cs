namespace drg_group.suzhou_2023
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
    
        public static bool PK19_group(MedicalRecord record){
            return true;
        }
    
        public static bool PR19_group(MedicalRecord record){
            return true;
        }
    
        public static bool PS19_group(MedicalRecord record){
            return true;
        }
    
        public static bool PV19_group(MedicalRecord record){
            return true;
        }
    
        public static bool PS21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool PS31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool PS41_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool PU11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool PU13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool PS2B_group(MedicalRecord record){
            return true;
        }
    
        public static bool PS3B_group(MedicalRecord record){
            return true;
        }
    
        public static bool PS4B_group(MedicalRecord record){
            return true;
        }
    
        public static bool PU15_group(MedicalRecord record){
            return true;
        }
    
    }
}
