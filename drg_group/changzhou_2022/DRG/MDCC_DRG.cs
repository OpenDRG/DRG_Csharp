namespace drg_group.changzhou_2022
{
    public class MDCC_DRG 
    {
    
        public static bool CS10_group(MedicalRecord record){
            return record.age<=17;
        }
    
        public static bool CB29_group(MedicalRecord record){
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
    
        public static bool CR19_group(MedicalRecord record){
            return true;
        }
    
        public static bool CS19_group(MedicalRecord record){
            return true;
        }
    
        public static bool CU19_group(MedicalRecord record){
            return true;
        }
    
        public static bool CV19_group(MedicalRecord record){
            return true;
        }
    
        public static bool CW19_group(MedicalRecord record){
            return true;
        }
    
        public static bool CX19_group(MedicalRecord record){
            return true;
        }
    
        public static bool CB11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool CB31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool CZ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool CB13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CB33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CT13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CZ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CB15_group(MedicalRecord record){
            return true;
        }
    
        public static bool CB35_group(MedicalRecord record){
            return true;
        }
    
        public static bool CT15_group(MedicalRecord record){
            return true;
        }
    
        public static bool CZ15_group(MedicalRecord record){
            return true;
        }
    
    }
}
