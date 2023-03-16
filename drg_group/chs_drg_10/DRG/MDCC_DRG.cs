namespace drg_group.chs_drg_10
{
    public class MDCC_DRG 
    {
    
        public static bool CB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool CB29_group(MedicalRecord record){
            return true;
        }
    
        public static bool CB39_group(MedicalRecord record){
            return true;
        }
    
        public static bool CB49_group(MedicalRecord record){
            return true;
        }
    
        public static bool CC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool CD19_group(MedicalRecord record){
            return true;
        }
    
        public static bool CD29_group(MedicalRecord record){
            return true;
        }
    
        public static bool CJ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool CS19_group(MedicalRecord record){
            return true;
        }
    
        public static bool CU19_group(MedicalRecord record){
            return true;
        }
    
        public static bool CW19_group(MedicalRecord record){
            return true;
        }
    
        public static bool CX19_group(MedicalRecord record){
            return true;
        }
    
        public static bool CR11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool CT11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool CV11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool CZ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool CR13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CT13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CV13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CZ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CR15_group(MedicalRecord record){
            return true;
        }
    
        public static bool CT15_group(MedicalRecord record){
            return true;
        }
    
        public static bool CV15_group(MedicalRecord record){
            return true;
        }
    
        public static bool CZ15_group(MedicalRecord record){
            return true;
        }
    
    }
}
