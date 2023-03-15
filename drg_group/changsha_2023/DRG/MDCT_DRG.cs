namespace drg_group.changsha_2023
{
    public class MDCT_DRG 
    {
    
        public static bool TR29_group(MedicalRecord record){
            return true;
        }
    
        public static bool TS19_group(MedicalRecord record){
            return true;
        }
    
        public static bool TV19_group(MedicalRecord record){
            return true;
        }
    
        public static bool TU1A_CS_group(MedicalRecord record){
            return record.age<=6;
        }
    
        public static bool TU1B_CS_group(MedicalRecord record){
            return true;
        }
    
        public static bool TB11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool TR11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool TS21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool TT11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool TW11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool TB13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool TT23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool TW13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool TB15_group(MedicalRecord record){
            return true;
        }
    
        public static bool TR15_group(MedicalRecord record){
            return true;
        }
    
        public static bool TS25_group(MedicalRecord record){
            return true;
        }
    
        public static bool TT15_group(MedicalRecord record){
            return true;
        }
    
        public static bool TT25_group(MedicalRecord record){
            return true;
        }
    
        public static bool TW15_group(MedicalRecord record){
            return true;
        }
    
    }
}
