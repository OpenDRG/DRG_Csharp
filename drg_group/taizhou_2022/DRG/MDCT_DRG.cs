namespace drg_group.taizhou_2022
{
    public class MDCT_DRG 
    {
    
        public static bool TS19_group(MedicalRecord record){
            return true;
        }
    
        public static bool TT29_group(MedicalRecord record){
            return true;
        }
    
        public static bool TR29_group(MedicalRecord record){
            return true;
        }
    
        public static bool TU19_group(MedicalRecord record){
            return true;
        }
    
        public static bool TV19_group(MedicalRecord record){
            return true;
        }
    
        public static bool TR19_group(MedicalRecord record){
            return true;
        }
    
        public static bool TS29_group(MedicalRecord record){
            return true;
        }
    
        public static bool TT19_group(MedicalRecord record){
            return true;
        }
    
        public static bool TW11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool TB11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool TW13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool TB13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool TB15_group(MedicalRecord record){
            return true;
        }
    
        public static bool TW15_group(MedicalRecord record){
            return true;
        }
    
    }
}
