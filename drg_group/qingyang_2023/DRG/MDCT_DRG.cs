namespace drg_group.qingyang_2023
{
    public class MDCT_DRG 
    {
    
        public static bool TB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool TR19_group(MedicalRecord record){
            return true;
        }
    
        public static bool TR29_group(MedicalRecord record){
            return true;
        }
    
        public static bool TS19_group(MedicalRecord record){
            return true;
        }
    
        public static bool TT29_group(MedicalRecord record){
            return true;
        }
    
        public static bool TU19_group(MedicalRecord record){
            return true;
        }
    
        public static bool TV19_group(MedicalRecord record){
            return true;
        }
    
        public static bool TS23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool TT13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool TW13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool TS25_group(MedicalRecord record){
            return true;
        }
    
        public static bool TT15_group(MedicalRecord record){
            return true;
        }
    
        public static bool TW15_group(MedicalRecord record){
            return true;
        }
    
    }
}
