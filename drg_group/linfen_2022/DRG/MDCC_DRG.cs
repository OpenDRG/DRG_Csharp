namespace drg_group.linfen_2022
{
    public class MDCC_DRG 
    {
    
        public static bool CB49_group(MedicalRecord record){
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
    
        public static bool CT19_group(MedicalRecord record){
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
    
        public static bool CB13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CB23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CB33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CC13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CD13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CD23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CX13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CZ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CB15_group(MedicalRecord record){
            return true;
        }
    
        public static bool CB25_group(MedicalRecord record){
            return true;
        }
    
        public static bool CB35_group(MedicalRecord record){
            return true;
        }
    
        public static bool CC15_group(MedicalRecord record){
            return true;
        }
    
        public static bool CD15_group(MedicalRecord record){
            return true;
        }
    
        public static bool CD25_group(MedicalRecord record){
            return true;
        }
    
        public static bool CX15_group(MedicalRecord record){
            return true;
        }
    
        public static bool CZ15_group(MedicalRecord record){
            return true;
        }
    
    }
}
